# CIN7.DearInventory.Api.MeApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                          | HTTP request                                                                                                                                                                                                                                    | Description |
| --------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**AddressesPgLmtIdTypeEtc**](MeApi.md#addressespglmtidtypeetc) | **GET** /me/addresses?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Type&#x3D;{Type}&amp;DefaultForType&#x3D;{DefaultForType}&amp;Country&#x3D;{Country}&amp;StateProvince&#x3D;{StateProvince}&amp;CitySuburb&#x3D;{CitySuburb} | GET         |
| [**ContactsPgLmtIdNameEtc**](MeApi.md#contactspglmtidnameetc)   | **GET** /me/contacts?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;Type&#x3D;{Type}&amp;DefaultForType&#x3D;{DefaultForType}&amp;Phone&#x3D;{Phone}&amp;Fax&#x3D;{Fax}&amp;Email&#x3D;{Email}               | GET         |
| [**MeAddressesIdDelete**](MeApi.md#meaddressesiddelete)         | **DELETE** /me/addresses?ID&#x3D;{ID}                                                                                                                                                                                                           | DELETE      |
| [**MeAddressesPost**](MeApi.md#meaddressespost)                 | **POST** /me/addresses                                                                                                                                                                                                                          | POST        |
| [**MeAddressesPut**](MeApi.md#meaddressesput)                   | **PUT** /me/addresses                                                                                                                                                                                                                           | PUT         |
| [**MeContactsIdDelete**](MeApi.md#mecontactsiddelete)           | **DELETE** /me/contacts?ID&#x3D;{ID}                                                                                                                                                                                                            | DELETE      |
| [**MeContactsPost**](MeApi.md#mecontactspost)                   | **POST** /me/contacts                                                                                                                                                                                                                           | POST        |
| [**MeContactsPut**](MeApi.md#mecontactsput)                     | **PUT** /me/contacts                                                                                                                                                                                                                            | PUT         |
| [**MeGet**](MeApi.md#meget)                                     | **GET** /me                                                                                                                                                                                                                                     | GET         |

<a id="addressespglmtidtypeetc"></a>

# **AddressesPgLmtIdTypeEtc**

> AddressesPgLmtIdTypeEtc200Response AddressesPgLmtIdTypeEtc (decimal page, decimal limit, string ID, string type, bool defaultForType, string country, string stateProvince, string citySuburb, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AddressesPgLmtIdTypeEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "ID_example";  // string | Only return MeAddress with the specific ID
            var type = "type_example";  // string | Only return MeAddresses with the specific Type
            var defaultForType = true;  // bool | Only return MeAddresses which are marked as default for chosen Type
            var country = "country_example";  // string | Only return MeAddresses with the specific Country
            var stateProvince = "stateProvince_example";  // string | Only return MeAddresses with the specific StateProvince
            var citySuburb = "citySuburb_example";  // string | Only return MeAddresses with the specific CitySuburb
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AddressesPgLmtIdTypeEtc200Response result = apiInstance.AddressesPgLmtIdTypeEtc(page, limit, ID, type, defaultForType, country, stateProvince, citySuburb, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.AddressesPgLmtIdTypeEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressesPgLmtIdTypeEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AddressesPgLmtIdTypeEtc200Response> response = apiInstance.AddressesPgLmtIdTypeEtcWithHttpInfo(page, limit, ID, type, defaultForType, country, stateProvince, citySuburb, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.AddressesPgLmtIdTypeEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                         | Notes             |
| ------------------------- | ----------- | ------------------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                                     | [default to 1M]   |
| **limit**                 | **decimal** |                                                                     | [default to 100M] |
| **ID**                    | **string**  | Only return MeAddress with the specific ID                          |                   |
| **type**                  | **string**  | Only return MeAddresses with the specific Type                      |                   |
| **defaultForType**        | **bool**    | Only return MeAddresses which are marked as default for chosen Type |                   |
| **country**               | **string**  | Only return MeAddresses with the specific Country                   |                   |
| **stateProvince**         | **string**  | Only return MeAddresses with the specific StateProvince             |                   |
| **citySuburb**            | **string**  | Only return MeAddresses with the specific CitySuburb                |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                           | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                           | [optional]        |

### Return type

[**AddressesPgLmtIdTypeEtc200Response**](AddressesPgLmtIdTypeEtc200Response.md)

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

<a id="contactspglmtidnameetc"></a>

# **ContactsPgLmtIdNameEtc**

> ContactsPgLmtIdNameEtc200Response ContactsPgLmtIdNameEtc (decimal page, decimal limit, string ID, string name, string type, bool defaultForType, string phone, string fax, string email, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ContactsPgLmtIdNameEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "ID_example";  // string | Only return MeContact with the specific ID
            var name = "name_example";  // string | Only return MeContact that start with the specific Name
            var type = "type_example";  // string | Only return MeContact with the specific Type
            var defaultForType = true;  // bool | Only return MeContact which are marked as default for chosen Type
            var phone = "phone_example";  // string | Only return MeContact with the specific Phone
            var fax = "fax_example";  // string | Only return MeContact with the specific Fax
            var email = "email_example";  // string | Only return MeContact with the specific Email
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                ContactsPgLmtIdNameEtc200Response result = apiInstance.ContactsPgLmtIdNameEtc(page, limit, ID, name, type, defaultForType, phone, fax, email, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.ContactsPgLmtIdNameEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactsPgLmtIdNameEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ContactsPgLmtIdNameEtc200Response> response = apiInstance.ContactsPgLmtIdNameEtcWithHttpInfo(page, limit, ID, name, type, defaultForType, phone, fax, email, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.ContactsPgLmtIdNameEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                       | Notes             |
| ------------------------- | ----------- | ----------------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                                   | [default to 1M]   |
| **limit**                 | **decimal** |                                                                   | [default to 100M] |
| **ID**                    | **string**  | Only return MeContact with the specific ID                        |                   |
| **name**                  | **string**  | Only return MeContact that start with the specific Name           |                   |
| **type**                  | **string**  | Only return MeContact with the specific Type                      |                   |
| **defaultForType**        | **bool**    | Only return MeContact which are marked as default for chosen Type |                   |
| **phone**                 | **string**  | Only return MeContact with the specific Phone                     |                   |
| **fax**                   | **string**  | Only return MeContact with the specific Fax                       |                   |
| **email**                 | **string**  | Only return MeContact with the specific Email                     |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                         | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                         | [optional]        |

### Return type

[**ContactsPgLmtIdNameEtc200Response**](ContactsPgLmtIdNameEtc200Response.md)

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

<a id="meaddressesiddelete"></a>

# **MeAddressesIdDelete**

> MeAddressesIdDelete200Response MeAddressesIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class MeAddressesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var ID = "ID_example";  // string | ID of MeAddress to Delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.MeAddressesIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.MeAddressesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MeAddressesIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.MeAddressesIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.MeAddressesIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of MeAddress to Delete                 |            |
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

<a id="meaddressespost"></a>

# **MeAddressesPost**

> MeAddressesPost200Response MeAddressesPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, MeAddressesPostRequest? meAddressesPostRequest = null)

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
    public class MeAddressesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var meAddressesPostRequest = new MeAddressesPostRequest?(); // MeAddressesPostRequest? |  (optional)

            try
            {
                // POST
                MeAddressesPost200Response result = apiInstance.MeAddressesPost(apiAuthAccountid, apiAuthApplicationkey, meAddressesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.MeAddressesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MeAddressesPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<MeAddressesPost200Response> response = apiInstance.MeAddressesPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, meAddressesPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.MeAddressesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                       | Type                                                      | Description                               | Notes      |
| -------------------------- | --------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**       | **string?**                                               | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**  | **string?**                                               | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **meAddressesPostRequest** | [**MeAddressesPostRequest?**](MeAddressesPostRequest?.md) |                                           | [optional] |

### Return type

[**MeAddressesPost200Response**](MeAddressesPost200Response.md)

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

<a id="meaddressesput"></a>

# **MeAddressesPut**

> MeAddressesPut200Response MeAddressesPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, MeAddressesPutRequest? meAddressesPutRequest = null)

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
    public class MeAddressesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var meAddressesPutRequest = new MeAddressesPutRequest?(); // MeAddressesPutRequest? |  (optional)

            try
            {
                // PUT
                MeAddressesPut200Response result = apiInstance.MeAddressesPut(apiAuthAccountid, apiAuthApplicationkey, meAddressesPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.MeAddressesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MeAddressesPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<MeAddressesPut200Response> response = apiInstance.MeAddressesPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, meAddressesPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.MeAddressesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                    | Description                               | Notes      |
| ------------------------- | ------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **meAddressesPutRequest** | [**MeAddressesPutRequest?**](MeAddressesPutRequest?.md) |                                           | [optional] |

### Return type

[**MeAddressesPut200Response**](MeAddressesPut200Response.md)

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

<a id="mecontactsiddelete"></a>

# **MeContactsIdDelete**

> MeAddressesIdDelete200Response MeContactsIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class MeContactsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var ID = "ID_example";  // string | ID of MeContact to Delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.MeContactsIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.MeContactsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MeContactsIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.MeContactsIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.MeContactsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of MeContact to Delete                 |            |
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

<a id="mecontactspost"></a>

# **MeContactsPost**

> MeContactsPost200Response MeContactsPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, MeContactsPostRequest? meContactsPostRequest = null)

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
    public class MeContactsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var meContactsPostRequest = new MeContactsPostRequest?(); // MeContactsPostRequest? |  (optional)

            try
            {
                // POST
                MeContactsPost200Response result = apiInstance.MeContactsPost(apiAuthAccountid, apiAuthApplicationkey, meContactsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.MeContactsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MeContactsPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<MeContactsPost200Response> response = apiInstance.MeContactsPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, meContactsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.MeContactsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                    | Description                               | Notes      |
| ------------------------- | ------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **meContactsPostRequest** | [**MeContactsPostRequest?**](MeContactsPostRequest?.md) |                                           | [optional] |

### Return type

[**MeContactsPost200Response**](MeContactsPost200Response.md)

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

<a id="mecontactsput"></a>

# **MeContactsPut**

> MeContactsPut200Response MeContactsPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, MeContactsPutRequest? meContactsPutRequest = null)

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
    public class MeContactsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var meContactsPutRequest = new MeContactsPutRequest?(); // MeContactsPutRequest? |  (optional)

            try
            {
                // PUT
                MeContactsPut200Response result = apiInstance.MeContactsPut(apiAuthAccountid, apiAuthApplicationkey, meContactsPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.MeContactsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MeContactsPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<MeContactsPut200Response> response = apiInstance.MeContactsPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, meContactsPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.MeContactsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                  | Description                               | Notes      |
| ------------------------- | ----------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **meContactsPutRequest**  | [**MeContactsPutRequest?**](MeContactsPutRequest?.md) |                                           | [optional] |

### Return type

[**MeContactsPut200Response**](MeContactsPut200Response.md)

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

<a id="meget"></a>

# **MeGet**

> MeGet200Response MeGet (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class MeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new MeApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                MeGet200Response result = apiInstance.MeGet(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MeApi.MeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MeGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<MeGet200Response> response = apiInstance.MeGetWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MeApi.MeGetWithHttpInfo: " + e.Message);
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

[**MeGet200Response**](MeGet200Response.md)

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
