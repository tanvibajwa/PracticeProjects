using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using ApiTestingDemo.Framework;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ApiTestingDemo.reqres
{
    public class GetApiForUsers : APIBase
    {
        [SetUp]
        public void Setup()
        {
            baseUrl = "https://reqres.in/";
            endpoint = "api/";
        }

        [Test]
        public void should_return_the_correct_number_of_pages()
        {
            string parameters = "users?page=2";
            var response = SendGetRequestToAPI(parameters);
            var responseString = ResponseToString(response);
            int pages = JsonConvert.DeserializeObject<dynamic>(responseString).total_pages;
            int page_number = JsonConvert.DeserializeObject<dynamic>(responseString).page;

            Assert.That(pages, Is.EqualTo(2));
            Assert.That(page_number, Is.EqualTo(2));
        }

        [Test]
        public void should_return_data_for_single_user()
        {
            string parameters = "users/2";
            var response = SendGetRequestToAPI(parameters);
            var responseString = ResponseToString(response);
            Dictionary<string, string> user_data = JsonConvert.DeserializeObject<dynamic>(responseString).data.ToObject<Dictionary<string, string>>();
            var user_id = user_data["id"];
            Assert.That(user_id, Is.EqualTo("2"));
        }

        [Test]
        public void should_return_user_not_found()
        {
            string parameters = "users/23";
            var response = SendGetRequestToAPI(parameters, false);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }


        [Test]
        public void should_return_data_for_unknown_user()
        {
            string parameters = "unknown";
            var response = SendGetRequestToAPI(parameters);
            var responseString = ResponseToString(response);
            Dictionary<string, string>[] user = JsonConvert.DeserializeObject<dynamic>(responseString).data.ToObject<Dictionary<string, string>[]>();
            var total_users = user.Length;
            int users_per_page = JsonConvert.DeserializeObject<dynamic>(responseString).per_page;
            Assert.AreEqual(total_users, users_per_page);
        }

        [Test]
        public void should_create_a_user()
        {
            string parameters = "users";
            Dictionary<string, string> new_user_request = new Dictionary<string, string>()
            {
                { "name", "morpheus"},
                {"job", "leader"}
            };

            string request_serialized = JsonConvert.SerializeObject(new_user_request);

            var http_content_to_send = new StringContent(request_serialized, Encoding.UTF8, "application/json");
            var response = SendPostRequestToAPI(http_content_to_send, parameters);
            var responseString = ResponseToString(response);
            string user_id = JsonConvert.DeserializeObject<dynamic>(responseString).id;
            Assert.IsNotNull(user_id);
        }

        [Test]
        public void should_register_successfully()
        {
            string parameters = "register";
            Dictionary<string, string> email_password = new Dictionary<string, string>()
            {
                {"email", "eve.holt@reqres.in" },
                {"password", "pistol" }
            };

            string serialised_request = JsonConvert.SerializeObject(email_password);
            var httpContent_to_send = new StringContent(serialised_request, Encoding.UTF8, "application/json");
            var response = SendPostRequestToAPI(httpContent_to_send, parameters);
            var responseString = ResponseToString(response);
            string user_id = JsonConvert.DeserializeObject<dynamic>(responseString).id;
            Assert.IsNotNull(user_id);
        }

        [Test]
        public void should_update_user_info()
        {
            string parameters = "users/2";
            Dictionary<string, string> user_info = new Dictionary<string, string>()
            {
                {"name", "morpheus" },
                {"job", "bar tender" }
            };

            string serialised_request = JsonConvert.SerializeObject(user_info);
            var httpContent_to_send = new StringContent(serialised_request, Encoding.UTF8, "application/json");
            var response = SendPutRequestToAPI(httpContent_to_send, parameters);
            var responseString = ResponseToString(response);
            string updation_time = JsonConvert.DeserializeObject<dynamic>(responseString).updatedAt;
            Assert.IsNotNull(updation_time);
        }
    }

    //public class User
    //{
    //    public Dictionary<string, string>[] data { get; set; }
    //    public Dictionary<string, string> support { get; set; }
    //    public Dictionary<string, string> ad { get; set; }
    //}

}

