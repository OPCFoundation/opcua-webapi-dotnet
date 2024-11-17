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
    /// ReaderGroupDataType
    /// </summary>
    [DataContract(Name = "ReaderGroupDataType")]
    public partial class ReaderGroupDataType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderGroupDataType" /> class.
        /// </summary>
        /// <param name="transportSettings">transportSettings.</param>
        /// <param name="messageSettings">messageSettings.</param>
        /// <param name="dataSetReaders">dataSetReaders.</param>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled (default to false).</param>
        /// <param name="securityMode">securityMode.</param>
        /// <param name="securityGroupId">securityGroupId.</param>
        /// <param name="securityKeyServices">securityKeyServices.</param>
        /// <param name="maxNetworkMessageSize">maxNetworkMessageSize (default to 0).</param>
        /// <param name="groupProperties">groupProperties.</param>
        public ReaderGroupDataType(Object transportSettings = default(Object), Object messageSettings = default(Object), List<DataSetReaderDataType> dataSetReaders = default(List<DataSetReaderDataType>), string name = default(string), bool enabled = false, int securityMode = default(int), string securityGroupId = default(string), List<EndpointDescription> securityKeyServices = default(List<EndpointDescription>), long maxNetworkMessageSize = 0, List<KeyValuePair> groupProperties = default(List<KeyValuePair>))
        {
            this.TransportSettings = transportSettings;
            this.MessageSettings = messageSettings;
            this.DataSetReaders = dataSetReaders;
            this.Name = name;
            this.Enabled = enabled;
            this.SecurityMode = securityMode;
            this.SecurityGroupId = securityGroupId;
            this.SecurityKeyServices = securityKeyServices;
            this.MaxNetworkMessageSize = maxNetworkMessageSize;
            this.GroupProperties = groupProperties;
        }

        /// <summary>
        /// Gets or Sets TransportSettings
        /// </summary>
        [DataMember(Name = "TransportSettings", EmitDefaultValue = false)]
        public Object TransportSettings { get; set; }

        /// <summary>
        /// Gets or Sets MessageSettings
        /// </summary>
        [DataMember(Name = "MessageSettings", EmitDefaultValue = false)]
        public Object MessageSettings { get; set; }

        /// <summary>
        /// Gets or Sets DataSetReaders
        /// </summary>
        [DataMember(Name = "DataSetReaders", EmitDefaultValue = false)]
        public List<DataSetReaderDataType> DataSetReaders { get; set; }

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
        /// Gets or Sets SecurityMode
        /// </summary>
        [DataMember(Name = "SecurityMode", EmitDefaultValue = false)]
        public int SecurityMode { get; set; }

        /// <summary>
        /// Gets or Sets SecurityGroupId
        /// </summary>
        [DataMember(Name = "SecurityGroupId", EmitDefaultValue = false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Gets or Sets SecurityKeyServices
        /// </summary>
        [DataMember(Name = "SecurityKeyServices", EmitDefaultValue = false)]
        public List<EndpointDescription> SecurityKeyServices { get; set; }

        /// <summary>
        /// Gets or Sets MaxNetworkMessageSize
        /// </summary>
        [DataMember(Name = "MaxNetworkMessageSize", EmitDefaultValue = false)]
        public long MaxNetworkMessageSize { get; set; }

        /// <summary>
        /// Gets or Sets GroupProperties
        /// </summary>
        [DataMember(Name = "GroupProperties", EmitDefaultValue = false)]
        public List<KeyValuePair> GroupProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReaderGroupDataType {\n");
            sb.Append("  TransportSettings: ").Append(TransportSettings).Append("\n");
            sb.Append("  MessageSettings: ").Append(MessageSettings).Append("\n");
            sb.Append("  DataSetReaders: ").Append(DataSetReaders).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SecurityMode: ").Append(SecurityMode).Append("\n");
            sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  SecurityKeyServices: ").Append(SecurityKeyServices).Append("\n");
            sb.Append("  MaxNetworkMessageSize: ").Append(MaxNetworkMessageSize).Append("\n");
            sb.Append("  GroupProperties: ").Append(GroupProperties).Append("\n");
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
            // MaxNetworkMessageSize (long) maximum
            if (this.MaxNetworkMessageSize > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for MaxNetworkMessageSize, must be a value less than or equal to 4294967295.", new [] { "MaxNetworkMessageSize" });
            }

            // MaxNetworkMessageSize (long) minimum
            if (this.MaxNetworkMessageSize < (long)0)
            {
                yield return new ValidationResult("Invalid value for MaxNetworkMessageSize, must be a value greater than or equal to 0.", new [] { "MaxNetworkMessageSize" });
            }

            yield break;
        }
    }

}
