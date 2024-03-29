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
    public class ServicePlanVisibilitiesTest
    {

        [TestMethod]
        public void TestUpdateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""1505d66d-87e6-4fe3-9f0b-fecc2697a3ce"",
  ""organization_guid"": ""ac830dd9-eae3-4944-80b9-be953c70438b""
}";

            UpdateServicePlanVisibilityRequest request = new UpdateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("1505d66d-87e6-4fe3-9f0b-fecc2697a3ce");
            request.OrganizationGuid = new Guid("ac830dd9-eae3-4944-80b9-be953c70438b");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
        [TestMethod]
        public void TestCreateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""aff02fda-a6d9-473a-9864-ec624845559c"",
  ""organization_guid"": ""dabb3d25-1246-426b-b5af-2c6a021af7fd""
}";

            CreateServicePlanVisibilityRequest request = new CreateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("aff02fda-a6d9-473a-9864-ec624845559c");
            request.OrganizationGuid = new Guid("dabb3d25-1246-426b-b5af-2c6a021af7fd");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
    }
}
