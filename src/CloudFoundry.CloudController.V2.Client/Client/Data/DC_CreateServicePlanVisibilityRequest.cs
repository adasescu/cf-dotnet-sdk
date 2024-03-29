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
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlanVisibilitiesEndpoint.CreateServicePlanVisibility()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_plan_visibilities/creating_a_service_plan_visibility.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateServicePlanVisibilityRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateServicePlanVisibilityRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlanVisibilitiesEndpoint.CreateServicePlanVisibility()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_plan_visibilities/creating_a_service_plan_visibility.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateServicePlanVisibilityRequest
    {

        /// <summary> 
        /// <para>The guid of the plan that will be made visible</para>
        /// </summary>
        [JsonProperty("service_plan_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicePlanGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the organization the plan will be visible to</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }
    }
}