using System.Net;
using System.Net.Http;

using NUnit.Framework;
using Moq;

using WeatherReport;

namespace WeatherReport.Tests.WeatherObtainerTests
{
    public class GetTemperatureTests
    {
        WeatherObtainer weather_obtainer;
        Mock<IWebHelper> mock_web_helper;

        [SetUp]
        public void Setup()
        {
            mock_web_helper = new Mock<IWebHelper>(MockBehavior.Strict);
            weather_obtainer = new WeatherObtainer(mock_web_helper.Object);
        }

        [TearDown]
        public void teardown()
        {
            mock_web_helper.Verify();
        }

        [Test]
        public void should_return_correct_temperature_as_read_from_web_api()
        {
            float expected_t_min, expected_t_max;

            expected_t_min = 1;
            expected_t_max = 100;

            var expected_api_parameter = "weather?lat=30.913170&lon=75.849541&units=metric&appid=ba3724895e56a803ff5f1af460841b24";
            var dummy_response = new HttpResponseMessage(HttpStatusCode.OK);
            var dummy_string = "{\n\"a\": \"b\",\n\"main\": {\n\"temp_min\": 1,\n\"temp_max\": 100,\n}\n}\n";
            mock_web_helper.Setup(m => m.SendGetRequestToAPI(expected_api_parameter, true)).Returns(dummy_response);
            mock_web_helper.Setup(m => m.ResponseToString(dummy_response)).Returns(dummy_string);

            weather_obtainer.GetTemperature(out float t_min, out float t_max);

            Assert.That(t_min, Is.EqualTo(expected_t_min));
            Assert.That(t_max, Is.EqualTo(expected_t_max));
        }
    }
}