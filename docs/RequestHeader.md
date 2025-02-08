# Opc.Ua.WebApi.Model.RequestHeader
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.33).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticationToken** | **string** |  | [optional] 
**Timestamp** | **DateTime** |  | [optional] [default to "0001-01-01T00:00Z"]
**RequestHandle** | **long** |  | [optional] [default to 0]
**ReturnDiagnostics** | **long** |  | [optional] [default to 0]
**AuditEntryId** | **string** |  | [optional] 
**TimeoutHint** | **long** |  | [optional] [default to 0]
**AdditionalHeader** | [**ExtensionObject**](ExtensionObject.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

