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
    public class OrganizationQuotaDefinitionsTest
    {

        [TestMethod]
        public void TestCreateOrganizationQuotaDefinitionRequest()
        {
            string json = @"{
  ""name"": ""gold_quota"",
  ""non_basic_services_allowed"": true,
  ""total_services"": 5,
  ""total_routes"": 10,
  ""memory_limit"": 5120,
  ""instance_memory_limit"": 10240
}";

            CreateOrganizationQuotaDefinitionRequest request = new CreateOrganizationQuotaDefinitionRequest();

            request.Name = "gold_quota";
            request.NonBasicServicesAllowed = true;
            request.TotalServices = 5;
            request.TotalRoutes = 10;
            request.MemoryLimit = 5120;
            request.InstanceMemoryLimit = 10240;
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
    }
}
