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

namespace everymessage.WebAPI.Requests
{
    /// <summary>
    /// Set of request methods to indicate the desired action to be performed for a given resource.
    /// </summary>
    public enum RestRequestHttpMethod : byte
    {
        /// <summary>
        /// The GET method requests a representation of the specified resource. Requests using GET should only retrieve data.
        /// </summary>
        [StringValue("GET")]
        GET = 0,

        /// <summary>
        /// The HEAD method asks for a response identical to that of a GET request, but without the response body.
        /// </summary>
        [StringValue("HEAD")]
        HEAD = 1,

        /// <summary>
        /// The POST method is used to submit an entity to the specified resource, often causing a change in state or side effects on the server.
        /// </summary>
        [StringValue("POST")]
        POST = 2,

        /// <summary>
        /// The PUT method replaces all current representations of the target resource with the request payload.
        /// </summary>
        [StringValue("PUT")]
        PUT = 3,

        /// <summary>
        /// The DELETE method deletes the specified resource.
        /// </summary>
        [StringValue("DELETE")]
        DELETE = 4,

        /// <summary>
        /// The CONNECT method establishes a tunnel to the server identified by the target resource.
        /// </summary>
        [StringValue("CONNECT")]
        CONNECT = 5,

        /// <summary>
        /// The OPTIONS method is used to describe the communication options for the target resource.
        /// </summary>
        [StringValue("OPTIONS")]
        OPTIONS = 6,

        /// <summary>
        /// The TRACE method performs a message loop-back test along the path to the target resource.
        /// </summary>
        [StringValue("TRACE")]
        TRACE = 7,

        /// <summary>
        /// The PATCH method is used to apply partial modifications to a resource.
        /// </summary>
        [StringValue("PATCH")]
        PATCH = 8
    }
}