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
    ///  Class for testing ActivateSessionRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ActivateSessionRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ActivateSessionRequest
        //private ActivateSessionRequest instance;

        public ActivateSessionRequestTests()
        {
            // TODO uncomment below to create an instance of ActivateSessionRequest
            //instance = new ActivateSessionRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ActivateSessionRequest
        /// </summary>
        [Fact]
        public void ActivateSessionRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" ActivateSessionRequest
            //Assert.IsType<ActivateSessionRequest>(instance);
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
        /// Test the property 'ClientSignature'
        /// </summary>
        [Fact]
        public void ClientSignatureTest()
        {
            // TODO unit test for the property 'ClientSignature'
        }

        /// <summary>
        /// Test the property 'ClientSoftwareCertificates'
        /// </summary>
        [Fact]
        public void ClientSoftwareCertificatesTest()
        {
            // TODO unit test for the property 'ClientSoftwareCertificates'
        }

        /// <summary>
        /// Test the property 'LocaleIds'
        /// </summary>
        [Fact]
        public void LocaleIdsTest()
        {
            // TODO unit test for the property 'LocaleIds'
        }

        /// <summary>
        /// Test the property 'UserIdentityToken'
        /// </summary>
        [Fact]
        public void UserIdentityTokenTest()
        {
            // TODO unit test for the property 'UserIdentityToken'
        }

        /// <summary>
        /// Test the property 'UserTokenSignature'
        /// </summary>
        [Fact]
        public void UserTokenSignatureTest()
        {
            // TODO unit test for the property 'UserTokenSignature'
        }
    }
}
