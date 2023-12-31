
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
    using System.Collections.Generic;
using Newtonsoft.Json;
using SDK.Models.Shared;
    using System.Collections.Generic;
/// <summary>
/// Filters are used to query requests.
/// </summary>
    public class Filters
    {
    /// <summary>
    /// A list of filters to apply to the query.
    /// </summary>
        
        [JsonProperty("filters")]
        public List<Filter> FiltersValue { get; set; }
        
    /// <summary>
    /// The maximum number of results to return.
    /// </summary>
        
        [JsonProperty("limit")]
        public int Limit { get; set; }
        
    /// <summary>
    /// The offset to start the query from.
    /// </summary>
        
        [JsonProperty("offset")]
        public int Offset { get; set; }
        
    /// <summary>
    /// The operator to use when combining filters.
    /// </summary>
        
        [JsonProperty("operator")]
        public string Operator { get; set; }
        
    }

}