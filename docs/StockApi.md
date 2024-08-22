# CIN7.DearInventory.Api.StockApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                               | HTTP request                                                                                                         | Description |
| ------------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**StockadjustmentIdVoidDelete**](StockApi.md#stockadjustmentidvoiddelete)           | **DELETE** /stockadjustment?ID&#x3D;{ID}&amp;Void&#x3D;{Void}                                                        | DELETE      |
| [**StockadjustmentPost**](StockApi.md#stockadjustmentpost)                           | **POST** /stockadjustment                                                                                            | POST        |
| [**StockadjustmentPut**](StockApi.md#stockadjustmentput)                             | **PUT** /stockadjustment                                                                                             | PUT         |
| [**StockadjustmentTaskidGet**](StockApi.md#stockadjustmenttaskidget)                 | **GET** /stockadjustment?TaskID&#x3D;{TaskID}                                                                        | GET         |
| [**StockadjustmentlistPgLmtStsGet**](StockApi.md#stockadjustmentlistpglmtstsget)     | **GET** /stockadjustmentList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}                        | GET         |
| [**StocktakeIdVoidDelete**](StockApi.md#stocktakeidvoiddelete)                       | **DELETE** /stocktake?ID&#x3D;{ID}&amp;Void&#x3D;{Void}                                                              | DELETE      |
| [**StocktakePost**](StockApi.md#stocktakepost)                                       | **POST** /stocktake                                                                                                  | POST        |
| [**StocktakePut**](StockApi.md#stocktakeput)                                         | **PUT** /stocktake                                                                                                   | PUT         |
| [**StocktakeTaskidGet**](StockApi.md#stocktaketaskidget)                             | **GET** /stocktake?TaskID&#x3D;{TaskID}                                                                              | GET         |
| [**StocktakelistPgLmtStsGet**](StockApi.md#stocktakelistpglmtstsget)                 | **GET** /stockTakeList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}                              | GET         |
| [**StocktransferIdVoidDelete**](StockApi.md#stocktransferidvoiddelete)               | **DELETE** /stockTransfer?ID&#x3D;{ID}&amp;Void&#x3D;{Void}                                                          | DELETE      |
| [**StocktransferOrderPost**](StockApi.md#stocktransferorderpost)                     | **POST** /stockTransfer/order                                                                                        | POST        |
| [**StocktransferOrderTaskidGet**](StockApi.md#stocktransferordertaskidget)           | **GET** /stockTransfer/order?TaskID&#x3D;{TaskID}                                                                    | GET         |
| [**StocktransferPost**](StockApi.md#stocktransferpost)                               | **POST** /stockTransfer                                                                                              | POST        |
| [**StocktransferPut**](StockApi.md#stocktransferput)                                 | **PUT** /stockTransfer                                                                                               | PUT         |
| [**StocktransferTaskidGet**](StockApi.md#stocktransfertaskidget)                     | **GET** /stockTransfer?TaskID&#x3D;{TaskID}                                                                          | GET         |
| [**StocktransferlistPgLmtStsSrchGet**](StockApi.md#stocktransferlistpglmtstssrchget) | **GET** /stockTransferList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}&amp;Search&#x3D;{Search} | GET         |

<a id="stockadjustmentidvoiddelete"></a>

# **StockadjustmentIdVoidDelete**

> StockadjustmentIdVoidDelete200Response StockadjustmentIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StockadjustmentIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var ID = "ID_example";  // string | ID of Stock Adjustment to Void
            var varVoid = true;  // bool | Void or Undo Stock Adjustment
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                StockadjustmentIdVoidDelete200Response result = apiInstance.StockadjustmentIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StockadjustmentIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StockadjustmentIdVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<StockadjustmentIdVoidDelete200Response> response = apiInstance.StockadjustmentIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StockadjustmentIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Stock Adjustment to Void            |            |
| **varVoid**               | **bool**    | Void or Undo Stock Adjustment             |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**StockadjustmentIdVoidDelete200Response**](StockadjustmentIdVoidDelete200Response.md)

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

<a id="stockadjustmentpost"></a>

# **StockadjustmentPost**

> StockadjustmentPost200Response StockadjustmentPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StockadjustmentPostRequest? stockadjustmentPostRequest = null)

POST

-   POST method will create new stock adjustment. + To modify existing stock adjustment use PUT.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class StockadjustmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var stockadjustmentPostRequest = new StockadjustmentPostRequest?(); // StockadjustmentPostRequest? |  (optional)

            try
            {
                // POST
                StockadjustmentPost200Response result = apiInstance.StockadjustmentPost(apiAuthAccountid, apiAuthApplicationkey, stockadjustmentPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StockadjustmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StockadjustmentPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<StockadjustmentPost200Response> response = apiInstance.StockadjustmentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, stockadjustmentPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StockadjustmentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                           | Type                                                              | Description                               | Notes      |
| ------------------------------ | ----------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**           | **string?**                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**      | **string?**                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **stockadjustmentPostRequest** | [**StockadjustmentPostRequest?**](StockadjustmentPostRequest?.md) |                                           | [optional] |

### Return type

[**StockadjustmentPost200Response**](StockadjustmentPost200Response.md)

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

<a id="stockadjustmentput"></a>

# **StockadjustmentPut**

> StockadjustmentPut200Response StockadjustmentPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StockadjustmentPutRequest? stockadjustmentPutRequest = null)

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
    public class StockadjustmentPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var stockadjustmentPutRequest = new StockadjustmentPutRequest?(); // StockadjustmentPutRequest? |  (optional)

            try
            {
                // PUT
                StockadjustmentPut200Response result = apiInstance.StockadjustmentPut(apiAuthAccountid, apiAuthApplicationkey, stockadjustmentPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StockadjustmentPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StockadjustmentPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<StockadjustmentPut200Response> response = apiInstance.StockadjustmentPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, stockadjustmentPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StockadjustmentPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                          | Type                                                            | Description                               | Notes      |
| ----------------------------- | --------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**          | **string?**                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**     | **string?**                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **stockadjustmentPutRequest** | [**StockadjustmentPutRequest?**](StockadjustmentPutRequest?.md) |                                           | [optional] |

### Return type

[**StockadjustmentPut200Response**](StockadjustmentPut200Response.md)

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

<a id="stockadjustmenttaskidget"></a>

# **StockadjustmentTaskidGet**

> StockadjustmentTaskidGet200Response StockadjustmentTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StockadjustmentTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Stock Adjustment
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                StockadjustmentTaskidGet200Response result = apiInstance.StockadjustmentTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StockadjustmentTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StockadjustmentTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<StockadjustmentTaskidGet200Response> response = apiInstance.StockadjustmentTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StockadjustmentTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                            | Notes      |
| ------------------------- | ----------- | ------------------------------------------------------ | ---------- |
| **taskID**                | **string**  | Returns detailed info of a particular Stock Adjustment |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b              | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033              | [optional] |

### Return type

[**StockadjustmentTaskidGet200Response**](StockadjustmentTaskidGet200Response.md)

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

<a id="stockadjustmentlistpglmtstsget"></a>

# **StockadjustmentlistPgLmtStsGet**

> StockadjustmentlistPgLmtStsGet200Response StockadjustmentlistPgLmtStsGet (decimal page, decimal limit, string status, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StockadjustmentlistPgLmtStsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var status = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                StockadjustmentlistPgLmtStsGet200Response result = apiInstance.StockadjustmentlistPgLmtStsGet(page, limit, status, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StockadjustmentlistPgLmtStsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StockadjustmentlistPgLmtStsGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<StockadjustmentlistPgLmtStsGet200Response> response = apiInstance.StockadjustmentlistPgLmtStsGetWithHttpInfo(page, limit, status, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StockadjustmentlistPgLmtStsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes                         |
| ------------------------- | ----------- | ----------------------------------------- | ----------------------------- |
| **page**                  | **decimal** |                                           | [default to 1M]               |
| **limit**                 | **decimal** |                                           | [default to 100M]             |
| **status**                | **string**  |                                           | [default to &quot;null&quot;] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]                    |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]                    |

### Return type

[**StockadjustmentlistPgLmtStsGet200Response**](StockadjustmentlistPgLmtStsGet200Response.md)

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

<a id="stocktakeidvoiddelete"></a>

# **StocktakeIdVoidDelete**

> StocktakeIdVoidDelete200Response StocktakeIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StocktakeIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var ID = "ID_example";  // string | ID of Stock Transfer to Void
            var varVoid = true;  // bool | Void or Undo Stock Transfer
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                StocktakeIdVoidDelete200Response result = apiInstance.StocktakeIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktakeIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktakeIdVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<StocktakeIdVoidDelete200Response> response = apiInstance.StocktakeIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktakeIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Stock Transfer to Void              |            |
| **varVoid**               | **bool**    | Void or Undo Stock Transfer               |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**StocktakeIdVoidDelete200Response**](StocktakeIdVoidDelete200Response.md)

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

<a id="stocktakepost"></a>

# **StocktakePost**

> StocktakePost200Response StocktakePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StocktakePostRequest? stocktakePostRequest = null)

POST

-   POST method will create new stocktask with status IN PROGRESS. + To modify existing stocktake use PUT.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class StocktakePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var stocktakePostRequest = new StocktakePostRequest?(); // StocktakePostRequest? |  (optional)

            try
            {
                // POST
                StocktakePost200Response result = apiInstance.StocktakePost(apiAuthAccountid, apiAuthApplicationkey, stocktakePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktakePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktakePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<StocktakePost200Response> response = apiInstance.StocktakePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, stocktakePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktakePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                  | Description                               | Notes      |
| ------------------------- | ----------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **stocktakePostRequest**  | [**StocktakePostRequest?**](StocktakePostRequest?.md) |                                           | [optional] |

### Return type

[**StocktakePost200Response**](StocktakePost200Response.md)

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

<a id="stocktakeput"></a>

# **StocktakePut**

> StocktakePut200Response StocktakePut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StocktakePutRequest? stocktakePutRequest = null)

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
    public class StocktakePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var stocktakePutRequest = new StocktakePutRequest?(); // StocktakePutRequest? |  (optional)

            try
            {
                // PUT
                StocktakePut200Response result = apiInstance.StocktakePut(apiAuthAccountid, apiAuthApplicationkey, stocktakePutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktakePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktakePutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<StocktakePut200Response> response = apiInstance.StocktakePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, stocktakePutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktakePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                | Description                               | Notes      |
| ------------------------- | --------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **stocktakePutRequest**   | [**StocktakePutRequest?**](StocktakePutRequest?.md) |                                           | [optional] |

### Return type

[**StocktakePut200Response**](StocktakePut200Response.md)

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

<a id="stocktaketaskidget"></a>

# **StocktakeTaskidGet**

> StocktakeTaskidGet200Response StocktakeTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StocktakeTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Stock Take
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                StocktakeTaskidGet200Response result = apiInstance.StocktakeTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktakeTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktakeTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<StocktakeTaskidGet200Response> response = apiInstance.StocktakeTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktakeTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                      | Notes      |
| ------------------------- | ----------- | ------------------------------------------------ | ---------- |
| **taskID**                | **string**  | Returns detailed info of a particular Stock Take |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b        | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033        | [optional] |

### Return type

[**StocktakeTaskidGet200Response**](StocktakeTaskidGet200Response.md)

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

<a id="stocktakelistpglmtstsget"></a>

# **StocktakelistPgLmtStsGet**

> StocktakelistPgLmtStsGet200Response StocktakelistPgLmtStsGet (decimal page, decimal limit, string status, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StocktakelistPgLmtStsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var status = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                StocktakelistPgLmtStsGet200Response result = apiInstance.StocktakelistPgLmtStsGet(page, limit, status, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktakelistPgLmtStsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktakelistPgLmtStsGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<StocktakelistPgLmtStsGet200Response> response = apiInstance.StocktakelistPgLmtStsGetWithHttpInfo(page, limit, status, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktakelistPgLmtStsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes                         |
| ------------------------- | ----------- | ----------------------------------------- | ----------------------------- |
| **page**                  | **decimal** |                                           | [default to 1M]               |
| **limit**                 | **decimal** |                                           | [default to 100M]             |
| **status**                | **string**  |                                           | [default to &quot;null&quot;] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]                    |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]                    |

### Return type

[**StocktakelistPgLmtStsGet200Response**](StocktakelistPgLmtStsGet200Response.md)

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

<a id="stocktransferidvoiddelete"></a>

# **StocktransferIdVoidDelete**

> StocktransferIdVoidDelete200Response StocktransferIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StocktransferIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var ID = "ID_example";  // string | ID of Stock Transfer to Void
            var varVoid = true;  // bool | Void or Undo Stock Transfer
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                StocktransferIdVoidDelete200Response result = apiInstance.StocktransferIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktransferIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktransferIdVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<StocktransferIdVoidDelete200Response> response = apiInstance.StocktransferIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktransferIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Stock Transfer to Void              |            |
| **varVoid**               | **bool**    | Void or Undo Stock Transfer               |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**StocktransferIdVoidDelete200Response**](StocktransferIdVoidDelete200Response.md)

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

<a id="stocktransferorderpost"></a>

# **StocktransferOrderPost**

> StocktransferOrderPost200Response StocktransferOrderPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StocktransferOrderPostRequest? stocktransferOrderPostRequest = null)

POST

-   POST method will create and update stock transfer order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class StocktransferOrderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var stocktransferOrderPostRequest = new StocktransferOrderPostRequest?(); // StocktransferOrderPostRequest? |  (optional)

            try
            {
                // POST
                StocktransferOrderPost200Response result = apiInstance.StocktransferOrderPost(apiAuthAccountid, apiAuthApplicationkey, stocktransferOrderPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktransferOrderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktransferOrderPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<StocktransferOrderPost200Response> response = apiInstance.StocktransferOrderPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, stocktransferOrderPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktransferOrderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                              | Type                                                                    | Description                               | Notes      |
| --------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**              | **string?**                                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**         | **string?**                                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **stocktransferOrderPostRequest** | [**StocktransferOrderPostRequest?**](StocktransferOrderPostRequest?.md) |                                           | [optional] |

### Return type

[**StocktransferOrderPost200Response**](StocktransferOrderPost200Response.md)

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

<a id="stocktransferordertaskidget"></a>

# **StocktransferOrderTaskidGet**

> StocktransferOrderPost200Response StocktransferOrderTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StocktransferOrderTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Stock Transfer Order
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                StocktransferOrderPost200Response result = apiInstance.StocktransferOrderTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktransferOrderTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktransferOrderTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<StocktransferOrderPost200Response> response = apiInstance.StocktransferOrderTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktransferOrderTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                | Notes      |
| ------------------------- | ----------- | ---------------------------------------------------------- | ---------- |
| **taskID**                | **string**  | Returns detailed info of a particular Stock Transfer Order |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                  | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                  | [optional] |

### Return type

[**StocktransferOrderPost200Response**](StocktransferOrderPost200Response.md)

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

<a id="stocktransferpost"></a>

# **StocktransferPost**

> StocktransferPost200Response StocktransferPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StocktransferPostRequest? stocktransferPostRequest = null)

POST

-   POST method will create new stock transfer. + To modify existing stock transfer use PUT.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class StocktransferPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var stocktransferPostRequest = new StocktransferPostRequest?(); // StocktransferPostRequest? |  (optional)

            try
            {
                // POST
                StocktransferPost200Response result = apiInstance.StocktransferPost(apiAuthAccountid, apiAuthApplicationkey, stocktransferPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktransferPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktransferPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<StocktransferPost200Response> response = apiInstance.StocktransferPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, stocktransferPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktransferPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type                                                          | Description                               | Notes      |
| ---------------------------- | ------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**         | **string?**                                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**    | **string?**                                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **stocktransferPostRequest** | [**StocktransferPostRequest?**](StocktransferPostRequest?.md) |                                           | [optional] |

### Return type

[**StocktransferPost200Response**](StocktransferPost200Response.md)

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

<a id="stocktransferput"></a>

# **StocktransferPut**

> StocktransferPut200Response StocktransferPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StocktransferPutRequest? stocktransferPutRequest = null)

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
    public class StocktransferPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var stocktransferPutRequest = new StocktransferPutRequest?(); // StocktransferPutRequest? |  (optional)

            try
            {
                // PUT
                StocktransferPut200Response result = apiInstance.StocktransferPut(apiAuthAccountid, apiAuthApplicationkey, stocktransferPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktransferPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktransferPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<StocktransferPut200Response> response = apiInstance.StocktransferPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, stocktransferPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktransferPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                        | Type                                                        | Description                               | Notes      |
| --------------------------- | ----------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**        | **string?**                                                 | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**   | **string?**                                                 | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **stocktransferPutRequest** | [**StocktransferPutRequest?**](StocktransferPutRequest?.md) |                                           | [optional] |

### Return type

[**StocktransferPut200Response**](StocktransferPut200Response.md)

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

<a id="stocktransfertaskidget"></a>

# **StocktransferTaskidGet**

> StocktransferTaskidGet200Response StocktransferTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StocktransferTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Stock Transfer
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                StocktransferTaskidGet200Response result = apiInstance.StocktransferTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktransferTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktransferTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<StocktransferTaskidGet200Response> response = apiInstance.StocktransferTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktransferTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                          | Notes      |
| ------------------------- | ----------- | ---------------------------------------------------- | ---------- |
| **taskID**                | **string**  | Returns detailed info of a particular Stock Transfer |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b            | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033            | [optional] |

### Return type

[**StocktransferTaskidGet200Response**](StocktransferTaskidGet200Response.md)

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

<a id="stocktransferlistpglmtstssrchget"></a>

# **StocktransferlistPgLmtStsSrchGet**

> StocktransferlistPgLmtStsSrchGet200Response StocktransferlistPgLmtStsSrchGet (decimal page, decimal limit, string status, string search, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class StocktransferlistPgLmtStsSrchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new StockApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var status = "\"null\"";  // string |  (default to "null")
            var search = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                StocktransferlistPgLmtStsSrchGet200Response result = apiInstance.StocktransferlistPgLmtStsSrchGet(page, limit, status, search, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockApi.StocktransferlistPgLmtStsSrchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StocktransferlistPgLmtStsSrchGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<StocktransferlistPgLmtStsSrchGet200Response> response = apiInstance.StocktransferlistPgLmtStsSrchGetWithHttpInfo(page, limit, status, search, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockApi.StocktransferlistPgLmtStsSrchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes                         |
| ------------------------- | ----------- | ----------------------------------------- | ----------------------------- |
| **page**                  | **decimal** |                                           | [default to 1M]               |
| **limit**                 | **decimal** |                                           | [default to 100M]             |
| **status**                | **string**  |                                           | [default to &quot;null&quot;] |
| **search**                | **string**  |                                           | [default to &quot;null&quot;] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]                    |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]                    |

### Return type

[**StocktransferlistPgLmtStsSrchGet200Response**](StocktransferlistPgLmtStsSrchGet200Response.md)

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
