# Org.OpenAPITools.Api.ProductFamilyApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IdPgLmtNameSkuEtc1**](ProductFamilyApi.md#idpglmtnameskuetc1) | **GET** /productFamily?ID&#x3D;{ID}&amp;Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Name&#x3D;{Name}&amp;Sku&#x3D;{Sku}&amp;ModifiedSince&#x3D;{ModifiedSince} | GET |
| [**ProductfamilyAttachmentsFamilyidGet**](ProductFamilyApi.md#productfamilyattachmentsfamilyidget) | **GET** /productFamily/attachments?FamilyID&#x3D;{FamilyID} | GET |
| [**ProductfamilyAttachmentsIdDelete**](ProductFamilyApi.md#productfamilyattachmentsiddelete) | **DELETE** /productFamily/attachments?ID&#x3D;{ID} | DELETE |
| [**ProductfamilyAttachmentsPost**](ProductFamilyApi.md#productfamilyattachmentspost) | **POST** /productFamily/attachments | POST |
| [**ProductfamilyPost**](ProductFamilyApi.md#productfamilypost) | **POST** /productFamily | POST |
| [**ProductfamilyPut**](ProductFamilyApi.md#productfamilyput) | **PUT** /productFamily | PUT |

<a id="idpglmtnameskuetc1"></a>
# **IdPgLmtNameSkuEtc1**
> IdPgLmtNameSkuEtc1200Response IdPgLmtNameSkuEtc1 (string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IdPgLmtNameSkuEtc1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductFamilyApi(config);
            var ID = "ID_example";  // string | Returns stock info of a particular product (Default: null)
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var name = "name_example";  // string | Only return products with product name containing specified name value (Default: null)
            var sku = "sku_example";  // string | Only return products with product sku containing specified sku value (Default: null)
            var modifiedSince = "modifiedSince_example";  // string | Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                IdPgLmtNameSkuEtc1200Response result = apiInstance.IdPgLmtNameSkuEtc1(ID, page, limit, name, sku, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFamilyApi.IdPgLmtNameSkuEtc1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IdPgLmtNameSkuEtc1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<IdPgLmtNameSkuEtc1200Response> response = apiInstance.IdPgLmtNameSkuEtc1WithHttpInfo(ID, page, limit, name, sku, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductFamilyApi.IdPgLmtNameSkuEtc1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | Returns stock info of a particular product (Default: null) |  |
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100) |  |
| **name** | **string** | Only return products with product name containing specified name value (Default: null) |  |
| **sku** | **string** | Only return products with product sku containing specified sku value (Default: null) |  |
| **modifiedSince** | **string** | Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null) |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**IdPgLmtNameSkuEtc1200Response**](IdPgLmtNameSkuEtc1200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productfamilyattachmentsfamilyidget"></a>
# **ProductfamilyAttachmentsFamilyidGet**
> List&lt;ProductAttachmentsPost200ResponseInner&gt; ProductfamilyAttachmentsFamilyidGet (string familyID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductfamilyAttachmentsFamilyidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductFamilyApi(config);
            var familyID = "familyID_example";  // string | Returns attachments info of a particular product family
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                List<ProductAttachmentsPost200ResponseInner> result = apiInstance.ProductfamilyAttachmentsFamilyidGet(familyID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyAttachmentsFamilyidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductfamilyAttachmentsFamilyidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<List<ProductAttachmentsPost200ResponseInner>> response = apiInstance.ProductfamilyAttachmentsFamilyidGetWithHttpInfo(familyID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyAttachmentsFamilyidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **familyID** | **string** | Returns attachments info of a particular product family |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**List&lt;ProductAttachmentsPost200ResponseInner&gt;**](ProductAttachmentsPost200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productfamilyattachmentsiddelete"></a>
# **ProductfamilyAttachmentsIdDelete**
> List&lt;ProductAttachmentsIdDelete200ResponseInner&gt; ProductfamilyAttachmentsIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductfamilyAttachmentsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductFamilyApi(config);
            var ID = "ID_example";  // string | ID of Product Family Attachment to delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // DELETE
                List<ProductAttachmentsIdDelete200ResponseInner> result = apiInstance.ProductfamilyAttachmentsIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyAttachmentsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductfamilyAttachmentsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>> response = apiInstance.ProductfamilyAttachmentsIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyAttachmentsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | ID of Product Family Attachment to delete |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;**](ProductAttachmentsIdDelete200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productfamilyattachmentspost"></a>
# **ProductfamilyAttachmentsPost**
> List&lt;ProductAttachmentsPost200ResponseInner&gt; ProductfamilyAttachmentsPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

POST

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductfamilyAttachmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductFamilyApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // POST
                List<ProductAttachmentsPost200ResponseInner> result = apiInstance.ProductfamilyAttachmentsPost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyAttachmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductfamilyAttachmentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<List<ProductAttachmentsPost200ResponseInner>> response = apiInstance.ProductfamilyAttachmentsPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyAttachmentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**List&lt;ProductAttachmentsPost200ResponseInner&gt;**](ProductAttachmentsPost200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productfamilypost"></a>
# **ProductfamilyPost**
> ProductfamilyPost200Response ProductfamilyPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductfamilyPostRequest? productfamilyPostRequest = null)

POST

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductfamilyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductFamilyApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var productfamilyPostRequest = new ProductfamilyPostRequest?(); // ProductfamilyPostRequest? |  (optional) 

            try
            {
                // POST
                ProductfamilyPost200Response result = apiInstance.ProductfamilyPost(apiAuthAccountid, apiAuthApplicationkey, productfamilyPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductfamilyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ProductfamilyPost200Response> response = apiInstance.ProductfamilyPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productfamilyPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **productfamilyPostRequest** | [**ProductfamilyPostRequest?**](ProductfamilyPostRequest?.md) |  | [optional]  |

### Return type

[**ProductfamilyPost200Response**](ProductfamilyPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productfamilyput"></a>
# **ProductfamilyPut**
> ProductfamilyPut200Response ProductfamilyPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductfamilyPutRequest? productfamilyPutRequest = null)

PUT

+ If you want provide products inside ProductFamilies PUT request, it will be added or updated. Delete operations are not allowed. So, it will be added to family if there are no such products were already added to product family, or it will be updated in case if these products are already were added before.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductfamilyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductFamilyApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var productfamilyPutRequest = new ProductfamilyPutRequest?(); // ProductfamilyPutRequest? |  (optional) 

            try
            {
                // PUT
                ProductfamilyPut200Response result = apiInstance.ProductfamilyPut(apiAuthAccountid, apiAuthApplicationkey, productfamilyPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductfamilyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductfamilyPut200Response> response = apiInstance.ProductfamilyPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productfamilyPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductFamilyApi.ProductfamilyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **productfamilyPutRequest** | [**ProductfamilyPutRequest?**](ProductfamilyPutRequest?.md) |  | [optional]  |

### Return type

[**ProductfamilyPut200Response**](ProductfamilyPut200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

