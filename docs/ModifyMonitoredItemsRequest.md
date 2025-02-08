# Opc.Ua.WebApi.Model.ModifyMonitoredItemsRequest
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.13.3/#5.13.3.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestHeader** | [**RequestHeader**](RequestHeader.md) |  | [optional] 
**SubscriptionId** | **long** |  | [optional] [default to 0]
**TimestampsToReturn** | **int** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.40). | [optional] 
**ItemsToModify** | [**List&lt;MonitoredItemModifyRequest&gt;**](MonitoredItemModifyRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

