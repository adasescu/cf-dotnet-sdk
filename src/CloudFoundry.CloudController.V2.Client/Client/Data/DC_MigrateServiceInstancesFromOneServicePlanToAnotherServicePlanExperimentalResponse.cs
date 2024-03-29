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
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimental()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_instances/migrate_service_instances_from_one_service_plan_to_another_service_plan_(experimental).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractMigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimental()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_instances/migrate_service_instances_from_one_service_plan_to_another_service_plan_(experimental).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractMigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse : IResponse
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
        /// <para>The Changed Count</para>
        /// </summary>
        [JsonProperty("changed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangedCount
        {
            get;
            set;
        }
    }
}