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

using everymessage.WebAPI.Requests;
using everymessage.WebAPI.Services;

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// Makes request towards everymessage workflow HTTP server.
    /// </summary>
    internal class QueryRecordsServiceRequest : WorkflowServiceRequest<QueryRecordsResponse>
    {

        private readonly QueryRecordsRequest _body;

        /// <summary>
        /// Constructs a new request.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="body"></param>
        public QueryRecordsServiceRequest(BaseRestService service, QueryRecordsRequest body) : base(service)
        {
            _body = body;
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string BaseUrl { get => this.Service.BaseUrl; }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string Version { get => this.Service.Version; }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string MethodName { get => "records/query"; }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override RestRequestHttpMethod HttpMethod => RestRequestHttpMethod.POST;

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override object GetBody()
        {
            return _body;
        }
    }


}
