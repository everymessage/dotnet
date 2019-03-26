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

namespace everymessage.WebAPI
{
    /// <summary>
    /// List of possible status reasons.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseStatusReason : byte
    {
        /// <summary>
        /// No failure.
        /// </summary>
        [EnumMember(Value = "")]
        None = 0,

        /// <summary>
        /// Unknown failure.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown = 1,

        /// <summary>
        /// Processing failure.
        /// </summary>
        [EnumMember(Value = "PROCESSING_FAILURE")]
        ProcessingFailure = 2,

        /// <summary>
        /// Invalid parameter is passed in.
        /// </summary>
        [EnumMember(Value = "INVALID_PARAMETER")]
        InvalidParameter = 3,

        /// <summary>
        /// The parameter value is missing.
        /// </summary>
        [EnumMember(Value = "MISSING_PARAMETER")]
        MissingParameter = 4,

        /// <summary>
        /// Insufficient data.
        /// </summary>
        [EnumMember(Value = "INSUFFICIENT_DATA")]
        InsufficientData = 5,

        /// <summary>
        /// Request is not authorised.
        /// </summary>
        [EnumMember(Value = "UNAUTHORIZED")]
        Unauthorized = 6,

        /// <summary>
        /// Request is forbidden.
        /// </summary>
        [EnumMember(Value = "FORBIDDEN")]
        Forbidden = 7,

        /// <summary>
        /// API call quota exceeded.
        /// </summary>
        [EnumMember(Value = "API_CALL_QUOTA_EXCEEDED")]
        ApiCallQuotaExceeded = 8,

        /// <summary>
        /// Request is blocked.
        /// </summary>
        [EnumMember(Value = "BLOCKED")]
        Blocked = 9,

        /// <summary>
        /// Company is blocked.
        /// </summary>
        [EnumMember(Value = "COMPANY_BLOCKED")]
        CompanyBlocked = 10,

        /// <summary>
        /// There is no enough credits to actualise this request.
        /// </summary>
        [EnumMember(Value = "INSUFFICIENT_CREDITS")]
        InsufficientCredits = 11,

        /// <summary>
        /// Daily limit is reached.
        /// </summary>
        [EnumMember(Value = "DAILY_LIMIT_REACHED")]
        DailyCreditLimitReached = 12,

        /// <summary>
        /// Company daily limit is reached.
        /// </summary>
        [EnumMember(Value = "COMPANY_DAILY_LIMIT_REACHED")]
        CompanyDailyCreditLimitReached = 13
    }
}
