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

namespace CIN7.DearInventory.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductionApiSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Authorize
        /// </summary>
        /// <remarks>
        /// + Method will authorize Production Order. Recalculates capacity.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Authorize200Response</returns>
        Authorize200Response Authorize(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0);

        /// <summary>
        /// Authorize
        /// </summary>
        /// <remarks>
        /// + Method will authorize Production Order. Recalculates capacity.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Authorize200Response</returns>
        ApiResponse<Authorize200Response> AuthorizeWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0);

        /// <summary>
        /// Void
        /// </summary>
        /// <remarks>
        /// + Method will void Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Undo200Response</returns>
        Undo200Response CallVoid(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0);

        /// <summary>
        /// Void
        /// </summary>
        /// <remarks>
        /// + Method will void Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Undo200Response</returns>
        ApiResponse<Undo200Response> CallVoidWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0);

        /// <summary>
        /// Complete Run
        /// </summary>
        /// <remarks>
        /// + Method will complete Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CompleteRun200Response</returns>
        CompleteRun200Response CompleteRun(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0);

        /// <summary>
        /// Complete Run
        /// </summary>
        /// <remarks>
        /// + Method will complete Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CompleteRun200Response</returns>
        ApiResponse<CompleteRun200Response> CompleteRunWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0);

        /// <summary>
        /// Complete Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will complete operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CompleteRunOperation200Response</returns>
        CompleteRunOperation200Response CompleteRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Complete Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will complete operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CompleteRunOperation200Response</returns>
        ApiResponse<CompleteRunOperation200Response> CompleteRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Delete Attachment
        /// </summary>
        /// <remarks>
        /// + Method will delete Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteAttachment(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Delete Attachment
        /// </summary>
        /// <remarks>
        /// + Method will delete Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> DeleteAttachmentWithHttpInfo(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Get Production Order Attachments
        /// </summary>
        /// <remarks>
        /// + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetProductionOrderAttachments200Response</returns>
        GetProductionOrderAttachments200Response GetProductionOrderAttachments(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Get Production Order Attachments
        /// </summary>
        /// <remarks>
        /// + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetProductionOrderAttachments200Response</returns>
        ApiResponse<GetProductionOrderAttachments200Response> GetProductionOrderAttachmentsWithHttpInfo(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Get Production Order Reference Data
        /// </summary>
        /// <remarks>
        /// + Method will return accumulated reference data useful for creating and updating production orders.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetProductionOrderReferenceData200Response</returns>
        GetProductionOrderReferenceData200Response GetProductionOrderReferenceData(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Get Production Order Reference Data
        /// </summary>
        /// <remarks>
        /// + Method will return accumulated reference data useful for creating and updating production orders.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetProductionOrderReferenceData200Response</returns>
        ApiResponse<GetProductionOrderReferenceData200Response> GetProductionOrderReferenceDataWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Orders and Production Runs according to provided filters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void OrderlistPgLmtStsSrchEtc(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Orders and Production Runs according to provided filters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> OrderlistPgLmtStsSrchEtcWithHttpInfo(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Post Attachment
        /// </summary>
        /// <remarks>
        /// + Method will add a Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PutAttachment200Response</returns>
        PutAttachment200Response PostAttachment(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0);

        /// <summary>
        /// Post Attachment
        /// </summary>
        /// <remarks>
        /// + Method will add a Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PutAttachment200Response</returns>
        ApiResponse<PutAttachment200Response> PostAttachmentWithHttpInfo(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionFactorycalendarPutRequest</returns>
        ProductionFactorycalendarPutRequest ProductionFactorycalendarPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionFactorycalendarPutRequest</returns>
        ApiResponse<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionFactorycalendarPutRequest</returns>
        ProductionFactorycalendarPutRequest ProductionFactorycalendarPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionFactorycalendarPutRequest</returns>
        ApiResponse<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionFactorycalendarPutRequest</returns>
        ProductionFactorycalendarPutRequest ProductionFactorycalendarYearGet(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionFactorycalendarPutRequest</returns>
        ApiResponse<ProductionFactorycalendarPutRequest> ProductionFactorycalendarYearGetWithHttpInfo(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response</returns>
        ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response</returns>
        ApiResponse<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response> ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfo(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Order and its nested items.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionOrderProductionorderidReturnattachmentscontentGet200Response</returns>
        ProductionOrderProductionorderidReturnattachmentscontentGet200Response ProductionOrderProductionorderidReturnattachmentscontentGet(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Order and its nested items.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionOrderProductionorderidReturnattachmentscontentGet200Response</returns>
        ApiResponse<ProductionOrderProductionorderidReturnattachmentscontentGet200Response> ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfo(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionOrderRecalculatedatesPost200Response</returns>
        ProductionOrderRecalculatedatesPost200Response ProductionOrderRecalculatedatesPost(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionOrderRecalculatedatesPost200Response</returns>
        ApiResponse<ProductionOrderRecalculatedatesPost200Response> ProductionOrderRecalculatedatesPostWithHttpInfo(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionOrderRunPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionOrderRunPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionOrderRunProductionorderidIncludeattachmentcontentGet(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfo(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionOrderRunProductionorderidIncreaseorderquantityPut(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfo(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomPost200Response</returns>
        ProductionProductionbomPost200Response ProductionProductionbomPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomPost200Response</returns>
        ApiResponse<ProductionProductionbomPost200Response> ProductionProductionbomPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionProductionbomProductfamilyidBomidDelete(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfo(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response</returns>
        ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response ProductionProductionbomProductfamilyidReturnattachmentscontentGet(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response</returns>
        ApiResponse<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response> ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfo(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionProductionbomProductidBomidDelete(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionProductionbomProductidBomidDeleteWithHttpInfo(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomProductidReturnattachmentscontentGet200Response</returns>
        ProductionProductionbomProductidReturnattachmentscontentGet200Response ProductionProductionbomProductidReturnattachmentscontentGet(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomProductidReturnattachmentscontentGet200Response</returns>
        ApiResponse<ProductionProductionbomProductidReturnattachmentscontentGet200Response> ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfo(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomPut200Response</returns>
        ProductionProductionbomPut200Response ProductionProductionbomPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomPut200Response</returns>
        ApiResponse<ProductionProductionbomPut200Response> ProductionProductionbomPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionResourcePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionResourcePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionResourcePutRequest</returns>
        ProductionResourcePutRequest ProductionResourcePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionResourcePutRequest</returns>
        ApiResponse<ProductionResourcePutRequest> ProductionResourcePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionResourcePutRequest</returns>
        ProductionResourcePutRequest ProductionResourceResourceidDelete(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionResourcePutRequest</returns>
        ApiResponse<ProductionResourcePutRequest> ProductionResourceResourceidDeleteWithHttpInfo(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionResourceResourceidIncludeattachmentsGet(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionResourceResourceidIncludeattachmentsGetWithHttpInfo(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all resources.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionResourcelistPgLmtNameOnlyactiveGet(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all resources.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfo(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all suspend reasons.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionSuspendreasonPgLmtWorkcenteridGet(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all suspend reasons.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfo(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionSuspendreasonPut200Response</returns>
        ProductionSuspendreasonPut200Response ProductionSuspendreasonPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionSuspendreasonPut200Response</returns>
        ApiResponse<ProductionSuspendreasonPut200Response> ProductionSuspendreasonPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all workcenters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionWorkcentersPgLmtNameGet(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all workcenters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionWorkcentersPgLmtNameGetWithHttpInfo(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Work center locations will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionWorkcentersPost200Response</returns>
        ProductionWorkcentersPost200Response ProductionWorkcentersPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Work center locations will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionWorkcentersPost200Response</returns>
        ApiResponse<ProductionWorkcentersPost200Response> ProductionWorkcentersPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionWorkcentersPut200Response</returns>
        ProductionWorkcentersPut200Response ProductionWorkcentersPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionWorkcentersPut200Response</returns>
        ApiResponse<ProductionWorkcentersPut200Response> ProductionWorkcentersPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductionWorkcentersWorkcenteridDelete(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductionWorkcentersWorkcenteridDeleteWithHttpInfo(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Put Attachment
        /// </summary>
        /// <remarks>
        /// + Method allows to update IsProcessed field of Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PutAttachment200Response</returns>
        PutAttachment200Response PutAttachment(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Put Attachment
        /// </summary>
        /// <remarks>
        /// + Method allows to update IsProcessed field of Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PutAttachment200Response</returns>
        ApiResponse<PutAttachment200Response> PutAttachmentWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Release
        /// </summary>
        /// <remarks>
        /// + Method will release Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Release200Response</returns>
        Release200Response Release(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0);

        /// <summary>
        /// Release
        /// </summary>
        /// <remarks>
        /// + Method will release Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Release200Response</returns>
        ApiResponse<Release200Response> ReleaseWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0);

        /// <summary>
        /// Resume Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will resume operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ResumeRunOperation200Response</returns>
        ResumeRunOperation200Response ResumeRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0);

        /// <summary>
        /// Resume Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will resume operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ResumeRunOperation200Response</returns>
        ApiResponse<ResumeRunOperation200Response> ResumeRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0);

        /// <summary>
        /// Start Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StartRunOperation200Response</returns>
        StartRunOperation200Response StartRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0);

        /// <summary>
        /// Start Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StartRunOperation200Response</returns>
        ApiResponse<StartRunOperation200Response> StartRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0);

        /// <summary>
        /// Suspend Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will suspend operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SuspendRunOperation200Response</returns>
        SuspendRunOperation200Response SuspendRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0);

        /// <summary>
        /// Suspend Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will suspend operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SuspendRunOperation200Response</returns>
        ApiResponse<SuspendRunOperation200Response> SuspendRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0);

        /// <summary>
        /// Undo
        /// </summary>
        /// <remarks>
        /// + Method will undo Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Undo200Response</returns>
        Undo200Response Undo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0);

        /// <summary>
        /// Undo
        /// </summary>
        /// <remarks>
        /// + Method will undo Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Undo200Response</returns>
        ApiResponse<Undo200Response> UndoWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0);

        /// <summary>
        /// Undo Run
        /// </summary>
        /// <remarks>
        /// + Method will undo Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UndoRun200Response</returns>
        UndoRun200Response UndoRun(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0);

        /// <summary>
        /// Undo Run
        /// </summary>
        /// <remarks>
        /// + Method will undo Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UndoRun200Response</returns>
        ApiResponse<UndoRun200Response> UndoRunWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0);

        /// <summary>
        /// Update Manual Journals
        /// </summary>
        /// <remarks>
        /// + Method will create or update Manual Journals of Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void UpdateManualJournals(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Update Manual Journals
        /// </summary>
        /// <remarks>
        /// + Method will create or update Manual Journals of Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> UpdateManualJournalsWithHttpInfo(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Void Run
        /// </summary>
        /// <remarks>
        /// + Method will void Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UndoRun200Response</returns>
        UndoRun200Response VoidRun(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0);

        /// <summary>
        /// Void Run
        /// </summary>
        /// <remarks>
        /// + Method will void Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UndoRun200Response</returns>
        ApiResponse<UndoRun200Response> VoidRunWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// Authorize
        /// </summary>
        /// <remarks>
        /// + Method will authorize Production Order. Recalculates capacity.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Authorize200Response</returns>
        System.Threading.Tasks.Task<Authorize200Response> AuthorizeAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Authorize
        /// </summary>
        /// <remarks>
        /// + Method will authorize Production Order. Recalculates capacity.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Authorize200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Authorize200Response>> AuthorizeWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Void
        /// </summary>
        /// <remarks>
        /// + Method will void Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Undo200Response</returns>
        System.Threading.Tasks.Task<Undo200Response> CallVoidAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Void
        /// </summary>
        /// <remarks>
        /// + Method will void Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Undo200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Undo200Response>> CallVoidWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete Run
        /// </summary>
        /// <remarks>
        /// + Method will complete Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompleteRun200Response</returns>
        System.Threading.Tasks.Task<CompleteRun200Response> CompleteRunAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete Run
        /// </summary>
        /// <remarks>
        /// + Method will complete Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompleteRun200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompleteRun200Response>> CompleteRunWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will complete operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompleteRunOperation200Response</returns>
        System.Threading.Tasks.Task<CompleteRunOperation200Response> CompleteRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will complete operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompleteRunOperation200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompleteRunOperation200Response>> CompleteRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Attachment
        /// </summary>
        /// <remarks>
        /// + Method will delete Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAttachmentAsync(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Attachment
        /// </summary>
        /// <remarks>
        /// + Method will delete Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> DeleteAttachmentWithHttpInfoAsync(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Production Order Attachments
        /// </summary>
        /// <remarks>
        /// + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetProductionOrderAttachments200Response</returns>
        System.Threading.Tasks.Task<GetProductionOrderAttachments200Response> GetProductionOrderAttachmentsAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Production Order Attachments
        /// </summary>
        /// <remarks>
        /// + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetProductionOrderAttachments200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetProductionOrderAttachments200Response>> GetProductionOrderAttachmentsWithHttpInfoAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Production Order Reference Data
        /// </summary>
        /// <remarks>
        /// + Method will return accumulated reference data useful for creating and updating production orders.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetProductionOrderReferenceData200Response</returns>
        System.Threading.Tasks.Task<GetProductionOrderReferenceData200Response> GetProductionOrderReferenceDataAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Production Order Reference Data
        /// </summary>
        /// <remarks>
        /// + Method will return accumulated reference data useful for creating and updating production orders.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetProductionOrderReferenceData200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetProductionOrderReferenceData200Response>> GetProductionOrderReferenceDataWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Orders and Production Runs according to provided filters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OrderlistPgLmtStsSrchEtcAsync(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Orders and Production Runs according to provided filters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> OrderlistPgLmtStsSrchEtcWithHttpInfoAsync(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Post Attachment
        /// </summary>
        /// <remarks>
        /// + Method will add a Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PutAttachment200Response</returns>
        System.Threading.Tasks.Task<PutAttachment200Response> PostAttachmentAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Post Attachment
        /// </summary>
        /// <remarks>
        /// + Method will add a Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PutAttachment200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PutAttachment200Response>> PostAttachmentWithHttpInfoAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionFactorycalendarPutRequest</returns>
        System.Threading.Tasks.Task<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionFactorycalendarPutRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionFactorycalendarPutRequest>> ProductionFactorycalendarPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionFactorycalendarPutRequest</returns>
        System.Threading.Tasks.Task<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionFactorycalendarPutRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionFactorycalendarPutRequest>> ProductionFactorycalendarPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionFactorycalendarPutRequest</returns>
        System.Threading.Tasks.Task<ProductionFactorycalendarPutRequest> ProductionFactorycalendarYearGetAsync(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionFactorycalendarPutRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionFactorycalendarPutRequest>> ProductionFactorycalendarYearGetWithHttpInfoAsync(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response</returns>
        System.Threading.Tasks.Task<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response> ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutAsync(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response>> ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfoAsync(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Order and its nested items.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionOrderProductionorderidReturnattachmentscontentGet200Response</returns>
        System.Threading.Tasks.Task<ProductionOrderProductionorderidReturnattachmentscontentGet200Response> ProductionOrderProductionorderidReturnattachmentscontentGetAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Returns Production Order and its nested items.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionOrderProductionorderidReturnattachmentscontentGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionOrderProductionorderidReturnattachmentscontentGet200Response>> ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfoAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionOrderRecalculatedatesPost200Response</returns>
        System.Threading.Tasks.Task<ProductionOrderRecalculatedatesPost200Response> ProductionOrderRecalculatedatesPostAsync(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionOrderRecalculatedatesPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionOrderRecalculatedatesPost200Response>> ProductionOrderRecalculatedatesPostWithHttpInfoAsync(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionOrderRunPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionOrderRunPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionOrderRunProductionorderidIncludeattachmentcontentGetAsync(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Runs.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfoAsync(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionOrderRunProductionorderidIncreaseorderquantityPutAsync(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfoAsync(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomPost200Response</returns>
        System.Threading.Tasks.Task<ProductionProductionbomPost200Response> ProductionProductionbomPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomPost200Response>> ProductionProductionbomPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionProductionbomProductfamilyidBomidDeleteAsync(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfoAsync(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response</returns>
        System.Threading.Tasks.Task<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response> ProductionProductionbomProductfamilyidReturnattachmentscontentGetAsync(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response>> ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfoAsync(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionProductionbomProductidBomidDeleteAsync(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionProductionbomProductidBomidDeleteWithHttpInfoAsync(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomProductidReturnattachmentscontentGet200Response</returns>
        System.Threading.Tasks.Task<ProductionProductionbomProductidReturnattachmentscontentGet200Response> ProductionProductionbomProductidReturnattachmentscontentGetAsync(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all Production BOMs of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomProductidReturnattachmentscontentGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomProductidReturnattachmentscontentGet200Response>> ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfoAsync(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomPut200Response</returns>
        System.Threading.Tasks.Task<ProductionProductionbomPut200Response> ProductionProductionbomPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product family.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomPut200Response>> ProductionProductionbomPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionResourcePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionResourcePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionResourcePutRequest</returns>
        System.Threading.Tasks.Task<ProductionResourcePutRequest> ProductionResourcePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionResourcePutRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionResourcePutRequest>> ProductionResourcePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionResourcePutRequest</returns>
        System.Threading.Tasks.Task<ProductionResourcePutRequest> ProductionResourceResourceidDeleteAsync(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionResourcePutRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionResourcePutRequest>> ProductionResourceResourceidDeleteWithHttpInfoAsync(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionResourceResourceidIncludeattachmentsGetAsync(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionResourceResourceidIncludeattachmentsGetWithHttpInfoAsync(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all resources.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionResourcelistPgLmtNameOnlyactiveGetAsync(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all resources.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfoAsync(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all suspend reasons.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionSuspendreasonPgLmtWorkcenteridGetAsync(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all suspend reasons.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfoAsync(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionSuspendreasonPut200Response</returns>
        System.Threading.Tasks.Task<ProductionSuspendreasonPut200Response> ProductionSuspendreasonPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionSuspendreasonPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionSuspendreasonPut200Response>> ProductionSuspendreasonPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all workcenters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionWorkcentersPgLmtNameGetAsync(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        /// + Method will return all workcenters.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionWorkcentersPgLmtNameGetWithHttpInfoAsync(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Work center locations will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionWorkcentersPost200Response</returns>
        System.Threading.Tasks.Task<ProductionWorkcentersPost200Response> ProductionWorkcentersPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Work center locations will be created.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionWorkcentersPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionWorkcentersPost200Response>> ProductionWorkcentersPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionWorkcentersPut200Response</returns>
        System.Threading.Tasks.Task<ProductionWorkcentersPut200Response> ProductionWorkcentersPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionWorkcentersPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionWorkcentersPut200Response>> ProductionWorkcentersPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductionWorkcentersWorkcenteridDeleteAsync(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductionWorkcentersWorkcenteridDeleteWithHttpInfoAsync(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Put Attachment
        /// </summary>
        /// <remarks>
        /// + Method allows to update IsProcessed field of Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PutAttachment200Response</returns>
        System.Threading.Tasks.Task<PutAttachment200Response> PutAttachmentAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Put Attachment
        /// </summary>
        /// <remarks>
        /// + Method allows to update IsProcessed field of Production Order attachment.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PutAttachment200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PutAttachment200Response>> PutAttachmentWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Release
        /// </summary>
        /// <remarks>
        /// + Method will release Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Release200Response</returns>
        System.Threading.Tasks.Task<Release200Response> ReleaseAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Release
        /// </summary>
        /// <remarks>
        /// + Method will release Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Release200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Release200Response>> ReleaseWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Resume Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will resume operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResumeRunOperation200Response</returns>
        System.Threading.Tasks.Task<ResumeRunOperation200Response> ResumeRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Resume Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will resume operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResumeRunOperation200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResumeRunOperation200Response>> ResumeRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StartRunOperation200Response</returns>
        System.Threading.Tasks.Task<StartRunOperation200Response> StartRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StartRunOperation200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<StartRunOperation200Response>> StartRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Suspend Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will suspend operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuspendRunOperation200Response</returns>
        System.Threading.Tasks.Task<SuspendRunOperation200Response> SuspendRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Suspend Run Operation
        /// </summary>
        /// <remarks>
        /// + Method will suspend operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuspendRunOperation200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuspendRunOperation200Response>> SuspendRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Undo
        /// </summary>
        /// <remarks>
        /// + Method will undo Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Undo200Response</returns>
        System.Threading.Tasks.Task<Undo200Response> UndoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Undo
        /// </summary>
        /// <remarks>
        /// + Method will undo Production Order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Undo200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Undo200Response>> UndoWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Undo Run
        /// </summary>
        /// <remarks>
        /// + Method will undo Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UndoRun200Response</returns>
        System.Threading.Tasks.Task<UndoRun200Response> UndoRunAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Undo Run
        /// </summary>
        /// <remarks>
        /// + Method will undo Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UndoRun200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UndoRun200Response>> UndoRunWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Manual Journals
        /// </summary>
        /// <remarks>
        /// + Method will create or update Manual Journals of Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateManualJournalsAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Manual Journals
        /// </summary>
        /// <remarks>
        /// + Method will create or update Manual Journals of Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> UpdateManualJournalsWithHttpInfoAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Void Run
        /// </summary>
        /// <remarks>
        /// + Method will void Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UndoRun200Response</returns>
        System.Threading.Tasks.Task<UndoRun200Response> VoidRunAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Void Run
        /// </summary>
        /// <remarks>
        /// + Method will void Run.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UndoRun200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UndoRun200Response>> VoidRunWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductionApi : IProductionApiSync, IProductionApiAsync
    {
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductionApi : IProductionApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductionApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProductionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductionApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProductionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProductionApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Authorize + Method will authorize Production Order. Recalculates capacity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Authorize200Response</returns>
        public Authorize200Response Authorize(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0)
        {
            ApiResponse<Authorize200Response> localVarResponse = AuthorizeWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, authorizeRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authorize + Method will authorize Production Order. Recalculates capacity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Authorize200Response</returns>
        public ApiResponse<Authorize200Response> AuthorizeWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = authorizeRequest;

            localVarRequestOptions.Operation = "ProductionApi.Authorize";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<Authorize200Response>("/production/order/authorize", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Authorize", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authorize + Method will authorize Production Order. Recalculates capacity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Authorize200Response</returns>
        public async System.Threading.Tasks.Task<Authorize200Response> AuthorizeAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Authorize200Response> localVarResponse = await AuthorizeWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, authorizeRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Authorize + Method will authorize Production Order. Recalculates capacity.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="authorizeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Authorize200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Authorize200Response>> AuthorizeWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, AuthorizeRequest? authorizeRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = authorizeRequest;

            localVarRequestOptions.Operation = "ProductionApi.Authorize";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<Authorize200Response>("/production/order/authorize", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Authorize", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Void + Method will void Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Undo200Response</returns>
        public Undo200Response CallVoid(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0)
        {
            ApiResponse<Undo200Response> localVarResponse = CallVoidWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Void + Method will void Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Undo200Response</returns>
        public ApiResponse<Undo200Response> CallVoidWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = undoRequest;

            localVarRequestOptions.Operation = "ProductionApi.CallVoid";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<Undo200Response>("/production/order/void", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CallVoid", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Void + Method will void Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Undo200Response</returns>
        public async System.Threading.Tasks.Task<Undo200Response> CallVoidAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Undo200Response> localVarResponse = await CallVoidWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, undoRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Void + Method will void Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Undo200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Undo200Response>> CallVoidWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = undoRequest;

            localVarRequestOptions.Operation = "ProductionApi.CallVoid";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<Undo200Response>("/production/order/void", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CallVoid", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete Run + Method will complete Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CompleteRun200Response</returns>
        public CompleteRun200Response CompleteRun(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0)
        {
            ApiResponse<CompleteRun200Response> localVarResponse = CompleteRunWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, completeRunRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete Run + Method will complete Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CompleteRun200Response</returns>
        public ApiResponse<CompleteRun200Response> CompleteRunWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = completeRunRequest;

            localVarRequestOptions.Operation = "ProductionApi.CompleteRun";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<CompleteRun200Response>("/production/order/run/complete", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CompleteRun", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete Run + Method will complete Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompleteRun200Response</returns>
        public async System.Threading.Tasks.Task<CompleteRun200Response> CompleteRunAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CompleteRun200Response> localVarResponse = await CompleteRunWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, completeRunRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete Run + Method will complete Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="completeRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompleteRun200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompleteRun200Response>> CompleteRunWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CompleteRunRequest? completeRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = completeRunRequest;

            localVarRequestOptions.Operation = "ProductionApi.CompleteRun";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<CompleteRun200Response>("/production/order/run/complete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CompleteRun", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete Run Operation + Method will complete operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CompleteRunOperation200Response</returns>
        public CompleteRunOperation200Response CompleteRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<CompleteRunOperation200Response> localVarResponse = CompleteRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete Run Operation + Method will complete operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CompleteRunOperation200Response</returns>
        public ApiResponse<CompleteRunOperation200Response> CompleteRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ProductionApi.CompleteRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<CompleteRunOperation200Response>("/production/order/run/operation/complete", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CompleteRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete Run Operation + Method will complete operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompleteRunOperation200Response</returns>
        public async System.Threading.Tasks.Task<CompleteRunOperation200Response> CompleteRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CompleteRunOperation200Response> localVarResponse = await CompleteRunOperationWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete Run Operation + Method will complete operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompleteRunOperation200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompleteRunOperation200Response>> CompleteRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ProductionApi.CompleteRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<CompleteRunOperation200Response>("/production/order/run/operation/complete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CompleteRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete Attachment + Method will delete Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteAttachment(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            DeleteAttachmentWithHttpInfo(productionOrderAttachmentID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Delete Attachment + Method will delete Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> DeleteAttachmentWithHttpInfo(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productionOrderAttachmentID' is set
            if (productionOrderAttachmentID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderAttachmentID' when calling ProductionApi->DeleteAttachment");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderAttachmentID", ClientUtils.ParameterToString(productionOrderAttachmentID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.DeleteAttachment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<object>("/production/order/attachment?ProductionOrderAttachmentID={ProductionOrderAttachmentID}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteAttachment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete Attachment + Method will delete Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAttachmentAsync(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await DeleteAttachmentWithHttpInfoAsync(productionOrderAttachmentID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete Attachment + Method will delete Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderAttachmentID">Identifier of a Production Order Attachment</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> DeleteAttachmentWithHttpInfoAsync(string productionOrderAttachmentID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productionOrderAttachmentID' is set
            if (productionOrderAttachmentID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderAttachmentID' when calling ProductionApi->DeleteAttachment");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderAttachmentID", ClientUtils.ParameterToString(productionOrderAttachmentID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.DeleteAttachment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<object>("/production/order/attachment?ProductionOrderAttachmentID={ProductionOrderAttachmentID}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteAttachment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Production Order Attachments + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetProductionOrderAttachments200Response</returns>
        public GetProductionOrderAttachments200Response GetProductionOrderAttachments(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<GetProductionOrderAttachments200Response> localVarResponse = GetProductionOrderAttachmentsWithHttpInfo(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Production Order Attachments + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetProductionOrderAttachments200Response</returns>
        public ApiResponse<GetProductionOrderAttachments200Response> GetProductionOrderAttachmentsWithHttpInfo(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->GetProductionOrderAttachments");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.GetProductionOrderAttachments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<GetProductionOrderAttachments200Response>("/production/order/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetProductionOrderAttachments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Production Order Attachments + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetProductionOrderAttachments200Response</returns>
        public async System.Threading.Tasks.Task<GetProductionOrderAttachments200Response> GetProductionOrderAttachmentsAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<GetProductionOrderAttachments200Response> localVarResponse = await GetProductionOrderAttachmentsWithHttpInfoAsync(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Production Order Attachments + Method will return all Production Order attachments: Production Order attachments, Production Operation attachments, Production Resource attachments.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order Attachment</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetProductionOrderAttachments200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetProductionOrderAttachments200Response>> GetProductionOrderAttachmentsWithHttpInfoAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->GetProductionOrderAttachments");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.GetProductionOrderAttachments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<GetProductionOrderAttachments200Response>("/production/order/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetProductionOrderAttachments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Production Order Reference Data + Method will return accumulated reference data useful for creating and updating production orders.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetProductionOrderReferenceData200Response</returns>
        public GetProductionOrderReferenceData200Response GetProductionOrderReferenceData(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<GetProductionOrderReferenceData200Response> localVarResponse = GetProductionOrderReferenceDataWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Production Order Reference Data + Method will return accumulated reference data useful for creating and updating production orders.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetProductionOrderReferenceData200Response</returns>
        public ApiResponse<GetProductionOrderReferenceData200Response> GetProductionOrderReferenceDataWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ProductionApi.GetProductionOrderReferenceData";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<GetProductionOrderReferenceData200Response>("/production/order/referenceData", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetProductionOrderReferenceData", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Production Order Reference Data + Method will return accumulated reference data useful for creating and updating production orders.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetProductionOrderReferenceData200Response</returns>
        public async System.Threading.Tasks.Task<GetProductionOrderReferenceData200Response> GetProductionOrderReferenceDataAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<GetProductionOrderReferenceData200Response> localVarResponse = await GetProductionOrderReferenceDataWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Production Order Reference Data + Method will return accumulated reference data useful for creating and updating production orders.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetProductionOrderReferenceData200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetProductionOrderReferenceData200Response>> GetProductionOrderReferenceDataWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ProductionApi.GetProductionOrderReferenceData";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<GetProductionOrderReferenceData200Response>("/production/order/referenceData", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetProductionOrderReferenceData", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Returns Production Orders and Production Runs according to provided filters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void OrderlistPgLmtStsSrchEtc(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            OrderlistPgLmtStsSrchEtcWithHttpInfo(page, limit, status, search, locationID, requiredByDateFrom, requiredByDateTo, completionDateFrom, completionDateTo, sourceTaskID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET + Returns Production Orders and Production Runs according to provided filters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> OrderlistPgLmtStsSrchEtcWithHttpInfo(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'locationID' is set
            if (locationID == null)
            {
                throw new ApiException(400, "Missing required parameter 'locationID' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'requiredByDateFrom' is set
            if (requiredByDateFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'requiredByDateFrom' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'requiredByDateTo' is set
            if (requiredByDateTo == null)
            {
                throw new ApiException(400, "Missing required parameter 'requiredByDateTo' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'completionDateFrom' is set
            if (completionDateFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'completionDateFrom' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'completionDateTo' is set
            if (completionDateTo == null)
            {
                throw new ApiException(400, "Missing required parameter 'completionDateTo' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'sourceTaskID' is set
            if (sourceTaskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'sourceTaskID' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            localVarRequestOptions.QueryParameters.Add("LocationID", ClientUtils.ParameterToString(locationID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RequiredByDateFrom", ClientUtils.ParameterToString(requiredByDateFrom)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RequiredByDateTo", ClientUtils.ParameterToString(requiredByDateTo)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CompletionDateFrom", ClientUtils.ParameterToString(completionDateFrom)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CompletionDateTo", ClientUtils.ParameterToString(completionDateTo)); // path parameter
            localVarRequestOptions.QueryParameters.Add("SourceTaskID", ClientUtils.ParameterToString(sourceTaskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.OrderlistPgLmtStsSrchEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/production/orderList", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("OrderlistPgLmtStsSrchEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Returns Production Orders and Production Runs according to provided filters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OrderlistPgLmtStsSrchEtcAsync(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await OrderlistPgLmtStsSrchEtcWithHttpInfoAsync(page, limit, status, search, locationID, requiredByDateFrom, requiredByDateTo, completionDateFrom, completionDateTo, sourceTaskID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET + Returns Production Orders and Production Runs according to provided filters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100 (Default: 100)</param>
        /// <param name="status">Filter by status, value on of the list: AllButVoided, Draft, Planned, Released, InProgress, Completed (Default: not set)</param>
        /// <param name="search">Only return Production Orders that have the provided text in Product Code or Product Name, Production Order Number, Tags, Comments, in Location name (Default: not set)</param>
        /// <param name="locationID">Only return Production Orders that have LocationID equal to provided value (Default: not set)</param>
        /// <param name="requiredByDateFrom">Only return Production Orders that have RequiredByDate field greater than the provided value Default: not set)</param>
        /// <param name="requiredByDateTo">Only return Production Orders that have RequiredByDate field less than the provided value (Default: not set)</param>
        /// <param name="completionDateFrom">Only return Production Orders that have CompletionDate field greater than the provided value (Default: not set)</param>
        /// <param name="completionDateTo">Only return Production Orders that have CompletionDate field less than the provided value (Default: not set)</param>
        /// <param name="sourceTaskID">Only return Production Orders that are created as a result of execution a Sale Task with ID &#x3D; SourceTaskID Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> OrderlistPgLmtStsSrchEtcWithHttpInfoAsync(decimal page, decimal limit, string status, string search, string locationID, string requiredByDateFrom, string requiredByDateTo, string completionDateFrom, string completionDateTo, string sourceTaskID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'status' is set
            if (status == null)
            {
                throw new ApiException(400, "Missing required parameter 'status' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'locationID' is set
            if (locationID == null)
            {
                throw new ApiException(400, "Missing required parameter 'locationID' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'requiredByDateFrom' is set
            if (requiredByDateFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'requiredByDateFrom' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'requiredByDateTo' is set
            if (requiredByDateTo == null)
            {
                throw new ApiException(400, "Missing required parameter 'requiredByDateTo' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'completionDateFrom' is set
            if (completionDateFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'completionDateFrom' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'completionDateTo' is set
            if (completionDateTo == null)
            {
                throw new ApiException(400, "Missing required parameter 'completionDateTo' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
            }

            // verify the required parameter 'sourceTaskID' is set
            if (sourceTaskID == null)
            {
                throw new ApiException(400, "Missing required parameter 'sourceTaskID' when calling ProductionApi->OrderlistPgLmtStsSrchEtc");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Status", ClientUtils.ParameterToString(status)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            localVarRequestOptions.QueryParameters.Add("LocationID", ClientUtils.ParameterToString(locationID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RequiredByDateFrom", ClientUtils.ParameterToString(requiredByDateFrom)); // path parameter
            localVarRequestOptions.QueryParameters.Add("RequiredByDateTo", ClientUtils.ParameterToString(requiredByDateTo)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CompletionDateFrom", ClientUtils.ParameterToString(completionDateFrom)); // path parameter
            localVarRequestOptions.QueryParameters.Add("CompletionDateTo", ClientUtils.ParameterToString(completionDateTo)); // path parameter
            localVarRequestOptions.QueryParameters.Add("SourceTaskID", ClientUtils.ParameterToString(sourceTaskID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.OrderlistPgLmtStsSrchEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/production/orderList", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("OrderlistPgLmtStsSrchEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Post Attachment + Method will add a Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PutAttachment200Response</returns>
        public PutAttachment200Response PostAttachment(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0)
        {
            ApiResponse<PutAttachment200Response> localVarResponse = PostAttachmentWithHttpInfo(productionOrderID, apiAuthAccountid, apiAuthApplicationkey, postAttachmentRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Post Attachment + Method will add a Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PutAttachment200Response</returns>
        public ApiResponse<PutAttachment200Response> PostAttachmentWithHttpInfo(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->PostAttachment");
            }

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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = postAttachmentRequest;

            localVarRequestOptions.Operation = "ProductionApi.PostAttachment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<PutAttachment200Response>("/production/order/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PostAttachment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Post Attachment + Method will add a Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PutAttachment200Response</returns>
        public async System.Threading.Tasks.Task<PutAttachment200Response> PostAttachmentAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PutAttachment200Response> localVarResponse = await PostAttachmentWithHttpInfoAsync(productionOrderID, apiAuthAccountid, apiAuthApplicationkey, postAttachmentRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Post Attachment + Method will add a Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="postAttachmentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PutAttachment200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PutAttachment200Response>> PostAttachmentWithHttpInfoAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, PostAttachmentRequest? postAttachmentRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->PostAttachment");
            }

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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = postAttachmentRequest;

            localVarRequestOptions.Operation = "ProductionApi.PostAttachment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<PutAttachment200Response>("/production/order/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PostAttachment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionFactorycalendarPutRequest</returns>
        public ProductionFactorycalendarPutRequest ProductionFactorycalendarPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionFactorycalendarPutRequest> localVarResponse = ProductionFactorycalendarPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionFactorycalendarPutRequest</returns>
        public ApiResponse<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productionFactorycalendarPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionFactorycalendarPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ProductionFactorycalendarPutRequest>("/production/factoryCalendar", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionFactorycalendarPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionFactorycalendarPutRequest</returns>
        public async System.Threading.Tasks.Task<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionFactorycalendarPutRequest> localVarResponse = await ProductionFactorycalendarPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionFactorycalendarPutRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionFactorycalendarPutRequest>> ProductionFactorycalendarPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productionFactorycalendarPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionFactorycalendarPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ProductionFactorycalendarPutRequest>("/production/factoryCalendar", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionFactorycalendarPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionFactorycalendarPutRequest</returns>
        public ProductionFactorycalendarPutRequest ProductionFactorycalendarPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionFactorycalendarPutRequest> localVarResponse = ProductionFactorycalendarPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionFactorycalendarPutRequest</returns>
        public ApiResponse<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productionFactorycalendarPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionFactorycalendarPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ProductionFactorycalendarPutRequest>("/production/factoryCalendar", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionFactorycalendarPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionFactorycalendarPutRequest</returns>
        public async System.Threading.Tasks.Task<ProductionFactorycalendarPutRequest> ProductionFactorycalendarPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionFactorycalendarPutRequest> localVarResponse = await ProductionFactorycalendarPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + FactoryCalendarDays, FactoryCalendarSpecialDays do not support modifying. Only creation and deletion are supported.  + FactoryCalendarDays will only be overwritten when collection is not empty.  + FactoryCalendarSpecialDays will be overwritten even when collection is empty.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionFactorycalendarPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionFactorycalendarPutRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionFactorycalendarPutRequest>> ProductionFactorycalendarPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productionFactorycalendarPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionFactorycalendarPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ProductionFactorycalendarPutRequest>("/production/factoryCalendar", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionFactorycalendarPut", localVarResponse);
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
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionFactorycalendarPutRequest</returns>
        public ProductionFactorycalendarPutRequest ProductionFactorycalendarYearGet(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductionFactorycalendarPutRequest> localVarResponse = ProductionFactorycalendarYearGetWithHttpInfo(year, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionFactorycalendarPutRequest</returns>
        public ApiResponse<ProductionFactorycalendarPutRequest> ProductionFactorycalendarYearGetWithHttpInfo(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'year' is set
            if (year == null)
            {
                throw new ApiException(400, "Missing required parameter 'year' when calling ProductionApi->ProductionFactorycalendarYearGet");
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

            localVarRequestOptions.QueryParameters.Add("Year", ClientUtils.ParameterToString(year)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionFactorycalendarYearGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ProductionFactorycalendarPutRequest>("/production/factoryCalendar", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionFactorycalendarYearGet", localVarResponse);
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
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionFactorycalendarPutRequest</returns>
        public async System.Threading.Tasks.Task<ProductionFactorycalendarPutRequest> ProductionFactorycalendarYearGetAsync(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionFactorycalendarPutRequest> localVarResponse = await ProductionFactorycalendarYearGetWithHttpInfoAsync(year, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">The year of the Factory Calendar</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionFactorycalendarPutRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionFactorycalendarPutRequest>> ProductionFactorycalendarYearGetWithHttpInfoAsync(string year, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'year' is set
            if (year == null)
            {
                throw new ApiException(400, "Missing required parameter 'year' when calling ProductionApi->ProductionFactorycalendarYearGet");
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

            localVarRequestOptions.QueryParameters.Add("Year", ClientUtils.ParameterToString(year)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionFactorycalendarYearGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ProductionFactorycalendarPutRequest>("/production/factoryCalendar", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionFactorycalendarYearGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response</returns>
        public ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response> localVarResponse = ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfo(allowRecalculateDates, allowRecalculateCyclesAndQuantities, apiAuthAccountid, apiAuthApplicationkey, productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response</returns>
        public ApiResponse<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response> ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfo(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0)
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

            localVarRequestOptions.QueryParameters.Add("AllowRecalculateDates", ClientUtils.ParameterToString(allowRecalculateDates)); // path parameter
            localVarRequestOptions.QueryParameters.Add("AllowRecalculateCyclesAndQuantities", ClientUtils.ParameterToString(allowRecalculateCyclesAndQuantities)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response>("/production/order", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response</returns>
        public async System.Threading.Tasks.Task<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response> ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutAsync(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response> localVarResponse = await ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfoAsync(allowRecalculateDates, allowRecalculateCyclesAndQuantities, apiAuthAccountid, apiAuthApplicationkey, productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Method will update Production Order. Note: Few fields can be updated and only while Production Order is in Draft or Planned status.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="allowRecalculateDates"></param>
        /// <param name="allowRecalculateCyclesAndQuantities"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response>> ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutWithHttpInfoAsync(bool allowRecalculateDates, bool allowRecalculateCyclesAndQuantities, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.QueryParameters.Add("AllowRecalculateDates", ClientUtils.ParameterToString(allowRecalculateDates)); // path parameter
            localVarRequestOptions.QueryParameters.Add("AllowRecalculateCyclesAndQuantities", ClientUtils.ParameterToString(allowRecalculateCyclesAndQuantities)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response>("/production/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Returns Production Order and its nested items.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionOrderProductionorderidReturnattachmentscontentGet200Response</returns>
        public ProductionOrderProductionorderidReturnattachmentscontentGet200Response ProductionOrderProductionorderidReturnattachmentscontentGet(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductionOrderProductionorderidReturnattachmentscontentGet200Response> localVarResponse = ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfo(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET + Returns Production Order and its nested items.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionOrderProductionorderidReturnattachmentscontentGet200Response</returns>
        public ApiResponse<ProductionOrderProductionorderidReturnattachmentscontentGet200Response> ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfo(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->ProductionOrderProductionorderidReturnattachmentscontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderProductionorderidReturnattachmentscontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ProductionOrderProductionorderidReturnattachmentscontentGet200Response>("/production/order", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderProductionorderidReturnattachmentscontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Returns Production Order and its nested items.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionOrderProductionorderidReturnattachmentscontentGet200Response</returns>
        public async System.Threading.Tasks.Task<ProductionOrderProductionorderidReturnattachmentscontentGet200Response> ProductionOrderProductionorderidReturnattachmentscontentGetAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionOrderProductionorderidReturnattachmentscontentGet200Response> localVarResponse = await ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfoAsync(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET + Returns Production Order and its nested items.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Identifier of a Production Order</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionOrderProductionorderidReturnattachmentscontentGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionOrderProductionorderidReturnattachmentscontentGet200Response>> ProductionOrderProductionorderidReturnattachmentscontentGetWithHttpInfoAsync(string productionOrderID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->ProductionOrderProductionorderidReturnattachmentscontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderProductionorderidReturnattachmentscontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ProductionOrderProductionorderidReturnattachmentscontentGet200Response>("/production/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderProductionorderidReturnattachmentscontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Method will create new Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionOrderRecalculatedatesPost200Response</returns>
        public ProductionOrderRecalculatedatesPost200Response ProductionOrderRecalculatedatesPost(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionOrderRecalculatedatesPost200Response> localVarResponse = ProductionOrderRecalculatedatesPostWithHttpInfo(recalculateDates, apiAuthAccountid, apiAuthApplicationkey, productionOrderRecalculatedatesPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Method will create new Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionOrderRecalculatedatesPost200Response</returns>
        public ApiResponse<ProductionOrderRecalculatedatesPost200Response> ProductionOrderRecalculatedatesPostWithHttpInfo(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0)
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

            localVarRequestOptions.QueryParameters.Add("RecalculateDates", ClientUtils.ParameterToString(recalculateDates)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = productionOrderRecalculatedatesPostRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRecalculatedatesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ProductionOrderRecalculatedatesPost200Response>("/production/order", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRecalculatedatesPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Method will create new Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionOrderRecalculatedatesPost200Response</returns>
        public async System.Threading.Tasks.Task<ProductionOrderRecalculatedatesPost200Response> ProductionOrderRecalculatedatesPostAsync(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionOrderRecalculatedatesPost200Response> localVarResponse = await ProductionOrderRecalculatedatesPostWithHttpInfoAsync(recalculateDates, apiAuthAccountid, apiAuthApplicationkey, productionOrderRecalculatedatesPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Method will create new Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="recalculateDates"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRecalculatedatesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionOrderRecalculatedatesPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionOrderRecalculatedatesPost200Response>> ProductionOrderRecalculatedatesPostWithHttpInfoAsync(bool recalculateDates, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.QueryParameters.Add("RecalculateDates", ClientUtils.ParameterToString(recalculateDates)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }
            localVarRequestOptions.Data = productionOrderRecalculatedatesPostRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRecalculatedatesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ProductionOrderRecalculatedatesPost200Response>("/production/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRecalculatedatesPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Method will create new Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionOrderRunPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0)
        {
            ProductionOrderRunPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionOrderRunPostRequest);
        }

        /// <summary>
        /// POST + Method will create new Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionOrderRunPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

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
            localVarRequestOptions.Data = productionOrderRunPostRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRunPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<object>("/production/order/run", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRunPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Method will create new Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionOrderRunPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionOrderRunPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productionOrderRunPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// POST + Method will create new Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionOrderRunPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionOrderRunPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionOrderRunPostRequest? productionOrderRunPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            RequestOptions localVarRequestOptions = new();

            string[] _contentTypes = [
                "application/json"
            ];

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
            localVarRequestOptions.Data = productionOrderRunPostRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRunPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<object>("/production/order/run", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRunPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionOrderRunProductionorderidIncludeattachmentcontentGet(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfo(productionOrderID, includeAttachmentContent, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET + Method will return all Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfo(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->ProductionOrderRunProductionorderidIncludeattachmentcontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeAttachmentContent", ClientUtils.ParameterToString(includeAttachmentContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRunProductionorderidIncludeattachmentcontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/production/order/run", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRunProductionorderidIncludeattachmentcontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionOrderRunProductionorderidIncludeattachmentcontentGetAsync(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfoAsync(productionOrderID, includeAttachmentContent, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET + Method will return all Runs.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="includeAttachmentContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionOrderRunProductionorderidIncludeattachmentcontentGetWithHttpInfoAsync(string productionOrderID, bool includeAttachmentContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->ProductionOrderRunProductionorderidIncludeattachmentcontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeAttachmentContent", ClientUtils.ParameterToString(includeAttachmentContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRunProductionorderidIncludeattachmentcontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/production/order/run", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRunProductionorderidIncludeattachmentcontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionOrderRunProductionorderidIncreaseorderquantityPut(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfo(productionOrderID, increaseOrderQuantity, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// PUT + Method will update Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfo(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->ProductionOrderRunProductionorderidIncreaseorderquantityPut");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncreaseOrderQuantity", ClientUtils.ParameterToString(increaseOrderQuantity)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRunProductionorderidIncreaseorderquantityPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<object>("/production/order/run", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRunProductionorderidIncreaseorderquantityPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionOrderRunProductionorderidIncreaseorderquantityPutAsync(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfoAsync(productionOrderID, increaseOrderQuantity, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// PUT + Method will update Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="increaseOrderQuantity">Will increase order quantity if sum all run&#39;s quantity more then order quantity.</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionOrderRunProductionorderidIncreaseorderquantityPutWithHttpInfoAsync(string productionOrderID, bool increaseOrderQuantity, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->ProductionOrderRunProductionorderidIncreaseorderquantityPut");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncreaseOrderQuantity", ClientUtils.ParameterToString(increaseOrderQuantity)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionOrderRunProductionorderidIncreaseorderquantityPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<object>("/production/order/run", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionOrderRunProductionorderidIncreaseorderquantityPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomPost200Response</returns>
        public ProductionProductionbomPost200Response ProductionProductionbomPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionProductionbomPost200Response> localVarResponse = ProductionProductionbomPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomPost200Response</returns>
        public ApiResponse<ProductionProductionbomPost200Response> ProductionProductionbomPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productionProductionbomPostRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ProductionProductionbomPost200Response>("/production/productionBOM", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomPost200Response</returns>
        public async System.Threading.Tasks.Task<ProductionProductionbomPost200Response> ProductionProductionbomPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionProductionbomPost200Response> localVarResponse = await ProductionProductionbomPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Method will create new Production BOM(s) for specified product family. Please set the &#39;OverwriteExistingProductionBOM&#39; flag to true if the existing Production BOM needs to be replaced.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomPost200Response>> ProductionProductionbomPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPostRequest? productionProductionbomPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productionProductionbomPostRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ProductionProductionbomPost200Response>("/production/productionBOM", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionProductionbomProductfamilyidBomidDelete(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfo(productFamilyID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfo(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productFamilyID' is set
            if (productFamilyID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productFamilyID' when calling ProductionApi->ProductionProductionbomProductfamilyidBomidDelete");
            }

            // verify the required parameter 'BOMID' is set
            if (BOMID == null)
            {
                throw new ApiException(400, "Missing required parameter 'BOMID' when calling ProductionApi->ProductionProductionbomProductfamilyidBomidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ProductFamilyID", ClientUtils.ParameterToString(productFamilyID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("BOMID", ClientUtils.ParameterToString(BOMID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductfamilyidBomidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<object>("/production/productionBOM", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductfamilyidBomidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionProductionbomProductfamilyidBomidDeleteAsync(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfoAsync(productFamilyID, BOMID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of a Product Family whose Production BOMs are to be deleted</param>
        /// <param name="BOMID">Identifier of a Production BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionProductionbomProductfamilyidBomidDeleteWithHttpInfoAsync(string productFamilyID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productFamilyID' is set
            if (productFamilyID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productFamilyID' when calling ProductionApi->ProductionProductionbomProductfamilyidBomidDelete");
            }

            // verify the required parameter 'BOMID' is set
            if (BOMID == null)
            {
                throw new ApiException(400, "Missing required parameter 'BOMID' when calling ProductionApi->ProductionProductionbomProductfamilyidBomidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ProductFamilyID", ClientUtils.ParameterToString(productFamilyID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("BOMID", ClientUtils.ParameterToString(BOMID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductfamilyidBomidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<object>("/production/productionBOM", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductfamilyidBomidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response</returns>
        public ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response ProductionProductionbomProductfamilyidReturnattachmentscontentGet(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response> localVarResponse = ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfo(productFamilyID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response</returns>
        public ApiResponse<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response> ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfo(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productFamilyID' is set
            if (productFamilyID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productFamilyID' when calling ProductionApi->ProductionProductionbomProductfamilyidReturnattachmentscontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductFamilyID", ClientUtils.ParameterToString(productFamilyID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductfamilyidReturnattachmentscontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response>("/production/productionBOM", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductfamilyidReturnattachmentscontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response</returns>
        public async System.Threading.Tasks.Task<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response> ProductionProductionbomProductfamilyidReturnattachmentscontentGetAsync(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response> localVarResponse = await ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfoAsync(productFamilyID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productFamilyID">Identifier of the Product Family to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response>> ProductionProductionbomProductfamilyidReturnattachmentscontentGetWithHttpInfoAsync(string productFamilyID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productFamilyID' is set
            if (productFamilyID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productFamilyID' when calling ProductionApi->ProductionProductionbomProductfamilyidReturnattachmentscontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductFamilyID", ClientUtils.ParameterToString(productFamilyID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductfamilyidReturnattachmentscontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response>("/production/productionBOM", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductfamilyidReturnattachmentscontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionProductionbomProductidBomidDelete(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionProductionbomProductidBomidDeleteWithHttpInfo(productID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionProductionbomProductidBomidDeleteWithHttpInfo(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ProductionApi->ProductionProductionbomProductidBomidDelete");
            }

            // verify the required parameter 'BOMID' is set
            if (BOMID == null)
            {
                throw new ApiException(400, "Missing required parameter 'BOMID' when calling ProductionApi->ProductionProductionbomProductidBomidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ProductID", ClientUtils.ParameterToString(productID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("BOMID", ClientUtils.ParameterToString(BOMID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductidBomidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<object>("/production/productionBOM", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductidBomidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionProductionbomProductidBomidDeleteAsync(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionProductionbomProductidBomidDeleteWithHttpInfoAsync(productID, BOMID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Production BOMs will be deleted</param>
        /// <param name="BOMID">Identifier of a Product BOM to be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionProductionbomProductidBomidDeleteWithHttpInfoAsync(string productID, string BOMID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ProductionApi->ProductionProductionbomProductidBomidDelete");
            }

            // verify the required parameter 'BOMID' is set
            if (BOMID == null)
            {
                throw new ApiException(400, "Missing required parameter 'BOMID' when calling ProductionApi->ProductionProductionbomProductidBomidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ProductID", ClientUtils.ParameterToString(productID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("BOMID", ClientUtils.ParameterToString(BOMID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductidBomidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<object>("/production/productionBOM", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductidBomidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomProductidReturnattachmentscontentGet200Response</returns>
        public ProductionProductionbomProductidReturnattachmentscontentGet200Response ProductionProductionbomProductidReturnattachmentscontentGet(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductionProductionbomProductidReturnattachmentscontentGet200Response> localVarResponse = ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfo(productID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomProductidReturnattachmentscontentGet200Response</returns>
        public ApiResponse<ProductionProductionbomProductidReturnattachmentscontentGet200Response> ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfo(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ProductionApi->ProductionProductionbomProductidReturnattachmentscontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductID", ClientUtils.ParameterToString(productID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductidReturnattachmentscontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ProductionProductionbomProductidReturnattachmentscontentGet200Response>("/production/productionBOM", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductidReturnattachmentscontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomProductidReturnattachmentscontentGet200Response</returns>
        public async System.Threading.Tasks.Task<ProductionProductionbomProductidReturnattachmentscontentGet200Response> ProductionProductionbomProductidReturnattachmentscontentGetAsync(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionProductionbomProductidReturnattachmentscontentGet200Response> localVarResponse = await ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfoAsync(productID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET + Method will return all Production BOMs of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product to return Production BOMs for</param>
        /// <param name="returnAttachmentsContent"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomProductidReturnattachmentscontentGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomProductidReturnattachmentscontentGet200Response>> ProductionProductionbomProductidReturnattachmentscontentGetWithHttpInfoAsync(string productID, bool returnAttachmentsContent, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ProductionApi->ProductionProductionbomProductidReturnattachmentscontentGet");
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

            localVarRequestOptions.QueryParameters.Add("ProductID", ClientUtils.ParameterToString(productID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ReturnAttachmentsContent", ClientUtils.ParameterToString(returnAttachmentsContent)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomProductidReturnattachmentscontentGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ProductionProductionbomProductidReturnattachmentscontentGet200Response>("/production/productionBOM", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomProductidReturnattachmentscontentGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionProductionbomPut200Response</returns>
        public ProductionProductionbomPut200Response ProductionProductionbomPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionProductionbomPut200Response> localVarResponse = ProductionProductionbomPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionProductionbomPut200Response</returns>
        public ApiResponse<ProductionProductionbomPut200Response> ProductionProductionbomPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productionProductionbomPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ProductionProductionbomPut200Response>("/production/productionBOM", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionProductionbomPut200Response</returns>
        public async System.Threading.Tasks.Task<ProductionProductionbomPut200Response> ProductionProductionbomPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionProductionbomPut200Response> localVarResponse = await ProductionProductionbomPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product family.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionProductionbomPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionProductionbomPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionProductionbomPut200Response>> ProductionProductionbomPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionProductionbomPutRequest? productionProductionbomPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productionProductionbomPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionProductionbomPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ProductionProductionbomPut200Response>("/production/productionBOM", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionProductionbomPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionResourcePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionResourcePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// POST + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionResourcePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourcePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<object>("/production/resource", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourcePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionResourcePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionResourcePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// POST + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionResourcePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourcePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<object>("/production/resource", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourcePost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionResourcePutRequest</returns>
        public ProductionResourcePutRequest ProductionResourcePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionResourcePutRequest> localVarResponse = ProductionResourcePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionResourcePutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionResourcePutRequest</returns>
        public ApiResponse<ProductionResourcePutRequest> ProductionResourcePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productionResourcePutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourcePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ProductionResourcePutRequest>("/production/resource", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourcePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionResourcePutRequest</returns>
        public async System.Threading.Tasks.Task<ProductionResourcePutRequest> ProductionResourcePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionResourcePutRequest> localVarResponse = await ProductionResourcePutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productionResourcePutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + ResourceCapacities, ResourceCosts, ResourceRemarks, ResourceAttachments do not support modifying. Only creation and deletion.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionResourcePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionResourcePutRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionResourcePutRequest>> ProductionResourcePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionResourcePutRequest? productionResourcePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productionResourcePutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourcePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ProductionResourcePutRequest>("/production/resource", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourcePut", localVarResponse);
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
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionResourcePutRequest</returns>
        public ProductionResourcePutRequest ProductionResourceResourceidDelete(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductionResourcePutRequest> localVarResponse = ProductionResourceResourceidDeleteWithHttpInfo(resourceID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionResourcePutRequest</returns>
        public ApiResponse<ProductionResourcePutRequest> ProductionResourceResourceidDeleteWithHttpInfo(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'resourceID' is set
            if (resourceID == null)
            {
                throw new ApiException(400, "Missing required parameter 'resourceID' when calling ProductionApi->ProductionResourceResourceidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ResourceID", ClientUtils.ParameterToString(resourceID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourceResourceidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<ProductionResourcePutRequest>("/production/resource", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourceResourceidDelete", localVarResponse);
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
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionResourcePutRequest</returns>
        public async System.Threading.Tasks.Task<ProductionResourcePutRequest> ProductionResourceResourceidDeleteAsync(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionResourcePutRequest> localVarResponse = await ProductionResourceResourceidDeleteWithHttpInfoAsync(resourceID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionResourcePutRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionResourcePutRequest>> ProductionResourceResourceidDeleteWithHttpInfoAsync(string resourceID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'resourceID' is set
            if (resourceID == null)
            {
                throw new ApiException(400, "Missing required parameter 'resourceID' when calling ProductionApi->ProductionResourceResourceidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ResourceID", ClientUtils.ParameterToString(resourceID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourceResourceidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<ProductionResourcePutRequest>("/production/resource", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourceResourceidDelete", localVarResponse);
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
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionResourceResourceidIncludeattachmentsGet(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionResourceResourceidIncludeattachmentsGetWithHttpInfo(resourceID, includeAttachments, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionResourceResourceidIncludeattachmentsGetWithHttpInfo(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'resourceID' is set
            if (resourceID == null)
            {
                throw new ApiException(400, "Missing required parameter 'resourceID' when calling ProductionApi->ProductionResourceResourceidIncludeattachmentsGet");
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

            localVarRequestOptions.QueryParameters.Add("ResourceID", ClientUtils.ParameterToString(resourceID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeAttachments", ClientUtils.ParameterToString(includeAttachments)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourceResourceidIncludeattachmentsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/production/resource", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourceResourceidIncludeattachmentsGet", localVarResponse);
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
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionResourceResourceidIncludeattachmentsGetAsync(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionResourceResourceidIncludeattachmentsGetWithHttpInfoAsync(resourceID, includeAttachments, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceID">Identifier of Resource</param>
        /// <param name="includeAttachments"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionResourceResourceidIncludeattachmentsGetWithHttpInfoAsync(string resourceID, bool includeAttachments, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'resourceID' is set
            if (resourceID == null)
            {
                throw new ApiException(400, "Missing required parameter 'resourceID' when calling ProductionApi->ProductionResourceResourceidIncludeattachmentsGet");
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

            localVarRequestOptions.QueryParameters.Add("ResourceID", ClientUtils.ParameterToString(resourceID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeAttachments", ClientUtils.ParameterToString(includeAttachments)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourceResourceidIncludeattachmentsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/production/resource", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourceResourceidIncludeattachmentsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all resources.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionResourcelistPgLmtNameOnlyactiveGet(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfo(page, limit, name, onlyActive, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET + Method will return all resources.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfo(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductionApi->ProductionResourcelistPgLmtNameOnlyactiveGet");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OnlyActive", ClientUtils.ParameterToString(onlyActive)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourcelistPgLmtNameOnlyactiveGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/production/resourceList", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourcelistPgLmtNameOnlyactiveGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all resources.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionResourcelistPgLmtNameOnlyactiveGetAsync(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfoAsync(page, limit, name, onlyActive, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET + Method will return all resources.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return Resources that start with the specific Name or Code</param>
        /// <param name="onlyActive"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionResourcelistPgLmtNameOnlyactiveGetWithHttpInfoAsync(decimal page, decimal limit, string name, bool onlyActive, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductionApi->ProductionResourcelistPgLmtNameOnlyactiveGet");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            localVarRequestOptions.QueryParameters.Add("OnlyActive", ClientUtils.ParameterToString(onlyActive)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionResourcelistPgLmtNameOnlyactiveGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/production/resourceList", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionResourcelistPgLmtNameOnlyactiveGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all suspend reasons.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionSuspendreasonPgLmtWorkcenteridGet(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfo(page, limit, workcenterID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET + Method will return all suspend reasons.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfo(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'workcenterID' is set
            if (workcenterID == null)
            {
                throw new ApiException(400, "Missing required parameter 'workcenterID' when calling ProductionApi->ProductionSuspendreasonPgLmtWorkcenteridGet");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("WorkcenterID", ClientUtils.ParameterToString(workcenterID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionSuspendreasonPgLmtWorkcenteridGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/production/suspendReason", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionSuspendreasonPgLmtWorkcenteridGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all suspend reasons.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionSuspendreasonPgLmtWorkcenteridGetAsync(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfoAsync(page, limit, workcenterID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET + Method will return all suspend reasons.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="workcenterID"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionSuspendreasonPgLmtWorkcenteridGetWithHttpInfoAsync(decimal page, decimal limit, string workcenterID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'workcenterID' is set
            if (workcenterID == null)
            {
                throw new ApiException(400, "Missing required parameter 'workcenterID' when calling ProductionApi->ProductionSuspendreasonPgLmtWorkcenteridGet");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("WorkcenterID", ClientUtils.ParameterToString(workcenterID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionSuspendreasonPgLmtWorkcenteridGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/production/suspendReason", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionSuspendreasonPgLmtWorkcenteridGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionSuspendreasonPut200Response</returns>
        public ProductionSuspendreasonPut200Response ProductionSuspendreasonPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductionSuspendreasonPut200Response> localVarResponse = ProductionSuspendreasonPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionSuspendreasonPut200Response</returns>
        public ApiResponse<ProductionSuspendreasonPut200Response> ProductionSuspendreasonPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ProductionApi.ProductionSuspendreasonPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ProductionSuspendreasonPut200Response>("/production/suspendReason", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionSuspendreasonPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionSuspendreasonPut200Response</returns>
        public async System.Threading.Tasks.Task<ProductionSuspendreasonPut200Response> ProductionSuspendreasonPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionSuspendreasonPut200Response> localVarResponse = await ProductionSuspendreasonPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Workcenters do not support modifying. Only creation and deletion.  ### Available Fields for SuspendReason  | Property | Type           | Length | Required |Notes       | |:- -- -- --|- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -| | &#x60;SuspendReasonID&#x60;  | Guid           |         | Yes* | If it is empty, then will add new Suspend Reason, otherwise it will be modified | | &#x60;Reason&#x60;  | String             |         | Yes*  | Only for new entity | | &#x60;Workcenters&#x60;  | Guid Array             |         |    |  |
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionSuspendreasonPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionSuspendreasonPut200Response>> ProductionSuspendreasonPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ProductionApi.ProductionSuspendreasonPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ProductionSuspendreasonPut200Response>("/production/suspendReason", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionSuspendreasonPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all workcenters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionWorkcentersPgLmtNameGet(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionWorkcentersPgLmtNameGetWithHttpInfo(page, limit, name, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET + Method will return all workcenters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionWorkcentersPgLmtNameGetWithHttpInfo(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductionApi->ProductionWorkcentersPgLmtNameGet");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersPgLmtNameGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/production/workcenters", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersPgLmtNameGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// GET + Method will return all workcenters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionWorkcentersPgLmtNameGetAsync(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionWorkcentersPgLmtNameGetWithHttpInfoAsync(page, limit, name, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET + Method will return all workcenters.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name">Only return WorkCenters that start with the specific Name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionWorkcentersPgLmtNameGetWithHttpInfoAsync(decimal page, decimal limit, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductionApi->ProductionWorkcentersPgLmtNameGet");
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

            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersPgLmtNameGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/production/workcenters", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersPgLmtNameGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Work center locations will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionWorkcentersPost200Response</returns>
        public ProductionWorkcentersPost200Response ProductionWorkcentersPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductionWorkcentersPost200Response> localVarResponse = ProductionWorkcentersPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Work center locations will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionWorkcentersPost200Response</returns>
        public ApiResponse<ProductionWorkcentersPost200Response> ProductionWorkcentersPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ProductionWorkcentersPost200Response>("/production/workcenters", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Work center locations will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionWorkcentersPost200Response</returns>
        public async System.Threading.Tasks.Task<ProductionWorkcentersPost200Response> ProductionWorkcentersPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionWorkcentersPost200Response> localVarResponse = await ProductionWorkcentersPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Work center locations will be created.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionWorkcentersPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionWorkcentersPost200Response>> ProductionWorkcentersPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ProductionWorkcentersPost200Response>("/production/workcenters", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductionWorkcentersPut200Response</returns>
        public ProductionWorkcentersPut200Response ProductionWorkcentersPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductionWorkcentersPut200Response> localVarResponse = ProductionWorkcentersPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productionWorkcentersPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductionWorkcentersPut200Response</returns>
        public ApiResponse<ProductionWorkcentersPut200Response> ProductionWorkcentersPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productionWorkcentersPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ProductionWorkcentersPut200Response>("/production/workcenters", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductionWorkcentersPut200Response</returns>
        public async System.Threading.Tasks.Task<ProductionWorkcentersPut200Response> ProductionWorkcentersPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductionWorkcentersPut200Response> localVarResponse = await ProductionWorkcentersPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productionWorkcentersPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + If work center location does not exist, it will be created. If work center location exists, it will be updated.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productionWorkcentersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductionWorkcentersPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionWorkcentersPut200Response>> ProductionWorkcentersPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productionWorkcentersPutRequest;

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ProductionWorkcentersPut200Response>("/production/workcenters", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductionWorkcentersWorkcenteridDelete(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductionWorkcentersWorkcenteridDeleteWithHttpInfo(workCenterId, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// DELETE + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductionWorkcentersWorkcenteridDeleteWithHttpInfo(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'workCenterId' is set
            if (workCenterId == null)
            {
                throw new ApiException(400, "Missing required parameter 'workCenterId' when calling ProductionApi->ProductionWorkcentersWorkcenteridDelete");
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

            localVarRequestOptions.QueryParameters.Add("WorkCenterId", ClientUtils.ParameterToString(workCenterId)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersWorkcenteridDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<object>("/production/workcenters", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersWorkcenteridDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductionWorkcentersWorkcenteridDeleteAsync(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductionWorkcentersWorkcenteridDeleteWithHttpInfoAsync(workCenterId, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// DELETE + Method will delete workcenter with specified WorkCenterId if it exists.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="workCenterId">Identifier of WorkCenter to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductionWorkcentersWorkcenteridDeleteWithHttpInfoAsync(string workCenterId, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'workCenterId' is set
            if (workCenterId == null)
            {
                throw new ApiException(400, "Missing required parameter 'workCenterId' when calling ProductionApi->ProductionWorkcentersWorkcenteridDelete");
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

            localVarRequestOptions.QueryParameters.Add("WorkCenterId", ClientUtils.ParameterToString(workCenterId)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.ProductionWorkcentersWorkcenteridDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<object>("/production/workcenters", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductionWorkcentersWorkcenteridDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Put Attachment + Method allows to update IsProcessed field of Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PutAttachment200Response</returns>
        public PutAttachment200Response PutAttachment(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<PutAttachment200Response> localVarResponse = PutAttachmentWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Put Attachment + Method allows to update IsProcessed field of Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PutAttachment200Response</returns>
        public ApiResponse<PutAttachment200Response> PutAttachmentWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ProductionApi.PutAttachment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<PutAttachment200Response>("/production/order/attachment", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PutAttachment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Put Attachment + Method allows to update IsProcessed field of Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PutAttachment200Response</returns>
        public async System.Threading.Tasks.Task<PutAttachment200Response> PutAttachmentAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PutAttachment200Response> localVarResponse = await PutAttachmentWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Put Attachment + Method allows to update IsProcessed field of Production Order attachment.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PutAttachment200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PutAttachment200Response>> PutAttachmentWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ProductionApi.PutAttachment";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<PutAttachment200Response>("/production/order/attachment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PutAttachment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Release + Method will release Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Release200Response</returns>
        public Release200Response Release(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0)
        {
            ApiResponse<Release200Response> localVarResponse = ReleaseWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, releaseRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Release + Method will release Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Release200Response</returns>
        public ApiResponse<Release200Response> ReleaseWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = releaseRequest;

            localVarRequestOptions.Operation = "ProductionApi.Release";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<Release200Response>("/production/order/release", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Release", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Release + Method will release Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Release200Response</returns>
        public async System.Threading.Tasks.Task<Release200Response> ReleaseAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Release200Response> localVarResponse = await ReleaseWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, releaseRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Release + Method will release Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="releaseRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Release200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Release200Response>> ReleaseWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReleaseRequest? releaseRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = releaseRequest;

            localVarRequestOptions.Operation = "ProductionApi.Release";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<Release200Response>("/production/order/release", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Release", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resume Run Operation + Method will resume operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ResumeRunOperation200Response</returns>
        public ResumeRunOperation200Response ResumeRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0)
        {
            ApiResponse<ResumeRunOperation200Response> localVarResponse = ResumeRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, resumeRunOperationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resume Run Operation + Method will resume operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ResumeRunOperation200Response</returns>
        public ApiResponse<ResumeRunOperation200Response> ResumeRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = resumeRunOperationRequest;

            localVarRequestOptions.Operation = "ProductionApi.ResumeRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ResumeRunOperation200Response>("/production/order/run/operation/resume", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ResumeRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resume Run Operation + Method will resume operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResumeRunOperation200Response</returns>
        public async System.Threading.Tasks.Task<ResumeRunOperation200Response> ResumeRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ResumeRunOperation200Response> localVarResponse = await ResumeRunOperationWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, resumeRunOperationRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resume Run Operation + Method will resume operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="resumeRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResumeRunOperation200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResumeRunOperation200Response>> ResumeRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ResumeRunOperationRequest? resumeRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = resumeRunOperationRequest;

            localVarRequestOptions.Operation = "ProductionApi.ResumeRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ResumeRunOperation200Response>("/production/order/run/operation/resume", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ResumeRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start Run Operation + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StartRunOperation200Response</returns>
        public StartRunOperation200Response StartRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0)
        {
            ApiResponse<StartRunOperation200Response> localVarResponse = StartRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, startRunOperationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start Run Operation + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StartRunOperation200Response</returns>
        public ApiResponse<StartRunOperation200Response> StartRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = startRunOperationRequest;

            localVarRequestOptions.Operation = "ProductionApi.StartRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<StartRunOperation200Response>("/production/order/run/operation/start", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("StartRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start Run Operation + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StartRunOperation200Response</returns>
        public async System.Threading.Tasks.Task<StartRunOperation200Response> StartRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StartRunOperation200Response> localVarResponse = await StartRunOperationWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, startRunOperationRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start Run Operation + Method will start operation.  \&quot;InputProducts\&quot; - (optional) is used only if we want to send specific quantity or batch for input products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="startRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StartRunOperation200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StartRunOperation200Response>> StartRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, StartRunOperationRequest? startRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = startRunOperationRequest;

            localVarRequestOptions.Operation = "ProductionApi.StartRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<StartRunOperation200Response>("/production/order/run/operation/start", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("StartRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Suspend Run Operation + Method will suspend operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SuspendRunOperation200Response</returns>
        public SuspendRunOperation200Response SuspendRunOperation(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0)
        {
            ApiResponse<SuspendRunOperation200Response> localVarResponse = SuspendRunOperationWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, suspendRunOperationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Suspend Run Operation + Method will suspend operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SuspendRunOperation200Response</returns>
        public ApiResponse<SuspendRunOperation200Response> SuspendRunOperationWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = suspendRunOperationRequest;

            localVarRequestOptions.Operation = "ProductionApi.SuspendRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<SuspendRunOperation200Response>("/production/order/run/operation/suspend", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SuspendRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Suspend Run Operation + Method will suspend operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SuspendRunOperation200Response</returns>
        public async System.Threading.Tasks.Task<SuspendRunOperation200Response> SuspendRunOperationAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SuspendRunOperation200Response> localVarResponse = await SuspendRunOperationWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, suspendRunOperationRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Suspend Run Operation + Method will suspend operation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="suspendRunOperationRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SuspendRunOperation200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuspendRunOperation200Response>> SuspendRunOperationWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, SuspendRunOperationRequest? suspendRunOperationRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = suspendRunOperationRequest;

            localVarRequestOptions.Operation = "ProductionApi.SuspendRunOperation";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<SuspendRunOperation200Response>("/production/order/run/operation/suspend", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("SuspendRunOperation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Undo + Method will undo Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Undo200Response</returns>
        public Undo200Response Undo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0)
        {
            ApiResponse<Undo200Response> localVarResponse = UndoWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Undo + Method will undo Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Undo200Response</returns>
        public ApiResponse<Undo200Response> UndoWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = undoRequest;

            localVarRequestOptions.Operation = "ProductionApi.Undo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<Undo200Response>("/production/order/undo", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Undo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Undo + Method will undo Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Undo200Response</returns>
        public async System.Threading.Tasks.Task<Undo200Response> UndoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Undo200Response> localVarResponse = await UndoWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, undoRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Undo + Method will undo Production Order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Undo200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Undo200Response>> UndoWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRequest? undoRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = undoRequest;

            localVarRequestOptions.Operation = "ProductionApi.Undo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<Undo200Response>("/production/order/undo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Undo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Undo Run + Method will undo Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UndoRun200Response</returns>
        public UndoRun200Response UndoRun(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0)
        {
            ApiResponse<UndoRun200Response> localVarResponse = UndoRunWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Undo Run + Method will undo Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UndoRun200Response</returns>
        public ApiResponse<UndoRun200Response> UndoRunWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = undoRunRequest;

            localVarRequestOptions.Operation = "ProductionApi.UndoRun";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<UndoRun200Response>("/production/order/run/undo", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UndoRun", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Undo Run + Method will undo Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UndoRun200Response</returns>
        public async System.Threading.Tasks.Task<UndoRun200Response> UndoRunAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<UndoRun200Response> localVarResponse = await UndoRunWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Undo Run + Method will undo Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UndoRun200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UndoRun200Response>> UndoRunWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = undoRunRequest;

            localVarRequestOptions.Operation = "ProductionApi.UndoRun";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<UndoRun200Response>("/production/order/run/undo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UndoRun", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update Manual Journals + Method will create or update Manual Journals of Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void UpdateManualJournals(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            UpdateManualJournalsWithHttpInfo(productionOrderID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Update Manual Journals + Method will create or update Manual Journals of Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> UpdateManualJournalsWithHttpInfo(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->UpdateManualJournals");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.UpdateManualJournals";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<object>("/production/order/run/manualJournal", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateManualJournals", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update Manual Journals + Method will create or update Manual Journals of Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateManualJournalsAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await UpdateManualJournalsWithHttpInfoAsync(productionOrderID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update Manual Journals + Method will create or update Manual Journals of Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionOrderID">Production Order identifier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> UpdateManualJournalsWithHttpInfoAsync(string productionOrderID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productionOrderID' is set
            if (productionOrderID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productionOrderID' when calling ProductionApi->UpdateManualJournals");
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

            localVarRequestOptions.QueryParameters.Add("ProductionOrderID", ClientUtils.ParameterToString(productionOrderID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductionApi.UpdateManualJournals";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<object>("/production/order/run/manualJournal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateManualJournals", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Void Run + Method will void Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UndoRun200Response</returns>
        public UndoRun200Response VoidRun(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0)
        {
            ApiResponse<UndoRun200Response> localVarResponse = VoidRunWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Void Run + Method will void Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UndoRun200Response</returns>
        public ApiResponse<UndoRun200Response> VoidRunWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = undoRunRequest;

            localVarRequestOptions.Operation = "ProductionApi.VoidRun";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<UndoRun200Response>("/production/order/run/void", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("VoidRun", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Void Run + Method will void Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UndoRun200Response</returns>
        public async System.Threading.Tasks.Task<UndoRun200Response> VoidRunAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<UndoRun200Response> localVarResponse = await VoidRunWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Void Run + Method will void Run.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="undoRunRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UndoRun200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UndoRun200Response>> VoidRunWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UndoRunRequest? undoRunRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = undoRunRequest;

            localVarRequestOptions.Operation = "ProductionApi.VoidRun";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<UndoRun200Response>("/production/order/run/void", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("VoidRun", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
    }
}