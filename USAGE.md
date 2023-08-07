<!-- Start SDK Example Usage -->


```unity
using SDK;
using SDK.Models.Security;
using SDK.Models.Apis;

var sdk = new SDKSDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.GetApisAsync(new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "provident", new List<string>() {
            "quibusdam",
            "unde",
            "nulla",
        } },
        { "corrupti", new List<string>() {
            "vel",
            "error",
            "deserunt",
            "suscipit",
        } },
        { "iure", new List<string>() {
            "debitis",
            "ipsa",
        } },
    },
    Op = new GetApisOp() {
        And = false,
    },
});
```
<!-- End SDK Example Usage -->