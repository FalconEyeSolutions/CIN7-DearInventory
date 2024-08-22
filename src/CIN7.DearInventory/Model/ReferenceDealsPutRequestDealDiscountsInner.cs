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
    /// ReferenceDealsPutRequestDealDiscountsInner
    /// </summary>
    [DataContract(Name = "referenceDeals_put_request_DealDiscounts_inner")]
    public partial class ReferenceDealsPutRequestDealDiscountsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDealsPutRequestDealDiscountsInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected ReferenceDealsPutRequestDealDiscountsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceDealsPutRequestDealDiscountsInner" /> class.
        /// </summary>
        /// <param name="buyMore">buyMore (required).</param>
        /// <param name="buyType">buyType (required).</param>
        /// <param name="buyValue">buyValue (required).</param>
        /// <param name="buyValueType">buyValueType (required).</param>
        /// <param name="dealDiscountBrands">dealDiscountBrands (required).</param>
        /// <param name="dealDiscountCategories">dealDiscountCategories (required).</param>
        /// <param name="dealDiscountProducts">dealDiscountProducts (required).</param>
        /// <param name="dealDiscountTags">dealDiscountTags (required).</param>
        /// <param name="discountID">discountID (required).</param>
        /// <param name="discountName">discountName (required).</param>
        /// <param name="discountType">discountType (required).</param>
        /// <param name="getType">getType (required).</param>
        /// <param name="getValue">getValue (required).</param>
        /// <param name="getValueType">getValueType (required).</param>
        /// <param name="iD">iD (required).</param>
        /// <param name="isOrderLevel">isOrderLevel (required).</param>
        /// <param name="sequence">sequence (required).</param>
        public ReferenceDealsPutRequestDealDiscountsInner(bool buyMore = default, string buyType = default, object buyValue = default, string buyValueType = default, List<string> dealDiscountBrands = default, List<string> dealDiscountCategories = default, List<ReferenceDealsPutRequestDealDiscountsInnerDealDiscountProductsInner> dealDiscountProducts = default, List<ReferenceDealsPutRequestDealDiscountsInnerDealDiscountTagsInner> dealDiscountTags = default, string discountID = default, string discountName = default, string discountType = default, string getType = default, object getValue = default, string getValueType = default, string iD = default, bool isOrderLevel = default, decimal sequence = default)
        {
            BuyMore = buyMore;
            // to ensure "buyType" is required (not null)
            ArgumentNullException.ThrowIfNull(buyType);
            BuyType = buyType;
            // to ensure "buyValue" is required (not null)
            ArgumentNullException.ThrowIfNull(buyValue);
            BuyValue = buyValue;
            // to ensure "buyValueType" is required (not null)
            ArgumentNullException.ThrowIfNull(buyValueType);
            BuyValueType = buyValueType;
            // to ensure "dealDiscountBrands" is required (not null)
            ArgumentNullException.ThrowIfNull(dealDiscountBrands);
            DealDiscountBrands = dealDiscountBrands;
            // to ensure "dealDiscountCategories" is required (not null)
            ArgumentNullException.ThrowIfNull(dealDiscountCategories);
            DealDiscountCategories = dealDiscountCategories;
            // to ensure "dealDiscountProducts" is required (not null)
            ArgumentNullException.ThrowIfNull(dealDiscountProducts);
            DealDiscountProducts = dealDiscountProducts;
            // to ensure "dealDiscountTags" is required (not null)
            ArgumentNullException.ThrowIfNull(dealDiscountTags);
            DealDiscountTags = dealDiscountTags;
            // to ensure "discountID" is required (not null)
            ArgumentNullException.ThrowIfNull(discountID);
            DiscountID = discountID;
            // to ensure "discountName" is required (not null)
            ArgumentNullException.ThrowIfNull(discountName);
            DiscountName = discountName;
            // to ensure "discountType" is required (not null)
            ArgumentNullException.ThrowIfNull(discountType);
            DiscountType = discountType;
            // to ensure "getType" is required (not null)
            ArgumentNullException.ThrowIfNull(getType);
            GetType = getType;
            // to ensure "getValue" is required (not null)
            ArgumentNullException.ThrowIfNull(getValue);
            GetValue = getValue;
            // to ensure "getValueType" is required (not null)
            ArgumentNullException.ThrowIfNull(getValueType);
            GetValueType = getValueType;
            // to ensure "iD" is required (not null)
            ArgumentNullException.ThrowIfNull(iD);
            ID = iD;
            IsOrderLevel = isOrderLevel;
            Sequence = sequence;
        }

        /// <summary>
        /// Gets or Sets BuyMore
        /// </summary>
        [DataMember(Name = "BuyMore", IsRequired = true, EmitDefaultValue = true)]
        public bool BuyMore { get; set; }

        /// <summary>
        /// Gets or Sets BuyType
        /// </summary>
        [DataMember(Name = "BuyType", IsRequired = true, EmitDefaultValue = true)]
        public string BuyType { get; set; }

        /// <summary>
        /// Gets or Sets BuyValue
        /// </summary>
        [DataMember(Name = "BuyValue", IsRequired = true, EmitDefaultValue = true)]
        public object BuyValue { get; set; }

        /// <summary>
        /// Gets or Sets BuyValueType
        /// </summary>
        [DataMember(Name = "BuyValueType", IsRequired = true, EmitDefaultValue = true)]
        public string BuyValueType { get; set; }

        /// <summary>
        /// Gets or Sets DealDiscountBrands
        /// </summary>
        [DataMember(Name = "DealDiscountBrands", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DealDiscountBrands { get; set; }

        /// <summary>
        /// Gets or Sets DealDiscountCategories
        /// </summary>
        [DataMember(Name = "DealDiscountCategories", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DealDiscountCategories { get; set; }

        /// <summary>
        /// Gets or Sets DealDiscountProducts
        /// </summary>
        [DataMember(Name = "DealDiscountProducts", IsRequired = true, EmitDefaultValue = true)]
        public List<ReferenceDealsPutRequestDealDiscountsInnerDealDiscountProductsInner> DealDiscountProducts { get; set; }

        /// <summary>
        /// Gets or Sets DealDiscountTags
        /// </summary>
        [DataMember(Name = "DealDiscountTags", IsRequired = true, EmitDefaultValue = true)]
        public List<ReferenceDealsPutRequestDealDiscountsInnerDealDiscountTagsInner> DealDiscountTags { get; set; }

        /// <summary>
        /// Gets or Sets DiscountID
        /// </summary>
        [DataMember(Name = "DiscountID", IsRequired = true, EmitDefaultValue = true)]
        public string DiscountID { get; set; }

        /// <summary>
        /// Gets or Sets DiscountName
        /// </summary>
        [DataMember(Name = "DiscountName", IsRequired = true, EmitDefaultValue = true)]
        public string DiscountName { get; set; }

        /// <summary>
        /// Gets or Sets DiscountType
        /// </summary>
        [DataMember(Name = "DiscountType", IsRequired = true, EmitDefaultValue = true)]
        public string DiscountType { get; set; }

        /// <summary>
        /// Gets or Sets GetType
        /// </summary>
        [DataMember(Name = "GetType", IsRequired = true, EmitDefaultValue = true)]
        public string GetType { get; set; }

        /// <summary>
        /// Gets or Sets GetValue
        /// </summary>
        [DataMember(Name = "GetValue", IsRequired = true, EmitDefaultValue = true)]
        public object GetValue { get; set; }

        /// <summary>
        /// Gets or Sets GetValueType
        /// </summary>
        [DataMember(Name = "GetValueType", IsRequired = true, EmitDefaultValue = true)]
        public string GetValueType { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", IsRequired = true, EmitDefaultValue = true)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets IsOrderLevel
        /// </summary>
        [DataMember(Name = "IsOrderLevel", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOrderLevel { get; set; }

        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [DataMember(Name = "Sequence", IsRequired = true, EmitDefaultValue = true)]
        public decimal Sequence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class ReferenceDealsPutRequestDealDiscountsInner {\n");
            sb.Append("  BuyMore: ").Append(BuyMore).Append('\n');
            sb.Append("  BuyType: ").Append(BuyType).Append('\n');
            sb.Append("  BuyValue: ").Append(BuyValue).Append('\n');
            sb.Append("  BuyValueType: ").Append(BuyValueType).Append('\n');
            sb.Append("  DealDiscountBrands: ").Append(DealDiscountBrands).Append('\n');
            sb.Append("  DealDiscountCategories: ").Append(DealDiscountCategories).Append('\n');
            sb.Append("  DealDiscountProducts: ").Append(DealDiscountProducts).Append('\n');
            sb.Append("  DealDiscountTags: ").Append(DealDiscountTags).Append('\n');
            sb.Append("  DiscountID: ").Append(DiscountID).Append('\n');
            sb.Append("  DiscountName: ").Append(DiscountName).Append('\n');
            sb.Append("  DiscountType: ").Append(DiscountType).Append('\n');
            sb.Append("  GetType: ").Append(GetType).Append('\n');
            sb.Append("  GetValue: ").Append(GetValue).Append('\n');
            sb.Append("  GetValueType: ").Append(GetValueType).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  IsOrderLevel: ").Append(IsOrderLevel).Append('\n');
            sb.Append("  Sequence: ").Append(Sequence).Append('\n');
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
