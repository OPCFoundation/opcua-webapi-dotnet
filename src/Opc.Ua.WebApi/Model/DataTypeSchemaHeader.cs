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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.3/#6.2.3.2.2).
    /// </summary>
    [DataContract(Name = "DataTypeSchemaHeader")]
    public partial class DataTypeSchemaHeader : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeSchemaHeader" /> class.
        /// </summary>
        /// <param name="namespaces">namespaces.</param>
        /// <param name="structureDataTypes">structureDataTypes.</param>
        /// <param name="enumDataTypes">enumDataTypes.</param>
        /// <param name="simpleDataTypes">simpleDataTypes.</param>
        public DataTypeSchemaHeader(List<string> namespaces = default(List<string>), List<StructureDescription> structureDataTypes = default(List<StructureDescription>), List<EnumDescription> enumDataTypes = default(List<EnumDescription>), List<SimpleTypeDescription> simpleDataTypes = default(List<SimpleTypeDescription>))
        {
            this.Namespaces = namespaces;
            this.StructureDataTypes = structureDataTypes;
            this.EnumDataTypes = enumDataTypes;
            this.SimpleDataTypes = simpleDataTypes;
        }

        /// <summary>
        /// Gets or Sets Namespaces
        /// </summary>
        [DataMember(Name = "Namespaces", EmitDefaultValue = false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// Gets or Sets StructureDataTypes
        /// </summary>
        [DataMember(Name = "StructureDataTypes", EmitDefaultValue = false)]
        public List<StructureDescription> StructureDataTypes { get; set; }

        /// <summary>
        /// Gets or Sets EnumDataTypes
        /// </summary>
        [DataMember(Name = "EnumDataTypes", EmitDefaultValue = false)]
        public List<EnumDescription> EnumDataTypes { get; set; }

        /// <summary>
        /// Gets or Sets SimpleDataTypes
        /// </summary>
        [DataMember(Name = "SimpleDataTypes", EmitDefaultValue = false)]
        public List<SimpleTypeDescription> SimpleDataTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataTypeSchemaHeader {\n");
            sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("  StructureDataTypes: ").Append(StructureDataTypes).Append("\n");
            sb.Append("  EnumDataTypes: ").Append(EnumDataTypes).Append("\n");
            sb.Append("  SimpleDataTypes: ").Append(SimpleDataTypes).Append("\n");
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
