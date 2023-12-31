
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.ApiEndpoints
{
    using System;
using UnityEngine.Networking;
using Newtonsoft.Json;
using SDK.Utils;
    using System.Collections.Generic;
    public class GeneratePostmanCollectionForApiEndpointRequest
    {
    /// <summary>
    /// The ID of the ApiEndpoint to generate a Postman collection for.
    /// </summary>
        
        [JsonProperty("apiEndpointID")]
        public string ApiEndpointID { get; set; }
        
    /// <summary>
    /// The ID of the Api to generate a Postman collection for.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// The version ID of the Api to generate a Postman collection for.
    /// </summary>
        
        [JsonProperty("versionID")]
        public string VersionID { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, GeneratePostmanCollectionForApiEndpointRequest value, string baseUrl)
        {
            if("generatePostmanCollectionForApiEndpoint" == operationId)
            {
                
                var apiEndpointID = PathParamSerializer.Serialize("simple", false, value.ApiEndpointID);
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);var urlString = baseUrl + $"/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}/generate/postman";// #request-debugging Get 
                var message = UnityWebRequest.Get(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [GeneratePostmanCollectionForApiEndpointRequest]");
        }
    }

}