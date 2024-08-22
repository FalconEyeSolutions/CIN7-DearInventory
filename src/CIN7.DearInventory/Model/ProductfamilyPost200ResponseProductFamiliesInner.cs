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
    /// ProductfamilyPost200ResponseProductFamiliesInner
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ProductfamilyPost200ResponseProductFamiliesInner" /> class.
    /// </remarks>
    /// <param name="attachments">attachments.</param>
    /// <param name="attributeSet">attributeSet.</param>
    /// <param name="brand">brand.</param>
    /// <param name="cOGSAccount">cOGSAccount.</param>
    /// <param name="category">category.</param>
    /// <param name="costingMethod">costingMethod.</param>
    /// <param name="countryOfOrigin">countryOfOrigin.</param>
    /// <param name="countryOfOriginCode">countryOfOriginCode.</param>
    /// <param name="defaultLocation">defaultLocation.</param>
    /// <param name="description">description.</param>
    /// <param name="discountRule">discountRule.</param>
    /// <param name="dropShipMode">dropShipMode.</param>
    /// <param name="hSCode">hSCode.</param>
    /// <param name="iD">iD.</param>
    /// <param name="inventoryAccount">inventoryAccount.</param>
    /// <param name="lastModifiedOn">lastModifiedOn.</param>
    /// <param name="minimumBeforeReorder">minimumBeforeReorder.</param>
    /// <param name="name">name.</param>
    /// <param name="option1Name">option1Name.</param>
    /// <param name="option1Values">option1Values.</param>
    /// <param name="option2Name">option2Name.</param>
    /// <param name="option2Values">option2Values.</param>
    /// <param name="option3Name">option3Name.</param>
    /// <param name="option3Values">option3Values.</param>
    /// <param name="priceTier1">priceTier1.</param>
    /// <param name="priceTier10">priceTier10.</param>
    /// <param name="priceTier2">priceTier2.</param>
    /// <param name="priceTier3">priceTier3.</param>
    /// <param name="priceTier4">priceTier4.</param>
    /// <param name="priceTier5">priceTier5.</param>
    /// <param name="priceTier6">priceTier6.</param>
    /// <param name="priceTier7">priceTier7.</param>
    /// <param name="priceTier8">priceTier8.</param>
    /// <param name="priceTier9">priceTier9.</param>
    /// <param name="products">products.</param>
    /// <param name="purchaseTaxRule">purchaseTaxRule.</param>
    /// <param name="reorderQuantity">reorderQuantity.</param>
    /// <param name="revenueAccount">revenueAccount.</param>
    /// <param name="sKU">sKU.</param>
    /// <param name="saleTaxRule">saleTaxRule.</param>
    /// <param name="shortDescription">shortDescription.</param>
    /// <param name="tags">tags.</param>
    /// <param name="uOM">uOM.</param>
    [DataContract(Name = "productfamily_post_200_response_ProductFamilies_inner")]
    public partial class ProductfamilyPost200ResponseProductFamiliesInner(List<string> attachments = default, object attributeSet = default, object brand = default, object cOGSAccount = default, string category = default, string costingMethod = default, string countryOfOrigin = default, string countryOfOriginCode = default, string defaultLocation = default, string description = default, object discountRule = default, string dropShipMode = default, string hSCode = default, string iD = default, object inventoryAccount = default, string lastModifiedOn = default, decimal minimumBeforeReorder = default, string name = default, string option1Name = default, string option1Values = default, string option2Name = default, string option2Values = default, string option3Name = default, string option3Values = default, decimal priceTier1 = default, decimal priceTier10 = default, decimal priceTier2 = default, decimal priceTier3 = default, decimal priceTier4 = default, decimal priceTier5 = default, decimal priceTier6 = default, decimal priceTier7 = default, decimal priceTier8 = default, decimal priceTier9 = default, List<ProductfamilyPostRequestProductsInner> products = default, object purchaseTaxRule = default, decimal reorderQuantity = default, object revenueAccount = default, string sKU = default, object saleTaxRule = default, string shortDescription = default, string tags = default, string uOM = default) : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "Attachments", EmitDefaultValue = false)]
        public List<string> Attachments { get; set; } = attachments;

        /// <summary>
        /// Gets or Sets AttributeSet
        /// </summary>
        [DataMember(Name = "AttributeSet", EmitDefaultValue = true)]
        public object AttributeSet { get; set; } = attributeSet;

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name = "Brand", EmitDefaultValue = true)]
        public object Brand { get; set; } = brand;

        /// <summary>
        /// Gets or Sets COGSAccount
        /// </summary>
        [DataMember(Name = "COGSAccount", EmitDefaultValue = true)]
        public object COGSAccount { get; set; } = cOGSAccount;

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "Category", EmitDefaultValue = false)]
        public string Category { get; set; } = category;

        /// <summary>
        /// Gets or Sets CostingMethod
        /// </summary>
        [DataMember(Name = "CostingMethod", EmitDefaultValue = false)]
        public string CostingMethod { get; set; } = costingMethod;

        /// <summary>
        /// Gets or Sets CountryOfOrigin
        /// </summary>
        [DataMember(Name = "CountryOfOrigin", EmitDefaultValue = false)]
        public string CountryOfOrigin { get; set; } = countryOfOrigin;

        /// <summary>
        /// Gets or Sets CountryOfOriginCode
        /// </summary>
        [DataMember(Name = "CountryOfOriginCode", EmitDefaultValue = false)]
        public string CountryOfOriginCode { get; set; } = countryOfOriginCode;

        /// <summary>
        /// Gets or Sets DefaultLocation
        /// </summary>
        [DataMember(Name = "DefaultLocation", EmitDefaultValue = false)]
        public string DefaultLocation { get; set; } = defaultLocation;

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; } = description;

        /// <summary>
        /// Gets or Sets DiscountRule
        /// </summary>
        [DataMember(Name = "DiscountRule", EmitDefaultValue = true)]
        public object DiscountRule { get; set; } = discountRule;

        /// <summary>
        /// Gets or Sets DropShipMode
        /// </summary>
        [DataMember(Name = "DropShipMode", EmitDefaultValue = false)]
        public string DropShipMode { get; set; } = dropShipMode;

        /// <summary>
        /// Gets or Sets HSCode
        /// </summary>
        [DataMember(Name = "HSCode", EmitDefaultValue = false)]
        public string HSCode { get; set; } = hSCode;

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; } = iD;

        /// <summary>
        /// Gets or Sets InventoryAccount
        /// </summary>
        [DataMember(Name = "InventoryAccount", EmitDefaultValue = true)]
        public object InventoryAccount { get; set; } = inventoryAccount;

        /// <summary>
        /// Gets or Sets LastModifiedOn
        /// </summary>
        [DataMember(Name = "LastModifiedOn", EmitDefaultValue = false)]
        public string LastModifiedOn { get; set; } = lastModifiedOn;

        /// <summary>
        /// Gets or Sets MinimumBeforeReorder
        /// </summary>
        [DataMember(Name = "MinimumBeforeReorder", EmitDefaultValue = false)]
        public decimal MinimumBeforeReorder { get; set; } = minimumBeforeReorder;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; } = name;

        /// <summary>
        /// Gets or Sets Option1Name
        /// </summary>
        [DataMember(Name = "Option1Name", EmitDefaultValue = false)]
        public string Option1Name { get; set; } = option1Name;

        /// <summary>
        /// Gets or Sets Option1Values
        /// </summary>
        [DataMember(Name = "Option1Values", EmitDefaultValue = false)]
        public string Option1Values { get; set; } = option1Values;

        /// <summary>
        /// Gets or Sets Option2Name
        /// </summary>
        [DataMember(Name = "Option2Name", EmitDefaultValue = false)]
        public string Option2Name { get; set; } = option2Name;

        /// <summary>
        /// Gets or Sets Option2Values
        /// </summary>
        [DataMember(Name = "Option2Values", EmitDefaultValue = false)]
        public string Option2Values { get; set; } = option2Values;

        /// <summary>
        /// Gets or Sets Option3Name
        /// </summary>
        [DataMember(Name = "Option3Name", EmitDefaultValue = false)]
        public string Option3Name { get; set; } = option3Name;

        /// <summary>
        /// Gets or Sets Option3Values
        /// </summary>
        [DataMember(Name = "Option3Values", EmitDefaultValue = false)]
        public string Option3Values { get; set; } = option3Values;

        /// <summary>
        /// Gets or Sets PriceTier1
        /// </summary>
        [DataMember(Name = "PriceTier1", EmitDefaultValue = false)]
        public decimal PriceTier1 { get; set; } = priceTier1;

        /// <summary>
        /// Gets or Sets PriceTier10
        /// </summary>
        [DataMember(Name = "PriceTier10", EmitDefaultValue = false)]
        public decimal PriceTier10 { get; set; } = priceTier10;

        /// <summary>
        /// Gets or Sets PriceTier2
        /// </summary>
        [DataMember(Name = "PriceTier2", EmitDefaultValue = false)]
        public decimal PriceTier2 { get; set; } = priceTier2;

        /// <summary>
        /// Gets or Sets PriceTier3
        /// </summary>
        [DataMember(Name = "PriceTier3", EmitDefaultValue = false)]
        public decimal PriceTier3 { get; set; } = priceTier3;

        /// <summary>
        /// Gets or Sets PriceTier4
        /// </summary>
        [DataMember(Name = "PriceTier4", EmitDefaultValue = false)]
        public decimal PriceTier4 { get; set; } = priceTier4;

        /// <summary>
        /// Gets or Sets PriceTier5
        /// </summary>
        [DataMember(Name = "PriceTier5", EmitDefaultValue = false)]
        public decimal PriceTier5 { get; set; } = priceTier5;

        /// <summary>
        /// Gets or Sets PriceTier6
        /// </summary>
        [DataMember(Name = "PriceTier6", EmitDefaultValue = false)]
        public decimal PriceTier6 { get; set; } = priceTier6;

        /// <summary>
        /// Gets or Sets PriceTier7
        /// </summary>
        [DataMember(Name = "PriceTier7", EmitDefaultValue = false)]
        public decimal PriceTier7 { get; set; } = priceTier7;

        /// <summary>
        /// Gets or Sets PriceTier8
        /// </summary>
        [DataMember(Name = "PriceTier8", EmitDefaultValue = false)]
        public decimal PriceTier8 { get; set; } = priceTier8;

        /// <summary>
        /// Gets or Sets PriceTier9
        /// </summary>
        [DataMember(Name = "PriceTier9", EmitDefaultValue = false)]
        public decimal PriceTier9 { get; set; } = priceTier9;

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name = "Products", EmitDefaultValue = false)]
        public List<ProductfamilyPostRequestProductsInner> Products { get; set; } = products;

        /// <summary>
        /// Gets or Sets PurchaseTaxRule
        /// </summary>
        [DataMember(Name = "PurchaseTaxRule", EmitDefaultValue = true)]
        public object PurchaseTaxRule { get; set; } = purchaseTaxRule;

        /// <summary>
        /// Gets or Sets ReorderQuantity
        /// </summary>
        [DataMember(Name = "ReorderQuantity", EmitDefaultValue = false)]
        public decimal ReorderQuantity { get; set; } = reorderQuantity;

        /// <summary>
        /// Gets or Sets RevenueAccount
        /// </summary>
        [DataMember(Name = "RevenueAccount", EmitDefaultValue = true)]
        public object RevenueAccount { get; set; } = revenueAccount;

        /// <summary>
        /// Gets or Sets SKU
        /// </summary>
        [DataMember(Name = "SKU", EmitDefaultValue = false)]
        public string SKU { get; set; } = sKU;

        /// <summary>
        /// Gets or Sets SaleTaxRule
        /// </summary>
        [DataMember(Name = "SaleTaxRule", EmitDefaultValue = true)]
        public object SaleTaxRule { get; set; } = saleTaxRule;

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "ShortDescription", EmitDefaultValue = false)]
        public string ShortDescription { get; set; } = shortDescription;

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "Tags", EmitDefaultValue = false)]
        public string Tags { get; set; } = tags;

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name = "UOM", EmitDefaultValue = false)]
        public string UOM { get; set; } = uOM;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class ProductfamilyPost200ResponseProductFamiliesInner {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append('\n');
            sb.Append("  AttributeSet: ").Append(AttributeSet).Append('\n');
            sb.Append("  Brand: ").Append(Brand).Append('\n');
            sb.Append("  COGSAccount: ").Append(COGSAccount).Append('\n');
            sb.Append("  Category: ").Append(Category).Append('\n');
            sb.Append("  CostingMethod: ").Append(CostingMethod).Append('\n');
            sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append('\n');
            sb.Append("  CountryOfOriginCode: ").Append(CountryOfOriginCode).Append('\n');
            sb.Append("  DefaultLocation: ").Append(DefaultLocation).Append('\n');
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  DiscountRule: ").Append(DiscountRule).Append('\n');
            sb.Append("  DropShipMode: ").Append(DropShipMode).Append('\n');
            sb.Append("  HSCode: ").Append(HSCode).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  InventoryAccount: ").Append(InventoryAccount).Append('\n');
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append('\n');
            sb.Append("  MinimumBeforeReorder: ").Append(MinimumBeforeReorder).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Option1Name: ").Append(Option1Name).Append('\n');
            sb.Append("  Option1Values: ").Append(Option1Values).Append('\n');
            sb.Append("  Option2Name: ").Append(Option2Name).Append('\n');
            sb.Append("  Option2Values: ").Append(Option2Values).Append('\n');
            sb.Append("  Option3Name: ").Append(Option3Name).Append('\n');
            sb.Append("  Option3Values: ").Append(Option3Values).Append('\n');
            sb.Append("  PriceTier1: ").Append(PriceTier1).Append('\n');
            sb.Append("  PriceTier10: ").Append(PriceTier10).Append('\n');
            sb.Append("  PriceTier2: ").Append(PriceTier2).Append('\n');
            sb.Append("  PriceTier3: ").Append(PriceTier3).Append('\n');
            sb.Append("  PriceTier4: ").Append(PriceTier4).Append('\n');
            sb.Append("  PriceTier5: ").Append(PriceTier5).Append('\n');
            sb.Append("  PriceTier6: ").Append(PriceTier6).Append('\n');
            sb.Append("  PriceTier7: ").Append(PriceTier7).Append('\n');
            sb.Append("  PriceTier8: ").Append(PriceTier8).Append('\n');
            sb.Append("  PriceTier9: ").Append(PriceTier9).Append('\n');
            sb.Append("  Products: ").Append(Products).Append('\n');
            sb.Append("  PurchaseTaxRule: ").Append(PurchaseTaxRule).Append('\n');
            sb.Append("  ReorderQuantity: ").Append(ReorderQuantity).Append('\n');
            sb.Append("  RevenueAccount: ").Append(RevenueAccount).Append('\n');
            sb.Append("  SKU: ").Append(SKU).Append('\n');
            sb.Append("  SaleTaxRule: ").Append(SaleTaxRule).Append('\n');
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append('\n');
            sb.Append("  Tags: ").Append(Tags).Append('\n');
            sb.Append("  UOM: ").Append(UOM).Append('\n');
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