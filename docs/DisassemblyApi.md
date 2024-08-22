# Org.OpenAPITools.Api.DisassemblyApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DisassemblyIdVoidDelete**](DisassemblyApi.md#disassemblyidvoiddelete) | **DELETE** /disassembly?ID&#x3D;{ID}&amp;Void&#x3D;{Void} | Delete |
| [**DisassemblyOrderPost**](DisassemblyApi.md#disassemblyorderpost) | **POST** /disassembly/order | POST |
| [**DisassemblyOrderTaskidGet**](DisassemblyApi.md#disassemblyordertaskidget) | **GET** /disassembly/order?TaskID&#x3D;{TaskID} | GET |
| [**DisassemblyPost**](DisassemblyApi.md#disassemblypost) | **POST** /disassembly | POST |
| [**DisassemblyTaskidGet**](DisassemblyApi.md#disassemblytaskidget) | **GET** /disassembly?TaskID&#x3D;{TaskID} | GET |
| [**DisassemblylistPgLmtStsSrchGet**](DisassemblyApi.md#disassemblylistpglmtstssrchget) | **GET** /disassemblyList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}&amp;Search&#x3D;{Search} | GET |

<a id="disassemblyidvoiddelete"></a>
# **DisassemblyIdVoidDelete**
> DisassemblyIdVoidDelete200Response DisassemblyIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class DisassemblyIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new DisassemblyApi(config);
            var ID = "ID_example";  // string | ID of Disassembly to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // Delete
                DisassemblyIdVoidDelete200Response result = apiInstance.DisassemblyIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisassemblyApi.DisassemblyIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisassemblyIdVoidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<DisassemblyIdVoidDelete200Response> response = apiInstance.DisassemblyIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisassemblyApi.DisassemblyIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | ID of Disassembly to Void or Undo |  |
| **varVoid** | **bool** |  | [default to false] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**DisassemblyIdVoidDelete200Response**](DisassemblyIdVoidDelete200Response.md)

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

<a id="disassemblyorderpost"></a>
# **DisassemblyOrderPost**
> DisassemblyOrderPostRequest DisassemblyOrderPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, DisassemblyOrderPostRequest? disassemblyOrderPostRequest = null)

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
    public class DisassemblyOrderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new DisassemblyApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var disassemblyOrderPostRequest = new DisassemblyOrderPostRequest?(); // DisassemblyOrderPostRequest? |  (optional) 

            try
            {
                // POST
                DisassemblyOrderPostRequest result = apiInstance.DisassemblyOrderPost(apiAuthAccountid, apiAuthApplicationkey, disassemblyOrderPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisassemblyApi.DisassemblyOrderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisassemblyOrderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<DisassemblyOrderPostRequest> response = apiInstance.DisassemblyOrderPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, disassemblyOrderPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisassemblyApi.DisassemblyOrderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **disassemblyOrderPostRequest** | [**DisassemblyOrderPostRequest?**](DisassemblyOrderPostRequest?.md) |  | [optional]  |

### Return type

[**DisassemblyOrderPostRequest**](DisassemblyOrderPostRequest.md)

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

<a id="disassemblyordertaskidget"></a>
# **DisassemblyOrderTaskidGet**
> DisassemblyOrderTaskidGet200Response DisassemblyOrderTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class DisassemblyOrderTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new DisassemblyApi(config);
            var taskID = "taskID_example";  // string | Returns Order info of a particular Disassembly
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                DisassemblyOrderTaskidGet200Response result = apiInstance.DisassemblyOrderTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisassemblyApi.DisassemblyOrderTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisassemblyOrderTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<DisassemblyOrderTaskidGet200Response> response = apiInstance.DisassemblyOrderTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisassemblyApi.DisassemblyOrderTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns Order info of a particular Disassembly |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**DisassemblyOrderTaskidGet200Response**](DisassemblyOrderTaskidGet200Response.md)

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

<a id="disassemblypost"></a>
# **DisassemblyPost**
> DisassemblyPost200Response DisassemblyPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, DisassemblyPostRequest? disassemblyPostRequest = null)

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
    public class DisassemblyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new DisassemblyApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var disassemblyPostRequest = new DisassemblyPostRequest?(); // DisassemblyPostRequest? |  (optional) 

            try
            {
                // POST
                DisassemblyPost200Response result = apiInstance.DisassemblyPost(apiAuthAccountid, apiAuthApplicationkey, disassemblyPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisassemblyApi.DisassemblyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisassemblyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<DisassemblyPost200Response> response = apiInstance.DisassemblyPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, disassemblyPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisassemblyApi.DisassemblyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **disassemblyPostRequest** | [**DisassemblyPostRequest?**](DisassemblyPostRequest?.md) |  | [optional]  |

### Return type

[**DisassemblyPost200Response**](DisassemblyPost200Response.md)

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

<a id="disassemblytaskidget"></a>
# **DisassemblyTaskidGet**
> DisassemblyTaskidGet200Response DisassemblyTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class DisassemblyTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new DisassemblyApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Disassembly
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                DisassemblyTaskidGet200Response result = apiInstance.DisassemblyTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisassemblyApi.DisassemblyTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisassemblyTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<DisassemblyTaskidGet200Response> response = apiInstance.DisassemblyTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisassemblyApi.DisassemblyTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns detailed info of a particular Disassembly |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**DisassemblyTaskidGet200Response**](DisassemblyTaskidGet200Response.md)

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

<a id="disassemblylistpglmtstssrchget"></a>
# **DisassemblylistPgLmtStsSrchGet**
> DisassemblylistPgLmtStsSrchGet200Response DisassemblylistPgLmtStsSrchGet (decimal page, decimal limit, string status, string search, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class DisassemblylistPgLmtStsSrchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new DisassemblyApi(config);
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var status = "status_example";  // string | Only return Disassembly with specified status (Default: null)
            var search = "search_example";  // string | Only return Disassembly with search value contained in one of these fields: DisassemblyNumber, Location, Status, Name, ProductCode (Default: null)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                DisassemblylistPgLmtStsSrchGet200Response result = apiInstance.DisassemblylistPgLmtStsSrchGet(page, limit, status, search, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisassemblyApi.DisassemblylistPgLmtStsSrchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisassemblylistPgLmtStsSrchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<DisassemblylistPgLmtStsSrchGet200Response> response = apiInstance.DisassemblylistPgLmtStsSrchGetWithHttpInfo(page, limit, status, search, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisassemblyApi.DisassemblylistPgLmtStsSrchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100) |  |
| **status** | **string** | Only return Disassembly with specified status (Default: null) |  |
| **search** | **string** | Only return Disassembly with search value contained in one of these fields: DisassemblyNumber, Location, Status, Name, ProductCode (Default: null) |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**DisassemblylistPgLmtStsSrchGet200Response**](DisassemblylistPgLmtStsSrchGet200Response.md)

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

