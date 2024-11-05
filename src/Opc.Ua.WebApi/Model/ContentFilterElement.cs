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
    /// ContentFilterElement
    /// </summary>
    [DataContract(Name = "ContentFilterElement")]
    public partial class ContentFilterElement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterElement" /> class.
        /// </summary>
        /// <param name="filterOperator">filterOperator.</param>
        /// <param name="filterOperands">filterOperands.</param>
        public ContentFilterElement(int filterOperator = default(int), List<ExtensionObject> filterOperands = default(List<ExtensionObject>))
        {
            this.FilterOperator = filterOperator;
            this.FilterOperands = filterOperands;
        }

        /// <summary>
        /// Gets or Sets FilterOperator
        /// </summary>
        [DataMember(Name = "FilterOperator", EmitDefaultValue = false)]
        public int FilterOperator { get; set; }

        /// <summary>
        /// Gets or Sets FilterOperands
        /// </summary>
        [DataMember(Name = "FilterOperands", EmitDefaultValue = false)]
        public List<ExtensionObject> FilterOperands { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentFilterElement {\n");
            sb.Append("  FilterOperator: ").Append(FilterOperator).Append("\n");
            sb.Append("  FilterOperands: ").Append(FilterOperands).Append("\n");
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
