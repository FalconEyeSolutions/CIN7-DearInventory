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
    /// ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200ResponseProductionOrdersInner
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200ResponseProductionOrdersInner" /> class.
    /// </remarks>
    /// <param name="bOMName">bOMName.</param>
    /// <param name="bOMQuantity">bOMQuantity.</param>
    /// <param name="bOMVersion">bOMVersion.</param>
    /// <param name="capacityCalculationType">capacityCalculationType.</param>
    /// <param name="comments">comments.</param>
    /// <param name="completionDate">completionDate.</param>
    /// <param name="costingMethod">costingMethod.</param>
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
    /// <param name="deliveries">deliveries.</param>
    /// <param name="finishedGoodsAccountCode">finishedGoodsAccountCode.</param>
    /// <param name="isIgnoreLeadTime">isIgnoreLeadTime.</param>
    /// <param name="issueMethodComponent">issueMethodComponent.</param>
    /// <param name="issueMethodParameter">issueMethodParameter.</param>
    /// <param name="locationID">locationID.</param>
    /// <param name="locationName">locationName.</param>
    /// <param name="operations">operations.</param>
    /// <param name="orderCycleTime">orderCycleTime.</param>
    /// <param name="orderNumber">orderNumber.</param>
    /// <param name="orderStatus">orderStatus.</param>
    /// <param name="plannedBy">plannedBy.</param>
    /// <param name="productID">productID.</param>
    /// <param name="productName">productName.</param>
    /// <param name="productSKU">productSKU.</param>
    /// <param name="productionOrderID">productionOrderID.</param>
    /// <param name="quantity">quantity.</param>
    /// <param name="releaseDate">releaseDate.</param>
    /// <param name="releasedBy">releasedBy.</param>
    /// <param name="requiredByDate">requiredByDate.</param>
    /// <param name="retailID">retailID.</param>
    /// <param name="runSize">runSize.</param>
    /// <param name="sourceName">sourceName.</param>
    /// <param name="sourceTaskID">sourceTaskID.</param>
    /// <param name="sourceTaskNumber">sourceTaskNumber.</param>
    /// <param name="sourceTasks">sourceTasks.</param>
    /// <param name="startDate">startDate.</param>
    /// <param name="startUpdate">startUpdate.</param>
    /// <param name="status">status.</param>
    /// <param name="tags">tags.</param>
    /// <param name="unit">unit.</param>
    /// <param name="wIPAccountCode">wIPAccountCode.</param>
    /// <param name="warehouseID">warehouseID.</param>
    /// <param name="warehouseName">warehouseName.</param>
    [DataContract(Name = "productionOrder_Allowrecalculatedates__Allowrecalculatecyclesandquantities__put_200_response_ProductionOrders_inner")]
    public partial class ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200ResponseProductionOrdersInner(object bOMName = default, decimal bOMQuantity = default, decimal bOMVersion = default, string capacityCalculationType = default, object comments = default, object completionDate = default, string costingMethod = default, string customField1 = default, string customField10 = default, string customField2 = default, string customField3 = default, string customField4 = default, string customField5 = default, string customField6 = default, string customField7 = default, string customField8 = default, string customField9 = default, List<string> deliveries = default, string finishedGoodsAccountCode = default, bool isIgnoreLeadTime = default, decimal issueMethodComponent = default, decimal issueMethodParameter = default, string locationID = default, string locationName = default, List<Authorize200ResponseProductionOrdersInnerOperationsInner> operations = default, object orderCycleTime = default, string orderNumber = default, string orderStatus = default, object plannedBy = default, string productID = default, string productName = default, string productSKU = default, string productionOrderID = default, decimal quantity = default, string releaseDate = default, object releasedBy = default, string requiredByDate = default, object retailID = default, decimal runSize = default, decimal sourceName = default, object sourceTaskID = default, object sourceTaskNumber = default, List<Authorize200ResponseProductionOrdersInnerSourceTasksInner> sourceTasks = default, string startDate = default, bool startUpdate = default, string status = default, object tags = default, string unit = default, string wIPAccountCode = default, object warehouseID = default, object warehouseName = default) : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets BOMName
        /// </summary>
        [DataMember(Name = "BOMName", EmitDefaultValue = true)]
        public object BOMName { get; set; } = bOMName;

        /// <summary>
        /// Gets or Sets BOMQuantity
        /// </summary>
        [DataMember(Name = "BOMQuantity", EmitDefaultValue = false)]
        public decimal BOMQuantity { get; set; } = bOMQuantity;

        /// <summary>
        /// Gets or Sets BOMVersion
        /// </summary>
        [DataMember(Name = "BOMVersion", EmitDefaultValue = false)]
        public decimal BOMVersion { get; set; } = bOMVersion;

        /// <summary>
        /// Gets or Sets CapacityCalculationType
        /// </summary>
        [DataMember(Name = "CapacityCalculationType", EmitDefaultValue = false)]
        public string CapacityCalculationType { get; set; } = capacityCalculationType;

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "Comments", EmitDefaultValue = true)]
        public object Comments { get; set; } = comments;

        /// <summary>
        /// Gets or Sets CompletionDate
        /// </summary>
        [DataMember(Name = "CompletionDate", EmitDefaultValue = true)]
        public object CompletionDate { get; set; } = completionDate;

        /// <summary>
        /// Gets or Sets CostingMethod
        /// </summary>
        [DataMember(Name = "CostingMethod", EmitDefaultValue = false)]
        public string CostingMethod { get; set; } = costingMethod;

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
        /// Gets or Sets Deliveries
        /// </summary>
        [DataMember(Name = "Deliveries", EmitDefaultValue = false)]
        public List<string> Deliveries { get; set; } = deliveries;

        /// <summary>
        /// Gets or Sets FinishedGoodsAccountCode
        /// </summary>
        [DataMember(Name = "FinishedGoodsAccountCode", EmitDefaultValue = false)]
        public string FinishedGoodsAccountCode { get; set; } = finishedGoodsAccountCode;

        /// <summary>
        /// Gets or Sets IsIgnoreLeadTime
        /// </summary>
        [DataMember(Name = "IsIgnoreLeadTime", EmitDefaultValue = true)]
        public bool IsIgnoreLeadTime { get; set; } = isIgnoreLeadTime;

        /// <summary>
        /// Gets or Sets IssueMethodComponent
        /// </summary>
        [DataMember(Name = "IssueMethodComponent", EmitDefaultValue = false)]
        public decimal IssueMethodComponent { get; set; } = issueMethodComponent;

        /// <summary>
        /// Gets or Sets IssueMethodParameter
        /// </summary>
        [DataMember(Name = "IssueMethodParameter", EmitDefaultValue = false)]
        public decimal IssueMethodParameter { get; set; } = issueMethodParameter;

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name = "LocationID", EmitDefaultValue = false)]
        public string LocationID { get; set; } = locationID;

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name = "LocationName", EmitDefaultValue = false)]
        public string LocationName { get; set; } = locationName;

        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name = "Operations", EmitDefaultValue = false)]
        public List<Authorize200ResponseProductionOrdersInnerOperationsInner> Operations { get; set; } = operations;

        /// <summary>
        /// Gets or Sets OrderCycleTime
        /// </summary>
        [DataMember(Name = "OrderCycleTime", EmitDefaultValue = true)]
        public object OrderCycleTime { get; set; } = orderCycleTime;

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "OrderNumber", EmitDefaultValue = false)]
        public string OrderNumber { get; set; } = orderNumber;

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name = "OrderStatus", EmitDefaultValue = false)]
        public string OrderStatus { get; set; } = orderStatus;

        /// <summary>
        /// Gets or Sets PlannedBy
        /// </summary>
        [DataMember(Name = "PlannedBy", EmitDefaultValue = true)]
        public object PlannedBy { get; set; } = plannedBy;

        /// <summary>
        /// Gets or Sets ProductID
        /// </summary>
        [DataMember(Name = "ProductID", EmitDefaultValue = false)]
        public string ProductID { get; set; } = productID;

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "ProductName", EmitDefaultValue = false)]
        public string ProductName { get; set; } = productName;

        /// <summary>
        /// Gets or Sets ProductSKU
        /// </summary>
        [DataMember(Name = "ProductSKU", EmitDefaultValue = false)]
        public string ProductSKU { get; set; } = productSKU;

        /// <summary>
        /// Gets or Sets ProductionOrderID
        /// </summary>
        [DataMember(Name = "ProductionOrderID", EmitDefaultValue = false)]
        public string ProductionOrderID { get; set; } = productionOrderID;

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; } = quantity;

        /// <summary>
        /// Gets or Sets ReleaseDate
        /// </summary>
        [DataMember(Name = "ReleaseDate", EmitDefaultValue = false)]
        public string ReleaseDate { get; set; } = releaseDate;

        /// <summary>
        /// Gets or Sets ReleasedBy
        /// </summary>
        [DataMember(Name = "ReleasedBy", EmitDefaultValue = true)]
        public object ReleasedBy { get; set; } = releasedBy;

        /// <summary>
        /// Gets or Sets RequiredByDate
        /// </summary>
        [DataMember(Name = "RequiredByDate", EmitDefaultValue = false)]
        public string RequiredByDate { get; set; } = requiredByDate;

        /// <summary>
        /// Gets or Sets RetailID
        /// </summary>
        [DataMember(Name = "RetailID", EmitDefaultValue = true)]
        public object RetailID { get; set; } = retailID;

        /// <summary>
        /// Gets or Sets RunSize
        /// </summary>
        [DataMember(Name = "RunSize", EmitDefaultValue = false)]
        public decimal RunSize { get; set; } = runSize;

        /// <summary>
        /// Gets or Sets SourceName
        /// </summary>
        [DataMember(Name = "SourceName", EmitDefaultValue = false)]
        public decimal SourceName { get; set; } = sourceName;

        /// <summary>
        /// Gets or Sets SourceTaskID
        /// </summary>
        [DataMember(Name = "SourceTaskID", EmitDefaultValue = true)]
        public object SourceTaskID { get; set; } = sourceTaskID;

        /// <summary>
        /// Gets or Sets SourceTaskNumber
        /// </summary>
        [DataMember(Name = "SourceTaskNumber", EmitDefaultValue = true)]
        public object SourceTaskNumber { get; set; } = sourceTaskNumber;

        /// <summary>
        /// Gets or Sets SourceTasks
        /// </summary>
        [DataMember(Name = "SourceTasks", EmitDefaultValue = false)]
        public List<Authorize200ResponseProductionOrdersInnerSourceTasksInner> SourceTasks { get; set; } = sourceTasks;

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "StartDate", EmitDefaultValue = false)]
        public string StartDate { get; set; } = startDate;

        /// <summary>
        /// Gets or Sets StartUpdate
        /// </summary>
        [DataMember(Name = "StartUpdate", EmitDefaultValue = true)]
        public bool StartUpdate { get; set; } = startUpdate;

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; } = status;

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "Tags", EmitDefaultValue = true)]
        public object Tags { get; set; } = tags;

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "Unit", EmitDefaultValue = false)]
        public string Unit { get; set; } = unit;

        /// <summary>
        /// Gets or Sets WIPAccountCode
        /// </summary>
        [DataMember(Name = "WIPAccountCode", EmitDefaultValue = false)]
        public string WIPAccountCode { get; set; } = wIPAccountCode;

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name = "WarehouseID", EmitDefaultValue = true)]
        public object WarehouseID { get; set; } = warehouseID;

        /// <summary>
        /// Gets or Sets WarehouseName
        /// </summary>
        [DataMember(Name = "WarehouseName", EmitDefaultValue = true)]
        public object WarehouseName { get; set; } = warehouseName;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class ProductionOrderAllowrecalculatedatesAllowrecalculatecyclesandquantitiesPut200ResponseProductionOrdersInner {\n");
            sb.Append("  BOMName: ").Append(BOMName).Append('\n');
            sb.Append("  BOMQuantity: ").Append(BOMQuantity).Append('\n');
            sb.Append("  BOMVersion: ").Append(BOMVersion).Append('\n');
            sb.Append("  CapacityCalculationType: ").Append(CapacityCalculationType).Append('\n');
            sb.Append("  Comments: ").Append(Comments).Append('\n');
            sb.Append("  CompletionDate: ").Append(CompletionDate).Append('\n');
            sb.Append("  CostingMethod: ").Append(CostingMethod).Append('\n');
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
            sb.Append("  Deliveries: ").Append(Deliveries).Append('\n');
            sb.Append("  FinishedGoodsAccountCode: ").Append(FinishedGoodsAccountCode).Append('\n');
            sb.Append("  IsIgnoreLeadTime: ").Append(IsIgnoreLeadTime).Append('\n');
            sb.Append("  IssueMethodComponent: ").Append(IssueMethodComponent).Append('\n');
            sb.Append("  IssueMethodParameter: ").Append(IssueMethodParameter).Append('\n');
            sb.Append("  LocationID: ").Append(LocationID).Append('\n');
            sb.Append("  LocationName: ").Append(LocationName).Append('\n');
            sb.Append("  Operations: ").Append(Operations).Append('\n');
            sb.Append("  OrderCycleTime: ").Append(OrderCycleTime).Append('\n');
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append('\n');
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append('\n');
            sb.Append("  PlannedBy: ").Append(PlannedBy).Append('\n');
            sb.Append("  ProductID: ").Append(ProductID).Append('\n');
            sb.Append("  ProductName: ").Append(ProductName).Append('\n');
            sb.Append("  ProductSKU: ").Append(ProductSKU).Append('\n');
            sb.Append("  ProductionOrderID: ").Append(ProductionOrderID).Append('\n');
            sb.Append("  Quantity: ").Append(Quantity).Append('\n');
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append('\n');
            sb.Append("  ReleasedBy: ").Append(ReleasedBy).Append('\n');
            sb.Append("  RequiredByDate: ").Append(RequiredByDate).Append('\n');
            sb.Append("  RetailID: ").Append(RetailID).Append('\n');
            sb.Append("  RunSize: ").Append(RunSize).Append('\n');
            sb.Append("  SourceName: ").Append(SourceName).Append('\n');
            sb.Append("  SourceTaskID: ").Append(SourceTaskID).Append('\n');
            sb.Append("  SourceTaskNumber: ").Append(SourceTaskNumber).Append('\n');
            sb.Append("  SourceTasks: ").Append(SourceTasks).Append('\n');
            sb.Append("  StartDate: ").Append(StartDate).Append('\n');
            sb.Append("  StartUpdate: ").Append(StartUpdate).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  Tags: ").Append(Tags).Append('\n');
            sb.Append("  Unit: ").Append(Unit).Append('\n');
            sb.Append("  WIPAccountCode: ").Append(WIPAccountCode).Append('\n');
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append('\n');
            sb.Append("  WarehouseName: ").Append(WarehouseName).Append('\n');
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