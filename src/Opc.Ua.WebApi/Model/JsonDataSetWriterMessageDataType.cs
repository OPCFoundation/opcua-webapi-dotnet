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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.3.2/#6.3.2.3.2).
    /// </summary>
    [DataContract(Name = "JsonDataSetWriterMessageDataType")]
    public partial class JsonDataSetWriterMessageDataType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonDataSetWriterMessageDataType" /> class.
        /// </summary>
        /// <param name="dataSetMessageContentMask">dataSetMessageContentMask (default to 0).</param>
        public JsonDataSetWriterMessageDataType(long dataSetMessageContentMask = 0)
        {
            this.DataSetMessageContentMask = dataSetMessageContentMask;
        }

        /// <summary>
        /// Gets or Sets DataSetMessageContentMask
        /// </summary>
        [DataMember(Name = "DataSetMessageContentMask", EmitDefaultValue = false)]
        public long DataSetMessageContentMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonDataSetWriterMessageDataType {\n");
            sb.Append("  DataSetMessageContentMask: ").Append(DataSetMessageContentMask).Append("\n");
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
            // DataSetMessageContentMask (long) maximum
            if (this.DataSetMessageContentMask > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for DataSetMessageContentMask, must be a value less than or equal to 4294967295.", new [] { "DataSetMessageContentMask" });
            }

            // DataSetMessageContentMask (long) minimum
            if (this.DataSetMessageContentMask < (long)0)
            {
                yield return new ValidationResult("Invalid value for DataSetMessageContentMask, must be a value greater than or equal to 0.", new [] { "DataSetMessageContentMask" });
            }

            yield break;
        }
    }

}
