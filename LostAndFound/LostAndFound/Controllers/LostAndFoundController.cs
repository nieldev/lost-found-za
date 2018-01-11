using System.Web.Mvc;

namespace LostAndFound.Controllers
{
    [Authorize]
    public class LostAndFoundController : Controller
    {
        
        // GET
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Lost()
        {
            return View();
        }

        public ActionResult Found()
        {
            return View();
        }

    }
}