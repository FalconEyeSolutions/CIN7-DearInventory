# CIN7.DearInventory.Api.JournalApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                         | HTTP request                                                                                                                        | Description |
| ------------------------------------------------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**JournalIdVoidDelete**](JournalApi.md#journalidvoiddelete)                   | **DELETE** /journal?ID&#x3D;{ID}&amp;Void&#x3D;{Void}                                                                               | Delete      |
| [**JournalPgLmtTaskidStsSrchGet**](JournalApi.md#journalpglmttaskidstssrchget) | **GET** /journal?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;TaskID&#x3D;{TaskID}&amp;Status&#x3D;{Status}&amp;Search&#x3D;{Search} | GET         |
| [**JournalPost**](JournalApi.md#journalpost)                                   | **POST** /journal                                                                                                                   | POST        |
| [**JournalPut**](JournalApi.md#journalput)                                     | **PUT** /journal                                                                                                                    | PUT         |

<a id="journalidvoiddelete"></a>

# **JournalIdVoidDelete**

> JournalIdVoidDelete200Response JournalIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Delete

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class JournalIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new JournalApi(config);
            var ID = "ID_example";  // string | ID of Jorunal to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Delete
                JournalIdVoidDelete200Response result = apiInstance.JournalIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalApi.JournalIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalIdVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<JournalIdVoidDelete200Response> response = apiInstance.JournalIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalApi.JournalIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **ID**                    | **string**  | ID of Jorunal to Void or Undo             |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**JournalIdVoidDelete200Response**](JournalIdVoidDelete200Response.md)

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

<a id="journalpglmttaskidstssrchget"></a>

# **JournalPgLmtTaskidStsSrchGet**

> JournalPgLmtTaskidStsSrchGet200Response JournalPgLmtTaskidStsSrchGet (decimal page, decimal limit, string taskID, string status, string search, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class JournalPgLmtTaskidStsSrchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new JournalApi(config);
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Journal
            var status = "status_example";  // string | \"Only return Journals with specified status (Default: null)
            var search = "search_example";  // string | Only return Journals with search value contained in one of these fields: JournalNumber, Status, Narration, Notes (Default: null)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                JournalPgLmtTaskidStsSrchGet200Response result = apiInstance.JournalPgLmtTaskidStsSrchGet(page, limit, taskID, status, search, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalApi.JournalPgLmtTaskidStsSrchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalPgLmtTaskidStsSrchGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<JournalPgLmtTaskidStsSrchGet200Response> response = apiInstance.JournalPgLmtTaskidStsSrchGetWithHttpInfo(page, limit, taskID, status, search, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalApi.JournalPgLmtTaskidStsSrchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                                                                      | Notes      |
| ------------------------- | ----------- | -------------------------------------------------------------------------------------------------------------------------------- | ---------- |
| **page**                  | **decimal** | Page (Default: 1)                                                                                                                |            |
| **limit**                 | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100)                                                 |            |
| **taskID**                | **string**  | Returns detailed info of a particular Journal                                                                                    |            |
| **status**                | **string**  | \&quot;Only return Journals with specified status (Default: null)                                                                |            |
| **search**                | **string**  | Only return Journals with search value contained in one of these fields: JournalNumber, Status, Narration, Notes (Default: null) |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                                        | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                                        | [optional] |

### Return type

[**JournalPgLmtTaskidStsSrchGet200Response**](JournalPgLmtTaskidStsSrchGet200Response.md)

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

<a id="journalpost"></a>

# **JournalPost**

> JournalPost200Response JournalPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, JournalPostRequest? journalPostRequest = null)

POST

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class JournalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new JournalApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var journalPostRequest = new JournalPostRequest?(); // JournalPostRequest? |  (optional)

            try
            {
                // POST
                JournalPost200Response result = apiInstance.JournalPost(apiAuthAccountid, apiAuthApplicationkey, journalPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalApi.JournalPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<JournalPost200Response> response = apiInstance.JournalPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, journalPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalApi.JournalPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                              | Description                               | Notes      |
| ------------------------- | ------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **journalPostRequest**    | [**JournalPostRequest?**](JournalPostRequest?.md) |                                           | [optional] |

### Return type

[**JournalPost200Response**](JournalPost200Response.md)

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

<a id="journalput"></a>

# **JournalPut**

> JournalPut200Response JournalPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, JournalPutRequest? journalPutRequest = null)

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
    public class JournalPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new JournalApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var journalPutRequest = new JournalPutRequest?(); // JournalPutRequest? |  (optional)

            try
            {
                // PUT
                JournalPut200Response result = apiInstance.JournalPut(apiAuthAccountid, apiAuthApplicationkey, journalPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalApi.JournalPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<JournalPut200Response> response = apiInstance.JournalPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, journalPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalApi.JournalPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                            | Description                               | Notes      |
| ------------------------- | ----------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **journalPutRequest**     | [**JournalPutRequest?**](JournalPutRequest?.md) |                                           | [optional] |

### Return type

[**JournalPut200Response**](JournalPut200Response.md)

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
