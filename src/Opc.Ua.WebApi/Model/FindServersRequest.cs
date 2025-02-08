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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.5.2/#5.5.2.2).
    /// </summary>
    [DataContract(Name = "FindServersRequest")]
    public partial class FindServersRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindServersRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="endpointUrl">endpointUrl.</param>
        /// <param name="localeIds">localeIds.</param>
        /// <param name="serverUris">serverUris.</param>
        public FindServersRequest(RequestHeader requestHeader = default(RequestHeader), string endpointUrl = default(string), List<string> localeIds = default(List<string>), List<string> serverUris = default(List<string>))
        {
            this.RequestHeader = requestHeader;
            this.EndpointUrl = endpointUrl;
            this.LocaleIds = localeIds;
            this.ServerUris = serverUris;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets EndpointUrl
        /// </summary>
        [DataMember(Name = "EndpointUrl", EmitDefaultValue = false)]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Gets or Sets LocaleIds
        /// </summary>
        [DataMember(Name = "LocaleIds", EmitDefaultValue = false)]
        public List<string> LocaleIds { get; set; }

        /// <summary>
        /// Gets or Sets ServerUris
        /// </summary>
        [DataMember(Name = "ServerUris", EmitDefaultValue = false)]
        public List<string> ServerUris { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FindServersRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  EndpointUrl: ").Append(EndpointUrl).Append("\n");
            sb.Append("  LocaleIds: ").Append(LocaleIds).Append("\n");
            sb.Append("  ServerUris: ").Append(ServerUris).Append("\n");
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
