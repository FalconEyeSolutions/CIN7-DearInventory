# Org.OpenAPITools.Api.LocationApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LocIdPgLmtDeprecatedEtc**](LocationApi.md#locidpglmtdeprecatedetc) | **GET** /ref/location?ID&#x3D;{ID}&amp;Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Deprecated&#x3D;{Deprecated}&amp;Name&#x3D;{Name} | GET |
| [**RefLocIdDelete**](LocationApi.md#reflociddelete) | **DELETE** /ref/location?ID&#x3D;{ID} | DELETE |
| [**RefLocPost**](LocationApi.md#reflocpost) | **POST** /ref/location | POST |
| [**RefLocPut**](LocationApi.md#reflocput) | **PUT** /ref/location | PUT |

<a id="locidpglmtdeprecatedetc"></a>
# **LocIdPgLmtDeprecatedEtc**
> LocIdPgLmtDeprecatedEtc200Response LocIdPgLmtDeprecatedEtc (decimal page, decimal limit, string ID, bool deprecated, string name, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class LocIdPgLmtDeprecatedEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new LocationApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "ID_example";  // string | Only return location that with the specific ID
            var deprecated = true;  // bool | Only return deprecated locations
            var name = "name_example";  // string | Only return locations that start with the specific name
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                LocIdPgLmtDeprecatedEtc200Response result = apiInstance.LocIdPgLmtDeprecatedEtc(page, limit, ID, deprecated, name, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationApi.LocIdPgLmtDeprecatedEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocIdPgLmtDeprecatedEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<LocIdPgLmtDeprecatedEtc200Response> response = apiInstance.LocIdPgLmtDeprecatedEtcWithHttpInfo(page, limit, ID, deprecated, name, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationApi.LocIdPgLmtDeprecatedEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** |  | [default to 1M] |
| **limit** | **decimal** |  | [default to 100M] |
| **ID** | **string** | Only return location that with the specific ID |  |
| **deprecated** | **bool** | Only return deprecated locations |  |
| **name** | **string** | Only return locations that start with the specific name |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**LocIdPgLmtDeprecatedEtc200Response**](LocIdPgLmtDeprecatedEtc200Response.md)

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

<a id="reflociddelete"></a>
# **RefLocIdDelete**
> MeAddressesIdDelete200Response RefLocIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class RefLocIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new LocationApi(config);
            var ID = "ID_example";  // string | ID of Location to Delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.RefLocIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationApi.RefLocIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefLocIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.RefLocIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationApi.RefLocIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | ID of Location to Delete |  |
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

<a id="reflocpost"></a>
# **RefLocPost**
> RefLocPost200Response RefLocPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefLocPostRequest? refLocPostRequest = null)

POST

+ Bins do not support modifying. Only creation and deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefLocPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new LocationApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var refLocPostRequest = new RefLocPostRequest?(); // RefLocPostRequest? |  (optional) 

            try
            {
                // POST
                RefLocPost200Response result = apiInstance.RefLocPost(apiAuthAccountid, apiAuthApplicationkey, refLocPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationApi.RefLocPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefLocPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<RefLocPost200Response> response = apiInstance.RefLocPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refLocPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationApi.RefLocPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **refLocPostRequest** | [**RefLocPostRequest?**](RefLocPostRequest?.md) |  | [optional]  |

### Return type

[**RefLocPost200Response**](RefLocPost200Response.md)

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

<a id="reflocput"></a>
# **RefLocPut**
> RefLocPut200Response RefLocPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefLocPutRequest? refLocPutRequest = null)

PUT

+ Bins do not support modifying. Only creation and deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefLocPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new LocationApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var refLocPutRequest = new RefLocPutRequest?(); // RefLocPutRequest? |  (optional) 

            try
            {
                // PUT
                RefLocPut200Response result = apiInstance.RefLocPut(apiAuthAccountid, apiAuthApplicationkey, refLocPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationApi.RefLocPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefLocPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<RefLocPut200Response> response = apiInstance.RefLocPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refLocPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationApi.RefLocPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **refLocPutRequest** | [**RefLocPutRequest?**](RefLocPutRequest?.md) |  | [optional]  |

### Return type

[**RefLocPut200Response**](RefLocPut200Response.md)

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

