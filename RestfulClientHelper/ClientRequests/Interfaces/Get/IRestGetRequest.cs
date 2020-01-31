using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open_Chequelist_Template.APIs.RestModels;
using RestSharp;

namespace Open_Chequelist_Template.APIs.Interfaces.Get
{
    interface IRestGetRequest
    {
        IRestResponse GetRequest(string baseUrl, string relativeUrl);
        IRestResponse GetRequest<T>(string baseUrl, string relativeUrl, T postObject);
        IRestResponse GetRequest(string baseUrl, string relativeUrl, List<RestParameter> parameters); 
    }
}
