using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using MaskManagement.Contracts;
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
        private readonly IMaskRepository _repo;
        private readonly IMapper _mapper;



        public MasksController(IWebHostEnvironment hostingEnvironment, IMaskRepository repo, IMapper mapper)
        {
            _hostingEnvironment = hostingEnvironment;
            _repo = repo;
            _mapper = mapper;
        }


        // GET: Masks
        public ActionResult Index()
        {
            var masks = _repo.FindAll().ToList();
            var model = _mapper.Map<List<MaskVM>>(masks);
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
                if (mask.Image != null)
                {
                    mask.ImagePath = UploadImage(mask.Image);
                }

                Mask newMask = _mapper.Map<Mask>(mask);

                _repo.Create(newMask);

            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Masks/Edit/5
        public ActionResult Edit(int id)
        {
            var mask = _repo.FindById(id);
            var model = _mapper.Map<MaskVM>(mask);
            return View(model);
        }

        // POST: Masks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MaskVM mask)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (mask.Image != null)
                    {
                        mask.ImagePath = UploadImage(mask.Image);
                    }

                    Mask newMask = _mapper.Map<Mask>(mask);

                    _repo.Update(newMask);

                }

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
            var mask = _repo.FindById(id);
            var model = _mapper.Map<MaskVM>(mask);
            return View(model);
        }

        // POST: Masks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string _)
        {
            try
            {
                _repo.Delete(_repo.FindById(id));

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var mask = _repo.FindById(id);
            var model = _mapper.Map<MaskVM>(mask);
            return View(model);
        }

        private string UploadImage(IFormFile file) 
        {
            string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(uploadFolder, uniqueFileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));
            return Path.Combine("img", uniqueFileName);
        }

    }
}




