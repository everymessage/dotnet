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
using System.Linq;
using System.Reflection;

namespace everymessage.WebAPI
{
    /// <summary>
    /// 
    /// </summary>
    public class StringValueAttribute : Attribute
    {

        private string _value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public StringValueAttribute(string value)
        {
            _value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            get { return _value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetStringValue(Enum value)
        {
            Type type = value.GetType();
            FieldInfo fi = type.GetRuntimeField(value.ToString());
            return (fi.GetCustomAttributes(typeof(StringValueAttribute), false).FirstOrDefault() as StringValueAttribute).Value;
        }

    }
}
