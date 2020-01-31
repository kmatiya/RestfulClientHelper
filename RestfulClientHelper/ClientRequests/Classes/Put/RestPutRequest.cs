using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Open_Chequelist_Template.APIs.Interfaces.Put;
using RestSharp;

namespace Open_Chequelist_Template.APIs.Classes.Put
{
    public class RestPutRequest : IRestPutRequest
    {
        public IRestResponse PutRequest<T>(string baseUrl, string relativeUrl, T putObject)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(relativeUrl, Method.PUT);
            request.AddObject(putObject);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}