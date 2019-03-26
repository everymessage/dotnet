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

namespace everymessage.WebAPI.Auth
{

    /// <summary>
    /// Credential for authorizing calls to the everymessage services.
    /// </summary>
#pragma warning disable IDE1006
    public class everymessageCredential
    {
#pragma warning disable IDE1006
        private everymessageCredential(string apiKey, string secretKey)
        {
            this.ApiKey = apiKey;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// 
        /// </summary>
        internal string ApiKey { get; }

        /// <summary>
        /// 
        /// </summary>
        internal string SecretKey { get; }

        /// <summary>
        /// Creates everymessage credential instance.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        public static everymessageCredential Create(string apiKey, string secretKey)
        {
            return new everymessageCredential(apiKey, secretKey);
        }
    }
}
