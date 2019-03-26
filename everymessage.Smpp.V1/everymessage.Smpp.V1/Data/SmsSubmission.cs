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

namespace everymessage.Smpp.V1
{

    /// <summary>
    /// The sms submission.
    /// </summary>
    public class SmsSubmission
    {
        /// <summary>
        /// Gets submission id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets submission reference.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets submission status.
        /// </summary>
        public SmsSubmissionStatus Status { get; set; }

        /// <summary>
        /// Gets submission recipient.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets submission originator.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets message body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets number of message segments.
        /// </summary>
        public byte? Segments { get; set; }

        /// <summary>
        /// Gets how much this request was charged.
        /// </summary>
        public decimal? Charged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id: {Id} ¦ To: {To} ¦ Ref: {Reference} ¦ Sta: {Status} ¦ Charged: {Charged} ¦ Msg: {Body}";
        }

    }

}
