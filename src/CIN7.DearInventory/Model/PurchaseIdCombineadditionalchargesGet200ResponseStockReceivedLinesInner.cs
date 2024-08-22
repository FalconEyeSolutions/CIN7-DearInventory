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
    /// PurchaseIdCombineadditionalchargesGet200ResponseStockReceivedLinesInner
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="PurchaseIdCombineadditionalchargesGet200ResponseStockReceivedLinesInner" /> class.
    /// </remarks>
    /// <param name="batchSN">batchSN.</param>
    /// <param name="cardID">cardID.</param>
    /// <param name="date">date.</param>
    /// <param name="dimensionsUnits">dimensionsUnits.</param>
    /// <param name="expiryDate">expiryDate.</param>
    /// <param name="location">location.</param>
    /// <param name="locationID">locationID.</param>
    /// <param name="name">name.</param>
    /// <param name="productCustomField1">productCustomField1.</param>
    /// <param name="productCustomField10">productCustomField10.</param>
    /// <param name="productCustomField2">productCustomField2.</param>
    /// <param name="productCustomField3">productCustomField3.</param>
    /// <param name="productCustomField4">productCustomField4.</param>
    /// <param name="productCustomField5">productCustomField5.</param>
    /// <param name="productCustomField6">productCustomField6.</param>
    /// <param name="productCustomField7">productCustomField7.</param>
    /// <param name="productCustomField8">productCustomField8.</param>
    /// <param name="productCustomField9">productCustomField9.</param>
    /// <param name="productHeight">productHeight.</param>
    /// <param name="productID">productID.</param>
    /// <param name="productLength">productLength.</param>
    /// <param name="productWeight">productWeight.</param>
    /// <param name="productWidth">productWidth.</param>
    /// <param name="quantity">quantity.</param>
    /// <param name="received">received.</param>
    /// <param name="sKU">sKU.</param>
    /// <param name="supplierSKU">supplierSKU.</param>
    /// <param name="weightUnits">weightUnits.</param>
    [DataContract(Name = "purchase_Id__Combineadditionalcharges__get_200_response_StockReceived_Lines_inner")]
    public partial class PurchaseIdCombineadditionalchargesGet200ResponseStockReceivedLinesInner(string batchSN = default, string cardID = default, string date = default, string dimensionsUnits = default, string expiryDate = default, string location = default, string locationID = default, string name = default, object productCustomField1 = default, object productCustomField10 = default, object productCustomField2 = default, object productCustomField3 = default, object productCustomField4 = default, object productCustomField5 = default, object productCustomField6 = default, object productCustomField7 = default, object productCustomField8 = default, object productCustomField9 = default, decimal productHeight = default, string productID = default, decimal productLength = default, decimal productWeight = default, decimal productWidth = default, decimal quantity = default, bool received = default, string sKU = default, string supplierSKU = default, string weightUnits = default) : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BatchSN
        /// </summary>
        [DataMember(Name = "BatchSN", EmitDefaultValue = false)]
        public string BatchSN { get; set; } = batchSN;

        /// <summary>
        /// Gets or Sets CardID
        /// </summary>
        [DataMember(Name = "CardID", EmitDefaultValue = false)]
        public string CardID { get; set; } = cardID;

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "Date", EmitDefaultValue = false)]
        public string Date { get; set; } = date;

        /// <summary>
        /// Gets or Sets DimensionsUnits
        /// </summary>
        [DataMember(Name = "DimensionsUnits", EmitDefaultValue = false)]
        public string DimensionsUnits { get; set; } = dimensionsUnits;

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name = "ExpiryDate", EmitDefaultValue = false)]
        public string ExpiryDate { get; set; } = expiryDate;

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "Location", EmitDefaultValue = false)]
        public string Location { get; set; } = location;

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name = "LocationID", EmitDefaultValue = false)]
        public string LocationID { get; set; } = locationID;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; } = name;

        /// <summary>
        /// Gets or Sets ProductCustomField1
        /// </summary>
        [DataMember(Name = "ProductCustomField1", EmitDefaultValue = true)]
        public object ProductCustomField1 { get; set; } = productCustomField1;

        /// <summary>
        /// Gets or Sets ProductCustomField10
        /// </summary>
        [DataMember(Name = "ProductCustomField10", EmitDefaultValue = true)]
        public object ProductCustomField10 { get; set; } = productCustomField10;

        /// <summary>
        /// Gets or Sets ProductCustomField2
        /// </summary>
        [DataMember(Name = "ProductCustomField2", EmitDefaultValue = true)]
        public object ProductCustomField2 { get; set; } = productCustomField2;

        /// <summary>
        /// Gets or Sets ProductCustomField3
        /// </summary>
        [DataMember(Name = "ProductCustomField3", EmitDefaultValue = true)]
        public object ProductCustomField3 { get; set; } = productCustomField3;

        /// <summary>
        /// Gets or Sets ProductCustomField4
        /// </summary>
        [DataMember(Name = "ProductCustomField4", EmitDefaultValue = true)]
        public object ProductCustomField4 { get; set; } = productCustomField4;

        /// <summary>
        /// Gets or Sets ProductCustomField5
        /// </summary>
        [DataMember(Name = "ProductCustomField5", EmitDefaultValue = true)]
        public object ProductCustomField5 { get; set; } = productCustomField5;

        /// <summary>
        /// Gets or Sets ProductCustomField6
        /// </summary>
        [DataMember(Name = "ProductCustomField6", EmitDefaultValue = true)]
        public object ProductCustomField6 { get; set; } = productCustomField6;

        /// <summary>
        /// Gets or Sets ProductCustomField7
        /// </summary>
        [DataMember(Name = "ProductCustomField7", EmitDefaultValue = true)]
        public object ProductCustomField7 { get; set; } = productCustomField7;

        /// <summary>
        /// Gets or Sets ProductCustomField8
        /// </summary>
        [DataMember(Name = "ProductCustomField8", EmitDefaultValue = true)]
        public object ProductCustomField8 { get; set; } = productCustomField8;

        /// <summary>
        /// Gets or Sets ProductCustomField9
        /// </summary>
        [DataMember(Name = "ProductCustomField9", EmitDefaultValue = true)]
        public object ProductCustomField9 { get; set; } = productCustomField9;

        /// <summary>
        /// Gets or Sets ProductHeight
        /// </summary>
        [DataMember(Name = "ProductHeight", EmitDefaultValue = false)]
        public decimal ProductHeight { get; set; } = productHeight;

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name = "ProductID", EmitDefaultValue = false)]
        public string ProductID { get; set; } = productID;

        /// <summary>
        /// Gets or Sets ProductLength
        /// </summary>
        [DataMember(Name = "ProductLength", EmitDefaultValue = false)]
        public decimal ProductLength { get; set; } = productLength;

        /// <summary>
        /// Gets or Sets ProductWeight
        /// </summary>
        [DataMember(Name = "ProductWeight", EmitDefaultValue = false)]
        public decimal ProductWeight { get; set; } = productWeight;

        /// <summary>
        /// Gets or Sets ProductWidth
        /// </summary>
        [DataMember(Name = "ProductWidth", EmitDefaultValue = false)]
        public decimal ProductWidth { get; set; } = productWidth;

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; } = quantity;

        /// <summary>
        /// Gets or Sets Received
        /// </summary>
        [DataMember(Name = "Received", EmitDefaultValue = true)]
        public bool Received { get; set; } = received;

        /// <summary>
        /// Gets or Sets SKU
        /// </summary>
        [DataMember(Name = "SKU", EmitDefaultValue = false)]
        public string SKU { get; set; } = sKU;

        /// <summary>
        /// Gets or Sets SupplierSKU
        /// </summary>
        [DataMember(Name = "SupplierSKU", EmitDefaultValue = false)]
        public string SupplierSKU { get; set; } = supplierSKU;

        /// <summary>
        /// Gets or Sets WeightUnits
        /// </summary>
        [DataMember(Name = "WeightUnits", EmitDefaultValue = false)]
        public string WeightUnits { get; set; } = weightUnits;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class PurchaseIdCombineadditionalchargesGet200ResponseStockReceivedLinesInner {\n");
            sb.Append("  BatchSN: ").Append(BatchSN).Append('\n');
            sb.Append("  CardID: ").Append(CardID).Append('\n');
            sb.Append("  Date: ").Append(Date).Append('\n');
            sb.Append("  DimensionsUnits: ").Append(DimensionsUnits).Append('\n');
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append('\n');
            sb.Append("  Location: ").Append(Location).Append('\n');
            sb.Append("  LocationID: ").Append(LocationID).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
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
            sb.Append("  ProductWeight: ").Append(ProductWeight).Append('\n');
            sb.Append("  ProductWidth: ").Append(ProductWidth).Append('\n');
            sb.Append("  Quantity: ").Append(Quantity).Append('\n');
            sb.Append("  Received: ").Append(Received).Append('\n');
            sb.Append("  SKU: ").Append(SKU).Append('\n');
            sb.Append("  SupplierSKU: ").Append(SupplierSKU).Append('\n');
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
