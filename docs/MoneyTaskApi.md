# Org.OpenAPITools.Api.MoneyTaskApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BanktransferIdVoidDelete**](MoneyTaskApi.md#banktransferidvoiddelete) | **DELETE** /bankTransfer?ID&#x3D;{ID}&amp;Void&#x3D;{Void} | Delete |
| [**BanktransferPost**](MoneyTaskApi.md#banktransferpost) | **POST** /bankTransfer | POST |
| [**BanktransferPut**](MoneyTaskApi.md#banktransferput) | **PUT** /bankTransfer | PUT |
| [**BanktransferTaskidGet**](MoneyTaskApi.md#banktransfertaskidget) | **GET** /bankTransfer?TaskID&#x3D;{TaskID} | GET |
| [**MoneyoperationIdVoidDelete**](MoneyTaskApi.md#moneyoperationidvoiddelete) | **DELETE** /moneyOperation?ID&#x3D;{ID}&amp;Void&#x3D;{Void} | Delete |
| [**MoneyoperationPost**](MoneyTaskApi.md#moneyoperationpost) | **POST** /moneyOperation | POST |
| [**MoneyoperationPut**](MoneyTaskApi.md#moneyoperationput) | **PUT** /moneyOperation | PUT |
| [**MoneyoperationTaskidGet**](MoneyTaskApi.md#moneyoperationtaskidget) | **GET** /moneyOperation?TaskID&#x3D;{TaskID} | GET |
| [**MoneytasklistPgLmtStsSrchTasktypeGet**](MoneyTaskApi.md#moneytasklistpglmtstssrchtasktypeget) | **GET** /moneyTaskList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}&amp;Search&#x3D;{Search}&amp;TaskType&#x3D;{TaskType} | GET |

<a id="banktransferidvoiddelete"></a>
# **BanktransferIdVoidDelete**
> BanktransferIdVoidDelete200Response BanktransferIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class BanktransferIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var ID = "ID_example";  // string | ID of Money Task to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // Delete
                BanktransferIdVoidDelete200Response result = apiInstance.BanktransferIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.BanktransferIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BanktransferIdVoidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<BanktransferIdVoidDelete200Response> response = apiInstance.BanktransferIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.BanktransferIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | ID of Money Task to Void or Undo |  |
| **varVoid** | **bool** |  | [default to false] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**BanktransferIdVoidDelete200Response**](BanktransferIdVoidDelete200Response.md)

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

<a id="banktransferpost"></a>
# **BanktransferPost**
> BanktransferPost200Response BanktransferPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, BanktransferPostRequest? banktransferPostRequest = null)

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
    public class BanktransferPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var banktransferPostRequest = new BanktransferPostRequest?(); // BanktransferPostRequest? |  (optional) 

            try
            {
                // POST
                BanktransferPost200Response result = apiInstance.BanktransferPost(apiAuthAccountid, apiAuthApplicationkey, banktransferPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.BanktransferPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BanktransferPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<BanktransferPost200Response> response = apiInstance.BanktransferPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, banktransferPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.BanktransferPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **banktransferPostRequest** | [**BanktransferPostRequest?**](BanktransferPostRequest?.md) |  | [optional]  |

### Return type

[**BanktransferPost200Response**](BanktransferPost200Response.md)

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

<a id="banktransferput"></a>
# **BanktransferPut**
> BanktransferPut200Response BanktransferPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, BanktransferPutRequest? banktransferPutRequest = null)

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
    public class BanktransferPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var banktransferPutRequest = new BanktransferPutRequest?(); // BanktransferPutRequest? |  (optional) 

            try
            {
                // PUT
                BanktransferPut200Response result = apiInstance.BanktransferPut(apiAuthAccountid, apiAuthApplicationkey, banktransferPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.BanktransferPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BanktransferPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<BanktransferPut200Response> response = apiInstance.BanktransferPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, banktransferPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.BanktransferPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **banktransferPutRequest** | [**BanktransferPutRequest?**](BanktransferPutRequest?.md) |  | [optional]  |

### Return type

[**BanktransferPut200Response**](BanktransferPut200Response.md)

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

<a id="banktransfertaskidget"></a>
# **BanktransferTaskidGet**
> BanktransferTaskidGet200Response BanktransferTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class BanktransferTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Bank Transfer
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                BanktransferTaskidGet200Response result = apiInstance.BanktransferTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.BanktransferTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BanktransferTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<BanktransferTaskidGet200Response> response = apiInstance.BanktransferTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.BanktransferTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns detailed info of a particular Bank Transfer |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**BanktransferTaskidGet200Response**](BanktransferTaskidGet200Response.md)

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

<a id="moneyoperationidvoiddelete"></a>
# **MoneyoperationIdVoidDelete**
> MoneyoperationIdVoidDelete200Response MoneyoperationIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class MoneyoperationIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var ID = "ID_example";  // string | ID of Money Task to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // Delete
                MoneyoperationIdVoidDelete200Response result = apiInstance.MoneyoperationIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoneyoperationIdVoidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<MoneyoperationIdVoidDelete200Response> response = apiInstance.MoneyoperationIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | ID of Money Task to Void or Undo |  |
| **varVoid** | **bool** |  | [default to false] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**MoneyoperationIdVoidDelete200Response**](MoneyoperationIdVoidDelete200Response.md)

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

<a id="moneyoperationpost"></a>
# **MoneyoperationPost**
> MoneyoperationPost200Response MoneyoperationPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, MoneyoperationPostRequest? moneyoperationPostRequest = null)

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
    public class MoneyoperationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var moneyoperationPostRequest = new MoneyoperationPostRequest?(); // MoneyoperationPostRequest? |  (optional) 

            try
            {
                // POST
                MoneyoperationPost200Response result = apiInstance.MoneyoperationPost(apiAuthAccountid, apiAuthApplicationkey, moneyoperationPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoneyoperationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<MoneyoperationPost200Response> response = apiInstance.MoneyoperationPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, moneyoperationPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **moneyoperationPostRequest** | [**MoneyoperationPostRequest?**](MoneyoperationPostRequest?.md) |  | [optional]  |

### Return type

[**MoneyoperationPost200Response**](MoneyoperationPost200Response.md)

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

<a id="moneyoperationput"></a>
# **MoneyoperationPut**
> MoneyoperationPut200Response MoneyoperationPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, MoneyoperationPutRequest? moneyoperationPutRequest = null)

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
    public class MoneyoperationPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var moneyoperationPutRequest = new MoneyoperationPutRequest?(); // MoneyoperationPutRequest? |  (optional) 

            try
            {
                // PUT
                MoneyoperationPut200Response result = apiInstance.MoneyoperationPut(apiAuthAccountid, apiAuthApplicationkey, moneyoperationPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoneyoperationPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<MoneyoperationPut200Response> response = apiInstance.MoneyoperationPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, moneyoperationPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **moneyoperationPutRequest** | [**MoneyoperationPutRequest?**](MoneyoperationPutRequest?.md) |  | [optional]  |

### Return type

[**MoneyoperationPut200Response**](MoneyoperationPut200Response.md)

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

<a id="moneyoperationtaskidget"></a>
# **MoneyoperationTaskidGet**
> MoneyoperationTaskidGet200Response MoneyoperationTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class MoneyoperationTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Money Task
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                MoneyoperationTaskidGet200Response result = apiInstance.MoneyoperationTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoneyoperationTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<MoneyoperationTaskidGet200Response> response = apiInstance.MoneyoperationTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.MoneyoperationTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns detailed info of a particular Money Task |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**MoneyoperationTaskidGet200Response**](MoneyoperationTaskidGet200Response.md)

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

<a id="moneytasklistpglmtstssrchtasktypeget"></a>
# **MoneytasklistPgLmtStsSrchTasktypeGet**
> MoneytasklistPgLmtStsSrchTasktypeGet200Response MoneytasklistPgLmtStsSrchTasktypeGet (decimal page, decimal limit, string status, string search, string taskType, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class MoneytasklistPgLmtStsSrchTasktypeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MoneyTaskApi(config);
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var status = "status_example";  // string | \"Only return Money Task with specified status (Default: null)
            var search = "search_example";  // string | Only return Money Task with search value contained in one of these fields: SupplierCustomerName, Reference, BankAccountCode, Memo, TotalAmount, CustomField(1-10) (Default: null)
            var taskType = "taskType_example";  // string | \"Only return Money Task with specified TaskType (Default: null)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                MoneytasklistPgLmtStsSrchTasktypeGet200Response result = apiInstance.MoneytasklistPgLmtStsSrchTasktypeGet(page, limit, status, search, taskType, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MoneyTaskApi.MoneytasklistPgLmtStsSrchTasktypeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoneytasklistPgLmtStsSrchTasktypeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<MoneytasklistPgLmtStsSrchTasktypeGet200Response> response = apiInstance.MoneytasklistPgLmtStsSrchTasktypeGetWithHttpInfo(page, limit, status, search, taskType, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MoneyTaskApi.MoneytasklistPgLmtStsSrchTasktypeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100) |  |
| **status** | **string** | \&quot;Only return Money Task with specified status (Default: null) |  |
| **search** | **string** | Only return Money Task with search value contained in one of these fields: SupplierCustomerName, Reference, BankAccountCode, Memo, TotalAmount, CustomField(1-10) (Default: null) |  |
| **taskType** | **string** | \&quot;Only return Money Task with specified TaskType (Default: null) |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**MoneytasklistPgLmtStsSrchTasktypeGet200Response**](MoneytasklistPgLmtStsSrchTasktypeGet200Response.md)

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

