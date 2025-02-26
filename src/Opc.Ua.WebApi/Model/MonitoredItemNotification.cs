/*
 * OPC UA Web API
 *
 * Provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Opc.Ua.WebApi.Client.OpenAPIDateConverter;

namespace Opc.Ua.WebApi.Model
{
    /// <summary>
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.25.2).
    /// </summary>
    [DataContract(Name = "MonitoredItemNotification")]
    public partial class MonitoredItemNotification : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoredItemNotification" /> class.
        /// </summary>
        /// <param name="clientHandle">clientHandle (default to 0).</param>
        /// <param name="value">value.</param>
        public MonitoredItemNotification(long clientHandle = 0, DataValue value = default(DataValue))
        {
            this.ClientHandle = clientHandle;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets ClientHandle
        /// </summary>
        [DataMember(Name = "ClientHandle", EmitDefaultValue = false)]
        public long ClientHandle { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public DataValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonitoredItemNotification {\n");
            sb.Append("  ClientHandle: ").Append(ClientHandle).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ClientHandle (long) maximum
            if (this.ClientHandle > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for ClientHandle, must be a value less than or equal to 4294967295.", new [] { "ClientHandle" });
            }

            // ClientHandle (long) minimum
            if (this.ClientHandle < (long)0)
            {
                yield return new ValidationResult("Invalid value for ClientHandle, must be a value greater than or equal to 0.", new [] { "ClientHandle" });
            }

            yield break;
        }
    }

}
