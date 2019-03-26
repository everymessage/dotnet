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
using Newtonsoft.Json;

namespace everymessage.Smpp.V1
{

    /// <summary>
    /// The sms recipient.
    /// </summary>
    public class SmsRecipient : IEquatable<SmsRecipient>
    {
        /// <summary>
        /// Constructs new SmsRecipient with number initialized.
        /// </summary>
        /// <param name="number">Phone number.</param>
        public SmsRecipient(string number)
        {
            this.Number = number;
        }

        /// <summary>
        /// Constructs new SmsRecipient with number and variable data initialized.
        /// </summary>
        /// <param name="reference">Your unique reference to the message for traceability.</param>
        /// <param name="number">Phone number.</param>
        /// <param name="variableData">Array of variable data.</param>
        public SmsRecipient(string reference, string number, params string[] variableData) : this(number)
        {
            this.Reference = reference;
            this.VariableData = variableData;
        }

        /// <summary>
        /// OPTIONAL. 
        /// Gets or sets message reference. 
        /// This is your unique reference to the message for traceability.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// REQUIRED. 
        /// Gets or sets sms phone number.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// OPTIONAL. 
        /// Gets or sets sms variable data.
        /// This is usually used to do sms message body merge.
        /// </summary>
        public string[] VariableData { get; set; }

        /// <summary>
        /// Determines whether the specified SmsRecipient is equal to the current SmsRecipient.
        /// </summary>
        /// <param name="other">Instance of SmsRecipient.</param>
        /// <returns></returns>
        public bool Equals(SmsRecipient other)
        {
            if (other == null)
            {
                return false;
            }

            bool equals = object.Equals(this.Reference, other.Reference);

            equals = equals && object.Equals(this.Number, other.Number);
           
            if (this.VariableData != null & other.VariableData != null)
            {
                equals = equals && this.VariableData.SequenceEqual(other.VariableData);
            }
            else
            {
                equals = equals && object.Equals(this.VariableData, other.VariableData);
            }

            return equals;
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as SmsRecipient);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (this.Reference != null ? this.Reference.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (this.Number != null ? this.Number.GetHashCode() : 0);

                if (this.VariableData != null)
                {
                    foreach(string vd in this.VariableData)
                    {
                        if (vd != null)
                        {
                            hash = (hash * HashingMultiplier) ^ (this.Number != null ? vd.GetHashCode() : 0);
                        }
                    }
                }

                return hash;
            }
        }

#pragma warning disable IDE0041

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public static bool operator ==(SmsRecipient number1, SmsRecipient number2)
        {
            if (object.ReferenceEquals(number1, null) && !object.ReferenceEquals(number2, null))
            {
                return false;
            }

            if (object.ReferenceEquals(number2, null) && !object.ReferenceEquals(number1, null))
            {
                return false;
            }

            if (object.ReferenceEquals(number1, null) && object.ReferenceEquals(number2, null))
            {
                return true;
            }

            return number1.Equals(number2);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public static bool operator !=(SmsRecipient number1, SmsRecipient number2)
        {
            if (object.ReferenceEquals(number1, null) && !object.ReferenceEquals(number2, null))
            {
                return true;
            }

            if (object.ReferenceEquals(number2, null) && !object.ReferenceEquals(number1, null))
            {
                return true;
            }

            if (object.ReferenceEquals(number1, null) && object.ReferenceEquals(number2, null))
            {
                return false;
            }

            return !number1.Equals(number2);
        }

#pragma warning restore IDE0041

        /// <summary>
        /// Creates new SmsRecipient instance from the string value.
        /// </summary>
        /// <param name="number">Phone number</param>
        public static implicit operator SmsRecipient(string number)
        {
            return new SmsRecipient(number);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string ToString()
        {
            return this.Number;
        }
    }

}
