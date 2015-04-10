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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;


namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// SpaceQuotaDefinitions Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SpaceQuotaDefinitionsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractSpaceQuotaDefinitionsEndpoint
    {
        internal SpaceQuotaDefinitionsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for SpaceQuotaDefinitions Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSpaceQuotaDefinitionsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractSpaceQuotaDefinitionsEndpoint()
        {
        }

        /// <summary>
        /// Updating a Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/updating_a_space_quota_definition.html"</para>
        /// </summary>
        public async Task<UpdateSpaceQuotaDefinitionResponse> UpdateSpaceQuotaDefinition(Guid? guid, UpdateSpaceQuotaDefinitionRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/space_quota_definitions/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateSpaceQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/creating_a_space_quota_definition.html"</para>
        /// </summary>
        public async Task<CreateSpaceQuotaDefinitionResponse> CreateSpaceQuotaDefinition(CreateSpaceQuotaDefinitionRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/space_quota_definitions";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateSpaceQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Spaces for the Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/list_all_spaces_for_the_space_quota_definition.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForSpaceQuotaDefinitionResponse>> ListAllSpacesForSpaceQuotaDefinition(Guid? guid)
        {
            return await ListAllSpacesForSpaceQuotaDefinition(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Spaces for the Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/list_all_spaces_for_the_space_quota_definition.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForSpaceQuotaDefinitionResponse>> ListAllSpacesForSpaceQuotaDefinition(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/space_quota_definitions/{0}/spaces", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForSpaceQuotaDefinitionResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Associate Space with the Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/associate_space_with_the_space_quota_definition.html"</para>
        /// </summary>
        public async Task<AssociateSpaceWithSpaceQuotaDefinitionResponse> AssociateSpaceWithSpaceQuotaDefinition(Guid? guid, Guid? space_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/space_quota_definitions/{0}/spaces/{1}", guid, space_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateSpaceWithSpaceQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/retrieve_a_particular_space_quota_definition.html"</para>
        /// </summary>
        public async Task<RetrieveSpaceQuotaDefinitionResponse> RetrieveSpaceQuotaDefinition(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/space_quota_definitions/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveSpaceQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/delete_a_particular_space_quota_definition.html"</para>
        /// </summary>
        public async Task DeleteSpaceQuotaDefinition(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/space_quota_definitions/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Remove Space from the Space Quota Definition
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/remove_space_from_the_space_quota_definition.html"</para>
        /// </summary>
        public async Task<RemoveSpaceFromSpaceQuotaDefinitionResponse> RemoveSpaceFromSpaceQuotaDefinition(Guid? guid, Guid? space_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/space_quota_definitions/{0}/spaces/{1}", guid, space_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveSpaceFromSpaceQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Space Quota Definitions
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/list_all_space_quota_definitions.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsResponse>> ListAllSpaceQuotaDefinitions()
        {
            return await ListAllSpaceQuotaDefinitions(new RequestOptions());
        }

        /// <summary>
        /// List all Space Quota Definitions
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/space_quota_definitions/list_all_space_quota_definitions.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpaceQuotaDefinitionsResponse>> ListAllSpaceQuotaDefinitions(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/space_quota_definitions";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpaceQuotaDefinitionsResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }
    }
}
