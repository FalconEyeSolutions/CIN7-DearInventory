/*
 * Cin7 Core Developer Portal
 *
 * ## API introduction  Cin7 Core Inventory API is part of Cin7 Core Inventory web application at https://inventory.dearsystems.com.  <b>You will need to:</b>  + Create an account there before you can use the API.  + Trial accounts are also allowed to access the API.  The API URL is https://inventory.dearsystems.com/externalapi/v2/. To call any API endpoint (method) you must append the endpoint name and parameters to the API URL. eg: https://inventory.dearsystems.com/externalapi/v2/me  <i>Note: The API accepts only JSON data format.</i>  Never assume that the API is actually online at any time. Always queue requests to the API so that you can retry the request in the event of a network failure: even if our server is up 24/7 forever, the network will not be. Consider what happens in the case of a network interruption, eg the cable gets cut by road workers yet again. You should always plan to add all requests to a queue so that they can be tried again in the event of any failure.  Full documentation of each endpoint is available on that endpoint's help page. This includes the operations supported and the full list of available fields with:  + Name  + Type  + Length  + Required values  Use our API Explorer to see examples of each data object.  Cin7 Core Inventory API is a subset of the functionality available through Cin7 Core Inventory UI - check the API documentation to see if the functionality you require is available in the API.  In the event of errors, the API will return an appropriate HTML status code, and an error message. You will need to read both the status code and the error message to establish the cause. Typical error messages are shown on the API status codes page.  ## Connecting to the API  To use the API you will need your Cin7 Core Account ID and API Application key. These can be created on the API setup page inside Cin7 Core Inventory application: https://inventory.dearsystems.com/ExternalAPI.  Each company that you have access to in Cin7 Core Inventory will have a different Cin7 Core Account ID. You can have multiple API Applications created on the same Cin7 Core account. This allows you to link different applications/add-ons to Cin7 Core, since API limits are applied on per API Application basis.  Your Account ID and API Application Key are equivalent to a login and password. They must be kept secret and not shared in any way.  Each request to the API must include these two values sent as HTTP headers:  + api-auth-accountid - You must send your Account ID in this header.  + api-auth-applicationkey - You must send API Application Key in this header.  PHP sample:  ```PHP  $account_id = 'api-auth-accountid: youraccountid'; $application_key = 'api-auth-applicationkey: applicationkey'; $naked_dear_url = 'https://inventory.dearsystems.com/ExternalApi/v2/SaleList';  $data = array ('Page' => '1', 'Limit' => '100'); $data = http_build_query($data);  $ch = curl_init(); curl_setopt($ch, CURLOPT_URL,$naked_dear_url.\"?\".$data); //GET API CALL curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);  $headers = [ \"Content-type: application/json\", $account_id, $application_key ];  curl_setopt($ch, CURLOPT_HTTPHEADER, $headers); $server_output = curl_exec ($ch); curl_close ($ch);  print $server_output ;   ```  ## Pagination  <h4>What is Pagination?</h4>  Pagination is the process of dividing content into discrete pages.  The benefit of pagination is that it allows for faster response times to requests against large datasets like Customers, Products and Invoices, thus providing a more responsive and flexible API for your mission-critical applications.  Cin7 Core Inventory API currently uses pagination on the following endpoints:  + SaleList  + PurchaseList  + StockAdjustmentList  + StockTakeList  + StockTransferList  + Product  + Сategory  All remaining API endpoints do not support pagination.  <h4>Requesting a page</h4>  Pages are requested by adding page parameter to URL: https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}, where {endpoint} and {pagenumber} are placeholders.  For example, if you wanted to retrieve the 3rd page of 100 records from the Products endpoint we would write https://inventory.dearsystems.com/ExternalApi/v2/Product?page=3.  <h4>Page size</h4>  The default page size is 100 records, but is configurable by adding the desired page size in the URL querystring, https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}&limit={pagesize}.  The minimum page size is 1 and the maximum page size is 1000 records.  If you want to retrieve the 5th page of 200 ProductAvailability records (ie. 1001st to 1500th record) then you would use this URL: https://inventory.dearsystems.com/ExternalApi/v2/Product?page=5&limit=200.  <h4>Pagination info</h4>  In the endpoints that support Pagination additional parameter Total is returned with every API call response to provide information regarding how many records there are overall. Below is an example of this structure in JSON for Products endpoint.  { \"Products\":[{...}], \"Total\":41}  ## API Status Codes  |Status Code|Description| |:- -- --|- -- -- -- -- --| |`200 OK`|Operation was successful| |`204 No Content`|Operation was successful and there is no content to return| |`400 Bad Request`|The request was not in a correct form, or the posted data failed a validation test. Check the error returned to see what was wrong with the request.| |`403 Forbidden`|Method authentication failed| |`404 Not found`|Endpoint does not exist (eg using /Products instead of /Product)| |`405 Not allowed`|The method used is not allowed (eg PUT, DELETE)| |`500 Internal Server Error`|The object passed to the API could not be parsed or some unexpected error occurred in Cin7 Core while processing API request| |`503 Service Unavailable`|You reached 60 calls per minute API limit|  ## Date Format  All date fields in Cin7 Core API (including parameters) are in ISO 8601 format and specifying UTC date: yyyy-MM-ddTHH:mm:ss.fff     e.g. 2012-11-14T13:28:33.363  ## Previous API version  Previous API version's description is available here: http://support.dearsystems.com/solution/folders/1000134185
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CIN7.DearInventory.Model;
using CIN7.DearInventory.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace CIN7.DearInventory.Test.Model
{
    /// <summary>
    ///  Class for testing ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner
        //private ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner instance;

        public ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInnerTests()
        {
            // TODO uncomment below to create an instance of ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner
            //instance = new ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner
        /// </summary>
        [Fact]
        public void ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner
            //Assert.IsType<ProductionOrderRecalculatedatesPost200ResponseProductionOrdersInner>(instance);
        }

        /// <summary>
        /// Test the property 'BOMName'
        /// </summary>
        [Fact]
        public void BOMNameTest()
        {
            // TODO unit test for the property 'BOMName'
        }

        /// <summary>
        /// Test the property 'BOMQuantity'
        /// </summary>
        [Fact]
        public void BOMQuantityTest()
        {
            // TODO unit test for the property 'BOMQuantity'
        }

        /// <summary>
        /// Test the property 'BOMVersion'
        /// </summary>
        [Fact]
        public void BOMVersionTest()
        {
            // TODO unit test for the property 'BOMVersion'
        }

        /// <summary>
        /// Test the property 'CapacityCalculationType'
        /// </summary>
        [Fact]
        public void CapacityCalculationTypeTest()
        {
            // TODO unit test for the property 'CapacityCalculationType'
        }

        /// <summary>
        /// Test the property 'Comments'
        /// </summary>
        [Fact]
        public void CommentsTest()
        {
            // TODO unit test for the property 'Comments'
        }

        /// <summary>
        /// Test the property 'CompletionDate'
        /// </summary>
        [Fact]
        public void CompletionDateTest()
        {
            // TODO unit test for the property 'CompletionDate'
        }

        /// <summary>
        /// Test the property 'CostingMethod'
        /// </summary>
        [Fact]
        public void CostingMethodTest()
        {
            // TODO unit test for the property 'CostingMethod'
        }

        /// <summary>
        /// Test the property 'CustomField1'
        /// </summary>
        [Fact]
        public void CustomField1Test()
        {
            // TODO unit test for the property 'CustomField1'
        }

        /// <summary>
        /// Test the property 'CustomField10'
        /// </summary>
        [Fact]
        public void CustomField10Test()
        {
            // TODO unit test for the property 'CustomField10'
        }

        /// <summary>
        /// Test the property 'CustomField2'
        /// </summary>
        [Fact]
        public void CustomField2Test()
        {
            // TODO unit test for the property 'CustomField2'
        }

        /// <summary>
        /// Test the property 'CustomField3'
        /// </summary>
        [Fact]
        public void CustomField3Test()
        {
            // TODO unit test for the property 'CustomField3'
        }

        /// <summary>
        /// Test the property 'CustomField4'
        /// </summary>
        [Fact]
        public void CustomField4Test()
        {
            // TODO unit test for the property 'CustomField4'
        }

        /// <summary>
        /// Test the property 'CustomField5'
        /// </summary>
        [Fact]
        public void CustomField5Test()
        {
            // TODO unit test for the property 'CustomField5'
        }

        /// <summary>
        /// Test the property 'CustomField6'
        /// </summary>
        [Fact]
        public void CustomField6Test()
        {
            // TODO unit test for the property 'CustomField6'
        }

        /// <summary>
        /// Test the property 'CustomField7'
        /// </summary>
        [Fact]
        public void CustomField7Test()
        {
            // TODO unit test for the property 'CustomField7'
        }

        /// <summary>
        /// Test the property 'CustomField8'
        /// </summary>
        [Fact]
        public void CustomField8Test()
        {
            // TODO unit test for the property 'CustomField8'
        }

        /// <summary>
        /// Test the property 'CustomField9'
        /// </summary>
        [Fact]
        public void CustomField9Test()
        {
            // TODO unit test for the property 'CustomField9'
        }

        /// <summary>
        /// Test the property 'Deliveries'
        /// </summary>
        [Fact]
        public void DeliveriesTest()
        {
            // TODO unit test for the property 'Deliveries'
        }

        /// <summary>
        /// Test the property 'FinishedGoodsAccountCode'
        /// </summary>
        [Fact]
        public void FinishedGoodsAccountCodeTest()
        {
            // TODO unit test for the property 'FinishedGoodsAccountCode'
        }

        /// <summary>
        /// Test the property 'IsIgnoreLeadTime'
        /// </summary>
        [Fact]
        public void IsIgnoreLeadTimeTest()
        {
            // TODO unit test for the property 'IsIgnoreLeadTime'
        }

        /// <summary>
        /// Test the property 'IssueMethodComponent'
        /// </summary>
        [Fact]
        public void IssueMethodComponentTest()
        {
            // TODO unit test for the property 'IssueMethodComponent'
        }

        /// <summary>
        /// Test the property 'IssueMethodParameter'
        /// </summary>
        [Fact]
        public void IssueMethodParameterTest()
        {
            // TODO unit test for the property 'IssueMethodParameter'
        }

        /// <summary>
        /// Test the property 'LocationID'
        /// </summary>
        [Fact]
        public void LocationIDTest()
        {
            // TODO unit test for the property 'LocationID'
        }

        /// <summary>
        /// Test the property 'LocationName'
        /// </summary>
        [Fact]
        public void LocationNameTest()
        {
            // TODO unit test for the property 'LocationName'
        }

        /// <summary>
        /// Test the property 'Operations'
        /// </summary>
        [Fact]
        public void OperationsTest()
        {
            // TODO unit test for the property 'Operations'
        }

        /// <summary>
        /// Test the property 'OrderCycleTime'
        /// </summary>
        [Fact]
        public void OrderCycleTimeTest()
        {
            // TODO unit test for the property 'OrderCycleTime'
        }

        /// <summary>
        /// Test the property 'OrderNumber'
        /// </summary>
        [Fact]
        public void OrderNumberTest()
        {
            // TODO unit test for the property 'OrderNumber'
        }

        /// <summary>
        /// Test the property 'OrderStatus'
        /// </summary>
        [Fact]
        public void OrderStatusTest()
        {
            // TODO unit test for the property 'OrderStatus'
        }

        /// <summary>
        /// Test the property 'PlannedBy'
        /// </summary>
        [Fact]
        public void PlannedByTest()
        {
            // TODO unit test for the property 'PlannedBy'
        }

        /// <summary>
        /// Test the property 'ProductID'
        /// </summary>
        [Fact]
        public void ProductIDTest()
        {
            // TODO unit test for the property 'ProductID'
        }

        /// <summary>
        /// Test the property 'ProductName'
        /// </summary>
        [Fact]
        public void ProductNameTest()
        {
            // TODO unit test for the property 'ProductName'
        }

        /// <summary>
        /// Test the property 'ProductSKU'
        /// </summary>
        [Fact]
        public void ProductSKUTest()
        {
            // TODO unit test for the property 'ProductSKU'
        }

        /// <summary>
        /// Test the property 'ProductionOrderID'
        /// </summary>
        [Fact]
        public void ProductionOrderIDTest()
        {
            // TODO unit test for the property 'ProductionOrderID'
        }

        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Fact]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }

        /// <summary>
        /// Test the property 'ReleaseDate'
        /// </summary>
        [Fact]
        public void ReleaseDateTest()
        {
            // TODO unit test for the property 'ReleaseDate'
        }

        /// <summary>
        /// Test the property 'ReleasedBy'
        /// </summary>
        [Fact]
        public void ReleasedByTest()
        {
            // TODO unit test for the property 'ReleasedBy'
        }

        /// <summary>
        /// Test the property 'RequiredByDate'
        /// </summary>
        [Fact]
        public void RequiredByDateTest()
        {
            // TODO unit test for the property 'RequiredByDate'
        }

        /// <summary>
        /// Test the property 'RetailID'
        /// </summary>
        [Fact]
        public void RetailIDTest()
        {
            // TODO unit test for the property 'RetailID'
        }

        /// <summary>
        /// Test the property 'RunSize'
        /// </summary>
        [Fact]
        public void RunSizeTest()
        {
            // TODO unit test for the property 'RunSize'
        }

        /// <summary>
        /// Test the property 'SourceName'
        /// </summary>
        [Fact]
        public void SourceNameTest()
        {
            // TODO unit test for the property 'SourceName'
        }

        /// <summary>
        /// Test the property 'SourceTaskID'
        /// </summary>
        [Fact]
        public void SourceTaskIDTest()
        {
            // TODO unit test for the property 'SourceTaskID'
        }

        /// <summary>
        /// Test the property 'SourceTaskNumber'
        /// </summary>
        [Fact]
        public void SourceTaskNumberTest()
        {
            // TODO unit test for the property 'SourceTaskNumber'
        }

        /// <summary>
        /// Test the property 'SourceTasks'
        /// </summary>
        [Fact]
        public void SourceTasksTest()
        {
            // TODO unit test for the property 'SourceTasks'
        }

        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }

        /// <summary>
        /// Test the property 'StartUpdate'
        /// </summary>
        [Fact]
        public void StartUpdateTest()
        {
            // TODO unit test for the property 'StartUpdate'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }

        /// <summary>
        /// Test the property 'Unit'
        /// </summary>
        [Fact]
        public void UnitTest()
        {
            // TODO unit test for the property 'Unit'
        }

        /// <summary>
        /// Test the property 'WIPAccountCode'
        /// </summary>
        [Fact]
        public void WIPAccountCodeTest()
        {
            // TODO unit test for the property 'WIPAccountCode'
        }

        /// <summary>
        /// Test the property 'WarehouseID'
        /// </summary>
        [Fact]
        public void WarehouseIDTest()
        {
            // TODO unit test for the property 'WarehouseID'
        }

        /// <summary>
        /// Test the property 'WarehouseName'
        /// </summary>
        [Fact]
        public void WarehouseNameTest()
        {
            // TODO unit test for the property 'WarehouseName'
        }
    }
}
