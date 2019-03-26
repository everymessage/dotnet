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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using everymessage.WebAPI.Auth;

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// everymessage Workflow client implementation.
    /// </summary>
    public class WorkflowClient : IDisposable
    {

        #region Private variables

        /// <summary>
        /// 
        /// </summary>
        internal WorkflowService Service { get; set; }

        #endregion

        #region Public properties

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> CustomHeaders { get; set; }

        #endregion

        #region Create

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endPoint"></param>
        /// <param name="credential"></param>
        /// <returns></returns>
        public static WorkflowClient Create(string endPoint, everymessageCredential credential)
        {
            WorkflowClient client = new WorkflowClient
            {
                Service = new WorkflowService(endPoint, credential),
                CustomHeaders = new Dictionary<string, string>()
            };

            client.Service.CustomHeaders = client.CustomHeaders;

            return client;
        }

        #endregion

        #region SubmitRecords

        /// <summary>
        /// Submits records to the workflow server.
        /// </summary>
        /// <param name="request">Records request body.</param>
        /// <returns></returns>
        public SubmitRecordsResponse SubmitRecords(SubmitRecordsRequest request)
        {
            SubmitRecordsServiceRequest serviceRequest = new SubmitRecordsServiceRequest(
                this.Service,
                request
            );

            SubmitRecordsResponse response = serviceRequest.Execute();
            return response;
        }

        #endregion

        #region SubmitRecordsAsync

        /// <inheritdoc />
        public async Task<SubmitRecordsResponse> SubmitRecordsAsync(SubmitRecordsRequest request, CancellationToken cancellationToken = default)
        {
            SubmitRecordsServiceRequest serviceRequest = new SubmitRecordsServiceRequest(
                this.Service,
                request
            );

            return await serviceRequest.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region QueryRecords

        /// <summary>
        /// Query records from the workflow server.
        /// </summary>
        /// <param name="request">Query request.</param>
        public QueryRecordsResponse QueryRecords(QueryRecordsRequest request)
        {
            QueryRecordsServiceRequest serviceRequest = new QueryRecordsServiceRequest(
                this.Service,
                request
            );

            QueryRecordsResponse response = serviceRequest.Execute();
            return response;
        }

        #endregion

        #region QueryRecordsAsync

        /// <inheritdoc />
        public async Task<QueryRecordsResponse> QueryRecordsAsync(QueryRecordsRequest request, CancellationToken cancellationToken = default)
        {
            QueryRecordsServiceRequest serviceRequest = new QueryRecordsServiceRequest(
                this.Service,
                request
            );

            return await serviceRequest.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region DeleteRecords

        /// <summary>
        /// Delete records from the workflow server.
        /// </summary>
        /// <param name="request">Delete request.</param>
        public DeleteRecordsResponse DeleteRecords(DeleteRecordsRequest request)
        {
            DeleteRecordsServiceRequest serviceRequest = new DeleteRecordsServiceRequest(
                this.Service,
                request
            );

            DeleteRecordsResponse response = serviceRequest.Execute();
            return response;
        }

        #endregion

        #region DeleteRecordsAsync

        /// <inheritdoc />
        public async Task<DeleteRecordsResponse> DeleteRecordsAsync(DeleteRecordsRequest request, CancellationToken cancellationToken = default)
        {
            DeleteRecordsServiceRequest serviceRequest = new DeleteRecordsServiceRequest(
                this.Service,
                request
            );

            return await serviceRequest.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Dispose of this instance.
        /// </summary>
        public void Dispose() { }

        #endregion

    }
}
