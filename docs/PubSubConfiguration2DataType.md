# Opc.Ua.WebApi.Model.PubSubConfiguration2DataType
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.12/#6.2.12.4).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscribedDataSets** | [**List&lt;StandaloneSubscribedDataSetDataType&gt;**](StandaloneSubscribedDataSetDataType.md) |  | [optional] 
**DataSetClasses** | [**List&lt;DataSetMetaDataType&gt;**](DataSetMetaDataType.md) |  | [optional] 
**DefaultSecurityKeyServices** | [**List&lt;EndpointDescription&gt;**](EndpointDescription.md) |  | [optional] 
**SecurityGroups** | [**List&lt;SecurityGroupDataType&gt;**](SecurityGroupDataType.md) |  | [optional] 
**PubSubKeyPushTargets** | [**List&lt;PubSubKeyPushTargetDataType&gt;**](PubSubKeyPushTargetDataType.md) |  | [optional] 
**ConfigurationVersion** | **long** |  | [optional] [default to 0]
**ConfigurationProperties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 
**PublishedDataSets** | [**List&lt;PublishedDataSetDataType&gt;**](PublishedDataSetDataType.md) |  | [optional] 
**Connections** | [**List&lt;PubSubConnectionDataType&gt;**](PubSubConnectionDataType.md) |  | [optional] 
**Enabled** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

