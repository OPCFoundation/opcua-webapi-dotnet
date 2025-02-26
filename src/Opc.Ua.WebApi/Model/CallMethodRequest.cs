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
    [DataContract(Name = "CallMethodRequest")]
    public partial class CallMethodRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallMethodRequest" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="methodId">methodId.</param>
        /// <param name="inputArguments">inputArguments.</param>
        public CallMethodRequest(string objectId = default(string), string methodId = default(string), List<Variant> inputArguments = default(List<Variant>))
        {
            this.ObjectId = objectId;
            this.MethodId = methodId;
            this.InputArguments = inputArguments;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name = "ObjectId", EmitDefaultValue = false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name = "MethodId", EmitDefaultValue = false)]
        public string MethodId { get; set; }

        /// <summary>
        /// Gets or Sets InputArguments
        /// </summary>
        [DataMember(Name = "InputArguments", EmitDefaultValue = false)]
        public List<Variant> InputArguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallMethodRequest {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  InputArguments: ").Append(InputArguments).Append("\n");
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
