using System.Collections.Generic;
using RestfulClientHelper.ClientRequests.RestModels;
using RestSharp;

namespace RestfulClientHelper.ClientRequests.Interfaces.Get
{
    /*
        Interface responsible for managanig get requests with no aunthentication required
    */
    public interface IRestGetRequest
    {
        IRestResponse GetRequest(string baseUrl, string relativeUrl);
        IRestResponse GetRequest<T>(string baseUrl, string relativeUrl, T postObject);
        IRestResponse GetRequest(string baseUrl, string relativeUrl, List<RestParameter> parameters); 
    }
}
