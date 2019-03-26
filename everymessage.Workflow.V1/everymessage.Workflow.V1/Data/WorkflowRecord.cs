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
    /// 
    /// </summary>
    public class WorkflowRecord
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ScheduledRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<WorkflowVariable> Variables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PrimaryReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SecondaryReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public GenderType? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AlternativeEmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AlternativePhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MailingAddressLine1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MailingAddressLine2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MailingAddressLine3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MailingAddressLine4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MailingPostcode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MailingCountryISO { get; set; }
    }
}
