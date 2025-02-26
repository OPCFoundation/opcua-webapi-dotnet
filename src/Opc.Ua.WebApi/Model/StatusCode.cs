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
    /// [Link to specification](https://reference.opcfoundation.org/Core/Part4/v105/docs/7.39). [Set of defined codes](https://github.com/OPCFoundation/UA-Nodeset/tree/latest/Schema/StatusCode.csv).
    /// </summary>
    [DataContract(Name = "StatusCode")]
    public partial class StatusCode : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCode" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="symbol">symbol.</param>
        public StatusCode(long code = default(long), string symbol = default(string))
        {
            this.Code = code;
            this.Symbol = symbol;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "Code", EmitDefaultValue = false)]
        public long Code { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "Symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StatusCode {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            // Code (long) maximum
            if (this.Code > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for Code, must be a value less than or equal to 4294967295.", new [] { "Code" });
            }

            // Code (long) minimum
            if (this.Code < (long)0)
            {
                yield return new ValidationResult("Invalid value for Code, must be a value greater than or equal to 0.", new [] { "Code" });
            }

            yield break;
        }
    }

}
