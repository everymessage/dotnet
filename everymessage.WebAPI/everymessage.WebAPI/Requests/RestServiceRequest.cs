// Copyright (c) 2019 everymessage ltd. - All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License"). You may
// not use this file except in compliance with the License. You may obtain 
// a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// engineers@everymessage.com

using System;
using System.Text;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

using everymessage.WebAPI.Services;

namespace everymessage.WebAPI.Requests
{
    /// <summary>
    /// Rest service request which supports both sync and async execution.
    /// </summary>
    public abstract class RestClientServiceRequest<TResponse>
    {
        private BaseRestService _service;

        /// <summary>
        /// Constructs a new RestClientServiceRequest.
        /// </summary>
        /// <param name="service">Service</param>
        public RestClientServiceRequest(BaseRestService service)
        {
            _service = service;
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        /// <returns></returns>
        public abstract object GetBody();

        /// <summary>
        /// Gets the base url of this request.
        /// </summary>
        public abstract string BaseUrl { get; }


        /// <summary>
        /// Gets the api version of this request.
        /// </summary>
        public abstract string Version { get; }

        /// <summary>
        /// Gets the method name of this request.
        /// </summary>
        public abstract string MethodName { get; }


        /// <summary>
        /// Gets the HTTP method of this request.
        /// </summary>
        public abstract RestRequestHttpMethod HttpMethod { get; }

        /// <summary>
        /// Gets this request service.
        /// </summary>
        public BaseRestService Service { get => _service; }

        private RestRequestBuilder CreateBuilder()
        {
            RestRequestBuilder builder = new RestRequestBuilder()
            {
                BaseUrl = this.BaseUrl,
                Version = this.Version,
                MethodName = this.MethodName,
                HttpMethod = this.HttpMethod
            };

            return builder;
        }

        /// <summary>Generates the right URL for this request.</summary>
        protected string GenerateRequestUrl()
        {
            return CreateBuilder().BuildUrl();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpRequestMessage CreateRequest()
        {
            RestRequestBuilder builder = this.CreateBuilder();
            HttpRequestMessage request = builder.CreateRequest(_service);

            HttpContent content = null;

            var mediaType = "application/" + _service.Serializer.Format;
            var serializedObject = _service.Serializer.Serialize(this.GetBody());
            content = new StringContent(serializedObject, Encoding.UTF8, mediaType);

            request.Content = content;

            return request;
        }

        /// <inheritdoc/>
        public TResponse Execute()
        {
            try
            {
                using (var response = AsyncHelper.RunSync<HttpResponseMessage>(() => ExecuteUnparsedAsync(CancellationToken.None)))
                {
                    return AsyncHelper.RunSync<TResponse>(() => ParseResponseAsync(response));
                }
            }
            catch (AggregateException aex)
            {
                // if an exception was thrown during the tasks, unwrap and throw it.
                 throw aex.InnerException ?? aex;
            }
        }

        /// <inheritdoc/>
        public async Task<TResponse> ExecuteAsync()
        {
            return await ExecuteAsync(CancellationToken.None);
        }

        /// <inheritdoc/>
        public async Task<TResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            using (var response = await ExecuteUnparsedAsync(cancellationToken).ConfigureAwait(false))
            {
                cancellationToken.ThrowIfCancellationRequested();
                return await ParseResponseAsync(response);
            }
        }

        private async Task<HttpResponseMessage> ExecuteUnparsedAsync(CancellationToken cancellationToken)
        {
            using (var request = CreateRequest())
            {
                return await _service.HttpClient.SendAsync(request, cancellationToken);
            }
        }

        private async Task<TResponse> ParseResponseAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return await DeserializeResponse<TResponse>(response);
            }
            else
            {
                return await Task.FromResult<TResponse>(default);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public virtual async Task<T> DeserializeResponse<T>(HttpResponseMessage response)
        {
            var text = await response.Content.ReadAsStringAsync();

            if (Type.Equals(typeof(T), typeof(string)))
            {
                return (T)(object)text;
            }

            T result = default;

            try
            {
                result = _service.Serializer.Deserialize<T>(text);
            }
            catch (JsonReaderException ex)
            {
                throw new Exception("Failed to parse response from server as json [" + text + "]", ex);
            }

            return result;
        }

    }
}
