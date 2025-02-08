# Opc.Ua.WebApi.Model.FieldMetaData
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.3/#6.2.3.2.4).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Description** | [**LocalizedText**](LocalizedText.md) |  | [optional] 
**FieldFlags** | **int** |  | [optional] [default to 0]
**BuiltInType** | **int** |  | [optional] [default to 0]
**DataType** | **string** |  | [optional] 
**ValueRank** | **int** |  | [optional] [default to 0]
**ArrayDimensions** | **List&lt;long&gt;** |  | [optional] 
**MaxStringLength** | **long** |  | [optional] [default to 0]
**DataSetFieldId** | **Guid** |  | [optional] 
**Properties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

