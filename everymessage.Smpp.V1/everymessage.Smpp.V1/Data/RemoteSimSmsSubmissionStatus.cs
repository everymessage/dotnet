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
    public enum RemoteSimSmsSubmissionStatus : byte
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
        /// Submission failure - sender mobile number is missing or not valid.
        /// </summary>
        [EnumMember(Value = "INVALID_SENDER_MOBILE_NUMBER")]
        InvalidSenderMobileNumber = 2,

        /// <summary>
        /// Submission failure - recipient mobile number is missing or not valid.
        /// </summary>
        [EnumMember(Value = "INVALID_RECIPIENT_MOBILE_NUMBER")]
        InvalidRecipientMobileNumber = 3,

        /// <summary>
        /// Submission failure - this encoding is not supported.
        /// </summary>
        [EnumMember(Value = "ENCODING_NOT_SUPPORTED")]
        EncodingNotSupported = 4,

        /// <summary>
        /// Submission failure - this message contains too much segments.
        /// </summary>
        [EnumMember(Value = "TOO_MANY_SEGMENTS")]
        TooManySegments = 5
    }

}
