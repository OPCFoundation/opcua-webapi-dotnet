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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.4/#5.13.4.2).
    /// </summary>
    [DataContract(Name = "SetMonitoringModeRequest")]
    public partial class SetMonitoringModeRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetMonitoringModeRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="subscriptionId">subscriptionId (default to 0).</param>
        /// <param name="monitoringMode">[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.23)..</param>
        /// <param name="monitoredItemIds">monitoredItemIds.</param>
        public SetMonitoringModeRequest(RequestHeader requestHeader = default(RequestHeader), long subscriptionId = 0, int monitoringMode = default(int), List<long> monitoredItemIds = default(List<long>))
        {
            this.RequestHeader = requestHeader;
            this.SubscriptionId = subscriptionId;
            this.MonitoringMode = monitoringMode;
            this.MonitoredItemIds = monitoredItemIds;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "SubscriptionId", EmitDefaultValue = false)]
        public long SubscriptionId { get; set; }

        /// <summary>
        /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.23).
        /// </summary>
        /// <value>[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.23).</value>
        [DataMember(Name = "MonitoringMode", EmitDefaultValue = false)]
        public int MonitoringMode { get; set; }

        /// <summary>
        /// Gets or Sets MonitoredItemIds
        /// </summary>
        [DataMember(Name = "MonitoredItemIds", EmitDefaultValue = false)]
        public List<long> MonitoredItemIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetMonitoringModeRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  MonitoringMode: ").Append(MonitoringMode).Append("\n");
            sb.Append("  MonitoredItemIds: ").Append(MonitoredItemIds).Append("\n");
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
            // SubscriptionId (long) maximum
            if (this.SubscriptionId > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for SubscriptionId, must be a value less than or equal to 4294967295.", new [] { "SubscriptionId" });
            }

            // SubscriptionId (long) minimum
            if (this.SubscriptionId < (long)0)
            {
                yield return new ValidationResult("Invalid value for SubscriptionId, must be a value greater than or equal to 0.", new [] { "SubscriptionId" });
            }

            yield break;
        }
    }

}
