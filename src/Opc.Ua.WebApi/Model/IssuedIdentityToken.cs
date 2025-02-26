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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part5/12.3.15/#12.3.15.2).
    /// </summary>
    [DataContract(Name = "IssuedIdentityToken")]
    public partial class IssuedIdentityToken : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedIdentityToken" /> class.
        /// </summary>
        /// <param name="tokenData">tokenData.</param>
        /// <param name="encryptionAlgorithm">encryptionAlgorithm.</param>
        /// <param name="policyId">policyId.</param>
        public IssuedIdentityToken(byte[] tokenData = default(byte[]), string encryptionAlgorithm = default(string), string policyId = default(string))
        {
            this.TokenData = tokenData;
            this.EncryptionAlgorithm = encryptionAlgorithm;
            this.PolicyId = policyId;
        }

        /// <summary>
        /// Gets or Sets TokenData
        /// </summary>
        [DataMember(Name = "TokenData", EmitDefaultValue = false)]
        public byte[] TokenData { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionAlgorithm
        /// </summary>
        [DataMember(Name = "EncryptionAlgorithm", EmitDefaultValue = false)]
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "PolicyId", EmitDefaultValue = false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssuedIdentityToken {\n");
            sb.Append("  TokenData: ").Append(TokenData).Append("\n");
            sb.Append("  EncryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
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
