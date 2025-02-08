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
    /// [Link to specification](https://reference.opcfoundation.org/Core/Part6/v105/docs/5.4.2.17).
    /// </summary>
    [DataContract(Name = "Variant")]
    public partial class Variant : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Variant" /> class.
        /// </summary>
        /// <param name="uaType">uaType.</param>
        /// <param name="value">value.</param>
        /// <param name="dimensions">dimensions.</param>
        public Variant(int uaType = default(int), Object value = default(Object), List<int> dimensions = default(List<int>))
        {
            this.UaType = uaType;
            this.Value = value;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Gets or Sets UaType
        /// </summary>
        [DataMember(Name = "UaType", EmitDefaultValue = false)]
        public int UaType { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "Value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "Dimensions", EmitDefaultValue = false)]
        public List<int> Dimensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Variant {\n");
            sb.Append("  UaType: ").Append(UaType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
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
            // UaType (int) maximum
            if (this.UaType > (int)255)
            {
                yield return new ValidationResult("Invalid value for UaType, must be a value less than or equal to 255.", new [] { "UaType" });
            }

            // UaType (int) minimum
            if (this.UaType < (int)0)
            {
                yield return new ValidationResult("Invalid value for UaType, must be a value greater than or equal to 0.", new [] { "UaType" });
            }

            yield break;
        }
    }

}
