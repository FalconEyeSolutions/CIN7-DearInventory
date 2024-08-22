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
    public interface IReferenceBooksApiSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Customer specific prices for specified products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomPricesPut200Response</returns>
        CustomPricesPut200Response CustomPricesPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Customer specific prices for specified products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomPricesPut200Response</returns>
        ApiResponse<CustomPricesPut200Response> CustomPricesPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void CustomPricesProductidCustomeridDelete(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> CustomPricesProductidCustomeridDeleteWithHttpInfo(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomPricesPut200Response</returns>
        CustomPricesPut200Response CustomPricesPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomPricesPut200Response</returns>
        ApiResponse<CustomPricesPut200Response> CustomPricesPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Get200Response</returns>
        Get200Response Get(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Get200Response</returns>
        ApiResponse<Get200Response> GetWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        MeAddressesIdDelete200Response ProductSuppliersPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        ApiResponse<MeAddressesIdDelete200Response> ProductSuppliersPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductSuppliersProductidGet200Response</returns>
        ProductSuppliersProductidGet200Response ProductSuppliersProductidGet(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductSuppliersProductidGet200Response</returns>
        ApiResponse<ProductSuppliersProductidGet200Response> ProductSuppliersProductidGetWithHttpInfo(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void ProductSuppliersProductidSupplieridDelete(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ProductSuppliersProductidSupplieridDeleteWithHttpInfo(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        MeAddressesIdDelete200Response ProductSuppliersPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        ApiResponse<MeAddressesIdDelete200Response> ProductSuppliersPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDealsIdPgLmtSrchGet200Response</returns>
        ReferenceDealsIdPgLmtSrchGet200Response ReferenceDealsIdPgLmtSrchGet(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDealsIdPgLmtSrchGet200Response</returns>
        ApiResponse<ReferenceDealsIdPgLmtSrchGet200Response> ReferenceDealsIdPgLmtSrchGetWithHttpInfo(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDealsPost200Response</returns>
        ReferenceDealsPost200Response ReferenceDealsPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDealsPost200Response</returns>
        ApiResponse<ReferenceDealsPost200Response> ReferenceDealsPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDealsPut200Response</returns>
        ReferenceDealsPut200Response ReferenceDealsPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDealsPut200Response</returns>
        ApiResponse<ReferenceDealsPut200Response> ReferenceDealsPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDiscountIdPgLmtSrchGet200Response</returns>
        ReferenceDiscountIdPgLmtSrchGet200Response ReferenceDiscountIdPgLmtSrchGet(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDiscountIdPgLmtSrchGet200Response</returns>
        ApiResponse<ReferenceDiscountIdPgLmtSrchGet200Response> ReferenceDiscountIdPgLmtSrchGetWithHttpInfo(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDiscountPost200Response</returns>
        ReferenceDiscountPost200Response ReferenceDiscountPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDiscountPost200Response</returns>
        ApiResponse<ReferenceDiscountPost200Response> ReferenceDiscountPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDiscountPut200Response</returns>
        ReferenceDiscountPut200Response ReferenceDiscountPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDiscountPut200Response</returns>
        ApiResponse<ReferenceDiscountPut200Response> ReferenceDiscountPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceShipzonesIdPgLmtSrchGet200Response</returns>
        ReferenceShipzonesIdPgLmtSrchGet200Response ReferenceShipzonesIdPgLmtSrchGet(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceShipzonesIdPgLmtSrchGet200Response</returns>
        ApiResponse<ReferenceShipzonesIdPgLmtSrchGet200Response> ReferenceShipzonesIdPgLmtSrchGetWithHttpInfo(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceShipzonesPost200Response</returns>
        ReferenceShipzonesPost200Response ReferenceShipzonesPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceShipzonesPost200Response</returns>
        ApiResponse<ReferenceShipzonesPost200Response> ReferenceShipzonesPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceShipzonesPut200Response</returns>
        ReferenceShipzonesPut200Response ReferenceShipzonesPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceShipzonesPut200Response</returns>
        ApiResponse<ReferenceShipzonesPut200Response> ReferenceShipzonesPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0);

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        MeAddressesIdDelete200Response ReferenceShipzonesShipzoneidDelete(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        ApiResponse<MeAddressesIdDelete200Response> ReferenceShipzonesShipzoneidDeleteWithHttpInfo(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UpdateRequest</returns>
        UpdateRequest Update(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UpdateRequest</returns>
        ApiResponse<UpdateRequest> UpdateWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReferenceBooksApiAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Customer specific prices for specified products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomPricesPut200Response</returns>
        System.Threading.Tasks.Task<CustomPricesPut200Response> CustomPricesPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        /// + Method will create new Customer specific prices for specified products.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomPricesPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomPricesPut200Response>> CustomPricesPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CustomPricesProductidCustomeridDeleteAsync(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Production BOM of specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> CustomPricesProductidCustomeridDeleteWithHttpInfoAsync(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomPricesPut200Response</returns>
        System.Threading.Tasks.Task<CustomPricesPut200Response> CustomPricesPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        /// + Method will update Production BOM for specified product.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomPricesPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomPricesPut200Response>> CustomPricesPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get200Response</returns>
        System.Threading.Tasks.Task<Get200Response> GetAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Get200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Get200Response>> GetWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        System.Threading.Tasks.Task<MeAddressesIdDelete200Response> ProductSuppliersPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> ProductSuppliersPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductSuppliersProductidGet200Response</returns>
        System.Threading.Tasks.Task<ProductSuppliersProductidGet200Response> ProductSuppliersProductidGetAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductSuppliersProductidGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductSuppliersProductidGet200Response>> ProductSuppliersProductidGetWithHttpInfoAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProductSuppliersProductidSupplieridDeleteAsync(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DELETE
        /// </summary>
        /// <remarks>
        /// + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> ProductSuppliersProductidSupplieridDeleteWithHttpInfoAsync(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        System.Threading.Tasks.Task<MeAddressesIdDelete200Response> ProductSuppliersPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> ProductSuppliersPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDealsIdPgLmtSrchGet200Response</returns>
        System.Threading.Tasks.Task<ReferenceDealsIdPgLmtSrchGet200Response> ReferenceDealsIdPgLmtSrchGetAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDealsIdPgLmtSrchGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceDealsIdPgLmtSrchGet200Response>> ReferenceDealsIdPgLmtSrchGetWithHttpInfoAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDealsPost200Response</returns>
        System.Threading.Tasks.Task<ReferenceDealsPost200Response> ReferenceDealsPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDealsPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceDealsPost200Response>> ReferenceDealsPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDealsPut200Response</returns>
        System.Threading.Tasks.Task<ReferenceDealsPut200Response> ReferenceDealsPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDealsPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceDealsPut200Response>> ReferenceDealsPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDiscountIdPgLmtSrchGet200Response</returns>
        System.Threading.Tasks.Task<ReferenceDiscountIdPgLmtSrchGet200Response> ReferenceDiscountIdPgLmtSrchGetAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDiscountIdPgLmtSrchGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceDiscountIdPgLmtSrchGet200Response>> ReferenceDiscountIdPgLmtSrchGetWithHttpInfoAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDiscountPost200Response</returns>
        System.Threading.Tasks.Task<ReferenceDiscountPost200Response> ReferenceDiscountPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDiscountPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceDiscountPost200Response>> ReferenceDiscountPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDiscountPut200Response</returns>
        System.Threading.Tasks.Task<ReferenceDiscountPut200Response> ReferenceDiscountPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDiscountPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceDiscountPut200Response>> ReferenceDiscountPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceShipzonesIdPgLmtSrchGet200Response</returns>
        System.Threading.Tasks.Task<ReferenceShipzonesIdPgLmtSrchGet200Response> ReferenceShipzonesIdPgLmtSrchGetAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceShipzonesIdPgLmtSrchGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceShipzonesIdPgLmtSrchGet200Response>> ReferenceShipzonesIdPgLmtSrchGetWithHttpInfoAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceShipzonesPost200Response</returns>
        System.Threading.Tasks.Task<ReferenceShipzonesPost200Response> ReferenceShipzonesPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceShipzonesPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceShipzonesPost200Response>> ReferenceShipzonesPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceShipzonesPut200Response</returns>
        System.Threading.Tasks.Task<ReferenceShipzonesPut200Response> ReferenceShipzonesPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceShipzonesPut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceShipzonesPut200Response>> ReferenceShipzonesPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        System.Threading.Tasks.Task<MeAddressesIdDelete200Response> ReferenceShipzonesShipzoneidDeleteAsync(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> ReferenceShipzonesShipzoneidDeleteWithHttpInfoAsync(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpdateRequest</returns>
        System.Threading.Tasks.Task<UpdateRequest> UpdateAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpdateRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateRequest>> UpdateWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReferenceBooksApi : IReferenceBooksApiSync, IReferenceBooksApiAsync
    {
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReferenceBooksApi : IReferenceBooksApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceBooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReferenceBooksApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceBooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReferenceBooksApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ReferenceBooksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReferenceBooksApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ReferenceBooksApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ReferenceBooksApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// POST + Method will create new Customer specific prices for specified products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomPricesPut200Response</returns>
        public CustomPricesPut200Response CustomPricesPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<CustomPricesPut200Response> localVarResponse = CustomPricesPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Method will create new Customer specific prices for specified products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomPricesPut200Response</returns>
        public ApiResponse<CustomPricesPut200Response> CustomPricesPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = customPricesPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.CustomPricesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<CustomPricesPut200Response>("/custom-prices", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CustomPricesPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// POST + Method will create new Customer specific prices for specified products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomPricesPut200Response</returns>
        public async System.Threading.Tasks.Task<CustomPricesPut200Response> CustomPricesPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CustomPricesPut200Response> localVarResponse = await CustomPricesPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST + Method will create new Customer specific prices for specified products.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomPricesPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomPricesPut200Response>> CustomPricesPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = customPricesPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.CustomPricesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<CustomPricesPut200Response>("/custom-prices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CustomPricesPost", localVarResponse);
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
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void CustomPricesProductidCustomeridDelete(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            CustomPricesProductidCustomeridDeleteWithHttpInfo(productID, customerID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> CustomPricesProductidCustomeridDeleteWithHttpInfo(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ReferenceBooksApi->CustomPricesProductidCustomeridDelete");
            }

            // verify the required parameter 'customerID' is set
            if (customerID == null)
            {
                throw new ApiException(400, "Missing required parameter 'customerID' when calling ReferenceBooksApi->CustomPricesProductidCustomeridDelete");
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
            localVarRequestOptions.QueryParameters.Add("CustomerID", ClientUtils.ParameterToString(customerID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.CustomPricesProductidCustomeridDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<object>("/custom-prices", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CustomPricesProductidCustomeridDelete", localVarResponse);
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
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CustomPricesProductidCustomeridDeleteAsync(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await CustomPricesProductidCustomeridDeleteWithHttpInfoAsync(productID, customerID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// DELETE + Method will delete specified Production BOM of specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product whose Custom Price will be deleted</param>
        /// <param name="customerID">Identifier of a Customer whose Custom Price will be deleted</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> CustomPricesProductidCustomeridDeleteWithHttpInfoAsync(string productID, string customerID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ReferenceBooksApi->CustomPricesProductidCustomeridDelete");
            }

            // verify the required parameter 'customerID' is set
            if (customerID == null)
            {
                throw new ApiException(400, "Missing required parameter 'customerID' when calling ReferenceBooksApi->CustomPricesProductidCustomeridDelete");
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
            localVarRequestOptions.QueryParameters.Add("CustomerID", ClientUtils.ParameterToString(customerID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.CustomPricesProductidCustomeridDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<object>("/custom-prices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CustomPricesProductidCustomeridDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomPricesPut200Response</returns>
        public CustomPricesPut200Response CustomPricesPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<CustomPricesPut200Response> localVarResponse = CustomPricesPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomPricesPut200Response</returns>
        public ApiResponse<CustomPricesPut200Response> CustomPricesPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = customPricesPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.CustomPricesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<CustomPricesPut200Response>("/custom-prices", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CustomPricesPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomPricesPut200Response</returns>
        public async System.Threading.Tasks.Task<CustomPricesPut200Response> CustomPricesPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CustomPricesPut200Response> localVarResponse = await CustomPricesPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, customPricesPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT + Method will update Production BOM for specified product.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="customPricesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomPricesPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomPricesPut200Response>> CustomPricesPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, CustomPricesPutRequest? customPricesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = customPricesPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.CustomPricesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<CustomPricesPut200Response>("/custom-prices", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CustomPricesPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Get200Response</returns>
        public Get200Response Get(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<Get200Response> localVarResponse = GetWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Get200Response</returns>
        public ApiResponse<Get200Response> GetWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ReferenceBooksApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<Get200Response>("/reference/shipZonesEnabled", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Get", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Get200Response</returns>
        public async System.Threading.Tasks.Task<Get200Response> GetAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Get200Response> localVarResponse = await GetWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Get200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Get200Response>> GetWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ReferenceBooksApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<Get200Response>("/reference/shipZonesEnabled", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Get", localVarResponse);
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
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        public MeAddressesIdDelete200Response ProductSuppliersPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = ProductSuppliersPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        public ApiResponse<MeAddressesIdDelete200Response> ProductSuppliersPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productSuppliersPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<MeAddressesIdDelete200Response>("/product-suppliers", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersPost", localVarResponse);
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
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        public async System.Threading.Tasks.Task<MeAddressesIdDelete200Response> ProductSuppliersPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = await ProductSuppliersPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> ProductSuppliersPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPostRequest? productSuppliersPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productSuppliersPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<MeAddressesIdDelete200Response>("/product-suppliers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersPost", localVarResponse);
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
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductSuppliersProductidGet200Response</returns>
        public ProductSuppliersProductidGet200Response ProductSuppliersProductidGet(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ProductSuppliersProductidGet200Response> localVarResponse = ProductSuppliersProductidGetWithHttpInfo(productID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductSuppliersProductidGet200Response</returns>
        public ApiResponse<ProductSuppliersProductidGet200Response> ProductSuppliersProductidGetWithHttpInfo(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ReferenceBooksApi->ProductSuppliersProductidGet");
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

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersProductidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ProductSuppliersProductidGet200Response>("/product-suppliers", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersProductidGet", localVarResponse);
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
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ProductSuppliersProductidGet200Response</returns>
        public async System.Threading.Tasks.Task<ProductSuppliersProductidGet200Response> ProductSuppliersProductidGetAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ProductSuppliersProductidGet200Response> localVarResponse = await ProductSuppliersProductidGetWithHttpInfoAsync(productID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Return product suppliers of a particular Product</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ProductSuppliersProductidGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductSuppliersProductidGet200Response>> ProductSuppliersProductidGetWithHttpInfoAsync(string productID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ReferenceBooksApi->ProductSuppliersProductidGet");
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

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersProductidGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ProductSuppliersProductidGet200Response>("/product-suppliers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersProductidGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void ProductSuppliersProductidSupplieridDelete(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ProductSuppliersProductidSupplieridDeleteWithHttpInfo(productID, supplierID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// DELETE + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<object> ProductSuppliersProductidSupplieridDeleteWithHttpInfo(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ReferenceBooksApi->ProductSuppliersProductidSupplieridDelete");
            }

            // verify the required parameter 'supplierID' is set
            if (supplierID == null)
            {
                throw new ApiException(400, "Missing required parameter 'supplierID' when calling ReferenceBooksApi->ProductSuppliersProductidSupplieridDelete");
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
            localVarRequestOptions.QueryParameters.Add("SupplierID", ClientUtils.ParameterToString(supplierID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersProductidSupplieridDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<object>("/product-suppliers", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersProductidSupplieridDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// DELETE + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProductSuppliersProductidSupplieridDeleteAsync(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await ProductSuppliersProductidSupplieridDeleteWithHttpInfoAsync(productID, supplierID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// DELETE + Method will delete specified Product Supplier settings with their Options and Intervals.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="productID">Identifier of the Product</param>
        /// <param name="supplierID">Identifier of a Supplier</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<object>> ProductSuppliersProductidSupplieridDeleteWithHttpInfoAsync(string productID, string supplierID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'productID' is set
            if (productID == null)
            {
                throw new ApiException(400, "Missing required parameter 'productID' when calling ReferenceBooksApi->ProductSuppliersProductidSupplieridDelete");
            }

            // verify the required parameter 'supplierID' is set
            if (supplierID == null)
            {
                throw new ApiException(400, "Missing required parameter 'supplierID' when calling ReferenceBooksApi->ProductSuppliersProductidSupplieridDelete");
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
            localVarRequestOptions.QueryParameters.Add("SupplierID", ClientUtils.ParameterToString(supplierID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersProductidSupplieridDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<object>("/product-suppliers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersProductidSupplieridDelete", localVarResponse);
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
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        public MeAddressesIdDelete200Response ProductSuppliersPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = ProductSuppliersPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        public ApiResponse<MeAddressesIdDelete200Response> ProductSuppliersPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = productSuppliersPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<MeAddressesIdDelete200Response>("/product-suppliers", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersPut", localVarResponse);
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
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        public async System.Threading.Tasks.Task<MeAddressesIdDelete200Response> ProductSuppliersPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = await ProductSuppliersPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, productSuppliersPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="productSuppliersPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> ProductSuppliersPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ProductSuppliersPutRequest? productSuppliersPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = productSuppliersPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ProductSuppliersPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<MeAddressesIdDelete200Response>("/product-suppliers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ProductSuppliersPut", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDealsIdPgLmtSrchGet200Response</returns>
        public ReferenceDealsIdPgLmtSrchGet200Response ReferenceDealsIdPgLmtSrchGet(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceDealsIdPgLmtSrchGet200Response> localVarResponse = ReferenceDealsIdPgLmtSrchGetWithHttpInfo(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDealsIdPgLmtSrchGet200Response</returns>
        public ApiResponse<ReferenceDealsIdPgLmtSrchGet200Response> ReferenceDealsIdPgLmtSrchGetWithHttpInfo(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ReferenceBooksApi->ReferenceDealsIdPgLmtSrchGet");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ReferenceBooksApi->ReferenceDealsIdPgLmtSrchGet");
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
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDealsIdPgLmtSrchGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ReferenceDealsIdPgLmtSrchGet200Response>("/reference/deals", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDealsIdPgLmtSrchGet", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDealsIdPgLmtSrchGet200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceDealsIdPgLmtSrchGet200Response> ReferenceDealsIdPgLmtSrchGetAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceDealsIdPgLmtSrchGet200Response> localVarResponse = await ReferenceDealsIdPgLmtSrchGetWithHttpInfoAsync(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Product Deal</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Product Deal that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDealsIdPgLmtSrchGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceDealsIdPgLmtSrchGet200Response>> ReferenceDealsIdPgLmtSrchGetWithHttpInfoAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ReferenceBooksApi->ReferenceDealsIdPgLmtSrchGet");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ReferenceBooksApi->ReferenceDealsIdPgLmtSrchGet");
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
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDealsIdPgLmtSrchGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ReferenceDealsIdPgLmtSrchGet200Response>("/reference/deals", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDealsIdPgLmtSrchGet", localVarResponse);
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
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDealsPost200Response</returns>
        public ReferenceDealsPost200Response ReferenceDealsPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceDealsPost200Response> localVarResponse = ReferenceDealsPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDealsPost200Response</returns>
        public ApiResponse<ReferenceDealsPost200Response> ReferenceDealsPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = referenceDealsPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDealsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ReferenceDealsPost200Response>("/reference/deals", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDealsPost", localVarResponse);
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
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDealsPost200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceDealsPost200Response> ReferenceDealsPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceDealsPost200Response> localVarResponse = await ReferenceDealsPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDealsPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceDealsPost200Response>> ReferenceDealsPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPostRequest? referenceDealsPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = referenceDealsPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDealsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ReferenceDealsPost200Response>("/reference/deals", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDealsPost", localVarResponse);
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
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDealsPut200Response</returns>
        public ReferenceDealsPut200Response ReferenceDealsPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceDealsPut200Response> localVarResponse = ReferenceDealsPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDealsPut200Response</returns>
        public ApiResponse<ReferenceDealsPut200Response> ReferenceDealsPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = referenceDealsPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDealsPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ReferenceDealsPut200Response>("/reference/deals", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDealsPut", localVarResponse);
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
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDealsPut200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceDealsPut200Response> ReferenceDealsPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceDealsPut200Response> localVarResponse = await ReferenceDealsPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, referenceDealsPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDealsPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDealsPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceDealsPut200Response>> ReferenceDealsPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDealsPutRequest? referenceDealsPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = referenceDealsPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDealsPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ReferenceDealsPut200Response>("/reference/deals", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDealsPut", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDiscountIdPgLmtSrchGet200Response</returns>
        public ReferenceDiscountIdPgLmtSrchGet200Response ReferenceDiscountIdPgLmtSrchGet(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceDiscountIdPgLmtSrchGet200Response> localVarResponse = ReferenceDiscountIdPgLmtSrchGetWithHttpInfo(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDiscountIdPgLmtSrchGet200Response</returns>
        public ApiResponse<ReferenceDiscountIdPgLmtSrchGet200Response> ReferenceDiscountIdPgLmtSrchGetWithHttpInfo(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ReferenceBooksApi->ReferenceDiscountIdPgLmtSrchGet");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ReferenceBooksApi->ReferenceDiscountIdPgLmtSrchGet");
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
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDiscountIdPgLmtSrchGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ReferenceDiscountIdPgLmtSrchGet200Response>("/reference/discount", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDiscountIdPgLmtSrchGet", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDiscountIdPgLmtSrchGet200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceDiscountIdPgLmtSrchGet200Response> ReferenceDiscountIdPgLmtSrchGetAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceDiscountIdPgLmtSrchGet200Response> localVarResponse = await ReferenceDiscountIdPgLmtSrchGetWithHttpInfoAsync(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Discount Rule</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Discount Rules that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDiscountIdPgLmtSrchGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceDiscountIdPgLmtSrchGet200Response>> ReferenceDiscountIdPgLmtSrchGetWithHttpInfoAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ReferenceBooksApi->ReferenceDiscountIdPgLmtSrchGet");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ReferenceBooksApi->ReferenceDiscountIdPgLmtSrchGet");
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
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDiscountIdPgLmtSrchGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ReferenceDiscountIdPgLmtSrchGet200Response>("/reference/discount", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDiscountIdPgLmtSrchGet", localVarResponse);
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
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDiscountPost200Response</returns>
        public ReferenceDiscountPost200Response ReferenceDiscountPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceDiscountPost200Response> localVarResponse = ReferenceDiscountPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDiscountPost200Response</returns>
        public ApiResponse<ReferenceDiscountPost200Response> ReferenceDiscountPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = referenceDiscountPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDiscountPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ReferenceDiscountPost200Response>("/reference/discount", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDiscountPost", localVarResponse);
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
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDiscountPost200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceDiscountPost200Response> ReferenceDiscountPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceDiscountPost200Response> localVarResponse = await ReferenceDiscountPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDiscountPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceDiscountPost200Response>> ReferenceDiscountPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPostRequest? referenceDiscountPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = referenceDiscountPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDiscountPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ReferenceDiscountPost200Response>("/reference/discount", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDiscountPost", localVarResponse);
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
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceDiscountPut200Response</returns>
        public ReferenceDiscountPut200Response ReferenceDiscountPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceDiscountPut200Response> localVarResponse = ReferenceDiscountPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceDiscountPut200Response</returns>
        public ApiResponse<ReferenceDiscountPut200Response> ReferenceDiscountPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = referenceDiscountPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDiscountPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ReferenceDiscountPut200Response>("/reference/discount", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDiscountPut", localVarResponse);
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
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceDiscountPut200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceDiscountPut200Response> ReferenceDiscountPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceDiscountPut200Response> localVarResponse = await ReferenceDiscountPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, referenceDiscountPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceDiscountPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceDiscountPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceDiscountPut200Response>> ReferenceDiscountPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceDiscountPutRequest? referenceDiscountPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = referenceDiscountPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceDiscountPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ReferenceDiscountPut200Response>("/reference/discount", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceDiscountPut", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceShipzonesIdPgLmtSrchGet200Response</returns>
        public ReferenceShipzonesIdPgLmtSrchGet200Response ReferenceShipzonesIdPgLmtSrchGet(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceShipzonesIdPgLmtSrchGet200Response> localVarResponse = ReferenceShipzonesIdPgLmtSrchGetWithHttpInfo(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceShipzonesIdPgLmtSrchGet200Response</returns>
        public ApiResponse<ReferenceShipzonesIdPgLmtSrchGet200Response> ReferenceShipzonesIdPgLmtSrchGetWithHttpInfo(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ReferenceBooksApi->ReferenceShipzonesIdPgLmtSrchGet");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ReferenceBooksApi->ReferenceShipzonesIdPgLmtSrchGet");
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
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesIdPgLmtSrchGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<ReferenceShipzonesIdPgLmtSrchGet200Response>("/reference/shipZones", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesIdPgLmtSrchGet", localVarResponse);
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
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceShipzonesIdPgLmtSrchGet200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceShipzonesIdPgLmtSrchGet200Response> ReferenceShipzonesIdPgLmtSrchGetAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceShipzonesIdPgLmtSrchGet200Response> localVarResponse = await ReferenceShipzonesIdPgLmtSrchGetWithHttpInfoAsync(ID, page, limit, search, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ID">Returns detailed info of a particular Shipping zone</param>
        /// <param name="page">Page (Default: 1)</param>
        /// <param name="limit">Specifies the page size for pagination. Default page size is 25 (Default: 25)</param>
        /// <param name="search">Only return Shiping Zones that have the provided text in Name (Default: not set)</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceShipzonesIdPgLmtSrchGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceShipzonesIdPgLmtSrchGet200Response>> ReferenceShipzonesIdPgLmtSrchGetWithHttpInfoAsync(string ID, decimal page, decimal limit, string search, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'ID' is set
            if (ID == null)
            {
                throw new ApiException(400, "Missing required parameter 'ID' when calling ReferenceBooksApi->ReferenceShipzonesIdPgLmtSrchGet");
            }

            // verify the required parameter 'search' is set
            if (search == null)
            {
                throw new ApiException(400, "Missing required parameter 'search' when calling ReferenceBooksApi->ReferenceShipzonesIdPgLmtSrchGet");
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
            localVarRequestOptions.QueryParameters.Add("Page", ClientUtils.ParameterToString(page)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Limit", ClientUtils.ParameterToString(limit)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Search", ClientUtils.ParameterToString(search)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesIdPgLmtSrchGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<ReferenceShipzonesIdPgLmtSrchGet200Response>("/reference/shipZones", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesIdPgLmtSrchGet", localVarResponse);
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
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceShipzonesPost200Response</returns>
        public ReferenceShipzonesPost200Response ReferenceShipzonesPost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceShipzonesPost200Response> localVarResponse = ReferenceShipzonesPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceShipzonesPost200Response</returns>
        public ApiResponse<ReferenceShipzonesPost200Response> ReferenceShipzonesPostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = referenceShipzonesPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<ReferenceShipzonesPost200Response>("/reference/shipZones", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesPost", localVarResponse);
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
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceShipzonesPost200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceShipzonesPost200Response> ReferenceShipzonesPostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceShipzonesPost200Response> localVarResponse = await ReferenceShipzonesPostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceShipzonesPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceShipzonesPost200Response>> ReferenceShipzonesPostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPostRequest? referenceShipzonesPostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = referenceShipzonesPostRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<ReferenceShipzonesPost200Response>("/reference/shipZones", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesPost", localVarResponse);
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
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReferenceShipzonesPut200Response</returns>
        public ReferenceShipzonesPut200Response ReferenceShipzonesPut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0)
        {
            ApiResponse<ReferenceShipzonesPut200Response> localVarResponse = ReferenceShipzonesPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReferenceShipzonesPut200Response</returns>
        public ApiResponse<ReferenceShipzonesPut200Response> ReferenceShipzonesPutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = referenceShipzonesPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<ReferenceShipzonesPut200Response>("/reference/shipZones", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesPut", localVarResponse);
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
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReferenceShipzonesPut200Response</returns>
        public async System.Threading.Tasks.Task<ReferenceShipzonesPut200Response> ReferenceShipzonesPutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ReferenceShipzonesPut200Response> localVarResponse = await ReferenceShipzonesPutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, referenceShipzonesPutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="referenceShipzonesPutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReferenceShipzonesPut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceShipzonesPut200Response>> ReferenceShipzonesPutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, ReferenceShipzonesPutRequest? referenceShipzonesPutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = referenceShipzonesPutRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<ReferenceShipzonesPut200Response>("/reference/shipZones", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesPut", localVarResponse);
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
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MeAddressesIdDelete200Response</returns>
        public MeAddressesIdDelete200Response ReferenceShipzonesShipzoneidDelete(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = ReferenceShipzonesShipzoneidDeleteWithHttpInfo(shipZoneID, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MeAddressesIdDelete200Response</returns>
        public ApiResponse<MeAddressesIdDelete200Response> ReferenceShipzonesShipzoneidDeleteWithHttpInfo(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'shipZoneID' is set
            if (shipZoneID == null)
            {
                throw new ApiException(400, "Missing required parameter 'shipZoneID' when calling ReferenceBooksApi->ReferenceShipzonesShipzoneidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ShipZoneID", ClientUtils.ParameterToString(shipZoneID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesShipzoneidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Delete<MeAddressesIdDelete200Response>("/reference/shipZones", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesShipzoneidDelete", localVarResponse);
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
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MeAddressesIdDelete200Response</returns>
        public async System.Threading.Tasks.Task<MeAddressesIdDelete200Response> ReferenceShipzonesShipzoneidDeleteAsync(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<MeAddressesIdDelete200Response> localVarResponse = await ReferenceShipzonesShipzoneidDeleteWithHttpInfoAsync(shipZoneID, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipZoneID">ID of Ship Zone to delete</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MeAddressesIdDelete200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeAddressesIdDelete200Response>> ReferenceShipzonesShipzoneidDeleteWithHttpInfoAsync(string shipZoneID, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'shipZoneID' is set
            if (shipZoneID == null)
            {
                throw new ApiException(400, "Missing required parameter 'shipZoneID' when calling ReferenceBooksApi->ReferenceShipzonesShipzoneidDelete");
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

            localVarRequestOptions.QueryParameters.Add("ShipZoneID", ClientUtils.ParameterToString(shipZoneID)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "ReferenceBooksApi.ReferenceShipzonesShipzoneidDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<MeAddressesIdDelete200Response>("/reference/shipZones", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ReferenceShipzonesShipzoneidDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UpdateRequest</returns>
        public UpdateRequest Update(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0)
        {
            ApiResponse<UpdateRequest> localVarResponse = UpdateWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, updateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UpdateRequest</returns>
        public ApiResponse<UpdateRequest> UpdateWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = updateRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.Update";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<UpdateRequest>("/reference/shipZonesEnabled", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Update", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UpdateRequest</returns>
        public async System.Threading.Tasks.Task<UpdateRequest> UpdateAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<UpdateRequest> localVarResponse = await UpdateWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, updateRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="updateRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UpdateRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateRequest>> UpdateWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, UpdateRequest? updateRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = updateRequest;

            localVarRequestOptions.Operation = "ReferenceBooksApi.Update";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<UpdateRequest>("/reference/shipZonesEnabled", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("Update", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
    }
}