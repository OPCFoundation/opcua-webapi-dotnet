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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.4/#5.11.4.2).
    /// </summary>
    [DataContract(Name = "WriteValue")]
    public partial class WriteValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteValue" /> class.
        /// </summary>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="attributeId">attributeId (default to 0).</param>
        /// <param name="indexRange">indexRange.</param>
        /// <param name="value">value.</param>
        public WriteValue(string nodeId = default(string), long attributeId = 0, string indexRange = default(string), DataValue value = default(DataValue))
        {
            this.NodeId = nodeId;
            this.AttributeId = attributeId;
            this.IndexRange = indexRange;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "NodeId", EmitDefaultValue = false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets AttributeId
        /// </summary>
        [DataMember(Name = "AttributeId", EmitDefaultValue = false)]
        public long AttributeId { get; set; }

        /// <summary>
        /// Gets or Sets IndexRange
        /// </summary>
        [DataMember(Name = "IndexRange", EmitDefaultValue = false)]
        public string IndexRange { get; set; }

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
            sb.Append("class WriteValue {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  AttributeId: ").Append(AttributeId).Append("\n");
            sb.Append("  IndexRange: ").Append(IndexRange).Append("\n");
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
            // AttributeId (long) maximum
            if (this.AttributeId > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for AttributeId, must be a value less than or equal to 4294967295.", new [] { "AttributeId" });
            }

            // AttributeId (long) minimum
            if (this.AttributeId < (long)0)
            {
                yield return new ValidationResult("Invalid value for AttributeId, must be a value greater than or equal to 0.", new [] { "AttributeId" });
            }

            yield break;
        }
    }

}
