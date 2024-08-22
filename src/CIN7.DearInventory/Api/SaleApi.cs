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
    public interface ISaleApiSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchCreatedsinceUpdatedsinceEtc200Response</returns>
        PgLmtSrchCreatedsinceUpdatedsinceEtc200Response PgLmtSrchCreatedsinceUpdatedsinceEtc(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchCreatedsinceUpdatedsinceEtc200Response</returns>
        ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response> PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfo(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response</returns>
        PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response PgLmtSrchCreatedsinceUpdatedsinceEtc1(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response</returns>
        ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response> PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfo(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleAttachmentPost200Response</returns>
        SaleAttachmentPost200Response SaleAttachmentIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleAttachmentPost200Response</returns>
        ApiResponse<SaleAttachmentPost200Response> SaleAttachmentIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleAttachmentPost200Response</returns>
        SaleAttachmentPost200Response SaleAttachmentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

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
        /// <returns>ApiResponse of SaleAttachmentPost200Response</returns>
        ApiResponse<SaleAttachmentPost200Response> SaleAttachmentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleAttachmentPost200Response</returns>
        SaleAttachmentPost200Response SaleAttachmentSaleidGet(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleAttachmentPost200Response</returns>
        ApiResponse<SaleAttachmentPost200Response> SaleAttachmentSaleidGetWithHttpInfo(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void SaleCreditnotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> SaleCreditnotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleCreditnoteTaskidVoidDelete200Response</returns>
        SaleCreditnoteTaskidVoidDelete200Response SaleCreditnoteTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleCreditnoteTaskidVoidDelete200Response</returns>
        ApiResponse<SaleCreditnoteTaskidVoidDelete200Response> SaleCreditnoteTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPackPut200Response</returns>
        SaleFulfilmentPackPut200Response SaleFulfilmentPackPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPackPut200Response</returns>
        ApiResponse<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPackPut200Response</returns>
        SaleFulfilmentPackPut200Response SaleFulfilmentPackPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPackPut200Response</returns>
        ApiResponse<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPackTaskidIncludeproductinfoGet200Response</returns>
        SaleFulfilmentPackTaskidIncludeproductinfoGet200Response SaleFulfilmentPackTaskidIncludeproductinfoGet(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPackTaskidIncludeproductinfoGet200Response</returns>
        ApiResponse<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response> SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfo(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPickPut200Response</returns>
        SaleFulfilmentPickPut200Response SaleFulfilmentPickPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPickPut200Response</returns>
        ApiResponse<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPickPut200Response</returns>
        SaleFulfilmentPickPut200Response SaleFulfilmentPickPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPickPut200Response</returns>
        ApiResponse<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPickPut200Response</returns>
        SaleFulfilmentPickPut200Response SaleFulfilmentPickTaskidIncludeproductinfoGet(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPickPut200Response</returns>
        ApiResponse<SaleFulfilmentPickPut200Response> SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfo(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPost200Response</returns>
        SaleFulfilmentPost200Response SaleFulfilmentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPost200Response</returns>
        ApiResponse<SaleFulfilmentPost200Response> SaleFulfilmentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentSaleidIncludeproductinfoGet200Response</returns>
        SaleFulfilmentSaleidIncludeproductinfoGet200Response SaleFulfilmentSaleidIncludeproductinfoGet(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentSaleidIncludeproductinfoGet200Response</returns>
        ApiResponse<SaleFulfilmentSaleidIncludeproductinfoGet200Response> SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfo(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentShipPut200Response</returns>
        SaleFulfilmentShipPut200Response SaleFulfilmentShipPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentShipPut200Response</returns>
        ApiResponse<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentShipPut200Response</returns>
        SaleFulfilmentShipPut200Response SaleFulfilmentShipPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentShipPut200Response</returns>
        ApiResponse<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentShipTaskidGet200Response</returns>
        SaleFulfilmentShipTaskidGet200Response SaleFulfilmentShipTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentShipTaskidGet200Response</returns>
        ApiResponse<SaleFulfilmentShipTaskidGet200Response> SaleFulfilmentShipTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentTaskidVoidDelete200Response</returns>
        SaleFulfilmentTaskidVoidDelete200Response SaleFulfilmentTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentTaskidVoidDelete200Response</returns>
        ApiResponse<SaleFulfilmentTaskidVoidDelete200Response> SaleFulfilmentTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response</returns>
        SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response</returns>
        ApiResponse<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response> SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfo(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleIdVoidDelete200Response</returns>
        SaleIdVoidDelete200Response SaleIdVoidDelete(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleIdVoidDelete200Response</returns>
        ApiResponse<SaleIdVoidDelete200Response> SaleIdVoidDeleteWithHttpInfo(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoicePost200Response</returns>
        SaleInvoicePost200Response SaleInvoicePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoicePost200Response</returns>
        ApiResponse<SaleInvoicePost200Response> SaleInvoicePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoicePut200Response</returns>
        SaleInvoicePut200Response SaleInvoicePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoicePut200Response</returns>
        ApiResponse<SaleInvoicePut200Response> SaleInvoicePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoicePost200Response</returns>
        SaleInvoicePost200Response SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoicePost200Response</returns>
        ApiResponse<SaleInvoicePost200Response> SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoiceTaskidVoidDelete200Response</returns>
        SaleInvoiceTaskidVoidDelete200Response SaleInvoiceTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoiceTaskidVoidDelete200Response</returns>
        ApiResponse<SaleInvoiceTaskidVoidDelete200Response> SaleInvoiceTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleManualjournalPostRequest</returns>
        SaleManualjournalPostRequest SaleManualjournalPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleManualjournalPostRequest</returns>
        ApiResponse<SaleManualjournalPostRequest> SaleManualjournalPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleManualjournalSaleidGet200Response</returns>
        SaleManualjournalSaleidGet200Response SaleManualjournalSaleidGet(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleManualjournalSaleidGet200Response</returns>
        ApiResponse<SaleManualjournalSaleidGet200Response> SaleManualjournalSaleidGetWithHttpInfo(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleOrderPost200Response</returns>
        SaleOrderPost200Response SaleOrderPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleOrderPost200Response</returns>
        ApiResponse<SaleOrderPost200Response> SaleOrderPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleOrderPost200Response</returns>
        SaleOrderPost200Response SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleOrderPost200Response</returns>
        ApiResponse<SaleOrderPost200Response> SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        MeAddressesIdDelete200Response SalePaymentIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        ApiResponse<MeAddressesIdDelete200Response> SalePaymentIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SalePaymentPost200Response</returns>
        SalePaymentPost200Response SalePaymentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SalePaymentPost200Response</returns>
        ApiResponse<SalePaymentPost200Response> SalePaymentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SalePaymentPut200Response</returns>
        SalePaymentPut200Response SalePaymentPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SalePaymentPut200Response</returns>
        ApiResponse<SalePaymentPut200Response> SalePaymentPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;SalePaymentSaleidGet200ResponseInner&gt;</returns>
        List<SalePaymentSaleidGet200ResponseInner> SalePaymentSaleidGet(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;SalePaymentSaleidGet200ResponseInner&gt;</returns>
        ApiResponse<List<SalePaymentSaleidGet200ResponseInner>> SalePaymentSaleidGetWithHttpInfo(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SalePost200Response</returns>
        SalePost200Response SalePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

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
        /// <returns>ApiResponse of SalePost200Response</returns>
        ApiResponse<SalePost200Response> SalePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SalePut200Response</returns>
        SalePut200Response SalePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SalePut200Response</returns>
        ApiResponse<SalePut200Response> SalePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleQuotePost200Response</returns>
        SaleQuotePost200Response SaleQuotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleQuotePost200Response</returns>
        ApiResponse<SaleQuotePost200Response> SaleQuotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleQuotePost200Response</returns>
        SaleQuotePost200Response SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleQuotePost200Response</returns>
        ApiResponse<SaleQuotePost200Response> SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISaleApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchCreatedsinceUpdatedsinceEtc200Response</returns>
        System.Threading.Tasks.Task<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response> PgLmtSrchCreatedsinceUpdatedsinceEtcAsync(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchCreatedsinceUpdatedsinceEtc200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response>> PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfoAsync(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response</returns>
        System.Threading.Tasks.Task<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response> PgLmtSrchCreatedsinceUpdatedsinceEtc1Async(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response>> PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfoAsync(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleAttachmentPost200Response</returns>
        System.Threading.Tasks.Task<SaleAttachmentPost200Response> SaleAttachmentIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleAttachmentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleAttachmentPost200Response>> SaleAttachmentIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task of SaleAttachmentPost200Response</returns>
        System.Threading.Tasks.Task<SaleAttachmentPost200Response> SaleAttachmentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task of ApiResponse (SaleAttachmentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleAttachmentPost200Response>> SaleAttachmentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleAttachmentPost200Response</returns>
        System.Threading.Tasks.Task<SaleAttachmentPost200Response> SaleAttachmentSaleidGetAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleAttachmentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleAttachmentPost200Response>> SaleAttachmentSaleidGetWithHttpInfoAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SaleCreditnotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> SaleCreditnotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleCreditnoteTaskidVoidDelete200Response</returns>
        System.Threading.Tasks.Task<SaleCreditnoteTaskidVoidDelete200Response> SaleCreditnoteTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleCreditnoteTaskidVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleCreditnoteTaskidVoidDelete200Response>> SaleCreditnoteTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPackPut200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPackPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPackPut200Response>> SaleFulfilmentPackPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPackPut200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPackPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPackPut200Response>> SaleFulfilmentPackPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPackTaskidIncludeproductinfoGet200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response> SaleFulfilmentPackTaskidIncludeproductinfoGetAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPackTaskidIncludeproductinfoGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response>> SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfoAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPickPut200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPickPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPickPut200Response>> SaleFulfilmentPickPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPickPut200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPickPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPickPut200Response>> SaleFulfilmentPickPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPickPut200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentPickPut200Response> SaleFulfilmentPickTaskidIncludeproductinfoGetAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPickPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPickPut200Response>> SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfoAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPost200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentPost200Response> SaleFulfilmentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPost200Response>> SaleFulfilmentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentSaleidIncludeproductinfoGet200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentSaleidIncludeproductinfoGet200Response> SaleFulfilmentSaleidIncludeproductinfoGetAsync(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentSaleidIncludeproductinfoGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentSaleidIncludeproductinfoGet200Response>> SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentShipPut200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentShipPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentShipPut200Response>> SaleFulfilmentShipPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentShipPut200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentShipPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentShipPut200Response>> SaleFulfilmentShipPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentShipTaskidGet200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentShipTaskidGet200Response> SaleFulfilmentShipTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentShipTaskidGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentShipTaskidGet200Response>> SaleFulfilmentShipTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentTaskidVoidDelete200Response</returns>
        System.Threading.Tasks.Task<SaleFulfilmentTaskidVoidDelete200Response> SaleFulfilmentTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentTaskidVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentTaskidVoidDelete200Response>> SaleFulfilmentTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response</returns>
        System.Threading.Tasks.Task<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response> SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetAsync(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response>> SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfoAsync(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleIdVoidDelete200Response</returns>
        System.Threading.Tasks.Task<SaleIdVoidDelete200Response> SaleIdVoidDeleteAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleIdVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleIdVoidDelete200Response>> SaleIdVoidDeleteWithHttpInfoAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoicePost200Response</returns>
        System.Threading.Tasks.Task<SaleInvoicePost200Response> SaleInvoicePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoicePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleInvoicePost200Response>> SaleInvoicePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoicePut200Response</returns>
        System.Threading.Tasks.Task<SaleInvoicePut200Response> SaleInvoicePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoicePut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleInvoicePut200Response>> SaleInvoicePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoicePost200Response</returns>
        System.Threading.Tasks.Task<SaleInvoicePost200Response> SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoicePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleInvoicePost200Response>> SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoiceTaskidVoidDelete200Response</returns>
        System.Threading.Tasks.Task<SaleInvoiceTaskidVoidDelete200Response> SaleInvoiceTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoiceTaskidVoidDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleInvoiceTaskidVoidDelete200Response>> SaleInvoiceTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleManualjournalPostRequest</returns>
        System.Threading.Tasks.Task<SaleManualjournalPostRequest> SaleManualjournalPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleManualjournalPostRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleManualjournalPostRequest>> SaleManualjournalPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleManualjournalSaleidGet200Response</returns>
        System.Threading.Tasks.Task<SaleManualjournalSaleidGet200Response> SaleManualjournalSaleidGetAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleManualjournalSaleidGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleManualjournalSaleidGet200Response>> SaleManualjournalSaleidGetWithHttpInfoAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleOrderPost200Response</returns>
        System.Threading.Tasks.Task<SaleOrderPost200Response> SaleOrderPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleOrderPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleOrderPost200Response>> SaleOrderPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleOrderPost200Response</returns>
        System.Threading.Tasks.Task<SaleOrderPost200Response> SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleOrderPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleOrderPost200Response>> SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        System.Threading.Tasks.Task<MeAddressesIdDelete200Response> SalePaymentIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> SalePaymentIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SalePaymentPost200Response</returns>
        System.Threading.Tasks.Task<SalePaymentPost200Response> SalePaymentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SalePaymentPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SalePaymentPost200Response>> SalePaymentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SalePaymentPut200Response</returns>
        System.Threading.Tasks.Task<SalePaymentPut200Response> SalePaymentPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Please note, that Payment with type Prepayment cannot be modified.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SalePaymentPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SalePaymentPut200Response>> SalePaymentPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SalePaymentSaleidGet200ResponseInner&gt;</returns>
        System.Threading.Tasks.Task<List<SalePaymentSaleidGet200ResponseInner>> SalePaymentSaleidGetAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SalePaymentSaleidGet200ResponseInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SalePaymentSaleidGet200ResponseInner>>> SalePaymentSaleidGetWithHttpInfoAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task of SalePost200Response</returns>
        System.Threading.Tasks.Task<SalePost200Response> SalePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task of ApiResponse (SalePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SalePost200Response>> SalePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SalePut200Response</returns>
        System.Threading.Tasks.Task<SalePut200Response> SalePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SalePut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SalePut200Response>> SalePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleQuotePost200Response</returns>
        System.Threading.Tasks.Task<SaleQuotePost200Response> SaleQuotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleQuotePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleQuotePost200Response>> SaleQuotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleQuotePost200Response</returns>
        System.Threading.Tasks.Task<SaleQuotePost200Response> SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleQuotePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaleQuotePost200Response>> SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISaleApi : ISaleApiSync, ISaleApiAsync
    {
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SaleApi : ISaleApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SaleApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SaleApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SaleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SaleApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SaleApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SaleApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchCreatedsinceUpdatedsinceEtc200Response</returns>
        public PgLmtSrchCreatedsinceUpdatedsinceEtc200Response PgLmtSrchCreatedsinceUpdatedsinceEtc(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response> localVarResponse = PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfo(page, limit, search, createdSince, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchCreatedsinceUpdatedsinceEtc200Response</returns>
        public ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response> PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfo(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
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
            localVarRequestOptions.QueryParameters.Add("CreatedSince", ClientUtils.ParameterToString(createdSince)); // path parameter
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

            localVarRequestOptions.Operation = "SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response>("/saleCreditNoteList", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchCreatedsinceUpdatedsinceEtc", localVarResponse);
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
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchCreatedsinceUpdatedsinceEtc200Response</returns>
        public async System.Threading.Tasks.Task<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response> PgLmtSrchCreatedsinceUpdatedsinceEtcAsync(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response> localVarResponse = await PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfoAsync(page, limit, search, createdSince, updatedSince, creditNoteStatus, status, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchCreatedsinceUpdatedsinceEtc200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response>> PgLmtSrchCreatedsinceUpdatedsinceEtcWithHttpInfoAsync(decimal page, decimal limit, string search, string createdSince, string updatedSince, string creditNoteStatus, string status, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc");
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
            localVarRequestOptions.QueryParameters.Add("CreatedSince", ClientUtils.ParameterToString(createdSince)); // path parameter
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

            localVarRequestOptions.Operation = "SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PgLmtSrchCreatedsinceUpdatedsinceEtc200Response>("/saleCreditNoteList", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchCreatedsinceUpdatedsinceEtc", localVarResponse);
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
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response</returns>
        public PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response PgLmtSrchCreatedsinceUpdatedsinceEtc1(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response> localVarResponse = PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfo(page, limit, search, createdSince, updatedSince, shipBy, quoteStatus, orderStatus, combinedPickStatus, combinedPackStatus, combinedShippingStatus, combinedInvoiceStatus, creditNoteStatus, externalID, status, readyForShipping, orderLocationID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response</returns>
        public ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response> PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfo(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'shipBy' is set
            if (shipBy == null)
            {
                throw new ApiException(400, "Missing required parameter 'shipBy' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'quoteStatus' is set
            if (quoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'quoteStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'orderStatus' is set
            if (orderStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedPickStatus' is set
            if (combinedPickStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedPickStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedPackStatus' is set
            if (combinedPackStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedPackStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedShippingStatus' is set
            if (combinedShippingStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedShippingStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedInvoiceStatus' is set
            if (combinedInvoiceStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedInvoiceStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'externalID' is set
            if (externalID == null)
            {
                throw new ApiException(400, "Missing required parameter 'externalID' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'orderLocationID' is set
            if (orderLocationID == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderLocationID' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
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
            localVarRequestOptions.QueryParameters.Add("CreatedSince", ClientUtils.ParameterToString(createdSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UpdatedSince", ClientUtils.ParameterToString(updatedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ShipBy", ClientUtils.ParameterToString(shipBy)); // path parameter
            localVarRequestOptions.QueryParameters.Add("QuoteStatus", ClientUtils.ParameterToString(quoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderStatus", ClientUtils.ParameterToString(orderStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedPickStatus", ClientUtils.ParameterToString(combinedPickStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedPackStatus", ClientUtils.ParameterToString(combinedPackStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedShippingStatus", ClientUtils.ParameterToString(combinedShippingStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedInvoiceStatus", ClientUtils.ParameterToString(combinedInvoiceStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteStatus", ClientUtils.ParameterToString(creditNoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ExternalID", ClientUtils.ParameterToString(externalID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReadyForShipping", ClientUtils.ParameterToString(readyForShipping)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderLocationID", ClientUtils.ParameterToString(orderLocationID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtc1";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response>("/saleList", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchCreatedsinceUpdatedsinceEtc1", localVarResponse);
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
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response</returns>
        public async System.Threading.Tasks.Task<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response> PgLmtSrchCreatedsinceUpdatedsinceEtc1Async(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response> localVarResponse = await PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfoAsync(page, limit, search, createdSince, updatedSince, shipBy, quoteStatus, orderStatus, combinedPickStatus, combinedPackStatus, combinedShippingStatus, combinedInvoiceStatus, creditNoteStatus, externalID, status, readyForShipping, orderLocationID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="search">Only return sales with search value contained in one of these fields: OrderNumber, Status, Customer, invoiceNumber, CustomerReference, CreditNoteNumber</param>
        /// <param name="createdSince">Only return sales created after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="updatedSince">Only return sales changed after specified date. Date must follow  ISO 8601 format.</param>
        /// <param name="shipBy">Only return sales with Ship By date on or before specified date, with not authorised Shipment. Date must follow  ISO 8601 format.</param>
        /// <param name="quoteStatus">Only return sales with specified quote status</param>
        /// <param name="orderStatus">Only return sales with specified order status</param>
        /// <param name="combinedPickStatus">Only return sales with specified CombinedPickingStatus</param>
        /// <param name="combinedPackStatus">Only return sales with specified CombinedPackingStatus</param>
        /// <param name="combinedShippingStatus">Only return sales with specified CombinedShippingStatus</param>
        /// <param name="combinedInvoiceStatus">Only return sales with specified CombinedInvoiceStatus</param>
        /// <param name="creditNoteStatus">Only return sales with specified credit note status</param>
        /// <param name="externalID">Only return sales with specified External ID</param>
        /// <param name="status">Only return sales with specified sale status</param>
        /// <param name="readyForShipping">Only return sales with &#39;Authorised&#39; pack and not &#39;Authorised&#39; shipping</param>
        /// <param name="orderLocationID">Only return sales with specified Order Location ID</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response>> PgLmtSrchCreatedsinceUpdatedsinceEtc1WithHttpInfoAsync(decimal page, decimal limit, string search, string createdSince, string updatedSince, string shipBy, string quoteStatus, string orderStatus, string combinedPickStatus, string combinedPackStatus, string combinedShippingStatus, string combinedInvoiceStatus, string creditNoteStatus, string externalID, string status, bool readyForShipping, string orderLocationID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'updatedSince' is set
            if (updatedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'updatedSince' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'shipBy' is set
            if (shipBy == null)
            {
                throw new ApiException(400, "Missing required parameter 'shipBy' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'quoteStatus' is set
            if (quoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'quoteStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'orderStatus' is set
            if (orderStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedPickStatus' is set
            if (combinedPickStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedPickStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedPackStatus' is set
            if (combinedPackStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedPackStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedShippingStatus' is set
            if (combinedShippingStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedShippingStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'combinedInvoiceStatus' is set
            if (combinedInvoiceStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'combinedInvoiceStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'creditNoteStatus' is set
            if (creditNoteStatus == null)
            {
                throw new ApiException(400, "Missing required parameter 'creditNoteStatus' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'externalID' is set
            if (externalID == null)
            {
                throw new ApiException(400, "Missing required parameter 'externalID' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
            }

            // verify the required parameter 'orderLocationID' is set
            if (orderLocationID == null)
            {
                throw new ApiException(400, "Missing required parameter 'orderLocationID' when calling SaleApi->PgLmtSrchCreatedsinceUpdatedsinceEtc1");
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
            localVarRequestOptions.QueryParameters.Add("CreatedSince", ClientUtils.ParameterToString(createdSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("UpdatedSince", ClientUtils.ParameterToString(updatedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ShipBy", ClientUtils.ParameterToString(shipBy)); // path parameter
            localVarRequestOptions.QueryParameters.Add("QuoteStatus", ClientUtils.ParameterToString(quoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderStatus", ClientUtils.ParameterToString(orderStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedPickStatus", ClientUtils.ParameterToString(combinedPickStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedPackStatus", ClientUtils.ParameterToString(combinedPackStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedShippingStatus", ClientUtils.ParameterToString(combinedShippingStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombinedInvoiceStatus", ClientUtils.ParameterToString(combinedInvoiceStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CreditNoteStatus", ClientUtils.ParameterToString(creditNoteStatus)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ExternalID", ClientUtils.ParameterToString(externalID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReadyForShipping", ClientUtils.ParameterToString(readyForShipping)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OrderLocationID", ClientUtils.ParameterToString(orderLocationID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.PgLmtSrchCreatedsinceUpdatedsinceEtc1";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<PgLmtSrchCreatedsinceUpdatedsinceEtc1200Response>("/saleList", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PgLmtSrchCreatedsinceUpdatedsinceEtc1", localVarResponse);
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
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleAttachmentPost200Response</returns>
        public SaleAttachmentPost200Response SaleAttachmentIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleAttachmentPost200Response> localVarResponse = SaleAttachmentIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleAttachmentPost200Response</returns>
        public ApiResponse<SaleAttachmentPost200Response> SaleAttachmentIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SaleAttachmentIdDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleAttachmentIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<SaleAttachmentPost200Response>("/sale/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleAttachmentIdDelete", localVarResponse);
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
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleAttachmentPost200Response</returns>
        public async System.Threading.Tasks.Task<SaleAttachmentPost200Response> SaleAttachmentIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleAttachmentPost200Response> localVarResponse = await SaleAttachmentIdDeleteWithHttpInfoAsync(ID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleAttachmentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleAttachmentPost200Response>> SaleAttachmentIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SaleAttachmentIdDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleAttachmentIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<SaleAttachmentPost200Response>("/sale/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleAttachmentIdDelete", localVarResponse);
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
        /// <returns>SaleAttachmentPost200Response</returns>
        public SaleAttachmentPost200Response SaleAttachmentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleAttachmentPost200Response> localVarResponse = SaleAttachmentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleAttachmentPost200Response</returns>
        public ApiResponse<SaleAttachmentPost200Response> SaleAttachmentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "SaleApi.SaleAttachmentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleAttachmentPost200Response>("/sale/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleAttachmentPost", localVarResponse);
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
        /// <returns>Task of SaleAttachmentPost200Response</returns>
        public async System.Threading.Tasks.Task<SaleAttachmentPost200Response> SaleAttachmentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleAttachmentPost200Response> localVarResponse = await SaleAttachmentPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
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
        /// <returns>Task of ApiResponse (SaleAttachmentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleAttachmentPost200Response>> SaleAttachmentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "SaleApi.SaleAttachmentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleAttachmentPost200Response>("/sale/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleAttachmentPost", localVarResponse);
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
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleAttachmentPost200Response</returns>
        public SaleAttachmentPost200Response SaleAttachmentSaleidGet(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleAttachmentPost200Response> localVarResponse = SaleAttachmentSaleidGetWithHttpInfo(saleID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleAttachmentPost200Response</returns>
        public ApiResponse<SaleAttachmentPost200Response> SaleAttachmentSaleidGetWithHttpInfo(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleAttachmentSaleidGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleAttachmentSaleidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleAttachmentPost200Response>("/sale/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleAttachmentSaleidGet", localVarResponse);
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
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleAttachmentPost200Response</returns>
        public async System.Threading.Tasks.Task<SaleAttachmentPost200Response> SaleAttachmentSaleidGetAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleAttachmentPost200Response> localVarResponse = await SaleAttachmentSaleidGetWithHttpInfoAsync(saleID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Attachments of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleAttachmentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleAttachmentPost200Response>> SaleAttachmentSaleidGetWithHttpInfoAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleAttachmentSaleidGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleAttachmentSaleidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleAttachmentPost200Response>("/sale/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleAttachmentSaleidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void SaleCreditnotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            SaleCreditnotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// POST + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> SaleCreditnotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [];

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

            localVarRequestOptions.Operation = "SaleApi.SaleCreditnotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<object>("/sale/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleCreditnotePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SaleCreditnotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await SaleCreditnotePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// POST + POST method will return exception if Credit Note status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Invoice status is not &#x60;AUTHORISED&#x60; or &#x60;PAID&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Credit Note Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> SaleCreditnotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [];

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

            localVarRequestOptions.Operation = "SaleApi.SaleCreditnotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<object>("/sale/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleCreditnotePost", localVarResponse);
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
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, includePaymentInfo, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [];

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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludePaymentInfo", ClientUtils.ParameterToString(includePaymentInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/sale/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet", localVarResponse);
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
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfoAsync(saleID, combineAdditionalCharges, includeProductInfo, includePaymentInfo, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Credit Notes info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="includePaymentInfo">Show all Credit Note payments in additional array and calculate the Credit Note balance (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, bool includePaymentInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet");
            }

            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [];

            // to determine the Accept header
            string[] _accepts = [];

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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludePaymentInfo", ClientUtils.ParameterToString(includePaymentInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/sale/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleCreditnoteSaleidCombineadditionalchargesIncludeproductinfoIncludepaymentinfoGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleCreditnoteTaskidVoidDelete200Response</returns>
        public SaleCreditnoteTaskidVoidDelete200Response SaleCreditnoteTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleCreditnoteTaskidVoidDelete200Response> localVarResponse = SaleCreditnoteTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleCreditnoteTaskidVoidDelete200Response</returns>
        public ApiResponse<SaleCreditnoteTaskidVoidDelete200Response> SaleCreditnoteTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleCreditnoteTaskidVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleCreditnoteTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<SaleCreditnoteTaskidVoidDelete200Response>("/sale/creditnote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleCreditnoteTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleCreditnoteTaskidVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<SaleCreditnoteTaskidVoidDelete200Response> SaleCreditnoteTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleCreditnoteTaskidVoidDelete200Response> localVarResponse = await SaleCreditnoteTaskidVoidDeleteWithHttpInfoAsync(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Credit Note with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleCreditnoteTaskidVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleCreditnoteTaskidVoidDelete200Response>> SaleCreditnoteTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleCreditnoteTaskidVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleCreditnoteTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<SaleCreditnoteTaskidVoidDelete200Response>("/sale/creditnote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleCreditnoteTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPackPut200Response</returns>
        public SaleFulfilmentPackPut200Response SaleFulfilmentPackPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentPackPut200Response> localVarResponse = SaleFulfilmentPackPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPackPut200Response</returns>
        public ApiResponse<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleFulfilmentPackPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPackPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleFulfilmentPackPut200Response>("/sale/fulfilment/pack", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPackPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPackPut200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentPackPut200Response> localVarResponse = await SaleFulfilmentPackPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPackPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPackPut200Response>> SaleFulfilmentPackPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleFulfilmentPackPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPackPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleFulfilmentPackPut200Response>("/sale/fulfilment/pack", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPackPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPackPut200Response</returns>
        public SaleFulfilmentPackPut200Response SaleFulfilmentPackPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentPackPut200Response> localVarResponse = SaleFulfilmentPackPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPackPut200Response</returns>
        public ApiResponse<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleFulfilmentPackPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPackPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<SaleFulfilmentPackPut200Response>("/sale/fulfilment/pack", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPackPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPackPut200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentPackPut200Response> SaleFulfilmentPackPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentPackPut200Response> localVarResponse = await SaleFulfilmentPackPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPackPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Pack status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPackPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPackPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPackPut200Response>> SaleFulfilmentPackPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPackPutRequest? saleFulfilmentPackPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleFulfilmentPackPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPackPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<SaleFulfilmentPackPut200Response>("/sale/fulfilment/pack", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPackPut", localVarResponse);
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
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPackTaskidIncludeproductinfoGet200Response</returns>
        public SaleFulfilmentPackTaskidIncludeproductinfoGet200Response SaleFulfilmentPackTaskidIncludeproductinfoGet(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response> localVarResponse = SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfo(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPackTaskidIncludeproductinfoGet200Response</returns>
        public ApiResponse<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response> SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfo(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentPackTaskidIncludeproductinfoGet");
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
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPackTaskidIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response>("/sale/fulfilment/pack", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPackTaskidIncludeproductinfoGet", localVarResponse);
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
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPackTaskidIncludeproductinfoGet200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response> SaleFulfilmentPackTaskidIncludeproductinfoGetAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response> localVarResponse = await SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfoAsync(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPackTaskidIncludeproductinfoGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response>> SaleFulfilmentPackTaskidIncludeproductinfoGetWithHttpInfoAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentPackTaskidIncludeproductinfoGet");
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
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPackTaskidIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleFulfilmentPackTaskidIncludeproductinfoGet200Response>("/sale/fulfilment/pack", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPackTaskidIncludeproductinfoGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPickPut200Response</returns>
        public SaleFulfilmentPickPut200Response SaleFulfilmentPickPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentPickPut200Response> localVarResponse = SaleFulfilmentPickPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPickPut200Response</returns>
        public ApiResponse<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleFulfilmentPickPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPickPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleFulfilmentPickPut200Response>("/sale/fulfilment/pick", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPickPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPickPut200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentPickPut200Response> localVarResponse = await SaleFulfilmentPickPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPickPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPickPut200Response>> SaleFulfilmentPickPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleFulfilmentPickPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPickPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleFulfilmentPickPut200Response>("/sale/fulfilment/pick", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPickPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPickPut200Response</returns>
        public SaleFulfilmentPickPut200Response SaleFulfilmentPickPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentPickPut200Response> localVarResponse = SaleFulfilmentPickPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPickPut200Response</returns>
        public ApiResponse<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleFulfilmentPickPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPickPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<SaleFulfilmentPickPut200Response>("/sale/fulfilment/pick", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPickPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPickPut200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentPickPut200Response> SaleFulfilmentPickPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentPickPut200Response> localVarResponse = await SaleFulfilmentPickPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPickPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Pick status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + To make autopick call the method with attributes &#x60;TaskID&#x60; and &#x60;AutoPickMode&#x60; &#x3D; &#x60;AUTOPICK&#x60;. Pick Status will be changed to \&quot;AUTHORISED\&quot; automatically.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPickPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPickPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPickPut200Response>> SaleFulfilmentPickPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPickPutRequest? saleFulfilmentPickPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleFulfilmentPickPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPickPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<SaleFulfilmentPickPut200Response>("/sale/fulfilment/pick", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPickPut", localVarResponse);
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
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPickPut200Response</returns>
        public SaleFulfilmentPickPut200Response SaleFulfilmentPickTaskidIncludeproductinfoGet(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentPickPut200Response> localVarResponse = SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfo(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPickPut200Response</returns>
        public ApiResponse<SaleFulfilmentPickPut200Response> SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfo(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentPickTaskidIncludeproductinfoGet");
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
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPickTaskidIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleFulfilmentPickPut200Response>("/sale/fulfilment/pick", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPickTaskidIncludeproductinfoGet", localVarResponse);
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
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPickPut200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentPickPut200Response> SaleFulfilmentPickTaskidIncludeproductinfoGetAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentPickPut200Response> localVarResponse = await SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfoAsync(taskID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPickPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPickPut200Response>> SaleFulfilmentPickTaskidIncludeproductinfoGetWithHttpInfoAsync(string taskID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentPickTaskidIncludeproductinfoGet");
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
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPickTaskidIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleFulfilmentPickPut200Response>("/sale/fulfilment/pick", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPickTaskidIncludeproductinfoGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentPost200Response</returns>
        public SaleFulfilmentPost200Response SaleFulfilmentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentPost200Response> localVarResponse = SaleFulfilmentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentPost200Response</returns>
        public ApiResponse<SaleFulfilmentPost200Response> SaleFulfilmentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleFulfilmentPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleFulfilmentPost200Response>("/sale/fulfilment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentPost200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentPost200Response> SaleFulfilmentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentPost200Response> localVarResponse = await SaleFulfilmentPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will create new Fulfilment Task.  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + New Fulfilment Task can be created if there is no fulfilment tasks with non &#x60;AUTHORISED&#x60; Pick status.  + Adding new Fulfilment Task to sale with &#x60;Type&#x60; &#x3D; &#x60;Simple Sale&#x60; will change sale &#x60;Type&#x60; to &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentPost200Response>> SaleFulfilmentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentPostRequest? saleFulfilmentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleFulfilmentPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleFulfilmentPost200Response>("/sale/fulfilment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentPost", localVarResponse);
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
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentSaleidIncludeproductinfoGet200Response</returns>
        public SaleFulfilmentSaleidIncludeproductinfoGet200Response SaleFulfilmentSaleidIncludeproductinfoGet(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentSaleidIncludeproductinfoGet200Response> localVarResponse = SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfo(saleID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentSaleidIncludeproductinfoGet200Response</returns>
        public ApiResponse<SaleFulfilmentSaleidIncludeproductinfoGet200Response> SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfo(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleFulfilmentSaleidIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentSaleidIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleFulfilmentSaleidIncludeproductinfoGet200Response>("/sale/fulfilment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentSaleidIncludeproductinfoGet", localVarResponse);
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
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentSaleidIncludeproductinfoGet200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentSaleidIncludeproductinfoGet200Response> SaleFulfilmentSaleidIncludeproductinfoGetAsync(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentSaleidIncludeproductinfoGet200Response> localVarResponse = await SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfoAsync(saleID, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Fulfilment info of a particular sale</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentSaleidIncludeproductinfoGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentSaleidIncludeproductinfoGet200Response>> SaleFulfilmentSaleidIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleFulfilmentSaleidIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentSaleidIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleFulfilmentSaleidIncludeproductinfoGet200Response>("/sale/fulfilment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentSaleidIncludeproductinfoGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentShipPut200Response</returns>
        public SaleFulfilmentShipPut200Response SaleFulfilmentShipPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentShipPut200Response> localVarResponse = SaleFulfilmentShipPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentShipPut200Response</returns>
        public ApiResponse<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleFulfilmentShipPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentShipPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleFulfilmentShipPut200Response>("/sale/fulfilment/ship", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentShipPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentShipPut200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentShipPut200Response> localVarResponse = await SaleFulfilmentShipPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + POST method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentShipPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentShipPut200Response>> SaleFulfilmentShipPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleFulfilmentShipPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentShipPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleFulfilmentShipPut200Response>("/sale/fulfilment/ship", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentShipPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentShipPut200Response</returns>
        public SaleFulfilmentShipPut200Response SaleFulfilmentShipPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentShipPut200Response> localVarResponse = SaleFulfilmentShipPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentShipPut200Response</returns>
        public ApiResponse<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleFulfilmentShipPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentShipPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<SaleFulfilmentShipPut200Response>("/sale/fulfilment/ship", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentShipPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentShipPut200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentShipPut200Response> SaleFulfilmentShipPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentShipPut200Response> localVarResponse = await SaleFulfilmentShipPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleFulfilmentShipPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if PackStatus status is not - &#x60;AUTHORISED&#x60;  + PUT method will return exception if ShipmentStatus status is - &#x60;AUTHORISED&#x60; or &#x60;PARTIALLY AUTHORISED&#x60;  + Add filed &#x60;AddTrackingNumbers&#x60; &#x3D; &#x60;true&#x60; to payload to be able to update tracking numbers or carrier for authorised shipment
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleFulfilmentShipPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentShipPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentShipPut200Response>> SaleFulfilmentShipPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleFulfilmentShipPutRequest? saleFulfilmentShipPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleFulfilmentShipPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentShipPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<SaleFulfilmentShipPut200Response>("/sale/fulfilment/ship", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentShipPut", localVarResponse);
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
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentShipTaskidGet200Response</returns>
        public SaleFulfilmentShipTaskidGet200Response SaleFulfilmentShipTaskidGet(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentShipTaskidGet200Response> localVarResponse = SaleFulfilmentShipTaskidGetWithHttpInfo(taskID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentShipTaskidGet200Response</returns>
        public ApiResponse<SaleFulfilmentShipTaskidGet200Response> SaleFulfilmentShipTaskidGetWithHttpInfo(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentShipTaskidGet");
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

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentShipTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleFulfilmentShipTaskidGet200Response>("/sale/fulfilment/ship", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentShipTaskidGet", localVarResponse);
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
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentShipTaskidGet200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentShipTaskidGet200Response> SaleFulfilmentShipTaskidGetAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentShipTaskidGet200Response> localVarResponse = await SaleFulfilmentShipTaskidGetWithHttpInfoAsync(taskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">TaskID of Fulfilment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentShipTaskidGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentShipTaskidGet200Response>> SaleFulfilmentShipTaskidGetWithHttpInfoAsync(string taskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentShipTaskidGet");
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

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentShipTaskidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleFulfilmentShipTaskidGet200Response>("/sale/fulfilment/ship", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentShipTaskidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleFulfilmentTaskidVoidDelete200Response</returns>
        public SaleFulfilmentTaskidVoidDelete200Response SaleFulfilmentTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleFulfilmentTaskidVoidDelete200Response> localVarResponse = SaleFulfilmentTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleFulfilmentTaskidVoidDelete200Response</returns>
        public ApiResponse<SaleFulfilmentTaskidVoidDelete200Response> SaleFulfilmentTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentTaskidVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<SaleFulfilmentTaskidVoidDelete200Response>("/sale/fulfilment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleFulfilmentTaskidVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<SaleFulfilmentTaskidVoidDelete200Response> SaleFulfilmentTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleFulfilmentTaskidVoidDelete200Response> localVarResponse = await SaleFulfilmentTaskidVoidDeleteWithHttpInfoAsync(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleFulfilmentTaskidVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleFulfilmentTaskidVoidDelete200Response>> SaleFulfilmentTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleFulfilmentTaskidVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleFulfilmentTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<SaleFulfilmentTaskidVoidDelete200Response>("/sale/fulfilment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleFulfilmentTaskidVoidDelete", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response</returns>
        public SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response> localVarResponse = SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfo(ID, combineAdditionalCharges, hideInventoryMovements, includeTransactions, countryFormat, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response</returns>
        public ApiResponse<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response> SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfo(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet");
            }

            // verify the required parameter 'countryFormat' is set
            if (countryFormat == null)
            {
                throw new ApiException(400, "Missing required parameter 'countryFormat' when calling SaleApi->SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet");
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
            localVarRequestOptions.QueryParameters.Add("HideInventoryMovements", ClientUtils.ParameterToString(hideInventoryMovements)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeTransactions", ClientUtils.ParameterToString(includeTransactions)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CountryFormat", ClientUtils.ParameterToString(countryFormat)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = Client.Get<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response>($"/sale", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response</returns>
        public async System.Threading.Tasks.Task<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response> SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetAsync(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response> localVarResponse = await SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfoAsync(ID, combineAdditionalCharges, hideInventoryMovements, includeTransactions, countryFormat, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="hideInventoryMovements">Hide inventory movements (Default &#x3D; false)</param>
        /// <param name="includeTransactions">Show related transactions (Default &#x3D; false)</param>
        /// <param name="countryFormat">Return Country Names or Country Codes. Can be Regular, Code2 or Code (Default &#x3D; Regular)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response>> SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGetWithHttpInfoAsync(string ID, bool combineAdditionalCharges, bool hideInventoryMovements, bool includeTransactions, string countryFormat, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet");
            }

            // verify the required parameter 'countryFormat' is set
            if (countryFormat == null)
            {
                throw new ApiException(400, "Missing required parameter 'countryFormat' when calling SaleApi->SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet");
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
            localVarRequestOptions.QueryParameters.Add("HideInventoryMovements", ClientUtils.ParameterToString(hideInventoryMovements)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeTransactions", ClientUtils.ParameterToString(includeTransactions)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CountryFormat", ClientUtils.ParameterToString(countryFormat)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet200Response>($"/sale", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleIdCombineadditionalchargesHideinventorymovementsIncludetransactionsCountryformatGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleIdVoidDelete200Response</returns>
        public SaleIdVoidDelete200Response SaleIdVoidDelete(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleIdVoidDelete200Response> localVarResponse = SaleIdVoidDeleteWithHttpInfo(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleIdVoidDelete200Response</returns>
        public ApiResponse<SaleIdVoidDelete200Response> SaleIdVoidDeleteWithHttpInfo(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SaleIdVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleIdVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<SaleIdVoidDelete200Response>($"/sale", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleIdVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleIdVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<SaleIdVoidDelete200Response> SaleIdVoidDeleteAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleIdVoidDelete200Response> localVarResponse = await SaleIdVoidDeleteWithHttpInfoAsync(ID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Sale to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleIdVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleIdVoidDelete200Response>> SaleIdVoidDeleteWithHttpInfoAsync(string ID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SaleIdVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleIdVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<SaleIdVoidDelete200Response>($"/sale", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleIdVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoicePost200Response</returns>
        public SaleInvoicePost200Response SaleInvoicePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleInvoicePost200Response> localVarResponse = SaleInvoicePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleInvoicePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoicePost200Response</returns>
        public ApiResponse<SaleInvoicePost200Response> SaleInvoicePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleInvoicePostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleInvoicePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleInvoicePost200Response>("/sale/invoice", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoicePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoicePost200Response</returns>
        public async System.Threading.Tasks.Task<SaleInvoicePost200Response> SaleInvoicePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleInvoicePost200Response> localVarResponse = await SaleInvoicePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleInvoicePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + If set &#x60;TaskID&#x60; value to Guid empty (&#x60;00000000-0000-0000-0000-000000000000&#x60;), then new Invoice Task will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleInvoicePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoicePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleInvoicePost200Response>> SaleInvoicePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleInvoicePostRequest? saleInvoicePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleInvoicePostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleInvoicePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleInvoicePost200Response>("/sale/invoice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoicePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoicePut200Response</returns>
        public SaleInvoicePut200Response SaleInvoicePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleInvoicePut200Response> localVarResponse = SaleInvoicePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoicePut200Response</returns>
        public ApiResponse<SaleInvoicePut200Response> SaleInvoicePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "SaleApi.SaleInvoicePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<SaleInvoicePut200Response>("/sale/invoice", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoicePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoicePut200Response</returns>
        public async System.Threading.Tasks.Task<SaleInvoicePut200Response> SaleInvoicePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleInvoicePut200Response> localVarResponse = await SaleInvoicePutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + PUT method will return exception if Invoice does not exist or Invoice status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + PUT method will return exception if Order status is not &#x60;AUTHORISED&#x60;.  + It is allowed to not provide some attributes including Lines and AdditionalCharges. Note that provided empty collection means deleting existing records if there were any.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoicePut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleInvoicePut200Response>> SaleInvoicePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "SaleApi.SaleInvoicePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<SaleInvoicePut200Response>("/sale/invoice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoicePut", localVarResponse);
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
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoicePost200Response</returns>
        public SaleInvoicePost200Response SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleInvoicePost200Response> localVarResponse = SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoicePost200Response</returns>
        public ApiResponse<SaleInvoicePost200Response> SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleInvoicePost200Response>("/sale/invoice", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet", localVarResponse);
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
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoicePost200Response</returns>
        public async System.Threading.Tasks.Task<SaleInvoicePost200Response> SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleInvoicePost200Response> localVarResponse = await SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Invoice info of a particular sale</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoicePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleInvoicePost200Response>> SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleInvoicePost200Response>("/sale/invoice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoiceSaleidCombineadditionalchargesIncludeproductinfoGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleInvoiceTaskidVoidDelete200Response</returns>
        public SaleInvoiceTaskidVoidDelete200Response SaleInvoiceTaskidVoidDelete(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleInvoiceTaskidVoidDelete200Response> localVarResponse = SaleInvoiceTaskidVoidDeleteWithHttpInfo(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleInvoiceTaskidVoidDelete200Response</returns>
        public ApiResponse<SaleInvoiceTaskidVoidDelete200Response> SaleInvoiceTaskidVoidDeleteWithHttpInfo(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleInvoiceTaskidVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleInvoiceTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<SaleInvoiceTaskidVoidDelete200Response>("/sale/invoice", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoiceTaskidVoidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleInvoiceTaskidVoidDelete200Response</returns>
        public async System.Threading.Tasks.Task<SaleInvoiceTaskidVoidDelete200Response> SaleInvoiceTaskidVoidDeleteAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleInvoiceTaskidVoidDelete200Response> localVarResponse = await SaleInvoiceTaskidVoidDeleteWithHttpInfoAsync(taskID, varVoid, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE + This method works only for:     + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;      + Sales with &#x60;Type&#x60; &#x3D; &#x60;Advanced Sale&#x60; and Invoice with  &#x60;TaskID&#x60; &#x3D; &#x60;SaleID&#x60;
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskID">ID of Sale task to Void or Undo</param>
        /// <param name="varVoid"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleInvoiceTaskidVoidDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleInvoiceTaskidVoidDelete200Response>> SaleInvoiceTaskidVoidDeleteWithHttpInfoAsync(string taskID, bool varVoid, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'taskID' is set
            if (taskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'taskID' when calling SaleApi->SaleInvoiceTaskidVoidDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SaleInvoiceTaskidVoidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<SaleInvoiceTaskidVoidDelete200Response>("/sale/invoice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleInvoiceTaskidVoidDelete", localVarResponse);
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
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleManualjournalPostRequest</returns>
        public SaleManualjournalPostRequest SaleManualjournalPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleManualjournalPostRequest> localVarResponse = SaleManualjournalPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleManualjournalPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleManualjournalPostRequest</returns>
        public ApiResponse<SaleManualjournalPostRequest> SaleManualjournalPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleManualjournalPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleManualjournalPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleManualjournalPostRequest>("/sale/manualJournal", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleManualjournalPost", localVarResponse);
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
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleManualjournalPostRequest</returns>
        public async System.Threading.Tasks.Task<SaleManualjournalPostRequest> SaleManualjournalPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleManualjournalPostRequest> localVarResponse = await SaleManualjournalPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleManualjournalPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleManualjournalPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleManualjournalPostRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleManualjournalPostRequest>> SaleManualjournalPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleManualjournalPostRequest? saleManualjournalPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleManualjournalPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleManualjournalPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleManualjournalPostRequest>("/sale/manualJournal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleManualjournalPost", localVarResponse);
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
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleManualjournalSaleidGet200Response</returns>
        public SaleManualjournalSaleidGet200Response SaleManualjournalSaleidGet(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleManualjournalSaleidGet200Response> localVarResponse = SaleManualjournalSaleidGetWithHttpInfo(saleID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleManualjournalSaleidGet200Response</returns>
        public ApiResponse<SaleManualjournalSaleidGet200Response> SaleManualjournalSaleidGetWithHttpInfo(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleManualjournalSaleidGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleManualjournalSaleidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleManualjournalSaleidGet200Response>("/sale/manualJournal", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleManualjournalSaleidGet", localVarResponse);
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
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleManualjournalSaleidGet200Response</returns>
        public async System.Threading.Tasks.Task<SaleManualjournalSaleidGet200Response> SaleManualjournalSaleidGetAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleManualjournalSaleidGet200Response> localVarResponse = await SaleManualjournalSaleidGetWithHttpInfoAsync(saleID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleManualjournalSaleidGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleManualjournalSaleidGet200Response>> SaleManualjournalSaleidGetWithHttpInfoAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleManualjournalSaleidGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleManualjournalSaleidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleManualjournalSaleidGet200Response>("/sale/manualJournal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleManualjournalSaleidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleOrderPost200Response</returns>
        public SaleOrderPost200Response SaleOrderPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleOrderPost200Response> localVarResponse = SaleOrderPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleOrderPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleOrderPost200Response</returns>
        public ApiResponse<SaleOrderPost200Response> SaleOrderPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleOrderPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleOrderPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleOrderPost200Response>("/sale/order", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleOrderPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleOrderPost200Response</returns>
        public async System.Threading.Tasks.Task<SaleOrderPost200Response> SaleOrderPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleOrderPost200Response> localVarResponse = await SaleOrderPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleOrderPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Order status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Quote status is not &#x60;AUTHORISED&#x60;.  + POST method can accept \&quot;AutoPickPackShipMode\&quot; property in body.     + Default: &#x60;NOPICK&#x60;     + This property affects only Sales with Type &#x3D; &#x60;Simple Sale&#x60; and with no backorder  when changing order status to &#x60;AUTHORISED&#x60;  + Available valus for AutoPickPackShipMode     + &#x60;NOPICK&#x60; - Order will be created without picking     + &#x60;AUTOPICK&#x60; - Order sill be created with Pick phase authorised      + &#x60;AUTOPICKPACK&#x60; - Order sill be created with Pick and Pack phases authorised     + &#x60;AUTOPICKPACKSHIP&#x60; - Order sill be created with Pick and Pack and Ship phases authorised  + If you add to Order product with quantity more than you have. Cin7 Core silently create backorder record for this product when changing order status to &#x60;AUTHORISED&#x60;.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleOrderPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleOrderPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleOrderPost200Response>> SaleOrderPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleOrderPostRequest? saleOrderPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleOrderPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleOrderPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleOrderPost200Response>("/sale/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleOrderPost", localVarResponse);
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
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleOrderPost200Response</returns>
        public SaleOrderPost200Response SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleOrderPost200Response> localVarResponse = SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleOrderPost200Response</returns>
        public ApiResponse<SaleOrderPost200Response> SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleOrderPost200Response>("/sale/order", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet", localVarResponse);
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
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleOrderPost200Response</returns>
        public async System.Threading.Tasks.Task<SaleOrderPost200Response> SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleOrderPost200Response> localVarResponse = await SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Orders</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleOrderPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleOrderPost200Response>> SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleOrderPost200Response>("/sale/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleOrderSaleidCombineadditionalchargesIncludeproductinfoGet", localVarResponse);
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
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        public MeAddressesIdDelete200Response SalePaymentIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = SalePaymentIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        public ApiResponse<MeAddressesIdDelete200Response> SalePaymentIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SalePaymentIdDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SalePaymentIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<MeAddressesIdDelete200Response>("/sale/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentIdDelete", localVarResponse);
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
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        public async System.Threading.Tasks.Task<MeAddressesIdDelete200Response> SalePaymentIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = await SalePaymentIdDeleteWithHttpInfoAsync(ID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Payment to Delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> SalePaymentIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling SaleApi->SalePaymentIdDelete");
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

            localVarRequestOptions.Operation = "SaleApi.SalePaymentIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<MeAddressesIdDelete200Response>("/sale/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentIdDelete", localVarResponse);
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
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SalePaymentPost200Response</returns>
        public SalePaymentPost200Response SalePaymentPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<SalePaymentPost200Response> localVarResponse = SalePaymentPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, salePaymentPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SalePaymentPost200Response</returns>
        public ApiResponse<SalePaymentPost200Response> SalePaymentPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = salePaymentPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SalePaymentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SalePaymentPost200Response>("/sale/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentPost", localVarResponse);
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
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SalePaymentPost200Response</returns>
        public async System.Threading.Tasks.Task<SalePaymentPost200Response> SalePaymentPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SalePaymentPost200Response> localVarResponse = await SalePaymentPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, salePaymentPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SalePaymentPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SalePaymentPost200Response>> SalePaymentPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPostRequest? salePaymentPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = salePaymentPostRequest;

            localVarRequestOptions.Operation = "SaleApi.SalePaymentPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SalePaymentPost200Response>("/sale/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentPost", localVarResponse);
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
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SalePaymentPut200Response</returns>
        public SalePaymentPut200Response SalePaymentPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<SalePaymentPut200Response> localVarResponse = SalePaymentPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, salePaymentPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SalePaymentPut200Response</returns>
        public ApiResponse<SalePaymentPut200Response> SalePaymentPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = salePaymentPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SalePaymentPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<SalePaymentPut200Response>("/sale/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentPut", localVarResponse);
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
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SalePaymentPut200Response</returns>
        public async System.Threading.Tasks.Task<SalePaymentPut200Response> SalePaymentPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SalePaymentPut200Response> localVarResponse = await SalePaymentPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, salePaymentPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Please note, that Payment with type Prepayment cannot be modified.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="salePaymentPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SalePaymentPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SalePaymentPut200Response>> SalePaymentPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SalePaymentPutRequest? salePaymentPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = salePaymentPutRequest;

            localVarRequestOptions.Operation = "SaleApi.SalePaymentPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<SalePaymentPut200Response>("/sale/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentPut", localVarResponse);
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
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;SalePaymentSaleidGet200ResponseInner&gt;</returns>
        public List<SalePaymentSaleidGet200ResponseInner> SalePaymentSaleidGet(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<List<SalePaymentSaleidGet200ResponseInner>> localVarResponse = SalePaymentSaleidGetWithHttpInfo(saleID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;SalePaymentSaleidGet200ResponseInner&gt;</returns>
        public ApiResponse<List<SalePaymentSaleidGet200ResponseInner>> SalePaymentSaleidGetWithHttpInfo(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SalePaymentSaleidGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SalePaymentSaleidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<List<SalePaymentSaleidGet200ResponseInner>>("/sale/payment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentSaleidGet", localVarResponse);
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
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SalePaymentSaleidGet200ResponseInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<SalePaymentSaleidGet200ResponseInner>> SalePaymentSaleidGetAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<List<SalePaymentSaleidGet200ResponseInner>> localVarResponse = await SalePaymentSaleidGetWithHttpInfoAsync(saleID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">Returns Payment info of a particular sale</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SalePaymentSaleidGet200ResponseInner&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SalePaymentSaleidGet200ResponseInner>>> SalePaymentSaleidGetWithHttpInfoAsync(string saleID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SalePaymentSaleidGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SalePaymentSaleidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<List<SalePaymentSaleidGet200ResponseInner>>("/sale/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePaymentSaleidGet", localVarResponse);
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
        /// <returns>SalePost200Response</returns>
        public SalePost200Response SalePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SalePost200Response> localVarResponse = SalePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SalePost200Response</returns>
        public ApiResponse<SalePost200Response> SalePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "SaleApi.SalePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SalePost200Response>("/sale", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePost", localVarResponse);
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
        /// <returns>Task of SalePost200Response</returns>
        public async System.Threading.Tasks.Task<SalePost200Response> SalePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SalePost200Response> localVarResponse = await SalePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
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
        /// <returns>Task of ApiResponse (SalePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SalePost200Response>> SalePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "SaleApi.SalePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SalePost200Response>("/sale", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePost", localVarResponse);
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SalePut200Response</returns>
        public SalePut200Response SalePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SalePut200Response> localVarResponse = SalePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SalePut200Response</returns>
        public ApiResponse<SalePut200Response> SalePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "SaleApi.SalePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<SalePut200Response>("/sale", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePut", localVarResponse);
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SalePut200Response</returns>
        public async System.Threading.Tasks.Task<SalePut200Response> SalePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SalePut200Response> localVarResponse = await SalePutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SalePut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SalePut200Response>> SalePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "SaleApi.SalePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<SalePut200Response>("/sale", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SalePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleQuotePost200Response</returns>
        public SaleQuotePost200Response SaleQuotePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<SaleQuotePost200Response> localVarResponse = SaleQuotePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, saleQuotePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleQuotePost200Response</returns>
        public ApiResponse<SaleQuotePost200Response> SaleQuotePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = saleQuotePostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleQuotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<SaleQuotePost200Response>("/sale/quote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleQuotePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleQuotePost200Response</returns>
        public async System.Threading.Tasks.Task<SaleQuotePost200Response> SaleQuotePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleQuotePost200Response> localVarResponse = await SaleQuotePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, saleQuotePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + POST method will return exception if Quote status is not - &#x60;DRAFT&#x60; or &#x60;NOT AVAILABLE&#x60;  + POST method will return exception if Sale&#39;s SkipQuote parameter is &#x60;true&#x60;.  + POST method does not support stand alone Credit Notes.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="saleQuotePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleQuotePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleQuotePost200Response>> SaleQuotePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SaleQuotePostRequest? saleQuotePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = saleQuotePostRequest;

            localVarRequestOptions.Operation = "SaleApi.SaleQuotePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<SaleQuotePost200Response>("/sale/quote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleQuotePost", localVarResponse);
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
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SaleQuotePost200Response</returns>
        public SaleQuotePost200Response SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<SaleQuotePost200Response> localVarResponse = SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SaleQuotePost200Response</returns>
        public ApiResponse<SaleQuotePost200Response> SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfo(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<SaleQuotePost200Response>("/sale/quote", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet", localVarResponse);
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
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SaleQuotePost200Response</returns>
        public async System.Threading.Tasks.Task<SaleQuotePost200Response> SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SaleQuotePost200Response> localVarResponse = await SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(saleID, combineAdditionalCharges, includeProductInfo, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="saleID">SaleID of Quotes</param>
        /// <param name="combineAdditionalCharges">Show additional charges in &#39;Lines&#39; array (Default &#x3D; false)</param>
        /// <param name="includeProductInfo">Show all used products in additional array (Default &#x3D; false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SaleQuotePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaleQuotePost200Response>> SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGetWithHttpInfoAsync(string saleID, bool combineAdditionalCharges, bool includeProductInfo, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'saleID' is set
            if (saleID == null)
            {
                throw new ApiException(400, "Missing required parameter 'saleID' when calling SaleApi->SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet");
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

            localVarRequestOptions.QueryParameters.Add("SaleID", ClientUtils.ParameterToString(saleID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CombineAdditionalCharges", ClientUtils.ParameterToString(combineAdditionalCharges)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeProductInfo", ClientUtils.ParameterToString(includeProductInfo)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "SaleApi.SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<SaleQuotePost200Response>("/sale/quote", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SaleQuoteSaleidCombineadditionalchargesIncludeproductinfoGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
    }
}