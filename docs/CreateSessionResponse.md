# Opc.Ua.WebApi.Model.CreateSessionResponse
[Link to specification](https://reference.opcfoundation.org/v105/Core/docs/Part4/5.7.2/#5.7.2.2).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResponseHeader** | [**ResponseHeader**](ResponseHeader.md) |  | [optional] 
**SessionId** | **string** |  | [optional] 
**AuthenticationToken** | **string** |  | [optional] 
**RevisedSessionTimeout** | **double** |  | [optional] [default to 0D]
**ServerNonce** | **byte[]** |  | [optional] 
**ServerCertificate** | **byte[]** |  | [optional] 
**ServerEndpoints** | [**List&lt;EndpointDescription&gt;**](EndpointDescription.md) |  | [optional] 
**ServerSoftwareCertificates** | [**List&lt;SignedSoftwareCertificate&gt;**](SignedSoftwareCertificate.md) |  | [optional] 
**ServerSignature** | [**SignatureData**](SignatureData.md) |  | [optional] 
**MaxRequestMessageSize** | **long** |  | [optional] [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

