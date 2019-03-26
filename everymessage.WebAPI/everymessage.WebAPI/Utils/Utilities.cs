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
using System.Text;
using System.Globalization;

namespace everymessage.WebAPI
{
    /// <summary>
    /// 
    /// </summary>
    internal class Utilities
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ConvertToRFC3339(DateTime date)
        {
            if (date.Kind == DateTimeKind.Unspecified)
            {
                date = date.ToUniversalTime();
            }

            return date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", DateTimeFormatInfo.InvariantInfo);
        }

        #region CombineUrlPaths

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string CombineUrlPaths(params string[] paths)
        {
            return paths.Aggregate(string.Empty, (current, path) => string.Format("{0}/{1}", current.TrimEnd('/'), path.TrimStart('/'))).TrimStart('/');
        }

        #endregion

        #region EncodeCredentials

        public static string EncodeCredentials(string username, string password)
        {
            var strCredentials = string.Format("{0}:{1}", username, password);
            var encodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(strCredentials));

            return encodedCredentials;
        }

        #endregion
    }
}
