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
    [DataContract(Name = "SetMonitoringModeResponse")]
    public partial class SetMonitoringModeResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetMonitoringModeResponse" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="results">results.</param>
        /// <param name="diagnosticInfos">diagnosticInfos.</param>
        public SetMonitoringModeResponse(ResponseHeader responseHeader = default(ResponseHeader), List<StatusCode> results = default(List<StatusCode>), List<DiagnosticInfo> diagnosticInfos = default(List<DiagnosticInfo>))
        {
            this.ResponseHeader = responseHeader;
            this.Results = results;
            this.DiagnosticInfos = diagnosticInfos;
        }

        /// <summary>
        /// Gets or Sets ResponseHeader
        /// </summary>
        [DataMember(Name = "ResponseHeader", EmitDefaultValue = false)]
        public ResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "Results", EmitDefaultValue = false)]
        public List<StatusCode> Results { get; set; }

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
            sb.Append("class SetMonitoringModeResponse {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
