using RestSharp;

namespace RestfulClientHelper.ClientRequests.Interfaces.Post
{
    /*
        Interface responsible for managanig post requests with basic aunthentication 
    */
    public interface IRestPostRequestWithBasicAunthentication
    {
        IRestResponse PostRequestWithBasicAunthentication<T>(string username, string password, string baseUrl, string relativeUrl, T postObject);
    }
}
