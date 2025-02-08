# Opc.Ua.WebApi.Model.HistoryReadRequest
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.11.3/#5.11.3.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestHeader** | [**RequestHeader**](RequestHeader.md) |  | [optional] 
**HistoryReadDetails** | [**ExtensionObject**](ExtensionObject.md) |  | [optional] 
**TimestampsToReturn** | **int** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.40). | [optional] 
**ReleaseContinuationPoints** | **bool** |  | [optional] [default to false]
**NodesToRead** | [**List&lt;HistoryReadValueId&gt;**](HistoryReadValueId.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

