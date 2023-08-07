
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Requests
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SDK.Models.Requests;
using SDK.Models.Shared;
using SDK.Utils;

    public interface IRequestsSDK
    {
        Task<GenerateRequestPostmanCollectionResponse> GenerateRequestPostmanCollectionAsync(GenerateRequestPostmanCollectionRequest? request = null);
        Task<GetRequestFromEventLogResponse> GetRequestFromEventLogAsync(GetRequestFromEventLogRequest? request = null);
        Task<QueryEventLogResponse> QueryEventLogAsync(QueryEventLogRequest? request = null);
    }

    public class RequestsSDK: IRequestsSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.3.0";
        // TODO: code review, is this more work required here to convert to a base URL?
        public Uri ServerUrl { get { return new Uri(_defaultClient.Client.url); } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public RequestsSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Generate a Postman collection for a particular request.
    /// 
    /// <remarks>
    /// Generates a Postman collection for a particular request. 
    /// Allowing it to be replayed with the same inputs that were captured by the SDK.
    /// </remarks>
    /// </summary>
    public async Task<GenerateRequestPostmanCollectionResponse> GenerateRequestPostmanCollectionAsync(GenerateRequestPostmanCollectionRequest? request = null)
    {
        string baseUrl = "";
        var message = GenerateRequestPostmanCollectionRequest.BuildHttpRequestMessage("generateRequestPostmanCollection", request, baseUrl);
        var client = _securityClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new GenerateRequestPostmanCollectionResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/octet-stream",response.ContentType))
            {
                response.PostmanCollection = httpResponseMessage.downloadHandler.data;
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get information about a particular request.
    /// </summary>
    public async Task<GetRequestFromEventLogResponse> GetRequestFromEventLogAsync(GetRequestFromEventLogRequest? request = null)
    {
        string baseUrl = "";
        var message = GetRequestFromEventLogRequest.BuildHttpRequestMessage("getRequestFromEventLog", request, baseUrl);
        var client = _securityClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new GetRequestFromEventLogResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.UnboundedRequest = JsonConvert.DeserializeObject<UnboundedRequest>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Query the event log to retrieve a list of requests.
    /// 
    /// <remarks>
    /// Supports retrieving a list of request captured by the SDK for this workspace.
    /// Allows the filtering of requests on a number of criteria such as ApiID, VersionID, Path, Method, etc.
    /// </remarks>
    /// </summary>
    public async Task<QueryEventLogResponse> QueryEventLogAsync(QueryEventLogRequest? request = null)
    {
        string baseUrl = "";
        var message = QueryEventLogRequest.BuildHttpRequestMessage("queryEventLog", request, baseUrl);
        var client = _securityClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new QueryEventLogResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.BoundedRequests = JsonConvert.DeserializeObject<List<BoundedRequest>>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    }
}