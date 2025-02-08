# Opc.Ua.WebApi.Model.CreateSessionRequest
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.2/#5.7.2.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestHeader** | [**RequestHeader**](RequestHeader.md) |  | [optional] 
**ClientDescription** | [**ApplicationDescription**](ApplicationDescription.md) |  | [optional] 
**ServerUri** | **string** |  | [optional] 
**EndpointUrl** | **string** |  | [optional] 
**SessionName** | **string** |  | [optional] 
**ClientNonce** | **byte[]** |  | [optional] 
**ClientCertificate** | **byte[]** |  | [optional] 
**RequestedSessionTimeout** | **double** |  | [optional] [default to 0D]
**MaxResponseMessageSize** | **long** |  | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

