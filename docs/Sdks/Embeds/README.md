# embeds

## Overview

REST APIs for managing embeds

### Available Operations

* [GetEmbedAccessToken](#getembedaccesstoken) - Get an embed access token for the current workspace.
* [GetValidEmbedAccessTokens](#getvalidembedaccesstokens) - Get all valid embed access tokens for the current workspace.
* [RevokeEmbedAccessToken](#revokeembedaccesstoken) - Revoke an embed access EmbedToken.

## GetEmbedAccessToken

Returns an embed access token for the current workspace. This can be used to authenticate access to externally embedded content.
Filters can be applied allowing views to be filtered to things like particular customerIds.

### Example Usage

```unity
using SDK;
using SDK.Models.Security;
using SDK.Models.Embeds;
using SDK.Models.Shared;

var sdk = new SDKSDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Embeds.GetEmbedAccessTokenAsync(new GetEmbedAccessTokenRequest() {
    Description = "laborum",
    Duration = 170909,
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "corporis",
                Operator = "explicabo",
                Value = "nobis",
            },
        },
        Limit = 315428,
        Offset = 607831,
        Operator = "nemo",
    },
});
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetEmbedAccessTokenRequest](../../Models/Embeds/GetEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetEmbedAccessTokenResponse](../../Models/Embeds/GetEmbedAccessTokenResponse.md)**


## GetValidEmbedAccessTokens

Get all valid embed access tokens for the current workspace.

### Example Usage

```unity
using SDK;
using SDK.Models.Security;
using SDK.Models.Embeds;

var sdk = new SDKSDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Embeds.GetValidEmbedAccessTokensAsync();
```


### Response

**[GetValidEmbedAccessTokensResponse](../../Models/Embeds/GetValidEmbedAccessTokensResponse.md)**


## RevokeEmbedAccessToken

Revoke an embed access EmbedToken.

### Example Usage

```unity
using SDK;
using SDK.Models.Security;
using SDK.Models.Embeds;

var sdk = new SDKSDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Embeds.RevokeEmbedAccessTokenAsync(new RevokeEmbedAccessTokenRequest() {
    TokenID = "minima",
});
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [RevokeEmbedAccessTokenRequest](../../Models/Embeds/RevokeEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[RevokeEmbedAccessTokenResponse](../../Models/Embeds/RevokeEmbedAccessTokenResponse.md)**

