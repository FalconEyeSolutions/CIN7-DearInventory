/*
 * Cin7 Core Developer Portal
 *
 * ## API introduction  Cin7 Core Inventory API is part of Cin7 Core Inventory web application at https://inventory.dearsystems.com.  <b>You will need to:</b>  + Create an account there before you can use the API.  + Trial accounts are also allowed to access the API.  The API URL is https://inventory.dearsystems.com/externalapi/v2/. To call any API endpoint (method) you must append the endpoint name and parameters to the API URL. eg: https://inventory.dearsystems.com/externalapi/v2/me  <i>Note: The API accepts only JSON data format.</i>  Never assume that the API is actually online at any time. Always queue requests to the API so that you can retry the request in the event of a network failure: even if our server is up 24/7 forever, the network will not be. Consider what happens in the case of a network interruption, eg the cable gets cut by road workers yet again. You should always plan to add all requests to a queue so that they can be tried again in the event of any failure.  Full documentation of each endpoint is available on that endpoint's help page. This includes the operations supported and the full list of available fields with:  + Name  + Type  + Length  + Required values  Use our API Explorer to see examples of each data object.  Cin7 Core Inventory API is a subset of the functionality available through Cin7 Core Inventory UI - check the API documentation to see if the functionality you require is available in the API.  In the event of errors, the API will return an appropriate HTML status code, and an error message. You will need to read both the status code and the error message to establish the cause. Typical error messages are shown on the API status codes page.  ## Connecting to the API  To use the API you will need your Cin7 Core Account ID and API Application key. These can be created on the API setup page inside Cin7 Core Inventory application: https://inventory.dearsystems.com/ExternalAPI.  Each company that you have access to in Cin7 Core Inventory will have a different Cin7 Core Account ID. You can have multiple API Applications created on the same Cin7 Core account. This allows you to link different applications/add-ons to Cin7 Core, since API limits are applied on per API Application basis.  Your Account ID and API Application Key are equivalent to a login and password. They must be kept secret and not shared in any way.  Each request to the API must include these two values sent as HTTP headers:  + api-auth-accountid - You must send your Account ID in this header.  + api-auth-applicationkey - You must send API Application Key in this header.  PHP sample:  ```PHP  $account_id = 'api-auth-accountid: youraccountid'; $application_key = 'api-auth-applicationkey: applicationkey'; $naked_dear_url = 'https://inventory.dearsystems.com/ExternalApi/v2/SaleList';  $data = array ('Page' => '1', 'Limit' => '100'); $data = http_build_query($data);  $ch = curl_init(); curl_setopt($ch, CURLOPT_URL,$naked_dear_url.\"?\".$data); //GET API CALL curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);  $headers = [ \"Content-type: application/json\", $account_id, $application_key ];  curl_setopt($ch, CURLOPT_HTTPHEADER, $headers); $server_output = curl_exec ($ch); curl_close ($ch);  print $server_output ;   ```  ## Pagination  <h4>What is Pagination?</h4>  Pagination is the process of dividing content into discrete pages.  The benefit of pagination is that it allows for faster response times to requests against large datasets like Customers, Products and Invoices, thus providing a more responsive and flexible API for your mission-critical applications.  Cin7 Core Inventory API currently uses pagination on the following endpoints:  + SaleList  + PurchaseList  + StockAdjustmentList  + StockTakeList  + StockTransferList  + Product  + Сategory  All remaining API endpoints do not support pagination.  <h4>Requesting a page</h4>  Pages are requested by adding page parameter to URL: https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}, where {endpoint} and {pagenumber} are placeholders.  For example, if you wanted to retrieve the 3rd page of 100 records from the Products endpoint we would write https://inventory.dearsystems.com/ExternalApi/v2/Product?page=3.  <h4>Page size</h4>  The default page size is 100 records, but is configurable by adding the desired page size in the URL querystring, https://inventory.dearsystems.com/ExternalApi/v2/{endpoint}?page={pagenumber}&limit={pagesize}.  The minimum page size is 1 and the maximum page size is 1000 records.  If you want to retrieve the 5th page of 200 ProductAvailability records (ie. 1001st to 1500th record) then you would use this URL: https://inventory.dearsystems.com/ExternalApi/v2/Product?page=5&limit=200.  <h4>Pagination info</h4>  In the endpoints that support Pagination additional parameter Total is returned with every API call response to provide information regarding how many records there are overall. Below is an example of this structure in JSON for Products endpoint.  { \"Products\":[{...}], \"Total\":41}  ## API Status Codes  |Status Code|Description| |:- -- --|- -- -- -- -- --| |`200 OK`|Operation was successful| |`204 No Content`|Operation was successful and there is no content to return| |`400 Bad Request`|The request was not in a correct form, or the posted data failed a validation test. Check the error returned to see what was wrong with the request.| |`403 Forbidden`|Method authentication failed| |`404 Not found`|Endpoint does not exist (eg using /Products instead of /Product)| |`405 Not allowed`|The method used is not allowed (eg PUT, DELETE)| |`500 Internal Server Error`|The object passed to the API could not be parsed or some unexpected error occurred in Cin7 Core while processing API request| |`503 Service Unavailable`|You reached 60 calls per minute API limit|  ## Date Format  All date fields in Cin7 Core API (including parameters) are in ISO 8601 format and specifying UTC date: yyyy-MM-ddTHH:mm:ss.fff     e.g. 2012-11-14T13:28:33.363  ## Previous API version  Previous API version's description is available here: http://support.dearsystems.com/solution/folders/1000134185
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CIN7.DearInventory.Client.OpenAPIDateConverter;

namespace CIN7.DearInventory.Model
{
    /// <summary>
    /// SalePost200Response
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="SalePost200Response" /> class.
    /// </remarks>
    /// <param name="additionalAttributes">additionalAttributes.</param>
    /// <param name="attachments">attachments.</param>
    /// <param name="baseCurrency">baseCurrency.</param>
    /// <param name="billingAddress">billingAddress.</param>
    /// <param name="cOGSAmount">cOGSAmount.</param>
    /// <param name="carrier">carrier.</param>
    /// <param name="combinedInvoiceStatus">combinedInvoiceStatus.</param>
    /// <param name="combinedPackingStatus">combinedPackingStatus.</param>
    /// <param name="combinedPaymentStatus">combinedPaymentStatus.</param>
    /// <param name="combinedPickingStatus">combinedPickingStatus.</param>
    /// <param name="combinedShippingStatus">combinedShippingStatus.</param>
    /// <param name="combinedTrackingNumbers">combinedTrackingNumbers.</param>
    /// <param name="contact">contact.</param>
    /// <param name="creditNotes">creditNotes.</param>
    /// <param name="currencyRate">currencyRate.</param>
    /// <param name="customer">customer.</param>
    /// <param name="customerCurrency">customerCurrency.</param>
    /// <param name="customerID">customerID.</param>
    /// <param name="customerReference">customerReference.</param>
    /// <param name="defaultAccount">defaultAccount.</param>
    /// <param name="email">email.</param>
    /// <param name="externalID">externalID.</param>
    /// <param name="fulFilmentStatus">fulFilmentStatus.</param>
    /// <param name="fulfilments">fulfilments.</param>
    /// <param name="iD">iD.</param>
    /// <param name="inventoryMovements">inventoryMovements.</param>
    /// <param name="invoices">invoices.</param>
    /// <param name="lastModifiedOn">lastModifiedOn.</param>
    /// <param name="location">location.</param>
    /// <param name="manualJournals">manualJournals.</param>
    /// <param name="note">note.</param>
    /// <param name="order">order.</param>
    /// <param name="phone">phone.</param>
    /// <param name="priceTier">priceTier.</param>
    /// <param name="quote">quote.</param>
    /// <param name="saleOrderDate">saleOrderDate.</param>
    /// <param name="salesRepresentative">salesRepresentative.</param>
    /// <param name="serviceOnly">serviceOnly.</param>
    /// <param name="shipBy">shipBy.</param>
    /// <param name="shippingAddress">shippingAddress.</param>
    /// <param name="shippingNotes">shippingNotes.</param>
    /// <param name="skipQuote">skipQuote.</param>
    /// <param name="sourceChannel">sourceChannel.</param>
    /// <param name="status">status.</param>
    /// <param name="taxCalculation">taxCalculation.</param>
    /// <param name="taxRule">taxRule.</param>
    /// <param name="terms">terms.</param>
    /// <param name="type">type.</param>
    [DataContract(Name = "sale_post_200_response")]
    public partial class SalePost200Response(AdvancedPurchasePutRequestAdditionalAttributes additionalAttributes = default, List<JournalPgLmtTaskidStsSrchGet200ResponseJournalsInnerAttachmentsInner> attachments = default, string baseCurrency = default, AdvancedPurchaseIdCombineadditionalchargesGet200ResponseBillingAddress billingAddress = default, decimal cOGSAmount = default, string carrier = default, string combinedInvoiceStatus = default, string combinedPackingStatus = default, string combinedPaymentStatus = default, string combinedPickingStatus = default, string combinedShippingStatus = default, string combinedTrackingNumbers = default, string contact = default, List<SalePut200ResponseCreditNotesInner> creditNotes = default, decimal currencyRate = default, string customer = default, string customerCurrency = default, string customerID = default, string customerReference = default, string defaultAccount = default, string email = default, object externalID = default, string fulFilmentStatus = default, List<SalePut200ResponseFulfilmentsInner> fulfilments = default, string iD = default, List<PurchaseIdCombineadditionalchargesGet200ResponseInventoryMovementsInner> inventoryMovements = default, List<SalePut200ResponseInvoicesInner> invoices = default, string lastModifiedOn = default, string location = default, PurchasePut200ResponseCreditNoteUnstock manualJournals = default, string note = default, SalePut200ResponseOrder order = default, string phone = default, string priceTier = default, SalePut200ResponseQuote quote = default, string saleOrderDate = default, string salesRepresentative = default, bool serviceOnly = default, string shipBy = default, SalePut200ResponseFulfilmentsInnerShipShippingAddress shippingAddress = default, string shippingNotes = default, bool skipQuote = default, string sourceChannel = default, string status = default, string taxCalculation = default, string taxRule = default, string terms = default, string type = default) : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "AdditionalAttributes", EmitDefaultValue = false)]
        public AdvancedPurchasePutRequestAdditionalAttributes AdditionalAttributes { get; set; } = additionalAttributes;

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "Attachments", EmitDefaultValue = false)]
        public List<JournalPgLmtTaskidStsSrchGet200ResponseJournalsInnerAttachmentsInner> Attachments { get; set; } = attachments;

        /// <summary>
        /// Gets or Sets BaseCurrency
        /// </summary>
        [DataMember(Name = "BaseCurrency", EmitDefaultValue = false)]
        public string BaseCurrency { get; set; } = baseCurrency;

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "BillingAddress", EmitDefaultValue = false)]
        public AdvancedPurchaseIdCombineadditionalchargesGet200ResponseBillingAddress BillingAddress { get; set; } = billingAddress;

        /// <summary>
        /// Gets or Sets COGSAmount
        /// </summary>
        [DataMember(Name = "COGSAmount", EmitDefaultValue = false)]
        public decimal COGSAmount { get; set; } = cOGSAmount;

        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name = "Carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; } = carrier;

        /// <summary>
        /// Gets or Sets CombinedInvoiceStatus
        /// </summary>
        [DataMember(Name = "CombinedInvoiceStatus", EmitDefaultValue = false)]
        public string CombinedInvoiceStatus { get; set; } = combinedInvoiceStatus;

        /// <summary>
        /// Gets or Sets CombinedPackingStatus
        /// </summary>
        [DataMember(Name = "CombinedPackingStatus", EmitDefaultValue = false)]
        public string CombinedPackingStatus { get; set; } = combinedPackingStatus;

        /// <summary>
        /// Gets or Sets CombinedPaymentStatus
        /// </summary>
        [DataMember(Name = "CombinedPaymentStatus", EmitDefaultValue = false)]
        public string CombinedPaymentStatus { get; set; } = combinedPaymentStatus;

        /// <summary>
        /// Gets or Sets CombinedPickingStatus
        /// </summary>
        [DataMember(Name = "CombinedPickingStatus", EmitDefaultValue = false)]
        public string CombinedPickingStatus { get; set; } = combinedPickingStatus;

        /// <summary>
        /// Gets or Sets CombinedShippingStatus
        /// </summary>
        [DataMember(Name = "CombinedShippingStatus", EmitDefaultValue = false)]
        public string CombinedShippingStatus { get; set; } = combinedShippingStatus;

        /// <summary>
        /// Gets or Sets CombinedTrackingNumbers
        /// </summary>
        [DataMember(Name = "CombinedTrackingNumbers", EmitDefaultValue = false)]
        public string CombinedTrackingNumbers { get; set; } = combinedTrackingNumbers;

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "Contact", EmitDefaultValue = false)]
        public string Contact { get; set; } = contact;

        /// <summary>
        /// Gets or Sets CreditNotes
        /// </summary>
        [DataMember(Name = "CreditNotes", EmitDefaultValue = false)]
        public List<SalePut200ResponseCreditNotesInner> CreditNotes { get; set; } = creditNotes;

        /// <summary>
        /// Gets or Sets CurrencyRate
        /// </summary>
        [DataMember(Name = "CurrencyRate", EmitDefaultValue = false)]
        public decimal CurrencyRate { get; set; } = currencyRate;

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "Customer", EmitDefaultValue = false)]
        public string Customer { get; set; } = customer;

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
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; } = email;

        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name = "ExternalID", EmitDefaultValue = true)]
        public object ExternalID { get; set; } = externalID;

        /// <summary>
        /// Gets or Sets FulFilmentStatus
        /// </summary>
        [DataMember(Name = "FulFilmentStatus", EmitDefaultValue = false)]
        public string FulFilmentStatus { get; set; } = fulFilmentStatus;

        /// <summary>
        /// Gets or Sets Fulfilments
        /// </summary>
        [DataMember(Name = "Fulfilments", EmitDefaultValue = false)]
        public List<SalePut200ResponseFulfilmentsInner> Fulfilments { get; set; } = fulfilments;

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; } = iD;

        /// <summary>
        /// Gets or Sets InventoryMovements
        /// </summary>
        [DataMember(Name = "InventoryMovements", EmitDefaultValue = false)]
        public List<PurchaseIdCombineadditionalchargesGet200ResponseInventoryMovementsInner> InventoryMovements { get; set; } = inventoryMovements;

        /// <summary>
        /// Gets or Sets Invoices
        /// </summary>
        [DataMember(Name = "Invoices", EmitDefaultValue = false)]
        public List<SalePut200ResponseInvoicesInner> Invoices { get; set; } = invoices;

        /// <summary>
        /// Gets or Sets LastModifiedOn
        /// </summary>
        [DataMember(Name = "LastModifiedOn", EmitDefaultValue = false)]
        public string LastModifiedOn { get; set; } = lastModifiedOn;

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "Location", EmitDefaultValue = false)]
        public string Location { get; set; } = location;

        /// <summary>
        /// Gets or Sets ManualJournals
        /// </summary>
        [DataMember(Name = "ManualJournals", EmitDefaultValue = false)]
        public PurchasePut200ResponseCreditNoteUnstock ManualJournals { get; set; } = manualJournals;

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "Note", EmitDefaultValue = false)]
        public string Note { get; set; } = note;

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "Order", EmitDefaultValue = false)]
        public SalePut200ResponseOrder Order { get; set; } = order;

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
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name = "Quote", EmitDefaultValue = false)]
        public SalePut200ResponseQuote Quote { get; set; } = quote;

        /// <summary>
        /// Gets or Sets SaleOrderDate
        /// </summary>
        [DataMember(Name = "SaleOrderDate", EmitDefaultValue = false)]
        public string SaleOrderDate { get; set; } = saleOrderDate;

        /// <summary>
        /// Gets or Sets SalesRepresentative
        /// </summary>
        [DataMember(Name = "SalesRepresentative", EmitDefaultValue = false)]
        public string SalesRepresentative { get; set; } = salesRepresentative;

        /// <summary>
        /// Gets or Sets ServiceOnly
        /// </summary>
        [DataMember(Name = "ServiceOnly", EmitDefaultValue = true)]
        public bool ServiceOnly { get; set; } = serviceOnly;

        /// <summary>
        /// Gets or Sets ShipBy
        /// </summary>
        [DataMember(Name = "ShipBy", EmitDefaultValue = false)]
        public string ShipBy { get; set; } = shipBy;

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "ShippingAddress", EmitDefaultValue = false)]
        public SalePut200ResponseFulfilmentsInnerShipShippingAddress ShippingAddress { get; set; } = shippingAddress;

        /// <summary>
        /// Gets or Sets ShippingNotes
        /// </summary>
        [DataMember(Name = "ShippingNotes", EmitDefaultValue = false)]
        public string ShippingNotes { get; set; } = shippingNotes;

        /// <summary>
        /// Gets or Sets SkipQuote
        /// </summary>
        [DataMember(Name = "SkipQuote", EmitDefaultValue = true)]
        public bool SkipQuote { get; set; } = skipQuote;

        /// <summary>
        /// Gets or Sets SourceChannel
        /// </summary>
        [DataMember(Name = "SourceChannel", EmitDefaultValue = false)]
        public string SourceChannel { get; set; } = sourceChannel;

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; } = status;

        /// <summary>
        /// Gets or Sets TaxCalculation
        /// </summary>
        [DataMember(Name = "TaxCalculation", EmitDefaultValue = false)]
        public string TaxCalculation { get; set; } = taxCalculation;

        /// <summary>
        /// Gets or Sets TaxRule
        /// </summary>
        [DataMember(Name = "TaxRule", EmitDefaultValue = false)]
        public string TaxRule { get; set; } = taxRule;

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name = "Terms", EmitDefaultValue = false)]
        public string Terms { get; set; } = terms;

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; } = type;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class SalePost200Response {\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append('\n');
            sb.Append("  Attachments: ").Append(Attachments).Append('\n');
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append('\n');
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append('\n');
            sb.Append("  COGSAmount: ").Append(COGSAmount).Append('\n');
            sb.Append("  Carrier: ").Append(Carrier).Append('\n');
            sb.Append("  CombinedInvoiceStatus: ").Append(CombinedInvoiceStatus).Append('\n');
            sb.Append("  CombinedPackingStatus: ").Append(CombinedPackingStatus).Append('\n');
            sb.Append("  CombinedPaymentStatus: ").Append(CombinedPaymentStatus).Append('\n');
            sb.Append("  CombinedPickingStatus: ").Append(CombinedPickingStatus).Append('\n');
            sb.Append("  CombinedShippingStatus: ").Append(CombinedShippingStatus).Append('\n');
            sb.Append("  CombinedTrackingNumbers: ").Append(CombinedTrackingNumbers).Append('\n');
            sb.Append("  Contact: ").Append(Contact).Append('\n');
            sb.Append("  CreditNotes: ").Append(CreditNotes).Append('\n');
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append('\n');
            sb.Append("  Customer: ").Append(Customer).Append('\n');
            sb.Append("  CustomerCurrency: ").Append(CustomerCurrency).Append('\n');
            sb.Append("  CustomerID: ").Append(CustomerID).Append('\n');
            sb.Append("  CustomerReference: ").Append(CustomerReference).Append('\n');
            sb.Append("  DefaultAccount: ").Append(DefaultAccount).Append('\n');
            sb.Append("  Email: ").Append(Email).Append('\n');
            sb.Append("  ExternalID: ").Append(ExternalID).Append('\n');
            sb.Append("  FulFilmentStatus: ").Append(FulFilmentStatus).Append('\n');
            sb.Append("  Fulfilments: ").Append(Fulfilments).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  InventoryMovements: ").Append(InventoryMovements).Append('\n');
            sb.Append("  Invoices: ").Append(Invoices).Append('\n');
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append('\n');
            sb.Append("  Location: ").Append(Location).Append('\n');
            sb.Append("  ManualJournals: ").Append(ManualJournals).Append('\n');
            sb.Append("  Note: ").Append(Note).Append('\n');
            sb.Append("  Order: ").Append(Order).Append('\n');
            sb.Append("  Phone: ").Append(Phone).Append('\n');
            sb.Append("  PriceTier: ").Append(PriceTier).Append('\n');
            sb.Append("  Quote: ").Append(Quote).Append('\n');
            sb.Append("  SaleOrderDate: ").Append(SaleOrderDate).Append('\n');
            sb.Append("  SalesRepresentative: ").Append(SalesRepresentative).Append('\n');
            sb.Append("  ServiceOnly: ").Append(ServiceOnly).Append('\n');
            sb.Append("  ShipBy: ").Append(ShipBy).Append('\n');
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append('\n');
            sb.Append("  ShippingNotes: ").Append(ShippingNotes).Append('\n');
            sb.Append("  SkipQuote: ").Append(SkipQuote).Append('\n');
            sb.Append("  SourceChannel: ").Append(SourceChannel).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  TaxCalculation: ").Append(TaxCalculation).Append('\n');
            sb.Append("  TaxRule: ").Append(TaxRule).Append('\n');
            sb.Append("  Terms: ").Append(Terms).Append('\n');
            sb.Append("  Type: ").Append(Type).Append('\n');
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
