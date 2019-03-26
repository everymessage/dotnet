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

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// WorkflowSmsInformation class.
    /// </summary>
    public class WorkflowSmsInformation
    {
        /// <summary>
        /// Gets sms message reference.
        /// </summary>
        public string Reference { get; internal set; }

        /// <summary>
        /// Gets sms message originator.
        /// </summary>
        public string Originator { get; internal set; }

        /// <summary>
        /// Gets sms message destination phone number.
        /// </summary>
        public string To { get; internal set; }

        /// <summary>
        /// Gets if sms message is sent.
        /// If this value is null/missing it means the message is still in the preprocessing queue.
        /// </summary>
        public bool? Sent { get; internal set; }

        /// <summary>
        /// Gets sms message sent date.
        /// If this value is null/missing it means the message is still in the preprocessing queue.
        /// </summary>
        public DateTime? SentDate { get; internal set; }

        /// <summary>
        /// Gets if sms message is delivered.
        /// If the value is null/missing it means that delivery notification is still not received.
        /// </summary>
        public bool? Delivered { get; internal set; }

        /// <summary>
        /// Gets sms message delivery code.
        /// If the value is null/missing it means that delivery notification is still not received.
        /// </summary>
        public int? DeliveryCode { get; internal set; }

        /// <summary>
        /// Gets sms message delivery notification date.
        /// If the value is null/missing it means that delivery notification is still not received.
        /// </summary>
        public DateTime? DeliveryDate { get; internal set; }
    }
}
