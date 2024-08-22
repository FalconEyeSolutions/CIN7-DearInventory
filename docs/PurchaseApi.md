# CIN7.DearInventory.Api.PurchaseApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                                                                                | HTTP request                                                                                                                                                                                                                                                                                                                                                                                                                                  | Description |
| ----------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**AdvancedPurchaseAwayPost**](PurchaseApi.md#advancedpurchaseawaypost)                                                                               | **POST** /advanced-purchase/put-away                                                                                                                                                                                                                                                                                                                                                                                                          | POST        |
| [**AdvancedPurchaseAwayPurchaseidGet**](PurchaseApi.md#advancedpurchaseawaypurchaseidget)                                                             | **GET** /advanced-purchase/put-away?PurchaseID&#x3D;{PurchaseID}                                                                                                                                                                                                                                                                                                                                                                              | GET         |
| [**AdvancedPurchaseCreditnotePost**](PurchaseApi.md#advancedpurchasecreditnotepost)                                                                   | **POST** /advanced-purchase/creditnote                                                                                                                                                                                                                                                                                                                                                                                                        | POST        |
| [**AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet**](PurchaseApi.md#advancedpurchasecreditnotepurchaseidcombineadditionalchargesget) | **GET** /advanced-purchase/creditnote?PurchaseID&#x3D;{PurchaseID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}                                                                                                                                                                                                                                                                                                               | GET         |
| [**AdvancedPurchaseCreditnoteTaskidDelete**](PurchaseApi.md#advancedpurchasecreditnotetaskiddelete)                                                   | **DELETE** /advanced-purchase/creditnote?TaskID&#x3D;{TaskID}                                                                                                                                                                                                                                                                                                                                                                                 | DELETE      |
| [**AdvancedPurchaseIdCombineadditionalchargesGet**](PurchaseApi.md#advancedpurchaseidcombineadditionalchargesget)                                     | **GET** /advanced-purchase?ID&#x3D;{ID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}                                                                                                                                                                                                                                                                                                                                          | GET         |
| [**AdvancedPurchaseIdVoidDelete**](PurchaseApi.md#advancedpurchaseidvoiddelete)                                                                       | **DELETE** /advanced-purchase?ID&#x3D;{ID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                                               | DELETE      |
| [**AdvancedPurchaseInvoicePost**](PurchaseApi.md#advancedpurchaseinvoicepost)                                                                         | **POST** /advanced-purchase/invoice                                                                                                                                                                                                                                                                                                                                                                                                           | POST        |
| [**AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet**](PurchaseApi.md#advancedpurchaseinvoicepurchaseidcombineadditionalchargesget)       | **GET** /advanced-purchase/invoice?PurchaseID&#x3D;{PurchaseID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}                                                                                                                                                                                                                                                                                                                  | GET         |
| [**AdvancedPurchaseInvoiceTaskidVoidDelete**](PurchaseApi.md#advancedpurchaseinvoicetaskidvoiddelete)                                                 | **DELETE** /advanced-purchase/invoice?TaskID&#x3D;{TaskID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                               | DELETE      |
| [**AdvancedPurchaseManualjournalPost**](PurchaseApi.md#advancedpurchasemanualjournalpost)                                                             | **POST** /advanced-purchase/manualJournal                                                                                                                                                                                                                                                                                                                                                                                                     | POST        |
| [**AdvancedPurchaseManualjournalPurchaseidGet**](PurchaseApi.md#advancedpurchasemanualjournalpurchaseidget)                                           | **GET** /advanced-purchase/manualJournal?PurchaseID&#x3D;{PurchaseID}                                                                                                                                                                                                                                                                                                                                                                         | GET         |
| [**AdvancedPurchasePaymentPost**](PurchaseApi.md#advancedpurchasepaymentpost)                                                                         | **POST** /advanced-purchase/payment                                                                                                                                                                                                                                                                                                                                                                                                           | POST        |
| [**AdvancedPurchasePaymentPut**](PurchaseApi.md#advancedpurchasepaymentput)                                                                           | **PUT** /advanced-purchase/payment                                                                                                                                                                                                                                                                                                                                                                                                            | PUT         |
| [**AdvancedPurchasePost**](PurchaseApi.md#advancedpurchasepost)                                                                                       | **POST** /advanced-purchase                                                                                                                                                                                                                                                                                                                                                                                                                   | POST        |
| [**AdvancedPurchasePut**](PurchaseApi.md#advancedpurchaseput)                                                                                         | **PUT** /advanced-purchase                                                                                                                                                                                                                                                                                                                                                                                                                    | PUT         |
| [**AdvancedPurchaseStockPost**](PurchaseApi.md#advancedpurchasestockpost)                                                                             | **POST** /advanced-purchase/stock                                                                                                                                                                                                                                                                                                                                                                                                             | POST        |
| [**AdvancedPurchaseStockPurchaseidGet**](PurchaseApi.md#advancedpurchasestockpurchaseidget)                                                           | **GET** /advanced-purchase/stock?PurchaseID&#x3D;{PurchaseID}                                                                                                                                                                                                                                                                                                                                                                                 | GET         |
| [**AdvancedPurchaseStockPut**](PurchaseApi.md#advancedpurchasestockput)                                                                               | **PUT** /advanced-purchase/stock                                                                                                                                                                                                                                                                                                                                                                                                              | PUT         |
| [**AdvancedPurchaseStockTaskidVoidDelete**](PurchaseApi.md#advancedpurchasestocktaskidvoiddelete)                                                     | **DELETE** /advanced-purchase/stock?TaskID&#x3D;{TaskID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                                 | DELETE      |
| [**PgLmtSrchRequiredbyUpdatedsinceEtc**](PurchaseApi.md#pglmtsrchrequiredbyupdatedsinceetc)                                                           | **GET** /purchaseList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Search&#x3D;{Search}&amp;RequiredBy&#x3D;{RequiredBy}&amp;UpdatedSince&#x3D;{UpdatedSince}&amp;OrderStatus&#x3D;{OrderStatus}&amp;RestockReceivedStatus&#x3D;{RestockReceivedStatus}&amp;InvoiceStatus&#x3D;{InvoiceStatus}&amp;CreditNoteStatus&#x3D;{CreditNoteStatus}&amp;UnstockStatus&#x3D;{UnstockStatus}&amp;Status{Status}&amp;DropShipTaskID&#x3D;{DropShipTaskID} | GET         |
| [**PgLmtSrchUpdatedsinceCreditnotestatusEtc**](PurchaseApi.md#pglmtsrchupdatedsincecreditnotestatusetc)                                               | **GET** /purchaseCreditNoteList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Search&#x3D;{Search}&amp;UpdatedSince&#x3D;{UpdatedSince}&amp;CreditNoteStatus&#x3D;{CreditNoteStatus}&amp;Status{Status}                                                                                                                                                                                                                                         | GET         |
| [**PurchaseAttachmentIdDelete**](PurchaseApi.md#purchaseattachmentiddelete)                                                                           | **DELETE** /purchase/attachment?ID&#x3D;{ID}                                                                                                                                                                                                                                                                                                                                                                                                  | DELETE      |
| [**PurchaseAttachmentPost**](PurchaseApi.md#purchaseattachmentpost)                                                                                   | **POST** /purchase/attachment                                                                                                                                                                                                                                                                                                                                                                                                                 | POST        |
| [**PurchaseAttachmentTaskidGet**](PurchaseApi.md#purchaseattachmenttaskidget)                                                                         | **GET** /purchase/attachment?TaskID&#x3D;{TaskID}                                                                                                                                                                                                                                                                                                                                                                                             | GET         |
| [**PurchaseCreditnotePost**](PurchaseApi.md#purchasecreditnotepost)                                                                                   | **POST** /purchase/creditnote                                                                                                                                                                                                                                                                                                                                                                                                                 | POST        |
| [**PurchaseCreditnoteTaskidCombineadditionalchargesGet**](PurchaseApi.md#purchasecreditnotetaskidcombineadditionalchargesget)                         | **GET** /purchase/creditnote?TaskID&#x3D;{TaskID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}                                                                                                                                                                                                                                                                                                                                | GET         |
| [**PurchaseIdCombineadditionalchargesGet**](PurchaseApi.md#purchaseidcombineadditionalchargesget)                                                     | **GET** /purchase?ID&#x3D;{ID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}                                                                                                                                                                                                                                                                                                                                                   | GET         |
| [**PurchaseIdVoidDelete**](PurchaseApi.md#purchaseidvoiddelete)                                                                                       | **DELETE** /purchase?ID&#x3D;{ID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                                                        | DELETE      |
| [**PurchaseInvoicePost**](PurchaseApi.md#purchaseinvoicepost)                                                                                         | **POST** /purchase/invoice                                                                                                                                                                                                                                                                                                                                                                                                                    | POST        |
| [**PurchaseInvoiceTaskidCombineadditionalchargesGet**](PurchaseApi.md#purchaseinvoicetaskidcombineadditionalchargesget)                               | **GET** /purchase/invoice?TaskID&#x3D;{TaskID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}                                                                                                                                                                                                                                                                                                                                   | GET         |
| [**PurchaseManualjournalPost**](PurchaseApi.md#purchasemanualjournalpost)                                                                             | **POST** /purchase/manualJournal                                                                                                                                                                                                                                                                                                                                                                                                              | POST        |
| [**PurchaseManualjournalTaskidGet**](PurchaseApi.md#purchasemanualjournaltaskidget)                                                                   | **GET** /purchase/manualJournal?TaskID&#x3D;{TaskID}                                                                                                                                                                                                                                                                                                                                                                                          | GET         |
| [**PurchaseOrderPost**](PurchaseApi.md#purchaseorderpost)                                                                                             | **POST** /purchase/order                                                                                                                                                                                                                                                                                                                                                                                                                      | POST        |
| [**PurchaseOrderTaskidCombineadditionalchargesGet**](PurchaseApi.md#purchaseordertaskidcombineadditionalchargesget)                                   | **GET** /purchase/order?TaskID&#x3D;{TaskID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}                                                                                                                                                                                                                                                                                                                                     | GET         |
| [**PurchasePaymentIdallocationDelete**](PurchaseApi.md#purchasepaymentidallocationdelete)                                                             | **DELETE** /purchase/payment?ID&#x3D;{ID}&amp;DeleteAllocation&#x3D;{DeleteAllocation}                                                                                                                                                                                                                                                                                                                                                        | DELETE      |
| [**PurchasePaymentPost**](PurchaseApi.md#purchasepaymentpost)                                                                                         | **POST** /purchase/payment                                                                                                                                                                                                                                                                                                                                                                                                                    | POST        |
| [**PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc**](PurchaseApi.md#purchasepaymentpurchaseidordernumberinvoicenumberetc)                       | **GET** /advanced-purchase/payment?PurchaseID&#x3D;{PurchaseID}&amp;OrderNumber&#x3D;{OrderNumber}&amp;InvoiceNumber&#x3D;{InvoiceNumber}&amp;CreditNoteNumber&#x3D;{CreditNoteNumber}                                                                                                                                                                                                                                                        | GET         |
| [**PurchasePaymentPut**](PurchaseApi.md#purchasepaymentput)                                                                                           | **PUT** /purchase/payment                                                                                                                                                                                                                                                                                                                                                                                                                     | PUT         |
| [**PurchasePaymentTaskidGet**](PurchaseApi.md#purchasepaymenttaskidget)                                                                               | **GET** /purchase/payment?TaskID&#x3D;{TaskID}                                                                                                                                                                                                                                                                                                                                                                                                | GET         |
| [**PurchasePost**](PurchaseApi.md#purchasepost)                                                                                                       | **POST** /purchase                                                                                                                                                                                                                                                                                                                                                                                                                            | POST        |
| [**PurchasePut**](PurchaseApi.md#purchaseput)                                                                                                         | **PUT** /purchase                                                                                                                                                                                                                                                                                                                                                                                                                             | PUT         |
| [**PurchaseStockPost**](PurchaseApi.md#purchasestockpost)                                                                                             | **POST** /purchase/stock                                                                                                                                                                                                                                                                                                                                                                                                                      | POST        |
| [**PurchaseStockTaskidGet**](PurchaseApi.md#purchasestocktaskidget)                                                                                   | **GET** /purchase/stock?TaskID&#x3D;{TaskID}                                                                                                                                                                                                                                                                                                                                                                                                  | GET         |

<a id="advancedpurchaseawaypost"></a>

# **AdvancedPurchaseAwayPost**

> AdvancedPurchaseAwayPost200Response AdvancedPurchaseAwayPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = null)

POST

-   POST method will return exception if Order status is not - `AUTHORISED` + POST method will return exception if Put Away status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Purchase `Approach` = `INVOICE` and `InvoiceStatus` is not - `AUTHORISED` + POST method is used to add only new stock lines. + POST method will create new Stock Receiving Task, if value of `TaskID` is not provided or equals to `00000000-0000-0000-0000-000000000000`. + To Authorize Put Away, Request with empty lines in payload can be done. + If duplicated lines found in one payload, one line with sum quantity will be created. + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseAwayPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchaseAwayPostRequest = new AdvancedPurchaseAwayPostRequest?(); // AdvancedPurchaseAwayPostRequest? |  (optional)

            try
            {
                // POST
                AdvancedPurchaseAwayPost200Response result = apiInstance.AdvancedPurchaseAwayPost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseAwayPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseAwayPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseAwayPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<AdvancedPurchaseAwayPost200Response> response = apiInstance.AdvancedPurchaseAwayPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseAwayPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseAwayPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                | Type                                                                        | Description                               | Notes      |
| ----------------------------------- | --------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                | **string?**                                                                 | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**           | **string?**                                                                 | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchaseAwayPostRequest** | [**AdvancedPurchaseAwayPostRequest?**](AdvancedPurchaseAwayPostRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchaseAwayPost200Response**](AdvancedPurchaseAwayPost200Response.md)

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

<a id="advancedpurchaseawaypurchaseidget"></a>

# **AdvancedPurchaseAwayPurchaseidGet**

> AdvancedPurchaseAwayPost200Response AdvancedPurchaseAwayPurchaseidGet (string purchaseID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseAwayPurchaseidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var purchaseID = "purchaseID_example";  // string | Returns detailed info of a particular Purchase Order
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AdvancedPurchaseAwayPost200Response result = apiInstance.AdvancedPurchaseAwayPurchaseidGet(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseAwayPurchaseidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseAwayPurchaseidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AdvancedPurchaseAwayPost200Response> response = apiInstance.AdvancedPurchaseAwayPurchaseidGetWithHttpInfo(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseAwayPurchaseidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                          | Notes      |
| ------------------------- | ----------- | ---------------------------------------------------- | ---------- |
| **purchaseID**            | **string**  | Returns detailed info of a particular Purchase Order |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b            | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033            | [optional] |

### Return type

[**AdvancedPurchaseAwayPost200Response**](AdvancedPurchaseAwayPost200Response.md)

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

<a id="advancedpurchasecreditnotepost"></a>

# **AdvancedPurchaseCreditnotePost**

> AdvancedPurchaseCreditnotePost200Response AdvancedPurchaseCreditnotePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = null)

POST

-   POST method will return exception if Invoice status is not - `AUTHORISED` or `PAID` + POST method will return exception if Credit Note status is not - `DRAFT` or `NOT AVAILABLE`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseCreditnotePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchaseCreditnotePostRequest = new AdvancedPurchaseCreditnotePostRequest?(); // AdvancedPurchaseCreditnotePostRequest? |  (optional)

            try
            {
                // POST
                AdvancedPurchaseCreditnotePost200Response result = apiInstance.AdvancedPurchaseCreditnotePost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseCreditnotePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseCreditnotePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseCreditnotePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<AdvancedPurchaseCreditnotePost200Response> response = apiInstance.AdvancedPurchaseCreditnotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseCreditnotePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseCreditnotePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                      | Type                                                                                    | Description                               | Notes      |
| ----------------------------------------- | --------------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                      | **string?**                                                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**                 | **string?**                                                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchaseCreditnotePostRequest** | [**AdvancedPurchaseCreditnotePostRequest?**](AdvancedPurchaseCreditnotePostRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchaseCreditnotePost200Response**](AdvancedPurchaseCreditnotePost200Response.md)

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

<a id="advancedpurchasecreditnotepurchaseidcombineadditionalchargesget"></a>

# **AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet**

> AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet (string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var purchaseID = "purchaseID_example";  // string | Returns detailed info of a particular Purchase Credit Notes
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response result = apiInstance.AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response> response = apiInstance.AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfo(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **purchaseID**               | **string**  | Returns detailed info of a particular Purchase Credit Notes             |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response**](AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response.md)

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

<a id="advancedpurchasecreditnotetaskiddelete"></a>

# **AdvancedPurchaseCreditnoteTaskidDelete**

> AdvancedPurchaseCreditnoteTaskidDelete200Response AdvancedPurchaseCreditnoteTaskidDelete (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseCreditnoteTaskidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | ID of Credit Note Purchase to Void
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                AdvancedPurchaseCreditnoteTaskidDelete200Response result = apiInstance.AdvancedPurchaseCreditnoteTaskidDelete(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseCreditnoteTaskidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<AdvancedPurchaseCreditnoteTaskidDelete200Response> response = apiInstance.AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **taskID**                | **string**  | ID of Credit Note Purchase to Void        |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**AdvancedPurchaseCreditnoteTaskidDelete200Response**](AdvancedPurchaseCreditnoteTaskidDelete200Response.md)

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

<a id="advancedpurchaseidcombineadditionalchargesget"></a>

# **AdvancedPurchaseIdCombineadditionalchargesGet**

> AdvancedPurchaseIdCombineadditionalchargesGet200Response AdvancedPurchaseIdCombineadditionalchargesGet (string ID, bool combineAdditionalCharges, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseIdCombineadditionalchargesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var ID = "ID_example";  // string | Returns detailed info of a particular Purchase
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AdvancedPurchaseIdCombineadditionalchargesGet200Response result = apiInstance.AdvancedPurchaseIdCombineadditionalchargesGet(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseIdCombineadditionalchargesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AdvancedPurchaseIdCombineadditionalchargesGet200Response> response = apiInstance.AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfo(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **ID**                       | **string**  | Returns detailed info of a particular Purchase                          |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**AdvancedPurchaseIdCombineadditionalchargesGet200Response**](AdvancedPurchaseIdCombineadditionalchargesGet200Response.md)

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

<a id="advancedpurchaseidvoiddelete"></a>

# **AdvancedPurchaseIdVoidDelete**

> AdvancedPurchaseIdVoidDelete200Response AdvancedPurchaseIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var ID = "ID_example";  // string | ID of Purchase to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                AdvancedPurchaseIdVoidDelete200Response result = apiInstance.AdvancedPurchaseIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseIdVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<AdvancedPurchaseIdVoidDelete200Response> response = apiInstance.AdvancedPurchaseIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **ID**                    | **string**  | ID of Purchase to Void or Undo            |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**AdvancedPurchaseIdVoidDelete200Response**](AdvancedPurchaseIdVoidDelete200Response.md)

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

<a id="advancedpurchaseinvoicepost"></a>

# **AdvancedPurchaseInvoicePost**

> AdvancedPurchaseInvoicePost200Response AdvancedPurchaseInvoicePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = null)

POST

-   POST method will return exception if Order status is not - `AUTHORISED` + POST method will return exception if Invoice status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Purchase `Approach` = `STOCK` and `StockReceivedStatus` is not - `AUTHORISED`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseInvoicePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchaseInvoicePostRequest = new AdvancedPurchaseInvoicePostRequest?(); // AdvancedPurchaseInvoicePostRequest? |  (optional)

            try
            {
                // POST
                AdvancedPurchaseInvoicePost200Response result = apiInstance.AdvancedPurchaseInvoicePost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseInvoicePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseInvoicePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseInvoicePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<AdvancedPurchaseInvoicePost200Response> response = apiInstance.AdvancedPurchaseInvoicePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseInvoicePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseInvoicePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                   | Type                                                                              | Description                               | Notes      |
| -------------------------------------- | --------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                   | **string?**                                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**              | **string?**                                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchaseInvoicePostRequest** | [**AdvancedPurchaseInvoicePostRequest?**](AdvancedPurchaseInvoicePostRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchaseInvoicePost200Response**](AdvancedPurchaseInvoicePost200Response.md)

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

<a id="advancedpurchaseinvoicepurchaseidcombineadditionalchargesget"></a>

# **AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet**

> AdvancedPurchaseInvoicePost200Response AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet (string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var purchaseID = "purchaseID_example";  // string | Returns detailed info of a particular Purchase Order
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AdvancedPurchaseInvoicePost200Response result = apiInstance.AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AdvancedPurchaseInvoicePost200Response> response = apiInstance.AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfo(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **purchaseID**               | **string**  | Returns detailed info of a particular Purchase Order                    |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**AdvancedPurchaseInvoicePost200Response**](AdvancedPurchaseInvoicePost200Response.md)

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

<a id="advancedpurchaseinvoicetaskidvoiddelete"></a>

# **AdvancedPurchaseInvoiceTaskidVoidDelete**

> AdvancedPurchaseInvoiceTaskidVoidDelete200Response AdvancedPurchaseInvoiceTaskidVoidDelete (string taskID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   DELETE not available for Simple Purchases

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseInvoiceTaskidVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | ID of Invoice Purchase to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                AdvancedPurchaseInvoiceTaskidVoidDelete200Response result = apiInstance.AdvancedPurchaseInvoiceTaskidVoidDelete(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseInvoiceTaskidVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<AdvancedPurchaseInvoiceTaskidVoidDelete200Response> response = apiInstance.AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **taskID**                | **string**  | ID of Invoice Purchase to Void or Undo    |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**AdvancedPurchaseInvoiceTaskidVoidDelete200Response**](AdvancedPurchaseInvoiceTaskidVoidDelete200Response.md)

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

<a id="advancedpurchasemanualjournalpost"></a>

# **AdvancedPurchaseManualjournalPost**

> AdvancedPurchaseManualjournalPost200Response AdvancedPurchaseManualjournalPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = null)

POST

-   POST can be done even if manual journal status is `AUTHORISED` + Line items with IsSystem value = `true` cannot be modified or deleted.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseManualjournalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchaseManualjournalPostRequest = new AdvancedPurchaseManualjournalPostRequest?(); // AdvancedPurchaseManualjournalPostRequest? |  (optional)

            try
            {
                // POST
                AdvancedPurchaseManualjournalPost200Response result = apiInstance.AdvancedPurchaseManualjournalPost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseManualjournalPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseManualjournalPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseManualjournalPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<AdvancedPurchaseManualjournalPost200Response> response = apiInstance.AdvancedPurchaseManualjournalPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseManualjournalPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseManualjournalPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                         | Type                                                                                          | Description                               | Notes      |
| -------------------------------------------- | --------------------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                         | **string?**                                                                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**                    | **string?**                                                                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchaseManualjournalPostRequest** | [**AdvancedPurchaseManualjournalPostRequest?**](AdvancedPurchaseManualjournalPostRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchaseManualjournalPost200Response**](AdvancedPurchaseManualjournalPost200Response.md)

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

<a id="advancedpurchasemanualjournalpurchaseidget"></a>

# **AdvancedPurchaseManualjournalPurchaseidGet**

> AdvancedPurchaseManualjournalPurchaseidGet200Response AdvancedPurchaseManualjournalPurchaseidGet (string purchaseID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseManualjournalPurchaseidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var purchaseID = "purchaseID_example";  // string | Returns detailed info of a particular Purchase Manual Journals
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AdvancedPurchaseManualjournalPurchaseidGet200Response result = apiInstance.AdvancedPurchaseManualjournalPurchaseidGet(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseManualjournalPurchaseidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AdvancedPurchaseManualjournalPurchaseidGet200Response> response = apiInstance.AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfo(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                    | Notes      |
| ------------------------- | ----------- | -------------------------------------------------------------- | ---------- |
| **purchaseID**            | **string**  | Returns detailed info of a particular Purchase Manual Journals |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                      | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                      | [optional] |

### Return type

[**AdvancedPurchaseManualjournalPurchaseidGet200Response**](AdvancedPurchaseManualjournalPurchaseidGet200Response.md)

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

<a id="advancedpurchasepaymentpost"></a>

# **AdvancedPurchasePaymentPost**

> AdvancedPurchasePaymentPost200Response AdvancedPurchasePaymentPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = null)

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
    public class AdvancedPurchasePaymentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchasePaymentPostRequest = new AdvancedPurchasePaymentPostRequest?(); // AdvancedPurchasePaymentPostRequest? |  (optional)

            try
            {
                // POST
                AdvancedPurchasePaymentPost200Response result = apiInstance.AdvancedPurchasePaymentPost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePaymentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchasePaymentPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<AdvancedPurchasePaymentPost200Response> response = apiInstance.AdvancedPurchasePaymentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePaymentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                   | Type                                                                              | Description                               | Notes      |
| -------------------------------------- | --------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                   | **string?**                                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**              | **string?**                                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchasePaymentPostRequest** | [**AdvancedPurchasePaymentPostRequest?**](AdvancedPurchasePaymentPostRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchasePaymentPost200Response**](AdvancedPurchasePaymentPost200Response.md)

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

<a id="advancedpurchasepaymentput"></a>

# **AdvancedPurchasePaymentPut**

> AdvancedPurchasePaymentPut200Response AdvancedPurchasePaymentPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = null)

PUT

-   Please note, that Payment with type Prepayment cannot be modified.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchasePaymentPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchasePaymentPutRequest = new AdvancedPurchasePaymentPutRequest?(); // AdvancedPurchasePaymentPutRequest? |  (optional)

            try
            {
                // PUT
                AdvancedPurchasePaymentPut200Response result = apiInstance.AdvancedPurchasePaymentPut(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePaymentPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchasePaymentPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<AdvancedPurchasePaymentPut200Response> response = apiInstance.AdvancedPurchasePaymentPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePaymentPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                  | Type                                                                            | Description                               | Notes      |
| ------------------------------------- | ------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                  | **string?**                                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**             | **string?**                                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchasePaymentPutRequest** | [**AdvancedPurchasePaymentPutRequest?**](AdvancedPurchasePaymentPutRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchasePaymentPut200Response**](AdvancedPurchasePaymentPut200Response.md)

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

<a id="advancedpurchasepost"></a>

# **AdvancedPurchasePost**

> AdvancedPurchasePost200Response AdvancedPurchasePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchasePostRequest? advancedPurchasePostRequest = null)

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
    public class AdvancedPurchasePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchasePostRequest = new AdvancedPurchasePostRequest?(); // AdvancedPurchasePostRequest? |  (optional)

            try
            {
                // POST
                AdvancedPurchasePost200Response result = apiInstance.AdvancedPurchasePost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchasePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<AdvancedPurchasePost200Response> response = apiInstance.AdvancedPurchasePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                            | Type                                                                | Description                               | Notes      |
| ------------------------------- | ------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**            | **string?**                                                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**       | **string?**                                                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchasePostRequest** | [**AdvancedPurchasePostRequest?**](AdvancedPurchasePostRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchasePost200Response**](AdvancedPurchasePost200Response.md)

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

<a id="advancedpurchaseput"></a>

# **AdvancedPurchasePut**

> AdvancedPurchasePut200Response AdvancedPurchasePut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchasePutRequest? advancedPurchasePutRequest = null)

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
    public class AdvancedPurchasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchasePutRequest = new AdvancedPurchasePutRequest?(); // AdvancedPurchasePutRequest? |  (optional)

            try
            {
                // PUT
                AdvancedPurchasePut200Response result = apiInstance.AdvancedPurchasePut(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchasePutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<AdvancedPurchasePut200Response> response = apiInstance.AdvancedPurchasePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                           | Type                                                              | Description                               | Notes      |
| ------------------------------ | ----------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**           | **string?**                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**      | **string?**                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchasePutRequest** | [**AdvancedPurchasePutRequest?**](AdvancedPurchasePutRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchasePut200Response**](AdvancedPurchasePut200Response.md)

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

<a id="advancedpurchasestockpost"></a>

# **AdvancedPurchaseStockPost**

> AdvancedPurchaseStockPut200Response AdvancedPurchaseStockPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = null)

POST

-   POST method will return exception if Order status is not - `AUTHORISED` + POST method will return exception if Stock Received status is not - `DRAFT` or `NOT AVAILABLE` or `PARTIALLY RECEIVED` + POST method will return exception if Purchase `Approach` = `INVOICE` and `InvoiceStatus` is not - `AUTHORISED` + POST method is used to add only new stock lines. + POST method will create new Stock Receiving Task, if value of `TaskID` is not provided or equals to `00000000-0000-0000-0000-000000000000`. + To Authorize Stock Received, Request with empty lines in payload can be done. + If duplicated lines found in one payload, one line with sum quantity will be created. + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseStockPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchaseStockPutRequest = new AdvancedPurchaseStockPutRequest?(); // AdvancedPurchaseStockPutRequest? |  (optional)

            try
            {
                // POST
                AdvancedPurchaseStockPut200Response result = apiInstance.AdvancedPurchaseStockPost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseStockPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<AdvancedPurchaseStockPut200Response> response = apiInstance.AdvancedPurchaseStockPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                | Type                                                                        | Description                               | Notes      |
| ----------------------------------- | --------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                | **string?**                                                                 | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**           | **string?**                                                                 | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchaseStockPutRequest** | [**AdvancedPurchaseStockPutRequest?**](AdvancedPurchaseStockPutRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchaseStockPut200Response**](AdvancedPurchaseStockPut200Response.md)

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

<a id="advancedpurchasestockpurchaseidget"></a>

# **AdvancedPurchaseStockPurchaseidGet**

> AdvancedPurchaseStockPurchaseidGet200Response AdvancedPurchaseStockPurchaseidGet (string purchaseID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class AdvancedPurchaseStockPurchaseidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var purchaseID = "purchaseID_example";  // string | Returns detailed info of a particular Purchase Order
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                AdvancedPurchaseStockPurchaseidGet200Response result = apiInstance.AdvancedPurchaseStockPurchaseidGet(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockPurchaseidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseStockPurchaseidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<AdvancedPurchaseStockPurchaseidGet200Response> response = apiInstance.AdvancedPurchaseStockPurchaseidGetWithHttpInfo(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockPurchaseidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                          | Notes      |
| ------------------------- | ----------- | ---------------------------------------------------- | ---------- |
| **purchaseID**            | **string**  | Returns detailed info of a particular Purchase Order |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b            | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033            | [optional] |

### Return type

[**AdvancedPurchaseStockPurchaseidGet200Response**](AdvancedPurchaseStockPurchaseidGet200Response.md)

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

<a id="advancedpurchasestockput"></a>

# **AdvancedPurchaseStockPut**

> AdvancedPurchaseStockPut200Response AdvancedPurchaseStockPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = null)

PUT

-   PUT method will return exception if Order status is not - `AUTHORISED` + PUT method will return exception if Stock Received status is not - `DRAFT` or `NOT AVAILABLE` or `PARTIALLY RECEIVED` + PUT method will return exception if Purchase `Approach` = `INVOICE` and `InvoiceStatus` is not - `AUTHORISED` + PUT method will overwrite data in the related Purchase Task. + If duplicated lines found in one payload, one line with sum quantity will be created. + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseStockPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchaseStockPutRequest = new AdvancedPurchaseStockPutRequest?(); // AdvancedPurchaseStockPutRequest? |  (optional)

            try
            {
                // PUT
                AdvancedPurchaseStockPut200Response result = apiInstance.AdvancedPurchaseStockPut(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseStockPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<AdvancedPurchaseStockPut200Response> response = apiInstance.AdvancedPurchaseStockPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                | Type                                                                        | Description                               | Notes      |
| ----------------------------------- | --------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                | **string?**                                                                 | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**           | **string?**                                                                 | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchaseStockPutRequest** | [**AdvancedPurchaseStockPutRequest?**](AdvancedPurchaseStockPutRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchaseStockPut200Response**](AdvancedPurchaseStockPut200Response.md)

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

<a id="advancedpurchasestocktaskidvoiddelete"></a>

# **AdvancedPurchaseStockTaskidVoidDelete**

> AdvancedPurchaseStockTaskidVoidDelete200Response AdvancedPurchaseStockTaskidVoidDelete (string taskID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   DELETE not available for Simple Purchases

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AdvancedPurchaseStockTaskidVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | ID of Stock Receiving Purchase to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                AdvancedPurchaseStockTaskidVoidDelete200Response result = apiInstance.AdvancedPurchaseStockTaskidVoidDelete(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockTaskidVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<AdvancedPurchaseStockTaskidVoidDelete200Response> response = apiInstance.AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                    | Notes              |
| ------------------------- | ----------- | ---------------------------------------------- | ------------------ |
| **taskID**                | **string**  | ID of Stock Receiving Purchase to Void or Undo |                    |
| **varVoid**               | **bool**    |                                                | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b      | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033      | [optional]         |

### Return type

[**AdvancedPurchaseStockTaskidVoidDelete200Response**](AdvancedPurchaseStockTaskidVoidDelete200Response.md)

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

<a id="pglmtsrchrequiredbyupdatedsinceetc"></a>

# **PgLmtSrchRequiredbyUpdatedsinceEtc**

> PgLmtSrchRequiredbyUpdatedsinceEtc200Response PgLmtSrchRequiredbyUpdatedsinceEtc (decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PgLmtSrchRequiredbyUpdatedsinceEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var search = "search_example";  // string | Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber
            var requiredBy = "requiredBy_example";  // string | Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.
            var updatedSince = "updatedSince_example";  // string | Only return purchase changed after specified date. Date must follow  ISO 8601 format.
            var orderStatus = "orderStatus_example";  // string | Only return purchase orders with specified order status
            var restockReceivedStatus = "restockReceivedStatus_example";  // string | Only return purchase orders with specified stock received (put away) status
            var invoiceStatus = "invoiceStatus_example";  // string | Only return purchase orders with specified invoice status
            var creditNoteStatus = "creditNoteStatus_example";  // string | Only return purchase orders with specified credit note status
            var unstockStatus = "unstockStatus_example";  // string | Only return purchase orders with specified unstock status
            var status = "status_example";  // string | Only return purchase orders with specified purchase status
            var dropShipTaskID = "dropShipTaskID_example";  // string | Only return drop ship purchase which was created by specified sale task ID
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PgLmtSrchRequiredbyUpdatedsinceEtc200Response result = apiInstance.PgLmtSrchRequiredbyUpdatedsinceEtc(page, limit, search, requiredBy, updatedSince, orderStatus, restockReceivedStatus, invoiceStatus, creditNoteStatus, unstockStatus, status, dropShipTaskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PgLmtSrchRequiredbyUpdatedsinceEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PgLmtSrchRequiredbyUpdatedsinceEtc200Response> response = apiInstance.PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfo(page, limit, search, requiredBy, updatedSince, orderStatus, restockReceivedStatus, invoiceStatus, creditNoteStatus, unstockStatus, status, dropShipTaskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                                                                                    | Notes             |
| ------------------------- | ----------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                                                                                                                | [default to 1M]   |
| **limit**                 | **decimal** |                                                                                                                                                | [default to 100M] |
| **search**                | **string**  | Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber |                   |
| **requiredBy**            | **string**  | Only return purchase orders with Required By date on or before specified date. Date must follow ISO 8601 format.                               |                   |
| **updatedSince**          | **string**  | Only return purchase changed after specified date. Date must follow ISO 8601 format.                                                           |                   |
| **orderStatus**           | **string**  | Only return purchase orders with specified order status                                                                                        |                   |
| **restockReceivedStatus** | **string**  | Only return purchase orders with specified stock received (put away) status                                                                    |                   |
| **invoiceStatus**         | **string**  | Only return purchase orders with specified invoice status                                                                                      |                   |
| **creditNoteStatus**      | **string**  | Only return purchase orders with specified credit note status                                                                                  |                   |
| **unstockStatus**         | **string**  | Only return purchase orders with specified unstock status                                                                                      |                   |
| **status**                | **string**  | Only return purchase orders with specified purchase status                                                                                     |                   |
| **dropShipTaskID**        | **string**  | Only return drop ship purchase which was created by specified sale task ID                                                                     |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                                                      | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                                                      | [optional]        |

### Return type

[**PgLmtSrchRequiredbyUpdatedsinceEtc200Response**](PgLmtSrchRequiredbyUpdatedsinceEtc200Response.md)

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

<a id="pglmtsrchupdatedsincecreditnotestatusetc"></a>

# **PgLmtSrchUpdatedsinceCreditnotestatusEtc**

> PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response PgLmtSrchUpdatedsinceCreditnotestatusEtc (decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PgLmtSrchUpdatedsinceCreditnotestatusEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var search = "search_example";  // string | Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber
            var updatedSince = "updatedSince_example";  // string | Only return purchase changed after specified date. Date must follow  ISO 8601 format.
            var creditNoteStatus = "creditNoteStatus_example";  // string | Only return purchase orders with specified credit note status
            var status = "status_example";  // string | Only return purchase orders with specified purchase status
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response result = apiInstance.PgLmtSrchUpdatedsinceCreditnotestatusEtc(page, limit, search, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PgLmtSrchUpdatedsinceCreditnotestatusEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response> response = apiInstance.PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfo(page, limit, search, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                                                                                    | Notes             |
| ------------------------- | ----------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                                                                                                                | [default to 1M]   |
| **limit**                 | **decimal** |                                                                                                                                                | [default to 100M] |
| **search**                | **string**  | Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber |                   |
| **updatedSince**          | **string**  | Only return purchase changed after specified date. Date must follow ISO 8601 format.                                                           |                   |
| **creditNoteStatus**      | **string**  | Only return purchase orders with specified credit note status                                                                                  |                   |
| **status**                | **string**  | Only return purchase orders with specified purchase status                                                                                     |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                                                      | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                                                      | [optional]        |

### Return type

[**PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response**](PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response.md)

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

<a id="purchaseattachmentiddelete"></a>

# **PurchaseAttachmentIdDelete**

> PurchaseAttachmentPost200Response PurchaseAttachmentIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseAttachmentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var ID = "ID_example";  // string | ID of Purchase Attachment to delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                PurchaseAttachmentPost200Response result = apiInstance.PurchaseAttachmentIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseAttachmentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseAttachmentIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<PurchaseAttachmentPost200Response> response = apiInstance.PurchaseAttachmentIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseAttachmentIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Purchase Attachment to delete       |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**PurchaseAttachmentPost200Response**](PurchaseAttachmentPost200Response.md)

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

<a id="purchaseattachmentpost"></a>

# **PurchaseAttachmentPost**

> PurchaseAttachmentPost200Response PurchaseAttachmentPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseAttachmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                PurchaseAttachmentPost200Response result = apiInstance.PurchaseAttachmentPost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseAttachmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseAttachmentPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchaseAttachmentPost200Response> response = apiInstance.PurchaseAttachmentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseAttachmentPostWithHttpInfo: " + e.Message);
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

[**PurchaseAttachmentPost200Response**](PurchaseAttachmentPost200Response.md)

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

<a id="purchaseattachmenttaskidget"></a>

# **PurchaseAttachmentTaskidGet**

> PurchaseAttachmentPost200Response PurchaseAttachmentTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseAttachmentTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | Returns Payment info of a particular purchase
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PurchaseAttachmentPost200Response result = apiInstance.PurchaseAttachmentTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseAttachmentTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseAttachmentTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PurchaseAttachmentPost200Response> response = apiInstance.PurchaseAttachmentTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseAttachmentTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                   | Notes      |
| ------------------------- | ----------- | --------------------------------------------- | ---------- |
| **taskID**                | **string**  | Returns Payment info of a particular purchase |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b     | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033     | [optional] |

### Return type

[**PurchaseAttachmentPost200Response**](PurchaseAttachmentPost200Response.md)

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

<a id="purchasecreditnotepost"></a>

# **PurchaseCreditnotePost**

> PurchaseCreditnotePost200Response PurchaseCreditnotePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = null)

POST

-   POST method will return exception if Invoice status is not - `AUTHORISED` or `PAID` + POST method will return exception if Credit Note status is not - `DRAFT` or `NOT AVAILABLE`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PurchaseCreditnotePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var purchaseCreditnotePostRequest = new PurchaseCreditnotePostRequest?(); // PurchaseCreditnotePostRequest? |  (optional)

            try
            {
                // POST
                PurchaseCreditnotePost200Response result = apiInstance.PurchaseCreditnotePost(apiAuthAccountid, apiAuthApplicationkey, purchaseCreditnotePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseCreditnotePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseCreditnotePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchaseCreditnotePost200Response> response = apiInstance.PurchaseCreditnotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseCreditnotePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseCreditnotePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                              | Type                                                                    | Description                               | Notes      |
| --------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**              | **string?**                                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**         | **string?**                                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **purchaseCreditnotePostRequest** | [**PurchaseCreditnotePostRequest?**](PurchaseCreditnotePostRequest?.md) |                                           | [optional] |

### Return type

[**PurchaseCreditnotePost200Response**](PurchaseCreditnotePost200Response.md)

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

<a id="purchasecreditnotetaskidcombineadditionalchargesget"></a>

# **PurchaseCreditnoteTaskidCombineadditionalchargesGet**

> PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response PurchaseCreditnoteTaskidCombineadditionalchargesGet (string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseCreditnoteTaskidCombineadditionalchargesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Purchase Credit Note
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response result = apiInstance.PurchaseCreditnoteTaskidCombineadditionalchargesGet(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseCreditnoteTaskidCombineadditionalchargesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response> response = apiInstance.PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfo(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **taskID**                   | **string**  | Returns detailed info of a particular Purchase Credit Note              |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response**](PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response.md)

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

<a id="purchaseidcombineadditionalchargesget"></a>

# **PurchaseIdCombineadditionalchargesGet**

> PurchaseIdCombineadditionalchargesGet200Response PurchaseIdCombineadditionalchargesGet (string ID, bool combineAdditionalCharges, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseIdCombineadditionalchargesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var ID = "ID_example";  // string | Returns detailed info of a particular Purchase
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PurchaseIdCombineadditionalchargesGet200Response result = apiInstance.PurchaseIdCombineadditionalchargesGet(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseIdCombineadditionalchargesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseIdCombineadditionalchargesGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PurchaseIdCombineadditionalchargesGet200Response> response = apiInstance.PurchaseIdCombineadditionalchargesGetWithHttpInfo(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseIdCombineadditionalchargesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **ID**                       | **string**  | Returns detailed info of a particular Purchase                          |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**PurchaseIdCombineadditionalchargesGet200Response**](PurchaseIdCombineadditionalchargesGet200Response.md)

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

<a id="purchaseidvoiddelete"></a>

# **PurchaseIdVoidDelete**

> PurchaseIdVoidDelete200Response PurchaseIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var ID = "ID_example";  // string | ID of Purchase to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                PurchaseIdVoidDelete200Response result = apiInstance.PurchaseIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseIdVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<PurchaseIdVoidDelete200Response> response = apiInstance.PurchaseIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **ID**                    | **string**  | ID of Purchase to Void or Undo            |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**PurchaseIdVoidDelete200Response**](PurchaseIdVoidDelete200Response.md)

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

<a id="purchaseinvoicepost"></a>

# **PurchaseInvoicePost**

> PurchaseInvoicePost200Response PurchaseInvoicePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = null)

POST

-   POST method will return exception if Order status is not - `AUTHORISED` + POST method will return exception if Invoice status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Purchase `Approach` = `STOCK` and `StockReceivedStatus` is not - `AUTHORISED`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PurchaseInvoicePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var purchaseInvoicePostRequest = new PurchaseInvoicePostRequest?(); // PurchaseInvoicePostRequest? |  (optional)

            try
            {
                // POST
                PurchaseInvoicePost200Response result = apiInstance.PurchaseInvoicePost(apiAuthAccountid, apiAuthApplicationkey, purchaseInvoicePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseInvoicePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseInvoicePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchaseInvoicePost200Response> response = apiInstance.PurchaseInvoicePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseInvoicePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseInvoicePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                           | Type                                                              | Description                               | Notes      |
| ------------------------------ | ----------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**           | **string?**                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**      | **string?**                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **purchaseInvoicePostRequest** | [**PurchaseInvoicePostRequest?**](PurchaseInvoicePostRequest?.md) |                                           | [optional] |

### Return type

[**PurchaseInvoicePost200Response**](PurchaseInvoicePost200Response.md)

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

<a id="purchaseinvoicetaskidcombineadditionalchargesget"></a>

# **PurchaseInvoiceTaskidCombineadditionalchargesGet**

> PurchaseInvoiceTaskidCombineadditionalchargesGet200Response PurchaseInvoiceTaskidCombineadditionalchargesGet (string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseInvoiceTaskidCombineadditionalchargesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Purchase Order
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PurchaseInvoiceTaskidCombineadditionalchargesGet200Response result = apiInstance.PurchaseInvoiceTaskidCombineadditionalchargesGet(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseInvoiceTaskidCombineadditionalchargesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response> response = apiInstance.PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfo(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **taskID**                   | **string**  | Returns detailed info of a particular Purchase Order                    |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**PurchaseInvoiceTaskidCombineadditionalchargesGet200Response**](PurchaseInvoiceTaskidCombineadditionalchargesGet200Response.md)

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

<a id="purchasemanualjournalpost"></a>

# **PurchaseManualjournalPost**

> PurchaseManualjournalPost200Response PurchaseManualjournalPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = null)

POST

-   POST can be done even if manual journal status is `AUTHORISED` + Line items with IsSystem value = `true` cannot be modified or deleted.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PurchaseManualjournalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var purchaseManualjournalPostRequest = new PurchaseManualjournalPostRequest?(); // PurchaseManualjournalPostRequest? |  (optional)

            try
            {
                // POST
                PurchaseManualjournalPost200Response result = apiInstance.PurchaseManualjournalPost(apiAuthAccountid, apiAuthApplicationkey, purchaseManualjournalPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseManualjournalPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseManualjournalPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchaseManualjournalPost200Response> response = apiInstance.PurchaseManualjournalPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseManualjournalPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseManualjournalPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                 | Type                                                                          | Description                               | Notes      |
| ------------------------------------ | ----------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                 | **string?**                                                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**            | **string?**                                                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **purchaseManualjournalPostRequest** | [**PurchaseManualjournalPostRequest?**](PurchaseManualjournalPostRequest?.md) |                                           | [optional] |

### Return type

[**PurchaseManualjournalPost200Response**](PurchaseManualjournalPost200Response.md)

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

<a id="purchasemanualjournaltaskidget"></a>

# **PurchaseManualjournalTaskidGet**

> PurchaseManualjournalTaskidGet200Response PurchaseManualjournalTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseManualjournalTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Purchase Manual Journals
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PurchaseManualjournalTaskidGet200Response result = apiInstance.PurchaseManualjournalTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseManualjournalTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseManualjournalTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PurchaseManualjournalTaskidGet200Response> response = apiInstance.PurchaseManualjournalTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseManualjournalTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                    | Notes      |
| ------------------------- | ----------- | -------------------------------------------------------------- | ---------- |
| **taskID**                | **string**  | Returns detailed info of a particular Purchase Manual Journals |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                      | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                      | [optional] |

### Return type

[**PurchaseManualjournalTaskidGet200Response**](PurchaseManualjournalTaskidGet200Response.md)

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

<a id="purchaseorderpost"></a>

# **PurchaseOrderPost**

> PurchaseOrderPost200Response PurchaseOrderPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PurchaseOrderPostRequest? purchaseOrderPostRequest = null)

POST

-   POST method will return exception if Order status is not - `DRAFT` or `NOT AVAILABLE`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PurchaseOrderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var purchaseOrderPostRequest = new PurchaseOrderPostRequest?(); // PurchaseOrderPostRequest? |  (optional)

            try
            {
                // POST
                PurchaseOrderPost200Response result = apiInstance.PurchaseOrderPost(apiAuthAccountid, apiAuthApplicationkey, purchaseOrderPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseOrderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseOrderPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchaseOrderPost200Response> response = apiInstance.PurchaseOrderPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseOrderPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseOrderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type                                                          | Description                               | Notes      |
| ---------------------------- | ------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**         | **string?**                                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**    | **string?**                                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **purchaseOrderPostRequest** | [**PurchaseOrderPostRequest?**](PurchaseOrderPostRequest?.md) |                                           | [optional] |

### Return type

[**PurchaseOrderPost200Response**](PurchaseOrderPost200Response.md)

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

<a id="purchaseordertaskidcombineadditionalchargesget"></a>

# **PurchaseOrderTaskidCombineadditionalchargesGet**

> PurchaseOrderTaskidCombineadditionalchargesGet200Response PurchaseOrderTaskidCombineadditionalchargesGet (string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseOrderTaskidCombineadditionalchargesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Purchase Order
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PurchaseOrderTaskidCombineadditionalchargesGet200Response result = apiInstance.PurchaseOrderTaskidCombineadditionalchargesGet(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseOrderTaskidCombineadditionalchargesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PurchaseOrderTaskidCombineadditionalchargesGet200Response> response = apiInstance.PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfo(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **taskID**                   | **string**  | Returns detailed info of a particular Purchase Order                    |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**PurchaseOrderTaskidCombineadditionalchargesGet200Response**](PurchaseOrderTaskidCombineadditionalchargesGet200Response.md)

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

<a id="purchasepaymentidallocationdelete"></a>

# **PurchasePaymentIdallocationDelete**

> MeAddressesIdDelete200Response PurchasePaymentIdallocationDelete (string ID, bool deleteAllocation, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchasePaymentIdallocationDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var ID = "ID_example";  // string | ID of Payment to Delete
            var deleteAllocation = true;  // bool | Delete allocated payments (Default = true)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.PurchasePaymentIdallocationDelete(ID, deleteAllocation, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchasePaymentIdallocationDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchasePaymentIdallocationDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.PurchasePaymentIdallocationDeleteWithHttpInfo(ID, deleteAllocation, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchasePaymentIdallocationDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                     | Notes      |
| ------------------------- | ----------- | ----------------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Payment to Delete                         |            |
| **deleteAllocation**      | **bool**    | Delete allocated payments (Default &#x3D; true) |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b       | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033       | [optional] |

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

<a id="purchasepaymentpost"></a>

# **PurchasePaymentPost**

> PurchasePaymentPost200Response PurchasePaymentPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = null)

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
    public class PurchasePaymentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchasePaymentPostRequest = new AdvancedPurchasePaymentPostRequest?(); // AdvancedPurchasePaymentPostRequest? |  (optional)

            try
            {
                // POST
                PurchasePaymentPost200Response result = apiInstance.PurchasePaymentPost(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchasePaymentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchasePaymentPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchasePaymentPost200Response> response = apiInstance.PurchasePaymentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchasePaymentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                   | Type                                                                              | Description                               | Notes      |
| -------------------------------------- | --------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                   | **string?**                                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**              | **string?**                                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchasePaymentPostRequest** | [**AdvancedPurchasePaymentPostRequest?**](AdvancedPurchasePaymentPostRequest?.md) |                                           | [optional] |

### Return type

[**PurchasePaymentPost200Response**](PurchasePaymentPost200Response.md)

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

<a id="purchasepaymentpurchaseidordernumberinvoicenumberetc"></a>

# **PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc**

> List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt; PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc (string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var purchaseID = "purchaseID_example";  // string | Returns detailed info of a particular Purchase Payments
            var orderNumber = "orderNumber_example";  // string | Returns detailed info of a particular Purchase Payments with Purchase Order Number
            var invoiceNumber = "invoiceNumber_example";  // string | Returns detailed info of a particular Purchase Payments with Invoice Number
            var creditNoteNumber = "creditNoteNumber_example";  // string | Returns detailed info of a particular Purchase Payments with Credit Note Number
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner> result = apiInstance.PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc(purchaseID, orderNumber, invoiceNumber, creditNoteNumber, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>> response = apiInstance.PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfo(purchaseID, orderNumber, invoiceNumber, creditNoteNumber, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                        | Notes      |
| ------------------------- | ----------- | ---------------------------------------------------------------------------------- | ---------- |
| **purchaseID**            | **string**  | Returns detailed info of a particular Purchase Payments                            |            |
| **orderNumber**           | **string**  | Returns detailed info of a particular Purchase Payments with Purchase Order Number |            |
| **invoiceNumber**         | **string**  | Returns detailed info of a particular Purchase Payments with Invoice Number        |            |
| **creditNoteNumber**      | **string**  | Returns detailed info of a particular Purchase Payments with Credit Note Number    |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                          | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                          | [optional] |

### Return type

[**List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;**](PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner.md)

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

<a id="purchasepaymentput"></a>

# **PurchasePaymentPut**

> AdvancedPurchasePaymentPutRequest PurchasePaymentPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = null)

PUT

-   Please note, that Payment with type Prepayment cannot be modified.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PurchasePaymentPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var advancedPurchasePaymentPutRequest = new AdvancedPurchasePaymentPutRequest?(); // AdvancedPurchasePaymentPutRequest? |  (optional)

            try
            {
                // PUT
                AdvancedPurchasePaymentPutRequest result = apiInstance.PurchasePaymentPut(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchasePaymentPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchasePaymentPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<AdvancedPurchasePaymentPutRequest> response = apiInstance.PurchasePaymentPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchasePaymentPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                  | Type                                                                            | Description                               | Notes      |
| ------------------------------------- | ------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                  | **string?**                                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**             | **string?**                                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **advancedPurchasePaymentPutRequest** | [**AdvancedPurchasePaymentPutRequest?**](AdvancedPurchasePaymentPutRequest?.md) |                                           | [optional] |

### Return type

[**AdvancedPurchasePaymentPutRequest**](AdvancedPurchasePaymentPutRequest.md)

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

<a id="purchasepaymenttaskidget"></a>

# **PurchasePaymentTaskidGet**

> List&lt;PurchasePaymentTaskidGet200ResponseInner&gt; PurchasePaymentTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchasePaymentTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Purchase Payments
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                List<PurchasePaymentTaskidGet200ResponseInner> result = apiInstance.PurchasePaymentTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchasePaymentTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchasePaymentTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<List<PurchasePaymentTaskidGet200ResponseInner>> response = apiInstance.PurchasePaymentTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchasePaymentTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                             | Notes      |
| ------------------------- | ----------- | ------------------------------------------------------- | ---------- |
| **taskID**                | **string**  | Returns detailed info of a particular Purchase Payments |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b               | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033               | [optional] |

### Return type

[**List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;**](PurchasePaymentTaskidGet200ResponseInner.md)

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

<a id="purchasepost"></a>

# **PurchasePost**

> PurchasePost200Response PurchasePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PurchasePostRequest? purchasePostRequest = null)

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
    public class PurchasePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var purchasePostRequest = new PurchasePostRequest?(); // PurchasePostRequest? |  (optional)

            try
            {
                // POST
                PurchasePost200Response result = apiInstance.PurchasePost(apiAuthAccountid, apiAuthApplicationkey, purchasePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchasePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchasePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchasePost200Response> response = apiInstance.PurchasePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchasePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchasePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                | Description                               | Notes      |
| ------------------------- | --------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **purchasePostRequest**   | [**PurchasePostRequest?**](PurchasePostRequest?.md) |                                           | [optional] |

### Return type

[**PurchasePost200Response**](PurchasePost200Response.md)

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

<a id="purchaseput"></a>

# **PurchasePut**

> PurchasePut200Response PurchasePut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PurchasePutRequest? purchasePutRequest = null)

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
    public class PurchasePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var purchasePutRequest = new PurchasePutRequest?(); // PurchasePutRequest? |  (optional)

            try
            {
                // PUT
                PurchasePut200Response result = apiInstance.PurchasePut(apiAuthAccountid, apiAuthApplicationkey, purchasePutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchasePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchasePutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<PurchasePut200Response> response = apiInstance.PurchasePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchasePutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchasePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                              | Description                               | Notes      |
| ------------------------- | ------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **purchasePutRequest**    | [**PurchasePutRequest?**](PurchasePutRequest?.md) |                                           | [optional] |

### Return type

[**PurchasePut200Response**](PurchasePut200Response.md)

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

<a id="purchasestockpost"></a>

# **PurchaseStockPost**

> PurchaseStockPost200Response PurchaseStockPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PurchaseStockPostRequest? purchaseStockPostRequest = null)

POST

-   POST method will return exception if Order status is not - `AUTHORISED` + POST method will return exception if Stock Received status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Purchase `Approach` = `INVOICE` and `InvoiceStatus` is not - `AUTHORISED` + POST method is used to add only new stock lines. + To Authorize Stock Received, Request with empty lines in payload can be done. + If duplicated lines found in one payload, one line with sum quantity will be created. + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PurchaseStockPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var purchaseStockPostRequest = new PurchaseStockPostRequest?(); // PurchaseStockPostRequest? |  (optional)

            try
            {
                // POST
                PurchaseStockPost200Response result = apiInstance.PurchaseStockPost(apiAuthAccountid, apiAuthApplicationkey, purchaseStockPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseStockPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseStockPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<PurchaseStockPost200Response> response = apiInstance.PurchaseStockPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseStockPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseStockPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type                                                          | Description                               | Notes      |
| ---------------------------- | ------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**         | **string?**                                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**    | **string?**                                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **purchaseStockPostRequest** | [**PurchaseStockPostRequest?**](PurchaseStockPostRequest?.md) |                                           | [optional] |

### Return type

[**PurchaseStockPost200Response**](PurchaseStockPost200Response.md)

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

<a id="purchasestocktaskidget"></a>

# **PurchaseStockTaskidGet**

> PurchaseStockPostRequest PurchaseStockTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PurchaseStockTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new PurchaseApi(config);
            var taskID = "taskID_example";  // string | Returns detailed info of a particular Purchase Order
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PurchaseStockPostRequest result = apiInstance.PurchaseStockTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchaseApi.PurchaseStockTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseStockTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PurchaseStockPostRequest> response = apiInstance.PurchaseStockTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchaseApi.PurchaseStockTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                          | Notes      |
| ------------------------- | ----------- | ---------------------------------------------------- | ---------- |
| **taskID**                | **string**  | Returns detailed info of a particular Purchase Order |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b            | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033            | [optional] |

### Return type

[**PurchaseStockPostRequest**](PurchaseStockPostRequest.md)

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
