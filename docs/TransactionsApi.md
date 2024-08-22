# CIN7.DearInventory.Api.TransactionsApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                                        | HTTP request                                                                                                                                   | Description |
| ------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**TransactionsPgLmtFromdateTodateAccountGet**](TransactionsApi.md#transactionspglmtfromdatetodateaccountget) | **GET** /transactions?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;FromDate&#x3D;{FromDate}&amp;ToDate&#x3D;{ToDate}&amp;Account&#x3D;{Account} | GET         |

<a id="transactionspglmtfromdatetodateaccountget"></a>

# **TransactionsPgLmtFromdateTodateAccountGet**

> TransactionsPgLmtFromdateTodateAccountGet200Response TransactionsPgLmtFromdateTodateAccountGet (decimal page, decimal limit, string fromDate, string toDate, string account, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class TransactionsPgLmtFromdateTodateAccountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new TransactionsApi(config);
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100. (Default: 100)
            var fromDate = "fromDate_example";  // string | Only return Transactions with EffectiveDate more than FromDate (Default: null)
            var toDate = "toDate_example";  // string | Only return Transactions with EffectiveDate less than ToDate (Default: null)
            var account = "account_example";  // string | Only return Transactions filtered by debit or credit account code (Default: null)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                TransactionsPgLmtFromdateTodateAccountGet200Response result = apiInstance.TransactionsPgLmtFromdateTodateAccountGet(page, limit, fromDate, toDate, account, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsPgLmtFromdateTodateAccountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransactionsPgLmtFromdateTodateAccountGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<TransactionsPgLmtFromdateTodateAccountGet200Response> response = apiInstance.TransactionsPgLmtFromdateTodateAccountGetWithHttpInfo(page, limit, fromDate, toDate, account, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.TransactionsPgLmtFromdateTodateAccountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                       | Notes      |
| ------------------------- | ----------- | --------------------------------------------------------------------------------- | ---------- |
| **page**                  | **decimal** | Page (Default: 1)                                                                 |            |
| **limit**                 | **decimal** | Specifies the page size for pagination. Default page size is 100. (Default: 100)  |            |
| **fromDate**              | **string**  | Only return Transactions with EffectiveDate more than FromDate (Default: null)    |            |
| **toDate**                | **string**  | Only return Transactions with EffectiveDate less than ToDate (Default: null)      |            |
| **account**               | **string**  | Only return Transactions filtered by debit or credit account code (Default: null) |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                         | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                         | [optional] |

### Return type

[**TransactionsPgLmtFromdateTodateAccountGet200Response**](TransactionsPgLmtFromdateTodateAccountGet200Response.md)

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
