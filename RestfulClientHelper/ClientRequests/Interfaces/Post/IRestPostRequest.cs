using RestSharp;

namespace Open_Chequelist_Template.APIs.Interfaces.Post
{
    interface IRestPostRequest
    {
        IRestResponse PostRequest<T>(string baseUrl, string relativeUrl, T postObject);
    }
}
