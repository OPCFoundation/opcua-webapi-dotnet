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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.33).
    /// </summary>
    [DataContract(Name = "RequestHeader")]
    public partial class RequestHeader : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestHeader" /> class.
        /// </summary>
        /// <param name="authenticationToken">authenticationToken.</param>
        /// <param name="timestamp">timestamp (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="requestHandle">requestHandle (default to 0).</param>
        /// <param name="returnDiagnostics">returnDiagnostics (default to 0).</param>
        /// <param name="auditEntryId">auditEntryId.</param>
        /// <param name="timeoutHint">timeoutHint (default to 0).</param>
        /// <param name="additionalHeader">additionalHeader.</param>
        public RequestHeader(string authenticationToken = default(string), DateTime timestamp = default(DateTime), long requestHandle = 0, long returnDiagnostics = 0, string auditEntryId = default(string), long timeoutHint = 0, ExtensionObject additionalHeader = default(ExtensionObject))
        {
            this.AuthenticationToken = authenticationToken;
            this.Timestamp = timestamp;
            this.RequestHandle = requestHandle;
            this.ReturnDiagnostics = returnDiagnostics;
            this.AuditEntryId = auditEntryId;
            this.TimeoutHint = timeoutHint;
            this.AdditionalHeader = additionalHeader;
        }

        /// <summary>
        /// Gets or Sets AuthenticationToken
        /// </summary>
        [DataMember(Name = "AuthenticationToken", EmitDefaultValue = false)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets RequestHandle
        /// </summary>
        [DataMember(Name = "RequestHandle", EmitDefaultValue = false)]
        public long RequestHandle { get; set; }

        /// <summary>
        /// Gets or Sets ReturnDiagnostics
        /// </summary>
        [DataMember(Name = "ReturnDiagnostics", EmitDefaultValue = false)]
        public long ReturnDiagnostics { get; set; }

        /// <summary>
        /// Gets or Sets AuditEntryId
        /// </summary>
        [DataMember(Name = "AuditEntryId", EmitDefaultValue = false)]
        public string AuditEntryId { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutHint
        /// </summary>
        [DataMember(Name = "TimeoutHint", EmitDefaultValue = false)]
        public long TimeoutHint { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalHeader
        /// </summary>
        [DataMember(Name = "AdditionalHeader", EmitDefaultValue = false)]
        public ExtensionObject AdditionalHeader { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestHeader {\n");
            sb.Append("  AuthenticationToken: ").Append(AuthenticationToken).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  RequestHandle: ").Append(RequestHandle).Append("\n");
            sb.Append("  ReturnDiagnostics: ").Append(ReturnDiagnostics).Append("\n");
            sb.Append("  AuditEntryId: ").Append(AuditEntryId).Append("\n");
            sb.Append("  TimeoutHint: ").Append(TimeoutHint).Append("\n");
            sb.Append("  AdditionalHeader: ").Append(AdditionalHeader).Append("\n");
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
            // RequestHandle (long) maximum
            if (this.RequestHandle > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for RequestHandle, must be a value less than or equal to 4294967295.", new [] { "RequestHandle" });
            }

            // RequestHandle (long) minimum
            if (this.RequestHandle < (long)0)
            {
                yield return new ValidationResult("Invalid value for RequestHandle, must be a value greater than or equal to 0.", new [] { "RequestHandle" });
            }

            // ReturnDiagnostics (long) maximum
            if (this.ReturnDiagnostics > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for ReturnDiagnostics, must be a value less than or equal to 4294967295.", new [] { "ReturnDiagnostics" });
            }

            // ReturnDiagnostics (long) minimum
            if (this.ReturnDiagnostics < (long)0)
            {
                yield return new ValidationResult("Invalid value for ReturnDiagnostics, must be a value greater than or equal to 0.", new [] { "ReturnDiagnostics" });
            }

            // TimeoutHint (long) maximum
            if (this.TimeoutHint > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for TimeoutHint, must be a value less than or equal to 4294967295.", new [] { "TimeoutHint" });
            }

            // TimeoutHint (long) minimum
            if (this.TimeoutHint < (long)0)
            {
                yield return new ValidationResult("Invalid value for TimeoutHint, must be a value greater than or equal to 0.", new [] { "TimeoutHint" });
            }

            yield break;
        }
    }

}
