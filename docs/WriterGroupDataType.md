# Opc.Ua.WebApi.Model.WriterGroupDataType
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.6/#6.2.6.7.1).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WriterGroupId** | **int** |  | [optional] [default to 0]
**PublishingInterval** | **double** |  | [optional] [default to 0D]
**KeepAliveTime** | **double** |  | [optional] [default to 0D]
**Priority** | **int** |  | [optional] [default to 0]
**LocaleIds** | **List&lt;string&gt;** |  | [optional] 
**HeaderLayoutUri** | **string** |  | [optional] 
**TransportSettings** | **Object** |  | [optional] 
**MessageSettings** | **Object** |  | [optional] 
**DataSetWriters** | [**List&lt;DataSetWriterDataType&gt;**](DataSetWriterDataType.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] [default to false]
**SecurityMode** | **int** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part5/12.3.10). | [optional] 
**SecurityGroupId** | **string** |  | [optional] 
**SecurityKeyServices** | [**List&lt;EndpointDescription&gt;**](EndpointDescription.md) |  | [optional] 
**MaxNetworkMessageSize** | **long** |  | [optional] [default to 0]
**GroupProperties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

