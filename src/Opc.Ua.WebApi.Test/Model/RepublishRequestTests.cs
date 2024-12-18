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
    ///  Class for testing RepublishRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RepublishRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RepublishRequest
        //private RepublishRequest instance;

        public RepublishRequestTests()
        {
            // TODO uncomment below to create an instance of RepublishRequest
            //instance = new RepublishRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RepublishRequest
        /// </summary>
        [Fact]
        public void RepublishRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RepublishRequest
            //Assert.IsType<RepublishRequest>(instance);
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
        /// Test the property 'SubscriptionId'
        /// </summary>
        [Fact]
        public void SubscriptionIdTest()
        {
            // TODO unit test for the property 'SubscriptionId'
        }

        /// <summary>
        /// Test the property 'RetransmitSequenceNumber'
        /// </summary>
        [Fact]
        public void RetransmitSequenceNumberTest()
        {
            // TODO unit test for the property 'RetransmitSequenceNumber'
        }
    }
}
