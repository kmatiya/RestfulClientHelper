using RestSharp;

namespace RestfulClientHelper.ClientRequests.Interfaces.Put
{
    /*
        Interface responsible for managanig put requests with no aunthentication required
    */
    public interface IRestPutRequest
    {
        IRestResponse PutRequest<T>(string baseUrl, string relativeUrl, T postObject);
    }
}
