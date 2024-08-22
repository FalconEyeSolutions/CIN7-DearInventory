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
    /// CompleteRunOperation200ResponseRunsInnerOperationsInner
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="CompleteRunOperation200ResponseRunsInnerOperationsInner" /> class.
    /// </remarks>
    /// <param name="actualTime">actualTime.</param>
    /// <param name="attachments">attachments.</param>
    /// <param name="coManStatus">coManStatus.</param>
    /// <param name="coManTaskLines">coManTaskLines.</param>
    /// <param name="coManTasks">coManTasks.</param>
    /// <param name="components">components.</param>
    /// <param name="dueDate">dueDate.</param>
    /// <param name="endDate">endDate.</param>
    /// <param name="finishedProducts">finishedProducts.</param>
    /// <param name="inputProducts">inputProducts.</param>
    /// <param name="isBackflush">isBackflush.</param>
    /// <param name="isDropShip">isDropShip.</param>
    /// <param name="manualEndDate">manualEndDate.</param>
    /// <param name="manualStartDate">manualStartDate.</param>
    /// <param name="name">name.</param>
    /// <param name="notes">notes.</param>
    /// <param name="operationID">operationID.</param>
    /// <param name="operationType">operationType.</param>
    /// <param name="order">order.</param>
    /// <param name="outputProducts">outputProducts.</param>
    /// <param name="plannedTime">plannedTime.</param>
    /// <param name="resourceCosts">resourceCosts.</param>
    /// <param name="resources">resources.</param>
    /// <param name="startDate">startDate.</param>
    /// <param name="status">status.</param>
    /// <param name="suspendReason">suspendReason.</param>
    /// <param name="unitsPerCycle">unitsPerCycle.</param>
    /// <param name="workCenterCode">workCenterCode.</param>
    /// <param name="workCenterID">workCenterID.</param>
    /// <param name="workCenterName">workCenterName.</param>
    [DataContract(Name = "Complete_Run_Operation_200_response_Runs_inner_Operations_inner")]
    public partial class CompleteRunOperation200ResponseRunsInnerOperationsInner(decimal actualTime = default, List<CompleteRunOperation200ResponseRunsInnerOperationsInnerAttachmentsInner> attachments = default, object coManStatus = default, List<string> coManTaskLines = default, List<string> coManTasks = default, List<CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner> components = default, object dueDate = default, string endDate = default, List<string> finishedProducts = default, List<string> inputProducts = default, bool isBackflush = default, bool isDropShip = default, string manualEndDate = default, string manualStartDate = default, string name = default, List<string> notes = default, string operationID = default, string operationType = default, decimal order = default, List<string> outputProducts = default, decimal plannedTime = default, List<CompleteRunOperation200ResponseRunsInnerOperationsInnerResourceCostsInner> resourceCosts = default, List<CompleteRunOperation200ResponseRunsInnerOperationsInnerResourcesInner> resources = default, string startDate = default, string status = default, object suspendReason = default, decimal unitsPerCycle = default, string workCenterCode = default, string workCenterID = default, string workCenterName = default) : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ActualTime
        /// </summary>
        [DataMember(Name = "ActualTime", EmitDefaultValue = false)]
        public decimal ActualTime { get; set; } = actualTime;

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "Attachments", EmitDefaultValue = false)]
        public List<CompleteRunOperation200ResponseRunsInnerOperationsInnerAttachmentsInner> Attachments { get; set; } = attachments;

        /// <summary>
        /// Gets or Sets CoManStatus
        /// </summary>
        [DataMember(Name = "CoManStatus", EmitDefaultValue = true)]
        public object CoManStatus { get; set; } = coManStatus;

        /// <summary>
        /// Gets or Sets CoManTaskLines
        /// </summary>
        [DataMember(Name = "CoManTaskLines", EmitDefaultValue = false)]
        public List<string> CoManTaskLines { get; set; } = coManTaskLines;

        /// <summary>
        /// Gets or Sets CoManTasks
        /// </summary>
        [DataMember(Name = "CoManTasks", EmitDefaultValue = false)]
        public List<string> CoManTasks { get; set; } = coManTasks;

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "Components", EmitDefaultValue = false)]
        public List<CompleteRunOperation200ResponseRunsInnerOperationsInnerComponentsInner> Components { get; set; } = components;

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "DueDate", EmitDefaultValue = true)]
        public object DueDate { get; set; } = dueDate;

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "EndDate", EmitDefaultValue = false)]
        public string EndDate { get; set; } = endDate;

        /// <summary>
        /// Gets or Sets FinishedProducts
        /// </summary>
        [DataMember(Name = "FinishedProducts", EmitDefaultValue = false)]
        public List<string> FinishedProducts { get; set; } = finishedProducts;

        /// <summary>
        /// Gets or Sets InputProducts
        /// </summary>
        [DataMember(Name = "InputProducts", EmitDefaultValue = false)]
        public List<string> InputProducts { get; set; } = inputProducts;

        /// <summary>
        /// Gets or Sets IsBackflush
        /// </summary>
        [DataMember(Name = "IsBackflush", EmitDefaultValue = true)]
        public bool IsBackflush { get; set; } = isBackflush;

        /// <summary>
        /// Gets or Sets IsDropShip
        /// </summary>
        [DataMember(Name = "IsDropShip", EmitDefaultValue = true)]
        public bool IsDropShip { get; set; } = isDropShip;

        /// <summary>
        /// Gets or Sets ManualEndDate
        /// </summary>
        [DataMember(Name = "ManualEndDate", EmitDefaultValue = false)]
        public string ManualEndDate { get; set; } = manualEndDate;

        /// <summary>
        /// Gets or Sets ManualStartDate
        /// </summary>
        [DataMember(Name = "ManualStartDate", EmitDefaultValue = false)]
        public string ManualStartDate { get; set; } = manualStartDate;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; } = name;

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "Notes", EmitDefaultValue = false)]
        public List<string> Notes { get; set; } = notes;

        /// <summary>
        /// Gets or Sets OperationID
        /// </summary>
        [DataMember(Name = "OperationID", EmitDefaultValue = false)]
        public string OperationID { get; set; } = operationID;

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        [DataMember(Name = "OperationType", EmitDefaultValue = false)]
        public string OperationType { get; set; } = operationType;

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "Order", EmitDefaultValue = false)]
        public decimal Order { get; set; } = order;

        /// <summary>
        /// Gets or Sets OutputProducts
        /// </summary>
        [DataMember(Name = "OutputProducts", EmitDefaultValue = false)]
        public List<string> OutputProducts { get; set; } = outputProducts;

        /// <summary>
        /// Gets or Sets PlannedTime
        /// </summary>
        [DataMember(Name = "PlannedTime", EmitDefaultValue = false)]
        public decimal PlannedTime { get; set; } = plannedTime;

        /// <summary>
        /// Gets or Sets ResourceCosts
        /// </summary>
        [DataMember(Name = "ResourceCosts", EmitDefaultValue = false)]
        public List<CompleteRunOperation200ResponseRunsInnerOperationsInnerResourceCostsInner> ResourceCosts { get; set; } = resourceCosts;

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "Resources", EmitDefaultValue = false)]
        public List<CompleteRunOperation200ResponseRunsInnerOperationsInnerResourcesInner> Resources { get; set; } = resources;

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "StartDate", EmitDefaultValue = false)]
        public string StartDate { get; set; } = startDate;

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; } = status;

        /// <summary>
        /// Gets or Sets SuspendReason
        /// </summary>
        [DataMember(Name = "SuspendReason", EmitDefaultValue = true)]
        public object SuspendReason { get; set; } = suspendReason;

        /// <summary>
        /// Gets or Sets UnitsPerCycle
        /// </summary>
        [DataMember(Name = "UnitsPerCycle", EmitDefaultValue = false)]
        public decimal UnitsPerCycle { get; set; } = unitsPerCycle;

        /// <summary>
        /// Gets or Sets WorkCenterCode
        /// </summary>
        [DataMember(Name = "WorkCenterCode", EmitDefaultValue = false)]
        public string WorkCenterCode { get; set; } = workCenterCode;

        /// <summary>
        /// Gets or Sets WorkCenterID
        /// </summary>
        [DataMember(Name = "WorkCenterID", EmitDefaultValue = false)]
        public string WorkCenterID { get; set; } = workCenterID;

        /// <summary>
        /// Gets or Sets WorkCenterName
        /// </summary>
        [DataMember(Name = "WorkCenterName", EmitDefaultValue = false)]
        public string WorkCenterName { get; set; } = workCenterName;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class CompleteRunOperation200ResponseRunsInnerOperationsInner {\n");
            sb.Append("  ActualTime: ").Append(ActualTime).Append('\n');
            sb.Append("  Attachments: ").Append(Attachments).Append('\n');
            sb.Append("  CoManStatus: ").Append(CoManStatus).Append('\n');
            sb.Append("  CoManTaskLines: ").Append(CoManTaskLines).Append('\n');
            sb.Append("  CoManTasks: ").Append(CoManTasks).Append('\n');
            sb.Append("  Components: ").Append(Components).Append('\n');
            sb.Append("  DueDate: ").Append(DueDate).Append('\n');
            sb.Append("  EndDate: ").Append(EndDate).Append('\n');
            sb.Append("  FinishedProducts: ").Append(FinishedProducts).Append('\n');
            sb.Append("  InputProducts: ").Append(InputProducts).Append('\n');
            sb.Append("  IsBackflush: ").Append(IsBackflush).Append('\n');
            sb.Append("  IsDropShip: ").Append(IsDropShip).Append('\n');
            sb.Append("  ManualEndDate: ").Append(ManualEndDate).Append('\n');
            sb.Append("  ManualStartDate: ").Append(ManualStartDate).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Notes: ").Append(Notes).Append('\n');
            sb.Append("  OperationID: ").Append(OperationID).Append('\n');
            sb.Append("  OperationType: ").Append(OperationType).Append('\n');
            sb.Append("  Order: ").Append(Order).Append('\n');
            sb.Append("  OutputProducts: ").Append(OutputProducts).Append('\n');
            sb.Append("  PlannedTime: ").Append(PlannedTime).Append('\n');
            sb.Append("  ResourceCosts: ").Append(ResourceCosts).Append('\n');
            sb.Append("  Resources: ").Append(Resources).Append('\n');
            sb.Append("  StartDate: ").Append(StartDate).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  SuspendReason: ").Append(SuspendReason).Append('\n');
            sb.Append("  UnitsPerCycle: ").Append(UnitsPerCycle).Append('\n');
            sb.Append("  WorkCenterCode: ").Append(WorkCenterCode).Append('\n');
            sb.Append("  WorkCenterID: ").Append(WorkCenterID).Append('\n');
            sb.Append("  WorkCenterName: ").Append(WorkCenterName).Append('\n');
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