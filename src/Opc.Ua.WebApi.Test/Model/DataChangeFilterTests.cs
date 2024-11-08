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
    ///  Class for testing DataChangeFilter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DataChangeFilterTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DataChangeFilter
        //private DataChangeFilter instance;

        public DataChangeFilterTests()
        {
            // TODO uncomment below to create an instance of DataChangeFilter
            //instance = new DataChangeFilter();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataChangeFilter
        /// </summary>
        [Fact]
        public void DataChangeFilterInstanceTest()
        {
            // TODO uncomment below to test "IsType" DataChangeFilter
            //Assert.IsType<DataChangeFilter>(instance);
        }

        /// <summary>
        /// Test the property 'Trigger'
        /// </summary>
        [Fact]
        public void TriggerTest()
        {
            // TODO unit test for the property 'Trigger'
        }

        /// <summary>
        /// Test the property 'DeadbandType'
        /// </summary>
        [Fact]
        public void DeadbandTypeTest()
        {
            // TODO unit test for the property 'DeadbandType'
        }

        /// <summary>
        /// Test the property 'DeadbandValue'
        /// </summary>
        [Fact]
        public void DeadbandValueTest()
        {
            // TODO unit test for the property 'DeadbandValue'
        }
    }
}
