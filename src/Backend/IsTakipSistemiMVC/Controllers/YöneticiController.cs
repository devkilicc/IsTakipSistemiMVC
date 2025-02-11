using System.Web.Mvc;
using IsTakipSistemiMVC.Models;

namespace IsTakipSistemiMVC.Controllers
{
    public class YöneticiController : Controller
    {
        IsTakipDBEntities entity = new IsTakipDBEntities();
        // GET: Yönetici
        public ActionResult Index()
        {
            return View();
        }
    }
}