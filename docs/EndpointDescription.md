# Opc.Ua.WebApi.Model.EndpointDescription
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/7.14).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndpointUrl** | **string** |  | [optional] 
**Server** | [**ApplicationDescription**](ApplicationDescription.md) |  | [optional] 
**ServerCertificate** | **byte[]** |  | [optional] 
**SecurityMode** | **int** | [Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part5/12.3.10). | [optional] 
**SecurityPolicyUri** | **string** |  | [optional] 
**UserIdentityTokens** | [**List&lt;UserTokenPolicy&gt;**](UserTokenPolicy.md) |  | [optional] 
**TransportProfileUri** | **string** |  | [optional] 
**SecurityLevel** | **int** |  | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

