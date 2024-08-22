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
    /// ProductionProductionbomPostRequestProductionBOMsInner
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ProductionProductionbomPostRequestProductionBOMsInner" /> class.
    /// </remarks>
    /// <param name="bufferPercent">bufferPercent.</param>
    /// <param name="componentProductionLeadTime">componentProductionLeadTime.</param>
    /// <param name="ignoreCumulativeLeadTime">ignoreCumulativeLeadTime.</param>
    /// <param name="instructionUrl">instructionUrl.</param>
    /// <param name="issueMethod">issueMethod.</param>
    /// <param name="operations">operations.</param>
    /// <param name="outputQuantity">outputQuantity.</param>
    [DataContract(Name = "productionProductionbom_post_request_ProductionBOMs_inner")]
    public partial class ProductionProductionbomPostRequestProductionBOMsInner(decimal bufferPercent = default, decimal componentProductionLeadTime = default, bool ignoreCumulativeLeadTime = default, string instructionUrl = default, decimal issueMethod = default, List<ProductionProductionbomPostRequestProductionBOMsInnerOperationsInner> operations = default, decimal outputQuantity = default) : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BufferPercent
        /// </summary>
        [DataMember(Name = "BufferPercent", EmitDefaultValue = false)]
        public decimal BufferPercent { get; set; } = bufferPercent;

        /// <summary>
        /// Gets or Sets ComponentProductionLeadTime
        /// </summary>
        [DataMember(Name = "ComponentProductionLeadTime", EmitDefaultValue = false)]
        public decimal ComponentProductionLeadTime { get; set; } = componentProductionLeadTime;

        /// <summary>
        /// Gets or Sets IgnoreCumulativeLeadTime
        /// </summary>
        [DataMember(Name = "IgnoreCumulativeLeadTime", EmitDefaultValue = true)]
        public bool IgnoreCumulativeLeadTime { get; set; } = ignoreCumulativeLeadTime;

        /// <summary>
        /// Gets or Sets InstructionUrl
        /// </summary>
        [DataMember(Name = "InstructionUrl", EmitDefaultValue = false)]
        public string InstructionUrl { get; set; } = instructionUrl;

        /// <summary>
        /// Gets or Sets IssueMethod
        /// </summary>
        [DataMember(Name = "IssueMethod", EmitDefaultValue = false)]
        public decimal IssueMethod { get; set; } = issueMethod;

        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name = "Operations", EmitDefaultValue = false)]
        public List<ProductionProductionbomPostRequestProductionBOMsInnerOperationsInner> Operations { get; set; } = operations;

        /// <summary>
        /// Gets or Sets OutputQuantity
        /// </summary>
        [DataMember(Name = "OutputQuantity", EmitDefaultValue = false)]
        public decimal OutputQuantity { get; set; } = outputQuantity;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class ProductionProductionbomPostRequestProductionBOMsInner {\n");
            sb.Append("  BufferPercent: ").Append(BufferPercent).Append('\n');
            sb.Append("  ComponentProductionLeadTime: ").Append(ComponentProductionLeadTime).Append('\n');
            sb.Append("  IgnoreCumulativeLeadTime: ").Append(IgnoreCumulativeLeadTime).Append('\n');
            sb.Append("  InstructionUrl: ").Append(InstructionUrl).Append('\n');
            sb.Append("  IssueMethod: ").Append(IssueMethod).Append('\n');
            sb.Append("  Operations: ").Append(Operations).Append('\n');
            sb.Append("  OutputQuantity: ").Append(OutputQuantity).Append('\n');
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
