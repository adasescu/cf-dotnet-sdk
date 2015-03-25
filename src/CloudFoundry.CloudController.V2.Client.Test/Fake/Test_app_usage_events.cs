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
    public class AppUsageEventsEndpoint
{
        [TestMethod]
        public void ListAllAppUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 2,
  ""total_pages"": 2,
  ""prev_url"": null,
  ""next_url"": ""/v2/app_usage_events?after_guid=f09f18f8-bfe7-4445-9e9d-47d7e19f6a60=asc=2=1"",
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""56f200a5-8350-4333-8200-217ff88526a3"",
        ""url"": ""/v2/app_usage_events/56f200a5-8350-4333-8200-217ff88526a3"",
        ""created_at"": ""2015-03-25T13:48:55+00:00""
      },
      ""entity"": {
        ""state"": ""STARTED"",
        ""memory_in_mb_per_instance"": 564,
        ""instance_count"": 1,
        ""app_guid"": ""guid-27e50f6a-b31d-44c4-8119-42554b4116ad"",
        ""app_name"": ""name-1686"",
        ""space_guid"": ""guid-edf19795-e53b-4e66-9be9-e8b7716d1994"",
        ""space_name"": ""name-1687"",
        ""org_guid"": ""guid-394816c1-8d16-4ede-9980-c030b16688df"",
        ""buildpack_guid"": ""guid-f9f78774-635f-4e48-bb0b-480491033302"",
        ""buildpack_name"": ""name-1688"",
        ""package_state"": ""STAGED""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.AppUsageEvents.ListAllAppUsageEvents().Result;

                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("/v2/app_usage_events?after_guid=f09f18f8-bfe7-4445-9e9d-47d7e19f6a60=asc=2=1", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("56f200a5-8350-4333-8200-217ff88526a3", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/app_usage_events/56f200a5-8350-4333-8200-217ff88526a3", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:55+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("STARTED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("564", TestUtil.ToTestableString(obj[0].MemoryInMbPerInstance), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].InstanceCount), true);
                Assert.AreEqual("guid-27e50f6a-b31d-44c4-8119-42554b4116ad", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("name-1686", TestUtil.ToTestableString(obj[0].AppName), true);
                Assert.AreEqual("guid-edf19795-e53b-4e66-9be9-e8b7716d1994", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("name-1687", TestUtil.ToTestableString(obj[0].SpaceName), true);
                Assert.AreEqual("guid-394816c1-8d16-4ede-9980-c030b16688df", TestUtil.ToTestableString(obj[0].OrgGuid), true);
                Assert.AreEqual("guid-f9f78774-635f-4e48-bb0b-480491033302", TestUtil.ToTestableString(obj[0].BuildpackGuid), true);
                Assert.AreEqual("name-1688", TestUtil.ToTestableString(obj[0].BuildpackName), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj[0].PackageState), true);

            }
        }

        [TestMethod]
        public void RetrieveAppUsageEventTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4d80b6f4-3855-4593-ab9c-bd6819728274"",
    ""url"": ""/v2/app_usage_events/4d80b6f4-3855-4593-ab9c-bd6819728274"",
    ""created_at"": ""2015-03-25T13:48:55+00:00""
  },
  ""entity"": {
    ""state"": ""STARTED"",
    ""memory_in_mb_per_instance"": 564,
    ""instance_count"": 1,
    ""app_guid"": ""guid-757db051-b4c6-46dc-a7a1-0b6355503d75"",
    ""app_name"": ""name-1692"",
    ""space_guid"": ""guid-9297a346-b60d-4d3a-8a52-8557b8fbac4d"",
    ""space_name"": ""name-1693"",
    ""org_guid"": ""guid-962d2cf1-57b2-418e-ae6a-c1c29e5c1067"",
    ""buildpack_guid"": ""guid-da3c1b86-8957-4d93-ae02-624059ed62c5"",
    ""buildpack_name"": ""name-1694"",
    ""package_state"": ""STAGED""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.AppUsageEvents.RetrieveAppUsageEvent(guid).Result;


                Assert.AreEqual("4d80b6f4-3855-4593-ab9c-bd6819728274", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/app_usage_events/4d80b6f4-3855-4593-ab9c-bd6819728274", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:55+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("STARTED", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("564", TestUtil.ToTestableString(obj.MemoryInMbPerInstance), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.InstanceCount), true);
                Assert.AreEqual("guid-757db051-b4c6-46dc-a7a1-0b6355503d75", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("name-1692", TestUtil.ToTestableString(obj.AppName), true);
                Assert.AreEqual("guid-9297a346-b60d-4d3a-8a52-8557b8fbac4d", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("name-1693", TestUtil.ToTestableString(obj.SpaceName), true);
                Assert.AreEqual("guid-962d2cf1-57b2-418e-ae6a-c1c29e5c1067", TestUtil.ToTestableString(obj.OrgGuid), true);
                Assert.AreEqual("guid-da3c1b86-8957-4d93-ae02-624059ed62c5", TestUtil.ToTestableString(obj.BuildpackGuid), true);
                Assert.AreEqual("name-1694", TestUtil.ToTestableString(obj.BuildpackName), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj.PackageState), true);

            }
        }

        [TestMethod]
        public void PurgeAndReseedAppUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();


                cfClient.AppUsageEvents.PurgeAndReseedAppUsageEvents().Wait();

            }
        }

    }
}