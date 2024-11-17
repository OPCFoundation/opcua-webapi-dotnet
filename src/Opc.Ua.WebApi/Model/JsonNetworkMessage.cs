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
    /// JsonNetworkMessage
    /// </summary>
    [DataContract(Name = "JsonNetworkMessage")]
    public partial class JsonNetworkMessage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonNetworkMessage" /> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="publisherId">publisherId.</param>
        /// <param name="writerGroupName">writerGroupName.</param>
        /// <param name="dataSetClassId">dataSetClassId.</param>
        /// <param name="messages">messages.</param>
        public JsonNetworkMessage(string messageId = default(string), string messageType = default(string), string publisherId = default(string), string writerGroupName = default(string), string dataSetClassId = default(string), Object messages = default(Object))
        {
            this.MessageId = messageId;
            this.MessageType = messageType;
            this.PublisherId = publisherId;
            this.WriterGroupName = writerGroupName;
            this.DataSetClassId = dataSetClassId;
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
        /// Gets or Sets WriterGroupName
        /// </summary>
        [DataMember(Name = "WriterGroupName", EmitDefaultValue = false)]
        public string WriterGroupName { get; set; }

        /// <summary>
        /// Gets or Sets DataSetClassId
        /// </summary>
        [DataMember(Name = "DataSetClassId", EmitDefaultValue = false)]
        public string DataSetClassId { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "Messages", EmitDefaultValue = true)]
        public Object Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonNetworkMessage {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  PublisherId: ").Append(PublisherId).Append("\n");
            sb.Append("  WriterGroupName: ").Append(WriterGroupName).Append("\n");
            sb.Append("  DataSetClassId: ").Append(DataSetClassId).Append("\n");
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