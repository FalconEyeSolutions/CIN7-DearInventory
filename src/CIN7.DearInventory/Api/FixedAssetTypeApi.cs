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
    public interface IFixedAssetTypeApiSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RefFixedassettypePgLmtIdNameGet200Response</returns>
        RefFixedassettypePgLmtIdNameGet200Response RefFixedassettypePgLmtIdNameGet(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RefFixedassettypePgLmtIdNameGet200Response</returns>
        ApiResponse<RefFixedassettypePgLmtIdNameGet200Response> RefFixedassettypePgLmtIdNameGetWithHttpInfo(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RefFixedassettypePost200Response</returns>
        RefFixedassettypePost200Response RefFixedassettypePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RefFixedassettypePost200Response</returns>
        ApiResponse<RefFixedassettypePost200Response> RefFixedassettypePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RefFixedassettypePut200Response</returns>
        RefFixedassettypePut200Response RefFixedassettypePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RefFixedassettypePut200Response</returns>
        ApiResponse<RefFixedassettypePut200Response> RefFixedassettypePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFixedAssetTypeApiAsync : IApiAccessor
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
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefFixedassettypePgLmtIdNameGet200Response</returns>
        System.Threading.Tasks.Task<RefFixedassettypePgLmtIdNameGet200Response> RefFixedassettypePgLmtIdNameGetAsync(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GET
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefFixedassettypePgLmtIdNameGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RefFixedassettypePgLmtIdNameGet200Response>> RefFixedassettypePgLmtIdNameGetWithHttpInfoAsync(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefFixedassettypePost200Response</returns>
        System.Threading.Tasks.Task<RefFixedassettypePost200Response> RefFixedassettypePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// POST
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefFixedassettypePost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RefFixedassettypePost200Response>> RefFixedassettypePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefFixedassettypePut200Response</returns>
        System.Threading.Tasks.Task<RefFixedassettypePut200Response> RefFixedassettypePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// PUT
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefFixedassettypePut200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RefFixedassettypePut200Response>> RefFixedassettypePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFixedAssetTypeApi : IFixedAssetTypeApiSync, IFixedAssetTypeApiAsync
    {
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FixedAssetTypeApi : IFixedAssetTypeApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedAssetTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FixedAssetTypeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedAssetTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FixedAssetTypeApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FixedAssetTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FixedAssetTypeApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FixedAssetTypeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FixedAssetTypeApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RefFixedassettypePgLmtIdNameGet200Response</returns>
        public RefFixedassettypePgLmtIdNameGet200Response RefFixedassettypePgLmtIdNameGet(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            ApiResponse<RefFixedassettypePgLmtIdNameGet200Response> localVarResponse = RefFixedassettypePgLmtIdNameGetWithHttpInfo(page, limit, fixedAssetTypeID, name, apiAuthAccountid, apiAuthApplicationkey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RefFixedassettypePgLmtIdNameGet200Response</returns>
        public ApiResponse<RefFixedassettypePgLmtIdNameGet200Response> RefFixedassettypePgLmtIdNameGetWithHttpInfo(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0)
        {
            // verify the required parameter 'fixedAssetTypeID' is set
            if (fixedAssetTypeID == null)
            {
                throw new ApiException(400, "Missing required parameter 'fixedAssetTypeID' when calling FixedAssetTypeApi->RefFixedassettypePgLmtIdNameGet");
            }

            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling FixedAssetTypeApi->RefFixedassettypePgLmtIdNameGet");
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
            localVarRequestOptions.QueryParameters.Add("FixedAssetTypeID", ClientUtils.ParameterToString(fixedAssetTypeID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "FixedAssetTypeApi.RefFixedassettypePgLmtIdNameGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Get<RefFixedassettypePgLmtIdNameGet200Response>("/ref/fixedassettype", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("RefFixedassettypePgLmtIdNameGet", localVarResponse);
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
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefFixedassettypePgLmtIdNameGet200Response</returns>
        public async System.Threading.Tasks.Task<RefFixedassettypePgLmtIdNameGet200Response> RefFixedassettypePgLmtIdNameGetAsync(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<RefFixedassettypePgLmtIdNameGet200Response> localVarResponse = await RefFixedassettypePgLmtIdNameGetWithHttpInfoAsync(page, limit, fixedAssetTypeID, name, apiAuthAccountid, apiAuthApplicationkey, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fixedAssetTypeID">Only return Fixed Asset Type with the specific ID</param>
        /// <param name="name">Only return accounts that start with the specific name</param>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefFixedassettypePgLmtIdNameGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RefFixedassettypePgLmtIdNameGet200Response>> RefFixedassettypePgLmtIdNameGetWithHttpInfoAsync(decimal page, decimal limit, string fixedAssetTypeID, string name, string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'fixedAssetTypeID' is set
            if (fixedAssetTypeID == null)
            {
                throw new ApiException(400, "Missing required parameter 'fixedAssetTypeID' when calling FixedAssetTypeApi->RefFixedassettypePgLmtIdNameGet");
            }

            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling FixedAssetTypeApi->RefFixedassettypePgLmtIdNameGet");
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
            localVarRequestOptions.QueryParameters.Add("FixedAssetTypeID", ClientUtils.ParameterToString(fixedAssetTypeID)); // path parameter
            localVarRequestOptions.QueryParameters.Add("Name", ClientUtils.ParameterToString(name)); // path parameter
            if (apiAuthAccountid != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-accountid", ClientUtils.ParameterToString(apiAuthAccountid)); // header parameter
            }
            if (apiAuthApplicationkey != null)
            {
                localVarRequestOptions.HeaderParameters.Add("api-auth-applicationkey", ClientUtils.ParameterToString(apiAuthApplicationkey)); // header parameter
            }

            localVarRequestOptions.Operation = "FixedAssetTypeApi.RefFixedassettypePgLmtIdNameGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<RefFixedassettypePgLmtIdNameGet200Response>("/ref/fixedassettype", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("RefFixedassettypePgLmtIdNameGet", localVarResponse);
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
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RefFixedassettypePost200Response</returns>
        public RefFixedassettypePost200Response RefFixedassettypePost(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0)
        {
            ApiResponse<RefFixedassettypePost200Response> localVarResponse = RefFixedassettypePostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePostRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RefFixedassettypePost200Response</returns>
        public ApiResponse<RefFixedassettypePost200Response> RefFixedassettypePostWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = refFixedassettypePostRequest;

            localVarRequestOptions.Operation = "FixedAssetTypeApi.RefFixedassettypePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Post<RefFixedassettypePost200Response>("/ref/fixedassettype", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("RefFixedassettypePost", localVarResponse);
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
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefFixedassettypePost200Response</returns>
        public async System.Threading.Tasks.Task<RefFixedassettypePost200Response> RefFixedassettypePostAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<RefFixedassettypePost200Response> localVarResponse = await RefFixedassettypePostWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePostRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// POST
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePostRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefFixedassettypePost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RefFixedassettypePost200Response>> RefFixedassettypePostWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePostRequest? refFixedassettypePostRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = refFixedassettypePostRequest;

            localVarRequestOptions.Operation = "FixedAssetTypeApi.RefFixedassettypePost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<RefFixedassettypePost200Response>("/ref/fixedassettype", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("RefFixedassettypePost", localVarResponse);
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
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RefFixedassettypePut200Response</returns>
        public RefFixedassettypePut200Response RefFixedassettypePut(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0)
        {
            ApiResponse<RefFixedassettypePut200Response> localVarResponse = RefFixedassettypePutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePutRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RefFixedassettypePut200Response</returns>
        public ApiResponse<RefFixedassettypePut200Response> RefFixedassettypePutWithHttpInfo(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0)
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
            localVarRequestOptions.Data = refFixedassettypePutRequest;

            localVarRequestOptions.Operation = "FixedAssetTypeApi.RefFixedassettypePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = Client.Put<RefFixedassettypePut200Response>("/ref/fixedassettype", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("RefFixedassettypePut", localVarResponse);
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
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RefFixedassettypePut200Response</returns>
        public async System.Threading.Tasks.Task<RefFixedassettypePut200Response> RefFixedassettypePutAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<RefFixedassettypePut200Response> localVarResponse = await RefFixedassettypePutWithHttpInfoAsync(apiAuthAccountid, apiAuthApplicationkey, refFixedassettypePutRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// PUT
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiAuthAccountid">e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional)</param>
        /// <param name="apiAuthApplicationkey">e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional)</param>
        /// <param name="refFixedassettypePutRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RefFixedassettypePut200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RefFixedassettypePut200Response>> RefFixedassettypePutWithHttpInfoAsync(string? apiAuthAccountid = default, string? apiAuthApplicationkey = default, RefFixedassettypePutRequest? refFixedassettypePutRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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
            localVarRequestOptions.Data = refFixedassettypePutRequest;

            localVarRequestOptions.Operation = "FixedAssetTypeApi.RefFixedassettypePut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<RefFixedassettypePut200Response>("/ref/fixedassettype", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("RefFixedassettypePut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
    }
}