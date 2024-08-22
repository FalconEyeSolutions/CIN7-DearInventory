# CIN7.DearInventory.Api.ProductMarkupPricesApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                           | HTTP request                                             | Description |
| ------------------------------------------------------------------------------------------------ | -------------------------------------------------------- | ----------- |
| [**ProductMarkuppricesProductidGet**](ProductMarkupPricesApi.md#productmarkuppricesproductidget) | **GET** /product/markupprices?ProductID&#x3D;{ProductID} | GET         |
| [**ProductMarkuppricesPut**](ProductMarkupPricesApi.md#productmarkuppricesput)                   | **PUT** /product/markupprices                            | PUT         |

<a id="productmarkuppricesproductidget"></a>

# **ProductMarkuppricesProductidGet**

> ProductMarkuppricesProductidGet200Response ProductMarkuppricesProductidGet (string productID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Method will return all markup price tiers. If markup does not exist, `MarkupType` will be equal to `D`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductMarkuppricesProductidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductMarkupPricesApi(config);
            var productID = "productID_example";  // string | Returns detailed info of a particular Product Markup Prices
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                ProductMarkuppricesProductidGet200Response result = apiInstance.ProductMarkuppricesProductidGet(productID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductMarkupPricesApi.ProductMarkuppricesProductidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductMarkuppricesProductidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ProductMarkuppricesProductidGet200Response> response = apiInstance.ProductMarkuppricesProductidGetWithHttpInfo(productID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductMarkupPricesApi.ProductMarkuppricesProductidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                 | Notes      |
| ------------------------- | ----------- | ----------------------------------------------------------- | ---------- |
| **productID**             | **string**  | Returns detailed info of a particular Product Markup Prices |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                   | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                   | [optional] |

### Return type

[**ProductMarkuppricesProductidGet200Response**](ProductMarkuppricesProductidGet200Response.md)

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

<a id="productmarkuppricesput"></a>

# **ProductMarkuppricesPut**

> ProductMarkuppricesPut200Response ProductMarkuppricesPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

PUT

-   If markup line for given price tier does not exist, it will be created. If markup line for given price tier exists, it will be updated. If markup line has `MarkupType` equal to `D`, markup line will be deleted.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductMarkuppricesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductMarkupPricesApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // PUT
                ProductMarkuppricesPut200Response result = apiInstance.ProductMarkuppricesPut(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductMarkupPricesApi.ProductMarkuppricesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductMarkuppricesPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductMarkuppricesPut200Response> response = apiInstance.ProductMarkuppricesPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductMarkupPricesApi.ProductMarkuppricesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**ProductMarkuppricesPut200Response**](ProductMarkuppricesPut200Response.md)

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
