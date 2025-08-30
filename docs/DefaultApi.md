# Opc.Ua.WebApi.Api.DefaultApi

All URIs are relative to *http://localhost:4840*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateSession**](DefaultApi.md#activatesession) | **POST** /activatesession |  |
| [**Browse**](DefaultApi.md#browse) | **POST** /browse |  |
| [**BrowseNext**](DefaultApi.md#browsenext) | **POST** /browsenext |  |
| [**Call**](DefaultApi.md#call) | **POST** /call |  |
| [**Cancel**](DefaultApi.md#cancel) | **POST** /cancel |  |
| [**CloseSession**](DefaultApi.md#closesession) | **POST** /closesession |  |
| [**CreateMonitoredItems**](DefaultApi.md#createmonitoreditems) | **POST** /createmonitoreditems |  |
| [**CreateSession**](DefaultApi.md#createsession) | **POST** /createsession |  |
| [**CreateSubscription**](DefaultApi.md#createsubscription) | **POST** /createsubscription |  |
| [**DeleteMonitoredItems**](DefaultApi.md#deletemonitoreditems) | **POST** /deletemonitoreditems |  |
| [**DeleteSubscriptions**](DefaultApi.md#deletesubscriptions) | **POST** /deletesubscriptions |  |
| [**FindServers**](DefaultApi.md#findservers) | **POST** /findservers |  |
| [**GetEndpoints**](DefaultApi.md#getendpoints) | **POST** /getendpoints |  |
| [**HistoryRead**](DefaultApi.md#historyread) | **POST** /historyread |  |
| [**HistoryUpdate**](DefaultApi.md#historyupdate) | **POST** /historyupdate |  |
| [**ModifyMonitoredItems**](DefaultApi.md#modifymonitoreditems) | **POST** /modifymonitoreditems |  |
| [**ModifySubscription**](DefaultApi.md#modifysubscription) | **POST** /modifysubscription |  |
| [**Publish**](DefaultApi.md#publish) | **POST** /publish |  |
| [**Read**](DefaultApi.md#read) | **POST** /read |  |
| [**RegisterNodes**](DefaultApi.md#registernodes) | **POST** /registernodes |  |
| [**Republish**](DefaultApi.md#republish) | **POST** /republish |  |
| [**SetMonitoringMode**](DefaultApi.md#setmonitoringmode) | **POST** /setmonitoringmode |  |
| [**SetPublishingMode**](DefaultApi.md#setpublishingmode) | **POST** /setpublishingmode |  |
| [**SetTriggering**](DefaultApi.md#settriggering) | **POST** /settriggering |  |
| [**TransferSubscriptions**](DefaultApi.md#transfersubscriptions) | **POST** /transfersubscriptions |  |
| [**TranslateBrowsePathsToNodeIds**](DefaultApi.md#translatebrowsepathstonodeids) | **POST** /translate |  |
| [**UnregisterNodes**](DefaultApi.md#unregisternodes) | **POST** /unregisternodes |  |
| [**Write**](DefaultApi.md#write) | **POST** /write |  |

<a id="activatesession"></a>
# **ActivateSession**
> ActivateSessionResponse ActivateSession (ActivateSessionRequest activateSessionRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class ActivateSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var activateSessionRequest = new ActivateSessionRequest(); // ActivateSessionRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.3/#5.7.3.2). (optional) 

            try
            {
                ActivateSessionResponse result = apiInstance.ActivateSession(activateSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ActivateSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ActivateSessionResponse> response = apiInstance.ActivateSessionWithHttpInfo(activateSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ActivateSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activateSessionRequest** | [**ActivateSessionRequest**](ActivateSessionRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.3/#5.7.3.2). | [optional]  |

### Return type

[**ActivateSessionResponse**](ActivateSessionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.3/#5.7.3.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="browse"></a>
# **Browse**
> BrowseResponse Browse (BrowseRequest browseRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class BrowseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var browseRequest = new BrowseRequest(); // BrowseRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.2/#5.9.2.2). (optional) 

            try
            {
                BrowseResponse result = apiInstance.Browse(browseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Browse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrowseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BrowseResponse> response = apiInstance.BrowseWithHttpInfo(browseRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.BrowseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **browseRequest** | [**BrowseRequest**](BrowseRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.2/#5.9.2.2). | [optional]  |

### Return type

[**BrowseResponse**](BrowseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.2/#5.9.2.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="browsenext"></a>
# **BrowseNext**
> BrowseNextResponse BrowseNext (BrowseNextRequest browseNextRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class BrowseNextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var browseNextRequest = new BrowseNextRequest(); // BrowseNextRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.3/#5.9.3.2). (optional) 

            try
            {
                BrowseNextResponse result = apiInstance.BrowseNext(browseNextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.BrowseNext: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrowseNextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BrowseNextResponse> response = apiInstance.BrowseNextWithHttpInfo(browseNextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.BrowseNextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **browseNextRequest** | [**BrowseNextRequest**](BrowseNextRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.3/#5.9.3.2). | [optional]  |

### Return type

[**BrowseNextResponse**](BrowseNextResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.3/#5.9.3.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="call"></a>
# **Call**
> CallResponse Call (CallRequest callRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class CallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var callRequest = new CallRequest(); // CallRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.12.2/#5.12.2.2). (optional) 

            try
            {
                CallResponse result = apiInstance.Call(callRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Call: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CallResponse> response = apiInstance.CallWithHttpInfo(callRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **callRequest** | [**CallRequest**](CallRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.12.2/#5.12.2.2). | [optional]  |

### Return type

[**CallResponse**](CallResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.12.2/#5.12.2.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancel"></a>
# **Cancel**
> CancelResponse Cancel (CancelRequest cancelRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class CancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var cancelRequest = new CancelRequest(); // CancelRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.5/#5.7.5.2). (optional) 

            try
            {
                CancelResponse result = apiInstance.Cancel(cancelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Cancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CancelResponse> response = apiInstance.CancelWithHttpInfo(cancelRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cancelRequest** | [**CancelRequest**](CancelRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.5/#5.7.5.2). | [optional]  |

### Return type

[**CancelResponse**](CancelResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.5/#5.7.5.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="closesession"></a>
# **CloseSession**
> CloseSessionResponse CloseSession (CloseSessionRequest closeSessionRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class CloseSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var closeSessionRequest = new CloseSessionRequest(); // CloseSessionRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.4/#5.7.4.2). (optional) 

            try
            {
                CloseSessionResponse result = apiInstance.CloseSession(closeSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CloseSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloseSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CloseSessionResponse> response = apiInstance.CloseSessionWithHttpInfo(closeSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CloseSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **closeSessionRequest** | [**CloseSessionRequest**](CloseSessionRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.4/#5.7.4.2). | [optional]  |

### Return type

[**CloseSessionResponse**](CloseSessionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.4/#5.7.4.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmonitoreditems"></a>
# **CreateMonitoredItems**
> CreateMonitoredItemsResponse CreateMonitoredItems (CreateMonitoredItemsRequest createMonitoredItemsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class CreateMonitoredItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var createMonitoredItemsRequest = new CreateMonitoredItemsRequest(); // CreateMonitoredItemsRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.2/#5.13.2.2). (optional) 

            try
            {
                CreateMonitoredItemsResponse result = apiInstance.CreateMonitoredItems(createMonitoredItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateMonitoredItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMonitoredItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreateMonitoredItemsResponse> response = apiInstance.CreateMonitoredItemsWithHttpInfo(createMonitoredItemsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateMonitoredItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createMonitoredItemsRequest** | [**CreateMonitoredItemsRequest**](CreateMonitoredItemsRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.2/#5.13.2.2). | [optional]  |

### Return type

[**CreateMonitoredItemsResponse**](CreateMonitoredItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.2/#5.13.2.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsession"></a>
# **CreateSession**
> CreateSessionResponse CreateSession (CreateSessionRequest createSessionRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var createSessionRequest = new CreateSessionRequest(); // CreateSessionRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.2/#5.7.2.2). (optional) 

            try
            {
                CreateSessionResponse result = apiInstance.CreateSession(createSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreateSessionResponse> response = apiInstance.CreateSessionWithHttpInfo(createSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSessionRequest** | [**CreateSessionRequest**](CreateSessionRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.2/#5.7.2.2). | [optional]  |

### Return type

[**CreateSessionResponse**](CreateSessionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.2/#5.7.2.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsubscription"></a>
# **CreateSubscription**
> CreateSubscriptionResponse CreateSubscription (CreateSubscriptionRequest createSubscriptionRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var createSubscriptionRequest = new CreateSubscriptionRequest(); // CreateSubscriptionRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.2/#5.14.2.2). (optional) 

            try
            {
                CreateSubscriptionResponse result = apiInstance.CreateSubscription(createSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreateSubscriptionResponse> response = apiInstance.CreateSubscriptionWithHttpInfo(createSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSubscriptionRequest** | [**CreateSubscriptionRequest**](CreateSubscriptionRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.2/#5.14.2.2). | [optional]  |

### Return type

[**CreateSubscriptionResponse**](CreateSubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.2/#5.14.2.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemonitoreditems"></a>
# **DeleteMonitoredItems**
> DeleteMonitoredItemsResponse DeleteMonitoredItems (DeleteMonitoredItemsRequest deleteMonitoredItemsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class DeleteMonitoredItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var deleteMonitoredItemsRequest = new DeleteMonitoredItemsRequest(); // DeleteMonitoredItemsRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.6/#5.13.6.2). (optional) 

            try
            {
                DeleteMonitoredItemsResponse result = apiInstance.DeleteMonitoredItems(deleteMonitoredItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteMonitoredItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMonitoredItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeleteMonitoredItemsResponse> response = apiInstance.DeleteMonitoredItemsWithHttpInfo(deleteMonitoredItemsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteMonitoredItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteMonitoredItemsRequest** | [**DeleteMonitoredItemsRequest**](DeleteMonitoredItemsRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.6/#5.13.6.2). | [optional]  |

### Return type

[**DeleteMonitoredItemsResponse**](DeleteMonitoredItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.6/#5.13.6.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesubscriptions"></a>
# **DeleteSubscriptions**
> DeleteSubscriptionsResponse DeleteSubscriptions (DeleteSubscriptionsRequest deleteSubscriptionsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class DeleteSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var deleteSubscriptionsRequest = new DeleteSubscriptionsRequest(); // DeleteSubscriptionsRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.8/#5.14.8.2). (optional) 

            try
            {
                DeleteSubscriptionsResponse result = apiInstance.DeleteSubscriptions(deleteSubscriptionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeleteSubscriptionsResponse> response = apiInstance.DeleteSubscriptionsWithHttpInfo(deleteSubscriptionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteSubscriptionsRequest** | [**DeleteSubscriptionsRequest**](DeleteSubscriptionsRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.8/#5.14.8.2). | [optional]  |

### Return type

[**DeleteSubscriptionsResponse**](DeleteSubscriptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.8/#5.14.8.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findservers"></a>
# **FindServers**
> FindServersResponse FindServers (FindServersRequest findServersRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class FindServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var findServersRequest = new FindServersRequest(); // FindServersRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.5.2/#5.5.2.2). (optional) 

            try
            {
                FindServersResponse result = apiInstance.FindServers(findServersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.FindServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FindServersResponse> response = apiInstance.FindServersWithHttpInfo(findServersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.FindServersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **findServersRequest** | [**FindServersRequest**](FindServersRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.5.2/#5.5.2.2). | [optional]  |

### Return type

[**FindServersResponse**](FindServersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.5.2/#5.5.2.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getendpoints"></a>
# **GetEndpoints**
> GetEndpointsResponse GetEndpoints (GetEndpointsRequest getEndpointsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class GetEndpointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var getEndpointsRequest = new GetEndpointsRequest(); // GetEndpointsRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.5.4/#5.5.4.2). (optional) 

            try
            {
                GetEndpointsResponse result = apiInstance.GetEndpoints(getEndpointsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEndpoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEndpointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetEndpointsResponse> response = apiInstance.GetEndpointsWithHttpInfo(getEndpointsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetEndpointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getEndpointsRequest** | [**GetEndpointsRequest**](GetEndpointsRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.5.4/#5.5.4.2). | [optional]  |

### Return type

[**GetEndpointsResponse**](GetEndpointsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.5.4/#5.5.4.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="historyread"></a>
# **HistoryRead**
> HistoryReadResponse HistoryRead (HistoryReadRequest historyReadRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class HistoryReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var historyReadRequest = new HistoryReadRequest(); // HistoryReadRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.3/#5.11.3.2). (optional) 

            try
            {
                HistoryReadResponse result = apiInstance.HistoryRead(historyReadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.HistoryRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HistoryReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HistoryReadResponse> response = apiInstance.HistoryReadWithHttpInfo(historyReadRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.HistoryReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **historyReadRequest** | [**HistoryReadRequest**](HistoryReadRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.3/#5.11.3.2). | [optional]  |

### Return type

[**HistoryReadResponse**](HistoryReadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.3/#5.11.3.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="historyupdate"></a>
# **HistoryUpdate**
> HistoryUpdateResponse HistoryUpdate (HistoryUpdateRequest historyUpdateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class HistoryUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var historyUpdateRequest = new HistoryUpdateRequest(); // HistoryUpdateRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.5/#5.11.5.2). (optional) 

            try
            {
                HistoryUpdateResponse result = apiInstance.HistoryUpdate(historyUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.HistoryUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HistoryUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HistoryUpdateResponse> response = apiInstance.HistoryUpdateWithHttpInfo(historyUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.HistoryUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **historyUpdateRequest** | [**HistoryUpdateRequest**](HistoryUpdateRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.5/#5.11.5.2). | [optional]  |

### Return type

[**HistoryUpdateResponse**](HistoryUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.5/#5.11.5.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modifymonitoreditems"></a>
# **ModifyMonitoredItems**
> ModifyMonitoredItemsResponse ModifyMonitoredItems (ModifyMonitoredItemsRequest modifyMonitoredItemsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class ModifyMonitoredItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var modifyMonitoredItemsRequest = new ModifyMonitoredItemsRequest(); // ModifyMonitoredItemsRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.3/#5.13.3.2). (optional) 

            try
            {
                ModifyMonitoredItemsResponse result = apiInstance.ModifyMonitoredItems(modifyMonitoredItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ModifyMonitoredItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyMonitoredItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ModifyMonitoredItemsResponse> response = apiInstance.ModifyMonitoredItemsWithHttpInfo(modifyMonitoredItemsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ModifyMonitoredItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modifyMonitoredItemsRequest** | [**ModifyMonitoredItemsRequest**](ModifyMonitoredItemsRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.3/#5.13.3.2). | [optional]  |

### Return type

[**ModifyMonitoredItemsResponse**](ModifyMonitoredItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.3/#5.13.3.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modifysubscription"></a>
# **ModifySubscription**
> ModifySubscriptionResponse ModifySubscription (ModifySubscriptionRequest modifySubscriptionRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class ModifySubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var modifySubscriptionRequest = new ModifySubscriptionRequest(); // ModifySubscriptionRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.3/#5.14.3.2). (optional) 

            try
            {
                ModifySubscriptionResponse result = apiInstance.ModifySubscription(modifySubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ModifySubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifySubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ModifySubscriptionResponse> response = apiInstance.ModifySubscriptionWithHttpInfo(modifySubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ModifySubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modifySubscriptionRequest** | [**ModifySubscriptionRequest**](ModifySubscriptionRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.3/#5.14.3.2). | [optional]  |

### Return type

[**ModifySubscriptionResponse**](ModifySubscriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.3/#5.14.3.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="publish"></a>
# **Publish**
> PublishResponse Publish (PublishRequest publishRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class PublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var publishRequest = new PublishRequest(); // PublishRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.5/#5.14.5.2). (optional) 

            try
            {
                PublishResponse result = apiInstance.Publish(publishRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Publish: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PublishWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PublishResponse> response = apiInstance.PublishWithHttpInfo(publishRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PublishWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishRequest** | [**PublishRequest**](PublishRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.5/#5.14.5.2). | [optional]  |

### Return type

[**PublishResponse**](PublishResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.5/#5.14.5.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="read"></a>
# **Read**
> ReadResponse Read (ReadRequest readRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class ReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var readRequest = new ReadRequest(); // ReadRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.2/#5.11.2.2). (optional) 

            try
            {
                ReadResponse result = apiInstance.Read(readRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Read: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReadResponse> response = apiInstance.ReadWithHttpInfo(readRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readRequest** | [**ReadRequest**](ReadRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.2/#5.11.2.2). | [optional]  |

### Return type

[**ReadResponse**](ReadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.2/#5.11.2.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="registernodes"></a>
# **RegisterNodes**
> RegisterNodesResponse RegisterNodes (RegisterNodesRequest registerNodesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class RegisterNodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var registerNodesRequest = new RegisterNodesRequest(); // RegisterNodesRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.5/#5.9.5.2). (optional) 

            try
            {
                RegisterNodesResponse result = apiInstance.RegisterNodes(registerNodesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RegisterNodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterNodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RegisterNodesResponse> response = apiInstance.RegisterNodesWithHttpInfo(registerNodesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RegisterNodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerNodesRequest** | [**RegisterNodesRequest**](RegisterNodesRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.5/#5.9.5.2). | [optional]  |

### Return type

[**RegisterNodesResponse**](RegisterNodesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.5/#5.9.5.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="republish"></a>
# **Republish**
> RepublishResponse Republish (RepublishRequest republishRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class RepublishExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var republishRequest = new RepublishRequest(); // RepublishRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.6/#5.14.6.2). (optional) 

            try
            {
                RepublishResponse result = apiInstance.Republish(republishRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Republish: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RepublishWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RepublishResponse> response = apiInstance.RepublishWithHttpInfo(republishRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RepublishWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **republishRequest** | [**RepublishRequest**](RepublishRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.6/#5.14.6.2). | [optional]  |

### Return type

[**RepublishResponse**](RepublishResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.6/#5.14.6.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setmonitoringmode"></a>
# **SetMonitoringMode**
> SetMonitoringModeResponse SetMonitoringMode (SetMonitoringModeRequest setMonitoringModeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class SetMonitoringModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var setMonitoringModeRequest = new SetMonitoringModeRequest(); // SetMonitoringModeRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.4/#5.13.4.2). (optional) 

            try
            {
                SetMonitoringModeResponse result = apiInstance.SetMonitoringMode(setMonitoringModeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SetMonitoringMode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetMonitoringModeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SetMonitoringModeResponse> response = apiInstance.SetMonitoringModeWithHttpInfo(setMonitoringModeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SetMonitoringModeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setMonitoringModeRequest** | [**SetMonitoringModeRequest**](SetMonitoringModeRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.4/#5.13.4.2). | [optional]  |

### Return type

[**SetMonitoringModeResponse**](SetMonitoringModeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.4/#5.13.4.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpublishingmode"></a>
# **SetPublishingMode**
> SetPublishingModeResponse SetPublishingMode (SetPublishingModeRequest setPublishingModeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class SetPublishingModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var setPublishingModeRequest = new SetPublishingModeRequest(); // SetPublishingModeRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.4/#5.14.4.2). (optional) 

            try
            {
                SetPublishingModeResponse result = apiInstance.SetPublishingMode(setPublishingModeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SetPublishingMode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPublishingModeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SetPublishingModeResponse> response = apiInstance.SetPublishingModeWithHttpInfo(setPublishingModeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SetPublishingModeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setPublishingModeRequest** | [**SetPublishingModeRequest**](SetPublishingModeRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.4/#5.14.4.2). | [optional]  |

### Return type

[**SetPublishingModeResponse**](SetPublishingModeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.4/#5.14.4.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="settriggering"></a>
# **SetTriggering**
> SetTriggeringResponse SetTriggering (SetTriggeringRequest setTriggeringRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class SetTriggeringExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var setTriggeringRequest = new SetTriggeringRequest(); // SetTriggeringRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.5/#5.13.5.2). (optional) 

            try
            {
                SetTriggeringResponse result = apiInstance.SetTriggering(setTriggeringRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SetTriggering: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetTriggeringWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SetTriggeringResponse> response = apiInstance.SetTriggeringWithHttpInfo(setTriggeringRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SetTriggeringWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setTriggeringRequest** | [**SetTriggeringRequest**](SetTriggeringRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.5/#5.13.5.2). | [optional]  |

### Return type

[**SetTriggeringResponse**](SetTriggeringResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.5/#5.13.5.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="transfersubscriptions"></a>
# **TransferSubscriptions**
> TransferSubscriptionsResponse TransferSubscriptions (TransferSubscriptionsRequest transferSubscriptionsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class TransferSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var transferSubscriptionsRequest = new TransferSubscriptionsRequest(); // TransferSubscriptionsRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.7/#5.14.7.2). (optional) 

            try
            {
                TransferSubscriptionsResponse result = apiInstance.TransferSubscriptions(transferSubscriptionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TransferSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransferSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TransferSubscriptionsResponse> response = apiInstance.TransferSubscriptionsWithHttpInfo(transferSubscriptionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TransferSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transferSubscriptionsRequest** | [**TransferSubscriptionsRequest**](TransferSubscriptionsRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.7/#5.14.7.2). | [optional]  |

### Return type

[**TransferSubscriptionsResponse**](TransferSubscriptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.7/#5.14.7.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="translatebrowsepathstonodeids"></a>
# **TranslateBrowsePathsToNodeIds**
> TranslateBrowsePathsToNodeIdsResponse TranslateBrowsePathsToNodeIds (TranslateBrowsePathsToNodeIdsRequest translateBrowsePathsToNodeIdsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class TranslateBrowsePathsToNodeIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var translateBrowsePathsToNodeIdsRequest = new TranslateBrowsePathsToNodeIdsRequest(); // TranslateBrowsePathsToNodeIdsRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.4/#5.9.4.2). (optional) 

            try
            {
                TranslateBrowsePathsToNodeIdsResponse result = apiInstance.TranslateBrowsePathsToNodeIds(translateBrowsePathsToNodeIdsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TranslateBrowsePathsToNodeIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranslateBrowsePathsToNodeIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TranslateBrowsePathsToNodeIdsResponse> response = apiInstance.TranslateBrowsePathsToNodeIdsWithHttpInfo(translateBrowsePathsToNodeIdsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TranslateBrowsePathsToNodeIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translateBrowsePathsToNodeIdsRequest** | [**TranslateBrowsePathsToNodeIdsRequest**](TranslateBrowsePathsToNodeIdsRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.4/#5.9.4.2). | [optional]  |

### Return type

[**TranslateBrowsePathsToNodeIdsResponse**](TranslateBrowsePathsToNodeIdsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.4/#5.9.4.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unregisternodes"></a>
# **UnregisterNodes**
> UnregisterNodesResponse UnregisterNodes (UnregisterNodesRequest unregisterNodesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class UnregisterNodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var unregisterNodesRequest = new UnregisterNodesRequest(); // UnregisterNodesRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.6/#5.9.6.2). (optional) 

            try
            {
                UnregisterNodesResponse result = apiInstance.UnregisterNodes(unregisterNodesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UnregisterNodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnregisterNodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnregisterNodesResponse> response = apiInstance.UnregisterNodesWithHttpInfo(unregisterNodesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UnregisterNodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unregisterNodesRequest** | [**UnregisterNodesRequest**](UnregisterNodesRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.6/#5.9.6.2). | [optional]  |

### Return type

[**UnregisterNodesResponse**](UnregisterNodesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.9.6/#5.9.6.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="write"></a>
# **Write**
> WriteResponse Write (WriteRequest writeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opc.Ua.WebApi.Api;
using Opc.Ua.WebApi.Client;
using Opc.Ua.WebApi.Model;

namespace Example
{
    public class WriteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:4840";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var writeRequest = new WriteRequest(); // WriteRequest | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.4/#5.11.4.2). (optional) 

            try
            {
                WriteResponse result = apiInstance.Write(writeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Write: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WriteResponse> response = apiInstance.WriteWithHttpInfo(writeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.WriteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **writeRequest** | [**WriteRequest**](WriteRequest.md) | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.4/#5.11.4.2). | [optional]  |

### Return type

[**WriteResponse**](WriteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.4/#5.11.4.2). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

