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
    /// ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInner
    /// </summary>
    [DataContract(Name = "productionProductionbom_Productid__Returnattachmentscontent__get_200_response_ProductionBOMs_inner_Operations_inner")]
    public partial class ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInner" /> class.
        /// </summary>
        /// <param name="attachments">attachments (required).</param>
        /// <param name="components">components (required).</param>
        /// <param name="cycleTime">cycleTime (required).</param>
        /// <param name="finishedProducts">finishedProducts (required).</param>
        /// <param name="inputProducts">inputProducts (required).</param>
        /// <param name="isBackflush">isBackflush (required).</param>
        /// <param name="isDropShip">isDropShip (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="notes">notes (required).</param>
        /// <param name="operationID">operationID (required).</param>
        /// <param name="operationLinks">operationLinks (required).</param>
        /// <param name="operationType">operationType (required).</param>
        /// <param name="order">order (required).</param>
        /// <param name="outputProducts">outputProducts (required).</param>
        /// <param name="resources">resources (required).</param>
        /// <param name="unitsPerCycle">unitsPerCycle (required).</param>
        /// <param name="variationComponents">variationComponents (required).</param>
        /// <param name="workCenterCoManProcurementType">workCenterCoManProcurementType (required).</param>
        /// <param name="workCenterID">workCenterID (required).</param>
        /// <param name="workCenterName">workCenterName (required).</param>
        public ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInner(List<string> attachments = default, List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerComponentsInner> components = default, decimal cycleTime = default, List<string> finishedProducts = default, List<string> inputProducts = default, bool isBackflush = default, bool isDropShip = default, string name = default, List<Authorize200ResponseProductionOrdersInnerOperationsInnerNotesInner> notes = default, string operationID = default, List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerOperationLinksInner> operationLinks = default, string operationType = default, decimal order = default, List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerOutputProductsInner> outputProducts = default, List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerResourcesInner> resources = default, decimal unitsPerCycle = default, List<string> variationComponents = default, object workCenterCoManProcurementType = default, string workCenterID = default, string workCenterName = default)
        {
            // to ensure "attachments" is required (not null)
            ArgumentNullException.ThrowIfNull(attachments);
            Attachments = attachments;
            // to ensure "components" is required (not null)
            ArgumentNullException.ThrowIfNull(components);
            Components = components;
            CycleTime = cycleTime;
            // to ensure "finishedProducts" is required (not null)
            ArgumentNullException.ThrowIfNull(finishedProducts);
            FinishedProducts = finishedProducts;
            // to ensure "inputProducts" is required (not null)
            ArgumentNullException.ThrowIfNull(inputProducts);
            InputProducts = inputProducts;
            IsBackflush = isBackflush;
            IsDropShip = isDropShip;
            // to ensure "name" is required (not null)
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
            // to ensure "notes" is required (not null)
            ArgumentNullException.ThrowIfNull(notes);
            Notes = notes;
            // to ensure "operationID" is required (not null)
            ArgumentNullException.ThrowIfNull(operationID);
            OperationID = operationID;
            // to ensure "operationLinks" is required (not null)
            ArgumentNullException.ThrowIfNull(operationLinks);
            OperationLinks = operationLinks;
            // to ensure "operationType" is required (not null)
            ArgumentNullException.ThrowIfNull(operationType);
            OperationType = operationType;
            Order = order;
            // to ensure "outputProducts" is required (not null)
            ArgumentNullException.ThrowIfNull(outputProducts);
            OutputProducts = outputProducts;
            // to ensure "resources" is required (not null)
            ArgumentNullException.ThrowIfNull(resources);
            Resources = resources;
            UnitsPerCycle = unitsPerCycle;
            // to ensure "variationComponents" is required (not null)
            ArgumentNullException.ThrowIfNull(variationComponents);
            VariationComponents = variationComponents;
            // to ensure "workCenterCoManProcurementType" is required (not null)
            ArgumentNullException.ThrowIfNull(workCenterCoManProcurementType);
            WorkCenterCoManProcurementType = workCenterCoManProcurementType;
            // to ensure "workCenterID" is required (not null)
            ArgumentNullException.ThrowIfNull(workCenterID);
            WorkCenterID = workCenterID;
            // to ensure "workCenterName" is required (not null)
            ArgumentNullException.ThrowIfNull(workCenterName);
            WorkCenterName = workCenterName;
        }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "Attachments", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "Components", IsRequired = true, EmitDefaultValue = true)]
        public List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerComponentsInner> Components { get; set; }

        /// <summary>
        /// Gets or Sets CycleTime
        /// </summary>
        [DataMember(Name = "CycleTime", IsRequired = true, EmitDefaultValue = true)]
        public decimal CycleTime { get; set; }

        /// <summary>
        /// Gets or Sets FinishedProducts
        /// </summary>
        [DataMember(Name = "FinishedProducts", IsRequired = true, EmitDefaultValue = true)]
        public List<string> FinishedProducts { get; set; }

        /// <summary>
        /// Gets or Sets InputProducts
        /// </summary>
        [DataMember(Name = "InputProducts", IsRequired = true, EmitDefaultValue = true)]
        public List<string> InputProducts { get; set; }

        /// <summary>
        /// Gets or Sets IsBackflush
        /// </summary>
        [DataMember(Name = "IsBackflush", IsRequired = true, EmitDefaultValue = true)]
        public bool IsBackflush { get; set; }

        /// <summary>
        /// Gets or Sets IsDropShip
        /// </summary>
        [DataMember(Name = "IsDropShip", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDropShip { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "Notes", IsRequired = true, EmitDefaultValue = true)]
        public List<Authorize200ResponseProductionOrdersInnerOperationsInnerNotesInner> Notes { get; set; }

        /// <summary>
        /// Gets or Sets OperationID
        /// </summary>
        [DataMember(Name = "OperationID", IsRequired = true, EmitDefaultValue = true)]
        public string OperationID { get; set; }

        /// <summary>
        /// Gets or Sets OperationLinks
        /// </summary>
        [DataMember(Name = "OperationLinks", IsRequired = true, EmitDefaultValue = true)]
        public List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerOperationLinksInner> OperationLinks { get; set; }

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        [DataMember(Name = "OperationType", IsRequired = true, EmitDefaultValue = true)]
        public string OperationType { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "Order", IsRequired = true, EmitDefaultValue = true)]
        public decimal Order { get; set; }

        /// <summary>
        /// Gets or Sets OutputProducts
        /// </summary>
        [DataMember(Name = "OutputProducts", IsRequired = true, EmitDefaultValue = true)]
        public List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerOutputProductsInner> OutputProducts { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "Resources", IsRequired = true, EmitDefaultValue = true)]
        public List<ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInnerResourcesInner> Resources { get; set; }

        /// <summary>
        /// Gets or Sets UnitsPerCycle
        /// </summary>
        [DataMember(Name = "UnitsPerCycle", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitsPerCycle { get; set; }

        /// <summary>
        /// Gets or Sets VariationComponents
        /// </summary>
        [DataMember(Name = "VariationComponents", IsRequired = true, EmitDefaultValue = true)]
        public List<string> VariationComponents { get; set; }

        /// <summary>
        /// Gets or Sets WorkCenterCoManProcurementType
        /// </summary>
        [DataMember(Name = "WorkCenterCoManProcurementType", IsRequired = true, EmitDefaultValue = true)]
        public object WorkCenterCoManProcurementType { get; set; }

        /// <summary>
        /// Gets or Sets WorkCenterID
        /// </summary>
        [DataMember(Name = "WorkCenterID", IsRequired = true, EmitDefaultValue = true)]
        public string WorkCenterID { get; set; }

        /// <summary>
        /// Gets or Sets WorkCenterName
        /// </summary>
        [DataMember(Name = "WorkCenterName", IsRequired = true, EmitDefaultValue = true)]
        public string WorkCenterName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class ProductionProductionbomProductidReturnattachmentscontentGet200ResponseProductionBOMsInnerOperationsInner {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append('\n');
            sb.Append("  Components: ").Append(Components).Append('\n');
            sb.Append("  CycleTime: ").Append(CycleTime).Append('\n');
            sb.Append("  FinishedProducts: ").Append(FinishedProducts).Append('\n');
            sb.Append("  InputProducts: ").Append(InputProducts).Append('\n');
            sb.Append("  IsBackflush: ").Append(IsBackflush).Append('\n');
            sb.Append("  IsDropShip: ").Append(IsDropShip).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Notes: ").Append(Notes).Append('\n');
            sb.Append("  OperationID: ").Append(OperationID).Append('\n');
            sb.Append("  OperationLinks: ").Append(OperationLinks).Append('\n');
            sb.Append("  OperationType: ").Append(OperationType).Append('\n');
            sb.Append("  Order: ").Append(Order).Append('\n');
            sb.Append("  OutputProducts: ").Append(OutputProducts).Append('\n');
            sb.Append("  Resources: ").Append(Resources).Append('\n');
            sb.Append("  UnitsPerCycle: ").Append(UnitsPerCycle).Append('\n');
            sb.Append("  VariationComponents: ").Append(VariationComponents).Append('\n');
            sb.Append("  WorkCenterCoManProcurementType: ").Append(WorkCenterCoManProcurementType).Append('\n');
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
