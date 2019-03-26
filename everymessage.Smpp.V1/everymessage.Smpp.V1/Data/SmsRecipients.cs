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

using System.Linq;
using System.Collections.Generic;

namespace everymessage.Smpp.V1
{
    /// <summary>
    /// The sms phone number list.
    /// </summary>
    public class SmsRecipients : List<SmsRecipient>
    {
        /// <summary>
        /// Constructs new SmsRecipients.
        /// </summary>
        public SmsRecipients() { }

        /// <summary>
        /// Constructs new SmsRecipients with numbers initialized.
        /// </summary>
        /// <param name="numbers">Array of phone numbers.</param>
        public SmsRecipients(params string[] numbers)
        {
            this.AddRange(numbers.Select(number => new SmsRecipient(number)));
        }

        /// <summary>
        /// Constructs new SmsRecipients with numbers initialized.
        /// </summary>
        /// <param name="recipients">Array of SmsRecipient.</param>
        public SmsRecipients(params SmsRecipient[] recipients)
        {
            this.AddRange(recipients);
        }

        /// <summary>
        /// Creates new SmsRecipients instance from the string value.
        /// </summary>
        /// <param name="number">Phone number</param>
        public static implicit operator SmsRecipients(string number)
        {
            return new SmsRecipients() { new SmsRecipient(number) };
        }

       
    }

}
