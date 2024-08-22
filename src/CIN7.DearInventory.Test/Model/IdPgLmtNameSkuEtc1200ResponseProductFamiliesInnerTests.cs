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
    ///  Class for testing IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IdPgLmtNameSkuEtc1200ResponseProductFamiliesInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner
        //private IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner instance;

        public IdPgLmtNameSkuEtc1200ResponseProductFamiliesInnerTests()
        {
            // TODO uncomment below to create an instance of IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner
            //instance = new IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner
        /// </summary>
        [Fact]
        public void IdPgLmtNameSkuEtc1200ResponseProductFamiliesInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner
            //Assert.IsType<IdPgLmtNameSkuEtc1200ResponseProductFamiliesInner>(instance);
        }

        /// <summary>
        /// Test the property 'Attachments'
        /// </summary>
        [Fact]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }

        /// <summary>
        /// Test the property 'AttributeSet'
        /// </summary>
        [Fact]
        public void AttributeSetTest()
        {
            // TODO unit test for the property 'AttributeSet'
        }

        /// <summary>
        /// Test the property 'Brand'
        /// </summary>
        [Fact]
        public void BrandTest()
        {
            // TODO unit test for the property 'Brand'
        }

        /// <summary>
        /// Test the property 'COGSAccount'
        /// </summary>
        [Fact]
        public void COGSAccountTest()
        {
            // TODO unit test for the property 'COGSAccount'
        }

        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Fact]
        public void CategoryTest()
        {
            // TODO unit test for the property 'Category'
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
        /// Test the property 'CountryOfOrigin'
        /// </summary>
        [Fact]
        public void CountryOfOriginTest()
        {
            // TODO unit test for the property 'CountryOfOrigin'
        }

        /// <summary>
        /// Test the property 'CountryOfOriginCode'
        /// </summary>
        [Fact]
        public void CountryOfOriginCodeTest()
        {
            // TODO unit test for the property 'CountryOfOriginCode'
        }

        /// <summary>
        /// Test the property 'DefaultLocation'
        /// </summary>
        [Fact]
        public void DefaultLocationTest()
        {
            // TODO unit test for the property 'DefaultLocation'
        }

        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

        /// <summary>
        /// Test the property 'DiscountRule'
        /// </summary>
        [Fact]
        public void DiscountRuleTest()
        {
            // TODO unit test for the property 'DiscountRule'
        }

        /// <summary>
        /// Test the property 'DropShipMode'
        /// </summary>
        [Fact]
        public void DropShipModeTest()
        {
            // TODO unit test for the property 'DropShipMode'
        }

        /// <summary>
        /// Test the property 'HSCode'
        /// </summary>
        [Fact]
        public void HSCodeTest()
        {
            // TODO unit test for the property 'HSCode'
        }

        /// <summary>
        /// Test the property 'ID'
        /// </summary>
        [Fact]
        public void IDTest()
        {
            // TODO unit test for the property 'ID'
        }

        /// <summary>
        /// Test the property 'InventoryAccount'
        /// </summary>
        [Fact]
        public void InventoryAccountTest()
        {
            // TODO unit test for the property 'InventoryAccount'
        }

        /// <summary>
        /// Test the property 'LastModifiedOn'
        /// </summary>
        [Fact]
        public void LastModifiedOnTest()
        {
            // TODO unit test for the property 'LastModifiedOn'
        }

        /// <summary>
        /// Test the property 'MinimumBeforeReorder'
        /// </summary>
        [Fact]
        public void MinimumBeforeReorderTest()
        {
            // TODO unit test for the property 'MinimumBeforeReorder'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Option1Name'
        /// </summary>
        [Fact]
        public void Option1NameTest()
        {
            // TODO unit test for the property 'Option1Name'
        }

        /// <summary>
        /// Test the property 'Option1Values'
        /// </summary>
        [Fact]
        public void Option1ValuesTest()
        {
            // TODO unit test for the property 'Option1Values'
        }

        /// <summary>
        /// Test the property 'Option2Name'
        /// </summary>
        [Fact]
        public void Option2NameTest()
        {
            // TODO unit test for the property 'Option2Name'
        }

        /// <summary>
        /// Test the property 'Option2Values'
        /// </summary>
        [Fact]
        public void Option2ValuesTest()
        {
            // TODO unit test for the property 'Option2Values'
        }

        /// <summary>
        /// Test the property 'Option3Name'
        /// </summary>
        [Fact]
        public void Option3NameTest()
        {
            // TODO unit test for the property 'Option3Name'
        }

        /// <summary>
        /// Test the property 'Option3Values'
        /// </summary>
        [Fact]
        public void Option3ValuesTest()
        {
            // TODO unit test for the property 'Option3Values'
        }

        /// <summary>
        /// Test the property 'PriceTier1'
        /// </summary>
        [Fact]
        public void PriceTier1Test()
        {
            // TODO unit test for the property 'PriceTier1'
        }

        /// <summary>
        /// Test the property 'PriceTier10'
        /// </summary>
        [Fact]
        public void PriceTier10Test()
        {
            // TODO unit test for the property 'PriceTier10'
        }

        /// <summary>
        /// Test the property 'PriceTier2'
        /// </summary>
        [Fact]
        public void PriceTier2Test()
        {
            // TODO unit test for the property 'PriceTier2'
        }

        /// <summary>
        /// Test the property 'PriceTier3'
        /// </summary>
        [Fact]
        public void PriceTier3Test()
        {
            // TODO unit test for the property 'PriceTier3'
        }

        /// <summary>
        /// Test the property 'PriceTier4'
        /// </summary>
        [Fact]
        public void PriceTier4Test()
        {
            // TODO unit test for the property 'PriceTier4'
        }

        /// <summary>
        /// Test the property 'PriceTier5'
        /// </summary>
        [Fact]
        public void PriceTier5Test()
        {
            // TODO unit test for the property 'PriceTier5'
        }

        /// <summary>
        /// Test the property 'PriceTier6'
        /// </summary>
        [Fact]
        public void PriceTier6Test()
        {
            // TODO unit test for the property 'PriceTier6'
        }

        /// <summary>
        /// Test the property 'PriceTier7'
        /// </summary>
        [Fact]
        public void PriceTier7Test()
        {
            // TODO unit test for the property 'PriceTier7'
        }

        /// <summary>
        /// Test the property 'PriceTier8'
        /// </summary>
        [Fact]
        public void PriceTier8Test()
        {
            // TODO unit test for the property 'PriceTier8'
        }

        /// <summary>
        /// Test the property 'PriceTier9'
        /// </summary>
        [Fact]
        public void PriceTier9Test()
        {
            // TODO unit test for the property 'PriceTier9'
        }

        /// <summary>
        /// Test the property 'Products'
        /// </summary>
        [Fact]
        public void ProductsTest()
        {
            // TODO unit test for the property 'Products'
        }

        /// <summary>
        /// Test the property 'PurchaseTaxRule'
        /// </summary>
        [Fact]
        public void PurchaseTaxRuleTest()
        {
            // TODO unit test for the property 'PurchaseTaxRule'
        }

        /// <summary>
        /// Test the property 'ReorderQuantity'
        /// </summary>
        [Fact]
        public void ReorderQuantityTest()
        {
            // TODO unit test for the property 'ReorderQuantity'
        }

        /// <summary>
        /// Test the property 'RevenueAccount'
        /// </summary>
        [Fact]
        public void RevenueAccountTest()
        {
            // TODO unit test for the property 'RevenueAccount'
        }

        /// <summary>
        /// Test the property 'SKU'
        /// </summary>
        [Fact]
        public void SKUTest()
        {
            // TODO unit test for the property 'SKU'
        }

        /// <summary>
        /// Test the property 'SaleTaxRule'
        /// </summary>
        [Fact]
        public void SaleTaxRuleTest()
        {
            // TODO unit test for the property 'SaleTaxRule'
        }

        /// <summary>
        /// Test the property 'ShortDescription'
        /// </summary>
        [Fact]
        public void ShortDescriptionTest()
        {
            // TODO unit test for the property 'ShortDescription'
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
        /// Test the property 'UOM'
        /// </summary>
        [Fact]
        public void UOMTest()
        {
            // TODO unit test for the property 'UOM'
        }
    }
}
