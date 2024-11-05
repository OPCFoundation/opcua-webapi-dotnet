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
    /// MonitoredItemCreateResult
    /// </summary>
    [DataContract(Name = "MonitoredItemCreateResult")]
    public partial class MonitoredItemCreateResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoredItemCreateResult" /> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="monitoredItemId">monitoredItemId (default to 0).</param>
        /// <param name="revisedSamplingInterval">revisedSamplingInterval (default to 0D).</param>
        /// <param name="revisedQueueSize">revisedQueueSize (default to 0).</param>
        /// <param name="filterResult">filterResult.</param>
        public MonitoredItemCreateResult(StatusCode statusCode = default(StatusCode), long monitoredItemId = 0, double revisedSamplingInterval = 0D, long revisedQueueSize = 0, ExtensionObject filterResult = default(ExtensionObject))
        {
            this.StatusCode = statusCode;
            this.MonitoredItemId = monitoredItemId;
            this.RevisedSamplingInterval = revisedSamplingInterval;
            this.RevisedQueueSize = revisedQueueSize;
            this.FilterResult = filterResult;
        }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets MonitoredItemId
        /// </summary>
        [DataMember(Name = "MonitoredItemId", EmitDefaultValue = false)]
        public long MonitoredItemId { get; set; }

        /// <summary>
        /// Gets or Sets RevisedSamplingInterval
        /// </summary>
        [DataMember(Name = "RevisedSamplingInterval", EmitDefaultValue = false)]
        public double RevisedSamplingInterval { get; set; }

        /// <summary>
        /// Gets or Sets RevisedQueueSize
        /// </summary>
        [DataMember(Name = "RevisedQueueSize", EmitDefaultValue = false)]
        public long RevisedQueueSize { get; set; }

        /// <summary>
        /// Gets or Sets FilterResult
        /// </summary>
        [DataMember(Name = "FilterResult", EmitDefaultValue = false)]
        public ExtensionObject FilterResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonitoredItemCreateResult {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  MonitoredItemId: ").Append(MonitoredItemId).Append("\n");
            sb.Append("  RevisedSamplingInterval: ").Append(RevisedSamplingInterval).Append("\n");
            sb.Append("  RevisedQueueSize: ").Append(RevisedQueueSize).Append("\n");
            sb.Append("  FilterResult: ").Append(FilterResult).Append("\n");
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
            // MonitoredItemId (long) maximum
            if (this.MonitoredItemId > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for MonitoredItemId, must be a value less than or equal to 4294967295.", new [] { "MonitoredItemId" });
            }

            // MonitoredItemId (long) minimum
            if (this.MonitoredItemId < (long)0)
            {
                yield return new ValidationResult("Invalid value for MonitoredItemId, must be a value greater than or equal to 0.", new [] { "MonitoredItemId" });
            }

            // RevisedQueueSize (long) maximum
            if (this.RevisedQueueSize > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for RevisedQueueSize, must be a value less than or equal to 4294967295.", new [] { "RevisedQueueSize" });
            }

            // RevisedQueueSize (long) minimum
            if (this.RevisedQueueSize < (long)0)
            {
                yield return new ValidationResult("Invalid value for RevisedQueueSize, must be a value greater than or equal to 0.", new [] { "RevisedQueueSize" });
            }

            yield break;
        }
    }

}
