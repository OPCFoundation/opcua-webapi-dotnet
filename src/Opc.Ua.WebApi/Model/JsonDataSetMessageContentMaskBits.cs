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
    /// [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.3.2/#6.3.2.3.1).
    /// </summary>
    /// <value>[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.3.2/#6.3.2.3.1).</value>
    public enum JsonDataSetMessageContentMaskBits
    {
        /// <summary>
        /// Enum DataSetWriterId for value: 1
        /// </summary>
        DataSetWriterId = 1,

        /// <summary>
        /// Enum MetaDataVersion for value: 2
        /// </summary>
        MetaDataVersion = 2,

        /// <summary>
        /// Enum SequenceNumber for value: 4
        /// </summary>
        SequenceNumber = 4,

        /// <summary>
        /// Enum Timestamp for value: 8
        /// </summary>
        Timestamp = 8,

        /// <summary>
        /// Enum Status for value: 16
        /// </summary>
        Status = 16,

        /// <summary>
        /// Enum MessageType for value: 32
        /// </summary>
        MessageType = 32,

        /// <summary>
        /// Enum DataSetWriterName for value: 64
        /// </summary>
        DataSetWriterName = 64,

        /// <summary>
        /// Enum FieldEncoding1 for value: 128
        /// </summary>
        FieldEncoding1 = 128,

        /// <summary>
        /// Enum PublisherId for value: 256
        /// </summary>
        PublisherId = 256,

        /// <summary>
        /// Enum WriterGroupName for value: 512
        /// </summary>
        WriterGroupName = 512,

        /// <summary>
        /// Enum MinorVersion for value: 1024
        /// </summary>
        MinorVersion = 1024,

        /// <summary>
        /// Enum FieldEncoding2 for value: 2048
        /// </summary>
        FieldEncoding2 = 2048
    }

}
