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
    public class StacksEndpoint
{
        [TestMethod]
        public void RetrieveStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""7b22d965-fbd7-4068-9cae-371cce502503"",
    ""url"": ""/v2/stacks/7b22d965-fbd7-4068-9cae-371cce502503"",
    ""created_at"": ""2015-04-10T19:41:57+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""lucid64"",
    ""description"": ""Ubuntu 10.04 on x86-64""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Stacks.RetrieveStack(guid).Result;


                Assert.AreEqual("7b22d965-fbd7-4068-9cae-371cce502503", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/7b22d965-fbd7-4068-9cae-371cce502503", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:41:57+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("lucid64", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("Ubuntu 10.04 on x86-64", TestUtil.ToTestableString(obj.Description), true);

            }
        }

        [TestMethod]
        public void ListAllStacksTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""7b22d965-fbd7-4068-9cae-371cce502503"",
        ""url"": ""/v2/stacks/7b22d965-fbd7-4068-9cae-371cce502503"",
        ""created_at"": ""2015-04-10T19:41:57+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""lucid64"",
        ""description"": ""Ubuntu 10.04 on x86-64""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""fa76cbd6-100c-4b19-ba46-9795143d5d75"",
        ""url"": ""/v2/stacks/fa76cbd6-100c-4b19-ba46-9795143d5d75"",
        ""created_at"": ""2015-04-10T19:41:57+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default-stack-name"",
        ""description"": ""default-stack-description""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""a68fd1df-a238-412a-8be4-aa39d4aa924d"",
        ""url"": ""/v2/stacks/a68fd1df-a238-412a-8be4-aa39d4aa924d"",
        ""created_at"": ""2015-04-10T19:41:57+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cider"",
        ""description"": ""cider-description""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Stacks.ListAllStacks().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("7b22d965-fbd7-4068-9cae-371cce502503", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/7b22d965-fbd7-4068-9cae-371cce502503", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:41:57+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("lucid64", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("Ubuntu 10.04 on x86-64", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("fa76cbd6-100c-4b19-ba46-9795143d5d75", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/fa76cbd6-100c-4b19-ba46-9795143d5d75", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:41:57+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("default-stack-name", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("default-stack-description", TestUtil.ToTestableString(obj[1].Description), true);
                Assert.AreEqual("a68fd1df-a238-412a-8be4-aa39d4aa924d", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/a68fd1df-a238-412a-8be4-aa39d4aa924d", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:41:57+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cider", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("cider-description", TestUtil.ToTestableString(obj[2].Description), true);

            }
        }

        [TestMethod]
        public void DeleteStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.Stacks.DeleteStack(guid).Wait();

            }
        }

    }
}