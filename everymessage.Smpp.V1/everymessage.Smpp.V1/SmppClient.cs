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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using everymessage.WebAPI.Auth;

namespace everymessage.Smpp.V1
{
    /// <summary>
    /// Sms client that allows sending and receiving sms messages.
    /// </summary>
    public class SmppClient : IDisposable
    {

        #region Private variables

        /// <summary>
        /// 
        /// </summary>
        internal SmppService Service { get; set; }

        #endregion

        #region Public properties

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> CustomHeaders { get; set; }

        #endregion

        #region Create

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endPoint"></param>
        /// <param name="credential"></param>
        /// <returns></returns>
        public static SmppClient Create(string endPoint, everymessageCredential credential)
        {
            SmppClient client = new SmppClient
            {
                Service = new SmppService(endPoint, credential),
                CustomHeaders = new Dictionary<string, string>()
            };

            client.Service.CustomHeaders = client.CustomHeaders;

            return client;
        }

        #endregion

        #region Submit - message

        /// <summary>
        /// Sends single Sms message.
        /// </summary>
        /// <param name="message">SmsMessage instance.</param>
        /// <returns></returns>
        public SubmitResponse Submit(SmsMessage message)
        {
            return this.Submit(new SmsMessage[] { message });
        }

        #endregion

        #region Submit - messages

        /// <summary>
        /// Sends multiple Sms messages.
        /// </summary>
        /// <param name="messages">Array of Sms message insatnces.</param>
        /// <returns></returns>
        public SubmitResponse Submit(params SmsMessage[] messages)
        {
            SubmitServiceRequest request = new SubmitServiceRequest(
                this.Service,
                new SubmitRequest()
                {
                    Messages = new List<SmsMessage>(messages)
                }
            );

            SubmitResponse response = request.Execute();
            return response;
        }

        #endregion

        #region SubmitAsync - message

        /// <inheritdoc />
        public async Task<SubmitResponse> SubmitAsync(SmsMessage message, CancellationToken cancellationToken = default)
        {
            SubmitServiceRequest request = new SubmitServiceRequest(
                this.Service,
                new SubmitRequest()
                {
                    Messages = new List<SmsMessage>() { message }
                }
            );

            return await request.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region SubmitAsync - messages

        /// <inheritdoc />
        public async Task<SubmitResponse> SubmitAsync(SmsMessage[] messages, CancellationToken cancellationToken = default)
        {
            SubmitServiceRequest request = new SubmitServiceRequest(
                this.Service,
                new SubmitRequest()
                {
                    Messages = new List<SmsMessage>(messages)
                }
            );

            return await request.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region SubmitRemoteSim - message

        /// <summary>
        /// Sends single remote Sim Sms message.
        /// </summary>
        /// <param name="message">RemoteSimSmsMessage instance.</param>
        public SubmitRemoteSimResponse SubmitRemoteSim(RemoteSimSmsMessage message)
        {
            return this.SubmitRemoteSim(new RemoteSimSmsMessage[] { message });
        }

        #endregion

        #region SubmitRemoteSim - messages

        /// <summary>
        /// Sends multiple remote Sim Sms messages.
        /// </summary>
        /// <param name="messages">Array of remote Sim Sms message instances.</param>
        public SubmitRemoteSimResponse SubmitRemoteSim(params RemoteSimSmsMessage[] messages)
        {
            RemoteSimServiceRequest request = new RemoteSimServiceRequest(
                this.Service,
                new RemoteSimRequest()
                {
                    Messages = new List<RemoteSimSmsMessage>(messages)
                }
            );

            SubmitRemoteSimResponse response = request.Execute();
            return response;
        }

        #endregion

        #region SubmitRemoteSimAsync - message

        /// <inheritdoc />
        public async Task<SubmitRemoteSimResponse> SubmitRemoteSimAsync(RemoteSimSmsMessage message, CancellationToken cancellationToken = default)
        {
            RemoteSimServiceRequest request = new RemoteSimServiceRequest(
                this.Service,
                new RemoteSimRequest()
                {
                    Messages = new List<RemoteSimSmsMessage>() { message }
                }
            );

            return await request.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region SubmitRemoteSimAsync - messages

        /// <inheritdoc />
        public async Task<SubmitRemoteSimResponse> SubmitRemoteSimAsync(RemoteSimSmsMessage[] messages, CancellationToken cancellationToken = default)
        {
            RemoteSimServiceRequest request = new RemoteSimServiceRequest(
                this.Service,
                new RemoteSimRequest()
                {
                    Messages = new List<RemoteSimSmsMessage>(messages)
                }
            );

            return await request.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Dispose of this instance.
        /// </summary>
        public void Dispose() { }

        #endregion

    }
}
