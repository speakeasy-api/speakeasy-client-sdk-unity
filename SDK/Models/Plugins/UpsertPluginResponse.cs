
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SDK.Models.Plugins
{
    using UnityEngine.Networking;
using SDK.Models.Shared;
    using System.Collections.Generic;
    public class UpsertPluginResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Default error response
    /// </summary>
        public Error? Error { get; set; }
        
    /// <summary>
    /// OK
    /// </summary>
        public Plugin? Plugin { get; set; }
        
        public int StatusCode { get; set; }
        
        public UnityWebRequest? RawResponse { get; set; }
        
    }

}