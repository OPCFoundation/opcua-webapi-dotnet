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
    /// [Link to specification]().
    /// </summary>
    [DataContract(Name = "JsonActionRequestMessage")]
    public partial class JsonActionRequestMessage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonActionRequestMessage" /> class.
        /// </summary>
        /// <param name="dataSetWriterId">dataSetWriterId (default to 0).</param>
        /// <param name="actionTargetId">actionTargetId (default to 0).</param>
        /// <param name="dataSetWriterName">dataSetWriterName.</param>
        /// <param name="writerGroupName">writerGroupName.</param>
        /// <param name="metaDataVersion">metaDataVersion.</param>
        /// <param name="minorVersion">minorVersion (default to 0).</param>
        /// <param name="timestamp">timestamp (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="requestId">requestId (default to 0).</param>
        /// <param name="actionState">[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.11/#6.2.11.2.1)..</param>
        /// <param name="payload">payload.</param>
        public JsonActionRequestMessage(int dataSetWriterId = 0, int actionTargetId = 0, string dataSetWriterName = default(string), string writerGroupName = default(string), ConfigurationVersionDataType metaDataVersion = default(ConfigurationVersionDataType), long minorVersion = 0, DateTime timestamp = default(DateTime), string messageType = default(string), int requestId = 0, int actionState = default(int), Object payload = default(Object))
        {
            this.DataSetWriterId = dataSetWriterId;
            this.ActionTargetId = actionTargetId;
            this.DataSetWriterName = dataSetWriterName;
            this.WriterGroupName = writerGroupName;
            this.MetaDataVersion = metaDataVersion;
            this.MinorVersion = minorVersion;
            this.Timestamp = timestamp;
            this.MessageType = messageType;
            this.RequestId = requestId;
            this.ActionState = actionState;
            this.Payload = payload;
        }

        /// <summary>
        /// Gets or Sets DataSetWriterId
        /// </summary>
        [DataMember(Name = "DataSetWriterId", EmitDefaultValue = false)]
        public int DataSetWriterId { get; set; }

        /// <summary>
        /// Gets or Sets ActionTargetId
        /// </summary>
        [DataMember(Name = "ActionTargetId", EmitDefaultValue = false)]
        public int ActionTargetId { get; set; }

        /// <summary>
        /// Gets or Sets DataSetWriterName
        /// </summary>
        [DataMember(Name = "DataSetWriterName", EmitDefaultValue = false)]
        public string DataSetWriterName { get; set; }

        /// <summary>
        /// Gets or Sets WriterGroupName
        /// </summary>
        [DataMember(Name = "WriterGroupName", EmitDefaultValue = false)]
        public string WriterGroupName { get; set; }

        /// <summary>
        /// Gets or Sets MetaDataVersion
        /// </summary>
        [DataMember(Name = "MetaDataVersion", EmitDefaultValue = false)]
        public ConfigurationVersionDataType MetaDataVersion { get; set; }

        /// <summary>
        /// Gets or Sets MinorVersion
        /// </summary>
        [DataMember(Name = "MinorVersion", EmitDefaultValue = false)]
        public long MinorVersion { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name = "MessageType", EmitDefaultValue = false)]
        public string MessageType { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "RequestId", EmitDefaultValue = false)]
        public int RequestId { get; set; }

        /// <summary>
        /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.11/#6.2.11.2.1).
        /// </summary>
        /// <value>[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.11/#6.2.11.2.1).</value>
        [DataMember(Name = "ActionState", EmitDefaultValue = false)]
        public int ActionState { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "Payload", EmitDefaultValue = false)]
        public Object Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonActionRequestMessage {\n");
            sb.Append("  DataSetWriterId: ").Append(DataSetWriterId).Append("\n");
            sb.Append("  ActionTargetId: ").Append(ActionTargetId).Append("\n");
            sb.Append("  DataSetWriterName: ").Append(DataSetWriterName).Append("\n");
            sb.Append("  WriterGroupName: ").Append(WriterGroupName).Append("\n");
            sb.Append("  MetaDataVersion: ").Append(MetaDataVersion).Append("\n");
            sb.Append("  MinorVersion: ").Append(MinorVersion).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ActionState: ").Append(ActionState).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            // DataSetWriterId (int) maximum
            if (this.DataSetWriterId > (int)65535)
            {
                yield return new ValidationResult("Invalid value for DataSetWriterId, must be a value less than or equal to 65535.", new [] { "DataSetWriterId" });
            }

            // DataSetWriterId (int) minimum
            if (this.DataSetWriterId < (int)0)
            {
                yield return new ValidationResult("Invalid value for DataSetWriterId, must be a value greater than or equal to 0.", new [] { "DataSetWriterId" });
            }

            // ActionTargetId (int) maximum
            if (this.ActionTargetId > (int)65535)
            {
                yield return new ValidationResult("Invalid value for ActionTargetId, must be a value less than or equal to 65535.", new [] { "ActionTargetId" });
            }

            // ActionTargetId (int) minimum
            if (this.ActionTargetId < (int)0)
            {
                yield return new ValidationResult("Invalid value for ActionTargetId, must be a value greater than or equal to 0.", new [] { "ActionTargetId" });
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

            // RequestId (int) maximum
            if (this.RequestId > (int)65535)
            {
                yield return new ValidationResult("Invalid value for RequestId, must be a value less than or equal to 65535.", new [] { "RequestId" });
            }

            // RequestId (int) minimum
            if (this.RequestId < (int)0)
            {
                yield return new ValidationResult("Invalid value for RequestId, must be a value greater than or equal to 0.", new [] { "RequestId" });
            }

            yield break;
        }
    }

}
