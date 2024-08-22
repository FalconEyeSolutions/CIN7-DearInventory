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
    ///  Class for testing CRMApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CRMApiTests : IDisposable
    {
        private CRMApi instance;

        public CRMApiTests()
        {
            instance = new CRMApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CRMApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CRMApi
            //Assert.IsType<CRMApi>(instance);
        }

        /// <summary>
        /// Test CrmLeadPost
        /// </summary>
        [Fact]
        public void CrmLeadPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmLeadPutRequest? crmLeadPutRequest = null;
            //var response = instance.CrmLeadPost(apiAuthAccountid, apiAuthApplicationkey, crmLeadPutRequest);
            //Assert.IsType<CrmLeadPut200Response>(response);
        }

        /// <summary>
        /// Test CrmLeadPut
        /// </summary>
        [Fact]
        public void CrmLeadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmLeadPutRequest? crmLeadPutRequest = null;
            //var response = instance.CrmLeadPut(apiAuthAccountid, apiAuthApplicationkey, crmLeadPutRequest);
            //Assert.IsType<CrmLeadPut200Response>(response);
        }

        /// <summary>
        /// Test CrmOpportunityPgLmtIdModifiedsinceGet
        /// </summary>
        [Fact]
        public void CrmOpportunityPgLmtIdModifiedsinceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string ID = null;
            //string modifiedSince = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.CrmOpportunityPgLmtIdModifiedsinceGet(page, limit, ID, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<CrmOpportunityPgLmtIdModifiedsinceGet200Response>(response);
        }

        /// <summary>
        /// Test CrmOpportunityPost
        /// </summary>
        [Fact]
        public void CrmOpportunityPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmOpportunityPutRequest? crmOpportunityPutRequest = null;
            //var response = instance.CrmOpportunityPost(apiAuthAccountid, apiAuthApplicationkey, crmOpportunityPutRequest);
            //Assert.IsType<CrmOpportunityPut200Response>(response);
        }

        /// <summary>
        /// Test CrmOpportunityPut
        /// </summary>
        [Fact]
        public void CrmOpportunityPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmOpportunityPutRequest? crmOpportunityPutRequest = null;
            //var response = instance.CrmOpportunityPut(apiAuthAccountid, apiAuthApplicationkey, crmOpportunityPutRequest);
            //Assert.IsType<CrmOpportunityPut200Response>(response);
        }

        /// <summary>
        /// Test CrmTaskPgLmtIdNameGet
        /// </summary>
        [Fact]
        public void CrmTaskPgLmtIdNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string ID = null;
            //string name = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.CrmTaskPgLmtIdNameGet(page, limit, ID, name, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<CrmTaskPgLmtIdNameGet200Response>(response);
        }

        /// <summary>
        /// Test CrmTaskPost
        /// </summary>
        [Fact]
        public void CrmTaskPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmTaskPostRequest? crmTaskPostRequest = null;
            //var response = instance.CrmTaskPost(apiAuthAccountid, apiAuthApplicationkey, crmTaskPostRequest);
            //Assert.IsType<CrmTaskPut200Response>(response);
        }

        /// <summary>
        /// Test CrmTaskPut
        /// </summary>
        [Fact]
        public void CrmTaskPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmTaskPutRequest? crmTaskPutRequest = null;
            //var response = instance.CrmTaskPut(apiAuthAccountid, apiAuthApplicationkey, crmTaskPutRequest);
            //Assert.IsType<CrmTaskPut200Response>(response);
        }

        /// <summary>
        /// Test CrmTaskcategoryPost
        /// </summary>
        [Fact]
        public void CrmTaskcategoryPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmTaskcategoryPostRequest? crmTaskcategoryPostRequest = null;
            //var response = instance.CrmTaskcategoryPost(apiAuthAccountid, apiAuthApplicationkey, crmTaskcategoryPostRequest);
            //Assert.IsType<CrmTaskcategoryPost200Response>(response);
        }

        /// <summary>
        /// Test CrmTaskcategoryPut
        /// </summary>
        [Fact]
        public void CrmTaskcategoryPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmTaskcategoryPutRequest? crmTaskcategoryPutRequest = null;
            //var response = instance.CrmTaskcategoryPut(apiAuthAccountid, apiAuthApplicationkey, crmTaskcategoryPutRequest);
            //Assert.IsType<CrmTaskcategoryPut200Response>(response);
        }

        /// <summary>
        /// Test CrmWorkflowPost
        /// </summary>
        [Fact]
        public void CrmWorkflowPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmWorkflowPostRequest? crmWorkflowPostRequest = null;
            //var response = instance.CrmWorkflowPost(apiAuthAccountid, apiAuthApplicationkey, crmWorkflowPostRequest);
            //Assert.IsType<CrmWorkflowPost200Response>(response);
        }

        /// <summary>
        /// Test CrmWorkflowPut
        /// </summary>
        [Fact]
        public void CrmWorkflowPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //CrmWorkflowPutRequest? crmWorkflowPutRequest = null;
            //var response = instance.CrmWorkflowPut(apiAuthAccountid, apiAuthApplicationkey, crmWorkflowPutRequest);
            //Assert.IsType<CrmWorkflowPut200Response>(response);
        }

        /// <summary>
        /// Test LeadPgLmtIdNameEtc
        /// </summary>
        [Fact]
        public void LeadPgLmtIdNameEtcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string ID = null;
            //string name = null;
            //string modifiedSince = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.LeadPgLmtIdNameEtc(page, limit, ID, name, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<LeadPgLmtIdNameEtc200Response>(response);
        }

        /// <summary>
        /// Test TaskPgLmtIdNameEtc
        /// </summary>
        [Fact]
        public void TaskPgLmtIdNameEtcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal page = null;
            //decimal limit = null;
            //string ID = null;
            //string name = null;
            //string startDateFrom = null;
            //string startDateTo = null;
            //string endDateFrom = null;
            //string endDateTo = null;
            //string completeDateFrom = null;
            //string completeDateTo = null;
            //string assignedTo = null;
            //string category = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //var response = instance.TaskPgLmtIdNameEtc(page, limit, ID, name, startDateFrom, startDateTo, endDateFrom, endDateTo, completeDateFrom, completeDateTo, assignedTo, category, apiAuthAccountid, apiAuthApplicationkey);
            //Assert.IsType<TaskPgLmtIdNameEtc200Response>(response);
        }

        /// <summary>
        /// Test WorkflowstartIdNameStartdateEnitytypeEtc
        /// </summary>
        [Fact]
        public void WorkflowstartIdNameStartdateEnitytypeEtcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ID = null;
            //string name = null;
            //string startDate = null;
            //string enityType = null;
            //string entityID = null;
            //string? apiAuthAccountid = null;
            //string? apiAuthApplicationkey = null;
            //Object? body = null;
            //instance.WorkflowstartIdNameStartdateEnitytypeEtc(ID, name, startDate, enityType, entityID, apiAuthAccountid, apiAuthApplicationkey, body);
        }
    }
}
