
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.Apis
{
    using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using Newtonsoft.Json;
using SDK.Utils;
    using System.Collections.Generic;
    public class GetAllApiVersionsRequest
    {
    /// <summary>
    /// The ID of the Api to retrieve.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// Metadata to filter Apis on
    /// </summary>
        
        [JsonProperty("metadata")]
        public Dictionary<string, List<string>>? Metadata { get; set; }
        
    /// <summary>
    /// Configuration for filter operations
    /// </summary>
        
        [JsonProperty("op")]
        public GetAllApiVersionsOp? Op { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, GetAllApiVersionsRequest value, string baseUrl)
        {
            if("getAllApiVersions" == operationId)
            {
                var queryParams = new List<string>();
                
                
                queryParams.Add(QueryParamSerializer.Serialize("deepObject",true, "metadata", "", value.Metadata));
                
                queryParams.Add(QueryParamSerializer.Serialize("deepObject",true, "op", "", value.Op));
                var queryParamString = $"?{String.Join("&", queryParams)}";
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var urlString = baseUrl + $"/v1/apis/{apiID}" + queryParamString;// #request-debugging Get 
                var message = UnityWebRequest.Get(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [GetAllApiVersionsRequest]");
        }
    }

}