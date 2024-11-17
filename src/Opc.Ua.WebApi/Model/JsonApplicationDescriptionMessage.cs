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
    /// JsonApplicationDescriptionMessage
    /// </summary>
    [DataContract(Name = "JsonApplicationDescriptionMessage")]
    public partial class JsonApplicationDescriptionMessage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApplicationDescriptionMessage" /> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="publisherId">publisherId.</param>
        /// <param name="timestamp">timestamp (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="description">description.</param>
        /// <param name="serverCapabilities">serverCapabilities.</param>
        public JsonApplicationDescriptionMessage(string messageId = default(string), string messageType = default(string), string publisherId = default(string), DateTime timestamp = default(DateTime), ApplicationDescription description = default(ApplicationDescription), List<string> serverCapabilities = default(List<string>))
        {
            this.MessageId = messageId;
            this.MessageType = messageType;
            this.PublisherId = publisherId;
            this.Timestamp = timestamp;
            this.Description = description;
            this.ServerCapabilities = serverCapabilities;
        }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "MessageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name = "MessageType", EmitDefaultValue = false)]
        public string MessageType { get; set; }

        /// <summary>
        /// Gets or Sets PublisherId
        /// </summary>
        [DataMember(Name = "PublisherId", EmitDefaultValue = false)]
        public string PublisherId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public ApplicationDescription Description { get; set; }

        /// <summary>
        /// Gets or Sets ServerCapabilities
        /// </summary>
        [DataMember(Name = "ServerCapabilities", EmitDefaultValue = false)]
        public List<string> ServerCapabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonApplicationDescriptionMessage {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  PublisherId: ").Append(PublisherId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ServerCapabilities: ").Append(ServerCapabilities).Append("\n");
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
