# Opc.Ua.WebApi.Model.JsonActionRequestMessage
[Link to specification]().

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSetWriterId** | **int** |  | [optional] [default to 0]
**ActionTargetId** | **int** |  | [optional] [default to 0]
**DataSetWriterName** | **string** |  | [optional] 
**WriterGroupName** | **string** |  | [optional] 
**MetaDataVersion** | [**ConfigurationVersionDataType**](ConfigurationVersionDataType.md) |  | [optional] 
**MinorVersion** | **long** |  | [optional] [default to 0]
**Timestamp** | **DateTime** |  | [optional] [default to "0001-01-01T00:00Z"]
**MessageType** | **string** |  | [optional] 
**RequestId** | **int** |  | [optional] [default to 0]
**ActionState** | **int** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.11/#6.2.11.2.1). | [optional] 
**Payload** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

