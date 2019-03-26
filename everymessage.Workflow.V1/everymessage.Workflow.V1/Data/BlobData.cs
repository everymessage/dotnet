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

using System.IO;

namespace everymessage.Workflow.V1
{
    /// <summary>
    /// BlobData class.
    /// </summary>
    public class BlobData
    {

        #region Name

        /// <summary>
        /// Gets or sets blob name.
        /// This is usually a file name.
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region MimeType

        /// <summary>
        /// Gets or sets blob mime type.
        /// </summary>
        public string MimeType { get; set; }

        #endregion

        #region Buffer

        /// <summary>
        /// Gets or sets data buffer.
        /// </summary>
        public byte[] Buffer { get; set; }

        #endregion

        #region FromFileStream

        /// <summary>
        /// Creates new BlobData from FileStream.
        /// </summary>
        /// <param name="stream">Instance of FileStream.</param>
        public static BlobData FromFileStream(FileStream stream)
        {
            BlobData bd = FromStream(stream);
            bd.Name = Path.GetFileName(stream.Name);
            return bd;
        }

        #endregion

        #region FromStream

        /// <summary>
        /// Creates new BlobData from Stream object.
        /// </summary>
        /// <param name="stream">Instance of Stream.</param>
        public static BlobData FromStream(Stream stream)
        {
            byte[] buffer = null;

            if (stream != null)
            {
                if (stream.CanRead)
                {
                    if (stream is MemoryStream)
                    {
                        buffer = ((MemoryStream)stream).ToArray();
                    }
                    else
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            stream.CopyTo(memoryStream);
                            buffer = memoryStream.ToArray();
                        }
                    }
                }
            }

            return new BlobData() { Buffer = buffer };
        }

        #endregion

    }
}
