using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Open_Chequelist_Template.APIs.Interfaces.Put
{
    interface IRestPutRequest
    {
        IRestResponse PutRequest<T>(string baseUrl, string relativeUrl, T postObject);
    }
}
