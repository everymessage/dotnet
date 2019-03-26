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
using System.IO;

using Newtonsoft.Json;

namespace everymessage.WebAPI.Json
{
    /// <summary>
    /// 
    /// </summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {

        private readonly JsonSerializerSettings settings;
        private readonly JsonSerializer serializer;

        /// <summary>
        /// 
        /// </summary>
        public static NewtonsoftJsonSerializer Instance { get; } = new NewtonsoftJsonSerializer();

        /// <summary>
        /// 
        /// </summary>
        public NewtonsoftJsonSerializer() : this(CreateDefaultSettings())
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        public NewtonsoftJsonSerializer(JsonSerializerSettings settings)
        {
            this.settings = settings;
            serializer = JsonSerializer.Create(settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static JsonSerializerSettings CreateDefaultSettings()
        {
            return new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                ContractResolver = new NewtonsoftJsonContractResolver()
            };
        }

        /// <inheritdoc/>
        public string Format => "json";

        /// <inheritdoc/>
        public void Serialize(object obj, Stream target)
        {
            using (var writer = new StreamWriter(target))
            {
                if (obj == null)
                {
                    obj = string.Empty;
                }

                serializer.Serialize(writer, obj);
            }
        }

        /// <inheritdoc/>
        public string Serialize(object obj)
        {
            using (TextWriter tw = new StringWriter())
            {
                if (obj == null)
                {
                    obj = string.Empty;
                }

                serializer.Serialize(tw, obj);
                return tw.ToString();
            }
        }

        /// <inheritdoc/>
        public T Deserialize<T>(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return default;
            }
            return JsonConvert.DeserializeObject<T>(input, settings);
        }

        /// <inheritdoc/>
        public object Deserialize(string input, Type type)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            return JsonConvert.DeserializeObject(input, type, settings);
        }

        /// <inheritdoc/>
        public T Deserialize<T>(Stream input)
        {
            using (StreamReader streamReader = new StreamReader(input))
            {
                return (T)serializer.Deserialize(streamReader, typeof(T));
            }
        }
    }
}
