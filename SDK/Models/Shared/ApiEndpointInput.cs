
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
    using Newtonsoft.Json;
    using System.Collections.Generic;
/// <summary>
/// An ApiEndpoint is a description of an Endpoint for an API.
/// </summary>
    public class ApiEndpointInput
    {
    /// <summary>
    /// The ID of this ApiEndpoint. This is a hash of the method and path.
    /// </summary>
        
        [JsonProperty("api_endpoint_id")]
        public string ApiEndpointId { get; set; }
        
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
    /// The version ID of the Api this ApiEndpoint belongs to.
    /// </summary>
        
        [JsonProperty("version_id")]
        public string VersionId { get; set; }
        
    }

}