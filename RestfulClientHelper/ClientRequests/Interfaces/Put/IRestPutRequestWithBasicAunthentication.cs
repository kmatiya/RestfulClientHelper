using RestSharp;

namespace RestfulClientHelper.ClientRequests.Interfaces.Put
{
    /*
        Interface responsible for managanig put requests with basic aunthentication 
    */
    public interface IRestPutRequestWithBasicAunthentication
    {
        IRestResponse PutRequestWithBasicAunthentication<T>(string username, string password, string baseUrl, string relativeUrl, T putObject);
    }
}
