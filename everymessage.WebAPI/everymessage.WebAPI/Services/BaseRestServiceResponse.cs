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
using Newtonsoft.Json;

namespace everymessage.WebAPI.Services
{

    /// <summary>
    /// Base rest API response class.
    /// </summary>
    public class BaseRestServiceResponse<T>
    {

        #region ApiName

        /// <summary>
        /// Gets API name.
        /// </summary>
        public string ApiName { get; set; }

        #endregion

        #region ApiVersion

        /// <summary>
        /// Gets API version.
        /// </summary>
        public string ApiVersion { get; set; }

        #endregion

        #region ApiTime

        /// <summary>
        /// Gets API server time.
        /// </summary>
        public DateTime ApiTime { get; set; }

        #endregion

        #region ApiState

        /// <summary>
        /// Gets API state.
        /// </summary>
        public string ApiState { get; set; }

        #endregion

        #region ResponseStatusCode

        /// <summary>
        /// Gets API response status code (common HTTP status code). 
        /// </summary>
        public int ResponseStatusCode { get; set; }

        #endregion

        #region Status

        /// <summary>
        /// Gets API response status. 
        /// If «ResponseStatusCode» is 200 it will return 'Success', all other «ResponseStatusCode» codes will return 'Failure'.
        /// </summary>
        [JsonIgnore]
        public ResponseStatus Status
        {
            get
            {
                return this.ResponseStatusCode == 200 ? ResponseStatus.Success : ResponseStatus.Failure;
            }
        }

        #endregion

        #region ResponseStatusReason

        /// <summary>
        /// Gets API response status reason.
        /// If «ResponseStatusCode» is other than 200, this property will contain more precise status reason.
        /// </summary>
        public ResponseStatusReason ResponseStatusReason { get; set; }

        #endregion

        #region ResponseStatusMessage

        /// <summary>
        /// Gets API response status message.
        /// </summary>
        public string ResponseStatusMessage { get; set; }

        #endregion

        #region Body

        /// <summary>
        /// Gets API response body.
        /// </summary>
        public T Body { get; set; }

        #endregion

        #region ProcessingTime

        /// <summary>
        /// Gets processing time in milliseconds.
        /// </summary>
        public int ProcessingTime { get; set; }

        #endregion

    }
}
