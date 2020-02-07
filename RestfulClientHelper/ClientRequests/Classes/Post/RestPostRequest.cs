using RestfulClientHelper.ClientRequests.Interfaces.Post;
using RestSharp;
using RestSharp.Authenticators;

namespace RestfulClientHelper.ClientRequests.Classes.Post
{
    public class RestPostRequest : IRestPostRequest, IRestPostRequestWithBasicAunthentication
    {
        public IRestResponse PostRequest<T>(string baseUrl, string relativeUrl, T postObject)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(relativeUrl, Method.POST);
            request.AddObject(postObject);
            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse PostRequestWithBasicAunthentication<T>(string username, string password, string baseUrl,
            string relativeUrl, T postObject)
        {
            var client = new RestClient(baseUrl) { Authenticator = new HttpBasicAuthenticator(username, password) };
            var request = new RestRequest(relativeUrl, Method.POST);
            request.AddObject(postObject);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}