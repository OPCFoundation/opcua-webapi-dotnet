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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.7/#6.2.7.5.1).
    /// </summary>
    [DataContract(Name = "PubSubConnectionDataType")]
    public partial class PubSubConnectionDataType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PubSubConnectionDataType" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled (default to false).</param>
        /// <param name="publisherId">publisherId.</param>
        /// <param name="transportProfileUri">transportProfileUri.</param>
        /// <param name="address">address.</param>
        /// <param name="connectionProperties">connectionProperties.</param>
        /// <param name="transportSettings">transportSettings.</param>
        /// <param name="writerGroups">writerGroups.</param>
        /// <param name="readerGroups">readerGroups.</param>
        public PubSubConnectionDataType(string name = default(string), bool enabled = false, Variant publisherId = default(Variant), string transportProfileUri = default(string), Object address = default(Object), List<KeyValuePair> connectionProperties = default(List<KeyValuePair>), Object transportSettings = default(Object), List<WriterGroupDataType> writerGroups = default(List<WriterGroupDataType>), List<ReaderGroupDataType> readerGroups = default(List<ReaderGroupDataType>))
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
        public Object Address { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionProperties
        /// </summary>
        [DataMember(Name = "ConnectionProperties", EmitDefaultValue = false)]
        public List<KeyValuePair> ConnectionProperties { get; set; }

        /// <summary>
        /// Gets or Sets TransportSettings
        /// </summary>
        [DataMember(Name = "TransportSettings", EmitDefaultValue = false)]
        public Object TransportSettings { get; set; }

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
