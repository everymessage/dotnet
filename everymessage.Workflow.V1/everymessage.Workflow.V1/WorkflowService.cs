﻿// Copyright (c) 2019 everymessage ltd. - All Rights Reserved.
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

using everymessage.WebAPI.Auth;
using everymessage.WebAPI.Services;

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// WorkflowService class.
    /// </summary>
    internal class WorkflowService : BaseRestService
    {
        private readonly string _endPoint;

        /// <summary>
        /// Constructs new WorkflowService.
        /// </summary>
        /// <param name="endPoint"></param>
        /// <param name="credentials">everymessageCredential instance.</param>
        public WorkflowService(string endPoint, everymessageCredential credentials) : base(credentials)
        {
            _endPoint = endPoint;
        }

        /// <summary>
        /// Gets base url of the everymessage Workflow HTTP server.
        /// </summary>
        public override string BaseUrl => _endPoint;

        /// <summary>
        /// Gets current web api version.
        /// </summary>
        public override string Version => "v1";
    }
}
