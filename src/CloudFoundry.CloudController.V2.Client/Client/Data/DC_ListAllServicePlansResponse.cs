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

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServicePlansEndpoint.ListAllServicePlans()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_plans/list_all_service_plans.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllServicePlansResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllServicePlansResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServicePlansEndpoint.ListAllServicePlans()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_plans/list_all_service_plans.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllServicePlansResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Free</para>
        /// </summary>
        [JsonProperty("free", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Free
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Description</para>
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Guid</para>
        /// </summary>
        [JsonProperty("service_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Extra</para>
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Extra
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Unique Id</para>
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UniqueId
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Public</para>
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Active</para>
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Url</para>
        /// </summary>
        [JsonProperty("service_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Instances Url</para>
        /// </summary>
        [JsonProperty("service_instances_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceInstancesUrl
        {
            get;
            set;
        }
    }
}