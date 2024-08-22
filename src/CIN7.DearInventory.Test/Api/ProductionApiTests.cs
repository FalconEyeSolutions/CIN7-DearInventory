/*
 * Cin7 Core Developer Portal
 *
 * ## API introduction  Cin7 Core Inventory API is part of Cin7 Core Inventory web application at https://inventory.dearsystems.com.  <b>You will need to:</b>  + Create an account there before you can use the API.  + Trial accounts are also allowed to access the API.  The API URL is https://inventory.dearsystems.com/externalapi/v2/. To call any API endpoint (method) you must append the endpoint name and parameters to the API URL. eg: https://inventory.dearsystems.com/externalapi/v2/me  <i>Note: The API accepts only JSON data format.</i>  Never assume that the API is actually online at any time. Always queue requests to the API so that you can retry the request in the event of a network failure: even if our server is up 24/7 forever, the network will not be. Consider what happens in the case of a network interruption, eg the cable gets cut by road workers yet again. You should always plan to add all requests to a queue so that they can be tried again in the event of any failure.  Full documentation of each endpoint is available on that endpoint's help page. This includes the operations supported and the full list of available fields with:  + Name  + Type  + Length  + Required values  Use our API Explorer to see examples of each data object.  Cin7 Core Inventory API is a subset of the functionality available through Cin7 Core Inventory UI - check the API documentation to see if the functionality you require is available in the API.  In the event of errors, the API will return an appropriate HTML status code, and an error message. You will need to read both the status code and the error message to establish the cause. Typical error messages are shown on the API status codes page.  ## Connecting to the API  To use the API you will need your Cin7 Core Account ID and API Application key. These can be created on the API setup page inside Cin7 Core Inventory application: https://inventory.dearsystems.com/ExternalAPI.  Each company that you have access to in Cin7 Core Inventory will have a different Cin7 Core Account ID. You can have multiple API Applications created on the same Cin7 Core account. This allows you to link different applications/add-ons to Cin7 Core, since API limits are applied on per API Application basis.  Your Account ID and API Application Key are equivalent to a login and password. They must be kept secret and not shared in any way.  Each request to the API must include these two values sent as HTTP headers:  + api-auth-accountid - You must send your Account ID in this header.  + api-auth-applicationkey - You must send API Application Key in this header.  PHP sample:  ```PHP  $account_id = 'api-auth-accountid: youraccountid'; $application_key = 'api-auth-applicationkey: applicationkey'; $naked_dear_url = 'https://inventory.dearsystems.com/ExternalApi/v2/SaleList';  $data = array ('Page' => '1', 'Limit' => '100'); $data = http_build_query($data);  $ch = curl_init(); curl_setopt($ch, CURLOPT_URL,$naked_dear_url.\"?\".$data); //GET API CALL curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);  $headers = [ \"Content-type: application/json\", $account_id, $application_key ];  curl_setopt($ch, CURLOPT_HTTPHEADER, $headers); $server_output = curl_exec ($ch); curl_close ($ch);  print $server_output ;   ```  ## Pagination  <h4>What is Pagination?</h4>  Pagination is the process of dividing content into discrete pages.  The benefit of pagination is that it allows for faster response times to requests against large datasets like Customers, Products and Invoices, thus providing a more responsive and flexible API for your mission-critical applications.  Cin7 Core Inventory API currently uses pagination on the following endpoints:  + SaleList  + PurchaseList  + StockAdjustmentList  + StockTakeList  + StockTransferList  + Product  + Сategory  All remaining API endpoints do not support pagination.  <h4>Requesting a page</h4>  Pages are requested by adding page parameter to URL: https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}, where {endpoint} and {pagenumber} are placeholders.  For example, if you wanted to retrieve the 3rd page of 100 records from the Products endpoint we would write https://inventory.dearsystems.com/ExternalApi/v2/Product?page=3.  <h4>Page size</h4>  The default page size is 100 records, but is configurable by adding the desired page size in the URL querystring, https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}&limit={pagesize}.  The minimum page size is 1 and the maximum page size is 1000 records.  If you want to retrieve the 5th page of 200 ProductAvailability records (ie. 1001st to 1500th record) then you would use this URL: https://inventory.dearsystems.com/ExternalApi/v2/Product?page=5&limit=200.  <h4>Pagination info</h4>  In the endpoints that support Pagination additional parameter Total is returned with every API call response to provide information regarding how many records there are overall. Below is an example of this structure in JSON for Products endpoint.  { \"Products\":[{...}], \"Total\":41}  ## API Status Codes  |Status Code|Description| |:- -- --|- -- -- -- -- --| |`200 OK`|Operation was successful| |`204 No Content`|Operation was successful and there is no content to return| |`400 Bad Request`|The request was not in a correct form, or the posted data failed a validation test. Check the error returned to see what was wrong with the request.| |`403 Forbidden`|Method authentication failed| |`404 Not found`|Endpoint does not exist (eg using /Products instead of /Product)| |`405 Not allowed`|The method used is not allowed (eg PUT, DELETE)| |`500 Internal Server Error`|The object passed to the API could not be parsed or some unexpected error occurred in Cin7 Core while processing API request| |`503 Service Unavailable`|You reached 60 calls per minute API limit|  ## Date Format  All date fields in Cin7 Core API (including parameters) are in ISO 8601 format and specifying UTC date: yyyy-MM-ddTHH:mm:ss.fff     e.g. 2012-11-14T13:28:33.363  ## Previous API version  Previous API version's description is available here: http://support.dearsystems.com/solution/folders/1000134185
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using CIN7.DearInventory.Client;
using CIN7.DearInventory.Api;
// uncomment below to import models
//using CIN7.DearInventory.Model;

namespace CIN7.DearInventory.Test.Api
{
    /// <summary>
    ///  Class for testing ProductionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductionApiTests : IDisposable
    {
        private ProductionApi instance;

        public ProductionApiTests()
        {
            instance = new ProductionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductionApi
            //Assert.IsType<ProductionApi>(instance);
        }

        /// <summary>
        /// Test Authorize
        /// </summary>
        [Fact]
        public void AuthorizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //AuthorizeRequest? authorizeRequest = null;
            //var response = instance.Authorize(apiAuthAccountid, apiAuthApplicationkey, authorizeRequest);
            //Assert.IsType<Authorize200Response>(response);
        }

        /// <summary>
        /// Test CallVoid
        /// </summary>
        [Fact]
        public void CallVoidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //UndoRequest? undoRequest = null;
            //var response = instance.CallVoid(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
            //Assert.IsType<Undo200Response>(response);
        }

        /// <summary>
        /// Test CompleteRun
        /// </summary>
        [Fact]
        public void CompleteRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CompleteRunRequest? completeRunRequest = null;
            //var response = instance.CompleteRun(apiAuthAccountid, apiAuthApplicationkey, completeRunRequest);
            //Assert.IsType<CompleteRun200Response>(response);
        }

        /// <summary>
        /// Test CompleteRunOperation
        /// </summary>
        [Fact]
        public void CompleteRunOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.CompleteRunOperation(apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<CompleteRunOperation200Response>(response);
        }

        /// <summary>
        /// Test DeleteAttachment
        /// </summary>
        [Fact]
        public void DeleteAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productionOrderAttachmentID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.DeleteAttachment(productionOrderAttachmentID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test GetProductionOrderAttachments
        /// </summary>
        [Fact]
        public void GetProductionOrderAttachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productionOrderID = null;
            //bool returnAttachmentsContent = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.GetProductionOrderAttachments(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<GetProductionOrderAttachments200Response>(response);
        }

        /// <summary>
        /// Test GetProductionOrderReferenceData
        /// </summary>
        [Fact]
        public void GetProductionOrderReferenceDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.GetProductionOrderReferenceData(apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<GetProductionOrderReferenceData200Response>(response);
        }

        /// <summary>
        /// Test OrderlistPgLmtStsSrchEtc
        /// </summary>
        [Fact]
        public void OrderlistPgLmtStsSrchEtcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string status = null;
            //string search = null;
            //string locationID = null;
            //string requiredByDateFrom = null;
            //string requiredByDateTo = null;
            //string completionDateFrom = null;
            //string completionDateTo = null;
            //string sourceTaskID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.OrderlistPgLmtStsSrchEtc(page, limit, status, search, locationID, requiredByDateFrom, requiredByDateTo, completionDateFrom, completionDateTo, sourceTaskID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test PostAttachment
        /// </summary>
        [Fact]
        public void PostAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productionOrderID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //PostAttachmentRequest? postAttachmentRequest = null;
            //var response = instance.PostAttachment(productionOrderID, apiAuthAccountid, apiAuthApplicationkey, postAttachmentRequest);
            //Assert.IsType<PutAttachment200Response>(response);
        }

        /// <summary>
        /// Test ProductionFactorycalendarPost
        /// </summary>
        [Fact]
        public void ProductionFactorycalendarPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = null;
            //var response = instance.ProductionFactorycalendarPost(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
            //Assert.IsType<ProductionFactorycalendarPutRequest>(response);
        }

        /// <summary>
        /// Test ProductionFactorycalendarPut
        /// </summary>
        [Fact]
        public void ProductionFactorycalendarPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionFactorycalendarPutRequest? productionFactorycalendarPutRequest = null;
            //var response = instance.ProductionFactorycalendarPut(apiAuthAccountid, apiAuthApplicationkey, productionFactorycalendarPutRequest);
            //Assert.IsType<ProductionFactorycalendarPutRequest>(response);
        }

        /// <summary>
        /// Test ProductionFactorycalendarYearGet
        /// </summary>
        [Fact]
        public void ProductionFactorycalendarYearGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string year = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.ProductionFactorycalendarYearGet(year, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<ProductionFactorycalendarPutRequest>(response);
        }

        /// <summary>
        /// Test ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut
        /// </summary>
        [Fact]
        public void ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool allowRecalculateDates = null;
            //bool allowRecalculateCyclesAndQuantities = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest? productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest = null;
            //var response = instance.ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut(allowRecalculateDates, allowRecalculateCyclesAndQuantities, apiAuthAccountid, apiAuthApplicationkey, productionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPutRequest);
            //Assert.IsType<ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200Response>(response);
        }

        /// <summary>
        /// Test ProductionOrderProductionorderidReturnattachmentscontentGet
        /// </summary>
        [Fact]
        public void ProductionOrderProductionorderidReturnattachmentscontentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productionOrderID = null;
            //bool returnAttachmentsContent = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.ProductionOrderProductionorderidReturnattachmentscontentGet(productionOrderID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<ProductionOrderProductionorderidReturnattachmentscontentGet200Response>(response);
        }

        /// <summary>
        /// Test ProductionOrderRecalculatedatesPost
        /// </summary>
        [Fact]
        public void ProductionOrderRecalculatedatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool recalculateDates = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionOrderRecalculatedatesPostRequest? productionOrderRecalculatedatesPostRequest = null;
            //var response = instance.ProductionOrderRecalculatedatesPost(recalculateDates, apiAuthAccountid, apiAuthApplicationkey, productionOrderRecalculatedatesPostRequest);
            //Assert.IsType<ProductionOrderRecalculatedatesPost200Response>(response);
        }

        /// <summary>
        /// Test ProductionOrderRunPost
        /// </summary>
        [Fact]
        public void ProductionOrderRunPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionOrderRunPostRequest? productionOrderRunPostRequest = null;
            //instance.ProductionOrderRunPost(apiAuthAccountid, apiAuthApplicationkey, productionOrderRunPostRequest);
        }

        /// <summary>
        /// Test ProductionOrderRunProductionorderidIncludeattachmentcontentGet
        /// </summary>
        [Fact]
        public void ProductionOrderRunProductionorderidIncludeattachmentcontentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productionOrderID = null;
            //bool includeAttachmentContent = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionOrderRunProductionorderidIncludeattachmentcontentGet(productionOrderID, includeAttachmentContent, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionOrderRunProductionorderidIncreaseorderquantityPut
        /// </summary>
        [Fact]
        public void ProductionOrderRunProductionorderidIncreaseorderquantityPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productionOrderID = null;
            //bool increaseOrderQuantity = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionOrderRunProductionorderidIncreaseorderquantityPut(productionOrderID, increaseOrderQuantity, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionProductionbomPost
        /// </summary>
        [Fact]
        public void ProductionProductionbomPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionProductionbomPostRequest? productionProductionbomPostRequest = null;
            //var response = instance.ProductionProductionbomPost(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPostRequest);
            //Assert.IsType<ProductionProductionbomPost200Response>(response);
        }

        /// <summary>
        /// Test ProductionProductionbomProductfamilyidBomidDelete
        /// </summary>
        [Fact]
        public void ProductionProductionbomProductfamilyidBomidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productFamilyID = null;
            //string BOMID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionProductionbomProductfamilyidBomidDelete(productFamilyID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionProductionbomProductfamilyidReturnattachmentscontentGet
        /// </summary>
        [Fact]
        public void ProductionProductionbomProductfamilyidReturnattachmentscontentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productFamilyID = null;
            //bool returnAttachmentsContent = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.ProductionProductionbomProductfamilyidReturnattachmentscontentGet(productFamilyID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<ProductionProductionbomProductfamilyidReturnattachmentscontentGet200Response>(response);
        }

        /// <summary>
        /// Test ProductionProductionbomProductidBomidDelete
        /// </summary>
        [Fact]
        public void ProductionProductionbomProductidBomidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productID = null;
            //string BOMID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionProductionbomProductidBomidDelete(productID, BOMID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionProductionbomProductidReturnattachmentscontentGet
        /// </summary>
        [Fact]
        public void ProductionProductionbomProductidReturnattachmentscontentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productID = null;
            //bool returnAttachmentsContent = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.ProductionProductionbomProductidReturnattachmentscontentGet(productID, returnAttachmentsContent, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<ProductionProductionbomProductidReturnattachmentscontentGet200Response>(response);
        }

        /// <summary>
        /// Test ProductionProductionbomPut
        /// </summary>
        [Fact]
        public void ProductionProductionbomPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionProductionbomPutRequest? productionProductionbomPutRequest = null;
            //var response = instance.ProductionProductionbomPut(apiAuthAccountid, apiAuthApplicationkey, productionProductionbomPutRequest);
            //Assert.IsType<ProductionProductionbomPut200Response>(response);
        }

        /// <summary>
        /// Test ProductionResourcePost
        /// </summary>
        [Fact]
        public void ProductionResourcePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionResourcePost(apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionResourcePut
        /// </summary>
        [Fact]
        public void ProductionResourcePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionResourcePutRequest? productionResourcePutRequest = null;
            //var response = instance.ProductionResourcePut(apiAuthAccountid, apiAuthApplicationkey, productionResourcePutRequest);
            //Assert.IsType<ProductionResourcePutRequest>(response);
        }

        /// <summary>
        /// Test ProductionResourceResourceidDelete
        /// </summary>
        [Fact]
        public void ProductionResourceResourceidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string resourceID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.ProductionResourceResourceidDelete(resourceID, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<ProductionResourcePutRequest>(response);
        }

        /// <summary>
        /// Test ProductionResourceResourceidIncludeattachmentsGet
        /// </summary>
        [Fact]
        public void ProductionResourceResourceidIncludeattachmentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string resourceID = null;
            //bool includeAttachments = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionResourceResourceidIncludeattachmentsGet(resourceID, includeAttachments, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionResourcelistPgLmtNameOnlyactiveGet
        /// </summary>
        [Fact]
        public void ProductionResourcelistPgLmtNameOnlyactiveGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string name = null;
            //bool onlyActive = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionResourcelistPgLmtNameOnlyactiveGet(page, limit, name, onlyActive, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionSuspendreasonPgLmtWorkcenteridGet
        /// </summary>
        [Fact]
        public void ProductionSuspendreasonPgLmtWorkcenteridGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string workcenterID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionSuspendreasonPgLmtWorkcenteridGet(page, limit, workcenterID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionSuspendreasonPut
        /// </summary>
        [Fact]
        public void ProductionSuspendreasonPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.ProductionSuspendreasonPut(apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<ProductionSuspendreasonPut200Response>(response);
        }

        /// <summary>
        /// Test ProductionWorkcentersPgLmtNameGet
        /// </summary>
        [Fact]
        public void ProductionWorkcentersPgLmtNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string name = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionWorkcentersPgLmtNameGet(page, limit, name, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test ProductionWorkcentersPost
        /// </summary>
        [Fact]
        public void ProductionWorkcentersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.ProductionWorkcentersPost(apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<ProductionWorkcentersPost200Response>(response);
        }

        /// <summary>
        /// Test ProductionWorkcentersPut
        /// </summary>
        [Fact]
        public void ProductionWorkcentersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ProductionWorkcentersPutRequest? productionWorkcentersPutRequest = null;
            //var response = instance.ProductionWorkcentersPut(apiAuthAccountid, apiAuthApplicationkey, productionWorkcentersPutRequest);
            //Assert.IsType<ProductionWorkcentersPut200Response>(response);
        }

        /// <summary>
        /// Test ProductionWorkcentersWorkcenteridDelete
        /// </summary>
        [Fact]
        public void ProductionWorkcentersWorkcenteridDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workCenterId = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.ProductionWorkcentersWorkcenteridDelete(workCenterId, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test PutAttachment
        /// </summary>
        [Fact]
        public void PutAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.PutAttachment(apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<PutAttachment200Response>(response);
        }

        /// <summary>
        /// Test Release
        /// </summary>
        [Fact]
        public void ReleaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ReleaseRequest? releaseRequest = null;
            //var response = instance.Release(apiAuthAccountid, apiAuthApplicationkey, releaseRequest);
            //Assert.IsType<Release200Response>(response);
        }

        /// <summary>
        /// Test ResumeRunOperation
        /// </summary>
        [Fact]
        public void ResumeRunOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //ResumeRunOperationRequest? resumeRunOperationRequest = null;
            //var response = instance.ResumeRunOperation(apiAuthAccountid, apiAuthApplicationkey, resumeRunOperationRequest);
            //Assert.IsType<ResumeRunOperation200Response>(response);
        }

        /// <summary>
        /// Test StartRunOperation
        /// </summary>
        [Fact]
        public void StartRunOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //StartRunOperationRequest? startRunOperationRequest = null;
            //var response = instance.StartRunOperation(apiAuthAccountid, apiAuthApplicationkey, startRunOperationRequest);
            //Assert.IsType<StartRunOperation200Response>(response);
        }

        /// <summary>
        /// Test SuspendRunOperation
        /// </summary>
        [Fact]
        public void SuspendRunOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //SuspendRunOperationRequest? suspendRunOperationRequest = null;
            //var response = instance.SuspendRunOperation(apiAuthAccountid, apiAuthApplicationkey, suspendRunOperationRequest);
            //Assert.IsType<SuspendRunOperation200Response>(response);
        }

        /// <summary>
        /// Test Undo
        /// </summary>
        [Fact]
        public void UndoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //UndoRequest? undoRequest = null;
            //var response = instance.Undo(apiAuthAccountid, apiAuthApplicationkey, undoRequest);
            //Assert.IsType<Undo200Response>(response);
        }

        /// <summary>
        /// Test UndoRun
        /// </summary>
        [Fact]
        public void UndoRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //UndoRunRequest? undoRunRequest = null;
            //var response = instance.UndoRun(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
            //Assert.IsType<UndoRun200Response>(response);
        }

        /// <summary>
        /// Test UpdateManualJournals
        /// </summary>
        [Fact]
        public void UpdateManualJournalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productionOrderID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //instance.UpdateManualJournals(productionOrderID, apiAuthAccountid, apiAuthApplicationkey);
        }

        /// <summary>
        /// Test VoidRun
        /// </summary>
        [Fact]
        public void VoidRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //UndoRunRequest? undoRunRequest = null;
            //var response = instance.VoidRun(apiAuthAccountid, apiAuthApplicationkey, undoRunRequest);
            //Assert.IsType<UndoRun200Response>(response);
        }
    }
}
