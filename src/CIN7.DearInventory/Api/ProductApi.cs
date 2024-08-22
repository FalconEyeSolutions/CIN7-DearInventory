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
    public interface IProductApiSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void IdPgLmtNameSkuEtc(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> IdPgLmtNameSkuEtcWithHttpInfo(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;</returns>
        List<ProductAttachmentsIdDelete200ResponseInner> ProductAttachmentsIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;</returns>
        ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>> ProductAttachmentsIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        List<ProductAttachmentsPost200ResponseInner> ProductAttachmentsPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

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
        /// <returns>ApiResponse of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        ApiResponse<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        List<ProductAttachmentsPost200ResponseInner> ProductAttachmentsProductidGet(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        ApiResponse<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsProductidGetWithHttpInfo(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductPost200Response</returns>
        ProductPost200Response ProductPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductPost200Response</returns>
        ApiResponse<ProductPost200Response> ProductPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductPut200Response</returns>
        ProductPut200Response ProductPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductPut200Response</returns>
        ApiResponse<ProductPut200Response> ProductPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductavailabilityPgLmtIdNameEtc200Response</returns>
        ProductavailabilityPgLmtIdNameEtc200Response ProductavailabilityPgLmtIdNameEtc(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductavailabilityPgLmtIdNameEtc200Response</returns>
        ApiResponse<ProductavailabilityPgLmtIdNameEtc200Response> ProductavailabilityPgLmtIdNameEtcWithHttpInfo(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task IdPgLmtNameSkuEtcAsync(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> IdPgLmtNameSkuEtcWithHttpInfoAsync(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;</returns>
        System.Threading.Tasks.Task<List<ProductAttachmentsIdDelete200ResponseInner>> ProductAttachmentsIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>>> ProductAttachmentsIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        System.Threading.Tasks.Task<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

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
        /// <returns>Task of ApiResponse (List&lt;ProductAttachmentsPost200ResponseInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ProductAttachmentsPost200ResponseInner>>> ProductAttachmentsPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        System.Threading.Tasks.Task<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsProductidGetAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProductAttachmentsPost200ResponseInner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ProductAttachmentsPost200ResponseInner>>> ProductAttachmentsProductidGetWithHttpInfoAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductPost200Response</returns>
        System.Threading.Tasks.Task<ProductPost200Response> ProductPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductPost200Response>> ProductPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductPut200Response</returns>
        System.Threading.Tasks.Task<ProductPut200Response> ProductPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductPut200Response>> ProductPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductavailabilityPgLmtIdNameEtc200Response</returns>
        System.Threading.Tasks.Task<ProductavailabilityPgLmtIdNameEtc200Response> ProductavailabilityPgLmtIdNameEtcAsync(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductavailabilityPgLmtIdNameEtc200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductavailabilityPgLmtIdNameEtc200Response>> ProductavailabilityPgLmtIdNameEtcWithHttpInfoAsync(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductApi : IProductApiSync, IProductApiAsync
    {
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductApi : IProductApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProductApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProductApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProductApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void IdPgLmtNameSkuEtc(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            IdPgLmtNameSkuEtcWithHttpInfo(ID, page, limit, name, sku, modifiedSince, includeDeprecated, includeBOM, includeSuppliers, includeMovements, includeAttachments, includeReorderLevels, includeCustomPrices, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> IdPgLmtNameSkuEtcWithHttpInfo(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ProductApi->IdPgLmtNameSkuEtc");
            }

            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductApi->IdPgLmtNameSkuEtc");
            }

            // verify the required parameter 'sku' is set
            if (sku == null)
            {
                throw new ApiException(400, "Missing required parameter 'sku' when calling ProductApi->IdPgLmtNameSkuEtc");
            }

            // verify the required parameter 'modifiedSince' is set
            if (modifiedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'modifiedSince' when calling ProductApi->IdPgLmtNameSkuEtc");
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

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Sku", ClientUtils.ParameterToString(sku)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ModifiedSince", ClientUtils.ParameterToString(modifiedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeDeprecated", ClientUtils.ParameterToString(includeDeprecated)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeBOM", ClientUtils.ParameterToString(includeBOM)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeSuppliers", ClientUtils.ParameterToString(includeSuppliers)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeMovements", ClientUtils.ParameterToString(includeMovements)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeAttachments", ClientUtils.ParameterToString(includeAttachments)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeReorderLevels", ClientUtils.ParameterToString(includeReorderLevels)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeCustomPrices", ClientUtils.ParameterToString(includeCustomPrices)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductApi.IdPgLmtNameSkuEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<object>("/product", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("IdPgLmtNameSkuEtc", localVarResponse);
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
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task IdPgLmtNameSkuEtcAsync(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await IdPgLmtNameSkuEtcWithHttpInfoAsync(ID, page, limit, name, sku, modifiedSince, includeDeprecated, includeBOM, includeSuppliers, includeMovements, includeAttachments, includeReorderLevels, includeCustomPrices, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns stock info of a particular product (Default: null)</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 100. (Default: 100)</param>
        /// <param name="name">Only return products with product name containing specified name value (Default: null)</param>
        /// <param name="sku">Only return products with product sku containing specified sku value (Default: null)</param>
        /// <param name="modifiedSince">Only return Products modified since specified date (UTC time) in ISO 8601 format. (Default: null)</param>
        /// <param name="includeDeprecated">Returns all Products, including deprecated, if set to true. If set to false or if it is not specified then returns only active (ie. non-deprecated) Products (Default: false)</param>
        /// <param name="includeBOM">Include Bill Of Materials information (Default: false)</param>
        /// <param name="includeSuppliers">Include Suppliers information (Default: false)</param>
        /// <param name="includeMovements">Include Movements information (Default: false)</param>
        /// <param name="includeAttachments">Include Attachments information (Default: false)</param>
        /// <param name="includeReorderLevels">Include Reorder Levels information (Default: false)</param>
        /// <param name="includeCustomPrices">Include Customer specific Prices (Default: false)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> IdPgLmtNameSkuEtcWithHttpInfoAsync(string ID, decimal page, decimal limit, string name, string sku, string modifiedSince, bool includeDeprecated, bool includeBOM, bool includeSuppliers, bool includeMovements, bool includeAttachments, bool includeReorderLevels, bool includeCustomPrices, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ProductApi->IdPgLmtNameSkuEtc");
            }

            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductApi->IdPgLmtNameSkuEtc");
            }

            // verify the required parameter 'sku' is set
            if (sku == null)
            {
                throw new ApiException(400, "Missing required parameter 'sku' when calling ProductApi->IdPgLmtNameSkuEtc");
            }

            // verify the required parameter 'modifiedSince' is set
            if (modifiedSince == null)
            {
                throw new ApiException(400, "Missing required parameter 'modifiedSince' when calling ProductApi->IdPgLmtNameSkuEtc");
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

            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Sku", ClientUtils.ParameterToString(sku)); // path parameter
            localVarRequestOptions.QueryParameters.Add("ModifiedSince", ClientUtils.ParameterToString(modifiedSince)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeDeprecated", ClientUtils.ParameterToString(includeDeprecated)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeBOM", ClientUtils.ParameterToString(includeBOM)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeSuppliers", ClientUtils.ParameterToString(includeSuppliers)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeMovements", ClientUtils.ParameterToString(includeMovements)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeAttachments", ClientUtils.ParameterToString(includeAttachments)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeReorderLevels", ClientUtils.ParameterToString(includeReorderLevels)); // path parameter
            localVarRequestOptions.QueryParameters.Add("IncludeCustomPrices", ClientUtils.ParameterToString(includeCustomPrices)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductApi.IdPgLmtNameSkuEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<object>("/product", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("IdPgLmtNameSkuEtc", localVarResponse);
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
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;</returns>
        public List<ProductAttachmentsIdDelete200ResponseInner> ProductAttachmentsIdDelete(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>> localVarResponse = ProductAttachmentsIdDeleteWithHttpInfo(ID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;</returns>
        public ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>> ProductAttachmentsIdDeleteWithHttpInfo(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ProductApi->ProductAttachmentsIdDelete");
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

            localVarRequestOptions.Operation = "ProductApi.ProductAttachmentsIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<List<ProductAttachmentsIdDelete200ResponseInner>>("/product/attachments", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductAttachmentsIdDelete", localVarResponse);
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
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<ProductAttachmentsIdDelete200ResponseInner>> ProductAttachmentsIdDeleteAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>> localVarResponse = await ProductAttachmentsIdDeleteWithHttpInfoAsync(ID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">ID of Product Attachment to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProductAttachmentsIdDelete200ResponseInner&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ProductAttachmentsIdDelete200ResponseInner>>> ProductAttachmentsIdDeleteWithHttpInfoAsync(string ID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ProductApi->ProductAttachmentsIdDelete");
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

            localVarRequestOptions.Operation = "ProductApi.ProductAttachmentsIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<List<ProductAttachmentsIdDelete200ResponseInner>>("/product/attachments", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductAttachmentsIdDelete", localVarResponse);
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
        /// <returns>List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        public List<ProductAttachmentsPost200ResponseInner> ProductAttachmentsPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<List<ProductAttachmentsPost200ResponseInner>> localVarResponse = ProductAttachmentsPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        public ApiResponse<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ProductApi.ProductAttachmentsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<List<ProductAttachmentsPost200ResponseInner>>("/product/attachments", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductAttachmentsPost", localVarResponse);
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
        /// <returns>Task of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<List<ProductAttachmentsPost200ResponseInner>> localVarResponse = await ProductAttachmentsPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
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
        /// <returns>Task of ApiResponse (List&lt;ProductAttachmentsPost200ResponseInner&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ProductAttachmentsPost200ResponseInner>>> ProductAttachmentsPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ProductApi.ProductAttachmentsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<List<ProductAttachmentsPost200ResponseInner>>("/product/attachments", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductAttachmentsPost", localVarResponse);
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
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        public List<ProductAttachmentsPost200ResponseInner> ProductAttachmentsProductidGet(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<List<ProductAttachmentsPost200ResponseInner>> localVarResponse = ProductAttachmentsProductidGetWithHttpInfo(productID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        public ApiResponse<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsProductidGetWithHttpInfo(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ProductApi->ProductAttachmentsProductidGet");
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
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductApi.ProductAttachmentsProductidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<List<ProductAttachmentsPost200ResponseInner>>("/product/attachments", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductAttachmentsProductidGet", localVarResponse);
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
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProductAttachmentsPost200ResponseInner&gt;</returns>
        public async System.Threading.Tasks.Task<List<ProductAttachmentsPost200ResponseInner>> ProductAttachmentsProductidGetAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<List<ProductAttachmentsPost200ResponseInner>> localVarResponse = await ProductAttachmentsProductidGetWithHttpInfoAsync(productID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Returns attachments info of a particular product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProductAttachmentsPost200ResponseInner&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ProductAttachmentsPost200ResponseInner>>> ProductAttachmentsProductidGetWithHttpInfoAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ProductApi->ProductAttachmentsProductidGet");
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
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductApi.ProductAttachmentsProductidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<List<ProductAttachmentsPost200ResponseInner>>("/product/attachments", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductAttachmentsProductidGet", localVarResponse);
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
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductPost200Response</returns>
        public ProductPost200Response ProductPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductPost200Response> localVarResponse = ProductPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductPost200Response</returns>
        public ApiResponse<ProductPost200Response> ProductPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productPostRequest;

            localVarRequestOptions.Operation = "ProductApi.ProductPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ProductPost200Response>("/product", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductPost", localVarResponse);
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
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductPost200Response</returns>
        public async System.Threading.Tasks.Task<ProductPost200Response> ProductPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductPost200Response> localVarResponse = await ProductPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductPost200Response>> ProductPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPostRequest? productPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productPostRequest;

            localVarRequestOptions.Operation = "ProductApi.ProductPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ProductPost200Response>("/product", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductPost", localVarResponse);
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
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductPut200Response</returns>
        public ProductPut200Response ProductPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ProductPut200Response> localVarResponse = ProductPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductPut200Response</returns>
        public ApiResponse<ProductPut200Response> ProductPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productPutRequest;

            localVarRequestOptions.Operation = "ProductApi.ProductPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ProductPut200Response>("/product", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductPut", localVarResponse);
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
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductPut200Response</returns>
        public async System.Threading.Tasks.Task<ProductPut200Response> ProductPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductPut200Response> localVarResponse = await ProductPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductPut200Response>> ProductPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductPutRequest? productPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productPutRequest;

            localVarRequestOptions.Operation = "ProductApi.ProductPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ProductPut200Response>("/product", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductPut", localVarResponse);
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
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductavailabilityPgLmtIdNameEtc200Response</returns>
        public ProductavailabilityPgLmtIdNameEtc200Response ProductavailabilityPgLmtIdNameEtc(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductavailabilityPgLmtIdNameEtc200Response> localVarResponse = ProductavailabilityPgLmtIdNameEtcWithHttpInfo(page, limit, ID, name, sku, location, batch, category, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductavailabilityPgLmtIdNameEtc200Response</returns>
        public ApiResponse<ProductavailabilityPgLmtIdNameEtc200Response> ProductavailabilityPgLmtIdNameEtcWithHttpInfo(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'sku' is set
            if (sku == null)
            {
                throw new ApiException(400, "Missing required parameter 'sku' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'location' is set
            if (location == null)
            {
                throw new ApiException(400, "Missing required parameter 'location' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'batch' is set
            if (batch == null)
            {
                throw new ApiException(400, "Missing required parameter 'batch' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new ApiException(400, "Missing required parameter 'category' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
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
            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Sku", ClientUtils.ParameterToString(sku)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Location", ClientUtils.ParameterToString(location)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Batch", ClientUtils.ParameterToString(batch)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Category", ClientUtils.ParameterToString(category)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductApi.ProductavailabilityPgLmtIdNameEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ProductavailabilityPgLmtIdNameEtc200Response>("/ref/productavailability", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductavailabilityPgLmtIdNameEtc", localVarResponse);
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
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductavailabilityPgLmtIdNameEtc200Response</returns>
        public async System.Threading.Tasks.Task<ProductavailabilityPgLmtIdNameEtc200Response> ProductavailabilityPgLmtIdNameEtcAsync(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductavailabilityPgLmtIdNameEtc200Response> localVarResponse = await ProductavailabilityPgLmtIdNameEtcWithHttpInfoAsync(page, limit, ID, name, sku, location, batch, category, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="batch"></param>
        /// <param name="category"></param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductavailabilityPgLmtIdNameEtc200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductavailabilityPgLmtIdNameEtc200Response>> ProductavailabilityPgLmtIdNameEtcWithHttpInfoAsync(decimal page, decimal limit, string ID, string name, string sku, string location, string batch, string category, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'sku' is set
            if (sku == null)
            {
                throw new ApiException(400, "Missing required parameter 'sku' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'location' is set
            if (location == null)
            {
                throw new ApiException(400, "Missing required parameter 'location' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'batch' is set
            if (batch == null)
            {
                throw new ApiException(400, "Missing required parameter 'batch' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
            }

            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new ApiException(400, "Missing required parameter 'category' when calling ProductApi->ProductavailabilityPgLmtIdNameEtc");
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
            localVarRequestOptions.QueryParameters.Add("ID", ClientUtils.ParameterToString(ID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Sku", ClientUtils.ParameterToString(sku)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Location", ClientUtils.ParameterToString(location)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Batch", ClientUtils.ParameterToString(batch)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Category", ClientUtils.ParameterToString(category)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ProductApi.ProductavailabilityPgLmtIdNameEtc";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ProductavailabilityPgLmtIdNameEtc200Response>("/ref/productavailability", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductavailabilityPgLmtIdNameEtc", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
    }
}