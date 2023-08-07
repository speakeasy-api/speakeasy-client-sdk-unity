
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.Schemas
{
    using System;
using UnityEngine.Networking;
using Newtonsoft.Json;
using SDK.Utils;
    using System.Collections.Generic;
    public class DownloadSchemaRevisionRequest
    {
    /// <summary>
    /// The ID of the Api to retrieve schemas for.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// The revision ID of the schema to retrieve.
    /// </summary>
        
        [JsonProperty("revisionID")]
        public string RevisionID { get; set; }
        
    /// <summary>
    /// The version ID of the Api to delete metadata for.
    /// </summary>
        
        [JsonProperty("versionID")]
        public string VersionID { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, DownloadSchemaRevisionRequest value, string baseUrl)
        {
            if("downloadSchemaRevision" == operationId)
            {
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var revisionID = PathParamSerializer.Serialize("simple", false, value.RevisionID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);var urlString = baseUrl + $"/v1/apis/{apiID}/version/{versionID}/schema/{revisionID}/download";// #request-debugging Get 
                var message = UnityWebRequest.Get(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [DownloadSchemaRevisionRequest]");
        }
    }

}