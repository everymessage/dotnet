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

using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

using everymessage.WebAPI.Auth;
using everymessage.WebAPI.Http;
using everymessage.WebAPI.Json;

namespace everymessage.WebAPI.Services
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseRestService
    {

        internal everymessageCredential Credentials { get; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string,string> CustomHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        internal ConfigurableHttpClient HttpClient { get; }

        /// <summary>
        /// 
        /// </summary>
        public ISerializer Serializer { get; }

        /// <summary>
        /// 
        /// </summary>
        protected BaseRestService(everymessageCredential credentials)
        {
            this.Credentials = credentials;
            this.HttpClient = HttpClientFactory.CreateClient();
            this.Serializer = new NewtonsoftJsonSerializer(
                new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.None,
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Converters = new List<JsonConverter>()
                    {
                        new StringEnumConverter()
                    }
            }); 
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract string BaseUrl { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract string Version { get;  }


    }

}
