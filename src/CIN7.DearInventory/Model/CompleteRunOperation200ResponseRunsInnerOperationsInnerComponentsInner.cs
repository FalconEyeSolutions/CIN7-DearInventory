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
    /// CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner
    /// </summary>
    [DataContract(Name = "Complete_Run_Operation_200_response_Runs_inner_Operations_inner_Components_inner")]
    public partial class CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner" /> class.
        /// </summary>
        /// <param name="available">available (required).</param>
        /// <param name="batchSN">batchSN (required).</param>
        /// <param name="costingMethod">costingMethod (required).</param>
        /// <param name="expectedQuantity">expectedQuantity (required).</param>
        /// <param name="expiryDate">expiryDate (required).</param>
        /// <param name="isBackflush">isBackflush (required).</param>
        /// <param name="isReserved">isReserved (required).</param>
        /// <param name="locationID">locationID (required).</param>
        /// <param name="locationName">locationName (required).</param>
        /// <param name="productCode">productCode (required).</param>
        /// <param name="productCost">productCost (required).</param>
        /// <param name="productID">productID (required).</param>
        /// <param name="productName">productName (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="reservedQuantity">reservedQuantity (required).</param>
        /// <param name="runComponentID">runComponentID (required).</param>
        /// <param name="unit">unit (required).</param>
        /// <param name="unitCost">unitCost (required).</param>
        /// <param name="wastagePercent">wastagePercent (required).</param>
        /// <param name="wastageQty">wastageQty (required).</param>
        public CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner(decimal available = default, string batchSN = default, object costingMethod = default, decimal expectedQuantity = default, object expiryDate = default, bool isBackflush = default, bool isReserved = default, string locationID = default, string locationName = default, string productCode = default, decimal productCost = default, string productID = default, string productName = default, decimal quantity = default, decimal reservedQuantity = default, string runComponentID = default, string unit = default, decimal unitCost = default, decimal wastagePercent = default, decimal wastageQty = default)
        {
            Available = available;
            // to ensure "batchSN" is required (not null)
            ArgumentNullException.ThrowIfNull(batchSN);
            BatchSN = batchSN;
            // to ensure "costingMethod" is required (not null)
            ArgumentNullException.ThrowIfNull(costingMethod);
            CostingMethod = costingMethod;
            ExpectedQuantity = expectedQuantity;
            // to ensure "expiryDate" is required (not null)
            ArgumentNullException.ThrowIfNull(expiryDate);
            ExpiryDate = expiryDate;
            IsBackflush = isBackflush;
            IsReserved = isReserved;
            // to ensure "locationID" is required (not null)
            ArgumentNullException.ThrowIfNull(locationID);
            LocationID = locationID;
            // to ensure "locationName" is required (not null)
            ArgumentNullException.ThrowIfNull(locationName);
            LocationName = locationName;
            // to ensure "productCode" is required (not null)
            ArgumentNullException.ThrowIfNull(productCode);
            ProductCode = productCode;
            ProductCost = productCost;
            // to ensure "productID" is required (not null)
            ArgumentNullException.ThrowIfNull(productID);
            ProductID = productID;
            // to ensure "productName" is required (not null)
            ArgumentNullException.ThrowIfNull(productName);
            ProductName = productName;
            Quantity = quantity;
            ReservedQuantity = reservedQuantity;
            // to ensure "runComponentID" is required (not null)
            ArgumentNullException.ThrowIfNull(runComponentID);
            RunComponentID = runComponentID;
            // to ensure "unit" is required (not null)
            ArgumentNullException.ThrowIfNull(unit);
            Unit = unit;
            UnitCost = unitCost;
            WastagePercent = wastagePercent;
            WastageQty = wastageQty;
        }

        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name = "Available", IsRequired = true, EmitDefaultValue = true)]
        public decimal Available { get; set; }

        /// <summary>
        /// Gets or Sets BatchSN
        /// </summary>
        [DataMember(Name = "BatchSN", IsRequired = true, EmitDefaultValue = true)]
        public string BatchSN { get; set; }

        /// <summary>
        /// Gets or Sets CostingMethod
        /// </summary>
        [DataMember(Name = "CostingMethod", IsRequired = true, EmitDefaultValue = true)]
        public object CostingMethod { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedQuantity
        /// </summary>
        [DataMember(Name = "ExpectedQuantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal ExpectedQuantity { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name = "ExpiryDate", IsRequired = true, EmitDefaultValue = true)]
        public object ExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets IsBackflush
        /// </summary>
        [DataMember(Name = "IsBackflush", IsRequired = true, EmitDefaultValue = true)]
        public bool IsBackflush { get; set; }

        /// <summary>
        /// Gets or Sets IsReserved
        /// </summary>
        [DataMember(Name = "IsReserved", IsRequired = true, EmitDefaultValue = true)]
        public bool IsReserved { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name = "LocationID", IsRequired = true, EmitDefaultValue = true)]
        public string LocationID { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name = "LocationName", IsRequired = true, EmitDefaultValue = true)]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "ProductCode", IsRequired = true, EmitDefaultValue = true)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductCost
        /// </summary>
        [DataMember(Name = "ProductCost", IsRequired = true, EmitDefaultValue = true)]
        public decimal ProductCost { get; set; }

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name = "ProductID", IsRequired = true, EmitDefaultValue = true)]
        public string ProductID { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "ProductName", IsRequired = true, EmitDefaultValue = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ReservedQuantity
        /// </summary>
        [DataMember(Name = "ReservedQuantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal ReservedQuantity { get; set; }

        /// <summary>
        /// Gets or Sets RunComponentID
        /// </summary>
        [DataMember(Name = "RunComponentID", IsRequired = true, EmitDefaultValue = true)]
        public string RunComponentID { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "Unit", IsRequired = true, EmitDefaultValue = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name = "UnitCost", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets WastagePercent
        /// </summary>
        [DataMember(Name = "WastagePercent", IsRequired = true, EmitDefaultValue = true)]
        public decimal WastagePercent { get; set; }

        /// <summary>
        /// Gets or Sets WastageQty
        /// </summary>
        [DataMember(Name = "WastageQty", IsRequired = true, EmitDefaultValue = true)]
        public decimal WastageQty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner {\n");
            sb.Append("  Available: ").Append(Available).Append('\n');
            sb.Append("  BatchSN: ").Append(BatchSN).Append('\n');
            sb.Append("  CostingMethod: ").Append(CostingMethod).Append('\n');
            sb.Append("  ExpectedQuantity: ").Append(ExpectedQuantity).Append('\n');
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append('\n');
            sb.Append("  IsBackflush: ").Append(IsBackflush).Append('\n');
            sb.Append("  IsReserved: ").Append(IsReserved).Append('\n');
            sb.Append("  LocationID: ").Append(LocationID).Append('\n');
            sb.Append("  LocationName: ").Append(LocationName).Append('\n');
            sb.Append("  ProductCode: ").Append(ProductCode).Append('\n');
            sb.Append("  ProductCost: ").Append(ProductCost).Append('\n');
            sb.Append("  ProductID: ").Append(ProductID).Append('\n');
            sb.Append("  ProductName: ").Append(ProductName).Append('\n');
            sb.Append("  Quantity: ").Append(Quantity).Append('\n');
            sb.Append("  ReservedQuantity: ").Append(ReservedQuantity).Append('\n');
            sb.Append("  RunComponentID: ").Append(RunComponentID).Append('\n');
            sb.Append("  Unit: ").Append(Unit).Append('\n');
            sb.Append("  UnitCost: ").Append(UnitCost).Append('\n');
            sb.Append("  WastagePercent: ").Append(WastagePercent).Append('\n');
            sb.Append("  WastageQty: ").Append(WastageQty).Append('\n');
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