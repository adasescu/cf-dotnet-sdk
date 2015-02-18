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
using CloudFoundry.CloudController.V2.Interfaces;
using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.Common.ServiceLocation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    public class SecurityGroupRunningDefaultsEndpoint: BaseEndpoint
    {
        public SecurityGroupRunningDefaultsEndpoint(CloudfoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }
    
        /// <summary>
        /// Return the Security Groups used for running Apps
        /// </summary>
    
        
        public async Task<PagedResponse<ReturnSecurityGroupsUsedForRunningAppsResponse>> ReturnSecurityGroupsUsedForRunningApps()
        {
            return await ReturnSecurityGroupsUsedForRunningApps(new RequestOptions());
        }
        
    
    
        public async Task<PagedResponse<ReturnSecurityGroupsUsedForRunningAppsResponse>> ReturnSecurityGroupsUsedForRunningApps(RequestOptions options)
    
        {
            string route = "/v2/config/running_security_groups";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await this.SendAsync(client);
        
            
            return Util.DeserializePage<ReturnSecurityGroupsUsedForRunningAppsResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Removing a Security Group as a default for running Apps
        /// </summary>
    
    
        public async Task RemovingSecurityGroupAsDefaultForRunningApps(Guid? guid)
    
        {
            string route = string.Format("/v2/config/running_security_groups/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            var response = await this.SendAsync(client);
        
        }
    
        /// <summary>
        /// Set a Security Group as a default for running Apps
        /// </summary>
    
    
        public async Task<SetSecurityGroupAsDefaultForRunningAppsResponse> SetSecurityGroupAsDefaultForRunningApps(Guid? guid)
    
        {
            string route = string.Format("/v2/config/running_security_groups/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            var response = await this.SendAsync(client);
        
            
            return Util.DeserializeJson<SetSecurityGroupAsDefaultForRunningAppsResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
    }
}