# Opc.Ua.WebApi.Model.WriterGroupDataType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WriterGroupId** | **int** |  | [optional] [default to 0]
**PublishingInterval** | **double** |  | [optional] [default to 0D]
**KeepAliveTime** | **double** |  | [optional] [default to 0D]
**Priority** | **int** |  | [optional] [default to 0]
**LocaleIds** | **List&lt;string&gt;** |  | [optional] 
**HeaderLayoutUri** | **string** |  | [optional] 
**TransportSettings** | [**ExtensionObject**](ExtensionObject.md) |  | [optional] 
**MessageSettings** | [**ExtensionObject**](ExtensionObject.md) |  | [optional] 
**DataSetWriters** | [**List&lt;DataSetWriterDataType&gt;**](DataSetWriterDataType.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] [default to false]
**SecurityMode** | **int** |  | [optional] 
**SecurityGroupId** | **string** |  | [optional] 
**SecurityKeyServices** | [**List&lt;EndpointDescription&gt;**](EndpointDescription.md) |  | [optional] 
**MaxNetworkMessageSize** | **long** |  | [optional] [default to 0]
**GroupProperties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

