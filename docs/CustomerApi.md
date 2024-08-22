# Org.OpenAPITools.Api.CustomerApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomerCreditsPgLmtCustomeridEtc**](CustomerApi.md#customercreditspglmtcustomeridetc) | **GET** /ref/customer/credits?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;CustomerID&#x3D;{CustomerID}&amp;ShowUsedCredits&#x3D;{ShowUsedCredits} | GET |
| [**CustomerPost**](CustomerApi.md#customerpost) | **POST** /customer | POST |
| [**CustomerPut**](CustomerApi.md#customerput) | **PUT** /customer | PUT |
| [**PgLmtIdNameModifiedsinceEtc**](CustomerApi.md#pglmtidnamemodifiedsinceetc) | **GET** /customer?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;ModifiedSince&#x3D;{ModifiedSince}&amp;IncludeDeprecated&#x3D;{IncludeDeprecated}&amp;IncludeProductPrices&#x3D;{IncludeProductPrices}&amp;ContactFilter&#x3D;{ContactFilter} | GET |
| [**RefCustomerTemplatesPgLmtCustomeridGet**](CustomerApi.md#refcustomertemplatespglmtcustomeridget) | **GET** /ref/customer/templates?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;CustomerId&#x3D;{CustomerId} | GET |
| [**RefCustomerTemplatesPost**](CustomerApi.md#refcustomertemplatespost) | **POST** /ref/customer/templates | POST |
| [**RefCustomerTemplatesTemplateidCustomeridDelete**](CustomerApi.md#refcustomertemplatestemplateidcustomeriddelete) | **DELETE** /ref/customer/templates?TemplateId&#x3D;{TemplateId}&amp;CustomerId&#x3D;{CustomerId} | DELETE |

<a id="customercreditspglmtcustomeridetc"></a>
# **CustomerCreditsPgLmtCustomeridEtc**
> CustomerCreditsPgLmtCustomeridEtc200Response CustomerCreditsPgLmtCustomeridEtc (decimal page, decimal limit, string customerID, string showUsedCredits, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CustomerCreditsPgLmtCustomeridEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CustomerApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var customerID = "\"null\"";  // string |  (default to "null")
            var showUsedCredits = "\"false\"";  // string |  (default to "false")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                CustomerCreditsPgLmtCustomeridEtc200Response result = apiInstance.CustomerCreditsPgLmtCustomeridEtc(page, limit, customerID, showUsedCredits, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomerCreditsPgLmtCustomeridEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerCreditsPgLmtCustomeridEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<CustomerCreditsPgLmtCustomeridEtc200Response> response = apiInstance.CustomerCreditsPgLmtCustomeridEtcWithHttpInfo(page, limit, customerID, showUsedCredits, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerApi.CustomerCreditsPgLmtCustomeridEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** |  | [default to 1M] |
| **limit** | **decimal** |  | [default to 100M] |
| **customerID** | **string** |  | [default to &quot;null&quot;] |
| **showUsedCredits** | **string** |  | [default to &quot;false&quot;] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**CustomerCreditsPgLmtCustomeridEtc200Response**](CustomerCreditsPgLmtCustomeridEtc200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="customerpost"></a>
# **CustomerPost**
> void CustomerPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CustomerPostRequest? customerPostRequest = null)

POST

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CustomerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CustomerApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var customerPostRequest = new CustomerPostRequest?(); // CustomerPostRequest? |  (optional) 

            try
            {
                // POST
                apiInstance.CustomerPost(apiAuthAccountid, apiAuthApplicationkey, customerPostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    apiInstance.CustomerPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, customerPostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerApi.CustomerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **customerPostRequest** | [**CustomerPostRequest?**](CustomerPostRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="customerput"></a>
# **CustomerPut**
> void CustomerPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CustomerPutRequest? customerPutRequest = null)

PUT

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CustomerPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CustomerApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var customerPutRequest = new CustomerPutRequest?(); // CustomerPutRequest? |  (optional) 

            try
            {
                // PUT
                apiInstance.CustomerPut(apiAuthAccountid, apiAuthApplicationkey, customerPutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerApi.CustomerPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    apiInstance.CustomerPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, customerPutRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerApi.CustomerPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **customerPutRequest** | [**CustomerPutRequest?**](CustomerPutRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pglmtidnamemodifiedsinceetc"></a>
# **PgLmtIdNameModifiedsinceEtc**
> PgLmtIdNameModifiedsinceEtc200Response PgLmtIdNameModifiedsinceEtc (decimal page, decimal limit, string ID, string name, string contactFilter, string modifiedSince, bool includeDeprecated, bool includeProductPrices, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PgLmtIdNameModifiedsinceEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CustomerApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "\"null\"";  // string |  (default to "null")
            var name = "\"null\"";  // string |  (default to "null")
            var contactFilter = "\"null\"";  // string |  (default to "null")
            var modifiedSince = "\"null\"";  // string |  (default to "null")
            var includeDeprecated = false;  // bool |  (default to false)
            var includeProductPrices = false;  // bool |  (default to false)
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                PgLmtIdNameModifiedsinceEtc200Response result = apiInstance.PgLmtIdNameModifiedsinceEtc(page, limit, ID, name, contactFilter, modifiedSince, includeDeprecated, includeProductPrices, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerApi.PgLmtIdNameModifiedsinceEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PgLmtIdNameModifiedsinceEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<PgLmtIdNameModifiedsinceEtc200Response> response = apiInstance.PgLmtIdNameModifiedsinceEtcWithHttpInfo(page, limit, ID, name, contactFilter, modifiedSince, includeDeprecated, includeProductPrices, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerApi.PgLmtIdNameModifiedsinceEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** |  | [default to 1M] |
| **limit** | **decimal** |  | [default to 100M] |
| **ID** | **string** |  | [default to &quot;null&quot;] |
| **name** | **string** |  | [default to &quot;null&quot;] |
| **contactFilter** | **string** |  | [default to &quot;null&quot;] |
| **modifiedSince** | **string** |  | [default to &quot;null&quot;] |
| **includeDeprecated** | **bool** |  | [default to false] |
| **includeProductPrices** | **bool** |  | [default to false] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**PgLmtIdNameModifiedsinceEtc200Response**](PgLmtIdNameModifiedsinceEtc200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refcustomertemplatespglmtcustomeridget"></a>
# **RefCustomerTemplatesPgLmtCustomeridGet**
> RefCustomerTemplatesPgLmtCustomeridGet200Response RefCustomerTemplatesPgLmtCustomeridGet (decimal page, decimal limit, string customerId, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

GET

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefCustomerTemplatesPgLmtCustomeridGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CustomerApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var customerId = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                RefCustomerTemplatesPgLmtCustomeridGet200Response result = apiInstance.RefCustomerTemplatesPgLmtCustomeridGet(page, limit, customerId, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerApi.RefCustomerTemplatesPgLmtCustomeridGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefCustomerTemplatesPgLmtCustomeridGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<RefCustomerTemplatesPgLmtCustomeridGet200Response> response = apiInstance.RefCustomerTemplatesPgLmtCustomeridGetWithHttpInfo(page, limit, customerId, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerApi.RefCustomerTemplatesPgLmtCustomeridGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal** |  | [default to 1M] |
| **limit** | **decimal** |  | [default to 100M] |
| **customerId** | **string** |  | [default to &quot;null&quot;] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**RefCustomerTemplatesPgLmtCustomeridGet200Response**](RefCustomerTemplatesPgLmtCustomeridGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refcustomertemplatespost"></a>
# **RefCustomerTemplatesPost**
> RefCustomerTemplatesPost200Response RefCustomerTemplatesPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, RefCustomerTemplatesPostRequest? refCustomerTemplatesPostRequest = null)

POST

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefCustomerTemplatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CustomerApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var refCustomerTemplatesPostRequest = new RefCustomerTemplatesPostRequest?(); // RefCustomerTemplatesPostRequest? |  (optional) 

            try
            {
                // POST
                RefCustomerTemplatesPost200Response result = apiInstance.RefCustomerTemplatesPost(apiAuthAccountid, apiAuthApplicationkey, refCustomerTemplatesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerApi.RefCustomerTemplatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefCustomerTemplatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<RefCustomerTemplatesPost200Response> response = apiInstance.RefCustomerTemplatesPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, refCustomerTemplatesPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerApi.RefCustomerTemplatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **refCustomerTemplatesPostRequest** | [**RefCustomerTemplatesPostRequest?**](RefCustomerTemplatesPostRequest?.md) |  | [optional]  |

### Return type

[**RefCustomerTemplatesPost200Response**](RefCustomerTemplatesPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refcustomertemplatestemplateidcustomeriddelete"></a>
# **RefCustomerTemplatesTemplateidCustomeridDelete**
> RefCustomerTemplatesTemplateidCustomeridDelete200Response RefCustomerTemplatesTemplateidCustomeridDelete (string templateId, string customerId, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

DELETE

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefCustomerTemplatesTemplateidCustomeridDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CustomerApi(config);
            var templateId = "templateId_example";  // string | Provide Template ID.
            var customerId = "customerId_example";  // string | Provide Customer ID.
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // DELETE
                RefCustomerTemplatesTemplateidCustomeridDelete200Response result = apiInstance.RefCustomerTemplatesTemplateidCustomeridDelete(templateId, customerId, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerApi.RefCustomerTemplatesTemplateidCustomeridDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefCustomerTemplatesTemplateidCustomeridDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE
    ApiResponse<RefCustomerTemplatesTemplateidCustomeridDelete200Response> response = apiInstance.RefCustomerTemplatesTemplateidCustomeridDeleteWithHttpInfo(templateId, customerId, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerApi.RefCustomerTemplatesTemplateidCustomeridDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | Provide Template ID. |  |
| **customerId** | **string** | Provide Customer ID. |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**RefCustomerTemplatesTemplateidCustomeridDelete200Response**](RefCustomerTemplatesTemplateidCustomeridDelete200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

