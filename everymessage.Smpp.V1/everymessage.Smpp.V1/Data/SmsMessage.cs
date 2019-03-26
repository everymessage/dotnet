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

using Newtonsoft.Json;

using everymessage.WebAPI.Json;

namespace everymessage.Smpp.V1
{
    /// <summary>
    /// The sms message.
    /// </summary>
    public class SmsMessage
    {
        /// <summary>
        /// OPTIONAL. 
        /// Gets or sets message reference. 
        /// This is your unique reference to the message for traceability.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// REQUIRED. 
        /// Gets or sets originator for this message. 
        /// Originator can be 11 alpha character without space or a 12 digits number.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// REQUIRED. 
        /// Gets or sets recipient numbers. 
        /// You can set one or more recipient numbers.
        /// </summary>
        public SmsRecipients To { get; set; }

        /// <summary>
        /// OPTIONAL. 
        /// Gets or sets if message encoding. 
        /// Default is SMSC Default Alphabet.
        /// </summary>
        public SmsEncoding? Encoding { get; set; }

        /// <summary>
        /// REQUIRED. 
        /// Gets or sets sms message body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// OPTIONAL. 
        /// Gets or sets registered delivery. 
        /// Default is false.
        /// </summary>
        public bool? RegisteredDelivery { get; set; }

        /// <summary>
        /// OPTIONAL.
        /// Gets or sets custom message variable names.
        /// </summary>
        public string[] Variables { get; set; }

        /// <summary>
        /// Gets json for this sms message.
        /// </summary>
        /// <returns></returns>
        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this, JsonDefaults.DEFAULT_SERIALIZER_SETTINGS);
        }
    }
}
