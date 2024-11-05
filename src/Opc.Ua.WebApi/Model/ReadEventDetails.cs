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
    /// ReadEventDetails
    /// </summary>
    [DataContract(Name = "ReadEventDetails")]
    public partial class ReadEventDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadEventDetails" /> class.
        /// </summary>
        /// <param name="numValuesPerNode">numValuesPerNode (default to 0).</param>
        /// <param name="startTime">startTime (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="endTime">endTime (default to &quot;0001-01-01T00:00Z&quot;).</param>
        /// <param name="filter">filter.</param>
        public ReadEventDetails(long numValuesPerNode = 0, DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), EventFilter filter = default(EventFilter))
        {
            this.NumValuesPerNode = numValuesPerNode;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Filter = filter;
        }

        /// <summary>
        /// Gets or Sets NumValuesPerNode
        /// </summary>
        [DataMember(Name = "NumValuesPerNode", EmitDefaultValue = false)]
        public long NumValuesPerNode { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "StartTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "EndTime", EmitDefaultValue = false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "Filter", EmitDefaultValue = false)]
        public EventFilter Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadEventDetails {\n");
            sb.Append("  NumValuesPerNode: ").Append(NumValuesPerNode).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            // NumValuesPerNode (long) maximum
            if (this.NumValuesPerNode > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for NumValuesPerNode, must be a value less than or equal to 4294967295.", new [] { "NumValuesPerNode" });
            }

            // NumValuesPerNode (long) minimum
            if (this.NumValuesPerNode < (long)0)
            {
                yield return new ValidationResult("Invalid value for NumValuesPerNode, must be a value greater than or equal to 0.", new [] { "NumValuesPerNode" });
            }

            yield break;
        }
    }

}
