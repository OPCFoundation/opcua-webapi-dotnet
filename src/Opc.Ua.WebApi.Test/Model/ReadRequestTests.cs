/*
 * OPC UA Web API
 *
 * Provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Opc.Ua.WebApi.Model;
using Opc.Ua.WebApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Opc.Ua.WebApi.Test.Model
{
    /// <summary>
    ///  Class for testing ReadRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReadRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReadRequest
        //private ReadRequest instance;

        public ReadRequestTests()
        {
            // TODO uncomment below to create an instance of ReadRequest
            //instance = new ReadRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReadRequest
        /// </summary>
        [Fact]
        public void ReadRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" ReadRequest
            //Assert.IsType<ReadRequest>(instance);
        }

        /// <summary>
        /// Test the property 'RequestHeader'
        /// </summary>
        [Fact]
        public void RequestHeaderTest()
        {
            // TODO unit test for the property 'RequestHeader'
        }

        /// <summary>
        /// Test the property 'MaxAge'
        /// </summary>
        [Fact]
        public void MaxAgeTest()
        {
            // TODO unit test for the property 'MaxAge'
        }

        /// <summary>
        /// Test the property 'TimestampsToReturn'
        /// </summary>
        [Fact]
        public void TimestampsToReturnTest()
        {
            // TODO unit test for the property 'TimestampsToReturn'
        }

        /// <summary>
        /// Test the property 'NodesToRead'
        /// </summary>
        [Fact]
        public void NodesToReadTest()
        {
            // TODO unit test for the property 'NodesToRead'
        }
    }
}
