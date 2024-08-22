# CIN7.DearInventory.Api.ChartOfAccountsApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                       | HTTP request                                                                                                                                         | Description |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**AccountPgLmtCodeNameEtc**](ChartOfAccountsApi.md#accountpglmtcodenameetc) | **GET** /ref/account?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Code&#x3D;{Code}&amp;Name&#x3D;{Name}&amp;Type&#x3D;{Type}&amp;Status&#x3D;{Status} | GET         |
| [**RefAccountCodeDelete**](ChartOfAccountsApi.md#refaccountcodedelete)       | **DELETE** /ref/account?Code&#x3D;{Code}                                                                                                             | DELETE      |
| [**RefAccountPost**](ChartOfAccountsApi.md#refaccountpost)                   | **POST** /ref/account                                                                                                                                | POST        |
| [**RefAccountPut**](ChartOfAccountsApi.md#refaccountput)                     | **PUT** /ref/account                                                                                                                                 | PUT         |

<a id="accountpglmtcodenameetc"></a>

# **AccountPgLmtCodeNameEtc**

> AccountPgLmtCodeNameEtc200Response AccountPgLmtCodeNameEtc (decimal page, decimal limit, string code, string name, string type, string status, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AccountPgLmtCodeNameEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ChartOfAccountsApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var code = "code_example";  // string | Only return accounts with the specific code
            var name = "name_example";  // string | Only return accounts that start with the specific name
            var type = "type_example";  // string | Only return accounts with the specific type
            var status = "status_example";  // string | Only return accounts with the specific status
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AccountPgLmtCodeNameEtc200Response result = apiInstance.AccountPgLmtCodeNameEtc(page, limit, code, name, type, status, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.AccountPgLmtCodeNameEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountPgLmtCodeNameEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AccountPgLmtCodeNameEtc200Response> response = apiInstance.AccountPgLmtCodeNameEtcWithHttpInfo(page, limit, code, name, type, status, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.AccountPgLmtCodeNameEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                            | Notes             |
| ------------------------- | ----------- | ------------------------------------------------------ | ----------------- |
| **page**                  | **decimal** |                                                        | [default to 1M]   |
| **limit**                 | **decimal** |                                                        | [default to 100M] |
| **code**                  | **string**  | Only return accounts with the specific code            |                   |
| **name**                  | **string**  | Only return accounts that start with the specific name |                   |
| **type**                  | **string**  | Only return accounts with the specific type            |                   |
| **status**                | **string**  | Only return accounts with the specific status          |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b              | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033              | [optional]        |

### Return type

[**AccountPgLmtCodeNameEtc200Response**](AccountPgLmtCodeNameEtc200Response.md)

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

<a id="refaccountcodedelete"></a>

# **RefAccountCodeDelete**

> MeAddressesIdDelete200Response RefAccountCodeDelete (string code, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class RefAccountCodeDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ChartOfAccountsApi(config);
            var code = "code_example";  // string | Code of account to Delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.RefAccountCodeDelete(code, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.RefAccountCodeDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefAccountCodeDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.RefAccountCodeDeleteWithHttpInfo(code, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.RefAccountCodeDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **code**                  | **string**  | Code of account to Delete                 |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**MeAddressesIdDelete200Response**](MeAddressesIdDelete200Response.md)

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

<a id="refaccountpost"></a>

# **RefAccountPost**

> RefAccountPost200Response RefAccountPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class RefAccountPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ChartOfAccountsApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                RefAccountPost200Response result = apiInstance.RefAccountPost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.RefAccountPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefAccountPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<RefAccountPost200Response> response = apiInstance.RefAccountPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.RefAccountPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**RefAccountPost200Response**](RefAccountPost200Response.md)

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

<a id="refaccountput"></a>

# **RefAccountPut**

> RefAccountPut200Response RefAccountPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefAccountPutRequest? refAccountPutRequest = null)

PUT

-   Updating accounts is not allowed while integration with Xero or Quickbooks enabled.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class RefAccountPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ChartOfAccountsApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var refAccountPutRequest = new RefAccountPutRequest?(); // RefAccountPutRequest? |  (optional)

            try
            {
                // PUT
                RefAccountPut200Response result = apiInstance.RefAccountPut(apiAuthAccountid, apiAuthApplicationkey, refAccountPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.RefAccountPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefAccountPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<RefAccountPut200Response> response = apiInstance.RefAccountPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refAccountPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.RefAccountPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                  | Description                               | Notes      |
| ------------------------- | ----------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **refAccountPutRequest**  | [**RefAccountPutRequest?**](RefAccountPutRequest?.md) |                                           | [optional] |

### Return type

[**RefAccountPut200Response**](RefAccountPut200Response.md)

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
