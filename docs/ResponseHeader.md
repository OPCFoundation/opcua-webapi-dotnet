# Opc.Ua.WebApi.Model.ResponseHeader
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.33).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime** |  | [optional] [default to "0001-01-01T00:00Z"]
**RequestHandle** | **long** |  | [optional] [default to 0]
**ServiceResult** | [**StatusCode**](StatusCode.md) |  | [optional] 
**ServiceDiagnostics** | [**DiagnosticInfo**](DiagnosticInfo.md) |  | [optional] 
**StringTable** | **List&lt;string&gt;** |  | [optional] 
**AdditionalHeader** | [**ExtensionObject**](ExtensionObject.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

