# Opc.Ua.WebApi.Model.ModifySubscriptionRequest
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.3/#5.14.3.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestHeader** | [**RequestHeader**](RequestHeader.md) |  | [optional] 
**SubscriptionId** | **long** |  | [optional] [default to 0]
**RequestedPublishingInterval** | **double** |  | [optional] [default to 0D]
**RequestedLifetimeCount** | **long** |  | [optional] [default to 0]
**RequestedMaxKeepAliveCount** | **long** |  | [optional] [default to 0]
**MaxNotificationsPerPublish** | **long** |  | [optional] [default to 0]
**Priority** | **int** |  | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

