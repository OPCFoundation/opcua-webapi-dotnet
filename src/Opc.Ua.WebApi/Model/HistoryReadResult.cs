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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.3/#5.11.3.2).
    /// </summary>
    [DataContract(Name = "HistoryReadResult")]
    public partial class HistoryReadResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryReadResult" /> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="continuationPoint">continuationPoint.</param>
        /// <param name="historyData">historyData.</param>
        public HistoryReadResult(StatusCode statusCode = default(StatusCode), byte[] continuationPoint = default(byte[]), ExtensionObject historyData = default(ExtensionObject))
        {
            this.StatusCode = statusCode;
            this.ContinuationPoint = continuationPoint;
            this.HistoryData = historyData;
        }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets ContinuationPoint
        /// </summary>
        [DataMember(Name = "ContinuationPoint", EmitDefaultValue = false)]
        public byte[] ContinuationPoint { get; set; }

        /// <summary>
        /// Gets or Sets HistoryData
        /// </summary>
        [DataMember(Name = "HistoryData", EmitDefaultValue = false)]
        public ExtensionObject HistoryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoryReadResult {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ContinuationPoint: ").Append(ContinuationPoint).Append("\n");
            sb.Append("  HistoryData: ").Append(HistoryData).Append("\n");
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
