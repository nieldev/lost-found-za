using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LostAndFound.Data;
using LostAndFound.Data.Models;
using LostAndFound.Data.Models.Lookups;

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
            List<Breed> breeds = await context.Breeds.ToListAsync();
            ViewData["Breed"] = new SelectList(breeds, "Id", "DisplayName");
            ViewData["Species"] = new SelectList(species,"Id","DisplayName");
            return View();
        }

        public ActionResult SaveDropzoneJsUploadedFiles()
        {
            bool isSavedSuccessfully = false;

            foreach (string fileName in Request.Files)
            {
                HttpPostedFileBase file = Request.Files[fileName];
               
                int fileSizeInBytes = file.ContentLength;
                MemoryStream target = new MemoryStream();
                file.InputStream.CopyToAsync(target);

                byte[] data = target.ToArray();
                //You can Save the file content here

                isSavedSuccessfully = true;
            }

            return Json(new { Message = string.Empty });

        }


        public ActionResult Found()
        {
            return View();
        }

    }
}