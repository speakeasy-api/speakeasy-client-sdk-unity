
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Metadata
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SDK.Models.Metadata;
using SDK.Models.Shared;
using SDK.Utils;

    public interface IMetadataSDK
    {
        Task<DeleteVersionMetadataResponse> DeleteVersionMetadataAsync(DeleteVersionMetadataRequest? request = null);
        Task<GetVersionMetadataResponse> GetVersionMetadataAsync(GetVersionMetadataRequest? request = null);
        Task<InsertVersionMetadataResponse> InsertVersionMetadataAsync(InsertVersionMetadataRequest request);
    }

    public class MetadataSDK: IMetadataSDK
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

        public MetadataSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Delete metadata for a particular apiID and versionID.
    /// </summary>
    public async Task<DeleteVersionMetadataResponse> DeleteVersionMetadataAsync(DeleteVersionMetadataRequest? request = null)
    {
        string baseUrl = "";
        var message = DeleteVersionMetadataRequest.BuildHttpRequestMessage("deleteVersionMetadata", request, baseUrl);
        var client = _securityClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new DeleteVersionMetadataResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get all metadata for a particular apiID and versionID.
    /// </summary>
    public async Task<GetVersionMetadataResponse> GetVersionMetadataAsync(GetVersionMetadataRequest? request = null)
    {
        string baseUrl = "";
        var message = GetVersionMetadataRequest.BuildHttpRequestMessage("getVersionMetadata", request, baseUrl);
        var client = _securityClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new GetVersionMetadataResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.VersionMetadata = JsonConvert.DeserializeObject<List<VersionMetadata>>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Insert metadata for a particular apiID and versionID.
    /// </summary>
    public async Task<InsertVersionMetadataResponse> InsertVersionMetadataAsync(InsertVersionMetadataRequest request)
    {
        string baseUrl = "";
        var message = InsertVersionMetadataRequest.BuildHttpRequestMessage("insertVersionMetadata", request, baseUrl);
        var client = _securityClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new InsertVersionMetadataResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.VersionMetadata = JsonConvert.DeserializeObject<VersionMetadata>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    }
}