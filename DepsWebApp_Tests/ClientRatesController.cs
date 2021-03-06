using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DepsWebApp_Tests
{
    class ClientRatesController
    {
        public static void Should_Return_StatusCode_200_When_Currencies_Are_Valid(HttpClient httpClient)
        {
            Tests.SeparatorLine();
            var response = Task.Run(async () =>
            {
                return await httpClient.GetAsync("/rates/UAH/USD?amount=2000");
            }).Result;

            Console.WriteLine("Test Get request /rates/UAH/USD?amount=2000 performed!");
            var responseBody = Task.Run(async () =>
            {
                return await response.Content.ReadAsStringAsync();
            }).Result;
            Console.WriteLine($"Get request /rates/UAH/USD?amount=2000 returned: {responseBody}\n with Status code: {response.StatusCode}");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Get request /rates/UAH/USD?amount=2000 was successfull!");
            }
            else
            {
                Console.WriteLine("Get request /rates/UAH/USD?amount=2000 has failed!");
            }
        }

        public static void Should_Return_StatusCode_400_When_Currencies_Are_Invalid(HttpClient httpClient)
        {
            Tests.SeparatorLine();
            var response = Task.Run(async () =>
            {
                return await httpClient.GetAsync("/rates/Ugfsa/USD?amount=2000");
            }).Result;

            Console.WriteLine("Test Get request /rates/Ugfsa/USD?amount=2000 performed!");
            var responseBody = Task.Run(async () =>
            {
                return await response.Content.ReadAsStringAsync();
            }).Result;
            Console.WriteLine($"Get request /rates/Ugfsa/USD?amount=2000 returned: {responseBody}\n with Status code: {response.StatusCode}");

            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                Console.WriteLine("Get request /rates/Ugfsa/USD?amount=2000 was successfull!");
            }
            else
            {
                Console.WriteLine("Get request /rates/Ugfsa/USD?amount=2000 has failed!");
            }
        }

        public static void Should_Return_Decimal_Number_When_Amount_Is_Not_Mentioned(HttpClient httpClient)
        {
            Tests.SeparatorLine();
            var response = Task.Run(async () =>
            {
                return await httpClient.GetAsync("/rates/UAH/USD");
            }).Result;

            Console.WriteLine("Test Get request /rates/UAH/USD performed!");
            var responseBody = Task.Run(async () =>
            {
                return await response.Content.ReadAsStringAsync();
            }).Result;
            Console.WriteLine($"Get request /rates/UAH/USD returned: {responseBody}\n with Status code: {response.StatusCode}");

            if (!string.IsNullOrEmpty(responseBody))
            {
                Console.WriteLine("Get request /rates/UAH/USD was successfull!");
            }
            else
            {
                Console.WriteLine("Get request /rates/UAH/USD has failed!");
            }
        }
    }
}
