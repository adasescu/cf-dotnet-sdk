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
    public class JobsTest
    {


        [TestMethod]
        public void TestRetrieveJobWithKnownFailureResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""117d029d-0874-470e-948d-8228ce7b199e"",
    ""created_at"": ""2015-02-19T03:53:02+00:00"",
    ""url"": ""/v2/jobs/117d029d-0874-470e-948d-8228ce7b199e""
  },
  ""entity"": {
    ""guid"": ""117d029d-0874-470e-948d-8228ce7b199e"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";

            RetrieveJobWithKnownFailureResponse obj = Utilities.DeserializeJson<RetrieveJobWithKnownFailureResponse>(json);

            Assert.AreEqual("117d029d-0874-470e-948d-8228ce7b199e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-02-19T03:53:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/117d029d-0874-470e-948d-8228ce7b199e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("117d029d-0874-470e-948d-8228ce7b199e", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
            Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);
        }

        [TestMethod]
        public void TestRetrieveJobThatIsQueuedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""44bd0164-e566-499a-b76a-f839d0a79659"",
    ""created_at"": ""2015-02-19T03:53:02+00:00"",
    ""url"": ""/v2/jobs/44bd0164-e566-499a-b76a-f839d0a79659""
  },
  ""entity"": {
    ""guid"": ""44bd0164-e566-499a-b76a-f839d0a79659"",
    ""status"": ""queued""
  }
}";

            RetrieveJobThatIsQueuedResponse obj = Utilities.DeserializeJson<RetrieveJobThatIsQueuedResponse>(json);

            Assert.AreEqual("44bd0164-e566-499a-b76a-f839d0a79659", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-02-19T03:53:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/44bd0164-e566-499a-b76a-f839d0a79659", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("44bd0164-e566-499a-b76a-f839d0a79659", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);
        }

        [TestMethod]
        public void TestRetrieveJobThatWasSuccessfulResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0"",
    ""created_at"": ""1970-01-01T00:00:00+00:00"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""0"",
    ""status"": ""finished""
  }
}";

            RetrieveJobThatWasSuccessfulResponse obj = Utilities.DeserializeJson<RetrieveJobThatWasSuccessfulResponse>(json);

            Assert.AreEqual("0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("1970-01-01T00:00:00+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("0", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);
        }

        [TestMethod]
        public void TestRetrieveJobWithUnknownFailureResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c39dd48a-9f41-45f3-937e-2831aec52b04"",
    ""created_at"": ""2015-02-19T03:53:02+00:00"",
    ""url"": ""/v2/jobs/c39dd48a-9f41-45f3-937e-2831aec52b04""
  },
  ""entity"": {
    ""guid"": ""c39dd48a-9f41-45f3-937e-2831aec52b04"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";

            RetrieveJobWithUnknownFailureResponse obj = Utilities.DeserializeJson<RetrieveJobWithUnknownFailureResponse>(json);

            Assert.AreEqual("c39dd48a-9f41-45f3-937e-2831aec52b04", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2015-02-19T03:53:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/c39dd48a-9f41-45f3-937e-2831aec52b04", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("c39dd48a-9f41-45f3-937e-2831aec52b04", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
            Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);
        }
    }
}