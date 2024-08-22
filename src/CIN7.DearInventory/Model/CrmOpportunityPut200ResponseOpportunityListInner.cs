/*
 * Cin7 Core Developer Portal
 *
 * ## API introduction  Cin7 Core Inventory API is part of Cin7 Core Inventory web application at https://inventory.dearsystems.com.  <b>You will need to:</b>  + Create an account there before you can use the API.  + Trial accounts are also allowed to access the API.  The API URL is https://inventory.dearsystems.com/externalapi/v2/. To call any API endpoint (method) you must append the endpoint name and parameters to the API URL. eg: https://inventory.dearsystems.com/externalapi/v2/me  <i>Note: The API accepts only JSON data format.</i>  Never assume that the API is actually online at any time. Always queue requests to the API so that you can retry the request in the event of a network failure: even if our server is up 24/7 forever, the network will not be. Consider what happens in the case of a network interruption, eg the cable gets cut by road workers yet again. You should always plan to add all requests to a queue so that they can be tried again in the event of any failure.  Full documentation of each endpoint is available on that endpoint's help page. This includes the operations supported and the full list of available fields with:  + Name  + Type  + Length  + Required values  Use our API Explorer to see examples of each data object.  Cin7 Core Inventory API is a subset of the functionality available through Cin7 Core Inventory UI - check the API documentation to see if the functionality you require is available in the API.  In the event of errors, the API will return an appropriate HTML status code, and an error message. You will need to read both the status code and the error message to establish the cause. Typical error messages are shown on the API status codes page.  ## Connecting to the API  To use the API you will need your Cin7 Core Account ID and API Application key. These can be created on the API setup page inside Cin7 Core Inventory application: https://inventory.dearsystems.com/ExternalAPI.  Each company that you have access to in Cin7 Core Inventory will have a different Cin7 Core Account ID. You can have multiple API Applications created on the same Cin7 Core account. This allows you to link different applications/add-ons to Cin7 Core, since API limits are applied on per API Application basis.  Your Account ID and API Application Key are equivalent to a login and password. They must be kept secret and not shared in any way.  Each request to the API must include these two values sent as HTTP headers:  + api-auth-accountid - You must send your Account ID in this header.  + api-auth-applicationkey - You must send API Application Key in this header.  PHP sample:  ```PHP  $account_id = 'api-auth-accountid: youraccountid'; $application_key = 'api-auth-applicationkey: applicationkey'; $naked_dear_url = 'https://inventory.dearsystems.com/ExternalApi/v2/SaleList';  $data = array ('Page' => '1', 'Limit' => '100'); $data = http_build_query($data);  $ch = curl_init(); curl_setopt($ch, CURLOPT_URL,$naked_dear_url.\"?\".$data); //GET API CALL curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);  $headers = [ \"Content-type: application/json\", $account_id, $application_key ];  curl_setopt($ch, CURLOPT_HTTPHEADER, $headers); $server_output = curl_exec ($ch); curl_close ($ch);  print $server_output ;   ```  ## Pagination  <h4>What is Pagination?</h4>  Pagination is the process of dividing content into discrete pages.  The benefit of pagination is that it allows for faster response times to requests against large datasets like Customers, Products and Invoices, thus providing a more responsive and flexible API for your mission-critical applications.  Cin7 Core Inventory API currently uses pagination on the following endpoints:  + SaleList  + PurchaseList  + StockAdjustmentList  + StockTakeList  + StockTransferList  + Product  + Сategory  All remaining API endpoints do not support pagination.  <h4>Requesting a page</h4>  Pages are requested by adding page parameter to URL: https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}, where {endpoint} and {pagenumber} are placeholders.  For example, if you wanted to retrieve the 3rd page of 100 records from the Products endpoint we would write https://inventory.dearsystems.com/ExternalApi/v2/Product?page=3.  <h4>Page size</h4>  The default page size is 100 records, but is configurable by adding the desired page size in the URL querystring, https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}&limit={pagesize}.  The minimum page size is 1 and the maximum page size is 1000 records.  If you want to retrieve the 5th page of 200 ProductAvailability records (ie. 1001st to 1500th record) then you would use this URL: https://inventory.dearsystems.com/ExternalApi/v2/Product?page=5&limit=200.  <h4>Pagination info</h4>  In the endpoints that support Pagination additional parameter Total is returned with every API call response to provide information regarding how many records there are overall. Below is an example of this structure in JSON for Products endpoint.  { \"Products\":[{...}], \"Total\":41}  ## API Status Codes  |Status Code|Description| |:- -- --|- -- -- -- -- --| |`200 OK`|Operation was successful| |`204 No Content`|Operation was successful and there is no content to return| |`400 Bad Request`|The request was not in a correct form, or the posted data failed a validation test. Check the error returned to see what was wrong with the request.| |`403 Forbidden`|Method authentication failed| |`404 Not found`|Endpoint does not exist (eg using /Products instead of /Product)| |`405 Not allowed`|The method used is not allowed (eg PUT, DELETE)| |`500 Internal Server Error`|The object passed to the API could not be parsed or some unexpected error occurred in Cin7 Core while processing API request| |`503 Service Unavailable`|You reached 60 calls per minute API limit|  ## Date Format  All date fields in Cin7 Core API (including parameters) are in ISO 8601 format and specifying UTC date: yyyy-MM-ddTHH:mm:ss.fff     e.g. 2012-11-14T13:28:33.363  ## Previous API version  Previous API version's description is available here: http://support.dearsystems.com/solution/folders/1000134185
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace CIN7.DearInventory.Model
{
    /// <summary>
    /// CrmOpportunityPut200ResponseOpportunityListInner
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="CrmOpportunityPut200ResponseOpportunityListInner" /> class.
    /// </remarks>
    /// <param name="additionalCharges">additionalCharges.</param>
    /// <param name="billingAddressLine1">billingAddressLine1.</param>
    /// <param name="billingAddressLine2">billingAddressLine2.</param>
    /// <param name="contact">contact.</param>
    /// <param name="currency">currency.</param>
    /// <param name="currencyConversionRate">currencyConversionRate.</param>
    /// <param name="customField1">customField1.</param>
    /// <param name="customField10">customField10.</param>
    /// <param name="customField2">customField2.</param>
    /// <param name="customField3">customField3.</param>
    /// <param name="customField4">customField4.</param>
    /// <param name="customField5">customField5.</param>
    /// <param name="customField6">customField6.</param>
    /// <param name="customField7">customField7.</param>
    /// <param name="customField8">customField8.</param>
    /// <param name="customField9">customField9.</param>
    /// <param name="customerCurrency">customerCurrency.</param>
    /// <param name="customerID">customerID.</param>
    /// <param name="customerName">customerName.</param>
    /// <param name="customerReference">customerReference.</param>
    /// <param name="defaultAccount">defaultAccount.</param>
    /// <param name="iD">iD.</param>
    /// <param name="leadID">leadID.</param>
    /// <param name="lines">lines.</param>
    /// <param name="opportunityComment">opportunityComment.</param>
    /// <param name="opportunityDate">opportunityDate.</param>
    /// <param name="opportunityLocation">opportunityLocation.</param>
    /// <param name="opportunityMemo">opportunityMemo.</param>
    /// <param name="opportunityNumber">opportunityNumber.</param>
    /// <param name="opportunityStatus">opportunityStatus.</param>
    /// <param name="phone">phone.</param>
    /// <param name="priceTier">priceTier.</param>
    /// <param name="salesRepresentative">salesRepresentative.</param>
    /// <param name="shipToAddress1">shipToAddress1.</param>
    /// <param name="shipToAddress2">shipToAddress2.</param>
    /// <param name="shipToCity">shipToCity.</param>
    /// <param name="shipToCompany">shipToCompany.</param>
    /// <param name="shipToContact">shipToContact.</param>
    /// <param name="shipToCountry">shipToCountry.</param>
    /// <param name="shipToOther">shipToOther.</param>
    /// <param name="shipToPostCode">shipToPostCode.</param>
    /// <param name="shipToState">shipToState.</param>
    /// <param name="shippingAddressLine1">shippingAddressLine1.</param>
    /// <param name="shippingAddressLine2">shippingAddressLine2.</param>
    /// <param name="taxInclusive">taxInclusive.</param>
    /// <param name="taxPercent">taxPercent.</param>
    /// <param name="taxRule">taxRule.</param>
    /// <param name="taxTotal">taxTotal.</param>
    /// <param name="termDays">termDays.</param>
    /// <param name="termDueNextMonth">termDueNextMonth.</param>
    /// <param name="termMethod">termMethod.</param>
    /// <param name="terms">terms.</param>
    /// <param name="total">total.</param>
    [DataContract(Name = "crmOpportunity_put_200_response_opportunityList_inner")]
    public partial class CrmOpportunityPut200ResponseOpportunityListInner(List<CrmOpportunityPut200ResponseOpportunityListInnerAdditionalChargesInner> additionalCharges = default, string billingAddressLine1 = default, string billingAddressLine2 = default, string contact = default, string currency = default, decimal currencyConversionRate = default, string customField1 = default, string customField10 = default, string customField2 = default, string customField3 = default, string customField4 = default, string customField5 = default, string customField6 = default, string customField7 = default, string customField8 = default, string customField9 = default, string customerCurrency = default, string customerID = default, string customerName = default, string customerReference = default, string defaultAccount = default, string iD = default, object leadID = default, List<CrmOpportunityPut200ResponseOpportunityListInnerLinesInner> lines = default, string opportunityComment = default, string opportunityDate = default, string opportunityLocation = default, string opportunityMemo = default, string opportunityNumber = default, string opportunityStatus = default, string phone = default, string priceTier = default, string salesRepresentative = default, string shipToAddress1 = default, string shipToAddress2 = default, string shipToCity = default, string shipToCompany = default, string shipToContact = default, string shipToCountry = default, bool shipToOther = default, string shipToPostCode = default, string shipToState = default, string shippingAddressLine1 = default, string shippingAddressLine2 = default, bool taxInclusive = default, decimal taxPercent = default, string taxRule = default, decimal taxTotal = default, decimal termDays = default, decimal termDueNextMonth = default, decimal termMethod = default, string terms = default, decimal total = default) : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AdditionalCharges
        /// </summary>
        [DataMember(Name = "AdditionalCharges", EmitDefaultValue = false)]
        public List<CrmOpportunityPut200ResponseOpportunityListInnerAdditionalChargesInner> AdditionalCharges { get; set; } = additionalCharges;

        /// <summary>
        /// Gets or Sets BillingAddressLine1
        /// </summary>
        [DataMember(Name = "BillingAddressLine1", EmitDefaultValue = false)]
        public string BillingAddressLine1 { get; set; } = billingAddressLine1;

        /// <summary>
        /// Gets or Sets BillingAddressLine2
        /// </summary>
        [DataMember(Name = "BillingAddressLine2", EmitDefaultValue = false)]
        public string BillingAddressLine2 { get; set; } = billingAddressLine2;

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "Contact", EmitDefaultValue = false)]
        public string Contact { get; set; } = contact;

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "Currency", EmitDefaultValue = false)]
        public string Currency { get; set; } = currency;

        /// <summary>
        /// Gets or Sets CurrencyConversionRate
        /// </summary>
        [DataMember(Name = "CurrencyConversionRate", EmitDefaultValue = false)]
        public decimal CurrencyConversionRate { get; set; } = currencyConversionRate;

        /// <summary>
        /// Gets or Sets CustomField1
        /// </summary>
        [DataMember(Name = "CustomField1", EmitDefaultValue = false)]
        public string CustomField1 { get; set; } = customField1;

        /// <summary>
        /// Gets or Sets CustomField10
        /// </summary>
        [DataMember(Name = "CustomField10", EmitDefaultValue = false)]
        public string CustomField10 { get; set; } = customField10;

        /// <summary>
        /// Gets or Sets CustomField2
        /// </summary>
        [DataMember(Name = "CustomField2", EmitDefaultValue = false)]
        public string CustomField2 { get; set; } = customField2;

        /// <summary>
        /// Gets or Sets CustomField3
        /// </summary>
        [DataMember(Name = "CustomField3", EmitDefaultValue = false)]
        public string CustomField3 { get; set; } = customField3;

        /// <summary>
        /// Gets or Sets CustomField4
        /// </summary>
        [DataMember(Name = "CustomField4", EmitDefaultValue = false)]
        public string CustomField4 { get; set; } = customField4;

        /// <summary>
        /// Gets or Sets CustomField5
        /// </summary>
        [DataMember(Name = "CustomField5", EmitDefaultValue = false)]
        public string CustomField5 { get; set; } = customField5;

        /// <summary>
        /// Gets or Sets CustomField6
        /// </summary>
        [DataMember(Name = "CustomField6", EmitDefaultValue = false)]
        public string CustomField6 { get; set; } = customField6;

        /// <summary>
        /// Gets or Sets CustomField7
        /// </summary>
        [DataMember(Name = "CustomField7", EmitDefaultValue = false)]
        public string CustomField7 { get; set; } = customField7;

        /// <summary>
        /// Gets or Sets CustomField8
        /// </summary>
        [DataMember(Name = "CustomField8", EmitDefaultValue = false)]
        public string CustomField8 { get; set; } = customField8;

        /// <summary>
        /// Gets or Sets CustomField9
        /// </summary>
        [DataMember(Name = "CustomField9", EmitDefaultValue = false)]
        public string CustomField9 { get; set; } = customField9;

        /// <summary>
        /// Gets or Sets CustomerCurrency
        /// </summary>
        [DataMember(Name = "CustomerCurrency", EmitDefaultValue = false)]
        public string CustomerCurrency { get; set; } = customerCurrency;

        /// <summary>
        /// Gets or Sets CustomerID
        /// </summary>
        [DataMember(Name = "CustomerID", EmitDefaultValue = false)]
        public string CustomerID { get; set; } = customerID;

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name = "CustomerName", EmitDefaultValue = false)]
        public string CustomerName { get; set; } = customerName;

        /// <summary>
        /// Gets or Sets CustomerReference
        /// </summary>
        [DataMember(Name = "CustomerReference", EmitDefaultValue = false)]
        public string CustomerReference { get; set; } = customerReference;

        /// <summary>
        /// Gets or Sets DefaultAccount
        /// </summary>
        [DataMember(Name = "DefaultAccount", EmitDefaultValue = false)]
        public string DefaultAccount { get; set; } = defaultAccount;

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; } = iD;

        /// <summary>
        /// Gets or Sets LeadID
        /// </summary>
        [DataMember(Name = "LeadID", EmitDefaultValue = true)]
        public object LeadID { get; set; } = leadID;

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", EmitDefaultValue = false)]
        public List<CrmOpportunityPut200ResponseOpportunityListInnerLinesInner> Lines { get; set; } = lines;

        /// <summary>
        /// Gets or Sets OpportunityComment
        /// </summary>
        [DataMember(Name = "OpportunityComment", EmitDefaultValue = false)]
        public string OpportunityComment { get; set; } = opportunityComment;

        /// <summary>
        /// Gets or Sets OpportunityDate
        /// </summary>
        [DataMember(Name = "OpportunityDate", EmitDefaultValue = false)]
        public string OpportunityDate { get; set; } = opportunityDate;

        /// <summary>
        /// Gets or Sets OpportunityLocation
        /// </summary>
        [DataMember(Name = "OpportunityLocation", EmitDefaultValue = false)]
        public string OpportunityLocation { get; set; } = opportunityLocation;

        /// <summary>
        /// Gets or Sets OpportunityMemo
        /// </summary>
        [DataMember(Name = "OpportunityMemo", EmitDefaultValue = false)]
        public string OpportunityMemo { get; set; } = opportunityMemo;

        /// <summary>
        /// Gets or Sets OpportunityNumber
        /// </summary>
        [DataMember(Name = "OpportunityNumber", EmitDefaultValue = false)]
        public string OpportunityNumber { get; set; } = opportunityNumber;

        /// <summary>
        /// Gets or Sets OpportunityStatus
        /// </summary>
        [DataMember(Name = "OpportunityStatus", EmitDefaultValue = false)]
        public string OpportunityStatus { get; set; } = opportunityStatus;

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "Phone", EmitDefaultValue = false)]
        public string Phone { get; set; } = phone;

        /// <summary>
        /// Gets or Sets PriceTier
        /// </summary>
        [DataMember(Name = "PriceTier", EmitDefaultValue = false)]
        public string PriceTier { get; set; } = priceTier;

        /// <summary>
        /// Gets or Sets SalesRepresentative
        /// </summary>
        [DataMember(Name = "SalesRepresentative", EmitDefaultValue = false)]
        public string SalesRepresentative { get; set; } = salesRepresentative;

        /// <summary>
        /// Gets or Sets ShipToAddress1
        /// </summary>
        [DataMember(Name = "ShipToAddress1", EmitDefaultValue = false)]
        public string ShipToAddress1 { get; set; } = shipToAddress1;

        /// <summary>
        /// Gets or Sets ShipToAddress2
        /// </summary>
        [DataMember(Name = "ShipToAddress2", EmitDefaultValue = false)]
        public string ShipToAddress2 { get; set; } = shipToAddress2;

        /// <summary>
        /// Gets or Sets ShipToCity
        /// </summary>
        [DataMember(Name = "ShipToCity", EmitDefaultValue = false)]
        public string ShipToCity { get; set; } = shipToCity;

        /// <summary>
        /// Gets or Sets ShipToCompany
        /// </summary>
        [DataMember(Name = "ShipToCompany", EmitDefaultValue = false)]
        public string ShipToCompany { get; set; } = shipToCompany;

        /// <summary>
        /// Gets or Sets ShipToContact
        /// </summary>
        [DataMember(Name = "ShipToContact", EmitDefaultValue = false)]
        public string ShipToContact { get; set; } = shipToContact;

        /// <summary>
        /// Gets or Sets ShipToCountry
        /// </summary>
        [DataMember(Name = "ShipToCountry", EmitDefaultValue = false)]
        public string ShipToCountry { get; set; } = shipToCountry;

        /// <summary>
        /// Gets or Sets ShipToOther
        /// </summary>
        [DataMember(Name = "ShipToOther", EmitDefaultValue = true)]
        public bool ShipToOther { get; set; } = shipToOther;

        /// <summary>
        /// Gets or Sets ShipToPostCode
        /// </summary>
        [DataMember(Name = "ShipToPostCode", EmitDefaultValue = false)]
        public string ShipToPostCode { get; set; } = shipToPostCode;

        /// <summary>
        /// Gets or Sets ShipToState
        /// </summary>
        [DataMember(Name = "ShipToState", EmitDefaultValue = false)]
        public string ShipToState { get; set; } = shipToState;

        /// <summary>
        /// Gets or Sets ShippingAddressLine1
        /// </summary>
        [DataMember(Name = "ShippingAddressLine1", EmitDefaultValue = false)]
        public string ShippingAddressLine1 { get; set; } = shippingAddressLine1;

        /// <summary>
        /// Gets or Sets ShippingAddressLine2
        /// </summary>
        [DataMember(Name = "ShippingAddressLine2", EmitDefaultValue = false)]
        public string ShippingAddressLine2 { get; set; } = shippingAddressLine2;

        /// <summary>
        /// Gets or Sets TaxInclusive
        /// </summary>
        [DataMember(Name = "TaxInclusive", EmitDefaultValue = true)]
        public bool TaxInclusive { get; set; } = taxInclusive;

        /// <summary>
        /// Gets or Sets TaxPercent
        /// </summary>
        [DataMember(Name = "TaxPercent", EmitDefaultValue = false)]
        public decimal TaxPercent { get; set; } = taxPercent;

        /// <summary>
        /// Gets or Sets TaxRule
        /// </summary>
        [DataMember(Name = "TaxRule", EmitDefaultValue = false)]
        public string TaxRule { get; set; } = taxRule;

        /// <summary>
        /// Gets or Sets TaxTotal
        /// </summary>
        [DataMember(Name = "TaxTotal", EmitDefaultValue = false)]
        public decimal TaxTotal { get; set; } = taxTotal;

        /// <summary>
        /// Gets or Sets TermDays
        /// </summary>
        [DataMember(Name = "TermDays", EmitDefaultValue = false)]
        public decimal TermDays { get; set; } = termDays;

        /// <summary>
        /// Gets or Sets TermDueNextMonth
        /// </summary>
        [DataMember(Name = "TermDueNextMonth", EmitDefaultValue = false)]
        public decimal TermDueNextMonth { get; set; } = termDueNextMonth;

        /// <summary>
        /// Gets or Sets TermMethod
        /// </summary>
        [DataMember(Name = "TermMethod", EmitDefaultValue = false)]
        public decimal TermMethod { get; set; } = termMethod;

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name = "Terms", EmitDefaultValue = false)]
        public string Terms { get; set; } = terms;

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "Total", EmitDefaultValue = false)]
        public decimal Total { get; set; } = total;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class CrmOpportunityPut200ResponseOpportunityListInner {\n");
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