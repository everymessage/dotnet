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
using Newtonsoft.Json;

namespace everymessage.Smpp.V1
{
    /// <summary>
    /// The remote SIM sms message.
    /// </summary>
    public class RemoteSimSmsMessage
    {

        /// <summary>
        /// REQUIRED. 
        /// Gets or sets sender's number. 
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// REQUIRED. 
        /// Gets or sets recipient's number. 
        /// </summary>

        public string Recipient { get; set; }

        /// <summary>
        /// OPTIONAL. 
        /// Gets or sets message encoding. 
        /// Default is SMSC Default Alphabet.
        /// </summary>
        public SmsEncoding? Encoding { get; set; }

        /// <summary>
        /// REQUIRED. 
        /// Gets or sets sms message content.
        /// </summary>
        public string Content { get; set; }


        /// <summary>
        /// REQUIRED. 
        /// Gets or sets sms tlv.
        /// </summary>
        public string TLV { get; set; }
    }
}
