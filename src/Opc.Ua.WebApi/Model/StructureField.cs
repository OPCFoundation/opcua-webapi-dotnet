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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part5/12.2.12/#12.2.12.10).
    /// </summary>
    [DataContract(Name = "StructureField")]
    public partial class StructureField : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureField" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="valueRank">valueRank (default to 0).</param>
        /// <param name="arrayDimensions">arrayDimensions.</param>
        /// <param name="maxStringLength">maxStringLength (default to 0).</param>
        /// <param name="isOptional">isOptional (default to false).</param>
        public StructureField(string name = default(string), LocalizedText description = default(LocalizedText), string dataType = default(string), int valueRank = 0, List<long> arrayDimensions = default(List<long>), long maxStringLength = 0, bool isOptional = false)
        {
            this.Name = name;
            this.Description = description;
            this.DataType = dataType;
            this.ValueRank = valueRank;
            this.ArrayDimensions = arrayDimensions;
            this.MaxStringLength = maxStringLength;
            this.IsOptional = isOptional;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public LocalizedText Description { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "DataType", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets ValueRank
        /// </summary>
        [DataMember(Name = "ValueRank", EmitDefaultValue = false)]
        public int ValueRank { get; set; }

        /// <summary>
        /// Gets or Sets ArrayDimensions
        /// </summary>
        [DataMember(Name = "ArrayDimensions", EmitDefaultValue = false)]
        public List<long> ArrayDimensions { get; set; }

        /// <summary>
        /// Gets or Sets MaxStringLength
        /// </summary>
        [DataMember(Name = "MaxStringLength", EmitDefaultValue = false)]
        public long MaxStringLength { get; set; }

        /// <summary>
        /// Gets or Sets IsOptional
        /// </summary>
        [DataMember(Name = "IsOptional", EmitDefaultValue = true)]
        public bool IsOptional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StructureField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ValueRank: ").Append(ValueRank).Append("\n");
            sb.Append("  ArrayDimensions: ").Append(ArrayDimensions).Append("\n");
            sb.Append("  MaxStringLength: ").Append(MaxStringLength).Append("\n");
            sb.Append("  IsOptional: ").Append(IsOptional).Append("\n");
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
            // MaxStringLength (long) maximum
            if (this.MaxStringLength > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for MaxStringLength, must be a value less than or equal to 4294967295.", new [] { "MaxStringLength" });
            }

            // MaxStringLength (long) minimum
            if (this.MaxStringLength < (long)0)
            {
                yield return new ValidationResult("Invalid value for MaxStringLength, must be a value greater than or equal to 0.", new [] { "MaxStringLength" });
            }

            yield break;
        }
    }

}
