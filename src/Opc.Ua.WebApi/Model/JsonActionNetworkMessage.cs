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
    /// JsonActionNetworkMessage
    /// </summary>
    [DataContract(Name = "JsonActionNetworkMessage")]
    public partial class JsonActionNetworkMessage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonActionNetworkMessage" /> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="publisherId">publisherId.</param>
        /// <param name="timestamp">timestamp (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="responseAddress">responseAddress.</param>
        /// <param name="correlationData">correlationData.</param>
        /// <param name="requestorId">requestorId.</param>
        /// <param name="timeoutHint">timeoutHint (default to 0D).</param>
        /// <param name="messages">messages.</param>
        public JsonActionNetworkMessage(string messageId = default(string), string messageType = default(string), string publisherId = default(string), DateTime timestamp = default(DateTime), string responseAddress = default(string), byte[] correlationData = default(byte[]), string requestorId = default(string), double timeoutHint = 0D, List<Object> messages = default(List<Object>))
        {
            this.MessageId = messageId;
            this.MessageType = messageType;
            this.PublisherId = publisherId;
            this.Timestamp = timestamp;
            this.ResponseAddress = responseAddress;
            this.CorrelationData = correlationData;
            this.RequestorId = requestorId;
            this.TimeoutHint = timeoutHint;
            this.Messages = messages;
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
        /// Gets or Sets ResponseAddress
        /// </summary>
        [DataMember(Name = "ResponseAddress", EmitDefaultValue = false)]
        public string ResponseAddress { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationData
        /// </summary>
        [DataMember(Name = "CorrelationData", EmitDefaultValue = false)]
        public byte[] CorrelationData { get; set; }

        /// <summary>
        /// Gets or Sets RequestorId
        /// </summary>
        [DataMember(Name = "RequestorId", EmitDefaultValue = false)]
        public string RequestorId { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutHint
        /// </summary>
        [DataMember(Name = "TimeoutHint", EmitDefaultValue = false)]
        public double TimeoutHint { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "Messages", EmitDefaultValue = false)]
        public List<Object> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonActionNetworkMessage {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  PublisherId: ").Append(PublisherId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ResponseAddress: ").Append(ResponseAddress).Append("\n");
            sb.Append("  CorrelationData: ").Append(CorrelationData).Append("\n");
            sb.Append("  RequestorId: ").Append(RequestorId).Append("\n");
            sb.Append("  TimeoutHint: ").Append(TimeoutHint).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
