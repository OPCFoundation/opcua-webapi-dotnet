# Opc.Ua.WebApi.Model.PublishResponse
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.14.5/#5.14.5.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseHeader** | [**ResponseHeader**](ResponseHeader.md) |  | [optional] 
**SubscriptionId** | **long** |  | [optional] [default to 0]
**AvailableSequenceNumbers** | **List&lt;long&gt;** |  | [optional] 
**MoreNotifications** | **bool** |  | [optional] [default to false]
**NotificationMessage** | [**NotificationMessage**](NotificationMessage.md) |  | [optional] 
**Results** | [**List&lt;StatusCode&gt;**](StatusCode.md) |  | [optional] 
**DiagnosticInfos** | [**List&lt;DiagnosticInfo&gt;**](DiagnosticInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

