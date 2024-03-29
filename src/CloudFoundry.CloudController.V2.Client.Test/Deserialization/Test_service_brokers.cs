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
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceBrokersTest
    {


        [TestMethod]
        public void TestListAllServiceBrokersResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""d134420e-74ad-4a30-8a57-d025cfb05bdd"",
        ""url"": ""/v2/service_brokers/d134420e-74ad-4a30-8a57-d025cfb05bdd"",
        ""created_at"": ""2015-02-19T03:52:40+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-229"",
        ""broker_url"": ""https://foo.com/url-23"",
        ""auth_username"": ""auth_username-7""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2f4217e5-fc4d-484e-bac8-4d92fe9acd14"",
        ""url"": ""/v2/service_brokers/2f4217e5-fc4d-484e-bac8-4d92fe9acd14"",
        ""created_at"": ""2015-02-19T03:52:40+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-230"",
        ""broker_url"": ""https://foo.com/url-24"",
        ""auth_username"": ""auth_username-8""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""938030a8-928c-4bd3-87fb-2ec27ecdc35a"",
        ""url"": ""/v2/service_brokers/938030a8-928c-4bd3-87fb-2ec27ecdc35a"",
        ""created_at"": ""2015-02-19T03:52:40+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-231"",
        ""broker_url"": ""https://foo.com/url-25"",
        ""auth_username"": ""auth_username-9""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBrokersResponse> page = Utilities.DeserializePage<ListAllServiceBrokersResponse>(json);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("d134420e-74ad-4a30-8a57-d025cfb05bdd", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/d134420e-74ad-4a30-8a57-d025cfb05bdd", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:40+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-229", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("https://foo.com/url-23", TestUtil.ToTestableString(page[0].BrokerUrl), true);
            Assert.AreEqual("auth_username-7", TestUtil.ToTestableString(page[0].AuthUsername), true);
            Assert.AreEqual("2f4217e5-fc4d-484e-bac8-4d92fe9acd14", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/2f4217e5-fc4d-484e-bac8-4d92fe9acd14", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:40+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-230", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("https://foo.com/url-24", TestUtil.ToTestableString(page[1].BrokerUrl), true);
            Assert.AreEqual("auth_username-8", TestUtil.ToTestableString(page[1].AuthUsername), true);
            Assert.AreEqual("938030a8-928c-4bd3-87fb-2ec27ecdc35a", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/938030a8-928c-4bd3-87fb-2ec27ecdc35a", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:40+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-231", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("https://foo.com/url-25", TestUtil.ToTestableString(page[2].BrokerUrl), true);
            Assert.AreEqual("auth_username-9", TestUtil.ToTestableString(page[2].AuthUsername), true);
        }

        [TestMethod]
        public void TestRetrieveServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""146dc2c6-83c8-4640-8be5-dfbf8cf94dc4"",
    ""url"": ""/v2/service_brokers/146dc2c6-83c8-4640-8be5-dfbf8cf94dc4"",
    ""created_at"": ""2015-02-19T03:52:41+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-241"",
    ""broker_url"": ""https://foo.com/url-35"",
    ""auth_username"": ""auth_username-19""
  }
}";

            RetrieveServiceBrokerResponse obj = Utilities.DeserializeJson<RetrieveServiceBrokerResponse>(json);

            Assert.AreEqual("146dc2c6-83c8-4640-8be5-dfbf8cf94dc4", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_brokers/146dc2c6-83c8-4640-8be5-dfbf8cf94dc4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-241", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://foo.com/url-35", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("auth_username-19", TestUtil.ToTestableString(obj.AuthUsername), true);
        }

        [TestMethod]
        public void TestCreateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""2edbddfb-a88f-485f-856c-f0ba0add98a5"",
    ""created_at"": ""2015-02-19T03:52:41+00:00"",
    ""updated_at"": null,
    ""url"": ""/v2/service_brokers/2edbddfb-a88f-485f-856c-f0ba0add98a5""
  },
  ""entity"": {
    ""name"": ""service-broker-name"",
    ""broker_url"": ""https://broker.example.com"",
    ""auth_username"": ""admin""
  }
}";

            CreateServiceBrokerResponse obj = Utilities.DeserializeJson<CreateServiceBrokerResponse>(json);

            Assert.AreEqual("2edbddfb-a88f-485f-856c-f0ba0add98a5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-02-19T03:52:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/2edbddfb-a88f-485f-856c-f0ba0add98a5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("service-broker-name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://broker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin", TestUtil.ToTestableString(obj.AuthUsername), true);
        }

        [TestMethod]
        public void TestUpdateServiceBrokerResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""9626bd4d-02f8-4163-9a4f-fa3246c9ccf6"",
    ""created_at"": ""2015-02-19T03:52:41+00:00"",
    ""updated_at"": ""2015-02-19T03:52:41+00:00"",
    ""url"": ""/v2/service_brokers/9626bd4d-02f8-4163-9a4f-fa3246c9ccf6""
  },
  ""entity"": {
    ""name"": ""name-238"",
    ""broker_url"": ""https://mybroker.example.com"",
    ""auth_username"": ""admin-user""
  }
}";

            UpdateServiceBrokerResponse obj = Utilities.DeserializeJson<UpdateServiceBrokerResponse>(json);

            Assert.AreEqual("9626bd4d-02f8-4163-9a4f-fa3246c9ccf6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-02-19T03:52:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-02-19T03:52:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("/v2/service_brokers/9626bd4d-02f8-4163-9a4f-fa3246c9ccf6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("name-238", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("https://mybroker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
            Assert.AreEqual("admin-user", TestUtil.ToTestableString(obj.AuthUsername), true);
        }
    }
}
