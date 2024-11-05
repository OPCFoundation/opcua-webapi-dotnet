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
    /// ModificationInfo
    /// </summary>
    [DataContract(Name = "ModificationInfo")]
    public partial class ModificationInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationInfo" /> class.
        /// </summary>
        /// <param name="modificationTime">modificationTime (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="updateType">updateType.</param>
        /// <param name="userName">userName.</param>
        public ModificationInfo(DateTime modificationTime = default(DateTime), int updateType = default(int), string userName = default(string))
        {
            this.ModificationTime = modificationTime;
            this.UpdateType = updateType;
            this.UserName = userName;
        }

        /// <summary>
        /// Gets or Sets ModificationTime
        /// </summary>
        [DataMember(Name = "ModificationTime", EmitDefaultValue = false)]
        public DateTime ModificationTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateType
        /// </summary>
        [DataMember(Name = "UpdateType", EmitDefaultValue = false)]
        public int UpdateType { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "UserName", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModificationInfo {\n");
            sb.Append("  ModificationTime: ").Append(ModificationTime).Append("\n");
            sb.Append("  UpdateType: ").Append(UpdateType).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            yield break;
        }
    }

}
