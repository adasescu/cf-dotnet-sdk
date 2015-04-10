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
    public class UserProvidedServiceInstancesEndpoint
{
        [TestMethod]
        public void DeleteUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.UserProvidedServiceInstances.DeleteUserProvidedServiceInstance(guid).Wait();

            }
        }

        [TestMethod]
        public void CreateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e830c569-a629-414b-9755-01fff5620f27"",
    ""url"": ""/v2/user_provided_service_instances/e830c569-a629-414b-9755-01fff5620f27"",
    ""created_at"": ""2015-04-10T19:42:02+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-user-provided-instance"",
    ""credentials"": {
      ""somekey"": ""somevalue""
    },
    ""space_guid"": ""9679e5cd-f7d9-4244-a63e-e080d113daa3"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""syslog://example.com"",
    ""space_url"": ""/v2/spaces/9679e5cd-f7d9-4244-a63e-e080d113daa3"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/e830c569-a629-414b-9755-01fff5620f27/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateUserProvidedServiceInstanceRequest value = new CreateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.CreateUserProvidedServiceInstance(value).Result;


                Assert.AreEqual("e830c569-a629-414b-9755-01fff5620f27", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/e830c569-a629-414b-9755-01fff5620f27", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:42:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-user-provided-instance", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("9679e5cd-f7d9-4244-a63e-e080d113daa3", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("syslog://example.com", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/9679e5cd-f7d9-4244-a63e-e080d113daa3", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/e830c569-a629-414b-9755-01fff5620f27/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5239c86c-4dbb-4f11-bb44-9751aa96e3f6"",
    ""url"": ""/v2/user_provided_service_instances/5239c86c-4dbb-4f11-bb44-9751aa96e3f6"",
    ""created_at"": ""2015-04-10T19:42:02+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1447"",
    ""credentials"": {
      ""creds-key-374"": ""creds-val-374""
    },
    ""space_guid"": ""8944e454-26b6-4b92-ab16-dd1438173554"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-95"",
    ""space_url"": ""/v2/spaces/8944e454-26b6-4b92-ab16-dd1438173554"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/5239c86c-4dbb-4f11-bb44-9751aa96e3f6/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.RetrieveUserProvidedServiceInstance(guid).Result;


                Assert.AreEqual("5239c86c-4dbb-4f11-bb44-9751aa96e3f6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5239c86c-4dbb-4f11-bb44-9751aa96e3f6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:42:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1447", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("8944e454-26b6-4b92-ab16-dd1438173554", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-95", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/8944e454-26b6-4b92-ab16-dd1438173554", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5239c86c-4dbb-4f11-bb44-9751aa96e3f6/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsForUserProvidedServiceInstanceTest()
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
        ""guid"": ""d8c2d648-070d-4579-8627-9f9539dee5e6"",
        ""url"": ""/v2/service_bindings/d8c2d648-070d-4579-8627-9f9539dee5e6"",
        ""created_at"": ""2015-04-10T19:42:02+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""e685ca22-c7dd-4581-945c-1455f58f8f2f"",
        ""service_instance_guid"": ""2df0610f-7ee3-41b1-a848-9474900698df"",
        ""credentials"": {
          ""creds-key-378"": ""creds-val-378""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/e685ca22-c7dd-4581-945c-1455f58f8f2f"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/2df0610f-7ee3-41b1-a848-9474900698df""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.ListAllServiceBindingsForUserProvidedServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("d8c2d648-070d-4579-8627-9f9539dee5e6", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/d8c2d648-070d-4579-8627-9f9539dee5e6", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:42:02+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("e685ca22-c7dd-4581-945c-1455f58f8f2f", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("2df0610f-7ee3-41b1-a848-9474900698df", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/e685ca22-c7dd-4581-945c-1455f58f8f2f", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/2df0610f-7ee3-41b1-a848-9474900698df", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void ListAllUserProvidedServiceInstancesTest()
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
        ""guid"": ""196477fd-e468-4e99-9917-a5fe49109048"",
        ""url"": ""/v2/user_provided_service_instances/196477fd-e468-4e99-9917-a5fe49109048"",
        ""created_at"": ""2015-04-10T19:42:02+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1428"",
        ""credentials"": {
          ""creds-key-362"": ""creds-val-362""
        },
        ""space_guid"": ""c72151b7-8fcb-407e-a0db-2a6965343546"",
        ""type"": ""user_provided_service_instance"",
        ""syslog_drain_url"": ""https://foo.com/url-91"",
        ""space_url"": ""/v2/spaces/c72151b7-8fcb-407e-a0db-2a6965343546"",
        ""service_bindings_url"": ""/v2/user_provided_service_instances/196477fd-e468-4e99-9917-a5fe49109048/service_bindings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.UserProvidedServiceInstances.ListAllUserProvidedServiceInstances().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("196477fd-e468-4e99-9917-a5fe49109048", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/196477fd-e468-4e99-9917-a5fe49109048", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:42:02+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1428", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("c72151b7-8fcb-407e-a0db-2a6965343546", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("https://foo.com/url-91", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/c72151b7-8fcb-407e-a0db-2a6965343546", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/196477fd-e468-4e99-9917-a5fe49109048/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void UpdateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8e64c270-6115-408c-b701-a7f38dc399e6"",
    ""url"": ""/v2/user_provided_service_instances/8e64c270-6115-408c-b701-a7f38dc399e6"",
    ""created_at"": ""2015-04-10T19:42:02+00:00"",
    ""updated_at"": ""2015-04-10T19:42:02+00:00""
  },
  ""entity"": {
    ""name"": ""name-1432"",
    ""credentials"": {
      ""somekey"": ""somenewvalue""
    },
    ""space_guid"": ""f254a019-7280-4508-9c03-1fa65ecbac23"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-92"",
    ""space_url"": ""/v2/spaces/f254a019-7280-4508-9c03-1fa65ecbac23"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/8e64c270-6115-408c-b701-a7f38dc399e6/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateUserProvidedServiceInstanceRequest value = new UpdateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.UpdateUserProvidedServiceInstance(guid, value).Result;


                Assert.AreEqual("8e64c270-6115-408c-b701-a7f38dc399e6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/8e64c270-6115-408c-b701-a7f38dc399e6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T19:42:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-10T19:42:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1432", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("f254a019-7280-4508-9c03-1fa65ecbac23", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-92", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/f254a019-7280-4508-9c03-1fa65ecbac23", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/8e64c270-6115-408c-b701-a7f38dc399e6/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

    }
}