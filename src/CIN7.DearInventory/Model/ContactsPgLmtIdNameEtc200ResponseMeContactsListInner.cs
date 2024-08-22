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
    /// ContactsPgLmtIdNameEtc200ResponseMeContactsListInner
    /// </summary>
    [DataContract(Name = "Contacts_Pg__Lmt__Id__Name__Etc_200_response_MeContactsList_inner")]
    public partial class ContactsPgLmtIdNameEtc200ResponseMeContactsListInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsPgLmtIdNameEtc200ResponseMeContactsListInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected ContactsPgLmtIdNameEtc200ResponseMeContactsListInner()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsPgLmtIdNameEtc200ResponseMeContactsListInner" /> class.
        /// </summary>
        /// <param name="comment">comment (required).</param>
        /// <param name="contactID">contactID (required).</param>
        /// <param name="defaultForType">defaultForType (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="fax">fax (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="phone">phone (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="website">website (required).</param>
        public ContactsPgLmtIdNameEtc200ResponseMeContactsListInner(object comment = default, string contactID = default, bool defaultForType = default, string email = default, object fax = default, string name = default, string phone = default, string type = default, object website = default)
        {
            // to ensure "comment" is required (not null)
            ArgumentNullException.ThrowIfNull(comment);
            Comment = comment;
            // to ensure "contactID" is required (not null)
            ArgumentNullException.ThrowIfNull(contactID);
            ContactID = contactID;
            DefaultForType = defaultForType;
            // to ensure "email" is required (not null)
            ArgumentNullException.ThrowIfNull(email);
            Email = email;
            // to ensure "fax" is required (not null)
            ArgumentNullException.ThrowIfNull(fax);
            Fax = fax;
            // to ensure "name" is required (not null)
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
            // to ensure "phone" is required (not null)
            ArgumentNullException.ThrowIfNull(phone);
            Phone = phone;
            // to ensure "type" is required (not null)
            ArgumentNullException.ThrowIfNull(type);
            Type = type;
            // to ensure "website" is required (not null)
            ArgumentNullException.ThrowIfNull(website);
            Website = website;
        }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "Comment", IsRequired = true, EmitDefaultValue = true)]
        public object Comment { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name = "ContactID", IsRequired = true, EmitDefaultValue = true)]
        public string ContactID { get; set; }

        /// <summary>
        /// Gets or Sets DefaultForType
        /// </summary>
        [DataMember(Name = "DefaultForType", IsRequired = true, EmitDefaultValue = true)]
        public bool DefaultForType { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "Email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name = "Fax", IsRequired = true, EmitDefaultValue = true)]
        public object Fax { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "Phone", IsRequired = true, EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "Website", IsRequired = true, EmitDefaultValue = true)]
        public object Website { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class ContactsPgLmtIdNameEtc200ResponseMeContactsListInner {\n");
            sb.Append("  Comment: ").Append(Comment).Append('\n');
            sb.Append("  ContactID: ").Append(ContactID).Append('\n');
            sb.Append("  DefaultForType: ").Append(DefaultForType).Append('\n');
            sb.Append("  Email: ").Append(Email).Append('\n');
            sb.Append("  Fax: ").Append(Fax).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Phone: ").Append(Phone).Append('\n');
            sb.Append("  Type: ").Append(Type).Append('\n');
            sb.Append("  Website: ").Append(Website).Append('\n');
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