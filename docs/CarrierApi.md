# CIN7.DearInventory.Api.CarrierApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                             | HTTP request                                                                                                                   | Description |
| -------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------ | ----------- |
| [**RefCarrierIdDelete**](CarrierApi.md#refcarrieriddelete)                                         | **DELETE** /ref/carrier?ID&#x3D;{ID}                                                                                           | DELETE      |
| [**RefCarrierPgLmtCarrieridDescriptionGet**](CarrierApi.md#refcarrierpglmtcarrieriddescriptionget) | **GET** /ref/carrier?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;CarrierID&#x3D;{CarrierID}&amp;Description&#x3D;{Description} | GET         |
| [**RefCarrierPost**](CarrierApi.md#refcarrierpost)                                                 | **POST** /ref/carrier                                                                                                          | POST        |
| [**RefCarrierPut**](CarrierApi.md#refcarrierput)                                                   | **PUT** /ref/carrier                                                                                                           | PUT         |

<a id="refcarrieriddelete"></a>

# **RefCarrierIdDelete**

> MeAddressesIdDelete200Response RefCarrierIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class RefCarrierIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CarrierApi(config);
            var ID = "ID_example";  // string | ID of Carrier to Delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.RefCarrierIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarrierApi.RefCarrierIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefCarrierIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.RefCarrierIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarrierApi.RefCarrierIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Carrier to Delete                   |            |
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

<a id="refcarrierpglmtcarrieriddescriptionget"></a>

# **RefCarrierPgLmtCarrieridDescriptionGet**

> RefCarrierPgLmtCarrieridDescriptionGet200Response RefCarrierPgLmtCarrieridDescriptionGet (decimal page, decimal limit, string carrierID, string description, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class RefCarrierPgLmtCarrieridDescriptionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CarrierApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var carrierID = "carrierID_example";  // string | Only return Carrier with the specific CarrierID
            var description = "description_example";  // string | Only return Carriers that start with the specific Description
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                RefCarrierPgLmtCarrieridDescriptionGet200Response result = apiInstance.RefCarrierPgLmtCarrieridDescriptionGet(page, limit, carrierID, description, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarrierApi.RefCarrierPgLmtCarrieridDescriptionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefCarrierPgLmtCarrieridDescriptionGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<RefCarrierPgLmtCarrieridDescriptionGet200Response> response = apiInstance.RefCarrierPgLmtCarrieridDescriptionGetWithHttpInfo(page, limit, carrierID, description, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarrierApi.RefCarrierPgLmtCarrieridDescriptionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                   | Notes             |
| ------------------------- | ----------- | ------------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                               | [default to 1M]   |
| **limit**                 | **decimal** |                                                               | [default to 100M] |
| **carrierID**             | **string**  | Only return Carrier with the specific CarrierID               |                   |
| **description**           | **string**  | Only return Carriers that start with the specific Description |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                     | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                     | [optional]        |

### Return type

[**RefCarrierPgLmtCarrieridDescriptionGet200Response**](RefCarrierPgLmtCarrieridDescriptionGet200Response.md)

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

<a id="refcarrierpost"></a>

# **RefCarrierPost**

> RefCarrierPost200Response RefCarrierPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefCarrierPostRequest? refCarrierPostRequest = null)

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
    public class RefCarrierPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CarrierApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var refCarrierPostRequest = new RefCarrierPostRequest?(); // RefCarrierPostRequest? |  (optional)

            try
            {
                // POST
                RefCarrierPost200Response result = apiInstance.RefCarrierPost(apiAuthAccountid, apiAuthApplicationkey, refCarrierPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarrierApi.RefCarrierPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefCarrierPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<RefCarrierPost200Response> response = apiInstance.RefCarrierPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refCarrierPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarrierApi.RefCarrierPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                    | Description                               | Notes      |
| ------------------------- | ------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **refCarrierPostRequest** | [**RefCarrierPostRequest?**](RefCarrierPostRequest?.md) |                                           | [optional] |

### Return type

[**RefCarrierPost200Response**](RefCarrierPost200Response.md)

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

<a id="refcarrierput"></a>

# **RefCarrierPut**

> RefCarrierPut200Response RefCarrierPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefCarrierPutRequest? refCarrierPutRequest = null)

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
    public class RefCarrierPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CarrierApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var refCarrierPutRequest = new RefCarrierPutRequest?(); // RefCarrierPutRequest? |  (optional)

            try
            {
                // PUT
                RefCarrierPut200Response result = apiInstance.RefCarrierPut(apiAuthAccountid, apiAuthApplicationkey, refCarrierPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarrierApi.RefCarrierPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefCarrierPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<RefCarrierPut200Response> response = apiInstance.RefCarrierPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refCarrierPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarrierApi.RefCarrierPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                  | Description                               | Notes      |
| ------------------------- | ----------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **refCarrierPutRequest**  | [**RefCarrierPutRequest?**](RefCarrierPutRequest?.md) |                                           | [optional] |

### Return type

[**RefCarrierPut200Response**](RefCarrierPut200Response.md)

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
