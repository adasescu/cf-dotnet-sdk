﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloudFoundry.CloudController.V2;
using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using CloudFoundry.UAA;

namespace CloudFoundry.CloudController.Test.Integration
{
    [TestClass]
    public class ApplicationTest
    {
        static CloudFoundryClient client;
        static Guid orgGuid;
        static Guid spaceGuid;
        static Guid stackGuid;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            client = TestUtil.GetClient();
            CloudCredentials credentials = new CloudCredentials();
            credentials.User = TestUtil.User;
            credentials.Password = TestUtil.Password;
            try
            {
                client.Login(credentials).Wait();
            }
            catch (Exception ex)
            {
                Assert.Fail("Error while loging in" + ex.ToString());
            }

            CreateOrganizationRequest org = new CreateOrganizationRequest();
            org.Name = "test_" + Guid.NewGuid().ToString();
            var newOrg = client.Organizations.CreateOrganization(org).Result;
            orgGuid = new Guid(newOrg.EntityMetadata.Guid);

            CreateSpaceRequest spc = new CreateSpaceRequest();
            spc.Name = "test_" + Guid.NewGuid().ToString();
            spc.OrganizationGuid = orgGuid;
            var newSpace = client.Spaces.CreateSpace(spc).Result;
            spaceGuid = new Guid(newSpace.EntityMetadata.Guid);

            stackGuid = new Guid(client.Stacks.ListAllStacks().Result[0].EntityMetadata.Guid);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            client.Spaces.DeleteSpace(spaceGuid).Wait();

            client.Organizations.DeleteOrganization(orgGuid).Wait();

        }

        [TestMethod]
        public void Application_test()
        {
            CreateAppResponse newApp = null;
            GetAppSummaryResponse readApp = null;
            UpdateAppResponse updateApp = null;

            CreateAppRequest app = new CreateAppRequest();
            app.Name = Guid.NewGuid().ToString();
            app.SpaceGuid = spaceGuid;
            app.Instances = 1;
            app.Memory = 256;
            app.StackGuid = stackGuid;

            try
            {
                newApp = client.Apps.CreateApp(app).Result;
            }
            catch (Exception ex)
            {
                Assert.Fail("Error creating app: {0}", ex.ToString());
            }
            Assert.IsNotNull(newApp);

            try
            {
                readApp = client.Apps.GetAppSummary(new Guid(newApp.EntityMetadata.Guid)).Result;
            }
            catch (Exception ex)
            {
                Assert.Fail("Error reading app: {0}", ex.ToString());
            }
            Assert.IsNotNull(readApp);
            Assert.AreEqual(app.Name, readApp.Name);

            UpdateAppRequest updateAppRequest = new UpdateAppRequest();
            updateAppRequest.Memory = 512;
            try
            {
                updateApp = client.Apps.UpdateApp(new Guid(newApp.EntityMetadata.Guid), updateAppRequest).Result;
            }
            catch (Exception ex)
            {
                Assert.Fail("Error updating app: {0}", ex.ToString());
            }
            Assert.IsNotNull(updateApp);
            Assert.AreEqual(updateAppRequest.Memory, updateApp.Memory);

            try
            {
                client.Apps.DeleteApp(new Guid(newApp.EntityMetadata.Guid)).Wait();
            }
            catch (Exception ex)
            {
                Assert.Fail("Error deleting app: {0}", ex.ToString());
            }
        }
    }
}
