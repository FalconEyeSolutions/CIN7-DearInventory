# CIN7.DearInventory.Api.BankAccountsApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                | HTTP request                                                                                                                 | Description |
| --------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**AccountBankPgLmtIdEtc**](BankAccountsApi.md#accountbankpglmtidetc) | **GET** /ref/account/bank?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;Bank&#x3D;{Bank} | GET         |

<a id="accountbankpglmtidetc"></a>

# **AccountBankPgLmtIdEtc**

> AccountBankPgLmtIdEtc200Response AccountBankPgLmtIdEtc (decimal page, decimal limit, string ID, string name, string bank, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AccountBankPgLmtIdEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new BankAccountsApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "ID_example";  // string | Only return accounts with the specific code
            var name = "name_example";  // string | Only return accounts that start with the specific name
            var bank = "bank_example";  // string | Only return accounts with the specific bank
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AccountBankPgLmtIdEtc200Response result = apiInstance.AccountBankPgLmtIdEtc(page, limit, ID, name, bank, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankAccountsApi.AccountBankPgLmtIdEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountBankPgLmtIdEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AccountBankPgLmtIdEtc200Response> response = apiInstance.AccountBankPgLmtIdEtcWithHttpInfo(page, limit, ID, name, bank, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankAccountsApi.AccountBankPgLmtIdEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                            | Notes             |
| ------------------------- | ----------- | ------------------------------------------------------ | ----------------- |
| **page**                  | **decimal** |                                                        | [default to 1M]   |
| **limit**                 | **decimal** |                                                        | [default to 100M] |
| **ID**                    | **string**  | Only return accounts with the specific code            |                   |
| **name**                  | **string**  | Only return accounts that start with the specific name |                   |
| **bank**                  | **string**  | Only return accounts with the specific bank            |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b              | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033              | [optional]        |

### Return type

[**AccountBankPgLmtIdEtc200Response**](AccountBankPgLmtIdEtc200Response.md)

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
