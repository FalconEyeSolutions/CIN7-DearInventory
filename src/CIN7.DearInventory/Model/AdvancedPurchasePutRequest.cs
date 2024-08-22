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
    /// AdvancedPurchasePutRequest
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="AdvancedPurchasePutRequest" /> class.
    /// </remarks>
    /// <param name="additionalAttributes">additionalAttributes.</param>
    /// <param name="billingAddress">billingAddress.</param>
    /// <param name="blindReceipt">blindReceipt.</param>
    /// <param name="contact">contact.</param>
    /// <param name="currencyRate">currencyRate.</param>
    /// <param name="iD">iD.</param>
    /// <param name="location">location.</param>
    /// <param name="note">note.</param>
    /// <param name="phone">phone.</param>
    /// <param name="requiredBy">requiredBy.</param>
    /// <param name="shippingAddress">shippingAddress.</param>
    /// <param name="supplier">supplier.</param>
    /// <param name="supplierID">supplierID.</param>
    /// <param name="taxCalculation">taxCalculation.</param>
    /// <param name="taxRule">taxRule.</param>
    /// <param name="terms">terms.</param>
    [DataContract(Name = "advancedPurchase_put_request")]
    public partial class AdvancedPurchasePutRequest(AdvancedPurchasePutRequestAdditionalAttributes additionalAttributes = default, AdvancedPurchasePutRequestBillingAddress billingAddress = default, bool blindReceipt = default, string contact = default, decimal currencyRate = default, string iD = default, string location = default, string note = default, string phone = default, object requiredBy = default, AdvancedPurchasePutRequestShippingAddress shippingAddress = default, string supplier = default, string supplierID = default, string taxCalculation = default, string taxRule = default, string terms = default) : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AdditionalAttributes
        /// </summary>
        [DataMember(Name = "AdditionalAttributes", EmitDefaultValue = false)]
        public AdvancedPurchasePutRequestAdditionalAttributes AdditionalAttributes { get; set; } = additionalAttributes;

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "BillingAddress", EmitDefaultValue = false)]
        public AdvancedPurchasePutRequestBillingAddress BillingAddress { get; set; } = billingAddress;

        /// <summary>
        /// Gets or Sets BlindReceipt
        /// </summary>
        [DataMember(Name = "BlindReceipt", EmitDefaultValue = true)]
        public bool BlindReceipt { get; set; } = blindReceipt;

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "Contact", EmitDefaultValue = false)]
        public string Contact { get; set; } = contact;

        /// <summary>
        /// Gets or Sets CurrencyRate
        /// </summary>
        [DataMember(Name = "CurrencyRate", EmitDefaultValue = false)]
        public decimal CurrencyRate { get; set; } = currencyRate;

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; } = iD;

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "Location", EmitDefaultValue = false)]
        public string Location { get; set; } = location;

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "Note", EmitDefaultValue = false)]
        public string Note { get; set; } = note;

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "Phone", EmitDefaultValue = false)]
        public string Phone { get; set; } = phone;

        /// <summary>
        /// Gets or Sets RequiredBy
        /// </summary>
        [DataMember(Name = "RequiredBy", EmitDefaultValue = true)]
        public object RequiredBy { get; set; } = requiredBy;

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "ShippingAddress", EmitDefaultValue = false)]
        public AdvancedPurchasePutRequestShippingAddress ShippingAddress { get; set; } = shippingAddress;

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name = "Supplier", EmitDefaultValue = false)]
        public string Supplier { get; set; } = supplier;

        /// <summary>
        /// Gets or Sets SupplierID
        /// </summary>
        [DataMember(Name = "SupplierID", EmitDefaultValue = false)]
        public string SupplierID { get; set; } = supplierID;

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class AdvancedPurchasePutRequest {\n");
            sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append('\n');
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append('\n');
            sb.Append("  BlindReceipt: ").Append(BlindReceipt).Append('\n');
            sb.Append("  Contact: ").Append(Contact).Append('\n');
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  Location: ").Append(Location).Append('\n');
            sb.Append("  Note: ").Append(Note).Append('\n');
            sb.Append("  Phone: ").Append(Phone).Append('\n');
            sb.Append("  RequiredBy: ").Append(RequiredBy).Append('\n');
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append('\n');
            sb.Append("  Supplier: ").Append(Supplier).Append('\n');
            sb.Append("  SupplierID: ").Append(SupplierID).Append('\n');
            sb.Append("  TaxCalculation: ").Append(TaxCalculation).Append('\n');
            sb.Append("  TaxRule: ").Append(TaxRule).Append('\n');
            sb.Append("  Terms: ").Append(Terms).Append('\n');
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