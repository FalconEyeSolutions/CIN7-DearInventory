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
    /// LocIdPgLmtDeprecatedEtc200ResponseLocationListInner
    /// </summary>
    [DataContract(Name = "Loc_Id__Pg__Lmt__Deprecated__Etc_200_response_LocationList_inner")]
    public partial class LocIdPgLmtDeprecatedEtc200ResponseLocationListInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocIdPgLmtDeprecatedEtc200ResponseLocationListInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected LocIdPgLmtDeprecatedEtc200ResponseLocationListInner()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocIdPgLmtDeprecatedEtc200ResponseLocationListInner" /> class.
        /// </summary>
        /// <param name="addressCitySuburb">addressCitySuburb (required).</param>
        /// <param name="addressCountry">addressCountry (required).</param>
        /// <param name="addressLine1">addressLine1 (required).</param>
        /// <param name="addressLine2">addressLine2 (required).</param>
        /// <param name="addressStateProvince">addressStateProvince (required).</param>
        /// <param name="addressZipPostCode">addressZipPostCode (required).</param>
        /// <param name="bins">bins (required).</param>
        /// <param name="fixedAssetsLocation">fixedAssetsLocation (required).</param>
        /// <param name="iD">iD (required).</param>
        /// <param name="isCoMan">isCoMan (required).</param>
        /// <param name="isDefault">isDefault (required).</param>
        /// <param name="isDeprecated">isDeprecated (required).</param>
        /// <param name="isShopfloor">isShopfloor (required).</param>
        /// <param name="isStaging">isStaging (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="parentID">parentID (required).</param>
        /// <param name="parentName">parentName (required).</param>
        /// <param name="pickZones">pickZones (required).</param>
        /// <param name="referenceCount">referenceCount (required).</param>
        public LocIdPgLmtDeprecatedEtc200ResponseLocationListInner(string addressCitySuburb = default, string addressCountry = default, string addressLine1 = default, string addressLine2 = default, string addressStateProvince = default, string addressZipPostCode = default, List<string> bins = default, bool fixedAssetsLocation = default, string iD = default, bool isCoMan = default, bool isDefault = default, bool isDeprecated = default, bool isShopfloor = default, bool isStaging = default, string name = default, string parentID = default, string parentName = default, string pickZones = default, decimal referenceCount = default)
        {
            // to ensure "addressCitySuburb" is required (not null)
            ArgumentNullException.ThrowIfNull(addressCitySuburb);
            AddressCitySuburb = addressCitySuburb;
            // to ensure "addressCountry" is required (not null)
            ArgumentNullException.ThrowIfNull(addressCountry);
            AddressCountry = addressCountry;
            // to ensure "addressLine1" is required (not null)
            ArgumentNullException.ThrowIfNull(addressLine1);
            AddressLine1 = addressLine1;
            // to ensure "addressLine2" is required (not null)
            ArgumentNullException.ThrowIfNull(addressLine2);
            AddressLine2 = addressLine2;
            // to ensure "addressStateProvince" is required (not null)
            ArgumentNullException.ThrowIfNull(addressStateProvince);
            AddressStateProvince = addressStateProvince;
            // to ensure "addressZipPostCode" is required (not null)
            ArgumentNullException.ThrowIfNull(addressZipPostCode);
            AddressZipPostCode = addressZipPostCode;
            // to ensure "bins" is required (not null)
            ArgumentNullException.ThrowIfNull(bins);
            Bins = bins;
            FixedAssetsLocation = fixedAssetsLocation;
            // to ensure "iD" is required (not null)
            ArgumentNullException.ThrowIfNull(iD);
            ID = iD;
            IsCoMan = isCoMan;
            IsDefault = isDefault;
            IsDeprecated = isDeprecated;
            IsShopfloor = isShopfloor;
            IsStaging = isStaging;
            // to ensure "name" is required (not null)
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
            // to ensure "parentID" is required (not null)
            ArgumentNullException.ThrowIfNull(parentID);
            ParentID = parentID;
            // to ensure "parentName" is required (not null)
            ArgumentNullException.ThrowIfNull(parentName);
            ParentName = parentName;
            // to ensure "pickZones" is required (not null)
            ArgumentNullException.ThrowIfNull(pickZones);
            PickZones = pickZones;
            ReferenceCount = referenceCount;
        }

        /// <summary>
        /// Gets or Sets AddressCitySuburb
        /// </summary>
        [DataMember(Name = "AddressCitySuburb", IsRequired = true, EmitDefaultValue = true)]
        public string AddressCitySuburb { get; set; }

        /// <summary>
        /// Gets or Sets AddressCountry
        /// </summary>
        [DataMember(Name = "AddressCountry", IsRequired = true, EmitDefaultValue = true)]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name = "AddressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name = "AddressLine2", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressStateProvince
        /// </summary>
        [DataMember(Name = "AddressStateProvince", IsRequired = true, EmitDefaultValue = true)]
        public string AddressStateProvince { get; set; }

        /// <summary>
        /// Gets or Sets AddressZipPostCode
        /// </summary>
        [DataMember(Name = "AddressZipPostCode", IsRequired = true, EmitDefaultValue = true)]
        public string AddressZipPostCode { get; set; }

        /// <summary>
        /// Gets or Sets Bins
        /// </summary>
        [DataMember(Name = "Bins", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Bins { get; set; }

        /// <summary>
        /// Gets or Sets FixedAssetsLocation
        /// </summary>
        [DataMember(Name = "FixedAssetsLocation", IsRequired = true, EmitDefaultValue = true)]
        public bool FixedAssetsLocation { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", IsRequired = true, EmitDefaultValue = true)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets IsCoMan
        /// </summary>
        [DataMember(Name = "IsCoMan", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCoMan { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "IsDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets IsDeprecated
        /// </summary>
        [DataMember(Name = "IsDeprecated", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeprecated { get; set; }

        /// <summary>
        /// Gets or Sets IsShopfloor
        /// </summary>
        [DataMember(Name = "IsShopfloor", IsRequired = true, EmitDefaultValue = true)]
        public bool IsShopfloor { get; set; }

        /// <summary>
        /// Gets or Sets IsStaging
        /// </summary>
        [DataMember(Name = "IsStaging", IsRequired = true, EmitDefaultValue = true)]
        public bool IsStaging { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ParentID
        /// </summary>
        [DataMember(Name = "ParentID", IsRequired = true, EmitDefaultValue = true)]
        public string ParentID { get; set; }

        /// <summary>
        /// Gets or Sets ParentName
        /// </summary>
        [DataMember(Name = "ParentName", IsRequired = true, EmitDefaultValue = true)]
        public string ParentName { get; set; }

        /// <summary>
        /// Gets or Sets PickZones
        /// </summary>
        [DataMember(Name = "PickZones", IsRequired = true, EmitDefaultValue = true)]
        public string PickZones { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceCount
        /// </summary>
        [DataMember(Name = "ReferenceCount", IsRequired = true, EmitDefaultValue = true)]
        public decimal ReferenceCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class LocIdPgLmtDeprecatedEtc200ResponseLocationListInner {\n");
            sb.Append("  AddressCitySuburb: ").Append(AddressCitySuburb).Append('\n');
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append('\n');
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append('\n');
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append('\n');
            sb.Append("  AddressStateProvince: ").Append(AddressStateProvince).Append('\n');
            sb.Append("  AddressZipPostCode: ").Append(AddressZipPostCode).Append('\n');
            sb.Append("  Bins: ").Append(Bins).Append('\n');
            sb.Append("  FixedAssetsLocation: ").Append(FixedAssetsLocation).Append('\n');
            sb.Append("  ID: ").Append(ID).Append('\n');
            sb.Append("  IsCoMan: ").Append(IsCoMan).Append('\n');
            sb.Append("  IsDefault: ").Append(IsDefault).Append('\n');
            sb.Append("  IsDeprecated: ").Append(IsDeprecated).Append('\n');
            sb.Append("  IsShopfloor: ").Append(IsShopfloor).Append('\n');
            sb.Append("  IsStaging: ").Append(IsStaging).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  ParentID: ").Append(ParentID).Append('\n');
            sb.Append("  ParentName: ").Append(ParentName).Append('\n');
            sb.Append("  PickZones: ").Append(PickZones).Append('\n');
            sb.Append("  ReferenceCount: ").Append(ReferenceCount).Append('\n');
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