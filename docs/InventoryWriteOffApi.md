# Org.OpenAPITools.Api.InventoryWriteOffApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InventorywriteoffIdVoidDelete**](InventoryWriteOffApi.md#inventorywriteoffidvoiddelete) | **DELETE** /inventoryWriteOff?ID&#x3D;{ID}&amp;Void&#x3D;{Void} | Delete |
| [**InventorywriteoffPost**](InventoryWriteOffApi.md#inventorywriteoffpost) | **POST** /inventoryWriteOff | POST |
| [**InventorywriteoffPut**](InventoryWriteOffApi.md#inventorywriteoffput) | **PUT** /inventoryWriteOff | PUT |
| [**InventorywriteoffTaskidGet**](InventoryWriteOffApi.md#inventorywriteofftaskidget) | **GET** /inventoryWriteOff?TaskID&#x3D;{TaskID} | GET |
| [**InventorywriteofflistPgLmtStsSrchGet**](InventoryWriteOffApi.md#inventorywriteofflistpglmtstssrchget) | **GET** /inventoryWriteOffList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}&amp;Search&#x3D;{Search} | GET |

<a id="inventorywriteoffidvoiddelete"></a>
# **InventorywriteoffIdVoidDelete**
> InventorywriteoffIdVoidDelete200Response InventorywriteoffIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class InventorywriteoffIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new InventoryWriteOffApi(config);
            var ID = "ID_example";  // string | ID of Inventory Write-Off to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // Delete
                InventorywriteoffIdVoidDelete200Response result = apiInstance.InventorywriteoffIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InventorywriteoffIdVoidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<InventorywriteoffIdVoidDelete200Response> response = apiInstance.InventorywriteoffIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | ID of Inventory Write-Off to Void or Undo |  |
| **varVoid** | **bool** |  | [default to false] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**InventorywriteoffIdVoidDelete200Response**](InventorywriteoffIdVoidDelete200Response.md)

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

<a id="inventorywriteoffpost"></a>
# **InventorywriteoffPost**
> InventorywriteoffPost200Response InventorywriteoffPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, InventorywriteoffPostRequest? inventorywriteoffPostRequest = null)

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
    public class InventorywriteoffPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new InventoryWriteOffApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var inventorywriteoffPostRequest = new InventorywriteoffPostRequest?(); // InventorywriteoffPostRequest? |  (optional) 

            try
            {
                // POST
                InventorywriteoffPost200Response result = apiInstance.InventorywriteoffPost(apiAuthAccountid, apiAuthApplicationkey, inventorywriteoffPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InventorywriteoffPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<InventorywriteoffPost200Response> response = apiInstance.InventorywriteoffPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, inventorywriteoffPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **inventorywriteoffPostRequest** | [**InventorywriteoffPostRequest?**](InventorywriteoffPostRequest?.md) |  | [optional]  |

### Return type

[**InventorywriteoffPost200Response**](InventorywriteoffPost200Response.md)

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

<a id="inventorywriteoffput"></a>
# **InventorywriteoffPut**
> InventorywriteoffPut200Response InventorywriteoffPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, InventorywriteoffPutRequest? inventorywriteoffPutRequest = null)

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
    public class InventorywriteoffPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new InventoryWriteOffApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var inventorywriteoffPutRequest = new InventorywriteoffPutRequest?(); // InventorywriteoffPutRequest? |  (optional) 

            try
            {
                // PUT
                InventorywriteoffPut200Response result = apiInstance.InventorywriteoffPut(apiAuthAccountid, apiAuthApplicationkey, inventorywriteoffPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InventorywriteoffPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<InventorywriteoffPut200Response> response = apiInstance.InventorywriteoffPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, inventorywriteoffPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **inventorywriteoffPutRequest** | [**InventorywriteoffPutRequest?**](InventorywriteoffPutRequest?.md) |  | [optional]  |

### Return type

[**InventorywriteoffPut200Response**](InventorywriteoffPut200Response.md)

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

<a id="inventorywriteofftaskidget"></a>
# **InventorywriteoffTaskidGet**
> InventorywriteoffPost200Response InventorywriteoffTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class InventorywriteoffTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new InventoryWriteOffApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Inventory Write-Off
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                InventorywriteoffPost200Response result = apiInstance.InventorywriteoffTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InventorywriteoffTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<InventorywriteoffPost200Response> response = apiInstance.InventorywriteoffTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteoffTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns detailed info of a particular Inventory Write-Off |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**InventorywriteoffPost200Response**](InventorywriteoffPost200Response.md)

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

<a id="inventorywriteofflistpglmtstssrchget"></a>
# **InventorywriteofflistPgLmtStsSrchGet**
> InventorywriteofflistPgLmtStsSrchGet200Response InventorywriteofflistPgLmtStsSrchGet (decimal page, decimal limit, string status, string search, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class InventorywriteofflistPgLmtStsSrchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new InventoryWriteOffApi(config);
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var status = "status_example";  // string | Only return Inventory Write-Off with specified status (Default: null)
            var search = "search_example";  // string | Only return Inventory Write-Off with search value contained in one of these fields: InventoryWriteOffNumber, Location, Status, Notes (Default: null)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                InventorywriteofflistPgLmtStsSrchGet200Response result = apiInstance.InventorywriteofflistPgLmtStsSrchGet(page, limit, status, search, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteofflistPgLmtStsSrchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InventorywriteofflistPgLmtStsSrchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<InventorywriteofflistPgLmtStsSrchGet200Response> response = apiInstance.InventorywriteofflistPgLmtStsSrchGetWithHttpInfo(page, limit, status, search, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InventoryWriteOffApi.InventorywriteofflistPgLmtStsSrchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100) |  |
| **status** | **string** | Only return Inventory Write-Off with specified status (Default: null) |  |
| **search** | **string** | Only return Inventory Write-Off with search value contained in one of these fields: InventoryWriteOffNumber, Location, Status, Notes (Default: null) |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**InventorywriteofflistPgLmtStsSrchGet200Response**](InventorywriteofflistPgLmtStsSrchGet200Response.md)

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

