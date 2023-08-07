
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
/// A filter is a key-value pair that can be used to filter a list of requests.
/// </summary>
    public class Filter
    {
    /// <summary>
    /// The key of the filter.
    /// </summary>
        
        [JsonProperty("key")]
        public string Key { get; set; }
        
    /// <summary>
    /// The operator of the filter.
    /// </summary>
        
        [JsonProperty("operator")]
        public string Operator { get; set; }
        
    /// <summary>
    /// The value of the filter.
    /// </summary>
        
        [JsonProperty("value")]
        public string Value { get; set; }
        
    }

}