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
    ///  Class for testing HistoryReadResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class HistoryReadResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for HistoryReadResult
        //private HistoryReadResult instance;

        public HistoryReadResultTests()
        {
            // TODO uncomment below to create an instance of HistoryReadResult
            //instance = new HistoryReadResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HistoryReadResult
        /// </summary>
        [Fact]
        public void HistoryReadResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" HistoryReadResult
            //Assert.IsType<HistoryReadResult>(instance);
        }

        /// <summary>
        /// Test the property 'StatusCode'
        /// </summary>
        [Fact]
        public void StatusCodeTest()
        {
            // TODO unit test for the property 'StatusCode'
        }

        /// <summary>
        /// Test the property 'ContinuationPoint'
        /// </summary>
        [Fact]
        public void ContinuationPointTest()
        {
            // TODO unit test for the property 'ContinuationPoint'
        }

        /// <summary>
        /// Test the property 'HistoryData'
        /// </summary>
        [Fact]
        public void HistoryDataTest()
        {
            // TODO unit test for the property 'HistoryData'
        }
    }
}
