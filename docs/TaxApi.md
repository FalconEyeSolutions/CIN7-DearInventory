# Org.OpenAPITools.Api.TaxApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RefTaxPost**](TaxApi.md#reftaxpost) | **POST** /ref/tax | POST |
| [**RefTaxPut**](TaxApi.md#reftaxput) | **PUT** /ref/tax | PUT |
| [**TaxPgLmtIdNameEtc**](TaxApi.md#taxpglmtidnameetc) | **GET** /ref/tax?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;IsActive&#x3D;{IsActive}&amp;IsTaxForSale&#x3D;{IsTaxForSale}&amp;IsTaxForPurchase&#x3D;{IsTaxForPurchase}&amp;Account&#x3D;{Account} | GET |

<a id="reftaxpost"></a>
# **RefTaxPost**
> RefTaxPost200Response RefTaxPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefTaxPostRequest? refTaxPostRequest = null)

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
    public class RefTaxPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new TaxApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var refTaxPostRequest = new RefTaxPostRequest?(); // RefTaxPostRequest? |  (optional) 

            try
            {
                // POST
                RefTaxPost200Response result = apiInstance.RefTaxPost(apiAuthAccountid, apiAuthApplicationkey, refTaxPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.RefTaxPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefTaxPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<RefTaxPost200Response> response = apiInstance.RefTaxPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refTaxPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxApi.RefTaxPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **refTaxPostRequest** | [**RefTaxPostRequest?**](RefTaxPostRequest?.md) |  | [optional]  |

### Return type

[**RefTaxPost200Response**](RefTaxPost200Response.md)

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

<a id="reftaxput"></a>
# **RefTaxPut**
> RefTaxPut200Response RefTaxPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefTaxPutRequest? refTaxPutRequest = null)

PUT

+ Updating accounts is not allowed while integration with Xero or Quickbooks enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefTaxPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new TaxApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var refTaxPutRequest = new RefTaxPutRequest?(); // RefTaxPutRequest? |  (optional) 

            try
            {
                // PUT
                RefTaxPut200Response result = apiInstance.RefTaxPut(apiAuthAccountid, apiAuthApplicationkey, refTaxPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.RefTaxPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefTaxPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<RefTaxPut200Response> response = apiInstance.RefTaxPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refTaxPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxApi.RefTaxPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **refTaxPutRequest** | [**RefTaxPutRequest?**](RefTaxPutRequest?.md) |  | [optional]  |

### Return type

[**RefTaxPut200Response**](RefTaxPut200Response.md)

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

<a id="taxpglmtidnameetc"></a>
# **TaxPgLmtIdNameEtc**
> TaxPgLmtIdNameEtc200Response TaxPgLmtIdNameEtc (decimal page, decimal limit, string ID, string name, bool isActive, bool isTaxForSale, bool isTaxForPurchase, string account, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class TaxPgLmtIdNameEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new TaxApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "ID_example";  // string | Only return Fixed Asset Type with the specific ID
            var name = "name_example";  // string | Only return accounts that start with the specific name
            var isActive = true;  // bool | Only return ACTIVE taxation rules
            var isTaxForSale = true;  // bool | Only return taxation rules which are applicable for Sales
            var isTaxForPurchase = true;  // bool | Only return taxation rules which are applicable for Purchase
            var account = "account_example";  // string | Only return taxation rules linked to specific accounte
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                TaxPgLmtIdNameEtc200Response result = apiInstance.TaxPgLmtIdNameEtc(page, limit, ID, name, isActive, isTaxForSale, isTaxForPurchase, account, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxApi.TaxPgLmtIdNameEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TaxPgLmtIdNameEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<TaxPgLmtIdNameEtc200Response> response = apiInstance.TaxPgLmtIdNameEtcWithHttpInfo(page, limit, ID, name, isActive, isTaxForSale, isTaxForPurchase, account, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxApi.TaxPgLmtIdNameEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** |  | [default to 1M] |
| **limit** | **decimal** |  | [default to 100M] |
| **ID** | **string** | Only return Fixed Asset Type with the specific ID |  |
| **name** | **string** | Only return accounts that start with the specific name |  |
| **isActive** | **bool** | Only return ACTIVE taxation rules |  |
| **isTaxForSale** | **bool** | Only return taxation rules which are applicable for Sales |  |
| **isTaxForPurchase** | **bool** | Only return taxation rules which are applicable for Purchase |  |
| **account** | **string** | Only return taxation rules linked to specific accounte |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**TaxPgLmtIdNameEtc200Response**](TaxPgLmtIdNameEtc200Response.md)

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

