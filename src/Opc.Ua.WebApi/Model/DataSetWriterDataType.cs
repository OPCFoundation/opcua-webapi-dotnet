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
    /// DataSetWriterDataType
    /// </summary>
    [DataContract(Name = "DataSetWriterDataType")]
    public partial class DataSetWriterDataType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetWriterDataType" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled (default to false).</param>
        /// <param name="dataSetWriterId">dataSetWriterId (default to 0).</param>
        /// <param name="dataSetFieldContentMask">dataSetFieldContentMask (default to 0).</param>
        /// <param name="keyFrameCount">keyFrameCount (default to 0).</param>
        /// <param name="dataSetName">dataSetName.</param>
        /// <param name="dataSetWriterProperties">dataSetWriterProperties.</param>
        /// <param name="transportSettings">transportSettings.</param>
        /// <param name="messageSettings">messageSettings.</param>
        public DataSetWriterDataType(string name = default(string), bool enabled = false, int dataSetWriterId = 0, long dataSetFieldContentMask = 0, long keyFrameCount = 0, string dataSetName = default(string), List<KeyValuePair> dataSetWriterProperties = default(List<KeyValuePair>), ExtensionObject transportSettings = default(ExtensionObject), ExtensionObject messageSettings = default(ExtensionObject))
        {
            this.Name = name;
            this.Enabled = enabled;
            this.DataSetWriterId = dataSetWriterId;
            this.DataSetFieldContentMask = dataSetFieldContentMask;
            this.KeyFrameCount = keyFrameCount;
            this.DataSetName = dataSetName;
            this.DataSetWriterProperties = dataSetWriterProperties;
            this.TransportSettings = transportSettings;
            this.MessageSettings = messageSettings;
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
        /// Gets or Sets DataSetWriterId
        /// </summary>
        [DataMember(Name = "DataSetWriterId", EmitDefaultValue = false)]
        public int DataSetWriterId { get; set; }

        /// <summary>
        /// Gets or Sets DataSetFieldContentMask
        /// </summary>
        [DataMember(Name = "DataSetFieldContentMask", EmitDefaultValue = false)]
        public long DataSetFieldContentMask { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameCount
        /// </summary>
        [DataMember(Name = "KeyFrameCount", EmitDefaultValue = false)]
        public long KeyFrameCount { get; set; }

        /// <summary>
        /// Gets or Sets DataSetName
        /// </summary>
        [DataMember(Name = "DataSetName", EmitDefaultValue = false)]
        public string DataSetName { get; set; }

        /// <summary>
        /// Gets or Sets DataSetWriterProperties
        /// </summary>
        [DataMember(Name = "DataSetWriterProperties", EmitDefaultValue = false)]
        public List<KeyValuePair> DataSetWriterProperties { get; set; }

        /// <summary>
        /// Gets or Sets TransportSettings
        /// </summary>
        [DataMember(Name = "TransportSettings", EmitDefaultValue = false)]
        public ExtensionObject TransportSettings { get; set; }

        /// <summary>
        /// Gets or Sets MessageSettings
        /// </summary>
        [DataMember(Name = "MessageSettings", EmitDefaultValue = false)]
        public ExtensionObject MessageSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSetWriterDataType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  DataSetWriterId: ").Append(DataSetWriterId).Append("\n");
            sb.Append("  DataSetFieldContentMask: ").Append(DataSetFieldContentMask).Append("\n");
            sb.Append("  KeyFrameCount: ").Append(KeyFrameCount).Append("\n");
            sb.Append("  DataSetName: ").Append(DataSetName).Append("\n");
            sb.Append("  DataSetWriterProperties: ").Append(DataSetWriterProperties).Append("\n");
            sb.Append("  TransportSettings: ").Append(TransportSettings).Append("\n");
            sb.Append("  MessageSettings: ").Append(MessageSettings).Append("\n");
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

            // DataSetFieldContentMask (long) maximum
            if (this.DataSetFieldContentMask > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for DataSetFieldContentMask, must be a value less than or equal to 4294967295.", new [] { "DataSetFieldContentMask" });
            }

            // DataSetFieldContentMask (long) minimum
            if (this.DataSetFieldContentMask < (long)0)
            {
                yield return new ValidationResult("Invalid value for DataSetFieldContentMask, must be a value greater than or equal to 0.", new [] { "DataSetFieldContentMask" });
            }

            // KeyFrameCount (long) maximum
            if (this.KeyFrameCount > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for KeyFrameCount, must be a value less than or equal to 4294967295.", new [] { "KeyFrameCount" });
            }

            // KeyFrameCount (long) minimum
            if (this.KeyFrameCount < (long)0)
            {
                yield return new ValidationResult("Invalid value for KeyFrameCount, must be a value greater than or equal to 0.", new [] { "KeyFrameCount" });
            }

            yield break;
        }
    }

}
