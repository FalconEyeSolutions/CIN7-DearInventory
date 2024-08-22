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
    /// RefAttributesetPost200Response
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="RefAttributesetPost200Response" /> class.
    /// </remarks>
    /// <param name="attribute10Name">attribute10Name.</param>
    /// <param name="attribute10Type">attribute10Type.</param>
    /// <param name="attribute10Values">attribute10Values.</param>
    /// <param name="attribute1Name">attribute1Name.</param>
    /// <param name="attribute1Type">attribute1Type.</param>
    /// <param name="attribute1Values">attribute1Values.</param>
    /// <param name="attribute2Name">attribute2Name.</param>
    /// <param name="attribute2Type">attribute2Type.</param>
    /// <param name="attribute2Values">attribute2Values.</param>
    /// <param name="attribute3Name">attribute3Name.</param>
    /// <param name="attribute3Type">attribute3Type.</param>
    /// <param name="attribute3Values">attribute3Values.</param>
    /// <param name="attribute4Name">attribute4Name.</param>
    /// <param name="attribute4Type">attribute4Type.</param>
    /// <param name="attribute4Values">attribute4Values.</param>
    /// <param name="attribute5Name">attribute5Name.</param>
    /// <param name="attribute5Type">attribute5Type.</param>
    /// <param name="attribute5Values">attribute5Values.</param>
    /// <param name="attribute6Name">attribute6Name.</param>
    /// <param name="attribute6Type">attribute6Type.</param>
    /// <param name="attribute6Values">attribute6Values.</param>
    /// <param name="attribute7Name">attribute7Name.</param>
    /// <param name="attribute7Type">attribute7Type.</param>
    /// <param name="attribute7Values">attribute7Values.</param>
    /// <param name="attribute8Name">attribute8Name.</param>
    /// <param name="attribute8Type">attribute8Type.</param>
    /// <param name="attribute8Values">attribute8Values.</param>
    /// <param name="attribute9Name">attribute9Name.</param>
    /// <param name="attribute9Type">attribute9Type.</param>
    /// <param name="attribute9Values">attribute9Values.</param>
    /// <param name="attributes">attributes.</param>
    /// <param name="iD">iD.</param>
    /// <param name="name">name.</param>
    [DataContract(Name = "refAttributeset_post_200_response")]
    public partial class RefAttributesetPost200Response(string attribute10Name = default, string attribute10Type = default, string attribute10Values = default, string attribute1Name = default, string attribute1Type = default, string attribute1Values = default, string attribute2Name = default, string attribute2Type = default, string attribute2Values = default, string attribute3Name = default, string attribute3Type = default, string attribute3Values = default, string attribute4Name = default, string attribute4Type = default, string attribute4Values = default, string attribute5Name = default, string attribute5Type = default, string attribute5Values = default, string attribute6Name = default, string attribute6Type = default, string attribute6Values = default, string attribute7Name = default, string attribute7Type = default, string attribute7Values = default, string attribute8Name = default, string attribute8Type = default, string attribute8Values = default, string attribute9Name = default, string attribute9Type = default, string attribute9Values = default, List<RefAttributesetPut200ResponseAttributesInner> attributes = default, string iD = default, string name = default) : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Attribute10Name
        /// </summary>
        [DataMember(Name = "Attribute10Name", EmitDefaultValue = false)]
        public string Attribute10Name { get; set; } = attribute10Name;

        /// <summary>
        /// Gets or Sets Attribute10Type
        /// </summary>
        [DataMember(Name = "Attribute10Type", EmitDefaultValue = false)]
        public string Attribute10Type { get; set; } = attribute10Type;

        /// <summary>
        /// Gets or Sets Attribute10Values
        /// </summary>
        [DataMember(Name = "Attribute10Values", EmitDefaultValue = false)]
        public string Attribute10Values { get; set; } = attribute10Values;

        /// <summary>
        /// Gets or Sets Attribute1Name
        /// </summary>
        [DataMember(Name = "Attribute1Name", EmitDefaultValue = false)]
        public string Attribute1Name { get; set; } = attribute1Name;

        /// <summary>
        /// Gets or Sets Attribute1Type
        /// </summary>
        [DataMember(Name = "Attribute1Type", EmitDefaultValue = false)]
        public string Attribute1Type { get; set; } = attribute1Type;

        /// <summary>
        /// Gets or Sets Attribute1Values
        /// </summary>
        [DataMember(Name = "Attribute1Values", EmitDefaultValue = false)]
        public string Attribute1Values { get; set; } = attribute1Values;

        /// <summary>
        /// Gets or Sets Attribute2Name
        /// </summary>
        [DataMember(Name = "Attribute2Name", EmitDefaultValue = false)]
        public string Attribute2Name { get; set; } = attribute2Name;

        /// <summary>
        /// Gets or Sets Attribute2Type
        /// </summary>
        [DataMember(Name = "Attribute2Type", EmitDefaultValue = false)]
        public string Attribute2Type { get; set; } = attribute2Type;

        /// <summary>
        /// Gets or Sets Attribute2Values
        /// </summary>
        [DataMember(Name = "Attribute2Values", EmitDefaultValue = false)]
        public string Attribute2Values { get; set; } = attribute2Values;

        /// <summary>
        /// Gets or Sets Attribute3Name
        /// </summary>
        [DataMember(Name = "Attribute3Name", EmitDefaultValue = false)]
        public string Attribute3Name { get; set; } = attribute3Name;

        /// <summary>
        /// Gets or Sets Attribute3Type
        /// </summary>
        [DataMember(Name = "Attribute3Type", EmitDefaultValue = false)]
        public string Attribute3Type { get; set; } = attribute3Type;

        /// <summary>
        /// Gets or Sets Attribute3Values
        /// </summary>
        [DataMember(Name = "Attribute3Values", EmitDefaultValue = false)]
        public string Attribute3Values { get; set; } = attribute3Values;

        /// <summary>
        /// Gets or Sets Attribute4Name
        /// </summary>
        [DataMember(Name = "Attribute4Name", EmitDefaultValue = false)]
        public string Attribute4Name { get; set; } = attribute4Name;

        /// <summary>
        /// Gets or Sets Attribute4Type
        /// </summary>
        [DataMember(Name = "Attribute4Type", EmitDefaultValue = false)]
        public string Attribute4Type { get; set; } = attribute4Type;

        /// <summary>
        /// Gets or Sets Attribute4Values
        /// </summary>
        [DataMember(Name = "Attribute4Values", EmitDefaultValue = false)]
        public string Attribute4Values { get; set; } = attribute4Values;

        /// <summary>
        /// Gets or Sets Attribute5Name
        /// </summary>
        [DataMember(Name = "Attribute5Name", EmitDefaultValue = false)]
        public string Attribute5Name { get; set; } = attribute5Name;

        /// <summary>
        /// Gets or Sets Attribute5Type
        /// </summary>
        [DataMember(Name = "Attribute5Type", EmitDefaultValue = false)]
        public string Attribute5Type { get; set; } = attribute5Type;

        /// <summary>
        /// Gets or Sets Attribute5Values
        /// </summary>
        [DataMember(Name = "Attribute5Values", EmitDefaultValue = false)]
        public string Attribute5Values { get; set; } = attribute5Values;

        /// <summary>
        /// Gets or Sets Attribute6Name
        /// </summary>
        [DataMember(Name = "Attribute6Name", EmitDefaultValue = false)]
        public string Attribute6Name { get; set; } = attribute6Name;

        /// <summary>
        /// Gets or Sets Attribute6Type
        /// </summary>
        [DataMember(Name = "Attribute6Type", EmitDefaultValue = false)]
        public string Attribute6Type { get; set; } = attribute6Type;

        /// <summary>
        /// Gets or Sets Attribute6Values
        /// </summary>
        [DataMember(Name = "Attribute6Values", EmitDefaultValue = false)]
        public string Attribute6Values { get; set; } = attribute6Values;

        /// <summary>
        /// Gets or Sets Attribute7Name
        /// </summary>
        [DataMember(Name = "Attribute7Name", EmitDefaultValue = false)]
        public string Attribute7Name { get; set; } = attribute7Name;

        /// <summary>
        /// Gets or Sets Attribute7Type
        /// </summary>
        [DataMember(Name = "Attribute7Type", EmitDefaultValue = false)]
        public string Attribute7Type { get; set; } = attribute7Type;

        /// <summary>
        /// Gets or Sets Attribute7Values
        /// </summary>
        [DataMember(Name = "Attribute7Values", EmitDefaultValue = false)]
        public string Attribute7Values { get; set; } = attribute7Values;

        /// <summary>
        /// Gets or Sets Attribute8Name
        /// </summary>
        [DataMember(Name = "Attribute8Name", EmitDefaultValue = false)]
        public string Attribute8Name { get; set; } = attribute8Name;

        /// <summary>
        /// Gets or Sets Attribute8Type
        /// </summary>
        [DataMember(Name = "Attribute8Type", EmitDefaultValue = false)]
        public string Attribute8Type { get; set; } = attribute8Type;

        /// <summary>
        /// Gets or Sets Attribute8Values
        /// </summary>
        [DataMember(Name = "Attribute8Values", EmitDefaultValue = false)]
        public string Attribute8Values { get; set; } = attribute8Values;

        /// <summary>
        /// Gets or Sets Attribute9Name
        /// </summary>
        [DataMember(Name = "Attribute9Name", EmitDefaultValue = false)]
        public string Attribute9Name { get; set; } = attribute9Name;

        /// <summary>
        /// Gets or Sets Attribute9Type
        /// </summary>
        [DataMember(Name = "Attribute9Type", EmitDefaultValue = false)]
        public string Attribute9Type { get; set; } = attribute9Type;

        /// <summary>
        /// Gets or Sets Attribute9Values
        /// </summary>
        [DataMember(Name = "Attribute9Values", EmitDefaultValue = false)]
        public string Attribute9Values { get; set; } = attribute9Values;

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "Attributes", EmitDefaultValue = false)]
        public List<RefAttributesetPut200ResponseAttributesInner> Attributes { get; set; } = attributes;

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; } = iD;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; } = name;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class RefAttributesetPost200Response {\n");
            sb.Append("  Attribute10Name: ").Append(Attribute10Name).Append('\n');
            sb.Append("  Attribute10Type: ").Append(Attribute10Type).Append('\n');
            sb.Append("  Attribute10Values: ").Append(Attribute10Values).Append('\n');
            sb.Append("  Attribute1Name: ").Append(Attribute1Name).Append('\n');
            sb.Append("  Attribute1Type: ").Append(Attribute1Type).Append('\n');
            sb.Append("  Attribute1Values: ").Append(Attribute1Values).Append('\n');
            sb.Append("  Attribute2Name: ").Append(Attribute2Name).Append('\n');
            sb.Append("  Attribute2Type: ").Append(Attribute2Type).Append('\n');
            sb.Append("  Attribute2Values: ").Append(Attribute2Values).Append('\n');
            sb.Append("  Attribute3Name: ").Append(Attribute3Name).Append('\n');
            sb.Append("  Attribute3Type: ").Append(Attribute3Type).Append('\n');
            sb.Append("  Attribute3Values: ").Append(Attribute3Values).Append('\n');
            sb.Append("  Attribute4Name: ").Append(Attribute4Name).Append('\n');
            sb.Append("  Attribute4Type: ").Append(Attribute4Type).Append('\n');
            sb.Append("  Attribute4Values: ").Append(Attribute4Values).Append('\n');
            sb.Append("  Attribute5Name: ").Append(Attribute5Name).Append('\n');
            sb.Append("  Attribute5Type: ").Append(Attribute5Type).Append('\n');
            sb.Append("  Attribute5Values: ").Append(Attribute5Values).Append('\n');
            sb.Append("  Attribute6Name: ").Append(Attribute6Name).Append('\n');
            sb.Append("  Attribute6Type: ").Append(Attribute6Type).Append('\n');
            sb.Append("  Attribute6Values: ").Append(Attribute6Values).Append('\n');
            sb.Append("  Attribute7Name: ").Append(Attribute7Name).Append('\n');
            sb.Append("  Attribute7Type: ").Append(Attribute7Type).Append('\n');
            sb.Append("  Attribute7Values: ").Append(Attribute7Values).Append('\n');
            sb.Append("  Attribute8Name: ").Append(Attribute8Name).Append('\n');
            sb.Append("  Attribute8Type: ").Append(Attribute8Type).Append('\n');
            sb.Append("  Attribute8Values: ").Append(Attribute8Values).Append('\n');
            sb.Append("  Attribute9Name: ").Append(Attribute9Name).Append('\n');
            sb.Append("  Attribute9Type: ").Append(Attribute9Type).Append('\n');
            sb.Append("  Attribute9Values: ").Append(Attribute9Values).Append('\n');
            sb.Append("  Attributes: ").Append(Attributes).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
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
