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

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// WorkflowVariable class.
    /// </summary>
    public class WorkflowVariable
    {

        #region Name

        /// <summary>
        /// Gets or sets variable name.
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Value

        /// <summary>
        /// Gets or sets variable value.
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Blob

        /// <summary>
        /// Gets or sets blob object.
        /// </summary>
        public BlobData Blob { get; set; }

        #endregion

        #region Create

        /// <summary>
        /// Creates new WorkflowVariable instance.
        /// </summary>
        /// <param name="variableName">Variable name.</param>
        /// <param name="variableValue">Variable value</param>
        public static WorkflowVariable Create(string variableName, object variableValue)
        {
            if (string.IsNullOrWhiteSpace(variableName))
            {
                throw new ArgumentNullException(nameof(variableName));
            }

            string stringValue = string.Empty;

            if (variableValue != null)
            {
                stringValue = variableValue.ToString();
            }

            return new WorkflowVariable() { Name = variableName, Value = stringValue };
        }

        #endregion

        #region FromStream

        /// <summary>
        /// Creates workflow variable from Stream.
        /// </summary>
        /// <param name="variableName">Variable name.</param>
        /// <param name="stream">Stream instance.</param>
        public static WorkflowVariable FromStream(string variableName, Stream stream)
        {
            return new WorkflowVariable()
            {
                Name = variableName,
                Blob = BlobData.FromStream(stream)
            };
        }

        #endregion

        #region FromFileStream

        /// <summary>
        /// Creates workflow variable from FileStream.
        /// </summary>
        /// <param name="variableName">Variable name.</param>
        /// <param name="stream">FileStream instance.</param>
        public static WorkflowVariable FromFileStream(string variableName, FileStream stream)
        {
            return new WorkflowVariable()
            {
                Name = variableName,
                Blob = BlobData.FromFileStream(stream)
            };
        }

        #endregion

    }
}
