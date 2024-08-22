# CIN7.DearInventory.Api.FixedAssetTypeApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                      | HTTP request                                                                                                            | Description |
| ------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**RefFixedassettypePgLmtIdNameGet**](FixedAssetTypeApi.md#reffixedassettypepglmtidnameget) | **GET** /ref/fixedassettype?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{FixedAssetTypeID}&amp;Name&#x3D;{Name} | GET         |
| [**RefFixedassettypePost**](FixedAssetTypeApi.md#reffixedassettypepost)                     | **POST** /ref/fixedassettype                                                                                            | POST        |
| [**RefFixedassettypePut**](FixedAssetTypeApi.md#reffixedassettypeput)                       | **PUT** /ref/fixedassettype                                                                                             | PUT         |

<a id="reffixedassettypepglmtidnameget"></a>

# **RefFixedassettypePgLmtIdNameGet**

> RefFixedassettypePgLmtIdNameGet200Response RefFixedassettypePgLmtIdNameGet (decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class RefFixedassettypePgLmtIdNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FixedAssetTypeApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var fixedAssetTypeID = "fixedAssetTypeID_example";  // string | Only return Fixed Asset Type with the specific ID
            var name = "name_example";  // string | Only return accounts that start with the specific name
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                RefFixedassettypePgLmtIdNameGet200Response result = apiInstance.RefFixedassettypePgLmtIdNameGet(page, limit, fixedAssetTypeID, name, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FixedAssetTypeApi.RefFixedassettypePgLmtIdNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefFixedassettypePgLmtIdNameGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<RefFixedassettypePgLmtIdNameGet200Response> response = apiInstance.RefFixedassettypePgLmtIdNameGetWithHttpInfo(page, limit, fixedAssetTypeID, name, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FixedAssetTypeApi.RefFixedassettypePgLmtIdNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                            | Notes             |
| ------------------------- | ----------- | ------------------------------------------------------ | ----------------- |
| **page**                  | **decimal** |                                                        | [default to 1M]   |
| **limit**                 | **decimal** |                                                        | [default to 100M] |
| **fixedAssetTypeID**      | **string**  | Only return Fixed Asset Type with the specific ID      |                   |
| **name**                  | **string**  | Only return accounts that start with the specific name |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b              | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033              | [optional]        |

### Return type

[**RefFixedassettypePgLmtIdNameGet200Response**](RefFixedassettypePgLmtIdNameGet200Response.md)

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

<a id="reffixedassettypepost"></a>

# **RefFixedassettypePost**

> RefFixedassettypePost200Response RefFixedassettypePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefFixedassettypePostRequest? refFixedassettypePostRequest = null)

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
    public class RefFixedassettypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FixedAssetTypeApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var refFixedassettypePostRequest = new RefFixedassettypePostRequest?(); // RefFixedassettypePostRequest? |  (optional)

            try
            {
                // POST
                RefFixedassettypePost200Response result = apiInstance.RefFixedassettypePost(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FixedAssetTypeApi.RefFixedassettypePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefFixedassettypePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<RefFixedassettypePost200Response> response = apiInstance.RefFixedassettypePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FixedAssetTypeApi.RefFixedassettypePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **refFixedassettypePostRequest** | [**RefFixedassettypePostRequest?**](RefFixedassettypePostRequest?.md) |                                           | [optional] |

### Return type

[**RefFixedassettypePost200Response**](RefFixedassettypePost200Response.md)

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

<a id="reffixedassettypeput"></a>

# **RefFixedassettypePut**

> RefFixedassettypePut200Response RefFixedassettypePut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefFixedassettypePutRequest? refFixedassettypePutRequest = null)

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
    public class RefFixedassettypePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new FixedAssetTypeApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var refFixedassettypePutRequest = new RefFixedassettypePutRequest?(); // RefFixedassettypePutRequest? |  (optional)

            try
            {
                // PUT
                RefFixedassettypePut200Response result = apiInstance.RefFixedassettypePut(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FixedAssetTypeApi.RefFixedassettypePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefFixedassettypePutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<RefFixedassettypePut200Response> response = apiInstance.RefFixedassettypePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FixedAssetTypeApi.RefFixedassettypePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                            | Type                                                                | Description                               | Notes      |
| ------------------------------- | ------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**            | **string?**                                                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**       | **string?**                                                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **refFixedassettypePutRequest** | [**RefFixedassettypePutRequest?**](RefFixedassettypePutRequest?.md) |                                           | [optional] |

### Return type

[**RefFixedassettypePut200Response**](RefFixedassettypePut200Response.md)

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
