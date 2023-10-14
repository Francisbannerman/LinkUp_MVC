using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace LinkUp_Web.HubtelPayment;

public class HubtelPay
{
    static async Task Main()
    {
        string apiUrl = "https://api.hubtel.com/payment/link";
        string username = "your_username";
        string password = "your_password";

        using (var client = new HttpClient())
        {
            // Set basic authentication credentials
            var base64Credentials = Convert.ToBase64String(
                System.Text.Encoding.ASCII.GetBytes($"{username}:{password}")
            );
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {base64Credentials}");

            // Construct the request body
            var requestBody = new
            {
                mobileNumber = "customer_mobile_number",
                amount = 100.0,
                title = "Payment Title",
                description = "Payment Description",
                clientReference = "unique_reference",
                callbackUrl = "https://your-callback-url.com",
                // Other optional parameters here
            };

            var requestBodyJson = JsonSerializer.Serialize(requestBody);

            // Send the POST request
            var response = await client.PostAsync(apiUrl, new StringContent(requestBodyJson));

            if (response.IsSuccessStatusCode)
            {
                // Handle success (HTTP status code 201)
                string responseContent = await response.Content.ReadAsStringAsync();
                // Parse the response JSON if needed
            }
            else
            {
                // Handle error responses
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}