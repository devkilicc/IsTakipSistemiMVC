using System.Web.Mvc;
using IsTakipSistemiMVC.Models;

namespace IsTakipSistemiMVC.Controllers
{
    public class LoginController : Controller
    {
        IsTakipDBEntities entity = new IsTakipDBEntities();
        public ActionResult Index()
        {
            return View();
        }
    }
}