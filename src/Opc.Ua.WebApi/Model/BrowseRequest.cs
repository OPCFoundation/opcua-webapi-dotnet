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
    /// BrowseRequest
    /// </summary>
    [DataContract(Name = "BrowseRequest")]
    public partial class BrowseRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowseRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="view">view.</param>
        /// <param name="requestedMaxReferencesPerNode">requestedMaxReferencesPerNode (default to 0).</param>
        /// <param name="nodesToBrowse">nodesToBrowse.</param>
        public BrowseRequest(RequestHeader requestHeader = default(RequestHeader), ViewDescription view = default(ViewDescription), long requestedMaxReferencesPerNode = 0, List<BrowseDescription> nodesToBrowse = default(List<BrowseDescription>))
        {
            this.RequestHeader = requestHeader;
            this.View = view;
            this.RequestedMaxReferencesPerNode = requestedMaxReferencesPerNode;
            this.NodesToBrowse = nodesToBrowse;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name = "View", EmitDefaultValue = false)]
        public ViewDescription View { get; set; }

        /// <summary>
        /// Gets or Sets RequestedMaxReferencesPerNode
        /// </summary>
        [DataMember(Name = "RequestedMaxReferencesPerNode", EmitDefaultValue = false)]
        public long RequestedMaxReferencesPerNode { get; set; }

        /// <summary>
        /// Gets or Sets NodesToBrowse
        /// </summary>
        [DataMember(Name = "NodesToBrowse", EmitDefaultValue = false)]
        public List<BrowseDescription> NodesToBrowse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrowseRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
            sb.Append("  RequestedMaxReferencesPerNode: ").Append(RequestedMaxReferencesPerNode).Append("\n");
            sb.Append("  NodesToBrowse: ").Append(NodesToBrowse).Append("\n");
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
            // RequestedMaxReferencesPerNode (long) maximum
            if (this.RequestedMaxReferencesPerNode > (long)4294967295)
            {
                yield return new ValidationResult("Invalid value for RequestedMaxReferencesPerNode, must be a value less than or equal to 4294967295.", new [] { "RequestedMaxReferencesPerNode" });
            }

            // RequestedMaxReferencesPerNode (long) minimum
            if (this.RequestedMaxReferencesPerNode < (long)0)
            {
                yield return new ValidationResult("Invalid value for RequestedMaxReferencesPerNode, must be a value greater than or equal to 0.", new [] { "RequestedMaxReferencesPerNode" });
            }

            yield break;
        }
    }

}
