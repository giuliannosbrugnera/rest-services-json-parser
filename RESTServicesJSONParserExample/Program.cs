using System;
using System.Net;
using System.Runtime.Serialization.Json;

namespace RESTServicesJSONParserExample

{
    class Program
    {
        static string BingMapsKey = "Aml6nTS3odM79EzwdEZhUtO_RIka7pVBJdsQJidAnuprqQUQjKd3vsG768Hwf9XI";
        static void Main(string[] args)
        {
            try
            {
                string locationsRequest = CreateRequest("New%20York");
                Response locationsResponse = MakeRequest(locationsRequest);
                ProcessResponse(locationsResponse);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }

        }

        public static string CreateRequest(string queryString)
        {
            string UrlRequest = "http://dev.virtualearth.net/REST/v1/Locations/" +
                                 queryString +
                                 "?output=xml" +
                                 " &key=" + BingMapsKey;
            return (UrlRequest);
        }
    }
}
