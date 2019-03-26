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
    /// 
    /// </summary>
    public class WorkflowRecordInformation
    {
        /// <summary>
        /// 
        /// </summary>
        public string DataReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PrimaryReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowRecordProcessingStatus ProcessingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Activities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<WorkflowRepositoryEntry> RepositoryEntries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<WorkflowSmsInformation> SentSmsMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<WorkflowEmailInformation> SentEmailDocuments { get; set; }
    }
}
