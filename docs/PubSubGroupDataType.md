# Opc.Ua.WebApi.Model.PubSubGroupDataType
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.5/#6.2.5.7).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] [default to false]
**SecurityMode** | **int** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part5/12.3.10). | [optional] 
**SecurityGroupId** | **string** |  | [optional] 
**SecurityKeyServices** | [**List&lt;EndpointDescription&gt;**](EndpointDescription.md) |  | [optional] 
**MaxNetworkMessageSize** | **long** |  | [optional] [default to 0]
**GroupProperties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

