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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.3/#6.2.3.2.6).
    /// </summary>
    [DataContract(Name = "ConfigurationVersionDataType")]
    public partial class ConfigurationVersionDataType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationVersionDataType" /> class.
        /// </summary>
        /// <param name="majorVersion">majorVersion (default to 0).</param>
        /// <param name="minorVersion">minorVersion (default to 0).</param>
        public ConfigurationVersionDataType(long majorVersion = 0, long minorVersion = 0)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        /// <summary>
        /// Gets or Sets MajorVersion
        /// </summary>
        [DataMember(Name = "MajorVersion", EmitDefaultValue = false)]
        public long MajorVersion { get; set; }

        /// <summary>
        /// Gets or Sets MinorVersion
        /// </summary>
        [DataMember(Name = "MinorVersion", EmitDefaultValue = false)]
        public long MinorVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationVersionDataType {\n");
            sb.Append("  MajorVersion: ").Append(MajorVersion).Append("\n");
            sb.Append("  MinorVersion: ").Append(MinorVersion).Append("\n");
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
            // MajorVersion (long) maximum
            if (this.MajorVersion > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for MajorVersion, must be a value less than or equal to 4294967295.", new [] { "MajorVersion" });
            }

            // MajorVersion (long) minimum
            if (this.MajorVersion < (long)0)
            {
                yield return new ValidationResult("Invalid value for MajorVersion, must be a value greater than or equal to 0.", new [] { "MajorVersion" });
            }

            // MinorVersion (long) maximum
            if (this.MinorVersion > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for MinorVersion, must be a value less than or equal to 4294967295.", new [] { "MinorVersion" });
            }

            // MinorVersion (long) minimum
            if (this.MinorVersion < (long)0)
            {
                yield return new ValidationResult("Invalid value for MinorVersion, must be a value greater than or equal to 0.", new [] { "MinorVersion" });
            }

            yield break;
        }
    }

}
