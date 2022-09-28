using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.IO;

namespace WeatherReport
{
    public interface IWebHelper
    {
        public HttpResponseMessage SendGetRequestToAPI(string parameters = null, bool checkStatus = true);
        public string ResponseToString(HttpResponseMessage response);
    }

    public class WebAPIHelper : IWebHelper
    {
        public string baseUrl { get; set; }
        public string endpoint { get; set; }
        private HttpClient httpClient { get; set; }


        public WebAPIHelper(string base_url, string ep)
        {
            baseUrl = base_url;
            endpoint = ep;
        }

        /// <summary>
        /// This function makes an API request, gets the response back and returns it
        /// </summary>

        public HttpResponseMessage SendGetRequestToAPI(string parameters = null, bool checkStatus = true)
        {
            httpClient = new HttpClient();
            var completePath = generate_path(parameters);

            var response = httpClient.GetAsync(completePath).Result;

      //      check_response(response, checkStatus);

            return response;
        }


        //protected HttpResponseMessage SendPostRequestToAPI(HttpContent content, string parameters = null, bool checkStatus = true)
        //{

        //    if (string.IsNullOrEmpty(baseUrl) || string.IsNullOrWhiteSpace(baseUrl) ||
        //        string.IsNullOrEmpty(endpoint) || string.IsNullOrWhiteSpace(endpoint))
        //    {
        //        Assert.Fail("Path is not correct");
        //    }

        //    string completePath = Path.Join(baseUrl, endpoint);

        //    if (parameters != null)
        //        completePath += parameters;

        //    var response = httpClient.PostAsync(completePath, content).Result;
        //    if (!response.IsSuccessStatusCode && checkStatus == true)
        //        Assert.Fail("Response was not OK");

        //    return response;
        //}

        //protected HttpResponseMessage SendPutRequestToAPI(HttpContent content, string parameters = null, bool checkStatus = true)
        //{

        //    if (string.IsNullOrEmpty(baseUrl) || string.IsNullOrWhiteSpace(baseUrl) ||
        //        string.IsNullOrEmpty(endpoint) || string.IsNullOrWhiteSpace(endpoint))
        //    {
        //        Assert.Fail("Path is not correct");
        //    }

        //    string completePath = Path.Join(baseUrl, endpoint);

        //    if (parameters != null)
        //        completePath += parameters;

        //    var response = httpClient.PutAsync(completePath, content).Result;
        //    if (!response.IsSuccessStatusCode && checkStatus == true)
        //        Assert.Fail("Response was not OK");

        //    return response;
        //}

        //protected HttpResponseMessage SendDeleteRequestToAPI(HttpContent content, string parameters = null, bool checkStatus = true)
        //{

        //    if (string.IsNullOrEmpty(baseUrl) || string.IsNullOrWhiteSpace(baseUrl) ||
        //        string.IsNullOrEmpty(endpoint) || string.IsNullOrWhiteSpace(endpoint))
        //    {
        //        Assert.Fail("Path is not correct");
        //    }

        //    string completePath = Path.Join(baseUrl, endpoint);

        //    if (parameters != null)
        //        completePath += parameters;

        //    var response = httpClient.DeleteAsync(completePath).Result;
        //    if (!response.IsSuccessStatusCode && checkStatus == true)
        //        Assert.Fail("Response was not OK");

        //    return response;
        //}

        public string ResponseToString(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }




        // ############
        // Private functions
        // ############

        //private static void check_response(HttpResponseMessage response, bool checkStatus)
        //{
        //    if (!response.IsSuccessStatusCode && checkStatus == true)
        //        Assert.Fail("Response was not OK");
        //}

        private string generate_path(string parameters)
        {
            //if (string.IsNullOrEmpty(baseUrl) || string.IsNullOrWhiteSpace(baseUrl) ||
            //    string.IsNullOrEmpty(endpoint) || string.IsNullOrWhiteSpace(endpoint))
            //{
            //    Assert.Fail("Path is not correct");
            //}

            string completePath = Path.Join(baseUrl, endpoint);

            if (parameters != null)
                completePath += parameters;
            return completePath;
        }

    
    }
}
