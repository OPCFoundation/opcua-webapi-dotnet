# Opc.Ua.WebApi.Model.PubSubKeyPushTargetDataType
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.12/#6.2.12.3).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationUri** | **string** |  | [optional] 
**PushTargetFolder** | **List&lt;string&gt;** |  | [optional] 
**EndpointUrl** | **string** |  | [optional] 
**SecurityPolicyUri** | **string** |  | [optional] 
**UserTokenType** | [**UserTokenPolicy**](UserTokenPolicy.md) |  | [optional] 
**RequestedKeyCount** | **int** |  | [optional] [default to 0]
**RetryInterval** | **double** |  | [optional] [default to 0D]
**PushTargetProperties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 
**SecurityGroups** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

