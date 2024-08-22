# CIN7.DearInventory.Api.ProductionApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method                                                                                                                                                                        | HTTP request                                                                                                                                                                                                                                                                                                                                                                              | Description                         |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------- |
| [**Authorize**](ProductionApi.md#authorize)                                                                                                                                   | **POST** /production/order/authorize                                                                                                                                                                                                                                                                                                                                                      | Authorize                           |
| [**CallVoid**](ProductionApi.md#callvoid)                                                                                                                                     | **POST** /production/order/void                                                                                                                                                                                                                                                                                                                                                           | Void                                |
| [**CompleteRun**](ProductionApi.md#completerun)                                                                                                                               | **PUT** /production/order/run/complete                                                                                                                                                                                                                                                                                                                                                    | Complete Run                        |
| [**CompleteRunOperation**](ProductionApi.md#completerunoperation)                                                                                                             | **PUT** /production/order/run/operation/complete                                                                                                                                                                                                                                                                                                                                          | Complete Run Operation              |
| [**DeleteAttachment**](ProductionApi.md#deleteattachment)                                                                                                                     | **DELETE** /production/order/attachment?ProductionOrderAttachmentID&#x3D;{ProductionOrderAttachmentID}                                                                                                                                                                                                                                                                                    | Delete Attachment                   |
| [**GetProductionOrderAttachments**](ProductionApi.md#getproductionorderattachments)                                                                                           | **GET** /production/order/attachment?ProductionOrderID&#x3D;{ProductionOrderID}&amp;ReturnAttachmentsContent&#x3D;{ReturnAttachmentsContent}                                                                                                                                                                                                                                              | Get Production Order Attachments    |
| [**GetProductionOrderReferenceData**](ProductionApi.md#getproductionorderreferencedata)                                                                                       | **GET** /production/order/referenceData                                                                                                                                                                                                                                                                                                                                                   | Get Production Order Reference Data |
| [**OrderlistPgLmtStsSrchEtc**](ProductionApi.md#orderlistpglmtstssrchetc)                                                                                                     | **GET** /production/orderList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Status&#x3D;{Status}&amp;Search&#x3D;{Search}&amp;LocationID&#x3D;{LocationID}&amp;RequiredByDateFrom&#x3D;{RequiredByDateFrom}&amp;RequiredByDateTo&#x3D;{RequiredByDateTo}&amp;CompletionDateFrom&#x3D;{CompletionDateFrom}&amp;CompletionDateTo&#x3D;{CompletionDateTo}&amp;SourceTaskID&#x3D;{SourceTaskID} | GET                                 |
| [**PostAttachment**](ProductionApi.md#postattachment)                                                                                                                         | **POST** /production/order/attachment?ProductionOrderID&#x3D;{ProductionOrderID}                                                                                                                                                                                                                                                                                                          | Post Attachment                     |
| [**ProductionFactorycalendarPost**](ProductionApi.md#productionfactorycalendarpost)                                                                                           | **POST** /production/factoryCalendar                                                                                                                                                                                                                                                                                                                                                      | POST                                |
| [**ProductionFactorycalendarPut**](ProductionApi.md#productionfactorycalendarput)                                                                                             | **PUT** /production/factoryCalendar                                                                                                                                                                                                                                                                                                                                                       | PUT                                 |
| [**ProductionFactorycalendarYearGet**](ProductionApi.md#productionfactorycalendaryearget)                                                                                     | **GET** /production/factoryCalendar?Year&#x3D;{Year}                                                                                                                                                                                                                                                                                                                                      | GET                                 |
| [**ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut**](ProductionApi.md#productionorderallowrecalculatedatesallowrecalculatecyclesandquantitiesput) | **PUT** /production/order?AllowRecalculateDates&#x3D;{AllowRecalculateDates}&amp;AllowRecalculateCyclesAndQuantities&#x3D;{AllowRecalculateCyclesAndQuantities}                                                                                                                                                                                                                           | PUT                                 |
| [**ProductionOrderProductionorderidReturnattachmentscontentGet**](ProductionApi.md#productionorderproductionorderidreturnattachmentscontentget)                               | **GET** /production/order?ProductionOrderID&#x3D;{ProductionOrderID}&amp;returnAttachmentsContent&#x3D;{ReturnAttachmentsContent}                                                                                                                                                                                                                                                         | GET                                 |
| [**ProductionOrderRecalculatedatesPost**](ProductionApi.md#productionorderrecalculatedatespost)                                                                               | **POST** /production/order?RecalculateDates&#x3D;{RecalculateDates}                                                                                                                                                                                                                                                                                                                       | POST                                |
| [**ProductionOrderRunPost**](ProductionApi.md#productionorderrunpost)                                                                                                         | **POST** /production/order/run                                                                                                                                                                                                                                                                                                                                                            | POST                                |
| [**ProductionOrderRunProductionorderidIncludeattachmentcontentGet**](ProductionApi.md#productionorderrunproductionorderidincludeattachmentcontentget)                         | **GET** /production/order/run?ProductionOrderID&#x3D;{ProductionOrderID}&amp;IncludeAttachmentContent&#x3D;{IncludeAttachmentContent}                                                                                                                                                                                                                                                     | GET                                 |
| [**ProductionOrderRunProductionorderidIncreaseorderquantityPut**](ProductionApi.md#productionorderrunproductionorderidincreaseorderquantityput)                               | **PUT** /production/order/run?ProductionOrderID&#x3D;{ProductionOrderID}&amp;IncreaseOrderQuantity&#x3D;{IncreaseOrderQuantity}                                                                                                                                                                                                                                                           | PUT                                 |
| [**ProductionProductionbomPost**](ProductionApi.md#productionproductionbompost)                                                                                               | **POST** /production/productionBOM                                                                                                                                                                                                                                                                                                                                                        | POST                                |
| [**ProductionProductionbomProductfamilyidBomidDelete**](ProductionApi.md#productionproductionbomproductfamilyidbomiddelete)                                                   | **DELETE** /production/productionBOM?ProductFamilyID&#x3D;{ProductFamilyID}&amp;BOMID&#x3D;{BOMID}                                                                                                                                                                                                                                                                                        | DELETE                              |
| [**ProductionProductionbomProductfamilyidReturnattachmentscontentGet**](ProductionApi.md#productionproductionbomproductfamilyidreturnattachmentscontentget)                   | **GET** /production/productionBOM?ProductFamilyID&#x3D;{ProductFamilyID}&amp;ReturnAttachmentsContent&#x3D;{ReturnAttachmentsContent}                                                                                                                                                                                                                                                     | GET                                 |
| [**ProductionProductionbomProductidBomidDelete**](ProductionApi.md#productionproductionbomproductidbomiddelete)                                                               | **DELETE** /production/productionBOM?ProductID&#x3D;{ProductID}&amp;BOMID&#x3D;{BOMID}                                                                                                                                                                                                                                                                                                    | DELETE                              |
| [**ProductionProductionbomProductidReturnattachmentscontentGet**](ProductionApi.md#productionproductionbomproductidreturnattachmentscontentget)                               | **GET** /production/productionBOM?ProductID&#x3D;{ProductID}&amp;ReturnAttachmentsContent&#x3D;{ReturnAttachmentsContent}                                                                                                                                                                                                                                                                 | GET                                 |
| [**ProductionProductionbomPut**](ProductionApi.md#productionproductionbomput)                                                                                                 | **PUT** /production/productionBOM                                                                                                                                                                                                                                                                                                                                                         | PUT                                 |
| [**ProductionResourcePost**](ProductionApi.md#productionresourcepost)                                                                                                         | **POST** /production/resource                                                                                                                                                                                                                                                                                                                                                             | POST                                |
| [**ProductionResourcePut**](ProductionApi.md#productionresourceput)                                                                                                           | **PUT** /production/resource                                                                                                                                                                                                                                                                                                                                                              | PUT                                 |
| [**ProductionResourceResourceidDelete**](ProductionApi.md#productionresourceresourceiddelete)                                                                                 | **DELETE** /production/resource?ResourceID&#x3D;{ResourceID}                                                                                                                                                                                                                                                                                                                              | DELETE                              |
| [**ProductionResourceResourceidIncludeattachmentsGet**](ProductionApi.md#productionresourceresourceidincludeattachmentsget)                                                   | **GET** /production/resource?ResourceID&#x3D;{ResourceID}&amp;IncludeAttachments&#x3D;{IncludeAttachments}                                                                                                                                                                                                                                                                                | GET                                 |
| [**ProductionResourcelistPgLmtNameOnlyactiveGet**](ProductionApi.md#productionresourcelistpglmtnameonlyactiveget)                                                             | **GET** /production/resourceList?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Name&#x3D;{Name}&amp;OnlyActive&#x3D;{OnlyActive}                                                                                                                                                                                                                                                            | GET                                 |
| [**ProductionSuspendreasonPgLmtWorkcenteridGet**](ProductionApi.md#productionsuspendreasonpglmtworkcenteridget)                                                               | **GET** /production/suspendReason?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;WorkcenterID&#x3D;{WorkcenterID}                                                                                                                                                                                                                                                                            | GET                                 |
| [**ProductionSuspendreasonPut**](ProductionApi.md#productionsuspendreasonput)                                                                                                 | **PUT** /production/suspendReason                                                                                                                                                                                                                                                                                                                                                         | PUT                                 |
| [**ProductionWorkcentersPgLmtNameGet**](ProductionApi.md#productionworkcenterspglmtnameget)                                                                                   | **GET** /production/workcenters?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;Name&#x3D;{Name}                                                                                                                                                                                                                                                                                              | GET                                 |
| [**ProductionWorkcentersPost**](ProductionApi.md#productionworkcenterspost)                                                                                                   | **POST** /production/workcenters                                                                                                                                                                                                                                                                                                                                                          | POST                                |
| [**ProductionWorkcentersPut**](ProductionApi.md#productionworkcentersput)                                                                                                     | **PUT** /production/workcenters                                                                                                                                                                                                                                                                                                                                                           | PUT                                 |
| [**ProductionWorkcentersWorkcenteridDelete**](ProductionApi.md#productionworkcentersworkcenteriddelete)                                                                       | **DELETE** /production/workcenters?WorkCenterId&#x3D;{WorkCenterId}                                                                                                                                                                                                                                                                                                                       | DELETE                              |
| [**PutAttachment**](ProductionApi.md#putattachment)                                                                                                                           | **PUT** /production/order/attachment                                                                                                                                                                                                                                                                                                                                                      | Put Attachment                      |
| [**Release**](ProductionApi.md#release)                                                                                                                                       | **POST** /production/order/release                                                                                                                                                                                                                                                                                                                                                        | Release                             |
| [**ResumeRunOperation**](ProductionApi.md#resumerunoperation)                                                                                                                 | **PUT** /production/order/run/operation/resume                                                                                                                                                                                                                                                                                                                                            | Resume Run Operation                |
| [**StartRunOperation**](ProductionApi.md#startrunoperation)                                                                                                                   | **PUT** /production/order/run/operation/start                                                                                                                                                                                                                                                                                                                                             | Start Run Operation                 |
| [**SuspendRunOperation**](ProductionApi.md#suspendrunoperation)                                                                                                               | **PUT** /production/order/run/operation/suspend                                                                                                                                                                                                                                                                                                                                           | Suspend Run Operation               |
| [**Undo**](ProductionApi.md#undo)                                                                                                                                             | **POST** /production/order/undo                                                                                                                                                                                                                                                                                                                                                           | Undo                                |
| [**UndoRun**](ProductionApi.md#undorun)                                                                                                                                       | **PUT** /production/order/run/undo                                                                                                                                                                                                                                                                                                                                                        | Undo Run                            |
| [**UpdateManualJournals**](ProductionApi.md#updatemanualjournals)                                                                                                             | **PUT** /production/order/run/manualJournal?ProductionOrderID&#x3D;{ProductionOrderID}                                                                                                                                                                                                                                                                                                    | Update Manual Journals              |
| [**VoidRun**](ProductionApi.md#voidrun)                                                                                                                                       | **PUT** /production/order/run/void                                                                                                                                                                                                                                                                                                                                                        | Void Run                            |

<a id="authorize"></a>

# **Authorize**

> Authorize200Response Authorize (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, AuthorizeRequest? authorizeRequest = null)

Authorize

-   Method will authorize Production Order. Recalculates capacity.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class AuthorizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var authorizeRequest = new AuthorizeRequest?(); // AuthorizeRequest? |  (optional)

            try
            {
                // Authorize
                Authorize200Response result = apiInstance.Authorize(apiAuthAccountid, apiAuthApplicationkey, authorizeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.Authorize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizeWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorize
    ApiResponse<Authorize200Response> response = apiInstance.AuthorizeWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, authorizeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.AuthorizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                          | Description                               | Notes      |
| ------------------------- | --------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **authorizeRequest**      | [**AuthorizeRequest?**](AuthorizeRequest?.md) |                                           | [optional] |

### Return type

[**Authorize200Response**](Authorize200Response.md)

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

<a id="callvoid"></a>

# **CallVoid**

> Undo200Response CallVoid (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, UndoRequest? undoRequest = null)

Void

-   Method will void Production Order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class CallVoidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var undoRequest = new UndoRequest?(); // UndoRequest? |  (optional)

            try
            {
                // Void
                Undo200Response result = apiInstance.CallVoid(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CallVoid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CallVoidWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Void
    ApiResponse<Undo200Response> response = apiInstance.CallVoidWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.CallVoidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                | Description                               | Notes      |
| ------------------------- | ----------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **undoRequest**           | [**UndoRequest?**](UndoRequest?.md) |                                           | [optional] |

### Return type

[**Undo200Response**](Undo200Response.md)

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

<a id="completerun"></a>

# **CompleteRun**

> CompleteRun200Response CompleteRun (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CompleteRunRequest? completeRunRequest = null)

Complete Run

-   Method will complete Run.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class CompleteRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var completeRunRequest = new CompleteRunRequest?(); // CompleteRunRequest? |  (optional)

            try
            {
                // Complete Run
                CompleteRun200Response result = apiInstance.CompleteRun(apiAuthAccountid, apiAuthApplicationkey, completeRunRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CompleteRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompleteRunWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete Run
    ApiResponse<CompleteRun200Response> response = apiInstance.CompleteRunWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, completeRunRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.CompleteRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                              | Description                               | Notes      |
| ------------------------- | ------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **completeRunRequest**    | [**CompleteRunRequest?**](CompleteRunRequest?.md) |                                           | [optional] |

### Return type

[**CompleteRun200Response**](CompleteRun200Response.md)

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

<a id="completerunoperation"></a>

# **CompleteRunOperation**

> CompleteRunOperation200Response CompleteRunOperation (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Complete Run Operation

-   Method will complete operation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class CompleteRunOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Complete Run Operation
                CompleteRunOperation200Response result = apiInstance.CompleteRunOperation(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.CompleteRunOperation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompleteRunOperationWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete Run Operation
    ApiResponse<CompleteRunOperation200Response> response = apiInstance.CompleteRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.CompleteRunOperationWithHttpInfo: " + e.Message);
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

[**CompleteRunOperation200Response**](CompleteRunOperation200Response.md)

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

<a id="deleteattachment"></a>

# **DeleteAttachment**

> void DeleteAttachment (string productionOrderAttachmentID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Delete Attachment

-   Method will delete Production Order attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class DeleteAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productionOrderAttachmentID = "productionOrderAttachmentID_example";  // string | Identifier of a Production Order Attachment
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Delete Attachment
                apiInstance.DeleteAttachment(productionOrderAttachmentID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.DeleteAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAttachmentWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Attachment
    apiInstance.DeleteAttachmentWithHttpInfo(productionOrderAttachmentID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.DeleteAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                            | Type        | Description                                 | Notes      |
| ------------------------------- | ----------- | ------------------------------------------- | ---------- |
| **productionOrderAttachmentID** | **string**  | Identifier of a Production Order Attachment |            |
| **apiAuthAccountid**            | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b   | [optional] |
| **apiAuthApplicationkey**       | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033   | [optional] |

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

<a id="getproductionorderattachments"></a>

# **GetProductionOrderAttachments**

> GetProductionOrderAttachments200Response GetProductionOrderAttachments (string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Get Production Order Attachments

-   Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class GetProductionOrderAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productionOrderID = "productionOrderID_example";  // string | Identifier of a Production Order Attachment
            var returnAttachmentsContent = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Get Production Order Attachments
                GetProductionOrderAttachments200Response result = apiInstance.GetProductionOrderAttachments(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionOrderAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductionOrderAttachmentsWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Production Order Attachments
    ApiResponse<GetProductionOrderAttachments200Response> response = apiInstance.GetProductionOrderAttachmentsWithHttpInfo(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.GetProductionOrderAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                 | Notes              |
| ---------------------------- | ----------- | ------------------------------------------- | ------------------ |
| **productionOrderID**        | **string**  | Identifier of a Production Order Attachment |                    |
| **returnAttachmentsContent** | **bool**    |                                             | [default to false] |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b   | [optional]         |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033   | [optional]         |

### Return type

[**GetProductionOrderAttachments200Response**](GetProductionOrderAttachments200Response.md)

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

<a id="getproductionorderreferencedata"></a>

# **GetProductionOrderReferenceData**

> GetProductionOrderReferenceData200Response GetProductionOrderReferenceData (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Get Production Order Reference Data

-   Method will return accumulated reference data useful for creating and updating production orders.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class GetProductionOrderReferenceDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Get Production Order Reference Data
                GetProductionOrderReferenceData200Response result = apiInstance.GetProductionOrderReferenceData(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.GetProductionOrderReferenceData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductionOrderReferenceDataWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Production Order Reference Data
    ApiResponse<GetProductionOrderReferenceData200Response> response = apiInstance.GetProductionOrderReferenceDataWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.GetProductionOrderReferenceDataWithHttpInfo: " + e.Message);
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

[**GetProductionOrderReferenceData200Response**](GetProductionOrderReferenceData200Response.md)

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

<a id="orderlistpglmtstssrchetc"></a>

# **OrderlistPgLmtStsSrchEtc**

> void OrderlistPgLmtStsSrchEtc (decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Returns Production Orders and Production Runs according to provided filters.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class OrderlistPgLmtStsSrchEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var page = 8.14D;  // decimal | Page (Default: 1)
            var limit = 8.14D;  // decimal | Specifies the page size for pagination. Default page size is 100 (Default: 100)
            var status = "status_example";  // string | Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)
            var search = "search_example";  // string | Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)
            var locationID = "locationID_example";  // string | Only return Production Orders that have LocationID equal to provided value (Default: not set)
            var requiredByDateFrom = "requiredByDateFrom_example";  // string | Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)
            var requiredByDateTo = "requiredByDateTo_example";  // string | Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)
            var completionDateFrom = "completionDateFrom_example";  // string | Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)
            var completionDateTo = "completionDateTo_example";  // string | Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)
            var sourceTaskID = "sourceTaskID_example";  // string | Only return Production Orders that are created as a result of execution a Sale Task with ID = SourceTaskID Default: not set)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.OrderlistPgLmtStsSrchEtc(page, limit, status, search, locationID, requiredByDateFrom, requiredByDateTo, completionDateFrom, completionDateTo, sourceTaskID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.OrderlistPgLmtStsSrchEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderlistPgLmtStsSrchEtcWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.OrderlistPgLmtStsSrchEtcWithHttpInfo(page, limit, status, search, locationID, requiredByDateFrom, requiredByDateTo, completionDateFrom, completionDateTo, sourceTaskID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.OrderlistPgLmtStsSrchEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                                                                                                             | Notes      |
| ------------------------- | ----------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------- |
| **page**                  | **decimal** | Page (Default: 1)                                                                                                                                                       |            |
| **limit**                 | **decimal** | Specifies the page size for pagination. Default page size is 100 (Default: 100)                                                                                         |            |
| **status**                | **string**  | Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)                                                |            |
| **search**                | **string**  | Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set) |            |
| **locationID**            | **string**  | Only return Production Orders that have LocationID equal to provided value (Default: not set)                                                                           |            |
| **requiredByDateFrom**    | **string**  | Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)                                                          |            |
| **requiredByDateTo**      | **string**  | Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)                                                            |            |
| **completionDateFrom**    | **string**  | Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)                                                         |            |
| **completionDateTo**      | **string**  | Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)                                                            |            |
| **sourceTaskID**          | **string**  | Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)                                       |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                                                                                                               | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                                                                                                               | [optional] |

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

<a id="postattachment"></a>

# **PostAttachment**

> PutAttachment200Response PostAttachment (string productionOrderID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, PostAttachmentRequest? postAttachmentRequest = null)

Post Attachment

-   Method will add a Production Order attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PostAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productionOrderID = "productionOrderID_example";  // string | Identifier of a Production Order
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var postAttachmentRequest = new PostAttachmentRequest?(); // PostAttachmentRequest? |  (optional)

            try
            {
                // Post Attachment
                PutAttachment200Response result = apiInstance.PostAttachment(productionOrderID, apiAuthAccountid, apiAuthApplicationkey, postAttachmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.PostAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAttachmentWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Post Attachment
    ApiResponse<PutAttachment200Response> response = apiInstance.PostAttachmentWithHttpInfo(productionOrderID, apiAuthAccountid, apiAuthApplicationkey, postAttachmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.PostAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                                    | Description                               | Notes      |
| ------------------------- | ------------------------------------------------------- | ----------------------------------------- | ---------- |
| **productionOrderID**     | **string**                                              | Identifier of a Production Order          |            |
| **apiAuthAccountid**      | **string?**                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **postAttachmentRequest** | [**PostAttachmentRequest?**](PostAttachmentRequest?.md) |                                           | [optional] |

### Return type

[**PutAttachment200Response**](PutAttachment200Response.md)

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

<a id="productionfactorycalendarpost"></a>

# **ProductionFactorycalendarPost**

> ProductionFactorycalendarPutRequest ProductionFactorycalendarPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = null)

POST

-   FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionFactorycalendarPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionFactorycalendarPutRequest = new ProductionFactorycalendarPutRequest?(); // ProductionFactorycalendarPutRequest? |  (optional)

            try
            {
                // POST
                ProductionFactorycalendarPutRequest result = apiInstance.ProductionFactorycalendarPost(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionFactorycalendarPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionFactorycalendarPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ProductionFactorycalendarPutRequest> response = apiInstance.ProductionFactorycalendarPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionFactorycalendarPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                    | Type                                                                                | Description                               | Notes      |
| --------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                    | **string?**                                                                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**               | **string?**                                                                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productionFactorycalendarPutRequest** | [**ProductionFactorycalendarPutRequest?**](ProductionFactorycalendarPutRequest?.md) |                                           | [optional] |

### Return type

[**ProductionFactorycalendarPutRequest**](ProductionFactorycalendarPutRequest.md)

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

<a id="productionfactorycalendarput"></a>

# **ProductionFactorycalendarPut**

> ProductionFactorycalendarPutRequest ProductionFactorycalendarPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = null)

PUT

-   FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported. + FactoryCalendarDays will only be overwritten when collection is not empty. + FactoryCalendarSpecialDays will be overwritten even when collection is empty.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionFactorycalendarPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionFactorycalendarPutRequest = new ProductionFactorycalendarPutRequest?(); // ProductionFactorycalendarPutRequest? |  (optional)

            try
            {
                // PUT
                ProductionFactorycalendarPutRequest result = apiInstance.ProductionFactorycalendarPut(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionFactorycalendarPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionFactorycalendarPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductionFactorycalendarPutRequest> response = apiInstance.ProductionFactorycalendarPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionFactorycalendarPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                    | Type                                                                                | Description                               | Notes      |
| --------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                    | **string?**                                                                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**               | **string?**                                                                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productionFactorycalendarPutRequest** | [**ProductionFactorycalendarPutRequest?**](ProductionFactorycalendarPutRequest?.md) |                                           | [optional] |

### Return type

[**ProductionFactorycalendarPutRequest**](ProductionFactorycalendarPutRequest.md)

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

<a id="productionfactorycalendaryearget"></a>

# **ProductionFactorycalendarYearGet**

> ProductionFactorycalendarPutRequest ProductionFactorycalendarYearGet (string year, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ProductionFactorycalendarYearGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var year = "year_example";  // string | The year of the Factory Calendar
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                ProductionFactorycalendarPutRequest result = apiInstance.ProductionFactorycalendarYearGet(year, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionFactorycalendarYearGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionFactorycalendarYearGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ProductionFactorycalendarPutRequest> response = apiInstance.ProductionFactorycalendarYearGetWithHttpInfo(year, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionFactorycalendarYearGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **year**                  | **string**  | The year of the Factory Calendar          |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**ProductionFactorycalendarPutRequest**](ProductionFactorycalendarPutRequest.md)

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

<a id="productionorderallowrecalculatedatesallowrecalculatecyclesandquantitiesput"></a>

# **ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut**

> ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut (bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = null)

PUT

-   Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var allowRecalculateDates = false;  // bool |  (default to false)
            var allowRecalculateCyclesAndQuantities = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = new ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest?(); // ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? |  (optional)

            try
            {
                // PUT
                ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response result = apiInstance.ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut(allowRecalculateDates, allowRecalculateCyclesAndQuantities, apiAuthAccountid, apiAuthApplicationkey, productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response> response = apiInstance.ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfo(allowRecalculateDates, allowRecalculateCyclesAndQuantities, apiAuthAccountid, apiAuthApplicationkey, productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                                                                  | Type                                                                                                                                                                            | Description                               | Notes              |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------- | ------------------ |
| **allowRecalculateDates**                                                             | **bool**                                                                                                                                                                        |                                           | [default to false] |
| **allowRecalculateCyclesAndQuantities**                                               | **bool**                                                                                                                                                                        |                                           | [default to false] |
| **apiAuthAccountid**                                                                  | **string?**                                                                                                                                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey**                                                             | **string?**                                                                                                                                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |
| **productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest** | [**ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest?**](ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest?.md) |                                           | [optional]         |

### Return type

[**ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response**](ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response.md)

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

<a id="productionorderproductionorderidreturnattachmentscontentget"></a>

# **ProductionOrderProductionorderidReturnattachmentscontentGet**

> ProductionOrderProductionorderidReturnattachmentscontentGet200Response ProductionOrderProductionorderidReturnattachmentscontentGet (string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Returns Production Order and its nested items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionOrderProductionorderidReturnattachmentscontentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productionOrderID = "productionOrderID_example";  // string | Identifier of a Production Order
            var returnAttachmentsContent = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                ProductionOrderProductionorderidReturnattachmentscontentGet200Response result = apiInstance.ProductionOrderProductionorderidReturnattachmentscontentGet(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionOrderProductionorderidReturnattachmentscontentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ProductionOrderProductionorderidReturnattachmentscontentGet200Response> response = apiInstance.ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfo(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                               | Notes              |
| ---------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **productionOrderID**        | **string**  | Identifier of a Production Order          |                    |
| **returnAttachmentsContent** | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

### Return type

[**ProductionOrderProductionorderidReturnattachmentscontentGet200Response**](ProductionOrderProductionorderidReturnattachmentscontentGet200Response.md)

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

<a id="productionorderrecalculatedatespost"></a>

# **ProductionOrderRecalculatedatesPost**

> ProductionOrderRecalculatedatesPost200Response ProductionOrderRecalculatedatesPost (bool recalculateDates, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = null)

POST

-   Method will create new Production Order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionOrderRecalculatedatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var recalculateDates = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionOrderRecalculatedatesPostRequest = new ProductionOrderRecalculatedatesPostRequest?(); // ProductionOrderRecalculatedatesPostRequest? |  (optional)

            try
            {
                // POST
                ProductionOrderRecalculatedatesPost200Response result = apiInstance.ProductionOrderRecalculatedatesPost(recalculateDates, apiAuthAccountid, apiAuthApplicationkey, productionOrderRecalculatedatesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionOrderRecalculatedatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionOrderRecalculatedatesPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ProductionOrderRecalculatedatesPost200Response> response = apiInstance.ProductionOrderRecalculatedatesPostWithHttpInfo(recalculateDates, apiAuthAccountid, apiAuthApplicationkey, productionOrderRecalculatedatesPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionOrderRecalculatedatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                           | Type                                                                                              | Description                               | Notes              |
| ---------------------------------------------- | ------------------------------------------------------------------------------------------------- | ----------------------------------------- | ------------------ |
| **recalculateDates**                           | **bool**                                                                                          |                                           | [default to false] |
| **apiAuthAccountid**                           | **string?**                                                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey**                      | **string?**                                                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |
| **productionOrderRecalculatedatesPostRequest** | [**ProductionOrderRecalculatedatesPostRequest?**](ProductionOrderRecalculatedatesPostRequest?.md) |                                           | [optional]         |

### Return type

[**ProductionOrderRecalculatedatesPost200Response**](ProductionOrderRecalculatedatesPost200Response.md)

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

<a id="productionorderrunpost"></a>

# **ProductionOrderRunPost**

> void ProductionOrderRunPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionOrderRunPostRequest? productionOrderRunPostRequest = null)

POST

-   Method will create new Runs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionOrderRunPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionOrderRunPostRequest = new ProductionOrderRunPostRequest?(); // ProductionOrderRunPostRequest? |  (optional)

            try
            {
                // POST
                apiInstance.ProductionOrderRunPost(apiAuthAccountid, apiAuthApplicationkey, productionOrderRunPostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionOrderRunPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionOrderRunPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    apiInstance.ProductionOrderRunPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionOrderRunPostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionOrderRunPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                              | Type                                                                    | Description                               | Notes      |
| --------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**              | **string?**                                                             | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**         | **string?**                                                             | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productionOrderRunPostRequest** | [**ProductionOrderRunPostRequest?**](ProductionOrderRunPostRequest?.md) |                                           | [optional] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

-   **Content-Type**: application/json
-   **Accept**: Not defined

### HTTP response details

| Status code | Description | Response headers |
| ----------- | ----------- | ---------------- |
| **200**     | OK          | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productionorderrunproductionorderidincludeattachmentcontentget"></a>

# **ProductionOrderRunProductionorderidIncludeattachmentcontentGet**

> void ProductionOrderRunProductionorderidIncludeattachmentcontentGet (string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Method will return all Runs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionOrderRunProductionorderidIncludeattachmentcontentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productionOrderID = "productionOrderID_example";  // string | Production Order identifier
            var includeAttachmentContent = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.ProductionOrderRunProductionorderidIncludeattachmentcontentGet(productionOrderID, includeAttachmentContent, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionOrderRunProductionorderidIncludeattachmentcontentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfo(productionOrderID, includeAttachmentContent, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                               | Notes              |
| ---------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **productionOrderID**        | **string**  | Production Order identifier               |                    |
| **includeAttachmentContent** | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

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

<a id="productionorderrunproductionorderidincreaseorderquantityput"></a>

# **ProductionOrderRunProductionorderidIncreaseorderquantityPut**

> void ProductionOrderRunProductionorderidIncreaseorderquantityPut (string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

PUT

-   Method will update Run.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionOrderRunProductionorderidIncreaseorderquantityPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productionOrderID = "productionOrderID_example";  // string | Production Order identifier
            var increaseOrderQuantity = true;  // bool | Will increase order quantity if sum all run's quantity more then order quantity.
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // PUT
                apiInstance.ProductionOrderRunProductionorderidIncreaseorderquantityPut(productionOrderID, increaseOrderQuantity, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionOrderRunProductionorderidIncreaseorderquantityPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    apiInstance.ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfo(productionOrderID, increaseOrderQuantity, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                                          | Notes      |
| ------------------------- | ----------- | ------------------------------------------------------------------------------------ | ---------- |
| **productionOrderID**     | **string**  | Production Order identifier                                                          |            |
| **increaseOrderQuantity** | **bool**    | Will increase order quantity if sum all run&#39;s quantity more then order quantity. |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                                            | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                                            | [optional] |

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

<a id="productionproductionbompost"></a>

# **ProductionProductionbomPost**

> ProductionProductionbomPost200Response ProductionProductionbomPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionProductionbomPostRequest? productionProductionbomPostRequest = null)

POST

-   Method will create new Production BOM(s) for specified product family. Please set the 'OverwriteExistingProductionBOM' flag to true if the existing Production BOM needs to be replaced.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionProductionbomPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionProductionbomPostRequest = new ProductionProductionbomPostRequest?(); // ProductionProductionbomPostRequest? |  (optional)

            try
            {
                // POST
                ProductionProductionbomPost200Response result = apiInstance.ProductionProductionbomPost(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionProductionbomPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionProductionbomPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ProductionProductionbomPost200Response> response = apiInstance.ProductionProductionbomPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionProductionbomPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                   | Type                                                                              | Description                               | Notes      |
| -------------------------------------- | --------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                   | **string?**                                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**              | **string?**                                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productionProductionbomPostRequest** | [**ProductionProductionbomPostRequest?**](ProductionProductionbomPostRequest?.md) |                                           | [optional] |

### Return type

[**ProductionProductionbomPost200Response**](ProductionProductionbomPost200Response.md)

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

<a id="productionproductionbomproductfamilyidbomiddelete"></a>

# **ProductionProductionbomProductfamilyidBomidDelete**

> void ProductionProductionbomProductfamilyidBomidDelete (string productFamilyID, string BOMID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   Method will delete specified Production BOM of specified product family.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionProductionbomProductfamilyidBomidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productFamilyID = "productFamilyID_example";  // string | Identifier of a Product Family whose Production BOMs are to be deleted
            var BOMID = "BOMID_example";  // string | Identifier of a Production BOM to be deleted
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                apiInstance.ProductionProductionbomProductfamilyidBomidDelete(productFamilyID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductfamilyidBomidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    apiInstance.ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfo(productFamilyID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                            | Notes      |
| ------------------------- | ----------- | ---------------------------------------------------------------------- | ---------- |
| **productFamilyID**       | **string**  | Identifier of a Product Family whose Production BOMs are to be deleted |            |
| **BOMID**                 | **string**  | Identifier of a Production BOM to be deleted                           |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                              | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                              | [optional] |

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

<a id="productionproductionbomproductfamilyidreturnattachmentscontentget"></a>

# **ProductionProductionbomProductfamilyidReturnattachmentscontentGet**

> ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response ProductionProductionbomProductfamilyidReturnattachmentscontentGet (string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Method will return all Production BOMs of specified product family.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionProductionbomProductfamilyidReturnattachmentscontentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productFamilyID = "productFamilyID_example";  // string | Identifier of the Product Family to return Production BOMs for
            var returnAttachmentsContent = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response result = apiInstance.ProductionProductionbomProductfamilyidReturnattachmentscontentGet(productFamilyID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductfamilyidReturnattachmentscontentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response> response = apiInstance.ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfo(productFamilyID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                                    | Notes              |
| ---------------------------- | ----------- | -------------------------------------------------------------- | ------------------ |
| **productFamilyID**          | **string**  | Identifier of the Product Family to return Production BOMs for |                    |
| **returnAttachmentsContent** | **bool**    |                                                                | [default to false] |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                      | [optional]         |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                      | [optional]         |

### Return type

[**ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response**](ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response.md)

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

<a id="productionproductionbomproductidbomiddelete"></a>

# **ProductionProductionbomProductidBomidDelete**

> void ProductionProductionbomProductidBomidDelete (string productID, string BOMID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   Method will delete specified Production BOM of specified product.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionProductionbomProductidBomidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productID = "productID_example";  // string | Identifier of the Product whose Production BOMs will be deleted
            var BOMID = "BOMID_example";  // string | Identifier of a Product BOM to be deleted
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                apiInstance.ProductionProductionbomProductidBomidDelete(productID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductidBomidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionProductionbomProductidBomidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    apiInstance.ProductionProductionbomProductidBomidDeleteWithHttpInfo(productID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductidBomidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                     | Notes      |
| ------------------------- | ----------- | --------------------------------------------------------------- | ---------- |
| **productID**             | **string**  | Identifier of the Product whose Production BOMs will be deleted |            |
| **BOMID**                 | **string**  | Identifier of a Product BOM to be deleted                       |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                       | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                       | [optional] |

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
| **204**     | No Content  | -                |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="productionproductionbomproductidreturnattachmentscontentget"></a>

# **ProductionProductionbomProductidReturnattachmentscontentGet**

> ProductionProductionbomProductidReturnattachmentscontentGet200Response ProductionProductionbomProductidReturnattachmentscontentGet (string productID, bool returnAttachmentsContent, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Method will return all Production BOMs of specified product.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionProductionbomProductidReturnattachmentscontentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productID = "productID_example";  // string | Identifier of the Product to return Production BOMs for
            var returnAttachmentsContent = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                ProductionProductionbomProductidReturnattachmentscontentGet200Response result = apiInstance.ProductionProductionbomProductidReturnattachmentscontentGet(productID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductidReturnattachmentscontentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<ProductionProductionbomProductidReturnattachmentscontentGet200Response> response = apiInstance.ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfo(productID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type        | Description                                             | Notes              |
| ---------------------------- | ----------- | ------------------------------------------------------- | ------------------ |
| **productID**                | **string**  | Identifier of the Product to return Production BOMs for |                    |
| **returnAttachmentsContent** | **bool**    |                                                         | [default to false] |
| **apiAuthAccountid**         | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b               | [optional]         |
| **apiAuthApplicationkey**    | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033               | [optional]         |

### Return type

[**ProductionProductionbomProductidReturnattachmentscontentGet200Response**](ProductionProductionbomProductidReturnattachmentscontentGet200Response.md)

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

<a id="productionproductionbomput"></a>

# **ProductionProductionbomPut**

> ProductionProductionbomPut200Response ProductionProductionbomPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionProductionbomPutRequest? productionProductionbomPutRequest = null)

PUT

-   Method will update Production BOM for specified product family.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionProductionbomPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionProductionbomPutRequest = new ProductionProductionbomPutRequest?(); // ProductionProductionbomPutRequest? |  (optional)

            try
            {
                // PUT
                ProductionProductionbomPut200Response result = apiInstance.ProductionProductionbomPut(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionProductionbomPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionProductionbomPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductionProductionbomPut200Response> response = apiInstance.ProductionProductionbomPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionProductionbomPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                  | Type                                                                            | Description                               | Notes      |
| ------------------------------------- | ------------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                  | **string?**                                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**             | **string?**                                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productionProductionbomPutRequest** | [**ProductionProductionbomPutRequest?**](ProductionProductionbomPutRequest?.md) |                                           | [optional] |

### Return type

[**ProductionProductionbomPut200Response**](ProductionProductionbomPut200Response.md)

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

<a id="productionresourcepost"></a>

# **ProductionResourcePost**

> void ProductionResourcePost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

POST

-   ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionResourcePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                apiInstance.ProductionResourcePost(apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionResourcePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionResourcePostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    apiInstance.ProductionResourcePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionResourcePostWithHttpInfo: " + e.Message);
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

<a id="productionresourceput"></a>

# **ProductionResourcePut**

> ProductionResourcePutRequest ProductionResourcePut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionResourcePutRequest? productionResourcePutRequest = null)

PUT

-   ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionResourcePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionResourcePutRequest = new ProductionResourcePutRequest?(); // ProductionResourcePutRequest? |  (optional)

            try
            {
                // PUT
                ProductionResourcePutRequest result = apiInstance.ProductionResourcePut(apiAuthAccountid, apiAuthApplicationkey, productionResourcePutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionResourcePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionResourcePutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductionResourcePutRequest> response = apiInstance.ProductionResourcePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionResourcePutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionResourcePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                             | Type                                                                  | Description                               | Notes      |
| -------------------------------- | --------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**             | **string?**                                                           | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**        | **string?**                                                           | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productionResourcePutRequest** | [**ProductionResourcePutRequest?**](ProductionResourcePutRequest?.md) |                                           | [optional] |

### Return type

[**ProductionResourcePutRequest**](ProductionResourcePutRequest.md)

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

<a id="productionresourceresourceiddelete"></a>

# **ProductionResourceResourceidDelete**

> ProductionResourcePutRequest ProductionResourceResourceidDelete (string resourceID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ProductionResourceResourceidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var resourceID = "resourceID_example";  // string | Identifier of Resource
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                ProductionResourcePutRequest result = apiInstance.ProductionResourceResourceidDelete(resourceID, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionResourceResourceidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionResourceResourceidDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<ProductionResourcePutRequest> response = apiInstance.ProductionResourceResourceidDeleteWithHttpInfo(resourceID, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionResourceResourceidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **resourceID**            | **string**  | Identifier of Resource                    |            |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |

### Return type

[**ProductionResourcePutRequest**](ProductionResourcePutRequest.md)

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

<a id="productionresourceresourceidincludeattachmentsget"></a>

# **ProductionResourceResourceidIncludeattachmentsGet**

> void ProductionResourceResourceidIncludeattachmentsGet (string resourceID, bool includeAttachments, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class ProductionResourceResourceidIncludeattachmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var resourceID = "resourceID_example";  // string | Identifier of Resource
            var includeAttachments = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.ProductionResourceResourceidIncludeattachmentsGet(resourceID, includeAttachments, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionResourceResourceidIncludeattachmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionResourceResourceidIncludeattachmentsGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.ProductionResourceResourceidIncludeattachmentsGetWithHttpInfo(resourceID, includeAttachments, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionResourceResourceidIncludeattachmentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes              |
| ------------------------- | ----------- | ----------------------------------------- | ------------------ |
| **resourceID**            | **string**  | Identifier of Resource                    |                    |
| **includeAttachments**    | **bool**    |                                           | [default to false] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]         |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]         |

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

<a id="productionresourcelistpglmtnameonlyactiveget"></a>

# **ProductionResourcelistPgLmtNameOnlyactiveGet**

> void ProductionResourcelistPgLmtNameOnlyactiveGet (decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Method will return all resources.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionResourcelistPgLmtNameOnlyactiveGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var name = "name_example";  // string | Only return Resources that start with the specific Name or Code
            var onlyActive = true;  // bool |  (default to true)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.ProductionResourcelistPgLmtNameOnlyactiveGet(page, limit, name, onlyActive, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionResourcelistPgLmtNameOnlyactiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfo(page, limit, name, onlyActive, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                                     | Notes             |
| ------------------------- | ----------- | --------------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                                 | [default to 1M]   |
| **limit**                 | **decimal** |                                                                 | [default to 100M] |
| **name**                  | **string**  | Only return Resources that start with the specific Name or Code |                   |
| **onlyActive**            | **bool**    |                                                                 | [default to true] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                       | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                       | [optional]        |

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

<a id="productionsuspendreasonpglmtworkcenteridget"></a>

# **ProductionSuspendreasonPgLmtWorkcenteridGet**

> void ProductionSuspendreasonPgLmtWorkcenteridGet (decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Method will return all suspend reasons.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionSuspendreasonPgLmtWorkcenteridGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var workcenterID = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.ProductionSuspendreasonPgLmtWorkcenteridGet(page, limit, workcenterID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionSuspendreasonPgLmtWorkcenteridGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfo(page, limit, workcenterID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes                         |
| ------------------------- | ----------- | ----------------------------------------- | ----------------------------- |
| **page**                  | **decimal** |                                           | [default to 1M]               |
| **limit**                 | **decimal** |                                           | [default to 100M]             |
| **workcenterID**          | **string**  |                                           | [default to &quot;null&quot;] |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]                    |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]                    |

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

<a id="productionsuspendreasonput"></a>

# **ProductionSuspendreasonPut**

> ProductionSuspendreasonPut200Response ProductionSuspendreasonPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

PUT

-   Workcenters do not support modifying. Only creation and deletion. ### Available Fields for SuspendReason | Property | Type | Length | Required |Notes | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | `SuspendReasonID` | Guid | | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | `Reason` | String | | Yes* | Only for new entity | | `Workcenters` | Guid Array | | | |

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionSuspendreasonPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // PUT
                ProductionSuspendreasonPut200Response result = apiInstance.ProductionSuspendreasonPut(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionSuspendreasonPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionSuspendreasonPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductionSuspendreasonPut200Response> response = apiInstance.ProductionSuspendreasonPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionSuspendreasonPutWithHttpInfo: " + e.Message);
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

[**ProductionSuspendreasonPut200Response**](ProductionSuspendreasonPut200Response.md)

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

<a id="productionworkcenterspglmtnameget"></a>

# **ProductionWorkcentersPgLmtNameGet**

> void ProductionWorkcentersPgLmtNameGet (decimal page, decimal limit, string name, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

-   Method will return all workcenters.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionWorkcentersPgLmtNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var name = "name_example";  // string | Only return WorkCenters that start with the specific Name
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // GET
                apiInstance.ProductionWorkcentersPgLmtNameGet(page, limit, name, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersPgLmtNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionWorkcentersPgLmtNameGetWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    apiInstance.ProductionWorkcentersPgLmtNameGetWithHttpInfo(page, limit, name, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersPgLmtNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                                               | Notes             |
| ------------------------- | ----------- | --------------------------------------------------------- | ----------------- |
| **page**                  | **decimal** |                                                           | [default to 1M]   |
| **limit**                 | **decimal** |                                                           | [default to 100M] |
| **name**                  | **string**  | Only return WorkCenters that start with the specific Name |                   |
| **apiAuthAccountid**      | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b                 | [optional]        |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033                 | [optional]        |

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

<a id="productionworkcenterspost"></a>

# **ProductionWorkcentersPost**

> ProductionWorkcentersPost200Response ProductionWorkcentersPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

POST

-   Work center locations will be created.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionWorkcentersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // POST
                ProductionWorkcentersPost200Response result = apiInstance.ProductionWorkcentersPost(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionWorkcentersPostWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<ProductionWorkcentersPost200Response> response = apiInstance.ProductionWorkcentersPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersPostWithHttpInfo: " + e.Message);
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

[**ProductionWorkcentersPost200Response**](ProductionWorkcentersPost200Response.md)

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

<a id="productionworkcentersput"></a>

# **ProductionWorkcentersPut**

> ProductionWorkcentersPut200Response ProductionWorkcentersPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = null)

PUT

-   If work center location does not exist, it will be created. If work center location exists, it will be updated.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionWorkcentersPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var productionWorkcentersPutRequest = new ProductionWorkcentersPutRequest?(); // ProductionWorkcentersPutRequest? |  (optional)

            try
            {
                // PUT
                ProductionWorkcentersPut200Response result = apiInstance.ProductionWorkcentersPut(apiAuthAccountid, apiAuthApplicationkey, productionWorkcentersPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionWorkcentersPutWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<ProductionWorkcentersPut200Response> response = apiInstance.ProductionWorkcentersPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionWorkcentersPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                                | Type                                                                        | Description                               | Notes      |
| ----------------------------------- | --------------------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**                | **string?**                                                                 | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**           | **string?**                                                                 | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **productionWorkcentersPutRequest** | [**ProductionWorkcentersPutRequest?**](ProductionWorkcentersPutRequest?.md) |                                           | [optional] |

### Return type

[**ProductionWorkcentersPut200Response**](ProductionWorkcentersPut200Response.md)

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

<a id="productionworkcentersworkcenteriddelete"></a>

# **ProductionWorkcentersWorkcenteridDelete**

> void ProductionWorkcentersWorkcenteridDelete (string workCenterId, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

-   Method will delete workcenter with specified WorkCenterId if it exists.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ProductionWorkcentersWorkcenteridDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var workCenterId = "workCenterId_example";  // string | Identifier of WorkCenter to delete
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // DELETE
                apiInstance.ProductionWorkcentersWorkcenteridDelete(workCenterId, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersWorkcenteridDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductionWorkcentersWorkcenteridDeleteWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    apiInstance.ProductionWorkcentersWorkcenteridDeleteWithHttpInfo(workCenterId, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ProductionWorkcentersWorkcenteridDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **workCenterId**          | **string**  | Identifier of WorkCenter to delete        |            |
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

<a id="putattachment"></a>

# **PutAttachment**

> PutAttachment200Response PutAttachment (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Put Attachment

-   Method allows to update IsProcessed field of Production Order attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class PutAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Put Attachment
                PutAttachment200Response result = apiInstance.PutAttachment(apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.PutAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutAttachmentWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Put Attachment
    ApiResponse<PutAttachment200Response> response = apiInstance.PutAttachmentWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.PutAttachmentWithHttpInfo: " + e.Message);
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

[**PutAttachment200Response**](PutAttachment200Response.md)

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

<a id="release"></a>

# **Release**

> Release200Response Release (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ReleaseRequest? releaseRequest = null)

Release

-   Method will release Production Order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var releaseRequest = new ReleaseRequest?(); // ReleaseRequest? |  (optional)

            try
            {
                // Release
                Release200Response result = apiInstance.Release(apiAuthAccountid, apiAuthApplicationkey, releaseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.Release: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReleaseWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Release
    ApiResponse<Release200Response> response = apiInstance.ReleaseWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, releaseRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ReleaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                      | Description                               | Notes      |
| ------------------------- | ----------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                               | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                               | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **releaseRequest**        | [**ReleaseRequest?**](ReleaseRequest?.md) |                                           | [optional] |

### Return type

[**Release200Response**](Release200Response.md)

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

<a id="resumerunoperation"></a>

# **ResumeRunOperation**

> ResumeRunOperation200Response ResumeRunOperation (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, ResumeRunOperationRequest? resumeRunOperationRequest = null)

Resume Run Operation

-   Method will resume operation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class ResumeRunOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var resumeRunOperationRequest = new ResumeRunOperationRequest?(); // ResumeRunOperationRequest? |  (optional)

            try
            {
                // Resume Run Operation
                ResumeRunOperation200Response result = apiInstance.ResumeRunOperation(apiAuthAccountid, apiAuthApplicationkey, resumeRunOperationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.ResumeRunOperation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResumeRunOperationWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resume Run Operation
    ApiResponse<ResumeRunOperation200Response> response = apiInstance.ResumeRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, resumeRunOperationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.ResumeRunOperationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                          | Type                                                            | Description                               | Notes      |
| ----------------------------- | --------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**          | **string?**                                                     | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**     | **string?**                                                     | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **resumeRunOperationRequest** | [**ResumeRunOperationRequest?**](ResumeRunOperationRequest?.md) |                                           | [optional] |

### Return type

[**ResumeRunOperation200Response**](ResumeRunOperation200Response.md)

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

<a id="startrunoperation"></a>

# **StartRunOperation**

> StartRunOperation200Response StartRunOperation (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, StartRunOperationRequest? startRunOperationRequest = null)

Start Run Operation

-   Method will start operation. \"InputProducts\" - (optional) is used only if we want to send specific quantity or batch for input products.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class StartRunOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var startRunOperationRequest = new StartRunOperationRequest?(); // StartRunOperationRequest? |  (optional)

            try
            {
                // Start Run Operation
                StartRunOperation200Response result = apiInstance.StartRunOperation(apiAuthAccountid, apiAuthApplicationkey, startRunOperationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.StartRunOperation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartRunOperationWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start Run Operation
    ApiResponse<StartRunOperation200Response> response = apiInstance.StartRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, startRunOperationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.StartRunOperationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                         | Type                                                          | Description                               | Notes      |
| ---------------------------- | ------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**         | **string?**                                                   | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**    | **string?**                                                   | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **startRunOperationRequest** | [**StartRunOperationRequest?**](StartRunOperationRequest?.md) |                                           | [optional] |

### Return type

[**StartRunOperation200Response**](StartRunOperation200Response.md)

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

<a id="suspendrunoperation"></a>

# **SuspendRunOperation**

> SuspendRunOperation200Response SuspendRunOperation (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, SuspendRunOperationRequest? suspendRunOperationRequest = null)

Suspend Run Operation

-   Method will suspend operation.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class SuspendRunOperationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var suspendRunOperationRequest = new SuspendRunOperationRequest?(); // SuspendRunOperationRequest? |  (optional)

            try
            {
                // Suspend Run Operation
                SuspendRunOperation200Response result = apiInstance.SuspendRunOperation(apiAuthAccountid, apiAuthApplicationkey, suspendRunOperationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.SuspendRunOperation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuspendRunOperationWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Suspend Run Operation
    ApiResponse<SuspendRunOperation200Response> response = apiInstance.SuspendRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, suspendRunOperationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.SuspendRunOperationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                           | Type                                                              | Description                               | Notes      |
| ------------------------------ | ----------------------------------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**           | **string?**                                                       | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey**      | **string?**                                                       | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **suspendRunOperationRequest** | [**SuspendRunOperationRequest?**](SuspendRunOperationRequest?.md) |                                           | [optional] |

### Return type

[**SuspendRunOperation200Response**](SuspendRunOperation200Response.md)

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

<a id="undo"></a>

# **Undo**

> Undo200Response Undo (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, UndoRequest? undoRequest = null)

Undo

-   Method will undo Production Order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class UndoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var undoRequest = new UndoRequest?(); // UndoRequest? |  (optional)

            try
            {
                // Undo
                Undo200Response result = apiInstance.Undo(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.Undo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UndoWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Undo
    ApiResponse<Undo200Response> response = apiInstance.UndoWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.UndoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                | Description                               | Notes      |
| ------------------------- | ----------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                         | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                         | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **undoRequest**           | [**UndoRequest?**](UndoRequest?.md) |                                           | [optional] |

### Return type

[**Undo200Response**](Undo200Response.md)

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

<a id="undorun"></a>

# **UndoRun**

> UndoRun200Response UndoRun (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, UndoRunRequest? undoRunRequest = null)

Undo Run

-   Method will undo Run.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class UndoRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var undoRunRequest = new UndoRunRequest?(); // UndoRunRequest? |  (optional)

            try
            {
                // Undo Run
                UndoRun200Response result = apiInstance.UndoRun(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.UndoRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UndoRunWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Undo Run
    ApiResponse<UndoRun200Response> response = apiInstance.UndoRunWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.UndoRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                      | Description                               | Notes      |
| ------------------------- | ----------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                               | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                               | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **undoRunRequest**        | [**UndoRunRequest?**](UndoRunRequest?.md) |                                           | [optional] |

### Return type

[**UndoRun200Response**](UndoRun200Response.md)

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

<a id="updatemanualjournals"></a>

# **UpdateManualJournals**

> void UpdateManualJournals (string productionOrderID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

Update Manual Journals

-   Method will create or update Manual Journals of Run.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class UpdateManualJournalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var productionOrderID = "productionOrderID_example";  // string | Production Order identifier
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)

            try
            {
                // Update Manual Journals
                apiInstance.UpdateManualJournals(productionOrderID, apiAuthAccountid, apiAuthApplicationkey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.UpdateManualJournals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateManualJournalsWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Manual Journals
    apiInstance.UpdateManualJournalsWithHttpInfo(productionOrderID, apiAuthAccountid, apiAuthApplicationkey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.UpdateManualJournalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type        | Description                               | Notes      |
| ------------------------- | ----------- | ----------------------------------------- | ---------- |
| **productionOrderID**     | **string**  | Production Order identifier               |            |
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

<a id="voidrun"></a>

# **VoidRun**

> UndoRun200Response VoidRun (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, UndoRunRequest? undoRunRequest = null)

Void Run

-   Method will void Run.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CIN7.DearInventory.Api;
using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;

namespace Example
{
    public class VoidRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new ProductionApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)
            var undoRunRequest = new UndoRunRequest?(); // UndoRunRequest? |  (optional)

            try
            {
                // Void Run
                UndoRun200Response result = apiInstance.VoidRun(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductionApi.VoidRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoidRunWithHttpInfo variant

This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Void Run
    ApiResponse<UndoRun200Response> response = apiInstance.VoidRunWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductionApi.VoidRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name                      | Type                                      | Description                               | Notes      |
| ------------------------- | ----------------------------------------- | ----------------------------------------- | ---------- |
| **apiAuthAccountid**      | **string?**                               | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional] |
| **apiAuthApplicationkey** | **string?**                               | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional] |
| **undoRunRequest**        | [**UndoRunRequest?**](UndoRunRequest?.md) |                                           | [optional] |

### Return type

[**UndoRun200Response**](UndoRun200Response.md)

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
