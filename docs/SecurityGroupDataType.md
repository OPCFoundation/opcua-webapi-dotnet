# Opc.Ua.WebApi.Model.SecurityGroupDataType
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part14/6.2.12/#6.2.12.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**SecurityGroupFolder** | **List&lt;string&gt;** |  | [optional] 
**KeyLifetime** | **double** |  | [optional] [default to 0D]
**SecurityPolicyUri** | **string** |  | [optional] 
**MaxFutureKeyCount** | **long** |  | [optional] [default to 0]
**MaxPastKeyCount** | **long** |  | [optional] [default to 0]
**SecurityGroupId** | **string** |  | [optional] 
**RolePermissions** | [**List&lt;RolePermissionType&gt;**](RolePermissionType.md) |  | [optional] 
**GroupProperties** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

