using System;

namespace RestfulClientHelper.ClientRequests.RestModels
{
    /*
        Class with allow a client to set name and value parameters that may be set for a request 
    */
    public class RestParameter
    {
        public string name { set; get; }
        public Object value { set; get; }
    }
}