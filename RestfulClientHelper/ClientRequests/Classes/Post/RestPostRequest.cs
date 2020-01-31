using System;
using Open_Chequelist_Template.APIs.Interfaces.Post;
using Open_Chequelist_Template.Models.Singletones;
using RestSharp;

namespace Open_Chequelist_Template.APIs.Classes.Post
{
    public class RestPostRequest : IRestPostRequest
    {
        public IRestResponse PostRequest<T>(string baseUrl, string relativeUrl, T postObject)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(relativeUrl, Method.POST);
            request.AddObject(postObject);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}