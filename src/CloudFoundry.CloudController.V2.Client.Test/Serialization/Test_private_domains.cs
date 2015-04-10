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

using CloudFoundry.CloudController.V2.Client;
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
    public class PrivateDomainsTest
    {

        [TestMethod]
        public void TestCreatePrivateDomainOwnedByGivenOrganizationRequest()
        {
            string json = @"{
  ""name"": ""exmaple.com"",
  ""owning_organization_guid"": ""2bc72cfe-1f15-4a08-a881-c25c8686d0bc""
}";

            CreatePrivateDomainOwnedByGivenOrganizationRequest request = new CreatePrivateDomainOwnedByGivenOrganizationRequest();

            request.Name = "exmaple.com";
            request.OwningOrganizationGuid = new Guid("2bc72cfe-1f15-4a08-a881-c25c8686d0bc");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
