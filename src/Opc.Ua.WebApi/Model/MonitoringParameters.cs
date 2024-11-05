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
    /// MonitoringParameters
    /// </summary>
    [DataContract(Name = "MonitoringParameters")]
    public partial class MonitoringParameters : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringParameters" /> class.
        /// </summary>
        /// <param name="clientHandle">clientHandle (default to 0).</param>
        /// <param name="samplingInterval">samplingInterval (default to 0D).</param>
        /// <param name="filter">filter.</param>
        /// <param name="queueSize">queueSize (default to 0).</param>
        /// <param name="discardOldest">discardOldest (default to false).</param>
        public MonitoringParameters(long clientHandle = 0, double samplingInterval = 0D, ExtensionObject filter = default(ExtensionObject), long queueSize = 0, bool discardOldest = false)
        {
            this.ClientHandle = clientHandle;
            this.SamplingInterval = samplingInterval;
            this.Filter = filter;
            this.QueueSize = queueSize;
            this.DiscardOldest = discardOldest;
        }

        /// <summary>
        /// Gets or Sets ClientHandle
        /// </summary>
        [DataMember(Name = "ClientHandle", EmitDefaultValue = false)]
        public long ClientHandle { get; set; }

        /// <summary>
        /// Gets or Sets SamplingInterval
        /// </summary>
        [DataMember(Name = "SamplingInterval", EmitDefaultValue = false)]
        public double SamplingInterval { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "Filter", EmitDefaultValue = false)]
        public ExtensionObject Filter { get; set; }

        /// <summary>
        /// Gets or Sets QueueSize
        /// </summary>
        [DataMember(Name = "QueueSize", EmitDefaultValue = false)]
        public long QueueSize { get; set; }

        /// <summary>
        /// Gets or Sets DiscardOldest
        /// </summary>
        [DataMember(Name = "DiscardOldest", EmitDefaultValue = true)]
        public bool DiscardOldest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonitoringParameters {\n");
            sb.Append("  ClientHandle: ").Append(ClientHandle).Append("\n");
            sb.Append("  SamplingInterval: ").Append(SamplingInterval).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  QueueSize: ").Append(QueueSize).Append("\n");
            sb.Append("  DiscardOldest: ").Append(DiscardOldest).Append("\n");
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
            // ClientHandle (long) maximum
            if (this.ClientHandle > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for ClientHandle, must be a value less than or equal to 4294967295.", new [] { "ClientHandle" });
            }

            // ClientHandle (long) minimum
            if (this.ClientHandle < (long)0)
            {
                yield return new ValidationResult("Invalid value for ClientHandle, must be a value greater than or equal to 0.", new [] { "ClientHandle" });
            }

            // QueueSize (long) maximum
            if (this.QueueSize > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for QueueSize, must be a value less than or equal to 4294967295.", new [] { "QueueSize" });
            }

            // QueueSize (long) minimum
            if (this.QueueSize < (long)0)
            {
                yield return new ValidationResult("Invalid value for QueueSize, must be a value greater than or equal to 0.", new [] { "QueueSize" });
            }

            yield break;
        }
    }

}
