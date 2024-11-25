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
    /// Defines JsonMessageType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JsonMessageType
    {
        /// <summary>
        /// Enum Data for value: ua-data
        /// </summary>
        [EnumMember(Value = "ua-data")]
        Data = 1,

        /// <summary>
        /// Enum DataSetMetadata for value: ua-metadata
        /// </summary>
        [EnumMember(Value = "ua-metadata")]
        DataSetMetadata = 2,

        /// <summary>
        /// Enum Application for value: ua-application
        /// </summary>
        [EnumMember(Value = "ua-application")]
        Application = 3,

        /// <summary>
        /// Enum Endpoints for value: ua-endpoints
        /// </summary>
        [EnumMember(Value = "ua-endpoints")]
        Endpoints = 4,

        /// <summary>
        /// Enum Status for value: ua-status
        /// </summary>
        [EnumMember(Value = "ua-status")]
        Status = 5,

        /// <summary>
        /// Enum Connection for value: ua-connection
        /// </summary>
        [EnumMember(Value = "ua-connection")]
        Connection = 6,

        /// <summary>
        /// Enum ActionRequest for value: ua-action-request
        /// </summary>
        [EnumMember(Value = "ua-action-request")]
        ActionRequest = 7,

        /// <summary>
        /// Enum ActionResponse for value: ua-action-response
        /// </summary>
        [EnumMember(Value = "ua-action-response")]
        ActionResponse = 8,

        /// <summary>
        /// Enum ActionMetadata for value: ua-action-metadata
        /// </summary>
        [EnumMember(Value = "ua-action-metadata")]
        ActionMetadata = 9,

        /// <summary>
        /// Enum ActionResponder for value: ua-action-responder
        /// </summary>
        [EnumMember(Value = "ua-action-responder")]
        ActionResponder = 10,

        /// <summary>
        /// Enum KeyFrame for value: ua-keyframe
        /// </summary>
        [EnumMember(Value = "ua-keyframe")]
        KeyFrame = 11,

        /// <summary>
        /// Enum DeltaFrame for value: ua-deltaframe
        /// </summary>
        [EnumMember(Value = "ua-deltaframe")]
        DeltaFrame = 12,

        /// <summary>
        /// Enum Event for value: ua-event
        /// </summary>
        [EnumMember(Value = "ua-event")]
        Event = 13,

        /// <summary>
        /// Enum KeepAlive for value: ua-keepalive
        /// </summary>
        [EnumMember(Value = "ua-keepalive")]
        KeepAlive = 14
    }

}
