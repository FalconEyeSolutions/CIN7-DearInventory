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
    ///  Class for testing CrmOpportunityPut200ResponseOpportunityListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CrmOpportunityPut200ResponseOpportunityListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CrmOpportunityPut200ResponseOpportunityListInner
        //private CrmOpportunityPut200ResponseOpportunityListInner instance;

        public CrmOpportunityPut200ResponseOpportunityListInnerTests()
        {
            // TODO uncomment below to create an instance of CrmOpportunityPut200ResponseOpportunityListInner
            //instance = new CrmOpportunityPut200ResponseOpportunityListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CrmOpportunityPut200ResponseOpportunityListInner
        /// </summary>
        [Fact]
        public void CrmOpportunityPut200ResponseOpportunityListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" CrmOpportunityPut200ResponseOpportunityListInner
            //Assert.IsType<CrmOpportunityPut200ResponseOpportunityListInner>(instance);
        }

        /// <summary>
        /// Test the property 'AdditionalCharges'
        /// </summary>
        [Fact]
        public void AdditionalChargesTest()
        {
            // TODO unit test for the property 'AdditionalCharges'
        }

        /// <summary>
        /// Test the property 'BillingAddressLine1'
        /// </summary>
        [Fact]
        public void BillingAddressLine1Test()
        {
            // TODO unit test for the property 'BillingAddressLine1'
        }

        /// <summary>
        /// Test the property 'BillingAddressLine2'
        /// </summary>
        [Fact]
        public void BillingAddressLine2Test()
        {
            // TODO unit test for the property 'BillingAddressLine2'
        }

        /// <summary>
        /// Test the property 'Contact'
        /// </summary>
        [Fact]
        public void ContactTest()
        {
            // TODO unit test for the property 'Contact'
        }

        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }

        /// <summary>
        /// Test the property 'CurrencyConversionRate'
        /// </summary>
        [Fact]
        public void CurrencyConversionRateTest()
        {
            // TODO unit test for the property 'CurrencyConversionRate'
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
        /// Test the property 'CustomerCurrency'
        /// </summary>
        [Fact]
        public void CustomerCurrencyTest()
        {
            // TODO unit test for the property 'CustomerCurrency'
        }

        /// <summary>
        /// Test the property 'CustomerID'
        /// </summary>
        [Fact]
        public void CustomerIDTest()
        {
            // TODO unit test for the property 'CustomerID'
        }

        /// <summary>
        /// Test the property 'CustomerName'
        /// </summary>
        [Fact]
        public void CustomerNameTest()
        {
            // TODO unit test for the property 'CustomerName'
        }

        /// <summary>
        /// Test the property 'CustomerReference'
        /// </summary>
        [Fact]
        public void CustomerReferenceTest()
        {
            // TODO unit test for the property 'CustomerReference'
        }

        /// <summary>
        /// Test the property 'DefaultAccount'
        /// </summary>
        [Fact]
        public void DefaultAccountTest()
        {
            // TODO unit test for the property 'DefaultAccount'
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
        /// Test the property 'LeadID'
        /// </summary>
        [Fact]
        public void LeadIDTest()
        {
            // TODO unit test for the property 'LeadID'
        }

        /// <summary>
        /// Test the property 'Lines'
        /// </summary>
        [Fact]
        public void LinesTest()
        {
            // TODO unit test for the property 'Lines'
        }

        /// <summary>
        /// Test the property 'OpportunityComment'
        /// </summary>
        [Fact]
        public void OpportunityCommentTest()
        {
            // TODO unit test for the property 'OpportunityComment'
        }

        /// <summary>
        /// Test the property 'OpportunityDate'
        /// </summary>
        [Fact]
        public void OpportunityDateTest()
        {
            // TODO unit test for the property 'OpportunityDate'
        }

        /// <summary>
        /// Test the property 'OpportunityLocation'
        /// </summary>
        [Fact]
        public void OpportunityLocationTest()
        {
            // TODO unit test for the property 'OpportunityLocation'
        }

        /// <summary>
        /// Test the property 'OpportunityMemo'
        /// </summary>
        [Fact]
        public void OpportunityMemoTest()
        {
            // TODO unit test for the property 'OpportunityMemo'
        }

        /// <summary>
        /// Test the property 'OpportunityNumber'
        /// </summary>
        [Fact]
        public void OpportunityNumberTest()
        {
            // TODO unit test for the property 'OpportunityNumber'
        }

        /// <summary>
        /// Test the property 'OpportunityStatus'
        /// </summary>
        [Fact]
        public void OpportunityStatusTest()
        {
            // TODO unit test for the property 'OpportunityStatus'
        }

        /// <summary>
        /// Test the property 'Phone'
        /// </summary>
        [Fact]
        public void PhoneTest()
        {
            // TODO unit test for the property 'Phone'
        }

        /// <summary>
        /// Test the property 'PriceTier'
        /// </summary>
        [Fact]
        public void PriceTierTest()
        {
            // TODO unit test for the property 'PriceTier'
        }

        /// <summary>
        /// Test the property 'SalesRepresentative'
        /// </summary>
        [Fact]
        public void SalesRepresentativeTest()
        {
            // TODO unit test for the property 'SalesRepresentative'
        }

        /// <summary>
        /// Test the property 'ShipToAddress1'
        /// </summary>
        [Fact]
        public void ShipToAddress1Test()
        {
            // TODO unit test for the property 'ShipToAddress1'
        }

        /// <summary>
        /// Test the property 'ShipToAddress2'
        /// </summary>
        [Fact]
        public void ShipToAddress2Test()
        {
            // TODO unit test for the property 'ShipToAddress2'
        }

        /// <summary>
        /// Test the property 'ShipToCity'
        /// </summary>
        [Fact]
        public void ShipToCityTest()
        {
            // TODO unit test for the property 'ShipToCity'
        }

        /// <summary>
        /// Test the property 'ShipToCompany'
        /// </summary>
        [Fact]
        public void ShipToCompanyTest()
        {
            // TODO unit test for the property 'ShipToCompany'
        }

        /// <summary>
        /// Test the property 'ShipToContact'
        /// </summary>
        [Fact]
        public void ShipToContactTest()
        {
            // TODO unit test for the property 'ShipToContact'
        }

        /// <summary>
        /// Test the property 'ShipToCountry'
        /// </summary>
        [Fact]
        public void ShipToCountryTest()
        {
            // TODO unit test for the property 'ShipToCountry'
        }

        /// <summary>
        /// Test the property 'ShipToOther'
        /// </summary>
        [Fact]
        public void ShipToOtherTest()
        {
            // TODO unit test for the property 'ShipToOther'
        }

        /// <summary>
        /// Test the property 'ShipToPostCode'
        /// </summary>
        [Fact]
        public void ShipToPostCodeTest()
        {
            // TODO unit test for the property 'ShipToPostCode'
        }

        /// <summary>
        /// Test the property 'ShipToState'
        /// </summary>
        [Fact]
        public void ShipToStateTest()
        {
            // TODO unit test for the property 'ShipToState'
        }

        /// <summary>
        /// Test the property 'ShippingAddressLine1'
        /// </summary>
        [Fact]
        public void ShippingAddressLine1Test()
        {
            // TODO unit test for the property 'ShippingAddressLine1'
        }

        /// <summary>
        /// Test the property 'ShippingAddressLine2'
        /// </summary>
        [Fact]
        public void ShippingAddressLine2Test()
        {
            // TODO unit test for the property 'ShippingAddressLine2'
        }

        /// <summary>
        /// Test the property 'TaxInclusive'
        /// </summary>
        [Fact]
        public void TaxInclusiveTest()
        {
            // TODO unit test for the property 'TaxInclusive'
        }

        /// <summary>
        /// Test the property 'TaxPercent'
        /// </summary>
        [Fact]
        public void TaxPercentTest()
        {
            // TODO unit test for the property 'TaxPercent'
        }

        /// <summary>
        /// Test the property 'TaxRule'
        /// </summary>
        [Fact]
        public void TaxRuleTest()
        {
            // TODO unit test for the property 'TaxRule'
        }

        /// <summary>
        /// Test the property 'TaxTotal'
        /// </summary>
        [Fact]
        public void TaxTotalTest()
        {
            // TODO unit test for the property 'TaxTotal'
        }

        /// <summary>
        /// Test the property 'TermDays'
        /// </summary>
        [Fact]
        public void TermDaysTest()
        {
            // TODO unit test for the property 'TermDays'
        }

        /// <summary>
        /// Test the property 'TermDueNextMonth'
        /// </summary>
        [Fact]
        public void TermDueNextMonthTest()
        {
            // TODO unit test for the property 'TermDueNextMonth'
        }

        /// <summary>
        /// Test the property 'TermMethod'
        /// </summary>
        [Fact]
        public void TermMethodTest()
        {
            // TODO unit test for the property 'TermMethod'
        }

        /// <summary>
        /// Test the property 'Terms'
        /// </summary>
        [Fact]
        public void TermsTest()
        {
            // TODO unit test for the property 'Terms'
        }

        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
    }
}
