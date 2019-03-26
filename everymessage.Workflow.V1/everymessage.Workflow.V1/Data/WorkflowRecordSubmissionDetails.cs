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

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkflowRecordSubmissionDetails
    {
        /// <summary>
        /// Gets primary reference;
        /// </summary>
        public string PrimaryReference { get; set; }

        /// <summary>
        /// Gets secondary reference;
        /// </summary>
        public string SecondaryReference { get; set; }

        /// <summary>
        /// Gets assigned workflow record id.
        /// </summary>
        public long WorkflowRecordId { get; set; }
    }
}
