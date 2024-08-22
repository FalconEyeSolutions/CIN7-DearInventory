# Org.OpenAPITools.Api.FinishedGoodsApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FinishedgoodsIdVoidDelete**](FinishedGoodsApi.md#finishedgoodsidvoiddelete) | **DELETE** /finishedGoods?ID&#x3D;{ID}&amp;Void&#x3D;{Void} | Delete |
| [**FinishedgoodsOrderPost**](FinishedGoodsApi.md#finishedgoodsorderpost) | **POST** /finishedGoods/order | POST |
| [**FinishedgoodsOrderTaskidGet**](FinishedGoodsApi.md#finishedgoodsordertaskidget) | **GET** /finishedGoods/order?TaskID&#x3D;{TaskID} | GET |
| [**FinishedgoodsPickPost**](FinishedGoodsApi.md#finishedgoodspickpost) | **POST** /finishedGoods/pick | POST |
| [**FinishedgoodsPickTaskidGet**](FinishedGoodsApi.md#finishedgoodspicktaskidget) | **GET** /finishedGoods/pick?TaskID&#x3D;{TaskID} | GET |
| [**FinishedgoodsPost**](FinishedGoodsApi.md#finishedgoodspost) | **POST** /finishedGoods | POST |
| [**FinishedgoodsPut**](FinishedGoodsApi.md#finishedgoodsput) | **PUT** /finishedGoods | PUT |
| [**FinishedgoodsTaskidGet**](FinishedGoodsApi.md#finishedgoodstaskidget) | **GET** /finishedGoods?TaskID&#x3D;{TaskID} | GET |
| [**FinishedgoodslistPgLmtStsSrchSaleidGet**](FinishedGoodsApi.md#finishedgoodslistpglmtstssrchsaleidget) | **GET** /finishedGoodsList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}&amp;Search&#x3D;{Search}&amp;SaleID&#x3D;{SaleID} | GET |

<a id="finishedgoodsidvoiddelete"></a>
# **FinishedgoodsIdVoidDelete**
> FinishedgoodsIdVoidDelete200Response FinishedgoodsIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class FinishedgoodsIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var ID = "ID_example";  // string | ID of Finished Goods to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // Delete
                FinishedgoodsIdVoidDelete200Response result = apiInstance.FinishedgoodsIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsIdVoidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<FinishedgoodsIdVoidDelete200Response> response = apiInstance.FinishedgoodsIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** | ID of Finished Goods to Void or Undo |  |
| **varVoid** | **bool** |  | [default to false] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**FinishedgoodsIdVoidDelete200Response**](FinishedgoodsIdVoidDelete200Response.md)

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

<a id="finishedgoodsorderpost"></a>
# **FinishedgoodsOrderPost**
> FinishedgoodsOrderPostRequest FinishedgoodsOrderPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, FinishedgoodsOrderPostRequest? finishedgoodsOrderPostRequest = null)

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
    public class FinishedgoodsOrderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var finishedgoodsOrderPostRequest = new FinishedgoodsOrderPostRequest?(); // FinishedgoodsOrderPostRequest? |  (optional) 

            try
            {
                // POST
                FinishedgoodsOrderPostRequest result = apiInstance.FinishedgoodsOrderPost(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsOrderPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsOrderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsOrderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<FinishedgoodsOrderPostRequest> response = apiInstance.FinishedgoodsOrderPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsOrderPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsOrderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **finishedgoodsOrderPostRequest** | [**FinishedgoodsOrderPostRequest?**](FinishedgoodsOrderPostRequest?.md) |  | [optional]  |

### Return type

[**FinishedgoodsOrderPostRequest**](FinishedgoodsOrderPostRequest.md)

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

<a id="finishedgoodsordertaskidget"></a>
# **FinishedgoodsOrderTaskidGet**
> FinishedgoodsOrderTaskidGet200Response FinishedgoodsOrderTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class FinishedgoodsOrderTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var taskID = "taskID_example";  // string | Returns Order info of a particular Finished Goods
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                FinishedgoodsOrderTaskidGet200Response result = apiInstance.FinishedgoodsOrderTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsOrderTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsOrderTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<FinishedgoodsOrderTaskidGet200Response> response = apiInstance.FinishedgoodsOrderTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsOrderTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns Order info of a particular Finished Goods |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**FinishedgoodsOrderTaskidGet200Response**](FinishedgoodsOrderTaskidGet200Response.md)

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

<a id="finishedgoodspickpost"></a>
# **FinishedgoodsPickPost**
> FinishedgoodsPickPost200Response FinishedgoodsPickPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, FinishedgoodsPickPostRequest? finishedgoodsPickPostRequest = null)

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
    public class FinishedgoodsPickPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var finishedgoodsPickPostRequest = new FinishedgoodsPickPostRequest?(); // FinishedgoodsPickPostRequest? |  (optional) 

            try
            {
                // POST
                FinishedgoodsPickPost200Response result = apiInstance.FinishedgoodsPickPost(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsPickPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPickPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsPickPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<FinishedgoodsPickPost200Response> response = apiInstance.FinishedgoodsPickPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsPickPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPickPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **finishedgoodsPickPostRequest** | [**FinishedgoodsPickPostRequest?**](FinishedgoodsPickPostRequest?.md) |  | [optional]  |

### Return type

[**FinishedgoodsPickPost200Response**](FinishedgoodsPickPost200Response.md)

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

<a id="finishedgoodspicktaskidget"></a>
# **FinishedgoodsPickTaskidGet**
> FinishedgoodsPickTaskidGet200Response FinishedgoodsPickTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class FinishedgoodsPickTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var taskID = "taskID_example";  // string | Returns Pick info of a particular Finished Goods
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                FinishedgoodsPickTaskidGet200Response result = apiInstance.FinishedgoodsPickTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPickTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsPickTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<FinishedgoodsPickTaskidGet200Response> response = apiInstance.FinishedgoodsPickTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPickTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns Pick info of a particular Finished Goods |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**FinishedgoodsPickTaskidGet200Response**](FinishedgoodsPickTaskidGet200Response.md)

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

<a id="finishedgoodspost"></a>
# **FinishedgoodsPost**
> FinishedgoodsPost200Response FinishedgoodsPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, FinishedgoodsPostRequest? finishedgoodsPostRequest = null)

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
    public class FinishedgoodsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var finishedgoodsPostRequest = new FinishedgoodsPostRequest?(); // FinishedgoodsPostRequest? |  (optional) 

            try
            {
                // POST
                FinishedgoodsPost200Response result = apiInstance.FinishedgoodsPost(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<FinishedgoodsPost200Response> response = apiInstance.FinishedgoodsPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **finishedgoodsPostRequest** | [**FinishedgoodsPostRequest?**](FinishedgoodsPostRequest?.md) |  | [optional]  |

### Return type

[**FinishedgoodsPost200Response**](FinishedgoodsPost200Response.md)

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

<a id="finishedgoodsput"></a>
# **FinishedgoodsPut**
> FinishedgoodsPut200Response FinishedgoodsPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, FinishedgoodsPutRequest? finishedgoodsPutRequest = null)

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
    public class FinishedgoodsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var finishedgoodsPutRequest = new FinishedgoodsPutRequest?(); // FinishedgoodsPutRequest? |  (optional) 

            try
            {
                // PUT
                FinishedgoodsPut200Response result = apiInstance.FinishedgoodsPut(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<FinishedgoodsPut200Response> response = apiInstance.FinishedgoodsPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, finishedgoodsPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **finishedgoodsPutRequest** | [**FinishedgoodsPutRequest?**](FinishedgoodsPutRequest?.md) |  | [optional]  |

### Return type

[**FinishedgoodsPut200Response**](FinishedgoodsPut200Response.md)

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

<a id="finishedgoodstaskidget"></a>
# **FinishedgoodsTaskidGet**
> FinishedgoodsTaskidGet200Response FinishedgoodsTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class FinishedgoodsTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Finished Goods
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                FinishedgoodsTaskidGet200Response result = apiInstance.FinishedgoodsTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodsTaskidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<FinishedgoodsTaskidGet200Response> response = apiInstance.FinishedgoodsTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodsTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskID** | **string** | Returns detailed info of a particular Finished Goods |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**FinishedgoodsTaskidGet200Response**](FinishedgoodsTaskidGet200Response.md)

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

<a id="finishedgoodslistpglmtstssrchsaleidget"></a>
# **FinishedgoodslistPgLmtStsSrchSaleidGet**
> FinishedgoodslistPgLmtStsSrchSaleidGet200Response FinishedgoodslistPgLmtStsSrchSaleidGet (decimal page, decimal limit, string status, string search, string saleID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class FinishedgoodslistPgLmtStsSrchSaleidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FinishedGoodsApi(config);
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var status = "status_example";  // string | Only return Finished Goods with specified status (Default: null)
            var search = "search_example";  // string | Only return Finished Goods with search value contained in one of these fields: AssemblyNumber, Location, Status, Name, ProductCode, BatchSN, Notes (Default: null)
            var saleID = "saleID_example";  // string | Only return Finished Goods related to particular Sale
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                FinishedgoodslistPgLmtStsSrchSaleidGet200Response result = apiInstance.FinishedgoodslistPgLmtStsSrchSaleidGet(page, limit, status, search, saleID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodslistPgLmtStsSrchSaleidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinishedgoodslistPgLmtStsSrchSaleidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<FinishedgoodslistPgLmtStsSrchSaleidGet200Response> response = apiInstance.FinishedgoodslistPgLmtStsSrchSaleidGetWithHttpInfo(page, limit, status, search, saleID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinishedGoodsApi.FinishedgoodslistPgLmtStsSrchSaleidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** | Page (Default: 1) |  |
| **limit** | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100) |  |
| **status** | **string** | Only return Finished Goods with specified status (Default: null) |  |
| **search** | **string** | Only return Finished Goods with search value contained in one of these fields: AssemblyNumber, Location, Status, Name, ProductCode, BatchSN, Notes (Default: null) |  |
| **saleID** | **string** | Only return Finished Goods related to particular Sale |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**FinishedgoodslistPgLmtStsSrchSaleidGet200Response**](FinishedgoodslistPgLmtStsSrchSaleidGet200Response.md)

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

