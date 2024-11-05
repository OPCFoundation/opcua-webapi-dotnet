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
    /// NotificationMessage
    /// </summary>
    [DataContract(Name = "NotificationMessage")]
    public partial class NotificationMessage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationMessage" /> class.
        /// </summary>
        /// <param name="sequenceNumber">sequenceNumber (default to 0).</param>
        /// <param name="publishTime">publishTime (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="notificationData">notificationData.</param>
        public NotificationMessage(long sequenceNumber = 0, DateTime publishTime = default(DateTime), List<ExtensionObject> notificationData = default(List<ExtensionObject>))
        {
            this.SequenceNumber = sequenceNumber;
            this.PublishTime = publishTime;
            this.NotificationData = notificationData;
        }

        /// <summary>
        /// Gets or Sets SequenceNumber
        /// </summary>
        [DataMember(Name = "SequenceNumber", EmitDefaultValue = false)]
        public long SequenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        [DataMember(Name = "PublishTime", EmitDefaultValue = false)]
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets NotificationData
        /// </summary>
        [DataMember(Name = "NotificationData", EmitDefaultValue = false)]
        public List<ExtensionObject> NotificationData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationMessage {\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  NotificationData: ").Append(NotificationData).Append("\n");
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
            // SequenceNumber (long) maximum
            if (this.SequenceNumber > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for SequenceNumber, must be a value less than or equal to 4294967295.", new [] { "SequenceNumber" });
            }

            // SequenceNumber (long) minimum
            if (this.SequenceNumber < (long)0)
            {
                yield return new ValidationResult("Invalid value for SequenceNumber, must be a value greater than or equal to 0.", new [] { "SequenceNumber" });
            }

            yield break;
        }
    }

}
