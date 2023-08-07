
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.Embeds
{
    using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using Newtonsoft.Json;
using SDK.Models.Shared;
using SDK.Utils;
    using System.Collections.Generic;
    public class GetEmbedAccessTokenRequest
    {
    /// <summary>
    /// The description of the embed access token.
    /// </summary>
        
        [JsonProperty("description")]
        public string? Description { get; set; }
        
    /// <summary>
    /// The duration (in minutes) of the embed access token.
    /// </summary>
        
        [JsonProperty("duration")]
        public int? Duration { get; set; }
        
    /// <summary>
    /// The filter to apply to the query.
    /// </summary>
        
        [JsonProperty("filters")]
        public Filters? Filters { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, GetEmbedAccessTokenRequest value, string baseUrl)
        {
            if("getEmbedAccessToken" == operationId)
            {
                var queryParams = new List<string>();
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "description", "", value.Description));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "duration", "", value.Duration));
                
                queryParams.Add($"filters={JsonConvert.SerializeObject(value.Filters, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }})}");
                var queryParamString = $"?{String.Join("&", queryParams)}";var urlString = baseUrl + "/v1/workspace/embed-access-token" + queryParamString;// #request-debugging Get 
                var message = UnityWebRequest.Get(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [GetEmbedAccessTokenRequest]");
        }
    }

}