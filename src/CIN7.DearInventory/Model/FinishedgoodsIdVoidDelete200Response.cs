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
    /// FinishedgoodsIdVoidDelete200Response
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="FinishedgoodsIdVoidDelete200Response" /> class.
    /// </remarks>
    /// <param name="account">account.</param>
    /// <param name="assemblyInstructionURL">assemblyInstructionURL.</param>
    /// <param name="assemblyNumber">assemblyNumber.</param>
    /// <param name="batchSN">batchSN.</param>
    /// <param name="bin">bin.</param>
    /// <param name="binID">binID.</param>
    /// <param name="completionDate">completionDate.</param>
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
    /// <param name="errors">errors.</param>
    /// <param name="expiryDate">expiryDate.</param>
    /// <param name="location">location.</param>
    /// <param name="locationID">locationID.</param>
    /// <param name="notes">notes.</param>
    /// <param name="orderLines">orderLines.</param>
    /// <param name="pickLines">pickLines.</param>
    /// <param name="productCode">productCode.</param>
    /// <param name="productID">productID.</param>
    /// <param name="productName">productName.</param>
    /// <param name="quantity">quantity.</param>
    /// <param name="status">status.</param>
    /// <param name="taskID">taskID.</param>
    /// <param name="transactions">transactions.</param>
    /// <param name="wIPAccount">wIPAccount.</param>
    /// <param name="wIPDate">wIPDate.</param>
    [DataContract(Name = "finishedgoods_Id__Void__delete_200_response")]
    public partial class FinishedgoodsIdVoidDelete200Response(string account = default, string assemblyInstructionURL = default, string assemblyNumber = default, string batchSN = default, object bin = default, object binID = default, string completionDate = default, string customField1 = default, string customField10 = default, string customField2 = default, string customField3 = default, string customField4 = default, string customField5 = default, string customField6 = default, string customField7 = default, string customField8 = default, string customField9 = default, List<string> errors = default, string expiryDate = default, string location = default, string locationID = default, object notes = default, List<string> orderLines = default, List<string> pickLines = default, string productCode = default, string productID = default, string productName = default, decimal quantity = default, string status = default, string taskID = default, List<string> transactions = default, string wIPAccount = default, string wIPDate = default) : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "Account", EmitDefaultValue = false)]
        public string Account { get; set; } = account;

        /// <summary>
        /// Gets or Sets AssemblyInstructionURL
        /// </summary>
        [DataMember(Name = "AssemblyInstructionURL", EmitDefaultValue = false)]
        public string AssemblyInstructionURL { get; set; } = assemblyInstructionURL;

        /// <summary>
        /// Gets or Sets AssemblyNumber
        /// </summary>
        [DataMember(Name = "AssemblyNumber", EmitDefaultValue = false)]
        public string AssemblyNumber { get; set; } = assemblyNumber;

        /// <summary>
        /// Gets or Sets BatchSN
        /// </summary>
        [DataMember(Name = "BatchSN", EmitDefaultValue = false)]
        public string BatchSN { get; set; } = batchSN;

        /// <summary>
        /// Gets or Sets Bin
        /// </summary>
        [DataMember(Name = "Bin", EmitDefaultValue = true)]
        public object Bin { get; set; } = bin;

        /// <summary>
        /// Gets or Sets BinID
        /// </summary>
        [DataMember(Name = "BinID", EmitDefaultValue = true)]
        public object BinID { get; set; } = binID;

        /// <summary>
        /// Gets or Sets CompletionDate
        /// </summary>
        [DataMember(Name = "CompletionDate", EmitDefaultValue = false)]
        public string CompletionDate { get; set; } = completionDate;

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
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "Errors", EmitDefaultValue = false)]
        public List<string> Errors { get; set; } = errors;

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
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "Notes", EmitDefaultValue = true)]
        public object Notes { get; set; } = notes;

        /// <summary>
        /// Gets or Sets OrderLines
        /// </summary>
        [DataMember(Name = "OrderLines", EmitDefaultValue = false)]
        public List<string> OrderLines { get; set; } = orderLines;

        /// <summary>
        /// Gets or Sets PickLines
        /// </summary>
        [DataMember(Name = "PickLines", EmitDefaultValue = false)]
        public List<string> PickLines { get; set; } = pickLines;

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "ProductCode", EmitDefaultValue = false)]
        public string ProductCode { get; set; } = productCode;

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
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; } = quantity;

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; } = status;

        /// <summary>
        /// Gets or Sets TaskID
        /// </summary>
        [DataMember(Name = "TaskID", EmitDefaultValue = false)]
        public string TaskID { get; set; } = taskID;

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "Transactions", EmitDefaultValue = false)]
        public List<string> Transactions { get; set; } = transactions;

        /// <summary>
        /// Gets or Sets WIPAccount
        /// </summary>
        [DataMember(Name = "WIPAccount", EmitDefaultValue = false)]
        public string WIPAccount { get; set; } = wIPAccount;

        /// <summary>
        /// Gets or Sets WIPDate
        /// </summary>
        [DataMember(Name = "WIPDate", EmitDefaultValue = false)]
        public string WIPDate { get; set; } = wIPDate;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class FinishedgoodsIdVoidDelete200Response {\n");
            sb.Append("  Account: ").Append(Account).Append('\n');
            sb.Append("  AssemblyInstructionURL: ").Append(AssemblyInstructionURL).Append('\n');
            sb.Append("  AssemblyNumber: ").Append(AssemblyNumber).Append('\n');
            sb.Append("  BatchSN: ").Append(BatchSN).Append('\n');
            sb.Append("  Bin: ").Append(Bin).Append('\n');
            sb.Append("  BinID: ").Append(BinID).Append('\n');
            sb.Append("  CompletionDate: ").Append(CompletionDate).Append('\n');
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
            sb.Append("  Errors: ").Append(Errors).Append('\n');
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append('\n');
            sb.Append("  Location: ").Append(Location).Append('\n');
            sb.Append("  LocationID: ").Append(LocationID).Append('\n');
            sb.Append("  Notes: ").Append(Notes).Append('\n');
            sb.Append("  OrderLines: ").Append(OrderLines).Append('\n');
            sb.Append("  PickLines: ").Append(PickLines).Append('\n');
            sb.Append("  ProductCode: ").Append(ProductCode).Append('\n');
            sb.Append("  ProductID: ").Append(ProductID).Append('\n');
            sb.Append("  ProductName: ").Append(ProductName).Append('\n');
            sb.Append("  Quantity: ").Append(Quantity).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  TaskID: ").Append(TaskID).Append('\n');
            sb.Append("  Transactions: ").Append(Transactions).Append('\n');
            sb.Append("  WIPAccount: ").Append(WIPAccount).Append('\n');
            sb.Append("  WIPDate: ").Append(WIPDate).Append('\n');
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