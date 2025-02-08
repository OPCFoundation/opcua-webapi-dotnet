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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.7.3).
    /// </summary>
    /// <value>[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.7.3).</value>
    public enum FilterOperator
    {
        /// <summary>
        /// Enum Equals for value: 0
        /// </summary>
        Equals = 0,

        /// <summary>
        /// Enum IsNull for value: 1
        /// </summary>
        IsNull = 1,

        /// <summary>
        /// Enum GreaterThan for value: 2
        /// </summary>
        GreaterThan = 2,

        /// <summary>
        /// Enum LessThan for value: 3
        /// </summary>
        LessThan = 3,

        /// <summary>
        /// Enum GreaterThanOrEqual for value: 4
        /// </summary>
        GreaterThanOrEqual = 4,

        /// <summary>
        /// Enum LessThanOrEqual for value: 5
        /// </summary>
        LessThanOrEqual = 5,

        /// <summary>
        /// Enum Like for value: 6
        /// </summary>
        Like = 6,

        /// <summary>
        /// Enum Not for value: 7
        /// </summary>
        Not = 7,

        /// <summary>
        /// Enum Between for value: 8
        /// </summary>
        Between = 8,

        /// <summary>
        /// Enum InList for value: 9
        /// </summary>
        InList = 9,

        /// <summary>
        /// Enum And for value: 10
        /// </summary>
        And = 10,

        /// <summary>
        /// Enum Or for value: 11
        /// </summary>
        Or = 11,

        /// <summary>
        /// Enum Cast for value: 12
        /// </summary>
        Cast = 12,

        /// <summary>
        /// Enum InView for value: 13
        /// </summary>
        InView = 13,

        /// <summary>
        /// Enum OfType for value: 14
        /// </summary>
        OfType = 14,

        /// <summary>
        /// Enum RelatedTo for value: 15
        /// </summary>
        RelatedTo = 15,

        /// <summary>
        /// Enum BitwiseAnd for value: 16
        /// </summary>
        BitwiseAnd = 16,

        /// <summary>
        /// Enum BitwiseOr for value: 17
        /// </summary>
        BitwiseOr = 17
    }

}
