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
    /// The remote SIM submission info.
    /// </summary>
    public class RemoteSimSmsSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RemoteSimSmsSubmissionStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public string Sender { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public string Recipient { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public int Segments { get; set; }
    }
}
