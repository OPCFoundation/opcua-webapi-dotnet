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
    /// ReadEventDetails2
    /// </summary>
    [DataContract(Name = "ReadEventDetails2")]
    public partial class ReadEventDetails2 : IEquatable<ReadEventDetails2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadEventDetails2" /> class.
        /// </summary>
        /// <param name="readModified">readModified.</param>
        public ReadEventDetails2(bool readModified = default(bool))
        {
            this.ReadModified = readModified;
        }

        /// <summary>
        /// Gets or Sets ReadModified
        /// </summary>
        [DataMember(Name = "ReadModified", EmitDefaultValue = true)]
        public bool ReadModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadEventDetails2 {\n");
            sb.Append("  ReadModified: ").Append(ReadModified).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReadEventDetails2);
        }

        /// <summary>
        /// Returns true if ReadEventDetails2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadEventDetails2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadEventDetails2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReadModified == input.ReadModified ||
                    this.ReadModified.Equals(input.ReadModified)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.ReadModified.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}