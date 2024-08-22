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
    /// StocktakeTaskidGet200ResponseNonZeroStockOnHandProductsInner
    /// </summary>
    [DataContract(Name = "stocktake_Taskid__get_200_response_NonZeroStockOnHandProducts_inner")]
    public partial class StocktakeTaskidGet200ResponseNonZeroStockOnHandProductsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StocktakeTaskidGet200ResponseNonZeroStockOnHandProductsInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected StocktakeTaskidGet200ResponseNonZeroStockOnHandProductsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StocktakeTaskidGet200ResponseNonZeroStockOnHandProductsInner" /> class.
        /// </summary>
        /// <param name="adjustment">adjustment (required).</param>
        /// <param name="available">available (required).</param>
        /// <param name="barcode">barcode (required).</param>
        /// <param name="batchSN">batchSN (required).</param>
        /// <param name="comments">comments (required).</param>
        /// <param name="dimensionsUnits">dimensionsUnits (required).</param>
        /// <param name="expiryDate">expiryDate (required).</param>
        /// <param name="image">image (required).</param>
        /// <param name="location">location (required).</param>
        /// <param name="locationID">locationID (required).</param>
        /// <param name="productCustomField1">productCustomField1 (required).</param>
        /// <param name="productCustomField10">productCustomField10 (required).</param>
        /// <param name="productCustomField2">productCustomField2 (required).</param>
        /// <param name="productCustomField3">productCustomField3 (required).</param>
        /// <param name="productCustomField4">productCustomField4 (required).</param>
        /// <param name="productCustomField5">productCustomField5 (required).</param>
        /// <param name="productCustomField6">productCustomField6 (required).</param>
        /// <param name="productCustomField7">productCustomField7 (required).</param>
        /// <param name="productCustomField8">productCustomField8 (required).</param>
        /// <param name="productCustomField9">productCustomField9 (required).</param>
        /// <param name="productHeight">productHeight (required).</param>
        /// <param name="productID">productID (required).</param>
        /// <param name="productLength">productLength (required).</param>
        /// <param name="productName">productName (required).</param>
        /// <param name="productWeight">productWeight (required).</param>
        /// <param name="productWidth">productWidth (required).</param>
        /// <param name="quantityOnHand">quantityOnHand (required).</param>
        /// <param name="sKU">sKU (required).</param>
        /// <param name="stockLocator">stockLocator (required).</param>
        /// <param name="unit">unit (required).</param>
        /// <param name="weightUnits">weightUnits (required).</param>
        public StocktakeTaskidGet200ResponseNonZeroStockOnHandProductsInner(decimal adjustment = default, decimal available = default, string barcode = default, string batchSN = default, object comments = default, string dimensionsUnits = default, string expiryDate = default, JournalPgLmtTaskidStsSrchGet200ResponseJournalsInnerAttachmentsInner image = default, string location = default, string locationID = default, object productCustomField1 = default, object productCustomField10 = default, object productCustomField2 = default, object productCustomField3 = default, object productCustomField4 = default, object productCustomField5 = default, object productCustomField6 = default, object productCustomField7 = default, object productCustomField8 = default, object productCustomField9 = default, decimal productHeight = default, string productID = default, decimal productLength = default, string productName = default, decimal productWeight = default, decimal productWidth = default, decimal quantityOnHand = default, string sKU = default, string stockLocator = default, string unit = default, string weightUnits = default)
        {
            Adjustment = adjustment;
            Available = available;
            // to ensure "barcode" is required (not null)
            ArgumentNullException.ThrowIfNull(barcode);
            Barcode = barcode;
            // to ensure "batchSN" is required (not null)
            ArgumentNullException.ThrowIfNull(batchSN);
            BatchSN = batchSN;
            // to ensure "comments" is required (not null)
            ArgumentNullException.ThrowIfNull(comments);
            Comments = comments;
            // to ensure "dimensionsUnits" is required (not null)
            ArgumentNullException.ThrowIfNull(dimensionsUnits);
            DimensionsUnits = dimensionsUnits;
            // to ensure "expiryDate" is required (not null)
            ArgumentNullException.ThrowIfNull(expiryDate);
            ExpiryDate = expiryDate;
            // to ensure "image" is required (not null)
            ArgumentNullException.ThrowIfNull(image);
            Image = image;
            // to ensure "location" is required (not null)
            ArgumentNullException.ThrowIfNull(location);
            Location = location;
            // to ensure "locationID" is required (not null)
            ArgumentNullException.ThrowIfNull(locationID);
            LocationID = locationID;
            // to ensure "productCustomField1" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField1);
            ProductCustomField1 = productCustomField1;
            // to ensure "productCustomField10" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField10);
            ProductCustomField10 = productCustomField10;
            // to ensure "productCustomField2" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField2);
            ProductCustomField2 = productCustomField2;
            // to ensure "productCustomField3" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField3);
            ProductCustomField3 = productCustomField3;
            // to ensure "productCustomField4" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField4);
            ProductCustomField4 = productCustomField4;
            // to ensure "productCustomField5" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField5);
            ProductCustomField5 = productCustomField5;
            // to ensure "productCustomField6" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField6);
            ProductCustomField6 = productCustomField6;
            // to ensure "productCustomField7" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField7);
            ProductCustomField7 = productCustomField7;
            // to ensure "productCustomField8" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField8);
            ProductCustomField8 = productCustomField8;
            // to ensure "productCustomField9" is required (not null)
            ArgumentNullException.ThrowIfNull(productCustomField9);
            ProductCustomField9 = productCustomField9;
            ProductHeight = productHeight;
            // to ensure "productID" is required (not null)
            ArgumentNullException.ThrowIfNull(productID);
            ProductID = productID;
            ProductLength = productLength;
            // to ensure "productName" is required (not null)
            ArgumentNullException.ThrowIfNull(productName);
            ProductName = productName;
            ProductWeight = productWeight;
            ProductWidth = productWidth;
            QuantityOnHand = quantityOnHand;
            // to ensure "sKU" is required (not null)
            ArgumentNullException.ThrowIfNull(sKU);
            SKU = sKU;
            // to ensure "stockLocator" is required (not null)
            ArgumentNullException.ThrowIfNull(stockLocator);
            StockLocator = stockLocator;
            // to ensure "unit" is required (not null)
            ArgumentNullException.ThrowIfNull(unit);
            Unit = unit;
            // to ensure "weightUnits" is required (not null)
            ArgumentNullException.ThrowIfNull(weightUnits);
            WeightUnits = weightUnits;
        }

        /// <summary>
        /// Gets or Sets Adjustment
        /// </summary>
        [DataMember(Name = "Adjustment", IsRequired = true, EmitDefaultValue = true)]
        public decimal Adjustment { get; set; }

        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name = "Available", IsRequired = true, EmitDefaultValue = true)]
        public decimal Available { get; set; }

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "Barcode", IsRequired = true, EmitDefaultValue = true)]
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or Sets BatchSN
        /// </summary>
        [DataMember(Name = "BatchSN", IsRequired = true, EmitDefaultValue = true)]
        public string BatchSN { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "Comments", IsRequired = true, EmitDefaultValue = true)]
        public object Comments { get; set; }

        /// <summary>
        /// Gets or Sets DimensionsUnits
        /// </summary>
        [DataMember(Name = "DimensionsUnits", IsRequired = true, EmitDefaultValue = true)]
        public string DimensionsUnits { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name = "ExpiryDate", IsRequired = true, EmitDefaultValue = true)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "Image", IsRequired = true, EmitDefaultValue = true)]
        public JournalPgLmtTaskidStsSrchGet200ResponseJournalsInnerAttachmentsInner Image { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "Location", IsRequired = true, EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name = "LocationID", IsRequired = true, EmitDefaultValue = true)]
        public string LocationID { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField1
        /// </summary>
        [DataMember(Name = "ProductCustomField1", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField1 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField10
        /// </summary>
        [DataMember(Name = "ProductCustomField10", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField10 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField2
        /// </summary>
        [DataMember(Name = "ProductCustomField2", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField2 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField3
        /// </summary>
        [DataMember(Name = "ProductCustomField3", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField3 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField4
        /// </summary>
        [DataMember(Name = "ProductCustomField4", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField4 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField5
        /// </summary>
        [DataMember(Name = "ProductCustomField5", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField5 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField6
        /// </summary>
        [DataMember(Name = "ProductCustomField6", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField6 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField7
        /// </summary>
        [DataMember(Name = "ProductCustomField7", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField7 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField8
        /// </summary>
        [DataMember(Name = "ProductCustomField8", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField8 { get; set; }

        /// <summary>
        /// Gets or Sets ProductCustomField9
        /// </summary>
        [DataMember(Name = "ProductCustomField9", IsRequired = true, EmitDefaultValue = true)]
        public object ProductCustomField9 { get; set; }

        /// <summary>
        /// Gets or Sets ProductHeight
        /// </summary>
        [DataMember(Name = "ProductHeight", IsRequired = true, EmitDefaultValue = true)]
        public decimal ProductHeight { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name = "ProductID", IsRequired = true, EmitDefaultValue = true)]
        public string ProductID { get; set; }

        /// <summary>
        /// Gets or Sets ProductLength
        /// </summary>
        [DataMember(Name = "ProductLength", IsRequired = true, EmitDefaultValue = true)]
        public decimal ProductLength { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "ProductName", IsRequired = true, EmitDefaultValue = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets ProductWeight
        /// </summary>
        [DataMember(Name = "ProductWeight", IsRequired = true, EmitDefaultValue = true)]
        public decimal ProductWeight { get; set; }

        /// <summary>
        /// Gets or Sets ProductWidth
        /// </summary>
        [DataMember(Name = "ProductWidth", IsRequired = true, EmitDefaultValue = true)]
        public decimal ProductWidth { get; set; }

        /// <summary>
        /// Gets or Sets QuantityOnHand
        /// </summary>
        [DataMember(Name = "QuantityOnHand", IsRequired = true, EmitDefaultValue = true)]
        public decimal QuantityOnHand { get; set; }

        /// <summary>
        /// Gets or Sets SKU
        /// </summary>
        [DataMember(Name = "SKU", IsRequired = true, EmitDefaultValue = true)]
        public string SKU { get; set; }

        /// <summary>
        /// Gets or Sets StockLocator
        /// </summary>
        [DataMember(Name = "StockLocator", IsRequired = true, EmitDefaultValue = true)]
        public string StockLocator { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "Unit", IsRequired = true, EmitDefaultValue = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets WeightUnits
        /// </summary>
        [DataMember(Name = "WeightUnits", IsRequired = true, EmitDefaultValue = true)]
        public string WeightUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class StocktakeTaskidGet200ResponseNonZeroStockOnHandProductsInner {\n");
            sb.Append("  Adjustment: ").Append(Adjustment).Append('\n');
            sb.Append("  Available: ").Append(Available).Append('\n');
            sb.Append("  Barcode: ").Append(Barcode).Append('\n');
            sb.Append("  BatchSN: ").Append(BatchSN).Append('\n');
            sb.Append("  Comments: ").Append(Comments).Append('\n');
            sb.Append("  DimensionsUnits: ").Append(DimensionsUnits).Append('\n');
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append('\n');
            sb.Append("  Image: ").Append(Image).Append('\n');
            sb.Append("  Location: ").Append(Location).Append('\n');
            sb.Append("  LocationID: ").Append(LocationID).Append('\n');
            sb.Append("  ProductCustomField1: ").Append(ProductCustomField1).Append('\n');
            sb.Append("  ProductCustomField10: ").Append(ProductCustomField10).Append('\n');
            sb.Append("  ProductCustomField2: ").Append(ProductCustomField2).Append('\n');
            sb.Append("  ProductCustomField3: ").Append(ProductCustomField3).Append('\n');
            sb.Append("  ProductCustomField4: ").Append(ProductCustomField4).Append('\n');
            sb.Append("  ProductCustomField5: ").Append(ProductCustomField5).Append('\n');
            sb.Append("  ProductCustomField6: ").Append(ProductCustomField6).Append('\n');
            sb.Append("  ProductCustomField7: ").Append(ProductCustomField7).Append('\n');
            sb.Append("  ProductCustomField8: ").Append(ProductCustomField8).Append('\n');
            sb.Append("  ProductCustomField9: ").Append(ProductCustomField9).Append('\n');
            sb.Append("  ProductHeight: ").Append(ProductHeight).Append('\n');
            sb.Append("  ProductID: ").Append(ProductID).Append('\n');
            sb.Append("  ProductLength: ").Append(ProductLength).Append('\n');
            sb.Append("  ProductName: ").Append(ProductName).Append('\n');
            sb.Append("  ProductWeight: ").Append(ProductWeight).Append('\n');
            sb.Append("  ProductWidth: ").Append(ProductWidth).Append('\n');
            sb.Append("  QuantityOnHand: ").Append(QuantityOnHand).Append('\n');
            sb.Append("  SKU: ").Append(SKU).Append('\n');
            sb.Append("  StockLocator: ").Append(StockLocator).Append('\n');
            sb.Append("  Unit: ").Append(Unit).Append('\n');
            sb.Append("  WeightUnits: ").Append(WeightUnits).Append('\n');
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
