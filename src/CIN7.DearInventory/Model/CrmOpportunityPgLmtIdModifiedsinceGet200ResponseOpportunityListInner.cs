/*
 * Cin7 Core Developer Portal
 *
 * ## API introduction  Cin7 Core Inventory API is part of Cin7 Core Inventory web application at https://inventory.dearsystems.com.  <b>You will need to:</b>  + Create an account there before you can use the API.  + Trial accounts are also allowed to access the API.  The API URL is https://inventory.dearsystems.com/externalapi/v2/. To call any API endpoint (method) you must append the endpoint name and parameters to the API URL. eg: https://inventory.dearsystems.com/externalapi/v2/me  <i>Note: The API accepts only JSON data format.</i>  Never assume that the API is actually online at any time. Always queue requests to the API so that you can retry the request in the event of a network failure: even if our server is up 24/7 forever, the network will not be. Consider what happens in the case of a network interruption, eg the cable gets cut by road workers yet again. You should always plan to add all requests to a queue so that they can be tried again in the event of any failure.  Full documentation of each endpoint is available on that endpoint's help page. This includes the operations supported and the full list of available fields with:  + Name  + Type  + Length  + Required values  Use our API Explorer to see examples of each data object.  Cin7 Core Inventory API is a subset of the functionality available through Cin7 Core Inventory UI - check the API documentation to see if the functionality you require is available in the API.  In the event of errors, the API will return an appropriate HTML status code, and an error message. You will need to read both the status code and the error message to establish the cause. Typical error messages are shown on the API status codes page.  ## Connecting to the API  To use the API you will need your Cin7 Core Account ID and API Application key. These can be created on the API setup page inside Cin7 Core Inventory application: https://inventory.dearsystems.com/ExternalAPI.  Each company that you have access to in Cin7 Core Inventory will have a different Cin7 Core Account ID. You can have multiple API Applications created on the same Cin7 Core account. This allows you to link different applications/add-ons to Cin7 Core, since API limits are applied on per API Application basis.  Your Account ID and API Application Key are equivalent to a login and password. They must be kept secret and not shared in any way.  Each request to the API must include these two values sent as HTTP headers:  + api-auth-accountid - You must send your Account ID in this header.  + api-auth-applicationkey - You must send API Application Key in this header.  PHP sample:  ```PHP  $account_id = 'api-auth-accountid: youraccountid'; $application_key = 'api-auth-applicationkey: applicationkey'; $naked_dear_url = 'https://inventory.dearsystems.com/ExternalApi/v2/SaleList';  $data = array ('Page' => '1', 'Limit' => '100'); $data = http_build_query($data);  $ch = curl_init(); curl_setopt($ch, CURLOPT_URL,$naked_dear_url.\"?\".$data); //GET API CALL curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);  $headers = [ \"Content-type: application/json\", $account_id, $application_key ];  curl_setopt($ch, CURLOPT_HTTPHEADER, $headers); $server_output = curl_exec ($ch); curl_close ($ch);  print $server_output ;   ```  ## Pagination  <h4>What is Pagination?</h4>  Pagination is the process of dividing content into discrete pages.  The benefit of pagination is that it allows for faster response times to requests against large datasets like Customers, Products and Invoices, thus providing a more responsive and flexible API for your mission-critical applications.  Cin7 Core Inventory API currently uses pagination on the following endpoints:  + SaleList  + PurchaseList  + StockAdjustmentList  + StockTakeList  + StockTransferList  + Product  + Сategory  All remaining API endpoints do not support pagination.  <h4>Requesting a page</h4>  Pages are requested by adding page parameter to URL: https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}, where {endpoint} and {pagenumber} are placeholders.  For example, if you wanted to retrieve the 3rd page of 100 records from the Products endpoint we would write https://inventory.dearsystems.com/ExternalApi/v2/Product?page=3.  <h4>Page size</h4>  The default page size is 100 records, but is configurable by adding the desired page size in the URL querystring, https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}&limit={pagesize}.  The minimum page size is 1 and the maximum page size is 1000 records.  If you want to retrieve the 5th page of 200 ProductAvailability records (ie. 1001st to 1500th record) then you would use this URL: https://inventory.dearsystems.com/ExternalApi/v2/Product?page=5&limit=200.  <h4>Pagination info</h4>  In the endpoints that support Pagination additional parameter Total is returned with every API call response to provide information regarding how many records there are overall. Below is an example of this structure in JSON for Products endpoint.  { \"Products\":[{...}], \"Total\":41}  ## API Status Codes  |Status Code|Description| |:- -- --|- -- -- -- -- --| |`200 OK`|Operation was successful| |`204 No Content`|Operation was successful and there is no content to return| |`400 Bad Request`|The request was not in a correct form, or the posted data failed a validation test. Check the error returned to see what was wrong with the request.| |`403 Forbidden`|Method authentication failed| |`404 Not found`|Endpoint does not exist (eg using /Products instead of /Product)| |`405 Not allowed`|The method used is not allowed (eg PUT, DELETE)| |`500 Internal Server Error`|The object passed to the API could not be parsed or some unexpected error occurred in Cin7 Core while processing API request| |`503 Service Unavailable`|You reached 60 calls per minute API limit|  ## Date Format  All date fields in Cin7 Core API (including parameters) are in ISO 8601 format and specifying UTC date: yyyy-MM-ddTHH:mm:ss.fff     e.g. 2012-11-14T13:28:33.363  ## Previous API version  Previous API version's description is available here: http://support.dearsystems.com/solution/folders/1000134185
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace CIN7.DearInventory.Model
{
    /// <summary>
    /// CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInner
    /// </summary>
    [DataContract(Name = "crmOpportunity_Pg__Lmt__Id__Modifiedsince__get_200_response_opportunityList_inner")]
    public partial class CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInner()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInner" /> class.
        /// </summary>
        /// <param name="additionalCharges">additionalCharges (required).</param>
        /// <param name="billingAddressLine1">billingAddressLine1 (required).</param>
        /// <param name="billingAddressLine2">billingAddressLine2 (required).</param>
        /// <param name="contact">contact (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="currencyConversionRate">currencyConversionRate (required).</param>
        /// <param name="customField1">customField1 (required).</param>
        /// <param name="customField10">customField10 (required).</param>
        /// <param name="customField2">customField2 (required).</param>
        /// <param name="customField3">customField3 (required).</param>
        /// <param name="customField4">customField4 (required).</param>
        /// <param name="customField5">customField5 (required).</param>
        /// <param name="customField6">customField6 (required).</param>
        /// <param name="customField7">customField7 (required).</param>
        /// <param name="customField8">customField8 (required).</param>
        /// <param name="customField9">customField9 (required).</param>
        /// <param name="customerCurrency">customerCurrency (required).</param>
        /// <param name="customerID">customerID (required).</param>
        /// <param name="customerName">customerName (required).</param>
        /// <param name="customerReference">customerReference (required).</param>
        /// <param name="defaultAccount">defaultAccount (required).</param>
        /// <param name="iD">iD (required).</param>
        /// <param name="leadID">leadID (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="opportunityComment">opportunityComment (required).</param>
        /// <param name="opportunityDate">opportunityDate (required).</param>
        /// <param name="opportunityLocation">opportunityLocation (required).</param>
        /// <param name="opportunityMemo">opportunityMemo (required).</param>
        /// <param name="opportunityNumber">opportunityNumber (required).</param>
        /// <param name="opportunityStatus">opportunityStatus (required).</param>
        /// <param name="phone">phone (required).</param>
        /// <param name="priceTier">priceTier (required).</param>
        /// <param name="salesRepresentative">salesRepresentative (required).</param>
        /// <param name="shipToAddress1">shipToAddress1 (required).</param>
        /// <param name="shipToAddress2">shipToAddress2 (required).</param>
        /// <param name="shipToCity">shipToCity (required).</param>
        /// <param name="shipToCompany">shipToCompany (required).</param>
        /// <param name="shipToContact">shipToContact (required).</param>
        /// <param name="shipToCountry">shipToCountry (required).</param>
        /// <param name="shipToOther">shipToOther (required).</param>
        /// <param name="shipToPostCode">shipToPostCode (required).</param>
        /// <param name="shipToState">shipToState (required).</param>
        /// <param name="shippingAddressLine1">shippingAddressLine1 (required).</param>
        /// <param name="shippingAddressLine2">shippingAddressLine2 (required).</param>
        /// <param name="taxInclusive">taxInclusive (required).</param>
        /// <param name="taxPercent">taxPercent (required).</param>
        /// <param name="taxRule">taxRule (required).</param>
        /// <param name="taxTotal">taxTotal (required).</param>
        /// <param name="termDays">termDays (required).</param>
        /// <param name="termDueNextMonth">termDueNextMonth (required).</param>
        /// <param name="termMethod">termMethod (required).</param>
        /// <param name="terms">terms (required).</param>
        /// <param name="total">total (required).</param>
        public CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInner(List<CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInnerAdditionalChargesInner> additionalCharges = default, string billingAddressLine1 = default, string billingAddressLine2 = default, string contact = default, string currency = default, decimal currencyConversionRate = default, string customField1 = default, string customField10 = default, string customField2 = default, string customField3 = default, string customField4 = default, string customField5 = default, string customField6 = default, string customField7 = default, string customField8 = default, string customField9 = default, string customerCurrency = default, string customerID = default, string customerName = default, string customerReference = default, string defaultAccount = default, string iD = default, string leadID = default, List<CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInnerLinesInner> lines = default, string opportunityComment = default, string opportunityDate = default, string opportunityLocation = default, string opportunityMemo = default, string opportunityNumber = default, string opportunityStatus = default, string phone = default, string priceTier = default, string salesRepresentative = default, string shipToAddress1 = default, string shipToAddress2 = default, string shipToCity = default, string shipToCompany = default, string shipToContact = default, string shipToCountry = default, bool shipToOther = default, string shipToPostCode = default, string shipToState = default, string shippingAddressLine1 = default, string shippingAddressLine2 = default, bool taxInclusive = default, decimal taxPercent = default, string taxRule = default, decimal taxTotal = default, decimal termDays = default, decimal termDueNextMonth = default, decimal termMethod = default, string terms = default, decimal total = default)
        {
            // to ensure "additionalCharges" is required (not null)
            ArgumentNullException.ThrowIfNull(additionalCharges);
            AdditionalCharges = additionalCharges;
            // to ensure "billingAddressLine1" is required (not null)
            ArgumentNullException.ThrowIfNull(billingAddressLine1);
            BillingAddressLine1 = billingAddressLine1;
            // to ensure "billingAddressLine2" is required (not null)
            ArgumentNullException.ThrowIfNull(billingAddressLine2);
            BillingAddressLine2 = billingAddressLine2;
            // to ensure "contact" is required (not null)
            ArgumentNullException.ThrowIfNull(contact);
            Contact = contact;
            // to ensure "currency" is required (not null)
            ArgumentNullException.ThrowIfNull(currency);
            Currency = currency;
            CurrencyConversionRate = currencyConversionRate;
            // to ensure "customField1" is required (not null)
            ArgumentNullException.ThrowIfNull(customField1);
            CustomField1 = customField1;
            // to ensure "customField10" is required (not null)
            ArgumentNullException.ThrowIfNull(customField10);
            CustomField10 = customField10;
            // to ensure "customField2" is required (not null)
            ArgumentNullException.ThrowIfNull(customField2);
            CustomField2 = customField2;
            // to ensure "customField3" is required (not null)
            ArgumentNullException.ThrowIfNull(customField3);
            CustomField3 = customField3;
            // to ensure "customField4" is required (not null)
            ArgumentNullException.ThrowIfNull(customField4);
            CustomField4 = customField4;
            // to ensure "customField5" is required (not null)
            ArgumentNullException.ThrowIfNull(customField5);
            CustomField5 = customField5;
            // to ensure "customField6" is required (not null)
            ArgumentNullException.ThrowIfNull(customField6);
            CustomField6 = customField6;
            // to ensure "customField7" is required (not null)
            ArgumentNullException.ThrowIfNull(customField7);
            CustomField7 = customField7;
            // to ensure "customField8" is required (not null)
            ArgumentNullException.ThrowIfNull(customField8);
            CustomField8 = customField8;
            // to ensure "customField9" is required (not null)
            ArgumentNullException.ThrowIfNull(customField9);
            CustomField9 = customField9;
            // to ensure "customerCurrency" is required (not null)
            ArgumentNullException.ThrowIfNull(customerCurrency);
            CustomerCurrency = customerCurrency;
            // to ensure "customerID" is required (not null)
            ArgumentNullException.ThrowIfNull(customerID);
            CustomerID = customerID;
            // to ensure "customerName" is required (not null)
            ArgumentNullException.ThrowIfNull(customerName);
            CustomerName = customerName;
            // to ensure "customerReference" is required (not null)
            ArgumentNullException.ThrowIfNull(customerReference);
            CustomerReference = customerReference;
            // to ensure "defaultAccount" is required (not null)
            ArgumentNullException.ThrowIfNull(defaultAccount);
            DefaultAccount = defaultAccount;
            // to ensure "iD" is required (not null)
            ArgumentNullException.ThrowIfNull(iD);
            ID = iD;
            // to ensure "leadID" is required (not null)
            ArgumentNullException.ThrowIfNull(leadID);
            LeadID = leadID;
            // to ensure "lines" is required (not null)
            ArgumentNullException.ThrowIfNull(lines);
            Lines = lines;
            // to ensure "opportunityComment" is required (not null)
            ArgumentNullException.ThrowIfNull(opportunityComment);
            OpportunityComment = opportunityComment;
            // to ensure "opportunityDate" is required (not null)
            ArgumentNullException.ThrowIfNull(opportunityDate);
            OpportunityDate = opportunityDate;
            // to ensure "opportunityLocation" is required (not null)
            ArgumentNullException.ThrowIfNull(opportunityLocation);
            OpportunityLocation = opportunityLocation;
            // to ensure "opportunityMemo" is required (not null)
            ArgumentNullException.ThrowIfNull(opportunityMemo);
            OpportunityMemo = opportunityMemo;
            // to ensure "opportunityNumber" is required (not null)
            ArgumentNullException.ThrowIfNull(opportunityNumber);
            OpportunityNumber = opportunityNumber;
            // to ensure "opportunityStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(opportunityStatus);
            OpportunityStatus = opportunityStatus;
            // to ensure "phone" is required (not null)
            ArgumentNullException.ThrowIfNull(phone);
            Phone = phone;
            // to ensure "priceTier" is required (not null)
            ArgumentNullException.ThrowIfNull(priceTier);
            PriceTier = priceTier;
            // to ensure "salesRepresentative" is required (not null)
            ArgumentNullException.ThrowIfNull(salesRepresentative);
            SalesRepresentative = salesRepresentative;
            // to ensure "shipToAddress1" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToAddress1);
            ShipToAddress1 = shipToAddress1;
            // to ensure "shipToAddress2" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToAddress2);
            ShipToAddress2 = shipToAddress2;
            // to ensure "shipToCity" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToCity);
            ShipToCity = shipToCity;
            // to ensure "shipToCompany" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToCompany);
            ShipToCompany = shipToCompany;
            // to ensure "shipToContact" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToContact);
            ShipToContact = shipToContact;
            // to ensure "shipToCountry" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToCountry);
            ShipToCountry = shipToCountry;
            ShipToOther = shipToOther;
            // to ensure "shipToPostCode" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToPostCode);
            ShipToPostCode = shipToPostCode;
            // to ensure "shipToState" is required (not null)
            ArgumentNullException.ThrowIfNull(shipToState);
            ShipToState = shipToState;
            // to ensure "shippingAddressLine1" is required (not null)
            ArgumentNullException.ThrowIfNull(shippingAddressLine1);
            ShippingAddressLine1 = shippingAddressLine1;
            // to ensure "shippingAddressLine2" is required (not null)
            ArgumentNullException.ThrowIfNull(shippingAddressLine2);
            ShippingAddressLine2 = shippingAddressLine2;
            TaxInclusive = taxInclusive;
            TaxPercent = taxPercent;
            // to ensure "taxRule" is required (not null)
            ArgumentNullException.ThrowIfNull(taxRule);
            TaxRule = taxRule;
            TaxTotal = taxTotal;
            TermDays = termDays;
            TermDueNextMonth = termDueNextMonth;
            TermMethod = termMethod;
            // to ensure "terms" is required (not null)
            ArgumentNullException.ThrowIfNull(terms);
            Terms = terms;
            Total = total;
        }

        /// <summary>
        /// Gets or Sets AdditionalCharges
        /// </summary>
        [DataMember(Name = "AdditionalCharges", IsRequired = true, EmitDefaultValue = true)]
        public List<CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInnerAdditionalChargesInner> AdditionalCharges { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddressLine1
        /// </summary>
        [DataMember(Name = "BillingAddressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string BillingAddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddressLine2
        /// </summary>
        [DataMember(Name = "BillingAddressLine2", IsRequired = true, EmitDefaultValue = true)]
        public string BillingAddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "Contact", IsRequired = true, EmitDefaultValue = true)]
        public string Contact { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "Currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversionRate
        /// </summary>
        [DataMember(Name = "CurrencyConversionRate", IsRequired = true, EmitDefaultValue = true)]
        public decimal CurrencyConversionRate { get; set; }

        /// <summary>
        /// Gets or Sets CustomField1
        /// </summary>
        [DataMember(Name = "CustomField1", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField1 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField10
        /// </summary>
        [DataMember(Name = "CustomField10", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField10 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField2
        /// </summary>
        [DataMember(Name = "CustomField2", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField2 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField3
        /// </summary>
        [DataMember(Name = "CustomField3", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField3 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField4
        /// </summary>
        [DataMember(Name = "CustomField4", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField4 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField5
        /// </summary>
        [DataMember(Name = "CustomField5", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField5 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField6
        /// </summary>
        [DataMember(Name = "CustomField6", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField6 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField7
        /// </summary>
        [DataMember(Name = "CustomField7", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField7 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField8
        /// </summary>
        [DataMember(Name = "CustomField8", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField8 { get; set; }

        /// <summary>
        /// Gets or Sets CustomField9
        /// </summary>
        [DataMember(Name = "CustomField9", IsRequired = true, EmitDefaultValue = true)]
        public string CustomField9 { get; set; }

        /// <summary>
        /// Gets or Sets CustomerCurrency
        /// </summary>
        [DataMember(Name = "CustomerCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerID
        /// </summary>
        [DataMember(Name = "CustomerID", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerID { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name = "CustomerName", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets CustomerReference
        /// </summary>
        [DataMember(Name = "CustomerReference", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAccount
        /// </summary>
        [DataMember(Name = "DefaultAccount", IsRequired = true, EmitDefaultValue = true)]
        public string DefaultAccount { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", IsRequired = true, EmitDefaultValue = true)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets LeadID
        /// </summary>
        [DataMember(Name = "LeadID", IsRequired = true, EmitDefaultValue = true)]
        public string LeadID { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", IsRequired = true, EmitDefaultValue = true)]
        public List<CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInnerLinesInner> Lines { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityComment
        /// </summary>
        [DataMember(Name = "OpportunityComment", IsRequired = true, EmitDefaultValue = true)]
        public string OpportunityComment { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityDate
        /// </summary>
        [DataMember(Name = "OpportunityDate", IsRequired = true, EmitDefaultValue = true)]
        public string OpportunityDate { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityLocation
        /// </summary>
        [DataMember(Name = "OpportunityLocation", IsRequired = true, EmitDefaultValue = true)]
        public string OpportunityLocation { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityMemo
        /// </summary>
        [DataMember(Name = "OpportunityMemo", IsRequired = true, EmitDefaultValue = true)]
        public string OpportunityMemo { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityNumber
        /// </summary>
        [DataMember(Name = "OpportunityNumber", IsRequired = true, EmitDefaultValue = true)]
        public string OpportunityNumber { get; set; }

        /// <summary>
        /// Gets or Sets OpportunityStatus
        /// </summary>
        [DataMember(Name = "OpportunityStatus", IsRequired = true, EmitDefaultValue = true)]
        public string OpportunityStatus { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "Phone", IsRequired = true, EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PriceTier
        /// </summary>
        [DataMember(Name = "PriceTier", IsRequired = true, EmitDefaultValue = true)]
        public string PriceTier { get; set; }

        /// <summary>
        /// Gets or Sets SalesRepresentative
        /// </summary>
        [DataMember(Name = "SalesRepresentative", IsRequired = true, EmitDefaultValue = true)]
        public string SalesRepresentative { get; set; }

        /// <summary>
        /// Gets or Sets ShipToAddress1
        /// </summary>
        [DataMember(Name = "ShipToAddress1", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToAddress1 { get; set; }

        /// <summary>
        /// Gets or Sets ShipToAddress2
        /// </summary>
        [DataMember(Name = "ShipToAddress2", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToAddress2 { get; set; }

        /// <summary>
        /// Gets or Sets ShipToCity
        /// </summary>
        [DataMember(Name = "ShipToCity", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToCity { get; set; }

        /// <summary>
        /// Gets or Sets ShipToCompany
        /// </summary>
        [DataMember(Name = "ShipToCompany", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToCompany { get; set; }

        /// <summary>
        /// Gets or Sets ShipToContact
        /// </summary>
        [DataMember(Name = "ShipToContact", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToContact { get; set; }

        /// <summary>
        /// Gets or Sets ShipToCountry
        /// </summary>
        [DataMember(Name = "ShipToCountry", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToCountry { get; set; }

        /// <summary>
        /// Gets or Sets ShipToOther
        /// </summary>
        [DataMember(Name = "ShipToOther", IsRequired = true, EmitDefaultValue = true)]
        public bool ShipToOther { get; set; }

        /// <summary>
        /// Gets or Sets ShipToPostCode
        /// </summary>
        [DataMember(Name = "ShipToPostCode", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToPostCode { get; set; }

        /// <summary>
        /// Gets or Sets ShipToState
        /// </summary>
        [DataMember(Name = "ShipToState", IsRequired = true, EmitDefaultValue = true)]
        public string ShipToState { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddressLine1
        /// </summary>
        [DataMember(Name = "ShippingAddressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string ShippingAddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddressLine2
        /// </summary>
        [DataMember(Name = "ShippingAddressLine2", IsRequired = true, EmitDefaultValue = true)]
        public string ShippingAddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets TaxInclusive
        /// </summary>
        [DataMember(Name = "TaxInclusive", IsRequired = true, EmitDefaultValue = true)]
        public bool TaxInclusive { get; set; }

        /// <summary>
        /// Gets or Sets TaxPercent
        /// </summary>
        [DataMember(Name = "TaxPercent", IsRequired = true, EmitDefaultValue = true)]
        public decimal TaxPercent { get; set; }

        /// <summary>
        /// Gets or Sets TaxRule
        /// </summary>
        [DataMember(Name = "TaxRule", IsRequired = true, EmitDefaultValue = true)]
        public string TaxRule { get; set; }

        /// <summary>
        /// Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name = "TaxTotal", IsRequired = true, EmitDefaultValue = true)]
        public decimal TaxTotal { get; set; }

        /// <summary>
        /// Gets or Sets TermDays
        /// </summary>
        [DataMember(Name = "TermDays", IsRequired = true, EmitDefaultValue = true)]
        public decimal TermDays { get; set; }

        /// <summary>
        /// Gets or Sets TermDueNextMonth
        /// </summary>
        [DataMember(Name = "TermDueNextMonth", IsRequired = true, EmitDefaultValue = true)]
        public decimal TermDueNextMonth { get; set; }

        /// <summary>
        /// Gets or Sets TermMethod
        /// </summary>
        [DataMember(Name = "TermMethod", IsRequired = true, EmitDefaultValue = true)]
        public decimal TermMethod { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name = "Terms", IsRequired = true, EmitDefaultValue = true)]
        public string Terms { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "Total", IsRequired = true, EmitDefaultValue = true)]
        public decimal Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class CrmOpportunityPgLmtIdModifiedsinceGet200ResponseOpportunityListInner {\n");
            sb.Append("  AdditionalCharges: ").Append(AdditionalCharges).Append('\n');
            sb.Append("  BillingAddressLine1: ").Append(BillingAddressLine1).Append('\n');
            sb.Append("  BillingAddressLine2: ").Append(BillingAddressLine2).Append('\n');
            sb.Append("  Contact: ").Append(Contact).Append('\n');
            sb.Append("  Currency: ").Append(Currency).Append('\n');
            sb.Append("  CurrencyConversionRate: ").Append(CurrencyConversionRate).Append('\n');
            sb.Append("  CustomField1: ").Append(CustomField1).Append('\n');
            sb.Append("  CustomField10: ").Append(CustomField10).Append('\n');
            sb.Append("  CustomField2: ").Append(CustomField2).Append('\n');
            sb.Append("  CustomField3: ").Append(CustomField3).Append('\n');
            sb.Append("  CustomField4: ").Append(CustomField4).Append('\n');
            sb.Append("  CustomField5: ").Append(CustomField5).Append('\n');
            sb.Append("  CustomField6: ").Append(CustomField6).Append('\n');
            sb.Append("  CustomField7: ").Append(CustomField7).Append('\n');
            sb.Append("  CustomField8: ").Append(CustomField8).Append('\n');
            sb.Append("  CustomField9: ").Append(CustomField9).Append('\n');
            sb.Append("  CustomerCurrency: ").Append(CustomerCurrency).Append('\n');
            sb.Append("  CustomerID: ").Append(CustomerID).Append('\n');
            sb.Append("  CustomerName: ").Append(CustomerName).Append('\n');
            sb.Append("  CustomerReference: ").Append(CustomerReference).Append('\n');
            sb.Append("  DefaultAccount: ").Append(DefaultAccount).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  LeadID: ").Append(LeadID).Append('\n');
            sb.Append("  Lines: ").Append(Lines).Append('\n');
            sb.Append("  OpportunityComment: ").Append(OpportunityComment).Append('\n');
            sb.Append("  OpportunityDate: ").Append(OpportunityDate).Append('\n');
            sb.Append("  OpportunityLocation: ").Append(OpportunityLocation).Append('\n');
            sb.Append("  OpportunityMemo: ").Append(OpportunityMemo).Append('\n');
            sb.Append("  OpportunityNumber: ").Append(OpportunityNumber).Append('\n');
            sb.Append("  OpportunityStatus: ").Append(OpportunityStatus).Append('\n');
            sb.Append("  Phone: ").Append(Phone).Append('\n');
            sb.Append("  PriceTier: ").Append(PriceTier).Append('\n');
            sb.Append("  SalesRepresentative: ").Append(SalesRepresentative).Append('\n');
            sb.Append("  ShipToAddress1: ").Append(ShipToAddress1).Append('\n');
            sb.Append("  ShipToAddress2: ").Append(ShipToAddress2).Append('\n');
            sb.Append("  ShipToCity: ").Append(ShipToCity).Append('\n');
            sb.Append("  ShipToCompany: ").Append(ShipToCompany).Append('\n');
            sb.Append("  ShipToContact: ").Append(ShipToContact).Append('\n');
            sb.Append("  ShipToCountry: ").Append(ShipToCountry).Append('\n');
            sb.Append("  ShipToOther: ").Append(ShipToOther).Append('\n');
            sb.Append("  ShipToPostCode: ").Append(ShipToPostCode).Append('\n');
            sb.Append("  ShipToState: ").Append(ShipToState).Append('\n');
            sb.Append("  ShippingAddressLine1: ").Append(ShippingAddressLine1).Append('\n');
            sb.Append("  ShippingAddressLine2: ").Append(ShippingAddressLine2).Append('\n');
            sb.Append("  TaxInclusive: ").Append(TaxInclusive).Append('\n');
            sb.Append("  TaxPercent: ").Append(TaxPercent).Append('\n');
            sb.Append("  TaxRule: ").Append(TaxRule).Append('\n');
            sb.Append("  TaxTotal: ").Append(TaxTotal).Append('\n');
            sb.Append("  TermDays: ").Append(TermDays).Append('\n');
            sb.Append("  TermDueNextMonth: ").Append(TermDueNextMonth).Append('\n');
            sb.Append("  TermMethod: ").Append(TermMethod).Append('\n');
            sb.Append("  Terms: ").Append(Terms).Append('\n');
            sb.Append("  Total: ").Append(Total).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}