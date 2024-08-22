# CIN7.DearInventory.Api.PaymentTermApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                       | HTTP request                                                                                                                                                                                | Description |
| ---------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**PaymenttermPgLmtIdNameEtc**](PaymentTermApi.md#paymenttermpglmtidnameetc) | **GET** /ref/paymentterm?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;Method&#x3D;{Method}&amp;IsActive&#x3D;{IsActive}&amp;IsDefault&#x3D;{IsDefault} | GET         |
| [**RefPaymenttermIdDelete**](PaymentTermApi.md#refpaymenttermiddelete)       | **DELETE** /ref/paymentterm?ID&#x3D;{ID}                                                                                                                                                    | DELETE      |
| [**RefPaymenttermPost**](PaymentTermApi.md#refpaymenttermpost)               | **POST** /ref/paymentterm                                                                                                                                                                   | POST        |
| [**RefPaymenttermPut**](PaymentTermApi.md#refpaymenttermput)                 | **PUT** /ref/paymentterm                                                                                                                                                                    | PUT         |

<a id="paymenttermpglmtidnameetc"></a>

# **PaymenttermPgLmtIdNameEtc**

> PaymenttermPgLmtIdNameEtc200Response PaymenttermPgLmtIdNameEtc (decimal page, decimal limit, string ID, string name, string method, bool isActive, bool isDefault, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PaymenttermPgLmtIdNameEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PaymentTermApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "ID_example";  // string | Only return Payment Term with the specific ID
            var name = "name_example";  // string | Only return Payment Terms that start with the specific Name
            var method = "method_example";  // string | Only return Payment Terms with the specific Method
            var isActive = true;  // bool | Only return Payment Terms which are marked as active.
            var isDefault = true;  // bool | Only return Payment Terms which are marked as default.
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PaymenttermPgLmtIdNameEtc200Response result = apiInstance.PaymenttermPgLmtIdNameEtc(page, limit, ID, name, method, isActive, isDefault, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermApi.PaymenttermPgLmtIdNameEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymenttermPgLmtIdNameEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PaymenttermPgLmtIdNameEtc200Response> response = apiInstance.PaymenttermPgLmtIdNameEtcWithHttpInfo(page, limit, ID, name, method, isActive, isDefault, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermApi.PaymenttermPgLmtIdNameEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                 | Notes             |
| ------------------------- | ----------- | ----------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                             | [default to 1M]   |
| **limit**                 | **decimal** |                                                             | [default to 100M] |
| **ID**                    | **string**  | Only return Payment Term with the specific ID               |                   |
| **name**                  | **string**  | Only return Payment Terms that start with the specific Name |                   |
| **method**                | **string**  | Only return Payment Terms with the specific Method          |                   |
| **isActive**              | **bool**    | Only return Payment Terms which are marked as active.       |                   |
| **isDefault**             | **bool**    | Only return Payment Terms which are marked as default.      |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                   | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                   | [optional]        |

### Return type

[**PaymenttermPgLmtIdNameEtc200Response**](PaymenttermPgLmtIdNameEtc200Response.md)

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

<a id="refpaymenttermiddelete"></a>

# **RefPaymenttermIdDelete**

> MeAddressesIdDelete200Response RefPaymenttermIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class RefPaymenttermIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PaymentTermApi(config);
            var ID = "ID_example";  // string | ID of Payment Term to Delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.RefPaymenttermIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermApi.RefPaymenttermIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefPaymenttermIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.RefPaymenttermIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermApi.RefPaymenttermIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Payment Term to Delete              |            |
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

<a id="refpaymenttermpost"></a>

# **RefPaymenttermPost**

> RefPaymenttermPost200Response RefPaymenttermPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefPaymenttermPostRequest? refPaymenttermPostRequest = null)

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
    public class RefPaymenttermPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PaymentTermApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var refPaymenttermPostRequest = new RefPaymenttermPostRequest?(); // RefPaymenttermPostRequest? |  (optional)

            try
            {
                // POST
                RefPaymenttermPost200Response result = apiInstance.RefPaymenttermPost(apiAuthAccountid, apiAuthApplicationkey, refPaymenttermPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermApi.RefPaymenttermPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefPaymenttermPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<RefPaymenttermPost200Response> response = apiInstance.RefPaymenttermPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refPaymenttermPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermApi.RefPaymenttermPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                          | Type                                                            | Description                               | Notes      |
| ----------------------------- | --------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**          | **string?**                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**     | **string?**                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **refPaymenttermPostRequest** | [**RefPaymenttermPostRequest?**](RefPaymenttermPostRequest?.md) |                                           | [optional] |

### Return type

[**RefPaymenttermPost200Response**](RefPaymenttermPost200Response.md)

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

<a id="refpaymenttermput"></a>

# **RefPaymenttermPut**

> RefPaymenttermPut200Response RefPaymenttermPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefPaymenttermPutRequest? refPaymenttermPutRequest = null)

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
    public class RefPaymenttermPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PaymentTermApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var refPaymenttermPutRequest = new RefPaymenttermPutRequest?(); // RefPaymenttermPutRequest? |  (optional)

            try
            {
                // PUT
                RefPaymenttermPut200Response result = apiInstance.RefPaymenttermPut(apiAuthAccountid, apiAuthApplicationkey, refPaymenttermPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermApi.RefPaymenttermPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefPaymenttermPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<RefPaymenttermPut200Response> response = apiInstance.RefPaymenttermPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refPaymenttermPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermApi.RefPaymenttermPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type                                                          | Description                               | Notes      |
| ---------------------------- | ------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**         | **string?**                                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**    | **string?**                                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **refPaymenttermPutRequest** | [**RefPaymenttermPutRequest?**](RefPaymenttermPutRequest?.md) |                                           | [optional] |

### Return type

[**RefPaymenttermPut200Response**](RefPaymenttermPut200Response.md)

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
