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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.12.2/#5.12.2.2).
    /// </summary>
    [DataContract(Name = "CallMethodResult")]
    public partial class CallMethodResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallMethodResult" /> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="inputArgumentResults">inputArgumentResults.</param>
        /// <param name="inputArgumentDiagnosticInfos">inputArgumentDiagnosticInfos.</param>
        /// <param name="outputArguments">outputArguments.</param>
        public CallMethodResult(StatusCode statusCode = default(StatusCode), List<StatusCode> inputArgumentResults = default(List<StatusCode>), List<DiagnosticInfo> inputArgumentDiagnosticInfos = default(List<DiagnosticInfo>), List<Variant> outputArguments = default(List<Variant>))
        {
            this.StatusCode = statusCode;
            this.InputArgumentResults = inputArgumentResults;
            this.InputArgumentDiagnosticInfos = inputArgumentDiagnosticInfos;
            this.OutputArguments = outputArguments;
        }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets InputArgumentResults
        /// </summary>
        [DataMember(Name = "InputArgumentResults", EmitDefaultValue = false)]
        public List<StatusCode> InputArgumentResults { get; set; }

        /// <summary>
        /// Gets or Sets InputArgumentDiagnosticInfos
        /// </summary>
        [DataMember(Name = "InputArgumentDiagnosticInfos", EmitDefaultValue = false)]
        public List<DiagnosticInfo> InputArgumentDiagnosticInfos { get; set; }

        /// <summary>
        /// Gets or Sets OutputArguments
        /// </summary>
        [DataMember(Name = "OutputArguments", EmitDefaultValue = false)]
        public List<Variant> OutputArguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallMethodResult {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  InputArgumentResults: ").Append(InputArgumentResults).Append("\n");
            sb.Append("  InputArgumentDiagnosticInfos: ").Append(InputArgumentDiagnosticInfos).Append("\n");
            sb.Append("  OutputArguments: ").Append(OutputArguments).Append("\n");
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
