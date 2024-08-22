# CIN7.DearInventory.Api.ProductApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                   | HTTP request                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | Description |
| ---------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**IdPgLmtNameSkuEtc**](ProductApi.md#idpglmtnameskuetc)                                 | **GET** /product?ID&#x3D;{ID}&amp;Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Name&#x3D;{Name}&amp;Sku&#x3D;{Sku}&amp;ModifiedSince&#x3D;{ModifiedSince}&amp;IncludeDeprecated&#x3D;{IncludeDeprecated}&amp;IncludeBOM&#x3D;{IncludeBOM}&amp;IncludeSuppliers&#x3D;{IncludeSuppliers}&amp;IncludeMovements&#x3D;{IncludeMovements}&amp;IncludeAttachments&#x3D;{IncludeAttachments}&amp;IncludeReorderLevels&#x3D;{IncludeReorderLevels}&amp;IncludeCustomPrices&#x3D;{IncludeCustomPrices} | GET         |
| [**ProductAttachmentsIdDelete**](ProductApi.md#productattachmentsiddelete)               | **DELETE** /product/attachments?ID&#x3D;{ID}                                                                                                                                                                                                                                                                                                                                                                                                                                                | DELETE      |
| [**ProductAttachmentsPost**](ProductApi.md#productattachmentspost)                       | **POST** /product/attachments                                                                                                                                                                                                                                                                                                                                                                                                                                                               | POST        |
| [**ProductAttachmentsProductidGet**](ProductApi.md#productattachmentsproductidget)       | **GET** /product/attachments?ProductID&#x3D;{ProductID}                                                                                                                                                                                                                                                                                                                                                                                                                                     | GET         |
| [**ProductPost**](ProductApi.md#productpost)                                             | **POST** /product                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | POST        |
| [**ProductPut**](ProductApi.md#productput)                                               | **PUT** /product                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | PUT         |
| [**ProductavailabilityPgLmtIdNameEtc**](ProductApi.md#productavailabilitypglmtidnameetc) | **GET** /ref/productavailability?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;Sku&#x3D;{Sku}&amp;Location&#x3D;{Location}&amp;Batch&#x3D;{Batch}&amp;Category&#x3D;{Category}                                                                                                                                                                                                                                                                          | GET         |

<a id="idpglmtnameskuetc"></a>

# **IdPgLmtNameSkuEtc**

> void IdPgLmtNameSkuEtc (string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class IdPgLmtNameSkuEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductApi(config);
            var ID = "ID_example";  // string | Returns stock info of a particular product (Default: null)
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var name = "name_example";  // string | Only return products with product name containing specified name value (Default: null)
            var sku = "sku_example";  // string | Only return products with product sku containing specified sku value (Default: null)
            var modifiedSince = "modifiedSince_example";  // string | Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)
            var includeDeprecated = true;  // bool | Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)
            var includeBOM = true;  // bool | Include Bill Of Materials information (Default: false)
            var includeSuppliers = true;  // bool | Include Suppliers information (Default: false)
            var includeMovements = true;  // bool | Include Movements information (Default: false)
            var includeAttachments = true;  // bool | Include Attachments information (Default: false)
            var includeReorderLevels = true;  // bool | Include Reorder Levels information (Default: false)
            var includeCustomPrices = true;  // bool | Include Customer specific Prices (Default: false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.IdPgLmtNameSkuEtc(ID, page, limit, name, sku, modifiedSince, includeDeprecated, includeBOM, includeSuppliers, includeMovements, includeAttachments, includeReorderLevels, includeCustomPrices, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.IdPgLmtNameSkuEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IdPgLmtNameSkuEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.IdPgLmtNameSkuEtcWithHttpInfo(ID, page, limit, name, sku, modifiedSince, includeDeprecated, includeBOM, includeSuppliers, includeMovements, includeAttachments, includeReorderLevels, includeCustomPrices, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.IdPgLmtNameSkuEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                                                                                                                   | Notes      |
| ------------------------- | ----------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------- |
| **ID**                    | **string**  | Returns stock info of a particular product (Default: null)                                                                                                                    |            |
| **page**                  | **decimal** | Page (Default: 1)                                                                                                                                                             |            |
| **limit**                 | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100)                                                                                              |            |
| **name**                  | **string**  | Only return products with product name containing specified name value (Default: null)                                                                                        |            |
| **sku**                   | **string**  | Only return products with product sku containing specified sku value (Default: null)                                                                                          |            |
| **modifiedSince**         | **string**  | Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)                                                                             |            |
| **includeDeprecated**     | **bool**    | Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false) |            |
| **includeBOM**            | **bool**    | Include Bill Of Materials information (Default: false)                                                                                                                        |            |
| **includeSuppliers**      | **bool**    | Include Suppliers information (Default: false)                                                                                                                                |            |
| **includeMovements**      | **bool**    | Include Movements information (Default: false)                                                                                                                                |            |
| **includeAttachments**    | **bool**    | Include Attachments information (Default: false)                                                                                                                              |            |
| **includeReorderLevels**  | **bool**    | Include Reorder Levels information (Default: false)                                                                                                                           |            |
| **includeCustomPrices**   | **bool**    | Include Customer specific Prices (Default: false)                                                                                                                             |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                                                                                     | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                                                                                     | [optional] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

-   **Content-Type**: Not defined
-   **Accept**: Not defined

### HTTP response details

| Status code | Description | Response headers |
| ----------- | ----------- | ---------------- |
| **200**     | OK          | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productattachmentsiddelete"></a>

# **ProductAttachmentsIdDelete**

> List&lt;ProductAttachmentsIdDelete200ResponseInner&gt; ProductAttachmentsIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductAttachmentsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductApi(config);
            var ID = "ID_example";  // string | ID of Product Attachment to delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                List<ProductAttachmentsIdDelete200ResponseInner> result = apiInstance.ProductAttachmentsIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAttachmentsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAttachmentsIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>> response = apiInstance.ProductAttachmentsIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAttachmentsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Product Attachment to delete        |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;**](ProductAttachmentsIdDelete200ResponseInner.md)

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

<a id="productattachmentspost"></a>

# **ProductAttachmentsPost**

> List&lt;ProductAttachmentsPost200ResponseInner&gt; ProductAttachmentsPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

POST

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductAttachmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                List<ProductAttachmentsPost200ResponseInner> result = apiInstance.ProductAttachmentsPost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAttachmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAttachmentsPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<List<ProductAttachmentsPost200ResponseInner>> response = apiInstance.ProductAttachmentsPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAttachmentsPostWithHttpInfo: " + e.Message);
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

[**List&lt;ProductAttachmentsPost200ResponseInner&gt;**](ProductAttachmentsPost200ResponseInner.md)

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

<a id="productattachmentsproductidget"></a>

# **ProductAttachmentsProductidGet**

> List&lt;ProductAttachmentsPost200ResponseInner&gt; ProductAttachmentsProductidGet (string productID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ProductAttachmentsProductidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductApi(config);
            var productID = "productID_example";  // string | Returns attachments info of a particular product
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                List<ProductAttachmentsPost200ResponseInner> result = apiInstance.ProductAttachmentsProductidGet(productID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductAttachmentsProductidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductAttachmentsProductidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<List<ProductAttachmentsPost200ResponseInner>> response = apiInstance.ProductAttachmentsProductidGetWithHttpInfo(productID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductAttachmentsProductidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                      | Notes      |
| ------------------------- | ----------- | ------------------------------------------------ | ---------- |
| **productID**             | **string**  | Returns attachments info of a particular product |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b        | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033        | [optional] |

### Return type

[**List&lt;ProductAttachmentsPost200ResponseInner&gt;**](ProductAttachmentsPost200ResponseInner.md)

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

<a id="productpost"></a>

# **ProductPost**

> ProductPost200Response ProductPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductPostRequest? productPostRequest = null)

POST

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productPostRequest = new ProductPostRequest?(); // ProductPostRequest? |  (optional)

            try
            {
                // POST
                ProductPost200Response result = apiInstance.ProductPost(apiAuthAccountid, apiAuthApplicationkey, productPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ProductPost200Response> response = apiInstance.ProductPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                              | Description                               | Notes      |
| ------------------------- | ------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productPostRequest**    | [**ProductPostRequest?**](ProductPostRequest?.md) |                                           | [optional] |

### Return type

[**ProductPost200Response**](ProductPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

-   **Content-Type**: application/json
-   **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
| ----------- | ----------- | ---------------- |
| **200**     | OK          | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productput"></a>

# **ProductPut**

> ProductPut200Response ProductPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductPutRequest? productPutRequest = null)

PUT

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productPutRequest = new ProductPutRequest?(); // ProductPutRequest? |  (optional)

            try
            {
                // PUT
                ProductPut200Response result = apiInstance.ProductPut(apiAuthAccountid, apiAuthApplicationkey, productPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductPut200Response> response = apiInstance.ProductPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                            | Description                               | Notes      |
| ------------------------- | ----------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productPutRequest**     | [**ProductPutRequest?**](ProductPutRequest?.md) |                                           | [optional] |

### Return type

[**ProductPut200Response**](ProductPut200Response.md)

### Authorization

No authorization required

### HTTP request headers

-   **Content-Type**: application/json
-   **Accept**: application/json

### HTTP response details

| Status code | Description | Response headers |
| ----------- | ----------- | ---------------- |
| **200**     | OK          | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productavailabilitypglmtidnameetc"></a>

# **ProductavailabilityPgLmtIdNameEtc**

> ProductavailabilityPgLmtIdNameEtc200Response ProductavailabilityPgLmtIdNameEtc (decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ProductavailabilityPgLmtIdNameEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "\"null\"";  // string |  (default to "null")
            var name = "\"null\"";  // string |  (default to "null")
            var sku = "\"null\"";  // string |  (default to "null")
            var location = "\"\"\"\"";  // string |  (default to """")
            var batch = "\"\"\"\"";  // string |  (default to """")
            var category = "\"\"\"\"";  // string |  (default to """")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                ProductavailabilityPgLmtIdNameEtc200Response result = apiInstance.ProductavailabilityPgLmtIdNameEtc(page, limit, ID, name, sku, location, batch, category, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductApi.ProductavailabilityPgLmtIdNameEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductavailabilityPgLmtIdNameEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ProductavailabilityPgLmtIdNameEtc200Response> response = apiInstance.ProductavailabilityPgLmtIdNameEtcWithHttpInfo(page, limit, ID, name, sku, location, batch, category, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductApi.ProductavailabilityPgLmtIdNameEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes                                 |
| ------------------------- | ----------- | ----------------------------------------- | ------------------------------------- |
| **page**                  | **decimal** |                                           | [default to 1M]                       |
| **limit**                 | **decimal** |                                           | [default to 100M]                     |
| **ID**                    | **string**  |                                           | [default to &quot;null&quot;]         |
| **name**                  | **string**  |                                           | [default to &quot;null&quot;]         |
| **sku**                   | **string**  |                                           | [default to &quot;null&quot;]         |
| **location**              | **string**  |                                           | [default to &quot;&quot;&quot;&quot;] |
| **batch**                 | **string**  |                                           | [default to &quot;&quot;&quot;&quot;] |
| **category**              | **string**  |                                           | [default to &quot;&quot;&quot;&quot;] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]                            |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]                            |

### Return type

[**ProductavailabilityPgLmtIdNameEtc200Response**](ProductavailabilityPgLmtIdNameEtc200Response.md)

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
