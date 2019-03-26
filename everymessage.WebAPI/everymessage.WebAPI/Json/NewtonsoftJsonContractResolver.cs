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
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;
using System.Linq;

namespace everymessage.WebAPI.Json
{
    /// <summary>
    /// 
    /// </summary>
    public class NewtonsoftJsonContractResolver : DefaultContractResolver
    {
        private static readonly JsonConverter DateTimeConverter = new RFC3339DateTimeConverter();
        private static readonly JsonConverter ExplicitNullConverter = new ExplicitNullConverter();

        /// <inheritdoc />
        protected override JsonContract CreateContract(Type objectType)
        {
            JsonContract contract = base.CreateContract(objectType);

            if (DateTimeConverter.CanConvert(objectType))
            {
                contract.Converter = DateTimeConverter;
            }
            else if (ExplicitNullConverter.CanConvert(objectType))
            {
                contract.Converter = ExplicitNullConverter;
            }

            return contract;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class RFC3339DateTimeConverter : JsonConverter
    {
        /// <inheritdoc/>
        public override bool CanRead
        {
            get
            {
                return false;
            }
        }

        /// <inheritdoc/>
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false.");
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) || objectType == typeof(Nullable<DateTime>);
        }
        
        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                serializer.Serialize(writer, Utilities.ConvertToRFC3339(date));
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ExplicitNullConverter : JsonConverter
    {
        /// <inheritdoc />
        public override bool CanRead
        {
            get
            {
                return false;
            }
        }

        /// <inheritdoc />
        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().GetCustomAttributes(typeof(JsonExplicitNullAttribute), false).Any();
        }

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false.");
        }

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteNull();
        }
    }
}
