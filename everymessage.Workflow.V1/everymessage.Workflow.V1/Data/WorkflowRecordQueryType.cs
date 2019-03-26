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

using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// Workflow records query type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowRecordQueryType : byte
    {
        /// <summary>
        /// Query all records.
        /// </summary>
        [EnumMember(Value = "ANY")]
        Any = 0,

        /// <summary>
        /// Query only pending records.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending = 1,

        /// <summary>
        /// Query only processed records.
        /// </summary>
        [EnumMember(Value = "PROCESSED")]
        Processed = 2
    }


}
