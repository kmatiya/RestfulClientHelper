using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Open_Chequelist_Template.APIs.Interfaces.Get;
using Open_Chequelist_Template.APIs.RestModels;
using RestSharp;

namespace Open_Chequelist_Template.APIs.Classes.Get
{
    public class RestGetRequest : IRestGetRequest
    {
        public IRestResponse GetRequest(string baseUrl, string relativeUrl)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(relativeUrl, Method.GET);
            IRestResponse response = client.Execute(request);
            return response;
        }

        public IRestResponse GetRequest<T>(string baseUrl, string relativeUrl, T parameterObject)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(relativeUrl, Method.GET);
            request.AddObject(parameterObject);
            IRestResponse response = client.Execute(request);
            return response;
        }

        public IRestResponse GetRequest(string baseUrl, string relativeUrl, List<RestParameter> parameters)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(relativeUrl, Method.GET);
            foreach (var eachParameter in parameters)
            {
                request.AddParameter(eachParameter.name, eachParameter.value);
            }
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}