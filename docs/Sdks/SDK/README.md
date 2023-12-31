# SDK

## Overview

Speakeasy API: The Speakeasy API allows teams to manage common operations with their APIs

The Speakeasy Platform Documentation
<https://speakeasyapi.dev/docs/>
### Available Operations

* [ValidateApiKey](#validateapikey) - Validate the current api key.

## ValidateApiKey

Validate the current api key.

### Example Usage

```unity
using SDK;
using SDK.Models.Security;

var sdk = new SDKSDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.SDK.ValidateApiKeyAsync();
```


### Response

**[ValidateApiKeyResponse](../../Models/SDK/ValidateApiKeyResponse.md)**

