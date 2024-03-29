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
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpaceQuotaDefinitionsEndpoint.ListAllSpacesForSpaceQuotaDefinition()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/space_quota_definitions/list_all_spaces_for_the_space_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllSpacesForSpaceQuotaDefinitionResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllSpacesForSpaceQuotaDefinitionResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SpaceQuotaDefinitionsEndpoint.ListAllSpacesForSpaceQuotaDefinition()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/space_quota_definitions/list_all_spaces_for_the_space_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllSpacesForSpaceQuotaDefinitionResponse : IResponse
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
        /// <para>The Organization Guid</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Quota Definition Guid</para>
        /// </summary>
        [JsonProperty("space_quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceQuotaDefinitionGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Organization Url</para>
        /// </summary>
        [JsonProperty("organization_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Quota Definition Url</para>
        /// </summary>
        [JsonProperty("space_quota_definition_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceQuotaDefinitionUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Developers Url</para>
        /// </summary>
        [JsonProperty("developers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopersUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Managers Url</para>
        /// </summary>
        [JsonProperty("managers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagersUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Auditors Url</para>
        /// </summary>
        [JsonProperty("auditors_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditorsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Apps Url</para>
        /// </summary>
        [JsonProperty("apps_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Routes Url</para>
        /// </summary>
        [JsonProperty("routes_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutesUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Domains Url</para>
        /// </summary>
        [JsonProperty("domains_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainsUrl
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

        /// <summary> 
        /// <para>The App Events Url</para>
        /// </summary>
        [JsonProperty("app_events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppEventsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Events Url</para>
        /// </summary>
        [JsonProperty("events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string EventsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Security Groups Url</para>
        /// </summary>
        [JsonProperty("security_groups_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupsUrl
        {
            get;
            set;
        }
    }
}