/*
 * Cin7 Core Developer Portal
 *
 * ## API introduction  Cin7 Core Inventory API is part of Cin7 Core Inventory web application at https://inventory.dearsystems.com.  <b>You will need to:</b>  + Create an account there before you can use the API.  + Trial accounts are also allowed to access the API.  The API URL is https://inventory.dearsystems.com/externalapi/v2/. To call any API endpoint (method) you must append the endpoint name and parameters to the API URL. eg: https://inventory.dearsystems.com/externalapi/v2/me  <i>Note: The API accepts only JSON data format.</i>  Never assume that the API is actually online at any time. Always queue requests to the API so that you can retry the request in the event of a network failure: even if our server is up 24/7 forever, the network will not be. Consider what happens in the case of a network interruption, eg the cable gets cut by road workers yet again. You should always plan to add all requests to a queue so that they can be tried again in the event of any failure.  Full documentation of each endpoint is available on that endpoint's help page. This includes the operations supported and the full list of available fields with:  + Name  + Type  + Length  + Required values  Use our API Explorer to see examples of each data object.  Cin7 Core Inventory API is a subset of the functionality available through Cin7 Core Inventory UI - check the API documentation to see if the functionality you require is available in the API.  In the event of errors, the API will return an appropriate HTML status code, and an error message. You will need to read both the status code and the error message to establish the cause. Typical error messages are shown on the API status codes page.  ## Connecting to the API  To use the API you will need your Cin7 Core Account ID and API Application key. These can be created on the API setup page inside Cin7 Core Inventory application: https://inventory.dearsystems.com/ExternalAPI.  Each company that you have access to in Cin7 Core Inventory will have a different Cin7 Core Account ID. You can have multiple API Applications created on the same Cin7 Core account. This allows you to link different applications/add-ons to Cin7 Core, since API limits are applied on per API Application basis.  Your Account ID and API Application Key are equivalent to a login and password. They must be kept secret and not shared in any way.  Each request to the API must include these two values sent as HTTP headers:  + api-auth-accountid - You must send your Account ID in this header.  + api-auth-applicationkey - You must send API Application Key in this header.  PHP sample:  ```PHP  $account_id = 'api-auth-accountid: youraccountid'; $application_key = 'api-auth-applicationkey: applicationkey'; $naked_dear_url = 'https://inventory.dearsystems.com/ExternalApi/v2/SaleList';  $data = array ('Page' => '1', 'Limit' => '100'); $data = http_build_query($data);  $ch = curl_init(); curl_setopt($ch, CURLOPT_URL,$naked_dear_url.\"?\".$data); //GET API CALL curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);  $headers = [ \"Content-type: application/json\", $account_id, $application_key ];  curl_setopt($ch, CURLOPT_HTTPHEADER, $headers); $server_output = curl_exec ($ch); curl_close ($ch);  print $server_output ;   ```  ## Pagination  <h4>What is Pagination?</h4>  Pagination is the process of dividing content into discrete pages.  The benefit of pagination is that it allows for faster response times to requests against large datasets like Customers, Products and Invoices, thus providing a more responsive and flexible API for your mission-critical applications.  Cin7 Core Inventory API currently uses pagination on the following endpoints:  + SaleList  + PurchaseList  + StockAdjustmentList  + StockTakeList  + StockTransferList  + Product  + Сategory  All remaining API endpoints do not support pagination.  <h4>Requesting a page</h4>  Pages are requested by adding page parameter to URL: https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}, where {endpoint} and {pagenumber} are placeholders.  For example, if you wanted to retrieve the 3rd page of 100 records from the Products endpoint we would write https://inventory.dearsystems.com/ExternalApi/v2/Product?page=3.  <h4>Page size</h4>  The default page size is 100 records, but is configurable by adding the desired page size in the URL querystring, https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}&limit={pagesize}.  The minimum page size is 1 and the maximum page size is 1000 records.  If you want to retrieve the 5th page of 200 ProductAvailability records (ie. 1001st to 1500th record) then you would use this URL: https://inventory.dearsystems.com/ExternalApi/v2/Product?page=5&limit=200.  <h4>Pagination info</h4>  In the endpoints that support Pagination additional parameter Total is returned with every API call response to provide information regarding how many records there are overall. Below is an example of this structure in JSON for Products endpoint.  { \"Products\":[{...}], \"Total\":41}  ## API Status Codes  |Status Code|Description| |:- -- --|- -- -- -- -- --| |`200 OK`|Operation was successful| |`204 No Content`|Operation was successful and there is no content to return| |`400 Bad Request`|The request was not in a correct form, or the posted data failed a validation test. Check the error returned to see what was wrong with the request.| |`403 Forbidden`|Method authentication failed| |`404 Not found`|Endpoint does not exist (eg using /Products instead of /Product)| |`405 Not allowed`|The method used is not allowed (eg PUT, DELETE)| |`500 Internal Server Error`|The object passed to the API could not be parsed or some unexpected error occurred in Cin7 Core while processing API request| |`503 Service Unavailable`|You reached 60 calls per minute API limit|  ## Date Format  All date fields in Cin7 Core API (including parameters) are in ISO 8601 format and specifying UTC date: yyyy-MM-ddTHH:mm:ss.fff     e.g. 2012-11-14T13:28:33.363  ## Previous API version  Previous API version's description is available here: http://support.dearsystems.com/solution/folders/1000134185
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using CIN7.DearInventory.Client;
using CIN7.DearInventory.Model;
using System;
using System.Collections.Generic;

namespace CIN7.DearInventory.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPurchaseApiSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseAwayPost200Response</returns>
        AdvancedPurchaseAwayPost200Response AdvancedPurchaseAwayPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseAwayPost200Response</returns>
        ApiResponse<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseAwayPost200Response</returns>
        AdvancedPurchaseAwayPost200Response AdvancedPurchaseAwayPurchaseidGet(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseAwayPost200Response</returns>
        ApiResponse<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPurchaseidGetWithHttpInfo(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseCreditnotePost200Response</returns>
        AdvancedPurchaseCreditnotePost200Response AdvancedPurchaseCreditnotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseCreditnotePost200Response</returns>
        ApiResponse<AdvancedPurchaseCreditnotePost200Response> AdvancedPurchaseCreditnotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response</returns>
        AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response</returns>
        ApiResponse<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response> AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfo(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseCreditnoteTaskidDelete200Response</returns>
        AdvancedPurchaseCreditnoteTaskidDelete200Response AdvancedPurchaseCreditnoteTaskidDelete(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseCreditnoteTaskidDelete200Response</returns>
        ApiResponse<AdvancedPurchaseCreditnoteTaskidDelete200Response> AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseIdCombineadditionalchargesGet200Response</returns>
        AdvancedPurchaseIdCombineadditionalchargesGet200Response AdvancedPurchaseIdCombineadditionalchargesGet(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseIdCombineadditionalchargesGet200Response</returns>
        ApiResponse<AdvancedPurchaseIdCombineadditionalchargesGet200Response> AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfo(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseIdVoidDelete200Response</returns>
        AdvancedPurchaseIdVoidDelete200Response AdvancedPurchaseIdVoidDelete(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseIdVoidDelete200Response</returns>
        ApiResponse<AdvancedPurchaseIdVoidDelete200Response> AdvancedPurchaseIdVoidDeleteWithHttpInfo(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseInvoicePost200Response</returns>
        AdvancedPurchaseInvoicePost200Response AdvancedPurchaseInvoicePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseInvoicePost200Response</returns>
        ApiResponse<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseInvoicePost200Response</returns>
        AdvancedPurchaseInvoicePost200Response AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseInvoicePost200Response</returns>
        ApiResponse<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfo(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseInvoiceTaskidVoidDelete200Response</returns>
        AdvancedPurchaseInvoiceTaskidVoidDelete200Response AdvancedPurchaseInvoiceTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseInvoiceTaskidVoidDelete200Response</returns>
        ApiResponse<AdvancedPurchaseInvoiceTaskidVoidDelete200Response> AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseManualjournalPost200Response</returns>
        AdvancedPurchaseManualjournalPost200Response AdvancedPurchaseManualjournalPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseManualjournalPost200Response</returns>
        ApiResponse<AdvancedPurchaseManualjournalPost200Response> AdvancedPurchaseManualjournalPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseManualjournalPurchaseidGet200Response</returns>
        AdvancedPurchaseManualjournalPurchaseidGet200Response AdvancedPurchaseManualjournalPurchaseidGet(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseManualjournalPurchaseidGet200Response</returns>
        ApiResponse<AdvancedPurchaseManualjournalPurchaseidGet200Response> AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfo(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePaymentPost200Response</returns>
        AdvancedPurchasePaymentPost200Response AdvancedPurchasePaymentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePaymentPost200Response</returns>
        ApiResponse<AdvancedPurchasePaymentPost200Response> AdvancedPurchasePaymentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePaymentPut200Response</returns>
        AdvancedPurchasePaymentPut200Response AdvancedPurchasePaymentPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePaymentPut200Response</returns>
        ApiResponse<AdvancedPurchasePaymentPut200Response> AdvancedPurchasePaymentPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePost200Response</returns>
        AdvancedPurchasePost200Response AdvancedPurchasePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePost200Response</returns>
        ApiResponse<AdvancedPurchasePost200Response> AdvancedPurchasePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePut200Response</returns>
        AdvancedPurchasePut200Response AdvancedPurchasePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePut200Response</returns>
        ApiResponse<AdvancedPurchasePut200Response> AdvancedPurchasePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockPut200Response</returns>
        AdvancedPurchaseStockPut200Response AdvancedPurchaseStockPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockPut200Response</returns>
        ApiResponse<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockPurchaseidGet200Response</returns>
        AdvancedPurchaseStockPurchaseidGet200Response AdvancedPurchaseStockPurchaseidGet(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockPurchaseidGet200Response</returns>
        ApiResponse<AdvancedPurchaseStockPurchaseidGet200Response> AdvancedPurchaseStockPurchaseidGetWithHttpInfo(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockPut200Response</returns>
        AdvancedPurchaseStockPut200Response AdvancedPurchaseStockPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockPut200Response</returns>
        ApiResponse<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockTaskidVoidDelete200Response</returns>
        AdvancedPurchaseStockTaskidVoidDelete200Response AdvancedPurchaseStockTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockTaskidVoidDelete200Response</returns>
        ApiResponse<AdvancedPurchaseStockTaskidVoidDelete200Response> AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchRequiredbyUpdatedsinceEtc200Response</returns>
        PgLmtSrchRequiredbyUpdatedsinceEtc200Response PgLmtSrchRequiredbyUpdatedsinceEtc(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchRequiredbyUpdatedsinceEtc200Response</returns>
        ApiResponse<PgLmtSrchRequiredbyUpdatedsinceEtc200Response> PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfo(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response</returns>
        PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response PgLmtSrchUpdatedsinceCreditnotestatusEtc(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response</returns>
        ApiResponse<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response> PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfo(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseAttachmentPost200Response</returns>
        PurchaseAttachmentPost200Response PurchaseAttachmentIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseAttachmentPost200Response</returns>
        ApiResponse<PurchaseAttachmentPost200Response> PurchaseAttachmentIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseAttachmentPost200Response</returns>
        PurchaseAttachmentPost200Response PurchaseAttachmentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseAttachmentPost200Response</returns>
        ApiResponse<PurchaseAttachmentPost200Response> PurchaseAttachmentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseAttachmentPost200Response</returns>
        PurchaseAttachmentPost200Response PurchaseAttachmentTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseAttachmentPost200Response</returns>
        ApiResponse<PurchaseAttachmentPost200Response> PurchaseAttachmentTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseCreditnotePost200Response</returns>
        PurchaseCreditnotePost200Response PurchaseCreditnotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseCreditnotePost200Response</returns>
        ApiResponse<PurchaseCreditnotePost200Response> PurchaseCreditnotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response</returns>
        PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response PurchaseCreditnoteTaskidCombineadditionalchargesGet(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response</returns>
        ApiResponse<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response> PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfo(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseIdCombineadditionalchargesGet200Response</returns>
        PurchaseIdCombineadditionalchargesGet200Response PurchaseIdCombineadditionalchargesGet(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseIdCombineadditionalchargesGet200Response</returns>
        ApiResponse<PurchaseIdCombineadditionalchargesGet200Response> PurchaseIdCombineadditionalchargesGetWithHttpInfo(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseIdVoidDelete200Response</returns>
        PurchaseIdVoidDelete200Response PurchaseIdVoidDelete(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseIdVoidDelete200Response</returns>
        ApiResponse<PurchaseIdVoidDelete200Response> PurchaseIdVoidDeleteWithHttpInfo(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseInvoicePost200Response</returns>
        PurchaseInvoicePost200Response PurchaseInvoicePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseInvoicePost200Response</returns>
        ApiResponse<PurchaseInvoicePost200Response> PurchaseInvoicePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseInvoiceTaskidCombineadditionalchargesGet200Response</returns>
        PurchaseInvoiceTaskidCombineadditionalchargesGet200Response PurchaseInvoiceTaskidCombineadditionalchargesGet(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseInvoiceTaskidCombineadditionalchargesGet200Response</returns>
        ApiResponse<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response> PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfo(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseManualjournalPost200Response</returns>
        PurchaseManualjournalPost200Response PurchaseManualjournalPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseManualjournalPost200Response</returns>
        ApiResponse<PurchaseManualjournalPost200Response> PurchaseManualjournalPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseManualjournalTaskidGet200Response</returns>
        PurchaseManualjournalTaskidGet200Response PurchaseManualjournalTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseManualjournalTaskidGet200Response</returns>
        ApiResponse<PurchaseManualjournalTaskidGet200Response> PurchaseManualjournalTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseOrderPost200Response</returns>
        PurchaseOrderPost200Response PurchaseOrderPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseOrderPost200Response</returns>
        ApiResponse<PurchaseOrderPost200Response> PurchaseOrderPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseOrderTaskidCombineadditionalchargesGet200Response</returns>
        PurchaseOrderTaskidCombineadditionalchargesGet200Response PurchaseOrderTaskidCombineadditionalchargesGet(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseOrderTaskidCombineadditionalchargesGet200Response</returns>
        ApiResponse<PurchaseOrderTaskidCombineadditionalchargesGet200Response> PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfo(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        MeAddressesIdDelete200Response PurchasePaymentIdallocationDelete(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        ApiResponse<MeAddressesIdDelete200Response> PurchasePaymentIdallocationDeleteWithHttpInfo(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchasePaymentPost200Response</returns>
        PurchasePaymentPost200Response PurchasePaymentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchasePaymentPost200Response</returns>
        ApiResponse<PurchasePaymentPost200Response> PurchasePaymentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;</returns>
        List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;</returns>
        ApiResponse<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfo(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePaymentPutRequest</returns>
        AdvancedPurchasePaymentPutRequest PurchasePaymentPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePaymentPutRequest</returns>
        ApiResponse<AdvancedPurchasePaymentPutRequest> PurchasePaymentPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;</returns>
        List<PurchasePaymentTaskidGet200ResponseInner> PurchasePaymentTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;</returns>
        ApiResponse<List<PurchasePaymentTaskidGet200ResponseInner>> PurchasePaymentTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchasePost200Response</returns>
        PurchasePost200Response PurchasePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchasePost200Response</returns>
        ApiResponse<PurchasePost200Response> PurchasePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchasePut200Response</returns>
        PurchasePut200Response PurchasePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchasePut200Response</returns>
        ApiResponse<PurchasePut200Response> PurchasePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseStockPost200Response</returns>
        PurchaseStockPost200Response PurchaseStockPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseStockPost200Response</returns>
        ApiResponse<PurchaseStockPost200Response> PurchaseStockPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseStockPostRequest</returns>
        PurchaseStockPostRequest PurchaseStockTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseStockPostRequest</returns>
        ApiResponse<PurchaseStockPostRequest> PurchaseStockTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPurchaseApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseAwayPost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseAwayPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseAwayPost200Response>> AdvancedPurchaseAwayPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseAwayPost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPurchaseidGetAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseAwayPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseAwayPost200Response>> AdvancedPurchaseAwayPurchaseidGetWithHttpInfoAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseCreditnotePost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseCreditnotePost200Response> AdvancedPurchaseCreditnotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseCreditnotePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseCreditnotePost200Response>> AdvancedPurchaseCreditnotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response> AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response>> AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfoAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseCreditnoteTaskidDelete200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseCreditnoteTaskidDelete200Response> AdvancedPurchaseCreditnoteTaskidDeleteAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseCreditnoteTaskidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseCreditnoteTaskidDelete200Response>> AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseIdCombineadditionalchargesGet200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseIdCombineadditionalchargesGet200Response> AdvancedPurchaseIdCombineadditionalchargesGetAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseIdCombineadditionalchargesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseIdCombineadditionalchargesGet200Response>> AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfoAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseIdVoidDelete200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseIdVoidDelete200Response> AdvancedPurchaseIdVoidDeleteAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseIdVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseIdVoidDelete200Response>> AdvancedPurchaseIdVoidDeleteWithHttpInfoAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseInvoicePost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseInvoicePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseInvoicePost200Response>> AdvancedPurchaseInvoicePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseInvoicePost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseInvoicePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseInvoicePost200Response>> AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfoAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseInvoiceTaskidVoidDelete200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseInvoiceTaskidVoidDelete200Response> AdvancedPurchaseInvoiceTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseInvoiceTaskidVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseInvoiceTaskidVoidDelete200Response>> AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseManualjournalPost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseManualjournalPost200Response> AdvancedPurchaseManualjournalPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseManualjournalPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseManualjournalPost200Response>> AdvancedPurchaseManualjournalPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseManualjournalPurchaseidGet200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseManualjournalPurchaseidGet200Response> AdvancedPurchaseManualjournalPurchaseidGetAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseManualjournalPurchaseidGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseManualjournalPurchaseidGet200Response>> AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfoAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePaymentPost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchasePaymentPost200Response> AdvancedPurchasePaymentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePaymentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePaymentPost200Response>> AdvancedPurchasePaymentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePaymentPut200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchasePaymentPut200Response> AdvancedPurchasePaymentPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePaymentPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePaymentPut200Response>> AdvancedPurchasePaymentPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePost200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchasePost200Response> AdvancedPurchasePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePost200Response>> AdvancedPurchasePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePut200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchasePut200Response> AdvancedPurchasePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePut200Response>> AdvancedPurchasePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockPut200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockPut200Response>> AdvancedPurchaseStockPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockPurchaseidGet200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseStockPurchaseidGet200Response> AdvancedPurchaseStockPurchaseidGetAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockPurchaseidGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockPurchaseidGet200Response>> AdvancedPurchaseStockPurchaseidGetWithHttpInfoAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockPut200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockPut200Response>> AdvancedPurchaseStockPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockTaskidVoidDelete200Response</returns>
        System.Threading.Tasks.Task<AdvancedPurchaseStockTaskidVoidDelete200Response> AdvancedPurchaseStockTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + DELETE not available for Simple Purchases
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockTaskidVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockTaskidVoidDelete200Response>> AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchRequiredbyUpdatedsinceEtc200Response</returns>
        System.Threading.Tasks.Task<PgLmtSrchRequiredbyUpdatedsinceEtc200Response> PgLmtSrchRequiredbyUpdatedsinceEtcAsync(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchRequiredbyUpdatedsinceEtc200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PgLmtSrchRequiredbyUpdatedsinceEtc200Response>> PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfoAsync(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response</returns>
        System.Threading.Tasks.Task<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response> PgLmtSrchUpdatedsinceCreditnotestatusEtcAsync(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response>> PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfoAsync(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseAttachmentPost200Response</returns>
        System.Threading.Tasks.Task<PurchaseAttachmentPost200Response> PurchaseAttachmentIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseAttachmentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseAttachmentPost200Response>> PurchaseAttachmentIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseAttachmentPost200Response</returns>
        System.Threading.Tasks.Task<PurchaseAttachmentPost200Response> PurchaseAttachmentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseAttachmentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseAttachmentPost200Response>> PurchaseAttachmentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseAttachmentPost200Response</returns>
        System.Threading.Tasks.Task<PurchaseAttachmentPost200Response> PurchaseAttachmentTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseAttachmentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseAttachmentPost200Response>> PurchaseAttachmentTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseCreditnotePost200Response</returns>
        System.Threading.Tasks.Task<PurchaseCreditnotePost200Response> PurchaseCreditnotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseCreditnotePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseCreditnotePost200Response>> PurchaseCreditnotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response</returns>
        System.Threading.Tasks.Task<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response> PurchaseCreditnoteTaskidCombineadditionalchargesGetAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response>> PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfoAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseIdCombineadditionalchargesGet200Response</returns>
        System.Threading.Tasks.Task<PurchaseIdCombineadditionalchargesGet200Response> PurchaseIdCombineadditionalchargesGetAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseIdCombineadditionalchargesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseIdCombineadditionalchargesGet200Response>> PurchaseIdCombineadditionalchargesGetWithHttpInfoAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseIdVoidDelete200Response</returns>
        System.Threading.Tasks.Task<PurchaseIdVoidDelete200Response> PurchaseIdVoidDeleteAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseIdVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseIdVoidDelete200Response>> PurchaseIdVoidDeleteWithHttpInfoAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseInvoicePost200Response</returns>
        System.Threading.Tasks.Task<PurchaseInvoicePost200Response> PurchaseInvoicePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseInvoicePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseInvoicePost200Response>> PurchaseInvoicePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseInvoiceTaskidCombineadditionalchargesGet200Response</returns>
        System.Threading.Tasks.Task<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response> PurchaseInvoiceTaskidCombineadditionalchargesGetAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseInvoiceTaskidCombineadditionalchargesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response>> PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfoAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseManualjournalPost200Response</returns>
        System.Threading.Tasks.Task<PurchaseManualjournalPost200Response> PurchaseManualjournalPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseManualjournalPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseManualjournalPost200Response>> PurchaseManualjournalPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseManualjournalTaskidGet200Response</returns>
        System.Threading.Tasks.Task<PurchaseManualjournalTaskidGet200Response> PurchaseManualjournalTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseManualjournalTaskidGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseManualjournalTaskidGet200Response>> PurchaseManualjournalTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseOrderPost200Response</returns>
        System.Threading.Tasks.Task<PurchaseOrderPost200Response> PurchaseOrderPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseOrderPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseOrderPost200Response>> PurchaseOrderPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseOrderTaskidCombineadditionalchargesGet200Response</returns>
        System.Threading.Tasks.Task<PurchaseOrderTaskidCombineadditionalchargesGet200Response> PurchaseOrderTaskidCombineadditionalchargesGetAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseOrderTaskidCombineadditionalchargesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseOrderTaskidCombineadditionalchargesGet200Response>> PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfoAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        System.Threading.Tasks.Task<MeAddressesIdDelete200Response> PurchasePaymentIdallocationDeleteAsync(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> PurchasePaymentIdallocationDeleteWithHttpInfoAsync(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchasePaymentPost200Response</returns>
        System.Threading.Tasks.Task<PurchasePaymentPost200Response> PurchasePaymentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchasePaymentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchasePaymentPost200Response>> PurchasePaymentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;</returns>
        System.Threading.Tasks.Task<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcAsync(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>>> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfoAsync(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePaymentPutRequest</returns>
        System.Threading.Tasks.Task<AdvancedPurchasePaymentPutRequest> PurchasePaymentPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePaymentPutRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePaymentPutRequest>> PurchasePaymentPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;</returns>
        System.Threading.Tasks.Task<List<PurchasePaymentTaskidGet200ResponseInner>> PurchasePaymentTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PurchasePaymentTaskidGet200ResponseInner>>> PurchasePaymentTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchasePost200Response</returns>
        System.Threading.Tasks.Task<PurchasePost200Response> PurchasePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchasePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchasePost200Response>> PurchasePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchasePut200Response</returns>
        System.Threading.Tasks.Task<PurchasePut200Response> PurchasePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchasePut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchasePut200Response>> PurchasePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseStockPost200Response</returns>
        System.Threading.Tasks.Task<PurchaseStockPost200Response> PurchaseStockPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseStockPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseStockPost200Response>> PurchaseStockPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseStockPostRequest</returns>
        System.Threading.Tasks.Task<PurchaseStockPostRequest> PurchaseStockTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseStockPostRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<PurchaseStockPostRequest>> PurchaseStockTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPurchaseApi : IPurchaseApiSync, IPurchaseApiAsync
    {
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PurchaseApi : IPurchaseApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PurchaseApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PurchaseApi(string basePath)
        {
            Configuration = DearInventory.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = DearInventory.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PurchaseApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DearInventory.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = DearInventory.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PurchaseApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DearInventory.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseAwayPost200Response</returns>
        public AdvancedPurchaseAwayPost200Response AdvancedPurchaseAwayPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseAwayPost200Response> localVarResponse = AdvancedPurchaseAwayPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseAwayPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseAwayPost200Response</returns>
        public ApiResponse<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseAwayPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseAwayPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<AdvancedPurchaseAwayPost200Response>("/advanced-purchase/put-away", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseAwayPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseAwayPost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseAwayPost200Response> localVarResponse = await AdvancedPurchaseAwayPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseAwayPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Put Away status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Put Away, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseAwayPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseAwayPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseAwayPost200Response>> AdvancedPurchaseAwayPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseAwayPostRequest? advancedPurchaseAwayPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseAwayPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseAwayPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<AdvancedPurchaseAwayPost200Response>("/advanced-purchase/put-away", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseAwayPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseAwayPost200Response</returns>
        public AdvancedPurchaseAwayPost200Response AdvancedPurchaseAwayPurchaseidGet(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseAwayPost200Response> localVarResponse = AdvancedPurchaseAwayPurchaseidGetWithHttpInfo(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseAwayPost200Response</returns>
        public ApiResponse<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPurchaseidGetWithHttpInfo(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseAwayPurchaseidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseAwayPurchaseidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<AdvancedPurchaseAwayPost200Response>("/advanced-purchase/put-away", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseAwayPurchaseidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseAwayPost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseAwayPost200Response> AdvancedPurchaseAwayPurchaseidGetAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseAwayPost200Response> localVarResponse = await AdvancedPurchaseAwayPurchaseidGetWithHttpInfoAsync(purchaseID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseAwayPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseAwayPost200Response>> AdvancedPurchaseAwayPurchaseidGetWithHttpInfoAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseAwayPurchaseidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseAwayPurchaseidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<AdvancedPurchaseAwayPost200Response>("/advanced-purchase/put-away", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseAwayPurchaseidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseCreditnotePost200Response</returns>
        public AdvancedPurchaseCreditnotePost200Response AdvancedPurchaseCreditnotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseCreditnotePost200Response> localVarResponse = AdvancedPurchaseCreditnotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseCreditnotePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseCreditnotePost200Response</returns>
        public ApiResponse<AdvancedPurchaseCreditnotePost200Response> AdvancedPurchaseCreditnotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseCreditnotePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseCreditnotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<AdvancedPurchaseCreditnotePost200Response>("/advanced-purchase/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseCreditnotePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseCreditnotePost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseCreditnotePost200Response> AdvancedPurchaseCreditnotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseCreditnotePost200Response> localVarResponse = await AdvancedPurchaseCreditnotePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseCreditnotePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseCreditnotePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseCreditnotePost200Response>> AdvancedPurchaseCreditnotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseCreditnotePostRequest? advancedPurchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseCreditnotePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseCreditnotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<AdvancedPurchaseCreditnotePost200Response>("/advanced-purchase/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseCreditnotePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response</returns>
        public AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response> localVarResponse = AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfo(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response</returns>
        public ApiResponse<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response> AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfo(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response>("/advanced-purchase/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response> AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response> localVarResponse = await AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfoAsync(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Credit Notes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response>> AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGetWithHttpInfoAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet200Response>("/advanced-purchase/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseCreditnotePurchaseidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseCreditnoteTaskidDelete200Response</returns>
        public AdvancedPurchaseCreditnoteTaskidDelete200Response AdvancedPurchaseCreditnoteTaskidDelete(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseCreditnoteTaskidDelete200Response> localVarResponse = AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseCreditnoteTaskidDelete200Response</returns>
        public ApiResponse<AdvancedPurchaseCreditnoteTaskidDelete200Response> AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->AdvancedPurchaseCreditnoteTaskidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseCreditnoteTaskidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<AdvancedPurchaseCreditnoteTaskidDelete200Response>("/advanced-purchase/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseCreditnoteTaskidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseCreditnoteTaskidDelete200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseCreditnoteTaskidDelete200Response> AdvancedPurchaseCreditnoteTaskidDeleteAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseCreditnoteTaskidDelete200Response> localVarResponse = await AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfoAsync(taskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Credit Note Purchase to Void</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseCreditnoteTaskidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseCreditnoteTaskidDelete200Response>> AdvancedPurchaseCreditnoteTaskidDeleteWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->AdvancedPurchaseCreditnoteTaskidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseCreditnoteTaskidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<AdvancedPurchaseCreditnoteTaskidDelete200Response>("/advanced-purchase/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseCreditnoteTaskidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseIdCombineadditionalchargesGet200Response</returns>
        public AdvancedPurchaseIdCombineadditionalchargesGet200Response AdvancedPurchaseIdCombineadditionalchargesGet(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseIdCombineadditionalchargesGet200Response> localVarResponse = AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfo(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseIdCombineadditionalchargesGet200Response</returns>
        public ApiResponse<AdvancedPurchaseIdCombineadditionalchargesGet200Response> AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfo(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->AdvancedPurchaseIdCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseIdCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<AdvancedPurchaseIdCombineadditionalchargesGet200Response>("/advanced-purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseIdCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseIdCombineadditionalchargesGet200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseIdCombineadditionalchargesGet200Response> AdvancedPurchaseIdCombineadditionalchargesGetAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseIdCombineadditionalchargesGet200Response> localVarResponse = await AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfoAsync(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseIdCombineadditionalchargesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseIdCombineadditionalchargesGet200Response>> AdvancedPurchaseIdCombineadditionalchargesGetWithHttpInfoAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->AdvancedPurchaseIdCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseIdCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<AdvancedPurchaseIdCombineadditionalchargesGet200Response>("/advanced-purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseIdCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseIdVoidDelete200Response</returns>
        public AdvancedPurchaseIdVoidDelete200Response AdvancedPurchaseIdVoidDelete(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseIdVoidDelete200Response> localVarResponse = AdvancedPurchaseIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseIdVoidDelete200Response</returns>
        public ApiResponse<AdvancedPurchaseIdVoidDelete200Response> AdvancedPurchaseIdVoidDeleteWithHttpInfo(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->AdvancedPurchaseIdVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseIdVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<AdvancedPurchaseIdVoidDelete200Response>("/advanced-purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseIdVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseIdVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseIdVoidDelete200Response> AdvancedPurchaseIdVoidDeleteAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseIdVoidDelete200Response> localVarResponse = await AdvancedPurchaseIdVoidDeleteWithHttpInfoAsync(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseIdVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseIdVoidDelete200Response>> AdvancedPurchaseIdVoidDeleteWithHttpInfoAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->AdvancedPurchaseIdVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseIdVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<AdvancedPurchaseIdVoidDelete200Response>("/advanced-purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseIdVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseInvoicePost200Response</returns>
        public AdvancedPurchaseInvoicePost200Response AdvancedPurchaseInvoicePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseInvoicePost200Response> localVarResponse = AdvancedPurchaseInvoicePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseInvoicePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseInvoicePost200Response</returns>
        public ApiResponse<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseInvoicePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseInvoicePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<AdvancedPurchaseInvoicePost200Response>("/advanced-purchase/invoice", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseInvoicePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseInvoicePost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseInvoicePost200Response> localVarResponse = await AdvancedPurchaseInvoicePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseInvoicePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseInvoicePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseInvoicePost200Response>> AdvancedPurchaseInvoicePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseInvoicePostRequest? advancedPurchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseInvoicePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseInvoicePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<AdvancedPurchaseInvoicePost200Response>("/advanced-purchase/invoice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseInvoicePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseInvoicePost200Response</returns>
        public AdvancedPurchaseInvoicePost200Response AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseInvoicePost200Response> localVarResponse = AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfo(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseInvoicePost200Response</returns>
        public ApiResponse<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfo(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<AdvancedPurchaseInvoicePost200Response>("/advanced-purchase/invoice ", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseInvoicePost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseInvoicePost200Response> AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseInvoicePost200Response> localVarResponse = await AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfoAsync(purchaseID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseInvoicePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseInvoicePost200Response>> AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGetWithHttpInfoAsync(string purchaseID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<AdvancedPurchaseInvoicePost200Response>("/advanced-purchase/invoice ", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseInvoicePurchaseidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseInvoiceTaskidVoidDelete200Response</returns>
        public AdvancedPurchaseInvoiceTaskidVoidDelete200Response AdvancedPurchaseInvoiceTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseInvoiceTaskidVoidDelete200Response> localVarResponse = AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseInvoiceTaskidVoidDelete200Response</returns>
        public ApiResponse<AdvancedPurchaseInvoiceTaskidVoidDelete200Response> AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->AdvancedPurchaseInvoiceTaskidVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseInvoiceTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<AdvancedPurchaseInvoiceTaskidVoidDelete200Response>("/advanced-purchase/invoice", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseInvoiceTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseInvoiceTaskidVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseInvoiceTaskidVoidDelete200Response> AdvancedPurchaseInvoiceTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseInvoiceTaskidVoidDelete200Response> localVarResponse = await AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfoAsync(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Invoice Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseInvoiceTaskidVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseInvoiceTaskidVoidDelete200Response>> AdvancedPurchaseInvoiceTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->AdvancedPurchaseInvoiceTaskidVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseInvoiceTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<AdvancedPurchaseInvoiceTaskidVoidDelete200Response>("/advanced-purchase/invoice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseInvoiceTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseManualjournalPost200Response</returns>
        public AdvancedPurchaseManualjournalPost200Response AdvancedPurchaseManualjournalPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseManualjournalPost200Response> localVarResponse = AdvancedPurchaseManualjournalPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseManualjournalPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseManualjournalPost200Response</returns>
        public ApiResponse<AdvancedPurchaseManualjournalPost200Response> AdvancedPurchaseManualjournalPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseManualjournalPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseManualjournalPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<AdvancedPurchaseManualjournalPost200Response>("/advanced-purchase/manualJournal", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseManualjournalPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseManualjournalPost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseManualjournalPost200Response> AdvancedPurchaseManualjournalPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseManualjournalPost200Response> localVarResponse = await AdvancedPurchaseManualjournalPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseManualjournalPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseManualjournalPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseManualjournalPost200Response>> AdvancedPurchaseManualjournalPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseManualjournalPostRequest? advancedPurchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseManualjournalPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseManualjournalPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<AdvancedPurchaseManualjournalPost200Response>("/advanced-purchase/manualJournal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseManualjournalPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseManualjournalPurchaseidGet200Response</returns>
        public AdvancedPurchaseManualjournalPurchaseidGet200Response AdvancedPurchaseManualjournalPurchaseidGet(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseManualjournalPurchaseidGet200Response> localVarResponse = AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfo(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseManualjournalPurchaseidGet200Response</returns>
        public ApiResponse<AdvancedPurchaseManualjournalPurchaseidGet200Response> AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfo(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseManualjournalPurchaseidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseManualjournalPurchaseidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<AdvancedPurchaseManualjournalPurchaseidGet200Response>("/advanced-purchase/manualJournal", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseManualjournalPurchaseidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseManualjournalPurchaseidGet200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseManualjournalPurchaseidGet200Response> AdvancedPurchaseManualjournalPurchaseidGetAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseManualjournalPurchaseidGet200Response> localVarResponse = await AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfoAsync(purchaseID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseManualjournalPurchaseidGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseManualjournalPurchaseidGet200Response>> AdvancedPurchaseManualjournalPurchaseidGetWithHttpInfoAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseManualjournalPurchaseidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseManualjournalPurchaseidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<AdvancedPurchaseManualjournalPurchaseidGet200Response>("/advanced-purchase/manualJournal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseManualjournalPurchaseidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePaymentPost200Response</returns>
        public AdvancedPurchasePaymentPost200Response AdvancedPurchasePaymentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchasePaymentPost200Response> localVarResponse = AdvancedPurchasePaymentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePaymentPost200Response</returns>
        public ApiResponse<AdvancedPurchasePaymentPost200Response> AdvancedPurchasePaymentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePaymentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<AdvancedPurchasePaymentPost200Response>("/advanced-purchase/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePaymentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePaymentPost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchasePaymentPost200Response> AdvancedPurchasePaymentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchasePaymentPost200Response> localVarResponse = await AdvancedPurchasePaymentPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePaymentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePaymentPost200Response>> AdvancedPurchasePaymentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePaymentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<AdvancedPurchasePaymentPost200Response>("/advanced-purchase/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePaymentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePaymentPut200Response</returns>
        public AdvancedPurchasePaymentPut200Response AdvancedPurchasePaymentPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchasePaymentPut200Response> localVarResponse = AdvancedPurchasePaymentPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePaymentPut200Response</returns>
        public ApiResponse<AdvancedPurchasePaymentPut200Response> AdvancedPurchasePaymentPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePaymentPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<AdvancedPurchasePaymentPut200Response>("/advanced-purchase/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePaymentPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePaymentPut200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchasePaymentPut200Response> AdvancedPurchasePaymentPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchasePaymentPut200Response> localVarResponse = await AdvancedPurchasePaymentPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePaymentPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePaymentPut200Response>> AdvancedPurchasePaymentPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePaymentPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<AdvancedPurchasePaymentPut200Response>("/advanced-purchase/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePaymentPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePost200Response</returns>
        public AdvancedPurchasePost200Response AdvancedPurchasePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchasePost200Response> localVarResponse = AdvancedPurchasePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePost200Response</returns>
        public ApiResponse<AdvancedPurchasePost200Response> AdvancedPurchasePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<AdvancedPurchasePost200Response>("/advanced-purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePost200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchasePost200Response> AdvancedPurchasePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchasePost200Response> localVarResponse = await AdvancedPurchasePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePost200Response>> AdvancedPurchasePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePostRequest? advancedPurchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<AdvancedPurchasePost200Response>("/advanced-purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePut200Response</returns>
        public AdvancedPurchasePut200Response AdvancedPurchasePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchasePut200Response> localVarResponse = AdvancedPurchasePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePut200Response</returns>
        public ApiResponse<AdvancedPurchasePut200Response> AdvancedPurchasePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<AdvancedPurchasePut200Response>("/advanced-purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePut200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchasePut200Response> AdvancedPurchasePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchasePut200Response> localVarResponse = await AdvancedPurchasePutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePut200Response>> AdvancedPurchasePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePutRequest? advancedPurchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchasePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<AdvancedPurchasePut200Response>("/advanced-purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchasePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockPut200Response</returns>
        public AdvancedPurchaseStockPut200Response AdvancedPurchaseStockPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseStockPut200Response> localVarResponse = AdvancedPurchaseStockPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockPut200Response</returns>
        public ApiResponse<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseStockPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<AdvancedPurchaseStockPut200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockPut200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseStockPut200Response> localVarResponse = await AdvancedPurchaseStockPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + POST method will create new Stock Receiving Task, if value of &#x60;TaskID&#x60; is not provided or equals to &#x60;00000000-0000-0000-0000-000000000000&#x60;.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockPut200Response>> AdvancedPurchaseStockPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseStockPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<AdvancedPurchaseStockPut200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockPurchaseidGet200Response</returns>
        public AdvancedPurchaseStockPurchaseidGet200Response AdvancedPurchaseStockPurchaseidGet(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseStockPurchaseidGet200Response> localVarResponse = AdvancedPurchaseStockPurchaseidGetWithHttpInfo(purchaseID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockPurchaseidGet200Response</returns>
        public ApiResponse<AdvancedPurchaseStockPurchaseidGet200Response> AdvancedPurchaseStockPurchaseidGetWithHttpInfo(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseStockPurchaseidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockPurchaseidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<AdvancedPurchaseStockPurchaseidGet200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockPurchaseidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockPurchaseidGet200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseStockPurchaseidGet200Response> AdvancedPurchaseStockPurchaseidGetAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseStockPurchaseidGet200Response> localVarResponse = await AdvancedPurchaseStockPurchaseidGetWithHttpInfoAsync(purchaseID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockPurchaseidGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockPurchaseidGet200Response>> AdvancedPurchaseStockPurchaseidGetWithHttpInfoAsync(string purchaseID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->AdvancedPurchaseStockPurchaseidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockPurchaseidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<AdvancedPurchaseStockPurchaseidGet200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockPurchaseidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockPut200Response</returns>
        public AdvancedPurchaseStockPut200Response AdvancedPurchaseStockPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseStockPut200Response> localVarResponse = AdvancedPurchaseStockPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockPut200Response</returns>
        public ApiResponse<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseStockPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<AdvancedPurchaseStockPut200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockPut200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseStockPut200Response> AdvancedPurchaseStockPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseStockPut200Response> localVarResponse = await AdvancedPurchaseStockPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchaseStockPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60; or &#x60;PARTIALLY RECEIVED&#x60;  + PUT method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + PUT method will overwrite data in the related Purchase Task.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchaseStockPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockPut200Response>> AdvancedPurchaseStockPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchaseStockPutRequest? advancedPurchaseStockPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchaseStockPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<AdvancedPurchaseStockPut200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchaseStockTaskidVoidDelete200Response</returns>
        public AdvancedPurchaseStockTaskidVoidDelete200Response AdvancedPurchaseStockTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchaseStockTaskidVoidDelete200Response> localVarResponse = AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchaseStockTaskidVoidDelete200Response</returns>
        public ApiResponse<AdvancedPurchaseStockTaskidVoidDelete200Response> AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->AdvancedPurchaseStockTaskidVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<AdvancedPurchaseStockTaskidVoidDelete200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchaseStockTaskidVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchaseStockTaskidVoidDelete200Response> AdvancedPurchaseStockTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchaseStockTaskidVoidDelete200Response> localVarResponse = await AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfoAsync(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + DELETE not available for Simple Purchases
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Stock Receiving Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchaseStockTaskidVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchaseStockTaskidVoidDelete200Response>> AdvancedPurchaseStockTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->AdvancedPurchaseStockTaskidVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.AdvancedPurchaseStockTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<AdvancedPurchaseStockTaskidVoidDelete200Response>("/advanced-purchase/stock", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("AdvancedPurchaseStockTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchRequiredbyUpdatedsinceEtc200Response</returns>
        public PgLmtSrchRequiredbyUpdatedsinceEtc200Response PgLmtSrchRequiredbyUpdatedsinceEtc(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PgLmtSrchRequiredbyUpdatedsinceEtc200Response> localVarResponse = PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfo(page, limit, search, requiredBy, updatedSince, orderStatus, restockReceivedStatus, invoiceStatus, creditNoteStatus, unstockStatus, status, dropShipTaskID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchRequiredbyUpdatedsinceEtc200Response</returns>
        public ApiResponse<PgLmtSrchRequiredbyUpdatedsinceEtc200Response> PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfo(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'requiredBy' is set
            if (requiredBy == null)
            {
                throw new ApiException(400, "Missing required parameter 'requiredBy' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'orderStatus' is set
            if (orderStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'restockReceivedStatus' is set
            if (restockReceivedStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'restockReceivedStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'invoiceStatus' is set
            if (invoiceStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'invoiceStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'unstockStatus' is set
            if (unstockStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'unstockStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'dropShipTaskID' is set
            if (dropShipTaskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'dropShipTaskID' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RequiredBy", ClientUtils.ParameterToString(requiredBy)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UpdatedSince", ClientUtils.ParameterToString(updatedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderStatus", ClientUtils.ParameterToString(orderStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RestockReceivedStatus", ClientUtils.ParameterToString(restockReceivedStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("InvoiceStatus", ClientUtils.ParameterToString(invoiceStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteStatus", ClientUtils.ParameterToString(creditNoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UnstockStatus", ClientUtils.ParameterToString(unstockStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            localVarRequestOptions.QueryParameters.Add("DropShipTaskID", ClientUtils.ParameterToString(dropShipTaskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PgLmtSrchRequiredbyUpdatedsinceEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PgLmtSrchRequiredbyUpdatedsinceEtc200Response>("/purchaseList", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchRequiredbyUpdatedsinceEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchRequiredbyUpdatedsinceEtc200Response</returns>
        public async System.Threading.Tasks.Task<PgLmtSrchRequiredbyUpdatedsinceEtc200Response> PgLmtSrchRequiredbyUpdatedsinceEtcAsync(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PgLmtSrchRequiredbyUpdatedsinceEtc200Response> localVarResponse = await PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfoAsync(page, limit, search, requiredBy, updatedSince, orderStatus, restockReceivedStatus, invoiceStatus, creditNoteStatus, unstockStatus, status, dropShipTaskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="requiredBy">Only return purchase orders with Required By date on or before specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="orderStatus">Only return purchase orders with specified order status</param>
        /// <param name="restockReceivedStatus">Only return purchase orders with specified stock received (put away) status</param>
        /// <param name="invoiceStatus">Only return purchase orders with specified invoice status</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="unstockStatus">Only return purchase orders with specified unstock status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="dropShipTaskID">Only return drop ship purchase which was created by specified sale task ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchRequiredbyUpdatedsinceEtc200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PgLmtSrchRequiredbyUpdatedsinceEtc200Response>> PgLmtSrchRequiredbyUpdatedsinceEtcWithHttpInfoAsync(decimal page, decimal limit, string search, string requiredBy, string updatedSince, string orderStatus, string restockReceivedStatus, string invoiceStatus, string creditNoteStatus, string unstockStatus, string status, string dropShipTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'requiredBy' is set
            if (requiredBy == null)
            {
                throw new ApiException(400, "Missing required parameter 'requiredBy' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'orderStatus' is set
            if (orderStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'restockReceivedStatus' is set
            if (restockReceivedStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'restockReceivedStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'invoiceStatus' is set
            if (invoiceStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'invoiceStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'unstockStatus' is set
            if (unstockStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'unstockStatus' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            // verify the required parameter 'dropShipTaskID' is set
            if (dropShipTaskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'dropShipTaskID' when calling PurchaseApi->PgLmtSrchRequiredbyUpdatedsinceEtc");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RequiredBy", ClientUtils.ParameterToString(requiredBy)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UpdatedSince", ClientUtils.ParameterToString(updatedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderStatus", ClientUtils.ParameterToString(orderStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RestockReceivedStatus", ClientUtils.ParameterToString(restockReceivedStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("InvoiceStatus", ClientUtils.ParameterToString(invoiceStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteStatus", ClientUtils.ParameterToString(creditNoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UnstockStatus", ClientUtils.ParameterToString(unstockStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            localVarRequestOptions.QueryParameters.Add("DropShipTaskID", ClientUtils.ParameterToString(dropShipTaskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PgLmtSrchRequiredbyUpdatedsinceEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PgLmtSrchRequiredbyUpdatedsinceEtc200Response>("/purchaseList", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchRequiredbyUpdatedsinceEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response</returns>
        public PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response PgLmtSrchUpdatedsinceCreditnotestatusEtc(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response> localVarResponse = PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfo(page, limit, search, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response</returns>
        public ApiResponse<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response> PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfo(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UpdatedSince", ClientUtils.ParameterToString(updatedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteStatus", ClientUtils.ParameterToString(creditNoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PgLmtSrchUpdatedsinceCreditnotestatusEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response>("/purchaseCreditNoteList", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchUpdatedsinceCreditnotestatusEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response</returns>
        public async System.Threading.Tasks.Task<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response> PgLmtSrchUpdatedsinceCreditnotestatusEtcAsync(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response> localVarResponse = await PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfoAsync(page, limit, search, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return purchase orders with search value contained in one of these fields: OrderNumber, Status, Supplier, InvoiceNumber, CreditNoteNumber</param>
        /// <param name="updatedSince">Only return purchase changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return purchase orders with specified credit note status</param>
        /// <param name="status">Only return purchase orders with specified purchase status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response>> PgLmtSrchUpdatedsinceCreditnotestatusEtcWithHttpInfoAsync(decimal page, decimal limit, string search, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling PurchaseApi->PgLmtSrchUpdatedsinceCreditnotestatusEtc");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UpdatedSince", ClientUtils.ParameterToString(updatedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteStatus", ClientUtils.ParameterToString(creditNoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PgLmtSrchUpdatedsinceCreditnotestatusEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PgLmtSrchUpdatedsinceCreditnotestatusEtc200Response>("/purchaseCreditNoteList", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchUpdatedsinceCreditnotestatusEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseAttachmentPost200Response</returns>
        public PurchaseAttachmentPost200Response PurchaseAttachmentIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseAttachmentPost200Response> localVarResponse = PurchaseAttachmentIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseAttachmentPost200Response</returns>
        public ApiResponse<PurchaseAttachmentPost200Response> PurchaseAttachmentIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchaseAttachmentIdDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseAttachmentIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<PurchaseAttachmentPost200Response>("/purchase/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseAttachmentIdDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseAttachmentPost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseAttachmentPost200Response> PurchaseAttachmentIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseAttachmentPost200Response> localVarResponse = await PurchaseAttachmentIdDeleteWithHttpInfoAsync(ID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseAttachmentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseAttachmentPost200Response>> PurchaseAttachmentIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchaseAttachmentIdDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseAttachmentIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<PurchaseAttachmentPost200Response>("/purchase/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseAttachmentIdDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseAttachmentPost200Response</returns>
        public PurchaseAttachmentPost200Response PurchaseAttachmentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseAttachmentPost200Response> localVarResponse = PurchaseAttachmentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseAttachmentPost200Response</returns>
        public ApiResponse<PurchaseAttachmentPost200Response> PurchaseAttachmentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseAttachmentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchaseAttachmentPost200Response>("/purchase/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseAttachmentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseAttachmentPost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseAttachmentPost200Response> PurchaseAttachmentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseAttachmentPost200Response> localVarResponse = await PurchaseAttachmentPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseAttachmentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseAttachmentPost200Response>> PurchaseAttachmentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseAttachmentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchaseAttachmentPost200Response>("/purchase/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseAttachmentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseAttachmentPost200Response</returns>
        public PurchaseAttachmentPost200Response PurchaseAttachmentTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseAttachmentPost200Response> localVarResponse = PurchaseAttachmentTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseAttachmentPost200Response</returns>
        public ApiResponse<PurchaseAttachmentPost200Response> PurchaseAttachmentTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseAttachmentTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseAttachmentTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PurchaseAttachmentPost200Response>("/purchase/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseAttachmentTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseAttachmentPost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseAttachmentPost200Response> PurchaseAttachmentTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseAttachmentPost200Response> localVarResponse = await PurchaseAttachmentTaskidGetWithHttpInfoAsync(taskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns Payment info of a particular purchase</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseAttachmentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseAttachmentPost200Response>> PurchaseAttachmentTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseAttachmentTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseAttachmentTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PurchaseAttachmentPost200Response>("/purchase/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseAttachmentTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseCreditnotePost200Response</returns>
        public PurchaseCreditnotePost200Response PurchaseCreditnotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseCreditnotePost200Response> localVarResponse = PurchaseCreditnotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseCreditnotePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseCreditnotePost200Response</returns>
        public ApiResponse<PurchaseCreditnotePost200Response> PurchaseCreditnotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseCreditnotePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseCreditnotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchaseCreditnotePost200Response>("/purchase/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseCreditnotePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseCreditnotePost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseCreditnotePost200Response> PurchaseCreditnotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseCreditnotePost200Response> localVarResponse = await PurchaseCreditnotePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, purchaseCreditnotePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;  + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseCreditnotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseCreditnotePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseCreditnotePost200Response>> PurchaseCreditnotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseCreditnotePostRequest? purchaseCreditnotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseCreditnotePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseCreditnotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchaseCreditnotePost200Response>("/purchase/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseCreditnotePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response</returns>
        public PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response PurchaseCreditnoteTaskidCombineadditionalchargesGet(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response> localVarResponse = PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfo(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response</returns>
        public ApiResponse<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response> PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfo(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseCreditnoteTaskidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseCreditnoteTaskidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response>("/purchase/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseCreditnoteTaskidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response> PurchaseCreditnoteTaskidCombineadditionalchargesGetAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response> localVarResponse = await PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfoAsync(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Credit Note</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response>> PurchaseCreditnoteTaskidCombineadditionalchargesGetWithHttpInfoAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseCreditnoteTaskidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseCreditnoteTaskidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PurchaseCreditnoteTaskidCombineadditionalchargesGet200Response>("/purchase/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseCreditnoteTaskidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseIdCombineadditionalchargesGet200Response</returns>
        public PurchaseIdCombineadditionalchargesGet200Response PurchaseIdCombineadditionalchargesGet(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseIdCombineadditionalchargesGet200Response> localVarResponse = PurchaseIdCombineadditionalchargesGetWithHttpInfo(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseIdCombineadditionalchargesGet200Response</returns>
        public ApiResponse<PurchaseIdCombineadditionalchargesGet200Response> PurchaseIdCombineadditionalchargesGetWithHttpInfo(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchaseIdCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseIdCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PurchaseIdCombineadditionalchargesGet200Response>("/purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseIdCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseIdCombineadditionalchargesGet200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseIdCombineadditionalchargesGet200Response> PurchaseIdCombineadditionalchargesGetAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseIdCombineadditionalchargesGet200Response> localVarResponse = await PurchaseIdCombineadditionalchargesGetWithHttpInfoAsync(ID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Purchase</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseIdCombineadditionalchargesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseIdCombineadditionalchargesGet200Response>> PurchaseIdCombineadditionalchargesGetWithHttpInfoAsync(string ID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchaseIdCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseIdCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PurchaseIdCombineadditionalchargesGet200Response>("/purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseIdCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseIdVoidDelete200Response</returns>
        public PurchaseIdVoidDelete200Response PurchaseIdVoidDelete(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseIdVoidDelete200Response> localVarResponse = PurchaseIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseIdVoidDelete200Response</returns>
        public ApiResponse<PurchaseIdVoidDelete200Response> PurchaseIdVoidDeleteWithHttpInfo(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchaseIdVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseIdVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<PurchaseIdVoidDelete200Response>("/purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseIdVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseIdVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseIdVoidDelete200Response> PurchaseIdVoidDeleteAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseIdVoidDelete200Response> localVarResponse = await PurchaseIdVoidDeleteWithHttpInfoAsync(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Purchase to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseIdVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseIdVoidDelete200Response>> PurchaseIdVoidDeleteWithHttpInfoAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchaseIdVoidDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Void", ClientUtils.ParameterToString(varVoid)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseIdVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<PurchaseIdVoidDelete200Response>("/purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseIdVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseInvoicePost200Response</returns>
        public PurchaseInvoicePost200Response PurchaseInvoicePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseInvoicePost200Response> localVarResponse = PurchaseInvoicePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseInvoicePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseInvoicePost200Response</returns>
        public ApiResponse<PurchaseInvoicePost200Response> PurchaseInvoicePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseInvoicePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseInvoicePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchaseInvoicePost200Response>("/purchase/invoice", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseInvoicePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseInvoicePost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseInvoicePost200Response> PurchaseInvoicePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseInvoicePost200Response> localVarResponse = await PurchaseInvoicePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, purchaseInvoicePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;STOCK&#x60; and &#x60;StockReceivedStatus&#x60; is not - &#x60;AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseInvoicePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseInvoicePost200Response>> PurchaseInvoicePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseInvoicePostRequest? purchaseInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseInvoicePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseInvoicePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchaseInvoicePost200Response>("/purchase/invoice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseInvoicePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseInvoiceTaskidCombineadditionalchargesGet200Response</returns>
        public PurchaseInvoiceTaskidCombineadditionalchargesGet200Response PurchaseInvoiceTaskidCombineadditionalchargesGet(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response> localVarResponse = PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfo(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseInvoiceTaskidCombineadditionalchargesGet200Response</returns>
        public ApiResponse<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response> PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfo(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseInvoiceTaskidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseInvoiceTaskidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response>("/purchase/invoice ", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseInvoiceTaskidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseInvoiceTaskidCombineadditionalchargesGet200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response> PurchaseInvoiceTaskidCombineadditionalchargesGetAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response> localVarResponse = await PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfoAsync(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseInvoiceTaskidCombineadditionalchargesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response>> PurchaseInvoiceTaskidCombineadditionalchargesGetWithHttpInfoAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseInvoiceTaskidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseInvoiceTaskidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PurchaseInvoiceTaskidCombineadditionalchargesGet200Response>("/purchase/invoice ", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseInvoiceTaskidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseManualjournalPost200Response</returns>
        public PurchaseManualjournalPost200Response PurchaseManualjournalPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseManualjournalPost200Response> localVarResponse = PurchaseManualjournalPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseManualjournalPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseManualjournalPost200Response</returns>
        public ApiResponse<PurchaseManualjournalPost200Response> PurchaseManualjournalPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseManualjournalPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseManualjournalPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchaseManualjournalPost200Response>("/purchase/manualJournal", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseManualjournalPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseManualjournalPost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseManualjournalPost200Response> PurchaseManualjournalPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseManualjournalPost200Response> localVarResponse = await PurchaseManualjournalPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, purchaseManualjournalPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST can be done even if manual journal status is &#x60;AUTHORISED&#x60;  + Line items with IsSystem value &#x3D; &#x60;true&#x60; cannot be modified or deleted.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseManualjournalPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseManualjournalPost200Response>> PurchaseManualjournalPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseManualjournalPostRequest? purchaseManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseManualjournalPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseManualjournalPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchaseManualjournalPost200Response>("/purchase/manualJournal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseManualjournalPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseManualjournalTaskidGet200Response</returns>
        public PurchaseManualjournalTaskidGet200Response PurchaseManualjournalTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseManualjournalTaskidGet200Response> localVarResponse = PurchaseManualjournalTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseManualjournalTaskidGet200Response</returns>
        public ApiResponse<PurchaseManualjournalTaskidGet200Response> PurchaseManualjournalTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseManualjournalTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseManualjournalTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PurchaseManualjournalTaskidGet200Response>("/purchase/manualJournal", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseManualjournalTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseManualjournalTaskidGet200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseManualjournalTaskidGet200Response> PurchaseManualjournalTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseManualjournalTaskidGet200Response> localVarResponse = await PurchaseManualjournalTaskidGetWithHttpInfoAsync(taskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Manual Journals</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseManualjournalTaskidGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseManualjournalTaskidGet200Response>> PurchaseManualjournalTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseManualjournalTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseManualjournalTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PurchaseManualjournalTaskidGet200Response>("/purchase/manualJournal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseManualjournalTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseOrderPost200Response</returns>
        public PurchaseOrderPost200Response PurchaseOrderPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseOrderPost200Response> localVarResponse = PurchaseOrderPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseOrderPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseOrderPost200Response</returns>
        public ApiResponse<PurchaseOrderPost200Response> PurchaseOrderPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseOrderPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseOrderPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchaseOrderPost200Response>("/purchase/order", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseOrderPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseOrderPost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseOrderPost200Response> PurchaseOrderPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseOrderPost200Response> localVarResponse = await PurchaseOrderPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, purchaseOrderPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseOrderPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseOrderPost200Response>> PurchaseOrderPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseOrderPostRequest? purchaseOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseOrderPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseOrderPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchaseOrderPost200Response>("/purchase/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseOrderPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseOrderTaskidCombineadditionalchargesGet200Response</returns>
        public PurchaseOrderTaskidCombineadditionalchargesGet200Response PurchaseOrderTaskidCombineadditionalchargesGet(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseOrderTaskidCombineadditionalchargesGet200Response> localVarResponse = PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfo(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseOrderTaskidCombineadditionalchargesGet200Response</returns>
        public ApiResponse<PurchaseOrderTaskidCombineadditionalchargesGet200Response> PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfo(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseOrderTaskidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseOrderTaskidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PurchaseOrderTaskidCombineadditionalchargesGet200Response>("/purchase/order", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseOrderTaskidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseOrderTaskidCombineadditionalchargesGet200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseOrderTaskidCombineadditionalchargesGet200Response> PurchaseOrderTaskidCombineadditionalchargesGetAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseOrderTaskidCombineadditionalchargesGet200Response> localVarResponse = await PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfoAsync(taskID, combineAdditionalCharges, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseOrderTaskidCombineadditionalchargesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseOrderTaskidCombineadditionalchargesGet200Response>> PurchaseOrderTaskidCombineadditionalchargesGetWithHttpInfoAsync(string taskID, bool combineAdditionalCharges, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseOrderTaskidCombineadditionalchargesGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseOrderTaskidCombineadditionalchargesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PurchaseOrderTaskidCombineadditionalchargesGet200Response>("/purchase/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseOrderTaskidCombineadditionalchargesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        public MeAddressesIdDelete200Response PurchasePaymentIdallocationDelete(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = PurchasePaymentIdallocationDeleteWithHttpInfo(ID, deleteAllocation, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        public ApiResponse<MeAddressesIdDelete200Response> PurchasePaymentIdallocationDeleteWithHttpInfo(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchasePaymentIdallocationDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("DeleteAllocation", ClientUtils.ParameterToString(deleteAllocation)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentIdallocationDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<MeAddressesIdDelete200Response>("/purchase/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentIdallocationDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        public async System.Threading.Tasks.Task<MeAddressesIdDelete200Response> PurchasePaymentIdallocationDeleteAsync(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = await PurchasePaymentIdallocationDeleteWithHttpInfoAsync(ID, deleteAllocation, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="deleteAllocation">Delete allocated payments (Default &#x3D; true)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> PurchasePaymentIdallocationDeleteWithHttpInfoAsync(string ID, bool deleteAllocation, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling PurchaseApi->PurchasePaymentIdallocationDelete");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("DeleteAllocation", ClientUtils.ParameterToString(deleteAllocation)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentIdallocationDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<MeAddressesIdDelete200Response>("/purchase/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentIdallocationDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchasePaymentPost200Response</returns>
        public PurchasePaymentPost200Response PurchasePaymentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchasePaymentPost200Response> localVarResponse = PurchasePaymentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchasePaymentPost200Response</returns>
        public ApiResponse<PurchasePaymentPost200Response> PurchasePaymentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchasePaymentPost200Response>("/purchase/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchasePaymentPost200Response</returns>
        public async System.Threading.Tasks.Task<PurchasePaymentPost200Response> PurchasePaymentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchasePaymentPost200Response> localVarResponse = await PurchasePaymentPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchasePaymentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchasePaymentPost200Response>> PurchasePaymentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPostRequest? advancedPurchasePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchasePaymentPost200Response>("/purchase/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;</returns>
        public List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>> localVarResponse = PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfo(purchaseID, orderNumber, invoiceNumber, creditNoteNumber, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;</returns>
        public ApiResponse<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfo(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            // verify the required parameter 'orderNumber' is set
            if (orderNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderNumber' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            // verify the required parameter 'invoiceNumber' is set
            if (invoiceNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'invoiceNumber' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            // verify the required parameter 'creditNoteNumber' is set
            if (creditNoteNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteNumber' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderNumber", ClientUtils.ParameterToString(orderNumber)); // path parameter
            localVarRequestOptions.QueryParameters.Add("InvoiceNumber", ClientUtils.ParameterToString(invoiceNumber)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteNumber", ClientUtils.ParameterToString(creditNoteNumber)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>>("/advanced-purchase/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcAsync(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>> localVarResponse = await PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfoAsync(purchaseID, orderNumber, invoiceNumber, creditNoteNumber, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="purchaseID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="orderNumber">Returns detailed info of a particular Purchase Payments with Purchase Order Number</param>
        /// <param name="invoiceNumber">Returns detailed info of a particular Purchase Payments with Invoice Number</param>
        /// <param name="creditNoteNumber">Returns detailed info of a particular Purchase Payments with Credit Note Number</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>>> PurchasePaymentPurchaseidOrdernumberInvoicenumberEtcWithHttpInfoAsync(string purchaseID, string orderNumber, string invoiceNumber, string creditNoteNumber, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'purchaseID' is set
            if (purchaseID == null)
            {
                throw new ApiException(400, "Missing required parameter 'purchaseID' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            // verify the required parameter 'orderNumber' is set
            if (orderNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderNumber' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            // verify the required parameter 'invoiceNumber' is set
            if (invoiceNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'invoiceNumber' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            // verify the required parameter 'creditNoteNumber' is set
            if (creditNoteNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteNumber' when calling PurchaseApi->PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("PurchaseID", ClientUtils.ParameterToString(purchaseID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderNumber", ClientUtils.ParameterToString(orderNumber)); // path parameter
            localVarRequestOptions.QueryParameters.Add("InvoiceNumber", ClientUtils.ParameterToString(invoiceNumber)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteNumber", ClientUtils.ParameterToString(creditNoteNumber)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<List<PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc200ResponseInner>>("/advanced-purchase/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentPurchaseidOrdernumberInvoicenumberEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AdvancedPurchasePaymentPutRequest</returns>
        public AdvancedPurchasePaymentPutRequest PurchasePaymentPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<AdvancedPurchasePaymentPutRequest> localVarResponse = PurchasePaymentPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AdvancedPurchasePaymentPutRequest</returns>
        public ApiResponse<AdvancedPurchasePaymentPutRequest> PurchasePaymentPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<AdvancedPurchasePaymentPutRequest>("/purchase/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AdvancedPurchasePaymentPutRequest</returns>
        public async System.Threading.Tasks.Task<AdvancedPurchasePaymentPutRequest> PurchasePaymentPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdvancedPurchasePaymentPutRequest> localVarResponse = await PurchasePaymentPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, advancedPurchasePaymentPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="advancedPurchasePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AdvancedPurchasePaymentPutRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedPurchasePaymentPutRequest>> PurchasePaymentPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AdvancedPurchasePaymentPutRequest? advancedPurchasePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = advancedPurchasePaymentPutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<AdvancedPurchasePaymentPutRequest>("/purchase/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;</returns>
        public List<PurchasePaymentTaskidGet200ResponseInner> PurchasePaymentTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<List<PurchasePaymentTaskidGet200ResponseInner>> localVarResponse = PurchasePaymentTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;</returns>
        public ApiResponse<List<PurchasePaymentTaskidGet200ResponseInner>> PurchasePaymentTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchasePaymentTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<List<PurchasePaymentTaskidGet200ResponseInner>>("/purchase/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<PurchasePaymentTaskidGet200ResponseInner>> PurchasePaymentTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<List<PurchasePaymentTaskidGet200ResponseInner>> localVarResponse = await PurchasePaymentTaskidGetWithHttpInfoAsync(taskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Payments</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PurchasePaymentTaskidGet200ResponseInner&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PurchasePaymentTaskidGet200ResponseInner>>> PurchasePaymentTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchasePaymentTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePaymentTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<List<PurchasePaymentTaskidGet200ResponseInner>>("/purchase/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePaymentTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchasePost200Response</returns>
        public PurchasePost200Response PurchasePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchasePost200Response> localVarResponse = PurchasePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchasePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchasePost200Response</returns>
        public ApiResponse<PurchasePost200Response> PurchasePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchasePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchasePost200Response>("/purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchasePost200Response</returns>
        public async System.Threading.Tasks.Task<PurchasePost200Response> PurchasePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchasePost200Response> localVarResponse = await PurchasePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, purchasePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchasePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchasePost200Response>> PurchasePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePostRequest? purchasePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchasePostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchasePost200Response>("/purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchasePut200Response</returns>
        public PurchasePut200Response PurchasePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchasePut200Response> localVarResponse = PurchasePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchasePutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchasePut200Response</returns>
        public ApiResponse<PurchasePut200Response> PurchasePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchasePutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<PurchasePut200Response>("/purchase", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchasePut200Response</returns>
        public async System.Threading.Tasks.Task<PurchasePut200Response> PurchasePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchasePut200Response> localVarResponse = await PurchasePutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, purchasePutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchasePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchasePut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchasePut200Response>> PurchasePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchasePutRequest? purchasePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchasePutRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchasePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<PurchasePut200Response>("/purchase", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchasePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseStockPost200Response</returns>
        public PurchaseStockPost200Response PurchaseStockPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseStockPost200Response> localVarResponse = PurchaseStockPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, purchaseStockPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseStockPost200Response</returns>
        public ApiResponse<PurchaseStockPost200Response> PurchaseStockPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseStockPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseStockPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PurchaseStockPost200Response>("/purchase/stock", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseStockPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseStockPost200Response</returns>
        public async System.Threading.Tasks.Task<PurchaseStockPost200Response> PurchaseStockPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseStockPost200Response> localVarResponse = await PurchaseStockPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, purchaseStockPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if Stock Received status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Purchase &#x60;Approach&#x60; &#x3D; &#x60;INVOICE&#x60; and &#x60;InvoiceStatus&#x60; is not - &#x60;AUTHORISED&#x60;  + POST method is used to add only new stock lines.  + To Authorize Stock Received, Request with empty lines in payload can be done.  + If duplicated lines found in one payload, one line with sum quantity will be created.  + If lines with same Product, location, batch and expiry Date already exist, error will be thrown.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="purchaseStockPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseStockPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseStockPost200Response>> PurchaseStockPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PurchaseStockPostRequest? purchaseStockPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = purchaseStockPostRequest;

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseStockPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PurchaseStockPost200Response>("/purchase/stock", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseStockPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PurchaseStockPostRequest</returns>
        public PurchaseStockPostRequest PurchaseStockTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PurchaseStockPostRequest> localVarResponse = PurchaseStockTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PurchaseStockPostRequest</returns>
        public ApiResponse<PurchaseStockPostRequest> PurchaseStockTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseStockTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseStockTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PurchaseStockPostRequest>("/purchase/stock", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseStockTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PurchaseStockPostRequest</returns>
        public async System.Threading.Tasks.Task<PurchaseStockPostRequest> PurchaseStockTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PurchaseStockPostRequest> localVarResponse = await PurchaseStockTaskidGetWithHttpInfoAsync(taskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">Returns detailed info of a particular Purchase Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PurchaseStockPostRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PurchaseStockPostRequest>> PurchaseStockTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling PurchaseApi->PurchaseStockTaskidGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [
                "application/json"
            ];

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add("TaskID", ClientUtils.ParameterToString(taskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "PurchaseApi.PurchaseStockTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PurchaseStockPostRequest>("/purchase/stock", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PurchaseStockTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
    }
}