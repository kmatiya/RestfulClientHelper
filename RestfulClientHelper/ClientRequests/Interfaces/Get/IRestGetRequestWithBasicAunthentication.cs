using System.Collections.Generic;
using RestfulClientHelper.ClientRequests.RestModels;
using RestSharp;

namespace RestfulClientHelper.ClientRequests.Interfaces.Get
{
    /*
        Interface responsible for managanig get requests with basic aunthentication 
    */
    public interface IRestGetRequestWithBasicAunthentication
    {
        IRestResponse GetRequestWithBasicAunthentication(string username, string password, string baseUrl, string relativeUrl);
        IRestResponse GetRequestWithBasicAunthentication<T>(string username, string password, string baseUrl, string relativeUrl, T postObject);
        IRestResponse GetRequestWithBasicAunthentication(string username, string password, string baseUrl, string relativeUrl, List<RestParameter> parameters); 
    }
}
