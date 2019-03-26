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

namespace everymessage.Smpp.V1
{
    /// <summary>
    /// List of possible sms encodings.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmsEncoding : byte
    {
        /// <summary>
        /// SMSC Default Alphabet
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        Default = 0,

        /// <summary>
        /// Latin 1 (ISO-8859-1)
        /// </summary>
        [EnumMember(Value = "LATIN1")]
        Latin1 = 1,

        /// <summary>
        /// Unicode.
        /// </summary>
        [EnumMember(Value = "UNICODE")]
        Unicode = 2
    }

}
