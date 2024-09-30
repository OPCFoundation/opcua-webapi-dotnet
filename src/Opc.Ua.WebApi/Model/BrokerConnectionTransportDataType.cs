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
    /// BrokerConnectionTransportDataType
    /// </summary>
    [DataContract(Name = "BrokerConnectionTransportDataType")]
    public partial class BrokerConnectionTransportDataType : IEquatable<BrokerConnectionTransportDataType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrokerConnectionTransportDataType" /> class.
        /// </summary>
        /// <param name="resourceUri">resourceUri.</param>
        /// <param name="authenticationProfileUri">authenticationProfileUri.</param>
        public BrokerConnectionTransportDataType(string resourceUri = default(string), string authenticationProfileUri = default(string))
        {
            this.ResourceUri = resourceUri;
            this.AuthenticationProfileUri = authenticationProfileUri;
        }

        /// <summary>
        /// Gets or Sets ResourceUri
        /// </summary>
        [DataMember(Name = "ResourceUri", EmitDefaultValue = false)]
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationProfileUri
        /// </summary>
        [DataMember(Name = "AuthenticationProfileUri", EmitDefaultValue = false)]
        public string AuthenticationProfileUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrokerConnectionTransportDataType {\n");
            sb.Append("  ResourceUri: ").Append(ResourceUri).Append("\n");
            sb.Append("  AuthenticationProfileUri: ").Append(AuthenticationProfileUri).Append("\n");
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
            return this.Equals(input as BrokerConnectionTransportDataType);
        }

        /// <summary>
        /// Returns true if BrokerConnectionTransportDataType instances are equal
        /// </summary>
        /// <param name="input">Instance of BrokerConnectionTransportDataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrokerConnectionTransportDataType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResourceUri == input.ResourceUri ||
                    (this.ResourceUri != null &&
                    this.ResourceUri.Equals(input.ResourceUri))
                ) && 
                (
                    this.AuthenticationProfileUri == input.AuthenticationProfileUri ||
                    (this.AuthenticationProfileUri != null &&
                    this.AuthenticationProfileUri.Equals(input.AuthenticationProfileUri))
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
                if (this.ResourceUri != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceUri.GetHashCode();
                }
                if (this.AuthenticationProfileUri != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationProfileUri.GetHashCode();
                }
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