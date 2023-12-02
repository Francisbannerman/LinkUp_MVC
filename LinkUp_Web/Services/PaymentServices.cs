using LinkUp_Web.Models;
using LinkUp_Web.Repository.IRepository;
using Stripe.Checkout;
using System.Security.Claims;
using System.Text.Json;
using LinkUp_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;


namespace LinkUp_Web.Services;

public class PaymentServices : IPaymentServices
{
    private readonly IUnitOfWork _unitOfWork;

    public PaymentServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public string stripePayment(GratisPointPackages gratisPointPackages, GratisPurchase gratisPurchase)
    {
        var domain = "https://localhost:7010/";
        var successURL = $"{domain}GratisPoint/OrderConfirmation?id={gratisPurchase.gratisPurchaseId}";
        var cancelURL = $"{domain}GratisPoint/index";
        
        var options = new SessionCreateOptions
        {
            SuccessUrl = successURL,
            CancelUrl = cancelURL,
            LineItems = new List<SessionLineItemOptions>(),
            Mode = "payment",
        };
        var sessionLineItem = new SessionLineItemOptions
        {
            PriceData = new SessionLineItemPriceDataOptions
            {
                UnitAmount = (long)(gratisPointPackages.AmountForGratisPoint * 100),
                Currency = "usd",
                ProductData = new SessionLineItemPriceDataProductDataOptions
                {
                    Name = gratisPointPackages.gratisPointQuantity.ToString()
                }
            },
            Quantity = 1
        };
        options.LineItems.Add(sessionLineItem);
          
         var service = new SessionService();
         Session session = service.Create(options);
         _unitOfWork.GratisPurchase.UpdateStripePaymentID(gratisPurchase.gratisPurchaseId, session.Id, session.PaymentIntentId); 
         _unitOfWork.Save();
        return session.Url;
    }

    public async Task hubtelPay()
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