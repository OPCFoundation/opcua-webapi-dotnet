# Opc.Ua.WebApi.Model.DataSetReaderDataType
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.9/#6.2.9.13.1).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] [default to false]
**PublisherId** | [**Variant**](Variant.md) |  | [optional] 
**WriterGroupId** | **int** |  | [optional] [default to 0]
**DataSetWriterId** | **int** |  | [optional] [default to 0]
**DataSetMetaData** | [**DataSetMetaDataType**](DataSetMetaDataType.md) |  | [optional] 
**DataSetFieldContentMask** | **long** |  | [optional] [default to 0]
**MessageReceiveTimeout** | **double** |  | [optional] [default to 0D]
**KeyFrameCount** | **long** |  | [optional] [default to 0]
**HeaderLayoutUri** | **string** |  | [optional] 
**SecurityMode** | **int** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part5/12.3.10). | [optional] 
**SecurityGroupId** | **string** |  | [optional] 
**SecurityKeyServices** | [**List&lt;EndpointDescription&gt;**](EndpointDescription.md) |  | [optional] 
**DataSetReaderProperties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 
**TransportSettings** | **Object** |  | [optional] 
**MessageSettings** | **Object** |  | [optional] 
**SubscribedDataSet** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

