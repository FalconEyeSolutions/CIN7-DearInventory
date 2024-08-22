# Org.OpenAPITools.Api.SupplierApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PgLmtIdNameModifiedsinceEtc1**](SupplierApi.md#pglmtidnamemodifiedsinceetc1) | **GET** /supplier?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;ModifiedSince&#x3D;{ModifiedSince}&amp;IncludeDeprecated&#x3D;{IncludeDeprecated} | GET |
| [**SupplierDepositsPgLmtSupplieridEtc**](SupplierApi.md#supplierdepositspglmtsupplieridetc) | **GET** /ref/supplier/deposits?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;SupplierID&#x3D;{SupplierID}&amp;ShowUsedDeposits&#x3D;{ShowUsedDeposits} | GET |
| [**SupplierPost**](SupplierApi.md#supplierpost) | **POST** /supplier | POST |
| [**SupplierPut**](SupplierApi.md#supplierput) | **PUT** /supplier | PUT |

<a id="pglmtidnamemodifiedsinceetc1"></a>
# **PgLmtIdNameModifiedsinceEtc1**
> PgLmtIdNameModifiedsinceEtc1200Response PgLmtIdNameModifiedsinceEtc1 (decimal page, decimal limit, string ID, string name, string modifiedSince, bool includeDeprecated, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PgLmtIdNameModifiedsinceEtc1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SupplierApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "\"null\"";  // string |  (default to "null")
            var name = "\"null\"";  // string |  (default to "null")
            var modifiedSince = "\"null\"";  // string |  (default to "null")
            var includeDeprecated = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                PgLmtIdNameModifiedsinceEtc1200Response result = apiInstance.PgLmtIdNameModifiedsinceEtc1(page, limit, ID, name, modifiedSince, includeDeprecated, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.PgLmtIdNameModifiedsinceEtc1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PgLmtIdNameModifiedsinceEtc1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PgLmtIdNameModifiedsinceEtc1200Response> response = apiInstance.PgLmtIdNameModifiedsinceEtc1WithHttpInfo(page, limit, ID, name, modifiedSince, includeDeprecated, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.PgLmtIdNameModifiedsinceEtc1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** |  | [default to 1M] |
| **limit** | **decimal** |  | [default to 100M] |
| **ID** | **string** |  | [default to &quot;null&quot;] |
| **name** | **string** |  | [default to &quot;null&quot;] |
| **modifiedSince** | **string** |  | [default to &quot;null&quot;] |
| **includeDeprecated** | **bool** |  | [default to false] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**PgLmtIdNameModifiedsinceEtc1200Response**](PgLmtIdNameModifiedsinceEtc1200Response.md)

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

<a id="supplierdepositspglmtsupplieridetc"></a>
# **SupplierDepositsPgLmtSupplieridEtc**
> SupplierDepositsPgLmtSupplieridEtc200Response SupplierDepositsPgLmtSupplieridEtc (decimal page, decimal limit, string supplierID, string showUsedDeposits, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SupplierDepositsPgLmtSupplieridEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SupplierApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var supplierID = "\"null\"";  // string |  (default to "null")
            var showUsedDeposits = "\"false\"";  // string |  (default to "false")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                SupplierDepositsPgLmtSupplieridEtc200Response result = apiInstance.SupplierDepositsPgLmtSupplieridEtc(page, limit, supplierID, showUsedDeposits, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierDepositsPgLmtSupplieridEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SupplierDepositsPgLmtSupplieridEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SupplierDepositsPgLmtSupplieridEtc200Response> response = apiInstance.SupplierDepositsPgLmtSupplieridEtcWithHttpInfo(page, limit, supplierID, showUsedDeposits, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.SupplierDepositsPgLmtSupplieridEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** |  | [default to 1M] |
| **limit** | **decimal** |  | [default to 100M] |
| **supplierID** | **string** |  | [default to &quot;null&quot;] |
| **showUsedDeposits** | **string** |  | [default to &quot;false&quot;] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**SupplierDepositsPgLmtSupplieridEtc200Response**](SupplierDepositsPgLmtSupplieridEtc200Response.md)

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

<a id="supplierpost"></a>
# **SupplierPost**
> SupplierPost200Response SupplierPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SupplierPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SupplierApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // POST
                SupplierPost200Response result = apiInstance.SupplierPost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SupplierPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SupplierPost200Response> response = apiInstance.SupplierPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.SupplierPostWithHttpInfo: " + e.Message);
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

[**SupplierPost200Response**](SupplierPost200Response.md)

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

<a id="supplierput"></a>
# **SupplierPut**
> SupplierPut200Response SupplierPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SupplierPutRequest? supplierPutRequest = null)

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
    public class SupplierPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SupplierApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var supplierPutRequest = new SupplierPutRequest?(); // SupplierPutRequest? |  (optional) 

            try
            {
                // PUT
                SupplierPut200Response result = apiInstance.SupplierPut(apiAuthAccountid, apiAuthApplicationkey, supplierPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierApi.SupplierPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SupplierPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<SupplierPut200Response> response = apiInstance.SupplierPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, supplierPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierApi.SupplierPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **supplierPutRequest** | [**SupplierPutRequest?**](SupplierPutRequest?.md) |  | [optional]  |

### Return type

[**SupplierPut200Response**](SupplierPut200Response.md)

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

