
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.Shared
{
    using System;
using Newtonsoft.Json;
    using System.Collections.Generic;
/// <summary>
/// An ApiEndpoint is a description of an Endpoint for an API.
/// </summary>
    public class ApiEndpoint
    {
    /// <summary>
    /// The ID of this ApiEndpoint. This is a hash of the method and path.
    /// </summary>
        
        [JsonProperty("api_endpoint_id")]
        public string ApiEndpointId { get; set; }
        
    /// <summary>
    /// The ID of the Api this ApiEndpoint belongs to.
    /// </summary>
        
        [JsonProperty("api_id")]
        public string ApiId { get; set; }
        
    /// <summary>
    /// Creation timestamp.
    /// </summary>
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
    /// <summary>
    /// A detailed description of the ApiEndpoint.
    /// </summary>
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
    /// <summary>
    /// A human-readable name for the ApiEndpoint.
    /// </summary>
        
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        
    /// <summary>
    /// Determines if the endpoint was found in the OpenAPI spec associated with the parent Api.
    /// </summary>
        
        [JsonProperty("matched")]
        public bool? Matched { get; set; }
        
    /// <summary>
    /// HTTP verb.
    /// </summary>
        
        [JsonProperty("method")]
        public string Method { get; set; }
        
    /// <summary>
    /// Path that handles this Api.
    /// </summary>
        
        [JsonProperty("path")]
        public string Path { get; set; }
        
    /// <summary>
    /// Last update timestamp.
    /// </summary>
        
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        
    /// <summary>
    /// The version ID of the Api this ApiEndpoint belongs to.
    /// </summary>
        
        [JsonProperty("version_id")]
        public string VersionId { get; set; }
        
    /// <summary>
    /// The workspace ID this ApiEndpoint belongs to.
    /// </summary>
        
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }
        
    }

}