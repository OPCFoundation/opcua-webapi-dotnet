# Opc.Ua.WebApi.Model.CreateSubscriptionRequest
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.2/#5.14.2.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestHeader** | [**RequestHeader**](RequestHeader.md) |  | [optional] 
**RequestedPublishingInterval** | **double** |  | [optional] [default to 0D]
**RequestedLifetimeCount** | **long** |  | [optional] [default to 0]
**RequestedMaxKeepAliveCount** | **long** |  | [optional] [default to 0]
**MaxNotificationsPerPublish** | **long** |  | [optional] [default to 0]
**PublishingEnabled** | **bool** |  | [optional] [default to false]
**Priority** | **int** |  | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

