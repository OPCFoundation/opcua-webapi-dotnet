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
    /// DataChangeFilter
    /// </summary>
    [DataContract(Name = "DataChangeFilter")]
    public partial class DataChangeFilter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataChangeFilter" /> class.
        /// </summary>
        /// <param name="trigger">trigger.</param>
        /// <param name="deadbandType">deadbandType (default to 0).</param>
        /// <param name="deadbandValue">deadbandValue (default to 0D).</param>
        public DataChangeFilter(int trigger = default(int), long deadbandType = 0, double deadbandValue = 0D)
        {
            this.Trigger = trigger;
            this.DeadbandType = deadbandType;
            this.DeadbandValue = deadbandValue;
        }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "Trigger", EmitDefaultValue = false)]
        public int Trigger { get; set; }

        /// <summary>
        /// Gets or Sets DeadbandType
        /// </summary>
        [DataMember(Name = "DeadbandType", EmitDefaultValue = false)]
        public long DeadbandType { get; set; }

        /// <summary>
        /// Gets or Sets DeadbandValue
        /// </summary>
        [DataMember(Name = "DeadbandValue", EmitDefaultValue = false)]
        public double DeadbandValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataChangeFilter {\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  DeadbandType: ").Append(DeadbandType).Append("\n");
            sb.Append("  DeadbandValue: ").Append(DeadbandValue).Append("\n");
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
            // DeadbandType (long) maximum
            if (this.DeadbandType > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for DeadbandType, must be a value less than or equal to 4294967295.", new [] { "DeadbandType" });
            }

            // DeadbandType (long) minimum
            if (this.DeadbandType < (long)0)
            {
                yield return new ValidationResult("Invalid value for DeadbandType, must be a value greater than or equal to 0.", new [] { "DeadbandType" });
            }

            yield break;
        }
    }

}
