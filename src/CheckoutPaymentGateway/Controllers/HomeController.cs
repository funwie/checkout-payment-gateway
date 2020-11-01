using Microsoft.AspNetCore.Mvc;

namespace CheckoutPaymentGateway.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet()]
        public ActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
    }
}
