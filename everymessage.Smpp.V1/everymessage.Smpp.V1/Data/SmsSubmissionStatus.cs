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
    /// List of sms submission statuses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmsSubmissionStatus : byte
    {
        /// <summary>
        /// Submission failure - system error.
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        Failure = 0,

        /// <summary>
        /// Submission success.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success = 1,

        /// <summary>
        /// Submission failure - the mobile number is missing.
        /// </summary>
        [EnumMember(Value = "MISSING_MOBILE_NUMBER")]
        MissingMobileNumber = 2,

        /// <summary>
        /// Submission failure - the mobile number is invalid.
        /// </summary>
        [EnumMember(Value = "INVALID_MOBILE_NUMBER")]
        InvalidMobileNumber = 3,

        /// <summary>
        /// Submission failure - the mobile number is blocked.
        /// </summary>
        [EnumMember(Value = "BLOCKED_MOBILE_NUMBER")]
        BlockedMobileNumber = 4,

        /// <summary>
        /// Submission failure - the message body is missing.
        /// </summary>
        [EnumMember(Value = "EMPTY_MESSAGE")]
        EmptyMessage = 5,

        /// <summary>
        /// Submission failure - message already exists in this batch.
        /// </summary>
        [EnumMember(Value = "DUPLICATED_MESSAGE")]
        DuplicatedMessage = 6,

        /// <summary>
        /// Submission failure - this originator is not allowed.
        /// </summary>
        [EnumMember(Value = "ORIGINATOR_NOT_ALLOWED")]
        OriginatorNotAllowed = 7,

        /// <summary>
        /// Submission failure - this route is not supported.
        /// </summary>
        [EnumMember(Value = "ROUTE_NOT_SUPPORTED")]
        RouteNotSupported = 8,

        /// <summary>
        /// Submission failure - this encoding is not supported.
        /// </summary>
        [EnumMember(Value = "ENCODING_NOT_SUPPORTED")]
        EncodingNotSupported = 9,

        /// <summary>
        /// Submission failure - this message contains too much segments.
        /// </summary>
        [EnumMember(Value = "TOO_MANY_SEGMENTS")]
        TooManySegments = 10
    }

}
