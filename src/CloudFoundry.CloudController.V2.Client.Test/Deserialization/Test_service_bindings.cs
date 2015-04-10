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
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceBindingsTest
    {


        [TestMethod]
        public void TestRetrieveServiceBindingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c47fb829-9e1e-45e3-a751-6c75954e7a38"",
    ""url"": ""/v2/service_bindings/c47fb829-9e1e-45e3-a751-6c75954e7a38"",
    ""created_at"": ""2015-04-10T19:41:58+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""72f1f39d-cfe6-4307-b024-315e25c320f7"",
    ""service_instance_guid"": ""3398718d-515c-4d0c-b9ca-fcd50aa0fc9d"",
    ""credentials"": {
      ""creds-key-234"": ""creds-val-234""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/72f1f39d-cfe6-4307-b024-315e25c320f7"",
    ""service_instance_url"": ""/v2/service_instances/3398718d-515c-4d0c-b9ca-fcd50aa0fc9d""
  }
}";

            RetrieveServiceBindingResponse obj = Utilities.DeserializeJson<RetrieveServiceBindingResponse>(json);

            Assert.AreEqual("c47fb829-9e1e-45e3-a751-6c75954e7a38", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/c47fb829-9e1e-45e3-a751-6c75954e7a38", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T19:41:58+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("72f1f39d-cfe6-4307-b024-315e25c320f7", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("3398718d-515c-4d0c-b9ca-fcd50aa0fc9d", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/72f1f39d-cfe6-4307-b024-315e25c320f7", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/service_instances/3398718d-515c-4d0c-b9ca-fcd50aa0fc9d", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceBindingsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3c455477-0f1e-4434-95db-28c442d85360"",
        ""url"": ""/v2/service_bindings/3c455477-0f1e-4434-95db-28c442d85360"",
        ""created_at"": ""2015-04-10T19:41:57+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""a5a0d9cf-d327-4745-aca1-cfda90ec50f9"",
        ""service_instance_guid"": ""293284fd-4edc-4f1e-a0d2-e6831f2f148a"",
        ""credentials"": {
          ""creds-key-221"": ""creds-val-221""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/a5a0d9cf-d327-4745-aca1-cfda90ec50f9"",
        ""service_instance_url"": ""/v2/service_instances/293284fd-4edc-4f1e-a0d2-e6831f2f148a""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsResponse> page = Utilities.DeserializePage<ListAllServiceBindingsResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("3c455477-0f1e-4434-95db-28c442d85360", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/3c455477-0f1e-4434-95db-28c442d85360", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T19:41:57+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("a5a0d9cf-d327-4745-aca1-cfda90ec50f9", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("293284fd-4edc-4f1e-a0d2-e6831f2f148a", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/a5a0d9cf-d327-4745-aca1-cfda90ec50f9", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/service_instances/293284fd-4edc-4f1e-a0d2-e6831f2f148a", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceBindingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""59a41f21-b344-4d67-903b-279c09a0e89d"",
    ""url"": ""/v2/service_bindings/59a41f21-b344-4d67-903b-279c09a0e89d"",
    ""created_at"": ""2015-04-10T19:41:57+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""922b26a5-8fd7-4467-8ceb-19d05603257d"",
    ""service_instance_guid"": ""e8383ba8-bb88-4a04-a934-e4a3ca7a3f85"",
    ""credentials"": {
      ""creds-key-227"": ""creds-val-227""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/922b26a5-8fd7-4467-8ceb-19d05603257d"",
    ""service_instance_url"": ""/v2/user_provided_service_instances/e8383ba8-bb88-4a04-a934-e4a3ca7a3f85""
  }
}";

            CreateServiceBindingResponse obj = Utilities.DeserializeJson<CreateServiceBindingResponse>(json);

            Assert.AreEqual("59a41f21-b344-4d67-903b-279c09a0e89d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/59a41f21-b344-4d67-903b-279c09a0e89d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T19:41:57+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("922b26a5-8fd7-4467-8ceb-19d05603257d", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("e8383ba8-bb88-4a04-a934-e4a3ca7a3f85", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/922b26a5-8fd7-4467-8ceb-19d05603257d", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/e8383ba8-bb88-4a04-a934-e4a3ca7a3f85", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
        }
    }
}
