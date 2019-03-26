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
using System.Collections.Generic;

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// WorkflowEmailInformation class.
    /// </summary>
    public class WorkflowEmailInformation
    {
        /// <summary>
        /// Gets this email reference.
        /// </summary>
        public string Reference { get; internal set; }

        /// <summary>
        /// Gets email address this email is sent from.
        /// </summary>
        public string From { get; internal set; }

        /// <summary>
        /// Gets list of email addresses this email is sent to.
        /// </summary>
        public List<string> To { get; internal set; }

        /// <summary>
        /// Gets if this email is sent.
        /// If this value is null/missing it means the email is still in the preprocessing queue.
        /// </summary>
        public bool? Sent { get; internal set; }

        /// <summary>
        /// Gets email sent date.
        /// If this value is null/missing it means the email is still in the preprocessing queue.
        /// </summary>
        public DateTime? SentDate { get; internal set; }

        /// <summary>
        /// Gets if email delivery failed.
        /// If this value is null/missing it means email is sent or failure notification is still not received.
        /// </summary>
        public bool? DeliveryFailure { get; internal set; }

        /// <summary>
        /// Gets email delivery failure date.
        /// If this value is null/missing it means email is sent or failure notification is still not received.
        /// </summary>
        public DateTime? DeliveryFailureDate { get; internal set; }

        /// <summary>
        /// Gets email delivery failure message from the smtp server.
        /// If this value is null/missing it means email is sent or failure notification is still not received.
        /// </summary>
        public string DeliveryFailureMessage { get; internal set; }
    }
}
