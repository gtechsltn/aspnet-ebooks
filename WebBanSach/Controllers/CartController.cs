using System.Web.Mvc;

namespace WebBanSach.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }
    }
}