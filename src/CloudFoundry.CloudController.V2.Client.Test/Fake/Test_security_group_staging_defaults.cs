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
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupStagingDefaultsEndpoint
{
        [TestMethod]
        public void RemovingSecurityGroupAsDefaultForStagingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SecurityGroupStagingDefaults.RemovingSecurityGroupAsDefaultForStaging(guid).Wait();

            }
        }

        [TestMethod]
        public void SetSecurityGroupAsDefaultForStagingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""3b67c90b-f63c-4b2f-9143-6340e52e8749"",
    ""url"": ""/v2/config/staging_security_groups/3b67c90b-f63c-4b2f-9143-6340e52e8749"",
    ""created_at"": ""2015-03-25T13:48:54+00:00"",
    ""updated_at"": ""2015-03-25T13:48:54+00:00""
  },
  ""entity"": {
    ""name"": ""name-1601"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": false,
    ""staging_default"": true
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroupStagingDefaults.SetSecurityGroupAsDefaultForStaging(guid).Result;


                Assert.AreEqual("3b67c90b-f63c-4b2f-9143-6340e52e8749", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/staging_security_groups/3b67c90b-f63c-4b2f-9143-6340e52e8749", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:54+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-03-25T13:48:54+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1601", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.StagingDefault), true);

            }
        }

        [TestMethod]
        public void ReturnSecurityGroupsUsedForStagingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""5485110c-44c6-4158-96de-0f0899883cea"",
        ""url"": ""/v2/config/staging_security_groups/5485110c-44c6-4158-96de-0f0899883cea"",
        ""created_at"": ""2015-03-25T13:48:54+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1600"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": true
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SecurityGroupStagingDefaults.ReturnSecurityGroupsUsedForStaging().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("5485110c-44c6-4158-96de-0f0899883cea", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/staging_security_groups/5485110c-44c6-4158-96de-0f0899883cea", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:54+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1600", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].RunningDefault), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].StagingDefault), true);

            }
        }

    }
}