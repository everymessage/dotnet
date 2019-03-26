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

using everymessage.WebAPI.Auth;
using everymessage.WebAPI.Services;

namespace everymessage.Smpp.V1
{
    /// <summary>
    /// 
    /// </summary>
    internal class SmppService : BaseRestService
    {
        /// <summary>
        /// Constructs new SmsService.
        /// </summary>
        /// <param name="credentials">everymessageCredential instance.</param>
        public SmppService(everymessageCredential credentials) : base(credentials) { }

        /// <summary>
        /// Gets base url of the everymessage Smpp HTTP server.
        /// </summary>
        //public override string BaseUrl => "https://sms-exchange.everymessage.com";
        //public override string BaseUrl => "http://localhost:63511";
        public override string BaseUrl => "http://172.21.1.101:5000";

        /// <summary>
        /// Gets current web api version.
        /// </summary>
        public override string Version => "v1";
    }
}
