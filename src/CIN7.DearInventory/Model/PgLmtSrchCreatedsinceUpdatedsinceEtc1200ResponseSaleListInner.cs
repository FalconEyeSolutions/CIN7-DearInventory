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
    /// PgLmtSrchCreatedsinceUpdatedsinceEtc1200ResponseSaleListInner
    /// </summary>
    [DataContract(Name = "Pg__Lmt__Srch__Createdsince__Updatedsince__Etc1_200_response_SaleList_inner")]
    public partial class PgLmtSrchCreatedsinceUpdatedsinceEtc1200ResponseSaleListInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PgLmtSrchCreatedsinceUpdatedsinceEtc1200ResponseSaleListInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected PgLmtSrchCreatedsinceUpdatedsinceEtc1200ResponseSaleListInner()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PgLmtSrchCreatedsinceUpdatedsinceEtc1200ResponseSaleListInner" /> class.
        /// </summary>
        /// <param name="baseCurrency">baseCurrency (required).</param>
        /// <param name="combinedInvoiceStatus">combinedInvoiceStatus (required).</param>
        /// <param name="combinedPackingStatus">combinedPackingStatus (required).</param>
        /// <param name="combinedPaymentStatus">combinedPaymentStatus (required).</param>
        /// <param name="combinedPickingStatus">combinedPickingStatus (required).</param>
        /// <param name="combinedShippingStatus">combinedShippingStatus (required).</param>
        /// <param name="combinedTrackingNumbers">combinedTrackingNumbers (required).</param>
        /// <param name="creditNoteNumber">creditNoteNumber (required).</param>
        /// <param name="creditNoteStatus">creditNoteStatus (required).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="customerCurrency">customerCurrency (required).</param>
        /// <param name="customerID">customerID (required).</param>
        /// <param name="customerReference">customerReference (required).</param>
        /// <param name="externalID">externalID (required).</param>
        /// <param name="fulFilmentStatus">fulFilmentStatus (required).</param>
        /// <param name="invoiceAmount">invoiceAmount (required).</param>
        /// <param name="invoiceDate">invoiceDate (required).</param>
        /// <param name="invoiceDueDate">invoiceDueDate (required).</param>
        /// <param name="invoiceNumber">invoiceNumber (required).</param>
        /// <param name="orderDate">orderDate (required).</param>
        /// <param name="orderLocationID">orderLocationID (required).</param>
        /// <param name="orderNumber">orderNumber (required).</param>
        /// <param name="orderStatus">orderStatus (required).</param>
        /// <param name="paidAmount">paidAmount (required).</param>
        /// <param name="quoteStatus">quoteStatus (required).</param>
        /// <param name="saleID">saleID (required).</param>
        /// <param name="shipBy">shipBy (required).</param>
        /// <param name="sourceChannel">sourceChannel (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="updated">updated (required).</param>
        public PgLmtSrchCreatedsinceUpdatedsinceEtc1200ResponseSaleListInner(string baseCurrency = default, string combinedInvoiceStatus = default, string combinedPackingStatus = default, string combinedPaymentStatus = default, string combinedPickingStatus = default, string combinedShippingStatus = default, string combinedTrackingNumbers = default, object creditNoteNumber = default, string creditNoteStatus = default, string customer = default, string customerCurrency = default, string customerID = default, string customerReference = default, object externalID = default, string fulFilmentStatus = default, decimal invoiceAmount = default, string invoiceDate = default, string invoiceDueDate = default, string invoiceNumber = default, string orderDate = default, string orderLocationID = default, string orderNumber = default, string orderStatus = default, decimal paidAmount = default, string quoteStatus = default, string saleID = default, string shipBy = default, string sourceChannel = default, string status = default, string type = default, string updated = default)
        {
            // to ensure "baseCurrency" is required (not null)
            ArgumentNullException.ThrowIfNull(baseCurrency);
            BaseCurrency = baseCurrency;
            // to ensure "combinedInvoiceStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(combinedInvoiceStatus);
            CombinedInvoiceStatus = combinedInvoiceStatus;
            // to ensure "combinedPackingStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(combinedPackingStatus);
            CombinedPackingStatus = combinedPackingStatus;
            // to ensure "combinedPaymentStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(combinedPaymentStatus);
            CombinedPaymentStatus = combinedPaymentStatus;
            // to ensure "combinedPickingStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(combinedPickingStatus);
            CombinedPickingStatus = combinedPickingStatus;
            // to ensure "combinedShippingStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(combinedShippingStatus);
            CombinedShippingStatus = combinedShippingStatus;
            // to ensure "combinedTrackingNumbers" is required (not null)
            ArgumentNullException.ThrowIfNull(combinedTrackingNumbers);
            CombinedTrackingNumbers = combinedTrackingNumbers;
            // to ensure "creditNoteNumber" is required (not null)
            ArgumentNullException.ThrowIfNull(creditNoteNumber);
            CreditNoteNumber = creditNoteNumber;
            // to ensure "creditNoteStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(creditNoteStatus);
            CreditNoteStatus = creditNoteStatus;
            // to ensure "customer" is required (not null)
            ArgumentNullException.ThrowIfNull(customer);
            Customer = customer;
            // to ensure "customerCurrency" is required (not null)
            ArgumentNullException.ThrowIfNull(customerCurrency);
            CustomerCurrency = customerCurrency;
            // to ensure "customerID" is required (not null)
            ArgumentNullException.ThrowIfNull(customerID);
            CustomerID = customerID;
            // to ensure "customerReference" is required (not null)
            ArgumentNullException.ThrowIfNull(customerReference);
            CustomerReference = customerReference;
            // to ensure "externalID" is required (not null)
            ArgumentNullException.ThrowIfNull(externalID);
            ExternalID = externalID;
            // to ensure "fulFilmentStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(fulFilmentStatus);
            FulFilmentStatus = fulFilmentStatus;
            InvoiceAmount = invoiceAmount;
            // to ensure "invoiceDate" is required (not null)
            ArgumentNullException.ThrowIfNull(invoiceDate);
            InvoiceDate = invoiceDate;
            // to ensure "invoiceDueDate" is required (not null)
            ArgumentNullException.ThrowIfNull(invoiceDueDate);
            InvoiceDueDate = invoiceDueDate;
            // to ensure "invoiceNumber" is required (not null)
            ArgumentNullException.ThrowIfNull(invoiceNumber);
            InvoiceNumber = invoiceNumber;
            // to ensure "orderDate" is required (not null)
            ArgumentNullException.ThrowIfNull(orderDate);
            OrderDate = orderDate;
            // to ensure "orderLocationID" is required (not null)
            ArgumentNullException.ThrowIfNull(orderLocationID);
            OrderLocationID = orderLocationID;
            // to ensure "orderNumber" is required (not null)
            ArgumentNullException.ThrowIfNull(orderNumber);
            OrderNumber = orderNumber;
            // to ensure "orderStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(orderStatus);
            OrderStatus = orderStatus;
            PaidAmount = paidAmount;
            // to ensure "quoteStatus" is required (not null)
            ArgumentNullException.ThrowIfNull(quoteStatus);
            QuoteStatus = quoteStatus;
            // to ensure "saleID" is required (not null)
            ArgumentNullException.ThrowIfNull(saleID);
            SaleID = saleID;
            // to ensure "shipBy" is required (not null)
            ArgumentNullException.ThrowIfNull(shipBy);
            ShipBy = shipBy;
            // to ensure "sourceChannel" is required (not null)
            ArgumentNullException.ThrowIfNull(sourceChannel);
            SourceChannel = sourceChannel;
            // to ensure "status" is required (not null)
            ArgumentNullException.ThrowIfNull(status);
            Status = status;
            // to ensure "type" is required (not null)
            ArgumentNullException.ThrowIfNull(type);
            Type = type;
            // to ensure "updated" is required (not null)
            ArgumentNullException.ThrowIfNull(updated);
            Updated = updated;
        }

        /// <summary>
        /// Gets or Sets BaseCurrency
        /// </summary>
        [DataMember(Name = "BaseCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CombinedInvoiceStatus
        /// </summary>
        [DataMember(Name = "CombinedInvoiceStatus", IsRequired = true, EmitDefaultValue = true)]
        public string CombinedInvoiceStatus { get; set; }

        /// <summary>
        /// Gets or Sets CombinedPackingStatus
        /// </summary>
        [DataMember(Name = "CombinedPackingStatus", IsRequired = true, EmitDefaultValue = true)]
        public string CombinedPackingStatus { get; set; }

        /// <summary>
        /// Gets or Sets CombinedPaymentStatus
        /// </summary>
        [DataMember(Name = "CombinedPaymentStatus", IsRequired = true, EmitDefaultValue = true)]
        public string CombinedPaymentStatus { get; set; }

        /// <summary>
        /// Gets or Sets CombinedPickingStatus
        /// </summary>
        [DataMember(Name = "CombinedPickingStatus", IsRequired = true, EmitDefaultValue = true)]
        public string CombinedPickingStatus { get; set; }

        /// <summary>
        /// Gets or Sets CombinedShippingStatus
        /// </summary>
        [DataMember(Name = "CombinedShippingStatus", IsRequired = true, EmitDefaultValue = true)]
        public string CombinedShippingStatus { get; set; }

        /// <summary>
        /// Gets or Sets CombinedTrackingNumbers
        /// </summary>
        [DataMember(Name = "CombinedTrackingNumbers", IsRequired = true, EmitDefaultValue = true)]
        public string CombinedTrackingNumbers { get; set; }

        /// <summary>
        /// Gets or Sets CreditNoteNumber
        /// </summary>
        [DataMember(Name = "CreditNoteNumber", IsRequired = true, EmitDefaultValue = true)]
        public object CreditNoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreditNoteStatus
        /// </summary>
        [DataMember(Name = "CreditNoteStatus", IsRequired = true, EmitDefaultValue = true)]
        public string CreditNoteStatus { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "Customer", IsRequired = true, EmitDefaultValue = true)]
        public string Customer { get; set; }

        /// <summary>
        /// Gets or Sets CustomerCurrency
        /// </summary>
        [DataMember(Name = "CustomerCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerID
        /// </summary>
        [DataMember(Name = "CustomerID", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerID { get; set; }

        /// <summary>
        /// Gets or Sets CustomerReference
        /// </summary>
        [DataMember(Name = "CustomerReference", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name = "ExternalID", IsRequired = true, EmitDefaultValue = true)]
        public object ExternalID { get; set; }

        /// <summary>
        /// Gets or Sets FulFilmentStatus
        /// </summary>
        [DataMember(Name = "FulFilmentStatus", IsRequired = true, EmitDefaultValue = true)]
        public string FulFilmentStatus { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceAmount
        /// </summary>
        [DataMember(Name = "InvoiceAmount", IsRequired = true, EmitDefaultValue = true)]
        public decimal InvoiceAmount { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDate
        /// </summary>
        [DataMember(Name = "InvoiceDate", IsRequired = true, EmitDefaultValue = true)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDueDate
        /// </summary>
        [DataMember(Name = "InvoiceDueDate", IsRequired = true, EmitDefaultValue = true)]
        public string InvoiceDueDate { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name = "InvoiceNumber", IsRequired = true, EmitDefaultValue = true)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name = "OrderDate", IsRequired = true, EmitDefaultValue = true)]
        public string OrderDate { get; set; }

        /// <summary>
        /// Gets or Sets OrderLocationID
        /// </summary>
        [DataMember(Name = "OrderLocationID", IsRequired = true, EmitDefaultValue = true)]
        public string OrderLocationID { get; set; }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name = "OrderNumber", IsRequired = true, EmitDefaultValue = true)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name = "OrderStatus", IsRequired = true, EmitDefaultValue = true)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Gets or Sets PaidAmount
        /// </summary>
        [DataMember(Name = "PaidAmount", IsRequired = true, EmitDefaultValue = true)]
        public decimal PaidAmount { get; set; }

        /// <summary>
        /// Gets or Sets QuoteStatus
        /// </summary>
        [DataMember(Name = "QuoteStatus", IsRequired = true, EmitDefaultValue = true)]
        public string QuoteStatus { get; set; }

        /// <summary>
        /// Gets or Sets SaleID
        /// </summary>
        [DataMember(Name = "SaleID", IsRequired = true, EmitDefaultValue = true)]
        public string SaleID { get; set; }

        /// <summary>
        /// Gets or Sets ShipBy
        /// </summary>
        [DataMember(Name = "ShipBy", IsRequired = true, EmitDefaultValue = true)]
        public string ShipBy { get; set; }

        /// <summary>
        /// Gets or Sets SourceChannel
        /// </summary>
        [DataMember(Name = "SourceChannel", IsRequired = true, EmitDefaultValue = true)]
        public string SourceChannel { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "Updated", IsRequired = true, EmitDefaultValue = true)]
        public string Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class PgLmtSrchCreatedsinceUpdatedsinceEtc1200ResponseSaleListInner {\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append('\n');
            sb.Append("  CombinedInvoiceStatus: ").Append(CombinedInvoiceStatus).Append('\n');
            sb.Append("  CombinedPackingStatus: ").Append(CombinedPackingStatus).Append('\n');
            sb.Append("  CombinedPaymentStatus: ").Append(CombinedPaymentStatus).Append('\n');
            sb.Append("  CombinedPickingStatus: ").Append(CombinedPickingStatus).Append('\n');
            sb.Append("  CombinedShippingStatus: ").Append(CombinedShippingStatus).Append('\n');
            sb.Append("  CombinedTrackingNumbers: ").Append(CombinedTrackingNumbers).Append('\n');
            sb.Append("  CreditNoteNumber: ").Append(CreditNoteNumber).Append('\n');
            sb.Append("  CreditNoteStatus: ").Append(CreditNoteStatus).Append('\n');
            sb.Append("  Customer: ").Append(Customer).Append('\n');
            sb.Append("  CustomerCurrency: ").Append(CustomerCurrency).Append('\n');
            sb.Append("  CustomerID: ").Append(CustomerID).Append('\n');
            sb.Append("  CustomerReference: ").Append(CustomerReference).Append('\n');
            sb.Append("  ExternalID: ").Append(ExternalID).Append('\n');
            sb.Append("  FulFilmentStatus: ").Append(FulFilmentStatus).Append('\n');
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append('\n');
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append('\n');
            sb.Append("  InvoiceDueDate: ").Append(InvoiceDueDate).Append('\n');
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append('\n');
            sb.Append("  OrderDate: ").Append(OrderDate).Append('\n');
            sb.Append("  OrderLocationID: ").Append(OrderLocationID).Append('\n');
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append('\n');
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append('\n');
            sb.Append("  PaidAmount: ").Append(PaidAmount).Append('\n');
            sb.Append("  QuoteStatus: ").Append(QuoteStatus).Append('\n');
            sb.Append("  SaleID: ").Append(SaleID).Append('\n');
            sb.Append("  ShipBy: ").Append(ShipBy).Append('\n');
            sb.Append("  SourceChannel: ").Append(SourceChannel).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  Type: ").Append(Type).Append('\n');
            sb.Append("  Updated: ").Append(Updated).Append('\n');
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