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
    /// PubSubConnectionDataType
    /// </summary>
    [DataContract(Name = "PubSubConnectionDataType")]
    public partial class PubSubConnectionDataType : IEquatable<PubSubConnectionDataType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PubSubConnectionDataType" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="publisherId">publisherId.</param>
        /// <param name="transportProfileUri">transportProfileUri.</param>
        /// <param name="address">address.</param>
        /// <param name="connectionProperties">connectionProperties.</param>
        /// <param name="transportSettings">transportSettings.</param>
        /// <param name="writerGroups">writerGroups.</param>
        /// <param name="readerGroups">readerGroups.</param>
        public PubSubConnectionDataType(string name = default(string), bool enabled = default(bool), Variant publisherId = default(Variant), string transportProfileUri = default(string), ExtensionObject address = default(ExtensionObject), List<KeyValuePair> connectionProperties = default(List<KeyValuePair>), ExtensionObject transportSettings = default(ExtensionObject), List<WriterGroupDataType> writerGroups = default(List<WriterGroupDataType>), List<ReaderGroupDataType> readerGroups = default(List<ReaderGroupDataType>))
        {
            this.Name = name;
            this.Enabled = enabled;
            this.PublisherId = publisherId;
            this.TransportProfileUri = transportProfileUri;
            this.Address = address;
            this.ConnectionProperties = connectionProperties;
            this.TransportSettings = transportSettings;
            this.WriterGroups = writerGroups;
            this.ReaderGroups = readerGroups;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "Enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets PublisherId
        /// </summary>
        [DataMember(Name = "PublisherId", EmitDefaultValue = false)]
        public Variant PublisherId { get; set; }

        /// <summary>
        /// Gets or Sets TransportProfileUri
        /// </summary>
        [DataMember(Name = "TransportProfileUri", EmitDefaultValue = false)]
        public string TransportProfileUri { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public ExtensionObject Address { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionProperties
        /// </summary>
        [DataMember(Name = "ConnectionProperties", EmitDefaultValue = false)]
        public List<KeyValuePair> ConnectionProperties { get; set; }

        /// <summary>
        /// Gets or Sets TransportSettings
        /// </summary>
        [DataMember(Name = "TransportSettings", EmitDefaultValue = false)]
        public ExtensionObject TransportSettings { get; set; }

        /// <summary>
        /// Gets or Sets WriterGroups
        /// </summary>
        [DataMember(Name = "WriterGroups", EmitDefaultValue = false)]
        public List<WriterGroupDataType> WriterGroups { get; set; }

        /// <summary>
        /// Gets or Sets ReaderGroups
        /// </summary>
        [DataMember(Name = "ReaderGroups", EmitDefaultValue = false)]
        public List<ReaderGroupDataType> ReaderGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PubSubConnectionDataType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  PublisherId: ").Append(PublisherId).Append("\n");
            sb.Append("  TransportProfileUri: ").Append(TransportProfileUri).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
            sb.Append("  TransportSettings: ").Append(TransportSettings).Append("\n");
            sb.Append("  WriterGroups: ").Append(WriterGroups).Append("\n");
            sb.Append("  ReaderGroups: ").Append(ReaderGroups).Append("\n");
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
            return this.Equals(input as PubSubConnectionDataType);
        }

        /// <summary>
        /// Returns true if PubSubConnectionDataType instances are equal
        /// </summary>
        /// <param name="input">Instance of PubSubConnectionDataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PubSubConnectionDataType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.PublisherId == input.PublisherId ||
                    (this.PublisherId != null &&
                    this.PublisherId.Equals(input.PublisherId))
                ) && 
                (
                    this.TransportProfileUri == input.TransportProfileUri ||
                    (this.TransportProfileUri != null &&
                    this.TransportProfileUri.Equals(input.TransportProfileUri))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ConnectionProperties == input.ConnectionProperties ||
                    this.ConnectionProperties != null &&
                    input.ConnectionProperties != null &&
                    this.ConnectionProperties.SequenceEqual(input.ConnectionProperties)
                ) && 
                (
                    this.TransportSettings == input.TransportSettings ||
                    (this.TransportSettings != null &&
                    this.TransportSettings.Equals(input.TransportSettings))
                ) && 
                (
                    this.WriterGroups == input.WriterGroups ||
                    this.WriterGroups != null &&
                    input.WriterGroups != null &&
                    this.WriterGroups.SequenceEqual(input.WriterGroups)
                ) && 
                (
                    this.ReaderGroups == input.ReaderGroups ||
                    this.ReaderGroups != null &&
                    input.ReaderGroups != null &&
                    this.ReaderGroups.SequenceEqual(input.ReaderGroups)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.PublisherId != null)
                {
                    hashCode = (hashCode * 59) + this.PublisherId.GetHashCode();
                }
                if (this.TransportProfileUri != null)
                {
                    hashCode = (hashCode * 59) + this.TransportProfileUri.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.ConnectionProperties != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionProperties.GetHashCode();
                }
                if (this.TransportSettings != null)
                {
                    hashCode = (hashCode * 59) + this.TransportSettings.GetHashCode();
                }
                if (this.WriterGroups != null)
                {
                    hashCode = (hashCode * 59) + this.WriterGroups.GetHashCode();
                }
                if (this.ReaderGroups != null)
                {
                    hashCode = (hashCode * 59) + this.ReaderGroups.GetHashCode();
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