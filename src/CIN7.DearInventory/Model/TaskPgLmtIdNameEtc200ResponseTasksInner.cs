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
    /// TaskPgLmtIdNameEtc200ResponseTasksInner
    /// </summary>
    [DataContract(Name = "Task_Pg__Lmt__Id__Name__Etc_200_response_Tasks_inner")]
    public partial class TaskPgLmtIdNameEtc200ResponseTasksInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPgLmtIdNameEtc200ResponseTasksInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected TaskPgLmtIdNameEtc200ResponseTasksInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPgLmtIdNameEtc200ResponseTasksInner" /> class.
        /// </summary>
        /// <param name="assignedBy">assignedBy (required).</param>
        /// <param name="assignedTo">assignedTo (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="completedDate">completedDate (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="entityID">entityID (required).</param>
        /// <param name="entityType">entityType (required).</param>
        /// <param name="iD">iD (required).</param>
        /// <param name="isAllDay">isAllDay (required).</param>
        /// <param name="isImportant">isImportant (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="taskStatus">taskStatus (required).</param>
        /// <param name="voidDate">voidDate (required).</param>
        /// <param name="workflowName">workflowName (required).</param>
        public TaskPgLmtIdNameEtc200ResponseTasksInner(string assignedBy = default, string assignedTo = default, string category = default, object completedDate = default, string description = default, string endDate = default, string entityID = default, string entityType = default, string iD = default, bool isAllDay = default, bool isImportant = default, string name = default, string startDate = default, string taskStatus = default, object voidDate = default, object workflowName = default)
        {
            // to ensure "assignedBy" is required (not null)
            ArgumentNullException.ThrowIfNull(assignedBy);
            AssignedBy = assignedBy;
            // to ensure "assignedTo" is required (not null)
            ArgumentNullException.ThrowIfNull(assignedTo);
            AssignedTo = assignedTo;
            // to ensure "category" is required (not null)
            ArgumentNullException.ThrowIfNull(category);
            Category = category;
            // to ensure "completedDate" is required (not null)
            ArgumentNullException.ThrowIfNull(completedDate);
            CompletedDate = completedDate;
            // to ensure "description" is required (not null)
            ArgumentNullException.ThrowIfNull(description);
            Description = description;
            // to ensure "endDate" is required (not null)
            ArgumentNullException.ThrowIfNull(endDate);
            EndDate = endDate;
            // to ensure "entityID" is required (not null)
            ArgumentNullException.ThrowIfNull(entityID);
            EntityID = entityID;
            // to ensure "entityType" is required (not null)
            ArgumentNullException.ThrowIfNull(entityType);
            EntityType = entityType;
            // to ensure "iD" is required (not null)
            ArgumentNullException.ThrowIfNull(iD);
            ID = iD;
            IsAllDay = isAllDay;
            IsImportant = isImportant;
            // to ensure "name" is required (not null)
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
            // to ensure "startDate" is required (not null)
            ArgumentNullException.ThrowIfNull(startDate);
            StartDate = startDate;
            // to ensure "taskStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(taskStatus);
            TaskStatus = taskStatus;
            // to ensure "voidDate" is required (not null)
            ArgumentNullException.ThrowIfNull(voidDate);
            VoidDate = voidDate;
            // to ensure "workflowName" is required (not null)
            ArgumentNullException.ThrowIfNull(workflowName);
            WorkflowName = workflowName;
        }

        /// <summary>
        /// Gets or Sets AssignedBy
        /// </summary>
        [DataMember(Name = "AssignedBy", IsRequired = true, EmitDefaultValue = true)]
        public string AssignedBy { get; set; }

        /// <summary>
        /// Gets or Sets AssignedTo
        /// </summary>
        [DataMember(Name = "AssignedTo", IsRequired = true, EmitDefaultValue = true)]
        public string AssignedTo { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "Category", IsRequired = true, EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDate
        /// </summary>
        [DataMember(Name = "CompletedDate", IsRequired = true, EmitDefaultValue = true)]
        public object CompletedDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "EndDate", IsRequired = true, EmitDefaultValue = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets EntityID
        /// </summary>
        [DataMember(Name = "EntityID", IsRequired = true, EmitDefaultValue = true)]
        public string EntityID { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "EntityType", IsRequired = true, EmitDefaultValue = true)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", IsRequired = true, EmitDefaultValue = true)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets IsAllDay
        /// </summary>
        [DataMember(Name = "IsAllDay", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAllDay { get; set; }

        /// <summary>
        /// Gets or Sets IsImportant
        /// </summary>
        [DataMember(Name = "IsImportant", IsRequired = true, EmitDefaultValue = true)]
        public bool IsImportant { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "StartDate", IsRequired = true, EmitDefaultValue = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TaskStatus
        /// </summary>
        [DataMember(Name = "TaskStatus", IsRequired = true, EmitDefaultValue = true)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// Gets or Sets VoidDate
        /// </summary>
        [DataMember(Name = "VoidDate", IsRequired = true, EmitDefaultValue = true)]
        public object VoidDate { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowName
        /// </summary>
        [DataMember(Name = "WorkflowName", IsRequired = true, EmitDefaultValue = true)]
        public object WorkflowName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class TaskPgLmtIdNameEtc200ResponseTasksInner {\n");
            sb.Append("  AssignedBy: ").Append(AssignedBy).Append('\n');
            sb.Append("  AssignedTo: ").Append(AssignedTo).Append('\n');
            sb.Append("  Category: ").Append(Category).Append('\n');
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append('\n');
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  EndDate: ").Append(EndDate).Append('\n');
            sb.Append("  EntityID: ").Append(EntityID).Append('\n');
            sb.Append("  EntityType: ").Append(EntityType).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  IsAllDay: ").Append(IsAllDay).Append('\n');
            sb.Append("  IsImportant: ").Append(IsImportant).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  StartDate: ").Append(StartDate).Append('\n');
            sb.Append("  TaskStatus: ").Append(TaskStatus).Append('\n');
            sb.Append("  VoidDate: ").Append(VoidDate).Append('\n');
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append('\n');
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
