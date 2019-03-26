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

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// QueryRecords request body.
    /// </summary>
    public class QueryRecordsRequest
    {
        /// <summary>
        /// List of workflow record id's.
        /// </summary>
        public List<long> Records { get; set; }

        /// <summary>
        /// Gets or sets if response should include record activities as well.
        /// </summary>
        public bool IncludeActivities { get; set; }

        /// <summary>
        /// Gets or sets if response should include record repository data as well.
        /// </summary>
        public bool IncludeRepositoryData { get; set; }

        /// <summary>
        /// Gets or sets if response should include record text status information as well.
        /// </summary>
        public bool IncludeSmsInformation { get; set; }

        /// <summary>
        /// Gets or sets if response should include record email status information as well.
        /// </summary>
        public bool IncludeEmailInformation { get; set; }
    }    
}
