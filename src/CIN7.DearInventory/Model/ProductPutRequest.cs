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
    /// ProductPutRequest
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ProductPutRequest" /> class.
    /// </remarks>
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
    /// <param name="assemblyCostEstimationMethod">assemblyCostEstimationMethod.</param>
    /// <param name="assemblyInstructionURL">assemblyInstructionURL.</param>
    /// <param name="attributeSet">attributeSet.</param>
    /// <param name="autoAssembly">autoAssembly.</param>
    /// <param name="autoDisassembly">autoDisassembly.</param>
    /// <param name="barcode">barcode.</param>
    /// <param name="billOfMaterial">billOfMaterial.</param>
    /// <param name="billOfMaterialsProducts">billOfMaterialsProducts.</param>
    /// <param name="billOfMaterialsServices">billOfMaterialsServices.</param>
    /// <param name="brand">brand.</param>
    /// <param name="cOGSAccount">cOGSAccount.</param>
    /// <param name="cartonHeight">cartonHeight.</param>
    /// <param name="cartonInnerQuantity">cartonInnerQuantity.</param>
    /// <param name="cartonLength">cartonLength.</param>
    /// <param name="cartonQuantity">cartonQuantity.</param>
    /// <param name="cartonWidth">cartonWidth.</param>
    /// <param name="category">category.</param>
    /// <param name="costingMethod">costingMethod.</param>
    /// <param name="countryOfOrigin">countryOfOrigin.</param>
    /// <param name="defaultLocation">defaultLocation.</param>
    /// <param name="description">description.</param>
    /// <param name="dimensionsUnits">dimensionsUnits.</param>
    /// <param name="discountRule">discountRule.</param>
    /// <param name="dropShipMode">dropShipMode.</param>
    /// <param name="expenseAccount">expenseAccount.</param>
    /// <param name="hSCode">hSCode.</param>
    /// <param name="height">height.</param>
    /// <param name="iD">iD.</param>
    /// <param name="internalNote">internalNote.</param>
    /// <param name="inventoryAccount">inventoryAccount.</param>
    /// <param name="length">length.</param>
    /// <param name="minimumBeforeReorder">minimumBeforeReorder.</param>
    /// <param name="name">name.</param>
    /// <param name="pickZones">pickZones.</param>
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
    /// <param name="priceTiers">priceTiers.</param>
    /// <param name="purchaseTaxRule">purchaseTaxRule.</param>
    /// <param name="quantityToProduce">quantityToProduce.</param>
    /// <param name="reorderLevels">reorderLevels.</param>
    /// <param name="reorderQuantity">reorderQuantity.</param>
    /// <param name="revenueAccount">revenueAccount.</param>
    /// <param name="sKU">sKU.</param>
    /// <param name="saleTaxRule">saleTaxRule.</param>
    /// <param name="sellable">sellable.</param>
    /// <param name="shortDescription">shortDescription.</param>
    /// <param name="status">status.</param>
    /// <param name="stockLocator">stockLocator.</param>
    /// <param name="suppliers">suppliers.</param>
    /// <param name="tags">tags.</param>
    /// <param name="uOM">uOM.</param>
    /// <param name="weight">weight.</param>
    /// <param name="weightUnits">weightUnits.</param>
    /// <param name="width">width.</param>
    [DataContract(Name = "product_put_request")]
    public partial class ProductPutRequest(string additionalAttribute1 = default, string additionalAttribute10 = default, string additionalAttribute2 = default, string additionalAttribute3 = default, string additionalAttribute4 = default, string additionalAttribute5 = default, string additionalAttribute6 = default, string additionalAttribute7 = default, string additionalAttribute8 = default, string additionalAttribute9 = default, string assemblyCostEstimationMethod = default, string assemblyInstructionURL = default, object attributeSet = default, bool autoAssembly = default, bool autoDisassembly = default, string barcode = default, bool billOfMaterial = default, List<ProductPutRequestBillOfMaterialsProductsInner> billOfMaterialsProducts = default, List<ProductPutRequestBillOfMaterialsServicesInner> billOfMaterialsServices = default, object brand = default, object cOGSAccount = default, decimal cartonHeight = default, decimal cartonInnerQuantity = default, decimal cartonLength = default, decimal cartonQuantity = default, decimal cartonWidth = default, string category = default, string costingMethod = default, string countryOfOrigin = default, string defaultLocation = default, string description = default, object dimensionsUnits = default, object discountRule = default, string dropShipMode = default, object expenseAccount = default, string hSCode = default, decimal height = default, string iD = default, string internalNote = default, object inventoryAccount = default, decimal length = default, decimal minimumBeforeReorder = default, string name = default, string pickZones = default, decimal priceTier1 = default, decimal priceTier10 = default, decimal priceTier2 = default, decimal priceTier3 = default, decimal priceTier4 = default, decimal priceTier5 = default, decimal priceTier6 = default, decimal priceTier7 = default, decimal priceTier8 = default, decimal priceTier9 = default, ProductPutRequestPriceTiers priceTiers = default, object purchaseTaxRule = default, decimal quantityToProduce = default, List<ProductPutRequestReorderLevelsInner> reorderLevels = default, decimal reorderQuantity = default, object revenueAccount = default, string sKU = default, object saleTaxRule = default, bool sellable = default, string shortDescription = default, string status = default, string stockLocator = default, List<ProductPutRequestSuppliersInner> suppliers = default, string tags = default, string uOM = default, decimal weight = default, string weightUnits = default, decimal width = default) : IValidatableObject
    {

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
        /// Gets or Sets AssemblyCostEstimationMethod
        /// </summary>
        [DataMember(Name = "AssemblyCostEstimationMethod", EmitDefaultValue = false)]
        public string AssemblyCostEstimationMethod { get; set; } = assemblyCostEstimationMethod;

        /// <summary>
        /// Gets or Sets AssemblyInstructionURL
        /// </summary>
        [DataMember(Name = "AssemblyInstructionURL", EmitDefaultValue = false)]
        public string AssemblyInstructionURL { get; set; } = assemblyInstructionURL;

        /// <summary>
        /// Gets or Sets AttributeSet
        /// </summary>
        [DataMember(Name = "AttributeSet", EmitDefaultValue = true)]
        public object AttributeSet { get; set; } = attributeSet;

        /// <summary>
        /// Gets or Sets AutoAssembly
        /// </summary>
        [DataMember(Name = "AutoAssembly", EmitDefaultValue = true)]
        public bool AutoAssembly { get; set; } = autoAssembly;

        /// <summary>
        /// Gets or Sets AutoDisassembly
        /// </summary>
        [DataMember(Name = "AutoDisassembly", EmitDefaultValue = true)]
        public bool AutoDisassembly { get; set; } = autoDisassembly;

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "Barcode", EmitDefaultValue = false)]
        public string Barcode { get; set; } = barcode;

        /// <summary>
        /// Gets or Sets BillOfMaterial
        /// </summary>
        [DataMember(Name = "BillOfMaterial", EmitDefaultValue = true)]
        public bool BillOfMaterial { get; set; } = billOfMaterial;

        /// <summary>
        /// Gets or Sets BillOfMaterialsProducts
        /// </summary>
        [DataMember(Name = "BillOfMaterialsProducts", EmitDefaultValue = false)]
        public List<ProductPutRequestBillOfMaterialsProductsInner> BillOfMaterialsProducts { get; set; } = billOfMaterialsProducts;

        /// <summary>
        /// Gets or Sets BillOfMaterialsServices
        /// </summary>
        [DataMember(Name = "BillOfMaterialsServices", EmitDefaultValue = false)]
        public List<ProductPutRequestBillOfMaterialsServicesInner> BillOfMaterialsServices { get; set; } = billOfMaterialsServices;

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
        /// Gets or Sets CartonHeight
        /// </summary>
        [DataMember(Name = "CartonHeight", EmitDefaultValue = false)]
        public decimal CartonHeight { get; set; } = cartonHeight;

        /// <summary>
        /// Gets or Sets CartonInnerQuantity
        /// </summary>
        [DataMember(Name = "CartonInnerQuantity", EmitDefaultValue = false)]
        public decimal CartonInnerQuantity { get; set; } = cartonInnerQuantity;

        /// <summary>
        /// Gets or Sets CartonLength
        /// </summary>
        [DataMember(Name = "CartonLength", EmitDefaultValue = false)]
        public decimal CartonLength { get; set; } = cartonLength;

        /// <summary>
        /// Gets or Sets CartonQuantity
        /// </summary>
        [DataMember(Name = "CartonQuantity", EmitDefaultValue = false)]
        public decimal CartonQuantity { get; set; } = cartonQuantity;

        /// <summary>
        /// Gets or Sets CartonWidth
        /// </summary>
        [DataMember(Name = "CartonWidth", EmitDefaultValue = false)]
        public decimal CartonWidth { get; set; } = cartonWidth;

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
        /// Gets or Sets DimensionsUnits
        /// </summary>
        [DataMember(Name = "DimensionsUnits", EmitDefaultValue = true)]
        public object DimensionsUnits { get; set; } = dimensionsUnits;

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
        /// Gets or Sets ExpenseAccount
        /// </summary>
        [DataMember(Name = "ExpenseAccount", EmitDefaultValue = true)]
        public object ExpenseAccount { get; set; } = expenseAccount;

        /// <summary>
        /// Gets or Sets HSCode
        /// </summary>
        [DataMember(Name = "HSCode", EmitDefaultValue = false)]
        public string HSCode { get; set; } = hSCode;

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "Height", EmitDefaultValue = false)]
        public decimal Height { get; set; } = height;

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; } = iD;

        /// <summary>
        /// Gets or Sets InternalNote
        /// </summary>
        [DataMember(Name = "InternalNote", EmitDefaultValue = false)]
        public string InternalNote { get; set; } = internalNote;

        /// <summary>
        /// Gets or Sets InventoryAccount
        /// </summary>
        [DataMember(Name = "InventoryAccount", EmitDefaultValue = true)]
        public object InventoryAccount { get; set; } = inventoryAccount;

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name = "Length", EmitDefaultValue = false)]
        public decimal Length { get; set; } = length;

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
        /// Gets or Sets PickZones
        /// </summary>
        [DataMember(Name = "PickZones", EmitDefaultValue = false)]
        public string PickZones { get; set; } = pickZones;

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
        /// Gets or Sets PriceTiers
        /// </summary>
        [DataMember(Name = "PriceTiers", EmitDefaultValue = false)]
        public ProductPutRequestPriceTiers PriceTiers { get; set; } = priceTiers;

        /// <summary>
        /// Gets or Sets PurchaseTaxRule
        /// </summary>
        [DataMember(Name = "PurchaseTaxRule", EmitDefaultValue = true)]
        public object PurchaseTaxRule { get; set; } = purchaseTaxRule;

        /// <summary>
        /// Gets or Sets QuantityToProduce
        /// </summary>
        [DataMember(Name = "QuantityToProduce", EmitDefaultValue = false)]
        public decimal QuantityToProduce { get; set; } = quantityToProduce;

        /// <summary>
        /// Gets or Sets ReorderLevels
        /// </summary>
        [DataMember(Name = "ReorderLevels", EmitDefaultValue = false)]
        public List<ProductPutRequestReorderLevelsInner> ReorderLevels { get; set; } = reorderLevels;

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
        /// Gets or Sets Sellable
        /// </summary>
        [DataMember(Name = "Sellable", EmitDefaultValue = true)]
        public bool Sellable { get; set; } = sellable;

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "ShortDescription", EmitDefaultValue = false)]
        public string ShortDescription { get; set; } = shortDescription;

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; } = status;

        /// <summary>
        /// Gets or Sets StockLocator
        /// </summary>
        [DataMember(Name = "StockLocator", EmitDefaultValue = false)]
        public string StockLocator { get; set; } = stockLocator;

        /// <summary>
        /// Gets or Sets Suppliers
        /// </summary>
        [DataMember(Name = "Suppliers", EmitDefaultValue = false)]
        public List<ProductPutRequestSuppliersInner> Suppliers { get; set; } = suppliers;

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
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
        public decimal Weight { get; set; } = weight;

        /// <summary>
        /// Gets or Sets WeightUnits
        /// </summary>
        [DataMember(Name = "WeightUnits", EmitDefaultValue = false)]
        public string WeightUnits { get; set; } = weightUnits;

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "Width", EmitDefaultValue = false)]
        public decimal Width { get; set; } = width;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class ProductPutRequest {\n");
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
            sb.Append("  AssemblyCostEstimationMethod: ").Append(AssemblyCostEstimationMethod).Append('\n');
            sb.Append("  AssemblyInstructionURL: ").Append(AssemblyInstructionURL).Append('\n');
            sb.Append("  AttributeSet: ").Append(AttributeSet).Append('\n');
            sb.Append("  AutoAssembly: ").Append(AutoAssembly).Append('\n');
            sb.Append("  AutoDisassembly: ").Append(AutoDisassembly).Append('\n');
            sb.Append("  Barcode: ").Append(Barcode).Append('\n');
            sb.Append("  BillOfMaterial: ").Append(BillOfMaterial).Append('\n');
            sb.Append("  BillOfMaterialsProducts: ").Append(BillOfMaterialsProducts).Append('\n');
            sb.Append("  BillOfMaterialsServices: ").Append(BillOfMaterialsServices).Append('\n');
            sb.Append("  Brand: ").Append(Brand).Append('\n');
            sb.Append("  COGSAccount: ").Append(COGSAccount).Append('\n');
            sb.Append("  CartonHeight: ").Append(CartonHeight).Append('\n');
            sb.Append("  CartonInnerQuantity: ").Append(CartonInnerQuantity).Append('\n');
            sb.Append("  CartonLength: ").Append(CartonLength).Append('\n');
            sb.Append("  CartonQuantity: ").Append(CartonQuantity).Append('\n');
            sb.Append("  CartonWidth: ").Append(CartonWidth).Append('\n');
            sb.Append("  Category: ").Append(Category).Append('\n');
            sb.Append("  CostingMethod: ").Append(CostingMethod).Append('\n');
            sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append('\n');
            sb.Append("  DefaultLocation: ").Append(DefaultLocation).Append('\n');
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  DimensionsUnits: ").Append(DimensionsUnits).Append('\n');
            sb.Append("  DiscountRule: ").Append(DiscountRule).Append('\n');
            sb.Append("  DropShipMode: ").Append(DropShipMode).Append('\n');
            sb.Append("  ExpenseAccount: ").Append(ExpenseAccount).Append('\n');
            sb.Append("  HSCode: ").Append(HSCode).Append('\n');
            sb.Append("  Height: ").Append(Height).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  InternalNote: ").Append(InternalNote).Append('\n');
            sb.Append("  InventoryAccount: ").Append(InventoryAccount).Append('\n');
            sb.Append("  Length: ").Append(Length).Append('\n');
            sb.Append("  MinimumBeforeReorder: ").Append(MinimumBeforeReorder).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  PickZones: ").Append(PickZones).Append('\n');
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
            sb.Append("  PriceTiers: ").Append(PriceTiers).Append('\n');
            sb.Append("  PurchaseTaxRule: ").Append(PurchaseTaxRule).Append('\n');
            sb.Append("  QuantityToProduce: ").Append(QuantityToProduce).Append('\n');
            sb.Append("  ReorderLevels: ").Append(ReorderLevels).Append('\n');
            sb.Append("  ReorderQuantity: ").Append(ReorderQuantity).Append('\n');
            sb.Append("  RevenueAccount: ").Append(RevenueAccount).Append('\n');
            sb.Append("  SKU: ").Append(SKU).Append('\n');
            sb.Append("  SaleTaxRule: ").Append(SaleTaxRule).Append('\n');
            sb.Append("  Sellable: ").Append(Sellable).Append('\n');
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  StockLocator: ").Append(StockLocator).Append('\n');
            sb.Append("  Suppliers: ").Append(Suppliers).Append('\n');
            sb.Append("  Tags: ").Append(Tags).Append('\n');
            sb.Append("  UOM: ").Append(UOM).Append('\n');
            sb.Append("  Weight: ").Append(Weight).Append('\n');
            sb.Append("  WeightUnits: ").Append(WeightUnits).Append('\n');
            sb.Append("  Width: ").Append(Width).Append('\n');
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
