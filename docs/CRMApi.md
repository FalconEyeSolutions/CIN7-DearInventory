# Org.OpenAPITools.Api.CRMApi

All URIs are relative to *https://inventory.dearsystems.com/ExternalApi/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CrmLeadPost**](CRMApi.md#crmleadpost) | **POST** /crm/lead | POST |
| [**CrmLeadPut**](CRMApi.md#crmleadput) | **PUT** /crm/lead | PUT |
| [**CrmOpportunityPgLmtIdModifiedsinceGet**](CRMApi.md#crmopportunitypglmtidmodifiedsinceget) | **GET** /crm/opportunity?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;ModifiedSince&#x3D;{ModifiedSince} | GET |
| [**CrmOpportunityPost**](CRMApi.md#crmopportunitypost) | **POST** /crm/opportunity | POST |
| [**CrmOpportunityPut**](CRMApi.md#crmopportunityput) | **PUT** /crm/opportunity | PUT |
| [**CrmTaskPgLmtIdNameGet**](CRMApi.md#crmtaskpglmtidnameget) | **GET** /crm/task?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name} | GET |
| [**CrmTaskPost**](CRMApi.md#crmtaskpost) | **POST** /crm/task | POST |
| [**CrmTaskPut**](CRMApi.md#crmtaskput) | **PUT** /crm/task | PUT |
| [**CrmTaskcategoryPost**](CRMApi.md#crmtaskcategorypost) | **POST** /crm/taskcategory | POST |
| [**CrmTaskcategoryPut**](CRMApi.md#crmtaskcategoryput) | **PUT** /crm/taskcategory | PUT |
| [**CrmWorkflowPost**](CRMApi.md#crmworkflowpost) | **POST** /crm/workflow | POST |
| [**CrmWorkflowPut**](CRMApi.md#crmworkflowput) | **PUT** /crm/workflow | PUT |
| [**LeadPgLmtIdNameEtc**](CRMApi.md#leadpglmtidnameetc) | **GET** /crm/lead?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;ModifiedSince&#x3D;{ModifiedSince} | GET |
| [**TaskPgLmtIdNameEtc**](CRMApi.md#taskpglmtidnameetc) | **GET** /crm/task?Page&#x3D;{Page}&amp;Limit&#x3D;{Limit}&amp;ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;StartDateFrom&#x3D;{StartDateFrom}&amp;StartDateTo&#x3D;{StartDateTo}&amp;EndDateFrom&#x3D;{EndDateFrom}&amp;EndDateTo&#x3D;{EndDateTo}&amp;CompleteDateFrom&#x3D;{CompleteDateFrom}&amp;CompleteDateTo&#x3D;{CompleteDateTo}&amp;AssignedTo&#x3D;{AssignedTo}&amp;Category&#x3D;{Category} | GET |
| [**WorkflowstartIdNameStartdateEnitytypeEtc**](CRMApi.md#workflowstartidnamestartdateenitytypeetc) | **POST** /crm/workflowstart?ID&#x3D;{ID}&amp;Name&#x3D;{Name}&amp;StartDate&#x3D;{StartDate}&amp;EnityType&#x3D;{EnityType}&amp;EntityID&#x3D;{EntityID} | POST |

<a id="crmleadpost"></a>
# **CrmLeadPost**
> CrmLeadPut200Response CrmLeadPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmLeadPutRequest? crmLeadPutRequest = null)

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
    public class CrmLeadPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmLeadPutRequest = new CrmLeadPutRequest?(); // CrmLeadPutRequest? |  (optional) 

            try
            {
                // POST
                CrmLeadPut200Response result = apiInstance.CrmLeadPost(apiAuthAccountid, apiAuthApplicationkey, crmLeadPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmLeadPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmLeadPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<CrmLeadPut200Response> response = apiInstance.CrmLeadPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmLeadPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmLeadPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmLeadPutRequest** | [**CrmLeadPutRequest?**](CrmLeadPutRequest?.md) |  | [optional]  |

### Return type

[**CrmLeadPut200Response**](CrmLeadPut200Response.md)

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

<a id="crmleadput"></a>
# **CrmLeadPut**
> CrmLeadPut200Response CrmLeadPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmLeadPutRequest? crmLeadPutRequest = null)

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
    public class CrmLeadPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmLeadPutRequest = new CrmLeadPutRequest?(); // CrmLeadPutRequest? |  (optional) 

            try
            {
                // PUT
                CrmLeadPut200Response result = apiInstance.CrmLeadPut(apiAuthAccountid, apiAuthApplicationkey, crmLeadPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmLeadPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmLeadPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<CrmLeadPut200Response> response = apiInstance.CrmLeadPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmLeadPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmLeadPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmLeadPutRequest** | [**CrmLeadPutRequest?**](CrmLeadPutRequest?.md) |  | [optional]  |

### Return type

[**CrmLeadPut200Response**](CrmLeadPut200Response.md)

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

<a id="crmopportunitypglmtidmodifiedsinceget"></a>
# **CrmOpportunityPgLmtIdModifiedsinceGet**
> CrmOpportunityPgLmtIdModifiedsinceGet200Response CrmOpportunityPgLmtIdModifiedsinceGet (decimal page, decimal limit, string ID, string modifiedSince, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class CrmOpportunityPgLmtIdModifiedsinceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "\"null\"";  // string |  (default to "null")
            var modifiedSince = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                CrmOpportunityPgLmtIdModifiedsinceGet200Response result = apiInstance.CrmOpportunityPgLmtIdModifiedsinceGet(page, limit, ID, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmOpportunityPgLmtIdModifiedsinceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmOpportunityPgLmtIdModifiedsinceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<CrmOpportunityPgLmtIdModifiedsinceGet200Response> response = apiInstance.CrmOpportunityPgLmtIdModifiedsinceGetWithHttpInfo(page, limit, ID, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmOpportunityPgLmtIdModifiedsinceGetWithHttpInfo: " + e.Message);
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
| **modifiedSince** | **string** |  | [default to &quot;null&quot;] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**CrmOpportunityPgLmtIdModifiedsinceGet200Response**](CrmOpportunityPgLmtIdModifiedsinceGet200Response.md)

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

<a id="crmopportunitypost"></a>
# **CrmOpportunityPost**
> CrmOpportunityPut200Response CrmOpportunityPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmOpportunityPutRequest? crmOpportunityPutRequest = null)

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
    public class CrmOpportunityPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmOpportunityPutRequest = new CrmOpportunityPutRequest?(); // CrmOpportunityPutRequest? |  (optional) 

            try
            {
                // POST
                CrmOpportunityPut200Response result = apiInstance.CrmOpportunityPost(apiAuthAccountid, apiAuthApplicationkey, crmOpportunityPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmOpportunityPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmOpportunityPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<CrmOpportunityPut200Response> response = apiInstance.CrmOpportunityPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmOpportunityPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmOpportunityPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmOpportunityPutRequest** | [**CrmOpportunityPutRequest?**](CrmOpportunityPutRequest?.md) |  | [optional]  |

### Return type

[**CrmOpportunityPut200Response**](CrmOpportunityPut200Response.md)

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

<a id="crmopportunityput"></a>
# **CrmOpportunityPut**
> CrmOpportunityPut200Response CrmOpportunityPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmOpportunityPutRequest? crmOpportunityPutRequest = null)

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
    public class CrmOpportunityPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmOpportunityPutRequest = new CrmOpportunityPutRequest?(); // CrmOpportunityPutRequest? |  (optional) 

            try
            {
                // PUT
                CrmOpportunityPut200Response result = apiInstance.CrmOpportunityPut(apiAuthAccountid, apiAuthApplicationkey, crmOpportunityPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmOpportunityPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmOpportunityPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<CrmOpportunityPut200Response> response = apiInstance.CrmOpportunityPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmOpportunityPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmOpportunityPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmOpportunityPutRequest** | [**CrmOpportunityPutRequest?**](CrmOpportunityPutRequest?.md) |  | [optional]  |

### Return type

[**CrmOpportunityPut200Response**](CrmOpportunityPut200Response.md)

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

<a id="crmtaskpglmtidnameget"></a>
# **CrmTaskPgLmtIdNameGet**
> CrmTaskPgLmtIdNameGet200Response CrmTaskPgLmtIdNameGet (decimal page, decimal limit, string ID, string name, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class CrmTaskPgLmtIdNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "\"null\"";  // string |  (default to "null")
            var name = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                CrmTaskPgLmtIdNameGet200Response result = apiInstance.CrmTaskPgLmtIdNameGet(page, limit, ID, name, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmTaskPgLmtIdNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmTaskPgLmtIdNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<CrmTaskPgLmtIdNameGet200Response> response = apiInstance.CrmTaskPgLmtIdNameGetWithHttpInfo(page, limit, ID, name, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmTaskPgLmtIdNameGetWithHttpInfo: " + e.Message);
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
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**CrmTaskPgLmtIdNameGet200Response**](CrmTaskPgLmtIdNameGet200Response.md)

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

<a id="crmtaskpost"></a>
# **CrmTaskPost**
> CrmTaskPut200Response CrmTaskPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmTaskPostRequest? crmTaskPostRequest = null)

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
    public class CrmTaskPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmTaskPostRequest = new CrmTaskPostRequest?(); // CrmTaskPostRequest? |  (optional) 

            try
            {
                // POST
                CrmTaskPut200Response result = apiInstance.CrmTaskPost(apiAuthAccountid, apiAuthApplicationkey, crmTaskPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmTaskPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmTaskPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<CrmTaskPut200Response> response = apiInstance.CrmTaskPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmTaskPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmTaskPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmTaskPostRequest** | [**CrmTaskPostRequest?**](CrmTaskPostRequest?.md) |  | [optional]  |

### Return type

[**CrmTaskPut200Response**](CrmTaskPut200Response.md)

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

<a id="crmtaskput"></a>
# **CrmTaskPut**
> CrmTaskPut200Response CrmTaskPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmTaskPutRequest? crmTaskPutRequest = null)

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
    public class CrmTaskPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmTaskPutRequest = new CrmTaskPutRequest?(); // CrmTaskPutRequest? |  (optional) 

            try
            {
                // PUT
                CrmTaskPut200Response result = apiInstance.CrmTaskPut(apiAuthAccountid, apiAuthApplicationkey, crmTaskPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmTaskPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmTaskPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<CrmTaskPut200Response> response = apiInstance.CrmTaskPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmTaskPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmTaskPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmTaskPutRequest** | [**CrmTaskPutRequest?**](CrmTaskPutRequest?.md) |  | [optional]  |

### Return type

[**CrmTaskPut200Response**](CrmTaskPut200Response.md)

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

<a id="crmtaskcategorypost"></a>
# **CrmTaskcategoryPost**
> CrmTaskcategoryPost200Response CrmTaskcategoryPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmTaskcategoryPostRequest? crmTaskcategoryPostRequest = null)

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
    public class CrmTaskcategoryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmTaskcategoryPostRequest = new CrmTaskcategoryPostRequest?(); // CrmTaskcategoryPostRequest? |  (optional) 

            try
            {
                // POST
                CrmTaskcategoryPost200Response result = apiInstance.CrmTaskcategoryPost(apiAuthAccountid, apiAuthApplicationkey, crmTaskcategoryPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmTaskcategoryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmTaskcategoryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<CrmTaskcategoryPost200Response> response = apiInstance.CrmTaskcategoryPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmTaskcategoryPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmTaskcategoryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmTaskcategoryPostRequest** | [**CrmTaskcategoryPostRequest?**](CrmTaskcategoryPostRequest?.md) |  | [optional]  |

### Return type

[**CrmTaskcategoryPost200Response**](CrmTaskcategoryPost200Response.md)

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

<a id="crmtaskcategoryput"></a>
# **CrmTaskcategoryPut**
> CrmTaskcategoryPut200Response CrmTaskcategoryPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmTaskcategoryPutRequest? crmTaskcategoryPutRequest = null)

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
    public class CrmTaskcategoryPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmTaskcategoryPutRequest = new CrmTaskcategoryPutRequest?(); // CrmTaskcategoryPutRequest? |  (optional) 

            try
            {
                // PUT
                CrmTaskcategoryPut200Response result = apiInstance.CrmTaskcategoryPut(apiAuthAccountid, apiAuthApplicationkey, crmTaskcategoryPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmTaskcategoryPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmTaskcategoryPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<CrmTaskcategoryPut200Response> response = apiInstance.CrmTaskcategoryPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmTaskcategoryPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmTaskcategoryPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmTaskcategoryPutRequest** | [**CrmTaskcategoryPutRequest?**](CrmTaskcategoryPutRequest?.md) |  | [optional]  |

### Return type

[**CrmTaskcategoryPut200Response**](CrmTaskcategoryPut200Response.md)

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

<a id="crmworkflowpost"></a>
# **CrmWorkflowPost**
> CrmWorkflowPost200Response CrmWorkflowPost (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmWorkflowPostRequest? crmWorkflowPostRequest = null)

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
    public class CrmWorkflowPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmWorkflowPostRequest = new CrmWorkflowPostRequest?(); // CrmWorkflowPostRequest? |  (optional) 

            try
            {
                // POST
                CrmWorkflowPost200Response result = apiInstance.CrmWorkflowPost(apiAuthAccountid, apiAuthApplicationkey, crmWorkflowPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmWorkflowPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmWorkflowPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    ApiResponse<CrmWorkflowPost200Response> response = apiInstance.CrmWorkflowPostWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmWorkflowPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmWorkflowPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmWorkflowPostRequest** | [**CrmWorkflowPostRequest?**](CrmWorkflowPostRequest?.md) |  | [optional]  |

### Return type

[**CrmWorkflowPost200Response**](CrmWorkflowPost200Response.md)

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

<a id="crmworkflowput"></a>
# **CrmWorkflowPut**
> CrmWorkflowPut200Response CrmWorkflowPut (string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, CrmWorkflowPutRequest? crmWorkflowPutRequest = null)

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
    public class CrmWorkflowPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var crmWorkflowPutRequest = new CrmWorkflowPutRequest?(); // CrmWorkflowPutRequest? |  (optional) 

            try
            {
                // PUT
                CrmWorkflowPut200Response result = apiInstance.CrmWorkflowPut(apiAuthAccountid, apiAuthApplicationkey, crmWorkflowPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.CrmWorkflowPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CrmWorkflowPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT
    ApiResponse<CrmWorkflowPut200Response> response = apiInstance.CrmWorkflowPutWithHttpInfo(apiAuthAccountid, apiAuthApplicationkey, crmWorkflowPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.CrmWorkflowPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **crmWorkflowPutRequest** | [**CrmWorkflowPutRequest?**](CrmWorkflowPutRequest?.md) |  | [optional]  |

### Return type

[**CrmWorkflowPut200Response**](CrmWorkflowPut200Response.md)

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

<a id="leadpglmtidnameetc"></a>
# **LeadPgLmtIdNameEtc**
> LeadPgLmtIdNameEtc200Response LeadPgLmtIdNameEtc (decimal page, decimal limit, string ID, string name, string modifiedSince, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class LeadPgLmtIdNameEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "\"null\"";  // string |  (default to "null")
            var name = "\"null\"";  // string |  (default to "null")
            var modifiedSince = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                LeadPgLmtIdNameEtc200Response result = apiInstance.LeadPgLmtIdNameEtc(page, limit, ID, name, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.LeadPgLmtIdNameEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LeadPgLmtIdNameEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<LeadPgLmtIdNameEtc200Response> response = apiInstance.LeadPgLmtIdNameEtcWithHttpInfo(page, limit, ID, name, modifiedSince, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.LeadPgLmtIdNameEtcWithHttpInfo: " + e.Message);
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
| **modifiedSince** | **string** |  | [default to &quot;null&quot;] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**LeadPgLmtIdNameEtc200Response**](LeadPgLmtIdNameEtc200Response.md)

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

<a id="taskpglmtidnameetc"></a>
# **TaskPgLmtIdNameEtc**
> TaskPgLmtIdNameEtc200Response TaskPgLmtIdNameEtc (decimal page, decimal limit, string ID, string name, string startDateFrom, string startDateTo, string endDateFrom, string endDateTo, string completeDateFrom, string completeDateTo, string assignedTo, string category, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null)

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
    public class TaskPgLmtIdNameEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var page = 1MD;  // decimal |  (default to 1M)
            var limit = 100MD;  // decimal |  (default to 100M)
            var ID = "\"null\"";  // string |  (default to "null")
            var name = "\"null\"";  // string |  (default to "null")
            var startDateFrom = "\"null\"";  // string |  (default to "null")
            var startDateTo = "\"null\"";  // string |  (default to "null")
            var endDateFrom = "\"null\"";  // string |  (default to "null")
            var endDateTo = "\"null\"";  // string |  (default to "null")
            var completeDateFrom = "\"null\"";  // string |  (default to "null")
            var completeDateTo = "\"null\"";  // string |  (default to "null")
            var assignedTo = "\"null\"";  // string |  (default to "null")
            var category = "\"null\"";  // string |  (default to "null")
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 

            try
            {
                // GET
                TaskPgLmtIdNameEtc200Response result = apiInstance.TaskPgLmtIdNameEtc(page, limit, ID, name, startDateFrom, startDateTo, endDateFrom, endDateTo, completeDateFrom, completeDateTo, assignedTo, category, apiAuthAccountid, apiAuthApplicationkey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.TaskPgLmtIdNameEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TaskPgLmtIdNameEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET
    ApiResponse<TaskPgLmtIdNameEtc200Response> response = apiInstance.TaskPgLmtIdNameEtcWithHttpInfo(page, limit, ID, name, startDateFrom, startDateTo, endDateFrom, endDateTo, completeDateFrom, completeDateTo, assignedTo, category, apiAuthAccountid, apiAuthApplicationkey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.TaskPgLmtIdNameEtcWithHttpInfo: " + e.Message);
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
| **startDateFrom** | **string** |  | [default to &quot;null&quot;] |
| **startDateTo** | **string** |  | [default to &quot;null&quot;] |
| **endDateFrom** | **string** |  | [default to &quot;null&quot;] |
| **endDateTo** | **string** |  | [default to &quot;null&quot;] |
| **completeDateFrom** | **string** |  | [default to &quot;null&quot;] |
| **completeDateTo** | **string** |  | [default to &quot;null&quot;] |
| **assignedTo** | **string** |  | [default to &quot;null&quot;] |
| **category** | **string** |  | [default to &quot;null&quot;] |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |

### Return type

[**TaskPgLmtIdNameEtc200Response**](TaskPgLmtIdNameEtc200Response.md)

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

<a id="workflowstartidnamestartdateenitytypeetc"></a>
# **WorkflowstartIdNameStartdateEnitytypeEtc**
> void WorkflowstartIdNameStartdateEnitytypeEtc (string ID, string name, string startDate, string enityType, string entityID, string? apiAuthAccountid = null, string? apiAuthApplicationkey = null, Object? body = null)

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
    public class WorkflowstartIdNameStartdateEnitytypeEtcExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://inventory.dearsystems.com/ExternalApi/v2";
            var apiInstance = new CRMApi(config);
            var ID = "\"null\"";  // string |  (default to "null")
            var name = "\"null\"";  // string |  (default to "null")
            var startDate = "startDate_example";  // string | Start date
            var enityType = "enityType_example";  // string | Enity Type
            var entityID = "entityID_example";  // string | Entity ID
            var apiAuthAccountid = 704ef231-cd93-49c9-a201-26b4b5d0d35b;  // string? | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b (optional) 
            var apiAuthApplicationkey = 0342a546-e0c2-0dff-f0be-6a5e17154033;  // string? | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 (optional) 
            var body = null;  // Object? |  (optional) 

            try
            {
                // POST
                apiInstance.WorkflowstartIdNameStartdateEnitytypeEtc(ID, name, startDate, enityType, entityID, apiAuthAccountid, apiAuthApplicationkey, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CRMApi.WorkflowstartIdNameStartdateEnitytypeEtc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkflowstartIdNameStartdateEnitytypeEtcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST
    apiInstance.WorkflowstartIdNameStartdateEnitytypeEtcWithHttpInfo(ID, name, startDate, enityType, entityID, apiAuthAccountid, apiAuthApplicationkey, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CRMApi.WorkflowstartIdNameStartdateEnitytypeEtcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ID** | **string** |  | [default to &quot;null&quot;] |
| **name** | **string** |  | [default to &quot;null&quot;] |
| **startDate** | **string** | Start date |  |
| **enityType** | **string** | Enity Type |  |
| **entityID** | **string** | Entity ID |  |
| **apiAuthAccountid** | **string?** | e.g. 704ef231-cd93-49c9-a201-26b4b5d0d35b | [optional]  |
| **apiAuthApplicationkey** | **string?** | e.g. 0342a546-e0c2-0dff-f0be-6a5e17154033 | [optional]  |
| **body** | **Object?** |  | [optional]  |

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

