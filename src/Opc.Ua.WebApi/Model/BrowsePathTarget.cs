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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.4/#5.9.4.2).
    /// </summary>
    [DataContract(Name = "BrowsePathTarget")]
    public partial class BrowsePathTarget : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowsePathTarget" /> class.
        /// </summary>
        /// <param name="targetId">targetId.</param>
        /// <param name="remainingPathIndex">remainingPathIndex (default to 0).</param>
        public BrowsePathTarget(string targetId = default(string), long remainingPathIndex = 0)
        {
            this.TargetId = targetId;
            this.RemainingPathIndex = remainingPathIndex;
        }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        [DataMember(Name = "TargetId", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or Sets RemainingPathIndex
        /// </summary>
        [DataMember(Name = "RemainingPathIndex", EmitDefaultValue = false)]
        public long RemainingPathIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrowsePathTarget {\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  RemainingPathIndex: ").Append(RemainingPathIndex).Append("\n");
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
            // RemainingPathIndex (long) maximum
            if (this.RemainingPathIndex > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for RemainingPathIndex, must be a value less than or equal to 4294967295.", new [] { "RemainingPathIndex" });
            }

            // RemainingPathIndex (long) minimum
            if (this.RemainingPathIndex < (long)0)
            {
                yield return new ValidationResult("Invalid value for RemainingPathIndex, must be a value greater than or equal to 0.", new [] { "RemainingPathIndex" });
            }

            yield break;
        }
    }

}
