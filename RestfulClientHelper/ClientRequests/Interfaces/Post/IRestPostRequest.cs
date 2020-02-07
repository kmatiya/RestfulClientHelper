using RestSharp;

namespace RestfulClientHelper.ClientRequests.Interfaces.Post
{
    /*
        Interface responsible for managanig post requests with no aunthentication required
    */
    public interface IRestPostRequest
    {
        IRestResponse PostRequest<T>(string baseUrl, string relativeUrl, T postObject);
    }
}
