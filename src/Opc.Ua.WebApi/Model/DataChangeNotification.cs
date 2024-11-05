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
    /// DataChangeNotification
    /// </summary>
    [DataContract(Name = "DataChangeNotification")]
    public partial class DataChangeNotification : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataChangeNotification" /> class.
        /// </summary>
        /// <param name="monitoredItems">monitoredItems.</param>
        /// <param name="diagnosticInfos">diagnosticInfos.</param>
        public DataChangeNotification(List<MonitoredItemNotification> monitoredItems = default(List<MonitoredItemNotification>), List<DiagnosticInfo> diagnosticInfos = default(List<DiagnosticInfo>))
        {
            this.MonitoredItems = monitoredItems;
            this.DiagnosticInfos = diagnosticInfos;
        }

        /// <summary>
        /// Gets or Sets MonitoredItems
        /// </summary>
        [DataMember(Name = "MonitoredItems", EmitDefaultValue = false)]
        public List<MonitoredItemNotification> MonitoredItems { get; set; }

        /// <summary>
        /// Gets or Sets DiagnosticInfos
        /// </summary>
        [DataMember(Name = "DiagnosticInfos", EmitDefaultValue = false)]
        public List<DiagnosticInfo> DiagnosticInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataChangeNotification {\n");
            sb.Append("  MonitoredItems: ").Append(MonitoredItems).Append("\n");
            sb.Append("  DiagnosticInfos: ").Append(DiagnosticInfos).Append("\n");
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
