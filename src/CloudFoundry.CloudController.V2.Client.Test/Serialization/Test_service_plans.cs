//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicePlansTest
    {

        [TestMethod]
        public void TestUpdateServicePlanDeprecatedRequest()
        {
            string json = @"{
  ""name"": ""100mb"",
  ""free"": true,
  ""description"": ""Let's you put data in your database!"",
  ""service_guid"": ""a8263069-a4f5-4c9d-b6c8-e70871c38d6d""
}";

            UpdateServicePlanDeprecatedRequest request = new UpdateServicePlanDeprecatedRequest();

            request.Name = "100mb";
            request.Free = true;
            request.Description = "Let's you put data in your database!";
            request.ServiceGuid = new Guid("a8263069-a4f5-4c9d-b6c8-e70871c38d6d");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
        [TestMethod]
        public void TestCreateServicePlanDeprecatedRequest()
        {
            string json = @"{
  ""name"": ""100mb"",
  ""free"": true,
  ""description"": ""Let's you put data in your database!"",
  ""service_guid"": ""9d8f2095-e6de-4158-a684-b1d97db494e7""
}";

            CreateServicePlanDeprecatedRequest request = new CreateServicePlanDeprecatedRequest();

            request.Name = "100mb";
            request.Free = true;
            request.Description = "Let's you put data in your database!";
            request.ServiceGuid = new Guid("9d8f2095-e6de-4158-a684-b1d97db494e7");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
    }
}
