# CIN7.DearInventory.Api.TemplatesApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                           | HTTP request                                                                                             | Description |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | ----------- |
| [**RefTemplatesPgLmtTypeNameGet**](TemplatesApi.md#reftemplatespglmttypenameget) | **GET** /ref/templates?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Type&#x3D;{Type}&amp;Name&#x3D;{Name} | GET         |

<a id="reftemplatespglmttypenameget"></a>

# **RefTemplatesPgLmtTypeNameGet**

> RefTemplatesPgLmtTypeNameGet200Response RefTemplatesPgLmtTypeNameGet (decimal page, decimal limit, string type, string name, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class RefTemplatesPgLmtTypeNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new TemplatesApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var type = "type_example";  // string | Only return templates with the specific Type
            var name = "name_example";  // string | Only return templates with the specific Name
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                RefTemplatesPgLmtTypeNameGet200Response result = apiInstance.RefTemplatesPgLmtTypeNameGet(page, limit, type, name, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplatesApi.RefTemplatesPgLmtTypeNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefTemplatesPgLmtTypeNameGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<RefTemplatesPgLmtTypeNameGet200Response> response = apiInstance.RefTemplatesPgLmtTypeNameGetWithHttpInfo(page, limit, type, name, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplatesApi.RefTemplatesPgLmtTypeNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                  | Notes             |
| ------------------------- | ----------- | -------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                              | [default to 1M]   |
| **limit**                 | **decimal** |                                              | [default to 100M] |
| **type**                  | **string**  | Only return templates with the specific Type |                   |
| **name**                  | **string**  | Only return templates with the specific Name |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b    | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033    | [optional]        |

### Return type

[**RefTemplatesPgLmtTypeNameGet200Response**](RefTemplatesPgLmtTypeNameGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

-   **Content-Type**: Not defined
-   **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
| ----------- | ----------- | ---------------- |
| **200**     | OK          | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
