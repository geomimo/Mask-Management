using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MaskManagement.Data;
using MaskManagement.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MaskManagement.Controllers
{
    public class MasksController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public MasksController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }


        // GET: Masks
        public ActionResult Index()
        {

            var model = new List<MaskVM>();
            return View(model);
        }

        // GET: Masks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Masks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MaskVM mask)
        {

            //TODO: Create a service for upload
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(mask.Image != null)
                {
                    // Generates wwwroot path.
                    string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + mask.Image.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    mask.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                // Save mask
            }

            return RedirectToAction("Details");
        }

        // GET: Masks/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View();
        }

        // POST: Masks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Masks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Masks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            return View();
        }

    }
}




