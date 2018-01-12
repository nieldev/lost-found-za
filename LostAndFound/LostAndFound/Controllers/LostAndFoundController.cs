using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using LostAndFound.Data;
using LostAndFound.Data.Models;

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

        public async Task<ActionResult> Lost()
        {
            var context = new LostAndFoundContext();
            List<Species> species = await context.Species.ToListAsync();
            ViewData["species"] = new SelectList(species,"Id","DisplayName");
            return View();
        }

        public ActionResult Found()
        {
            return View();
        }

    }
}