using LinkUp_Web.Models;

namespace LinkUp_Web.Services.IServices;

public interface IPaymentServices
{
    public string stripePayment(GratisPointPackages gratisPointPackages, GratisPurchase gratisPurchase);
    public Task  hubtelPay();
}