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

using System.Collections.Generic;
using System.Reflection;
using System.Net.Http;
using System.Net.Http.Headers;

using everymessage.WebAPI.Services;

namespace everymessage.WebAPI.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class RestRequestBuilder
    {

        /// <summary>
        /// Gets the base url of this request.
        /// </summary>
        public string BaseUrl { get; set; }


        /// <summary>
        /// Gets the api version of this request.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets the method name of this request.
        /// </summary>
        public string MethodName { get; set; }


        /// <summary>
        /// Gets the HTTP method of this request.
        /// </summary>
        public RestRequestHttpMethod HttpMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string BuildUrl()
        {
            return Utilities.CombineUrlPaths(this.BaseUrl, this.Version, this.MethodName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpRequestMessage CreateRequest(BaseRestService service)
        {
            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(StringValueAttribute.GetStringValue(this.HttpMethod)), BuildUrl());
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Utilities.EncodeCredentials(service.Credentials.ApiKey, service.Credentials.SecretKey));
            request.Headers.Add("Y-Client-Type", ".NET");
            request.Headers.Add("Y-Client-Info", service.GetType().GetTypeInfo().Assembly.FullName);

#if NETSTANDARD1_3
            request.Headers.Add("Y-Client-Platform", System.Runtime.InteropServices.RuntimeInformation.OSDescription);
#else
            request.Headers.Add("Y-Client-Platform", System.Environment.OSVersion.ToString());
#endif

            if (service.CustomHeaders != null && service.CustomHeaders.Count > 0)
            {
                foreach (var customHeader in service.CustomHeaders)
                {
                    request.Headers.Add(customHeader.Key, customHeader.Value);
                }
            }

            return request;
        }
    }
}
