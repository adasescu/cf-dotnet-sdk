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
    public class SharedDomainsEndpoint
{
        [TestMethod]
        public void FilterSharedDomainsByNameTest()
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
        ""guid"": ""72175309-1196-4fac-be79-41653ad8b0d8"",
        ""url"": ""/v2/shared_domains/72175309-1196-4fac-be79-41653ad8b0d8"",
        ""created_at"": ""2015-03-25T13:48:58+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""shared-domain.com""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.FilterSharedDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("72175309-1196-4fac-be79-41653ad8b0d8", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/72175309-1196-4fac-be79-41653ad8b0d8", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("shared-domain.com", TestUtil.ToTestableString(obj[0].Name), true);

            }
        }

        [TestMethod]
        public void CreateSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""bb7a3adf-3869-4c3a-bd2c-f62e6219a6e2"",
    ""url"": ""/v2/shared_domains/bb7a3adf-3869-4c3a-bd2c-f62e6219a6e2"",
    ""created_at"": ""2015-03-25T13:48:58+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSharedDomainRequest value = new CreateSharedDomainRequest();


                var obj = cfClient.SharedDomains.CreateSharedDomain(value).Result;


                Assert.AreEqual("bb7a3adf-3869-4c3a-bd2c-f62e6219a6e2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/bb7a3adf-3869-4c3a-bd2c-f62e6219a6e2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);

            }
        }

        [TestMethod]
        public void DeleteSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SharedDomains.DeleteSharedDomain(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllSharedDomainsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""de2ac534-0f0a-4a85-83a1-b5f495a012f6"",
        ""url"": ""/v2/shared_domains/de2ac534-0f0a-4a85-83a1-b5f495a012f6"",
        ""created_at"": ""2015-03-25T13:48:57+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ce1467f4-e038-4958-8877-96a260e79cf6"",
        ""url"": ""/v2/shared_domains/ce1467f4-e038-4958-8877-96a260e79cf6"",
        ""created_at"": ""2015-03-25T13:48:57+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""3aae5c44-3811-4fb6-b85f-191bdc90c998"",
        ""url"": ""/v2/shared_domains/3aae5c44-3811-4fb6-b85f-191bdc90c998"",
        ""created_at"": ""2015-03-25T13:48:58+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-46.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""54f649ec-7407-4b0e-8efa-ef013f2a2c17"",
        ""url"": ""/v2/shared_domains/54f649ec-7407-4b0e-8efa-ef013f2a2c17"",
        ""created_at"": ""2015-03-25T13:48:58+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-47.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""71e2de02-d74c-497f-a8ee-1f856e220ddb"",
        ""url"": ""/v2/shared_domains/71e2de02-d74c-497f-a8ee-1f856e220ddb"",
        ""created_at"": ""2015-03-25T13:48:58+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-48.example.com""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.ListAllSharedDomains().Result;

                Assert.AreEqual("5", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("de2ac534-0f0a-4a85-83a1-b5f495a012f6", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/de2ac534-0f0a-4a85-83a1-b5f495a012f6", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:57+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("ce1467f4-e038-4958-8877-96a260e79cf6", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/ce1467f4-e038-4958-8877-96a260e79cf6", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:57+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("3aae5c44-3811-4fb6-b85f-191bdc90c998", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/3aae5c44-3811-4fb6-b85f-191bdc90c998", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-46.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("54f649ec-7407-4b0e-8efa-ef013f2a2c17", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/54f649ec-7407-4b0e-8efa-ef013f2a2c17", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-47.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("71e2de02-d74c-497f-a8ee-1f856e220ddb", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/71e2de02-d74c-497f-a8ee-1f856e220ddb", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-48.example.com", TestUtil.ToTestableString(obj[4].Name), true);

            }
        }

        [TestMethod]
        public void RetrieveSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""de2ac534-0f0a-4a85-83a1-b5f495a012f6"",
    ""url"": ""/v2/shared_domains/de2ac534-0f0a-4a85-83a1-b5f495a012f6"",
    ""created_at"": ""2015-03-25T13:48:57+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""customer-app-domain1.com""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SharedDomains.RetrieveSharedDomain(guid).Result;


                Assert.AreEqual("de2ac534-0f0a-4a85-83a1-b5f495a012f6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/de2ac534-0f0a-4a85-83a1-b5f495a012f6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:57+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj.Name), true);

            }
        }

    }
}