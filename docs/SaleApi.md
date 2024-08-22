# CIN7.DearInventory.Api.SaleApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                                                                                                                            | HTTP request                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | Description |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [**PgLmtSrchCreatedsinceUpdatedsinceEtc**](SaleApi.md#pglmtsrchcreatedsinceupdatedsinceetc)                                                                                                       | **GET** /saleCreditNoteList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Search&#x3D;{Search}&amp;CreatedSince&#x3D;{CreatedSince}&amp;UpdatedSince&#x3D;{UpdatedSince}&amp;CreditNoteStatus&#x3D;{CreditNoteStatus}&amp;Status&#x3D;{Status}                                                                                                                                                                                                                                                                                                                                                                                                                                 | GET         |
| [**PgLmtSrchCreatedsinceUpdatedsinceEtc1**](SaleApi.md#pglmtsrchcreatedsinceupdatedsinceetc1)                                                                                                     | **GET** /saleList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Search&#x3D;{Search}&amp;CreatedSince&#x3D;{CreatedSince}&amp;UpdatedSince&#x3D;{UpdatedSince}&amp;ShipBy&#x3D;{ShipBy}&amp;QuoteStatus&#x3D;{QuoteStatus}&amp;OrderStatus&#x3D;{OrderStatus}&amp;CombinedPickStatus&#x3D;{CombinedPickStatus}&amp;CombinedPackStatus&#x3D;{CombinedPackStatus}&amp;CombinedShippingStatus&#x3D;{CombinedShippingStatus}&amp;CombinedInvoiceStatus&#x3D;{CombinedInvoiceStatus}&amp;CreditNoteStatus&#x3D;{CreditNoteStatus}&amp;ExternalID&#x3D;{ExternalID}&amp;Status&#x3D;{Status}&amp;ReadyForShipping&#x3D;{ReadyForShipping}&amp;OrderLocationID&#x3D;{OrderLocationID} | GET         |
| [**SaleAttachmentIdDelete**](SaleApi.md#saleattachmentiddelete)                                                                                                                                   | **DELETE** /sale/attachment?ID&#x3D;{ID}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | DELETE      |
| [**SaleAttachmentPost**](SaleApi.md#saleattachmentpost)                                                                                                                                           | **POST** /sale/attachment                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | POST        |
| [**SaleAttachmentSaleidGet**](SaleApi.md#saleattachmentsaleidget)                                                                                                                                 | **GET** /sale/attachment?SaleID&#x3D;{SaleID}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | GET         |
| [**SaleCreditnotePost**](SaleApi.md#salecreditnotepost)                                                                                                                                           | **POST** /sale/creditnote                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | POST        |
| [**SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet**](SaleApi.md#salecreditnotesaleidcombineadditionalchargesincludeproductinfoincludepaymentinfoget)         | **GET** /sale/creditnote?SaleID&#x3D;{SaleID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}&amp;IncludeProductInfo&#x3D;{IncludeProductInfo}&amp;IncludePaymentInfo&#x3D;{IncludePaymentInfo}                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | GET         |
| [**SaleCreditnoteTaskidVoidDelete**](SaleApi.md#salecreditnotetaskidvoiddelete)                                                                                                                   | **DELETE** /sale/creditnote?TaskID&#x3D;{TaskID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | DELETE      |
| [**SaleFulfilmentPackPost**](SaleApi.md#salefulfilmentpackpost)                                                                                                                                   | **POST** /sale/fulfilment/pack                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | POST        |
| [**SaleFulfilmentPackPut**](SaleApi.md#salefulfilmentpackput)                                                                                                                                     | **PUT** /sale/fulfilment/pack                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | PUT         |
| [**SaleFulfilmentPackTaskidIncludeproductinfoGet**](SaleApi.md#salefulfilmentpacktaskidincludeproductinfoget)                                                                                     | **GET** /sale/fulfilment/pack?TaskID&#x3D;{TaskID}&amp;IncludeProductInfo&#x3D;{IncludeProductInfo}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | GET         |
| [**SaleFulfilmentPickPost**](SaleApi.md#salefulfilmentpickpost)                                                                                                                                   | **POST** /sale/fulfilment/pick                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | POST        |
| [**SaleFulfilmentPickPut**](SaleApi.md#salefulfilmentpickput)                                                                                                                                     | **PUT** /sale/fulfilment/pick                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | PUT         |
| [**SaleFulfilmentPickTaskidIncludeproductinfoGet**](SaleApi.md#salefulfilmentpicktaskidincludeproductinfoget)                                                                                     | **GET** /sale/fulfilment/pick?TaskID&#x3D;{TaskID}&amp;IncludeProductInfo&#x3D;{IncludeProductInfo}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          | GET         |
| [**SaleFulfilmentPost**](SaleApi.md#salefulfilmentpost)                                                                                                                                           | **POST** /sale/fulfilment                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | POST        |
| [**SaleFulfilmentSaleidIncludeproductinfoGet**](SaleApi.md#salefulfilmentsaleidincludeproductinfoget)                                                                                             | **GET** /sale/fulfilment?SaleID&#x3D;{SaleID}&amp;IncludeProductInfo&#x3D;{IncludeProductInfo}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | GET         |
| [**SaleFulfilmentShipPost**](SaleApi.md#salefulfilmentshippost)                                                                                                                                   | **POST** /sale/fulfilment/ship                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | POST        |
| [**SaleFulfilmentShipPut**](SaleApi.md#salefulfilmentshipput)                                                                                                                                     | **PUT** /sale/fulfilment/ship                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | PUT         |
| [**SaleFulfilmentShipTaskidGet**](SaleApi.md#salefulfilmentshiptaskidget)                                                                                                                         | **GET** /sale/fulfilment/ship?TaskID&#x3D;{TaskID}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | GET         |
| [**SaleFulfilmentTaskidVoidDelete**](SaleApi.md#salefulfilmenttaskidvoiddelete)                                                                                                                   | **DELETE** /sale/fulfilment?TaskID&#x3D;{TaskID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | DELETE      |
| [**SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet**](SaleApi.md#saleidcombineadditionalchargeshideinventorymovementsincludetransactionscountryformatget) | **GET** /sale?ID&#x3D;{ID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}&amp;HideInventoryMovements&#x3D;{HideInventoryMovements}&amp;IncludeTransactions&#x3D;{IncludeTransactions}&amp;CountryFormat&#x3D;{CountryFormat}                                                                                                                                                                                                                                                                                                                                                                                                                                   | GET         |
| [**SaleIdVoidDelete**](SaleApi.md#saleidvoiddelete)                                                                                                                                               | **DELETE** /sale?ID&#x3D;{ID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Delete      |
| [**SaleInvoicePost**](SaleApi.md#saleinvoicepost)                                                                                                                                                 | **POST** /sale/invoice                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | POST        |
| [**SaleInvoicePut**](SaleApi.md#saleinvoiceput)                                                                                                                                                   | **PUT** /sale/invoice                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | PUT         |
| [**SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet**](SaleApi.md#saleinvoicesaleidcombineadditionalchargesincludeproductinfoget)                                                   | **GET** /sale/invoice?SaleID&#x3D;{SaleID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}&amp;IncludeProductInfo&#x3D;{IncludeProductInfo}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | GET         |
| [**SaleInvoiceTaskidVoidDelete**](SaleApi.md#saleinvoicetaskidvoiddelete)                                                                                                                         | **DELETE** /sale/invoice?TaskID&#x3D;{TaskID}&amp;Void&#x3D;{Void}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | DELETE      |
| [**SaleManualjournalPost**](SaleApi.md#salemanualjournalpost)                                                                                                                                     | **POST** /sale/manualJournal                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | POST        |
| [**SaleManualjournalSaleidGet**](SaleApi.md#salemanualjournalsaleidget)                                                                                                                           | **GET** /sale/manualJournal?SaleID&#x3D;{SaleID}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | GET         |
| [**SaleOrderPost**](SaleApi.md#saleorderpost)                                                                                                                                                     | **POST** /sale/order                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | POST        |
| [**SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet**](SaleApi.md#saleordersaleidcombineadditionalchargesincludeproductinfoget)                                                       | **GET** /sale/order?SaleID&#x3D;{SaleID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}&amp;IncludeProductInfo&#x3D;{IncludeProductInfo}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | GET         |
| [**SalePaymentIdDelete**](SaleApi.md#salepaymentiddelete)                                                                                                                                         | **DELETE** /sale/payment?ID&#x3D;{ID}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | DELETE      |
| [**SalePaymentPost**](SaleApi.md#salepaymentpost)                                                                                                                                                 | **POST** /sale/payment                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | POST        |
| [**SalePaymentPut**](SaleApi.md#salepaymentput)                                                                                                                                                   | **PUT** /sale/payment                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | PUT         |
| [**SalePaymentSaleidGet**](SaleApi.md#salepaymentsaleidget)                                                                                                                                       | **GET** /sale/payment?SaleID&#x3D;{SaleID}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | GET         |
| [**SalePost**](SaleApi.md#salepost)                                                                                                                                                               | **POST** /sale                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | POST        |
| [**SalePut**](SaleApi.md#saleput)                                                                                                                                                                 | **PUT** /sale                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                | PUT         |
| [**SaleQuotePost**](SaleApi.md#salequotepost)                                                                                                                                                     | **POST** /sale/quote                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | POST        |
| [**SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet**](SaleApi.md#salequotesaleidcombineadditionalchargesincludeproductinfoget)                                                       | **GET** /sale/quote?SaleID&#x3D;{SaleID}&amp;CombineAdditionalCharges&#x3D;{CombineAdditionalCharges}&amp;IncludeProductInfo&#x3D;{IncludeProductInfo}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | GET         |

<a id="pglmtsrchcreatedsinceupdatedsinceetc"></a>

# **PgLmtSrchCreatedsinceUpdatedsinceEtc**

> PgLmtSrchCreatedsinceUpdatedsinceEtc200Response PgLmtSrchCreatedsinceUpdatedsinceEtc (decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PgLmtSrchCreatedsinceUpdatedsinceEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var search = "search_example";  // string | Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber
            var createdSince = "createdSince_example";  // string | Only return sales created after specified date. Date must follow  ISO 8601 format.
            var updatedSince = "updatedSince_example";  // string | Only return sales changed after specified date. Date must follow  ISO 8601 format.
            var creditNoteStatus = "creditNoteStatus_example";  // string | Only return sales with specified credit note status
            var status = "status_example";  // string | Only return sales with specified sale status
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PgLmtSrchCreatedsinceUpdatedsinceEtc200Response result = apiInstance.PgLmtSrchCreatedsinceUpdatedsinceEtc(page, limit, search, createdSince, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response> response = apiInstance.PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfo(page, limit, search, createdSince, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                                                                                             | Notes             |
| ------------------------- | ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                                                                                                                         | [default to 1M]   |
| **limit**                 | **decimal** |                                                                                                                                                         | [default to 100M] |
| **search**                | **string**  | Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber |                   |
| **createdSince**          | **string**  | Only return sales created after specified date. Date must follow ISO 8601 format.                                                                       |                   |
| **updatedSince**          | **string**  | Only return sales changed after specified date. Date must follow ISO 8601 format.                                                                       |                   |
| **creditNoteStatus**      | **string**  | Only return sales with specified credit note status                                                                                                     |                   |
| **status**                | **string**  | Only return sales with specified sale status                                                                                                            |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                                                               | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                                                               | [optional]        |

### Return type

[**PgLmtSrchCreatedsinceUpdatedsinceEtc200Response**](PgLmtSrchCreatedsinceUpdatedsinceEtc200Response.md)

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

<a id="pglmtsrchcreatedsinceupdatedsinceetc1"></a>

# **PgLmtSrchCreatedsinceUpdatedsinceEtc1**

> PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response PgLmtSrchCreatedsinceUpdatedsinceEtc1 (decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class PgLmtSrchCreatedsinceUpdatedsinceEtc1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var search = "search_example";  // string | Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber
            var createdSince = "createdSince_example";  // string | Only return sales created after specified date. Date must follow  ISO 8601 format.
            var updatedSince = "updatedSince_example";  // string | Only return sales changed after specified date. Date must follow  ISO 8601 format.
            var shipBy = "shipBy_example";  // string | Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.
            var quoteStatus = "quoteStatus_example";  // string | Only return sales with specified quote status
            var orderStatus = "orderStatus_example";  // string | Only return sales with specified order status
            var combinedPickStatus = "combinedPickStatus_example";  // string | Only return sales with specified CombinedPickingStatus
            var combinedPackStatus = "combinedPackStatus_example";  // string | Only return sales with specified CombinedPackingStatus
            var combinedShippingStatus = "combinedShippingStatus_example";  // string | Only return sales with specified CombinedShippingStatus
            var combinedInvoiceStatus = "combinedInvoiceStatus_example";  // string | Only return sales with specified CombinedInvoiceStatus
            var creditNoteStatus = "creditNoteStatus_example";  // string | Only return sales with specified credit note status
            var externalID = "externalID_example";  // string | Only return sales with specified External ID
            var status = "status_example";  // string | Only return sales with specified sale status
            var readyForShipping = true;  // bool | Only return sales with 'Authorised' pack and not 'Authorised' shipping
            var orderLocationID = "orderLocationID_example";  // string | Only return sales with specified Order Location ID
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response result = apiInstance.PgLmtSrchCreatedsinceUpdatedsinceEtc1(page, limit, search, createdSince, updatedSince, shipBy, quoteStatus, orderStatus, combinedPickStatus, combinedPackStatus, combinedShippingStatus, combinedInvoiceStatus, creditNoteStatus, externalID, status, readyForShipping, orderLocationID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtc1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response> response = apiInstance.PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfo(page, limit, search, createdSince, updatedSince, shipBy, quoteStatus, orderStatus, combinedPickStatus, combinedPackStatus, combinedShippingStatus, combinedInvoiceStatus, creditNoteStatus, externalID, status, readyForShipping, orderLocationID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                       | Type        | Description                                                                                                                                             | Notes             |
| -------------------------- | ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------- |
| **page**                   | **decimal** |                                                                                                                                                         | [default to 1M]   |
| **limit**                  | **decimal** |                                                                                                                                                         | [default to 100M] |
| **search**                 | **string**  | Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber |                   |
| **createdSince**           | **string**  | Only return sales created after specified date. Date must follow ISO 8601 format.                                                                       |                   |
| **updatedSince**           | **string**  | Only return sales changed after specified date. Date must follow ISO 8601 format.                                                                       |                   |
| **shipBy**                 | **string**  | Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow ISO 8601 format.                        |                   |
| **quoteStatus**            | **string**  | Only return sales with specified quote status                                                                                                           |                   |
| **orderStatus**            | **string**  | Only return sales with specified order status                                                                                                           |                   |
| **combinedPickStatus**     | **string**  | Only return sales with specified CombinedPickingStatus                                                                                                  |                   |
| **combinedPackStatus**     | **string**  | Only return sales with specified CombinedPackingStatus                                                                                                  |                   |
| **combinedShippingStatus** | **string**  | Only return sales with specified CombinedShippingStatus                                                                                                 |                   |
| **combinedInvoiceStatus**  | **string**  | Only return sales with specified CombinedInvoiceStatus                                                                                                  |                   |
| **creditNoteStatus**       | **string**  | Only return sales with specified credit note status                                                                                                     |                   |
| **externalID**             | **string**  | Only return sales with specified External ID                                                                                                            |                   |
| **status**                 | **string**  | Only return sales with specified sale status                                                                                                            |                   |
| **readyForShipping**       | **bool**    | Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping                                                                  |                   |
| **orderLocationID**        | **string**  | Only return sales with specified Order Location ID                                                                                                      |                   |
| **apiAuthAccountid**       | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                                                               | [optional]        |
| **apiAuthApplicationkey**  | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                                                               | [optional]        |

### Return type

[**PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response**](PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response.md)

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

<a id="saleattachmentiddelete"></a>

# **SaleAttachmentIdDelete**

> SaleAttachmentPost200Response SaleAttachmentIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleAttachmentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var ID = "ID_example";  // string | ID of Sale Attachment to delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                SaleAttachmentPost200Response result = apiInstance.SaleAttachmentIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleAttachmentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleAttachmentIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<SaleAttachmentPost200Response> response = apiInstance.SaleAttachmentIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleAttachmentIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Sale Attachment to delete           |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**SaleAttachmentPost200Response**](SaleAttachmentPost200Response.md)

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

<a id="saleattachmentpost"></a>

# **SaleAttachmentPost**

> SaleAttachmentPost200Response SaleAttachmentPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleAttachmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                SaleAttachmentPost200Response result = apiInstance.SaleAttachmentPost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleAttachmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleAttachmentPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleAttachmentPost200Response> response = apiInstance.SaleAttachmentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleAttachmentPostWithHttpInfo: " + e.Message);
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

[**SaleAttachmentPost200Response**](SaleAttachmentPost200Response.md)

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

<a id="saleattachmentsaleidget"></a>

# **SaleAttachmentSaleidGet**

> SaleAttachmentPost200Response SaleAttachmentSaleidGet (string saleID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleAttachmentSaleidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | Returns Attachments of a particular sale
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleAttachmentPost200Response result = apiInstance.SaleAttachmentSaleidGet(saleID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleAttachmentSaleidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleAttachmentSaleidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleAttachmentPost200Response> response = apiInstance.SaleAttachmentSaleidGetWithHttpInfo(saleID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleAttachmentSaleidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **saleID**                | **string**  | Returns Attachments of a particular sale  |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**SaleAttachmentPost200Response**](SaleAttachmentPost200Response.md)

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

<a id="salecreditnotepost"></a>

# **SaleCreditnotePost**

> void SaleCreditnotePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

POST

-   POST method will return exception if Credit Note status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Invoice status is not `AUTHORISED` or `PAID`. + If set `TaskID` value to Guid empty (`00000000-0000-0000-0000-000000000000`), then new Credit Note Task will be created.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleCreditnotePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                apiInstance.SaleCreditnotePost(apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleCreditnotePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleCreditnotePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    apiInstance.SaleCreditnotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleCreditnotePostWithHttpInfo: " + e.Message);
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

-   **Content-Type**: Not defined
-   **Accept**: Not defined

### HTTP response details

| Status code | Description | Response headers |
| ----------- | ----------- | ---------------- |
| **200**     | OK          | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="salecreditnotesaleidcombineadditionalchargesincludeproductinfoincludepaymentinfoget"></a>

# **SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet**

> void SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet (string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | Returns Credit Notes info of a particular sale
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var includeProductInfo = true;  // bool | Show all used products in additional array (Default = false)
            var includePaymentInfo = true;  // bool | Show all Credit Note payments in additional array and calculate the Credit Note balance (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet(saleID, combineAdditionalCharges, includeProductInfo, includePaymentInfo, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, includePaymentInfo, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                                                                    | Notes      |
| ---------------------------- | ----------- | -------------------------------------------------------------------------------------------------------------- | ---------- |
| **saleID**                   | **string**  | Returns Credit Notes info of a particular sale                                                                 |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)                                        |            |
| **includeProductInfo**       | **bool**    | Show all used products in additional array (Default &#x3D; false)                                              |            |
| **includePaymentInfo**       | **bool**    | Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                      | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                      | [optional] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

-   **Content-Type**: Not defined
-   **Accept**: Not defined

### HTTP response details

| Status code | Description | Response headers |
| ----------- | ----------- | ---------------- |
| **200**     | OK          | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="salecreditnotetaskidvoiddelete"></a>

# **SaleCreditnoteTaskidVoidDelete**

> SaleCreditnoteTaskidVoidDelete200Response SaleCreditnoteTaskidVoidDelete (string taskID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   This method works only for: + Sales with `Type` = `Advanced Sale` and Credit Note with `TaskID` = `SaleID` + Sales with `Type` = `Advanced Sale` and Credit Note with `TaskID` = `SaleID`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleCreditnoteTaskidVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var taskID = "taskID_example";  // string | ID of Sale task to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                SaleCreditnoteTaskidVoidDelete200Response result = apiInstance.SaleCreditnoteTaskidVoidDelete(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleCreditnoteTaskidVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleCreditnoteTaskidVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<SaleCreditnoteTaskidVoidDelete200Response> response = apiInstance.SaleCreditnoteTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleCreditnoteTaskidVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **taskID**                | **string**  | ID of Sale task to Void or Undo           |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**SaleCreditnoteTaskidVoidDelete200Response**](SaleCreditnoteTaskidVoidDelete200Response.md)

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

<a id="salefulfilmentpackpost"></a>

# **SaleFulfilmentPackPost**

> SaleFulfilmentPackPut200Response SaleFulfilmentPackPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = null)

POST

-   POST method will return exception if Pick status is - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Pack status is not - `DRAFT` or `NOT AVAILABLE`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentPackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleFulfilmentPackPutRequest = new SaleFulfilmentPackPutRequest?(); // SaleFulfilmentPackPutRequest? |  (optional)

            try
            {
                // POST
                SaleFulfilmentPackPut200Response result = apiInstance.SaleFulfilmentPackPost(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentPackPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentPackPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleFulfilmentPackPut200Response> response = apiInstance.SaleFulfilmentPackPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentPackPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleFulfilmentPackPutRequest** | [**SaleFulfilmentPackPutRequest?**](SaleFulfilmentPackPutRequest?.md) |                                           | [optional] |

### Return type

[**SaleFulfilmentPackPut200Response**](SaleFulfilmentPackPut200Response.md)

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

<a id="salefulfilmentpackput"></a>

# **SaleFulfilmentPackPut**

> SaleFulfilmentPackPut200Response SaleFulfilmentPackPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = null)

PUT

-   PUT method will return exception if Pick status is - `DRAFT` or `NOT AVAILABLE` + PUT method will return exception if Pack status is not - `DRAFT` or `NOT AVAILABLE`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentPackPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleFulfilmentPackPutRequest = new SaleFulfilmentPackPutRequest?(); // SaleFulfilmentPackPutRequest? |  (optional)

            try
            {
                // PUT
                SaleFulfilmentPackPut200Response result = apiInstance.SaleFulfilmentPackPut(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentPackPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentPackPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<SaleFulfilmentPackPut200Response> response = apiInstance.SaleFulfilmentPackPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentPackPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleFulfilmentPackPutRequest** | [**SaleFulfilmentPackPutRequest?**](SaleFulfilmentPackPutRequest?.md) |                                           | [optional] |

### Return type

[**SaleFulfilmentPackPut200Response**](SaleFulfilmentPackPut200Response.md)

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

<a id="salefulfilmentpacktaskidincludeproductinfoget"></a>

# **SaleFulfilmentPackTaskidIncludeproductinfoGet**

> SaleFulfilmentPackTaskidIncludeproductinfoGet200Response SaleFulfilmentPackTaskidIncludeproductinfoGet (string taskID, bool includeProductInfo, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleFulfilmentPackTaskidIncludeproductinfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var taskID = "taskID_example";  // string | TaskID of Fulfilment
            var includeProductInfo = true;  // bool | Show all used products in additional array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleFulfilmentPackTaskidIncludeproductinfoGet200Response result = apiInstance.SaleFulfilmentPackTaskidIncludeproductinfoGet(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentPackTaskidIncludeproductinfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response> response = apiInstance.SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfo(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                       | Notes      |
| ------------------------- | ----------- | ----------------------------------------------------------------- | ---------- |
| **taskID**                | **string**  | TaskID of Fulfilment                                              |            |
| **includeProductInfo**    | **bool**    | Show all used products in additional array (Default &#x3D; false) |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                         | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                         | [optional] |

### Return type

[**SaleFulfilmentPackTaskidIncludeproductinfoGet200Response**](SaleFulfilmentPackTaskidIncludeproductinfoGet200Response.md)

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

<a id="salefulfilmentpickpost"></a>

# **SaleFulfilmentPickPost**

> SaleFulfilmentPickPut200Response SaleFulfilmentPickPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = null)

POST

-   POST method will return exception if Pick status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Order status is not `AUTHORISED`. + To make autopick call the method with attributes `TaskID` and `AutoPickMode` = `AUTOPICK`. Pick Status will be changed to \"AUTHORISED\" automatically.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentPickPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleFulfilmentPickPutRequest = new SaleFulfilmentPickPutRequest?(); // SaleFulfilmentPickPutRequest? |  (optional)

            try
            {
                // POST
                SaleFulfilmentPickPut200Response result = apiInstance.SaleFulfilmentPickPost(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentPickPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentPickPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleFulfilmentPickPut200Response> response = apiInstance.SaleFulfilmentPickPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentPickPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleFulfilmentPickPutRequest** | [**SaleFulfilmentPickPutRequest?**](SaleFulfilmentPickPutRequest?.md) |                                           | [optional] |

### Return type

[**SaleFulfilmentPickPut200Response**](SaleFulfilmentPickPut200Response.md)

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

<a id="salefulfilmentpickput"></a>

# **SaleFulfilmentPickPut**

> SaleFulfilmentPickPut200Response SaleFulfilmentPickPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = null)

PUT

-   PUT method will return exception if Pick status is not - `DRAFT` or `NOT AVAILABLE` + PUT method will return exception if Order status is not `AUTHORISED`. + To make autopick call the method with attributes `TaskID` and `AutoPickMode` = `AUTOPICK`. Pick Status will be changed to \"AUTHORISED\" automatically.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentPickPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleFulfilmentPickPutRequest = new SaleFulfilmentPickPutRequest?(); // SaleFulfilmentPickPutRequest? |  (optional)

            try
            {
                // PUT
                SaleFulfilmentPickPut200Response result = apiInstance.SaleFulfilmentPickPut(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentPickPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentPickPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<SaleFulfilmentPickPut200Response> response = apiInstance.SaleFulfilmentPickPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentPickPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleFulfilmentPickPutRequest** | [**SaleFulfilmentPickPutRequest?**](SaleFulfilmentPickPutRequest?.md) |                                           | [optional] |

### Return type

[**SaleFulfilmentPickPut200Response**](SaleFulfilmentPickPut200Response.md)

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

<a id="salefulfilmentpicktaskidincludeproductinfoget"></a>

# **SaleFulfilmentPickTaskidIncludeproductinfoGet**

> SaleFulfilmentPickPut200Response SaleFulfilmentPickTaskidIncludeproductinfoGet (string taskID, bool includeProductInfo, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleFulfilmentPickTaskidIncludeproductinfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var taskID = "taskID_example";  // string | TaskID of Fulfilment
            var includeProductInfo = true;  // bool | Show all used products in additional array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleFulfilmentPickPut200Response result = apiInstance.SaleFulfilmentPickTaskidIncludeproductinfoGet(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentPickTaskidIncludeproductinfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleFulfilmentPickPut200Response> response = apiInstance.SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfo(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                       | Notes      |
| ------------------------- | ----------- | ----------------------------------------------------------------- | ---------- |
| **taskID**                | **string**  | TaskID of Fulfilment                                              |            |
| **includeProductInfo**    | **bool**    | Show all used products in additional array (Default &#x3D; false) |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                         | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                         | [optional] |

### Return type

[**SaleFulfilmentPickPut200Response**](SaleFulfilmentPickPut200Response.md)

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

<a id="salefulfilmentpost"></a>

# **SaleFulfilmentPost**

> SaleFulfilmentPost200Response SaleFulfilmentPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = null)

POST

-   POST method will create new Fulfilment Task. + POST method will return exception if Order status is not `AUTHORISED`. + New Fulfilment Task can be created if there is no fulfilment tasks with non `AUTHORISED` Pick status. + Adding new Fulfilment Task to sale with `Type` = `Simple Sale` will change sale `Type` to `Advanced Sale`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleFulfilmentPostRequest = new SaleFulfilmentPostRequest?(); // SaleFulfilmentPostRequest? |  (optional)

            try
            {
                // POST
                SaleFulfilmentPost200Response result = apiInstance.SaleFulfilmentPost(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleFulfilmentPost200Response> response = apiInstance.SaleFulfilmentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                          | Type                                                            | Description                               | Notes      |
| ----------------------------- | --------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**          | **string?**                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**     | **string?**                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleFulfilmentPostRequest** | [**SaleFulfilmentPostRequest?**](SaleFulfilmentPostRequest?.md) |                                           | [optional] |

### Return type

[**SaleFulfilmentPost200Response**](SaleFulfilmentPost200Response.md)

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

<a id="salefulfilmentsaleidincludeproductinfoget"></a>

# **SaleFulfilmentSaleidIncludeproductinfoGet**

> SaleFulfilmentSaleidIncludeproductinfoGet200Response SaleFulfilmentSaleidIncludeproductinfoGet (string saleID, bool includeProductInfo, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleFulfilmentSaleidIncludeproductinfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | Returns Fulfilment info of a particular sale
            var includeProductInfo = true;  // bool | Show all used products in additional array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleFulfilmentSaleidIncludeproductinfoGet200Response result = apiInstance.SaleFulfilmentSaleidIncludeproductinfoGet(saleID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentSaleidIncludeproductinfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleFulfilmentSaleidIncludeproductinfoGet200Response> response = apiInstance.SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfo(saleID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                       | Notes      |
| ------------------------- | ----------- | ----------------------------------------------------------------- | ---------- |
| **saleID**                | **string**  | Returns Fulfilment info of a particular sale                      |            |
| **includeProductInfo**    | **bool**    | Show all used products in additional array (Default &#x3D; false) |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                         | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                         | [optional] |

### Return type

[**SaleFulfilmentSaleidIncludeproductinfoGet200Response**](SaleFulfilmentSaleidIncludeproductinfoGet200Response.md)

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

<a id="salefulfilmentshippost"></a>

# **SaleFulfilmentShipPost**

> SaleFulfilmentShipPut200Response SaleFulfilmentShipPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = null)

POST

-   POST method will return exception if PackStatus status is not - `AUTHORISED` + POST method will return exception if ShipmentStatus status is - `AUTHORISED` or `PARTIALLY AUTHORISED`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentShipPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleFulfilmentShipPutRequest = new SaleFulfilmentShipPutRequest?(); // SaleFulfilmentShipPutRequest? |  (optional)

            try
            {
                // POST
                SaleFulfilmentShipPut200Response result = apiInstance.SaleFulfilmentShipPost(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentShipPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentShipPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleFulfilmentShipPut200Response> response = apiInstance.SaleFulfilmentShipPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentShipPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleFulfilmentShipPutRequest** | [**SaleFulfilmentShipPutRequest?**](SaleFulfilmentShipPutRequest?.md) |                                           | [optional] |

### Return type

[**SaleFulfilmentShipPut200Response**](SaleFulfilmentShipPut200Response.md)

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

<a id="salefulfilmentshipput"></a>

# **SaleFulfilmentShipPut**

> SaleFulfilmentShipPut200Response SaleFulfilmentShipPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = null)

PUT

-   PUT method will return exception if PackStatus status is not - `AUTHORISED` + PUT method will return exception if ShipmentStatus status is - `AUTHORISED` or `PARTIALLY AUTHORISED` + Add filed `AddTrackingNumbers` = `true` to payload to be able to update tracking numbers or carrier for authorised shipment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentShipPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleFulfilmentShipPutRequest = new SaleFulfilmentShipPutRequest?(); // SaleFulfilmentShipPutRequest? |  (optional)

            try
            {
                // PUT
                SaleFulfilmentShipPut200Response result = apiInstance.SaleFulfilmentShipPut(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentShipPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentShipPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<SaleFulfilmentShipPut200Response> response = apiInstance.SaleFulfilmentShipPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentShipPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleFulfilmentShipPutRequest** | [**SaleFulfilmentShipPutRequest?**](SaleFulfilmentShipPutRequest?.md) |                                           | [optional] |

### Return type

[**SaleFulfilmentShipPut200Response**](SaleFulfilmentShipPut200Response.md)

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

<a id="salefulfilmentshiptaskidget"></a>

# **SaleFulfilmentShipTaskidGet**

> SaleFulfilmentShipTaskidGet200Response SaleFulfilmentShipTaskidGet (string taskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleFulfilmentShipTaskidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var taskID = "taskID_example";  // string | TaskID of Fulfilment
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleFulfilmentShipTaskidGet200Response result = apiInstance.SaleFulfilmentShipTaskidGet(taskID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentShipTaskidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentShipTaskidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleFulfilmentShipTaskidGet200Response> response = apiInstance.SaleFulfilmentShipTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentShipTaskidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **taskID**                | **string**  | TaskID of Fulfilment                      |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**SaleFulfilmentShipTaskidGet200Response**](SaleFulfilmentShipTaskidGet200Response.md)

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

<a id="salefulfilmenttaskidvoiddelete"></a>

# **SaleFulfilmentTaskidVoidDelete**

> SaleFulfilmentTaskidVoidDelete200Response SaleFulfilmentTaskidVoidDelete (string taskID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   This method works only for: + Sales with `Type` = `Advanced Sale`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleFulfilmentTaskidVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var taskID = "taskID_example";  // string | ID of Sale task to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                SaleFulfilmentTaskidVoidDelete200Response result = apiInstance.SaleFulfilmentTaskidVoidDelete(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleFulfilmentTaskidVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleFulfilmentTaskidVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<SaleFulfilmentTaskidVoidDelete200Response> response = apiInstance.SaleFulfilmentTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleFulfilmentTaskidVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **taskID**                | **string**  | ID of Sale task to Void or Undo           |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**SaleFulfilmentTaskidVoidDelete200Response**](SaleFulfilmentTaskidVoidDelete200Response.md)

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

<a id="saleidcombineadditionalchargeshideinventorymovementsincludetransactionscountryformatget"></a>

# **SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet**

> SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet (string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var ID = "ID_example";  // string | Returns detailed info of a particular sale
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var hideInventoryMovements = true;  // bool | Hide inventory movements (Default = false)
            var includeTransactions = true;  // bool | Show related transactions (Default = false)
            var countryFormat = "countryFormat_example";  // string | Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default = Regular)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response result = apiInstance.SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet(ID, combineAdditionalCharges, hideInventoryMovements, includeTransactions, countryFormat, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response> response = apiInstance.SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfo(ID, combineAdditionalCharges, hideInventoryMovements, includeTransactions, countryFormat, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                                                   | Notes      |
| ---------------------------- | ----------- | --------------------------------------------------------------------------------------------- | ---------- |
| **ID**                       | **string**  | Returns detailed info of a particular sale                                                    |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)                       |            |
| **hideInventoryMovements**   | **bool**    | Hide inventory movements (Default &#x3D; false)                                               |            |
| **includeTransactions**      | **bool**    | Show related transactions (Default &#x3D; false)                                              |            |
| **countryFormat**            | **string**  | Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular) |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                     | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                     | [optional] |

### Return type

[**SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response**](SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response.md)

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

<a id="saleidvoiddelete"></a>

# **SaleIdVoidDelete**

> SaleIdVoidDelete200Response SaleIdVoidDelete (string ID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleIdVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var ID = "ID_example";  // string | ID of Sale to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Delete
                SaleIdVoidDelete200Response result = apiInstance.SaleIdVoidDelete(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleIdVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleIdVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<SaleIdVoidDelete200Response> response = apiInstance.SaleIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleIdVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **ID**                    | **string**  | ID of Sale to Void or Undo                |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**SaleIdVoidDelete200Response**](SaleIdVoidDelete200Response.md)

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

<a id="saleinvoicepost"></a>

# **SaleInvoicePost**

> SaleInvoicePost200Response SaleInvoicePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleInvoicePostRequest? saleInvoicePostRequest = null)

POST

-   POST method will return exception if Invoice status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Order status is not `AUTHORISED`. + If set `TaskID` value to Guid empty (`00000000-0000-0000-0000-000000000000`), then new Invoice Task will be created.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleInvoicePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleInvoicePostRequest = new SaleInvoicePostRequest?(); // SaleInvoicePostRequest? |  (optional)

            try
            {
                // POST
                SaleInvoicePost200Response result = apiInstance.SaleInvoicePost(apiAuthAccountid, apiAuthApplicationkey, saleInvoicePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleInvoicePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleInvoicePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleInvoicePost200Response> response = apiInstance.SaleInvoicePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleInvoicePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleInvoicePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                       | Type                                                      | Description                               | Notes      |
| -------------------------- | --------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**       | **string?**                                               | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**  | **string?**                                               | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleInvoicePostRequest** | [**SaleInvoicePostRequest?**](SaleInvoicePostRequest?.md) |                                           | [optional] |

### Return type

[**SaleInvoicePost200Response**](SaleInvoicePost200Response.md)

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

<a id="saleinvoiceput"></a>

# **SaleInvoicePut**

> SaleInvoicePut200Response SaleInvoicePut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

PUT

-   PUT method will return exception if Invoice does not exist or Invoice status is not - `DRAFT` or `NOT AVAILABLE` + PUT method will return exception if Order status is not `AUTHORISED`. + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleInvoicePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // PUT
                SaleInvoicePut200Response result = apiInstance.SaleInvoicePut(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleInvoicePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleInvoicePutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<SaleInvoicePut200Response> response = apiInstance.SaleInvoicePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleInvoicePutWithHttpInfo: " + e.Message);
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

[**SaleInvoicePut200Response**](SaleInvoicePut200Response.md)

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

<a id="saleinvoicesaleidcombineadditionalchargesincludeproductinfoget"></a>

# **SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet**

> SaleInvoicePost200Response SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet (string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | Returns Invoice info of a particular sale
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var includeProductInfo = true;  // bool | Show all used products in additional array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleInvoicePost200Response result = apiInstance.SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleInvoicePost200Response> response = apiInstance.SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **saleID**                   | **string**  | Returns Invoice info of a particular sale                               |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **includeProductInfo**       | **bool**    | Show all used products in additional array (Default &#x3D; false)       |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**SaleInvoicePost200Response**](SaleInvoicePost200Response.md)

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

<a id="saleinvoicetaskidvoiddelete"></a>

# **SaleInvoiceTaskidVoidDelete**

> SaleInvoiceTaskidVoidDelete200Response SaleInvoiceTaskidVoidDelete (string taskID, bool varVoid, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   This method works only for: + Sales with `Type` = `Advanced Sale` and Invoice with `TaskID` = `SaleID` + Sales with `Type` = `Advanced Sale` and Invoice with `TaskID` = `SaleID`

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleInvoiceTaskidVoidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var taskID = "taskID_example";  // string | ID of Sale task to Void or Undo
            var varVoid = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                SaleInvoiceTaskidVoidDelete200Response result = apiInstance.SaleInvoiceTaskidVoidDelete(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleInvoiceTaskidVoidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleInvoiceTaskidVoidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<SaleInvoiceTaskidVoidDelete200Response> response = apiInstance.SaleInvoiceTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleInvoiceTaskidVoidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **taskID**                | **string**  | ID of Sale task to Void or Undo           |                    |
| **varVoid**               | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**SaleInvoiceTaskidVoidDelete200Response**](SaleInvoiceTaskidVoidDelete200Response.md)

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

<a id="salemanualjournalpost"></a>

# **SaleManualjournalPost**

> SaleManualjournalPostRequest SaleManualjournalPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleManualjournalPostRequest? saleManualjournalPostRequest = null)

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
    public class SaleManualjournalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleManualjournalPostRequest = new SaleManualjournalPostRequest?(); // SaleManualjournalPostRequest? |  (optional)

            try
            {
                // POST
                SaleManualjournalPostRequest result = apiInstance.SaleManualjournalPost(apiAuthAccountid, apiAuthApplicationkey, saleManualjournalPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleManualjournalPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleManualjournalPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleManualjournalPostRequest> response = apiInstance.SaleManualjournalPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleManualjournalPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleManualjournalPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleManualjournalPostRequest** | [**SaleManualjournalPostRequest?**](SaleManualjournalPostRequest?.md) |                                           | [optional] |

### Return type

[**SaleManualjournalPostRequest**](SaleManualjournalPostRequest.md)

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

<a id="salemanualjournalsaleidget"></a>

# **SaleManualjournalSaleidGet**

> SaleManualjournalSaleidGet200Response SaleManualjournalSaleidGet (string saleID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleManualjournalSaleidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | Returns Payment info of a particular sale
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleManualjournalSaleidGet200Response result = apiInstance.SaleManualjournalSaleidGet(saleID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleManualjournalSaleidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleManualjournalSaleidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleManualjournalSaleidGet200Response> response = apiInstance.SaleManualjournalSaleidGetWithHttpInfo(saleID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleManualjournalSaleidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **saleID**                | **string**  | Returns Payment info of a particular sale |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**SaleManualjournalSaleidGet200Response**](SaleManualjournalSaleidGet200Response.md)

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

<a id="saleorderpost"></a>

# **SaleOrderPost**

> SaleOrderPost200Response SaleOrderPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleOrderPostRequest? saleOrderPostRequest = null)

POST

-   POST method will return exception if Order status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Quote status is not `AUTHORISED`. + POST method can accept \"AutoPickPackShipMode\" property in body. + Default: `NOPICK` + This property affects only Sales with Type = `Simple Sale` and with no backorder when changing order status to `AUTHORISED` + Available valus for AutoPickPackShipMode + `NOPICK` - Order will be created without picking + `AUTOPICK` - Order sill be created with Pick phase authorised + `AUTOPICKPACK` - Order sill be created with Pick and Pack phases authorised + `AUTOPICKPACKSHIP` - Order sill be created with Pick and Pack and Ship phases authorised + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to `AUTHORISED`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleOrderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleOrderPostRequest = new SaleOrderPostRequest?(); // SaleOrderPostRequest? |  (optional)

            try
            {
                // POST
                SaleOrderPost200Response result = apiInstance.SaleOrderPost(apiAuthAccountid, apiAuthApplicationkey, saleOrderPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleOrderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleOrderPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleOrderPost200Response> response = apiInstance.SaleOrderPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleOrderPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleOrderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                  | Description                               | Notes      |
| ------------------------- | ----------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleOrderPostRequest**  | [**SaleOrderPostRequest?**](SaleOrderPostRequest?.md) |                                           | [optional] |

### Return type

[**SaleOrderPost200Response**](SaleOrderPost200Response.md)

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

<a id="saleordersaleidcombineadditionalchargesincludeproductinfoget"></a>

# **SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet**

> SaleOrderPost200Response SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet (string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | SaleID of Orders
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var includeProductInfo = true;  // bool | Show all used products in additional array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleOrderPost200Response result = apiInstance.SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleOrderPost200Response> response = apiInstance.SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **saleID**                   | **string**  | SaleID of Orders                                                        |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **includeProductInfo**       | **bool**    | Show all used products in additional array (Default &#x3D; false)       |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**SaleOrderPost200Response**](SaleOrderPost200Response.md)

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

<a id="salepaymentiddelete"></a>

# **SalePaymentIdDelete**

> MeAddressesIdDelete200Response SalePaymentIdDelete (string ID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SalePaymentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var ID = "ID_example";  // string | ID of Payment to Delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                MeAddressesIdDelete200Response result = apiInstance.SalePaymentIdDelete(ID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SalePaymentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalePaymentIdDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<MeAddressesIdDelete200Response> response = apiInstance.SalePaymentIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SalePaymentIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **ID**                    | **string**  | ID of Payment to Delete                   |            |
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

<a id="salepaymentpost"></a>

# **SalePaymentPost**

> SalePaymentPost200Response SalePaymentPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SalePaymentPostRequest? salePaymentPostRequest = null)

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
    public class SalePaymentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var salePaymentPostRequest = new SalePaymentPostRequest?(); // SalePaymentPostRequest? |  (optional)

            try
            {
                // POST
                SalePaymentPost200Response result = apiInstance.SalePaymentPost(apiAuthAccountid, apiAuthApplicationkey, salePaymentPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SalePaymentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalePaymentPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SalePaymentPost200Response> response = apiInstance.SalePaymentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, salePaymentPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SalePaymentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                       | Type                                                      | Description                               | Notes      |
| -------------------------- | --------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**       | **string?**                                               | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**  | **string?**                                               | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **salePaymentPostRequest** | [**SalePaymentPostRequest?**](SalePaymentPostRequest?.md) |                                           | [optional] |

### Return type

[**SalePaymentPost200Response**](SalePaymentPost200Response.md)

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

<a id="salepaymentput"></a>

# **SalePaymentPut**

> SalePaymentPut200Response SalePaymentPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SalePaymentPutRequest? salePaymentPutRequest = null)

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
    public class SalePaymentPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var salePaymentPutRequest = new SalePaymentPutRequest?(); // SalePaymentPutRequest? |  (optional)

            try
            {
                // PUT
                SalePaymentPut200Response result = apiInstance.SalePaymentPut(apiAuthAccountid, apiAuthApplicationkey, salePaymentPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SalePaymentPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalePaymentPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<SalePaymentPut200Response> response = apiInstance.SalePaymentPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, salePaymentPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SalePaymentPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                    | Description                               | Notes      |
| ------------------------- | ------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **salePaymentPutRequest** | [**SalePaymentPutRequest?**](SalePaymentPutRequest?.md) |                                           | [optional] |

### Return type

[**SalePaymentPut200Response**](SalePaymentPut200Response.md)

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

<a id="salepaymentsaleidget"></a>

# **SalePaymentSaleidGet**

> List&lt;SalePaymentSaleidGet200ResponseInner&gt; SalePaymentSaleidGet (string saleID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SalePaymentSaleidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | Returns Payment info of a particular sale
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                List<SalePaymentSaleidGet200ResponseInner> result = apiInstance.SalePaymentSaleidGet(saleID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SalePaymentSaleidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalePaymentSaleidGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<List<SalePaymentSaleidGet200ResponseInner>> response = apiInstance.SalePaymentSaleidGetWithHttpInfo(saleID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SalePaymentSaleidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **saleID**                | **string**  | Returns Payment info of a particular sale |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**List&lt;SalePaymentSaleidGet200ResponseInner&gt;**](SalePaymentSaleidGet200ResponseInner.md)

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

<a id="salepost"></a>

# **SalePost**

> SalePost200Response SalePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SalePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                SalePost200Response result = apiInstance.SalePost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SalePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SalePost200Response> response = apiInstance.SalePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SalePostWithHttpInfo: " + e.Message);
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

[**SalePost200Response**](SalePost200Response.md)

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

<a id="saleput"></a>

# **SalePut**

> SalePut200Response SalePut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SalePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // PUT
                SalePut200Response result = apiInstance.SalePut(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SalePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalePutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<SalePut200Response> response = apiInstance.SalePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SalePutWithHttpInfo: " + e.Message);
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

[**SalePut200Response**](SalePut200Response.md)

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

<a id="salequotepost"></a>

# **SaleQuotePost**

> SaleQuotePost200Response SaleQuotePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SaleQuotePostRequest? saleQuotePostRequest = null)

POST

-   POST method will return exception if Quote status is not - `DRAFT` or `NOT AVAILABLE` + POST method will return exception if Sale's SkipQuote parameter is `true`. + POST method does not support stand alone Credit Notes.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SaleQuotePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var saleQuotePostRequest = new SaleQuotePostRequest?(); // SaleQuotePostRequest? |  (optional)

            try
            {
                // POST
                SaleQuotePost200Response result = apiInstance.SaleQuotePost(apiAuthAccountid, apiAuthApplicationkey, saleQuotePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleQuotePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleQuotePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<SaleQuotePost200Response> response = apiInstance.SaleQuotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleQuotePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleQuotePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                  | Description                               | Notes      |
| ------------------------- | ----------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **saleQuotePostRequest**  | [**SaleQuotePostRequest?**](SaleQuotePostRequest?.md) |                                           | [optional] |

### Return type

[**SaleQuotePost200Response**](SaleQuotePost200Response.md)

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

<a id="salequotesaleidcombineadditionalchargesincludeproductinfoget"></a>

# **SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet**

> SaleQuotePost200Response SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet (string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new SaleApi(config);
            var saleID = "saleID_example";  // string | SaleID of Quotes
            var combineAdditionalCharges = true;  // bool | Show additional charges in 'Lines' array (Default = false)
            var includeProductInfo = true;  // bool | Show all used products in additional array (Default = false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                SaleQuotePost200Response result = apiInstance.SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SaleApi.SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<SaleQuotePost200Response> response = apiInstance.SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SaleApi.SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                             | Notes      |
| ---------------------------- | ----------- | ----------------------------------------------------------------------- | ---------- |
| **saleID**                   | **string**  | SaleID of Quotes                                                        |            |
| **combineAdditionalCharges** | **bool**    | Show additional charges in &#39;Lines&#39; array (Default &#x3D; false) |            |
| **includeProductInfo**       | **bool**    | Show all used products in additional array (Default &#x3D; false)       |            |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                               | [optional] |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                               | [optional] |

### Return type

[**SaleQuotePost200Response**](SaleQuotePost200Response.md)

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
