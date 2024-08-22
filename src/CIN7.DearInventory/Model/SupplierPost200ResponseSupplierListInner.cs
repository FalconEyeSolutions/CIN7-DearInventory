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
    /// SupplierPost200ResponseSupplierListInner
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="SupplierPost200ResponseSupplierListInner" /> class.
    /// </remarks>
    /// <param name="accountPayable">accountPayable.</param>
    /// <param name="additionalAttribute1">additionalAttribute1.</param>
    /// <param name="additionalAttribute10">additionalAttribute10.</param>
    /// <param name="additionalAttribute2">additionalAttribute2.</param>
    /// <param name="additionalAttribute3">additionalAttribute3.</param>
    /// <param name="additionalAttribute4">additionalAttribute4.</param>
    /// <param name="additionalAttribute5">additionalAttribute5.</param>
    /// <param name="additionalAttribute6">additionalAttribute6.</param>
    /// <param name="additionalAttribute7">additionalAttribute7.</param>
    /// <param name="additionalAttribute8">additionalAttribute8.</param>
    /// <param name="additionalAttribute9">additionalAttribute9.</param>
    /// <param name="addresses">addresses.</param>
    /// <param name="attributeSet">attributeSet.</param>
    /// <param name="comments">comments.</param>
    /// <param name="contacts">contacts.</param>
    /// <param name="currency">currency.</param>
    /// <param name="discount">discount.</param>
    /// <param name="iD">iD.</param>
    /// <param name="lastModifiedOn">lastModifiedOn.</param>
    /// <param name="name">name.</param>
    /// <param name="paymentTerm">paymentTerm.</param>
    /// <param name="status">status.</param>
    /// <param name="taxNumber">taxNumber.</param>
    /// <param name="taxRule">taxRule.</param>
    [DataContract(Name = "supplier_post_200_response_SupplierList_inner")]
    public partial class SupplierPost200ResponseSupplierListInner(string accountPayable = default, string additionalAttribute1 = default, string additionalAttribute10 = default, string additionalAttribute2 = default, string additionalAttribute3 = default, string additionalAttribute4 = default, string additionalAttribute5 = default, string additionalAttribute6 = default, string additionalAttribute7 = default, string additionalAttribute8 = default, string additionalAttribute9 = default, List<string> addresses = default, string attributeSet = default, string comments = default, List<string> contacts = default, string currency = default, decimal discount = default, string iD = default, string lastModifiedOn = default, string name = default, string paymentTerm = default, string status = default, string taxNumber = default, string taxRule = default) : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AccountPayable
        /// </summary>
        [DataMember(Name = "AccountPayable", EmitDefaultValue = false)]
        public string AccountPayable { get; set; } = accountPayable;

        /// <summary>
        /// Gets or Sets AdditionalAttribute1
        /// </summary>
        [DataMember(Name = "AdditionalAttribute1", EmitDefaultValue = false)]
        public string AdditionalAttribute1 { get; set; } = additionalAttribute1;

        /// <summary>
        /// Gets or Sets AdditionalAttribute10
        /// </summary>
        [DataMember(Name = "AdditionalAttribute10", EmitDefaultValue = false)]
        public string AdditionalAttribute10 { get; set; } = additionalAttribute10;

        /// <summary>
        /// Gets or Sets AdditionalAttribute2
        /// </summary>
        [DataMember(Name = "AdditionalAttribute2", EmitDefaultValue = false)]
        public string AdditionalAttribute2 { get; set; } = additionalAttribute2;

        /// <summary>
        /// Gets or Sets AdditionalAttribute3
        /// </summary>
        [DataMember(Name = "AdditionalAttribute3", EmitDefaultValue = false)]
        public string AdditionalAttribute3 { get; set; } = additionalAttribute3;

        /// <summary>
        /// Gets or Sets AdditionalAttribute4
        /// </summary>
        [DataMember(Name = "AdditionalAttribute4", EmitDefaultValue = false)]
        public string AdditionalAttribute4 { get; set; } = additionalAttribute4;

        /// <summary>
        /// Gets or Sets AdditionalAttribute5
        /// </summary>
        [DataMember(Name = "AdditionalAttribute5", EmitDefaultValue = false)]
        public string AdditionalAttribute5 { get; set; } = additionalAttribute5;

        /// <summary>
        /// Gets or Sets AdditionalAttribute6
        /// </summary>
        [DataMember(Name = "AdditionalAttribute6", EmitDefaultValue = false)]
        public string AdditionalAttribute6 { get; set; } = additionalAttribute6;

        /// <summary>
        /// Gets or Sets AdditionalAttribute7
        /// </summary>
        [DataMember(Name = "AdditionalAttribute7", EmitDefaultValue = false)]
        public string AdditionalAttribute7 { get; set; } = additionalAttribute7;

        /// <summary>
        /// Gets or Sets AdditionalAttribute8
        /// </summary>
        [DataMember(Name = "AdditionalAttribute8", EmitDefaultValue = false)]
        public string AdditionalAttribute8 { get; set; } = additionalAttribute8;

        /// <summary>
        /// Gets or Sets AdditionalAttribute9
        /// </summary>
        [DataMember(Name = "AdditionalAttribute9", EmitDefaultValue = false)]
        public string AdditionalAttribute9 { get; set; } = additionalAttribute9;

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "Addresses", EmitDefaultValue = false)]
        public List<string> Addresses { get; set; } = addresses;

        /// <summary>
        /// Gets or Sets AttributeSet
        /// </summary>
        [DataMember(Name = "AttributeSet", EmitDefaultValue = false)]
        public string AttributeSet { get; set; } = attributeSet;

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "Comments", EmitDefaultValue = false)]
        public string Comments { get; set; } = comments;

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name = "Contacts", EmitDefaultValue = false)]
        public List<string> Contacts { get; set; } = contacts;

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "Currency", EmitDefaultValue = false)]
        public string Currency { get; set; } = currency;

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name = "Discount", EmitDefaultValue = false)]
        public decimal Discount { get; set; } = discount;

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; } = iD;

        /// <summary>
        /// Gets or Sets LastModifiedOn
        /// </summary>
        [DataMember(Name = "LastModifiedOn", EmitDefaultValue = false)]
        public string LastModifiedOn { get; set; } = lastModifiedOn;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; } = name;

        /// <summary>
        /// Gets or Sets PaymentTerm
        /// </summary>
        [DataMember(Name = "PaymentTerm", EmitDefaultValue = false)]
        public string PaymentTerm { get; set; } = paymentTerm;

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; } = status;

        /// <summary>
        /// Gets or Sets TaxNumber
        /// </summary>
        [DataMember(Name = "TaxNumber", EmitDefaultValue = false)]
        public string TaxNumber { get; set; } = taxNumber;

        /// <summary>
        /// Gets or Sets TaxRule
        /// </summary>
        [DataMember(Name = "TaxRule", EmitDefaultValue = false)]
        public string TaxRule { get; set; } = taxRule;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class SupplierPost200ResponseSupplierListInner {\n");
            sb.Append("  AccountPayable: ").Append(AccountPayable).Append('\n');
            sb.Append("  AdditionalAttribute1: ").Append(AdditionalAttribute1).Append('\n');
            sb.Append("  AdditionalAttribute10: ").Append(AdditionalAttribute10).Append('\n');
            sb.Append("  AdditionalAttribute2: ").Append(AdditionalAttribute2).Append('\n');
            sb.Append("  AdditionalAttribute3: ").Append(AdditionalAttribute3).Append('\n');
            sb.Append("  AdditionalAttribute4: ").Append(AdditionalAttribute4).Append('\n');
            sb.Append("  AdditionalAttribute5: ").Append(AdditionalAttribute5).Append('\n');
            sb.Append("  AdditionalAttribute6: ").Append(AdditionalAttribute6).Append('\n');
            sb.Append("  AdditionalAttribute7: ").Append(AdditionalAttribute7).Append('\n');
            sb.Append("  AdditionalAttribute8: ").Append(AdditionalAttribute8).Append('\n');
            sb.Append("  AdditionalAttribute9: ").Append(AdditionalAttribute9).Append('\n');
            sb.Append("  Addresses: ").Append(Addresses).Append('\n');
            sb.Append("  AttributeSet: ").Append(AttributeSet).Append('\n');
            sb.Append("  Comments: ").Append(Comments).Append('\n');
            sb.Append("  Contacts: ").Append(Contacts).Append('\n');
            sb.Append("  Currency: ").Append(Currency).Append('\n');
            sb.Append("  Discount: ").Append(Discount).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  PaymentTerm: ").Append(PaymentTerm).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append('\n');
            sb.Append("  TaxRule: ").Append(TaxRule).Append('\n');
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
