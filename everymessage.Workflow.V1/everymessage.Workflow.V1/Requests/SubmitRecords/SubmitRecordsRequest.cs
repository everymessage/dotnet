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
    /// SubmitRecords request body.
    /// </summary>
    public class SubmitRecordsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BatchName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IVRServiceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TextServiceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<WorkflowRecord> Records { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DeletePendingRecords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ScheduledRunRangeStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ScheduledRunRangeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BatchTransactionConfig BatchTransaction { get; set; }
    }    
}
