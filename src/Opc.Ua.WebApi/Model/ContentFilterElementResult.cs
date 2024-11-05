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
    /// ContentFilterElementResult
    /// </summary>
    [DataContract(Name = "ContentFilterElementResult")]
    public partial class ContentFilterElementResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterElementResult" /> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="operandStatusCodes">operandStatusCodes.</param>
        /// <param name="operandDiagnosticInfos">operandDiagnosticInfos.</param>
        public ContentFilterElementResult(StatusCode statusCode = default(StatusCode), List<StatusCode> operandStatusCodes = default(List<StatusCode>), List<DiagnosticInfo> operandDiagnosticInfos = default(List<DiagnosticInfo>))
        {
            this.StatusCode = statusCode;
            this.OperandStatusCodes = operandStatusCodes;
            this.OperandDiagnosticInfos = operandDiagnosticInfos;
        }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets OperandStatusCodes
        /// </summary>
        [DataMember(Name = "OperandStatusCodes", EmitDefaultValue = false)]
        public List<StatusCode> OperandStatusCodes { get; set; }

        /// <summary>
        /// Gets or Sets OperandDiagnosticInfos
        /// </summary>
        [DataMember(Name = "OperandDiagnosticInfos", EmitDefaultValue = false)]
        public List<DiagnosticInfo> OperandDiagnosticInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentFilterElementResult {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  OperandStatusCodes: ").Append(OperandStatusCodes).Append("\n");
            sb.Append("  OperandDiagnosticInfos: ").Append(OperandDiagnosticInfos).Append("\n");
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
