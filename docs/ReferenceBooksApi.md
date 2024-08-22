# Org.OpenAPITools.Api.ReferenceBooksApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomPricesPost**](ReferenceBooksApi.md#custompricespost) | **POST** /custom-prices | POST |
| [**CustomPricesProductidCustomeridDelete**](ReferenceBooksApi.md#custompricesproductidcustomeriddelete) | **DELETE** /custom-prices?ProductID&#x3D;{ProductID}&amp;CustomerID&#x3D;{CustomerID} | DELETE |
| [**CustomPricesPut**](ReferenceBooksApi.md#custompricesput) | **PUT** /custom-prices | PUT |
| [**Get**](ReferenceBooksApi.md#get) | **GET** /reference/shipZonesEnabled | Get |
| [**ProductSuppliersPost**](ReferenceBooksApi.md#productsupplierspost) | **POST** /product-suppliers | POST |
| [**ProductSuppliersProductidGet**](ReferenceBooksApi.md#productsuppliersproductidget) | **GET** /product-suppliers?ProductID&#x3D;{ProductID} | GET |
| [**ProductSuppliersProductidSupplieridDelete**](ReferenceBooksApi.md#productsuppliersproductidsupplieriddelete) | **DELETE** /product-suppliers?ProductID&#x3D;{ProductID}&amp;SupplierID&#x3D;{SupplierID} | DELETE |
| [**ProductSuppliersPut**](ReferenceBooksApi.md#productsuppliersput) | **PUT** /product-suppliers | PUT |
| [**ReferenceDealsIdPgLmtSrchGet**](ReferenceBooksApi.md#referencedealsidpglmtsrchget) | **GET** /reference/deals?ID&#x3D;{ID}&amp;Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Search&#x3D;{Search} | GET |
| [**ReferenceDealsPost**](ReferenceBooksApi.md#referencedealspost) | **POST** /reference/deals | POST |
| [**ReferenceDealsPut**](ReferenceBooksApi.md#referencedealsput) | **PUT** /reference/deals | PUT |
| [**ReferenceDiscountIdPgLmtSrchGet**](ReferenceBooksApi.md#referencediscountidpglmtsrchget) | **GET** /reference/discount?ID&#x3D;{ID}&amp;Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Search&#x3D;{Search} | GET |
| [**ReferenceDiscountPost**](ReferenceBooksApi.md#referencediscountpost) | **POST** /reference/discount | POST |
| [**ReferenceDiscountPut**](ReferenceBooksApi.md#referencediscountput) | **PUT** /reference/discount | PUT |
| [**ReferenceShipzonesIdPgLmtSrchGet**](ReferenceBooksApi.md#referenceshipzonesidpglmtsrchget) | **GET** /reference/shipZones?ID&#x3D;{ID}&amp;Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Search&#x3D;{Search} | GET |
| [**ReferenceShipzonesPost**](ReferenceBooksApi.md#referenceshipzonespost) | **POST** /reference/shipZones | POST |
| [**ReferenceShipzonesPut**](ReferenceBooksApi.md#referenceshipzonesput) | **PUT** /reference/shipZones | PUT |
| [**ReferenceShipzonesShipzoneidDelete**](ReferenceBooksApi.md#referenceshipzonesshipzoneiddelete) | **DELETE** /reference/shipZones?ShipZoneID &#x3D;{ShipZoneID} | Delete |
| [**Update**](ReferenceBooksApi.md#update) | **PUT** /reference/shipZonesEnabled | Update |

<a id="custompricespost"></a>
# **CustomPricesPost**
> CustomPricesPut200Response CustomPricesPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CustomPricesPutRequest? customPricesPutRequest = null)

POST

+ Method will create new Customer specific prices for specified products.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CustomPricesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var customPricesPutRequest = new CustomPricesPutRequest?(); // CustomPricesPutRequest? |  (optional) 

            try
            {
                // POST
                CustomPricesPut200Response result = apiInstance.CustomPricesPost(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.CustomPricesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomPricesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<CustomPricesPut200Response> response = apiInstance.CustomPricesPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.CustomPricesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **customPricesPutRequest** | [**CustomPricesPutRequest?**](CustomPricesPutRequest?.md) |  | [optional]  |

### Return type

[**CustomPricesPut200Response**](CustomPricesPut200Response.md)

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

<a id="custompricesproductidcustomeriddelete"></a>
# **CustomPricesProductidCustomeridDelete**
> void CustomPricesProductidCustomeridDelete (string productID, string customerID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

+ Method will delete specified Production BOM of specified product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CustomPricesProductidCustomeridDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var productID = "productID_example";  // string | Identifier of the Product whose Custom Price will be deleted
            var customerID = "customerID_example";  // string | Identifier of a Customer whose Custom Price will be deleted
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // DELETE
                apiInstance.CustomPricesProductidCustomeridDelete(productID, customerID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.CustomPricesProductidCustomeridDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomPricesProductidCustomeridDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    apiInstance.CustomPricesProductidCustomeridDeleteWithHttpInfo(productID, customerID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.CustomPricesProductidCustomeridDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productID** | **string** | Identifier of the Product whose Custom Price will be deleted |  |
| **customerID** | **string** | Identifier of a Customer whose Custom Price will be deleted |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="custompricesput"></a>
# **CustomPricesPut**
> CustomPricesPut200Response CustomPricesPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CustomPricesPutRequest? customPricesPutRequest = null)

PUT

+ Method will update Production BOM for specified product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CustomPricesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var customPricesPutRequest = new CustomPricesPutRequest?(); // CustomPricesPutRequest? |  (optional) 

            try
            {
                // PUT
                CustomPricesPut200Response result = apiInstance.CustomPricesPut(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.CustomPricesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomPricesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<CustomPricesPut200Response> response = apiInstance.CustomPricesPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.CustomPricesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **customPricesPutRequest** | [**CustomPricesPutRequest?**](CustomPricesPutRequest?.md) |  | [optional]  |

### Return type

[**CustomPricesPut200Response**](CustomPricesPut200Response.md)

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

<a id="get"></a>
# **Get**
> Get200Response Get (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Get

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // Get
                Get200Response result = apiInstance.Get(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get
    ApiResponse<Get200Response> response = apiInstance.GetWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.GetWithHttpInfo: " + e.Message);
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

[**Get200Response**](Get200Response.md)

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

<a id="productsupplierspost"></a>
# **ProductSuppliersPost**
> MeAddressesIdDelete200Response ProductSuppliersPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductSuppliersPostRequest? productSuppliersPostRequest = null)

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
    public class ProductSuppliersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var productSuppliersPostRequest = new ProductSuppliersPostRequest?(); // ProductSuppliersPostRequest? |  (optional) 

            try
            {
                // POST
                MeAddressesIdDelete200Response result = apiInstance.ProductSuppliersPost(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductSuppliersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.ProductSuppliersPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **productSuppliersPostRequest** | [**ProductSuppliersPostRequest?**](ProductSuppliersPostRequest?.md) |  | [optional]  |

### Return type

[**MeAddressesIdDelete200Response**](MeAddressesIdDelete200Response.md)

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

<a id="productsuppliersproductidget"></a>
# **ProductSuppliersProductidGet**
> ProductSuppliersProductidGet200Response ProductSuppliersProductidGet (string productID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ProductSuppliersProductidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var productID = "productID_example";  // string | Return product suppliers of a particular Product
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                ProductSuppliersProductidGet200Response result = apiInstance.ProductSuppliersProductidGet(productID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersProductidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductSuppliersProductidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ProductSuppliersProductidGet200Response> response = apiInstance.ProductSuppliersProductidGetWithHttpInfo(productID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersProductidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productID** | **string** | Return product suppliers of a particular Product |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**ProductSuppliersProductidGet200Response**](ProductSuppliersProductidGet200Response.md)

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

<a id="productsuppliersproductidsupplieriddelete"></a>
# **ProductSuppliersProductidSupplieridDelete**
> void ProductSuppliersProductidSupplieridDelete (string productID, string supplierID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

+ Method will delete specified Product Supplier settings with their Options and Intervals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductSuppliersProductidSupplieridDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var productID = "productID_example";  // string | Identifier of the Product
            var supplierID = "supplierID_example";  // string | Identifier of a Supplier
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // DELETE
                apiInstance.ProductSuppliersProductidSupplieridDelete(productID, supplierID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersProductidSupplieridDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductSuppliersProductidSupplieridDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    apiInstance.ProductSuppliersProductidSupplieridDeleteWithHttpInfo(productID, supplierID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersProductidSupplieridDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productID** | **string** | Identifier of the Product |  |
| **supplierID** | **string** | Identifier of a Supplier |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productsuppliersput"></a>
# **ProductSuppliersPut**
> MeAddressesIdDelete200Response ProductSuppliersPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductSuppliersPutRequest? productSuppliersPutRequest = null)

PUT

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProductSuppliersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var productSuppliersPutRequest = new ProductSuppliersPutRequest?(); // ProductSuppliersPutRequest? |  (optional) 

            try
            {
                // PUT
                MeAddressesIdDelete200Response result = apiInstance.ProductSuppliersPut(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductSuppliersPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.ProductSuppliersPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ProductSuppliersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **productSuppliersPutRequest** | [**ProductSuppliersPutRequest?**](ProductSuppliersPutRequest?.md) |  | [optional]  |

### Return type

[**MeAddressesIdDelete200Response**](MeAddressesIdDelete200Response.md)

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

<a id="referencedealsidpglmtsrchget"></a>
# **ReferenceDealsIdPgLmtSrchGet**
> ReferenceDealsIdPgLmtSrchGet200Response ReferenceDealsIdPgLmtSrchGet (string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ReferenceDealsIdPgLmtSrchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var ID = "ID_example";  // string | Returns detailed info of a particular Product Deal
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 25 (Default: 25)
            var search = "search_example";  // string | Only return Product Deal that have the provided text in Name (Default: not set)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                ReferenceDealsIdPgLmtSrchGet200Response result = apiInstance.ReferenceDealsIdPgLmtSrchGet(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDealsIdPgLmtSrchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceDealsIdPgLmtSrchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ReferenceDealsIdPgLmtSrchGet200Response> response = apiInstance.ReferenceDealsIdPgLmtSrchGetWithHttpInfo(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDealsIdPgLmtSrchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | Returns detailed info of a particular Product Deal |  |
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 25 (Default: 25) |  |
| **search** | **string** | Only return Product Deal that have the provided text in Name (Default: not set) |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**ReferenceDealsIdPgLmtSrchGet200Response**](ReferenceDealsIdPgLmtSrchGet200Response.md)

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

<a id="referencedealspost"></a>
# **ReferenceDealsPost**
> ReferenceDealsPost200Response ReferenceDealsPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ReferenceDealsPostRequest? referenceDealsPostRequest = null)

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
    public class ReferenceDealsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var referenceDealsPostRequest = new ReferenceDealsPostRequest?(); // ReferenceDealsPostRequest? |  (optional) 

            try
            {
                // POST
                ReferenceDealsPost200Response result = apiInstance.ReferenceDealsPost(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDealsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceDealsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ReferenceDealsPost200Response> response = apiInstance.ReferenceDealsPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDealsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **referenceDealsPostRequest** | [**ReferenceDealsPostRequest?**](ReferenceDealsPostRequest?.md) |  | [optional]  |

### Return type

[**ReferenceDealsPost200Response**](ReferenceDealsPost200Response.md)

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

<a id="referencedealsput"></a>
# **ReferenceDealsPut**
> ReferenceDealsPut200Response ReferenceDealsPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ReferenceDealsPutRequest? referenceDealsPutRequest = null)

PUT

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceDealsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var referenceDealsPutRequest = new ReferenceDealsPutRequest?(); // ReferenceDealsPutRequest? |  (optional) 

            try
            {
                // PUT
                ReferenceDealsPut200Response result = apiInstance.ReferenceDealsPut(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDealsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceDealsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ReferenceDealsPut200Response> response = apiInstance.ReferenceDealsPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDealsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **referenceDealsPutRequest** | [**ReferenceDealsPutRequest?**](ReferenceDealsPutRequest?.md) |  | [optional]  |

### Return type

[**ReferenceDealsPut200Response**](ReferenceDealsPut200Response.md)

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

<a id="referencediscountidpglmtsrchget"></a>
# **ReferenceDiscountIdPgLmtSrchGet**
> ReferenceDiscountIdPgLmtSrchGet200Response ReferenceDiscountIdPgLmtSrchGet (string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ReferenceDiscountIdPgLmtSrchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var ID = "ID_example";  // string | Returns detailed info of a particular Discount Rule
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 25 (Default: 25)
            var search = "search_example";  // string | Only return Discount Rules that have the provided text in Name (Default: not set)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                ReferenceDiscountIdPgLmtSrchGet200Response result = apiInstance.ReferenceDiscountIdPgLmtSrchGet(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDiscountIdPgLmtSrchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceDiscountIdPgLmtSrchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ReferenceDiscountIdPgLmtSrchGet200Response> response = apiInstance.ReferenceDiscountIdPgLmtSrchGetWithHttpInfo(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDiscountIdPgLmtSrchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | Returns detailed info of a particular Discount Rule |  |
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 25 (Default: 25) |  |
| **search** | **string** | Only return Discount Rules that have the provided text in Name (Default: not set) |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**ReferenceDiscountIdPgLmtSrchGet200Response**](ReferenceDiscountIdPgLmtSrchGet200Response.md)

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

<a id="referencediscountpost"></a>
# **ReferenceDiscountPost**
> ReferenceDiscountPost200Response ReferenceDiscountPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ReferenceDiscountPostRequest? referenceDiscountPostRequest = null)

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
    public class ReferenceDiscountPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var referenceDiscountPostRequest = new ReferenceDiscountPostRequest?(); // ReferenceDiscountPostRequest? |  (optional) 

            try
            {
                // POST
                ReferenceDiscountPost200Response result = apiInstance.ReferenceDiscountPost(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDiscountPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceDiscountPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ReferenceDiscountPost200Response> response = apiInstance.ReferenceDiscountPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDiscountPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **referenceDiscountPostRequest** | [**ReferenceDiscountPostRequest?**](ReferenceDiscountPostRequest?.md) |  | [optional]  |

### Return type

[**ReferenceDiscountPost200Response**](ReferenceDiscountPost200Response.md)

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

<a id="referencediscountput"></a>
# **ReferenceDiscountPut**
> ReferenceDiscountPut200Response ReferenceDiscountPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ReferenceDiscountPutRequest? referenceDiscountPutRequest = null)

PUT

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceDiscountPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var referenceDiscountPutRequest = new ReferenceDiscountPutRequest?(); // ReferenceDiscountPutRequest? |  (optional) 

            try
            {
                // PUT
                ReferenceDiscountPut200Response result = apiInstance.ReferenceDiscountPut(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDiscountPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceDiscountPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ReferenceDiscountPut200Response> response = apiInstance.ReferenceDiscountPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceDiscountPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **referenceDiscountPutRequest** | [**ReferenceDiscountPutRequest?**](ReferenceDiscountPutRequest?.md) |  | [optional]  |

### Return type

[**ReferenceDiscountPut200Response**](ReferenceDiscountPut200Response.md)

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

<a id="referenceshipzonesidpglmtsrchget"></a>
# **ReferenceShipzonesIdPgLmtSrchGet**
> ReferenceShipzonesIdPgLmtSrchGet200Response ReferenceShipzonesIdPgLmtSrchGet (string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ReferenceShipzonesIdPgLmtSrchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var ID = "ID_example";  // string | Returns detailed info of a particular Shipping zone
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 25 (Default: 25)
            var search = "search_example";  // string | Only return Shiping Zones that have the provided text in Name (Default: not set)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                ReferenceShipzonesIdPgLmtSrchGet200Response result = apiInstance.ReferenceShipzonesIdPgLmtSrchGet(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesIdPgLmtSrchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceShipzonesIdPgLmtSrchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ReferenceShipzonesIdPgLmtSrchGet200Response> response = apiInstance.ReferenceShipzonesIdPgLmtSrchGetWithHttpInfo(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesIdPgLmtSrchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | Returns detailed info of a particular Shipping zone |  |
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 25 (Default: 25) |  |
| **search** | **string** | Only return Shiping Zones that have the provided text in Name (Default: not set) |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**ReferenceShipzonesIdPgLmtSrchGet200Response**](ReferenceShipzonesIdPgLmtSrchGet200Response.md)

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

<a id="referenceshipzonespost"></a>
# **ReferenceShipzonesPost**
> ReferenceShipzonesPost200Response ReferenceShipzonesPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = null)

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
    public class ReferenceShipzonesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var referenceShipzonesPostRequest = new ReferenceShipzonesPostRequest?(); // ReferenceShipzonesPostRequest? |  (optional) 

            try
            {
                // POST
                ReferenceShipzonesPost200Response result = apiInstance.ReferenceShipzonesPost(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceShipzonesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ReferenceShipzonesPost200Response> response = apiInstance.ReferenceShipzonesPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **referenceShipzonesPostRequest** | [**ReferenceShipzonesPostRequest?**](ReferenceShipzonesPostRequest?.md) |  | [optional]  |

### Return type

[**ReferenceShipzonesPost200Response**](ReferenceShipzonesPost200Response.md)

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

<a id="referenceshipzonesput"></a>
# **ReferenceShipzonesPut**
> ReferenceShipzonesPut200Response ReferenceShipzonesPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = null)

PUT

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceShipzonesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var referenceShipzonesPutRequest = new ReferenceShipzonesPutRequest?(); // ReferenceShipzonesPutRequest? |  (optional) 

            try
            {
                // PUT
                ReferenceShipzonesPut200Response result = apiInstance.ReferenceShipzonesPut(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceShipzonesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ReferenceShipzonesPut200Response> response = apiInstance.ReferenceShipzonesPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **referenceShipzonesPutRequest** | [**ReferenceShipzonesPutRequest?**](ReferenceShipzonesPutRequest?.md) |  | [optional]  |

### Return type

[**ReferenceShipzonesPut200Response**](ReferenceShipzonesPut200Response.md)

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

<a id="referenceshipzonesshipzoneiddelete"></a>
# **ReferenceShipzonesShipzoneidDelete**
> MeAddressesIdDelete200Response ReferenceShipzonesShipzoneidDelete (string shipZoneID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Delete

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceShipzonesShipzoneidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var shipZoneID = "shipZoneID_example";  // string | ID of Ship Zone to delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // Delete
                MeAddressesIdDelete200Response result = apiInstance.ReferenceShipzonesShipzoneidDelete(shipZoneID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesShipzoneidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceShipzonesShipzoneidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.ReferenceShipzonesShipzoneidDeleteWithHttpInfo(shipZoneID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.ReferenceShipzonesShipzoneidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipZoneID** | **string** | ID of Ship Zone to delete |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**MeAddressesIdDelete200Response**](MeAddressesIdDelete200Response.md)

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

<a id="update"></a>
# **Update**
> UpdateRequest Update (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, UpdateRequest? updateRequest = null)

Update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ReferenceBooksApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var updateRequest = new UpdateRequest?(); // UpdateRequest? |  (optional) 

            try
            {
                // Update
                UpdateRequest result = apiInstance.Update(apiAuthAccountid, apiAuthApplicationkey, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceBooksApi.Update: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update
    ApiResponse<UpdateRequest> response = apiInstance.UpdateWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceBooksApi.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **updateRequest** | [**UpdateRequest?**](UpdateRequest?.md) |  | [optional]  |

### Return type

[**UpdateRequest**](UpdateRequest.md)

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

