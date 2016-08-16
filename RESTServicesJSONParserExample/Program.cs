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
    }
}
