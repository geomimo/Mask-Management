using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MaskManagement.Models;
using MaskManagement.Contracts;
using AutoMapper;
using MaskManagement.Data;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Newtonsoft.Json;

namespace MaskManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPurchaseRepository _prepo;
        private readonly IMaskRepository _mrepo;
        private readonly IMapper _mapper;


        public HomeController(ILogger<HomeController> logger, IPurchaseRepository prepo, IMaskRepository mrepo, IMapper mapper)
        {
            _logger = logger;
            _prepo = prepo;
            _mrepo = mrepo;
            _mapper = mapper;
        }

        // GET: Home
        public IActionResult Index()
        {
            var purchases = _prepo.FindAll().ToList();
            var model = _mapper.Map<List<PurchaseDetailsVM>>(purchases);
            return View(model);
        }

        // GET: Home/Create
        public IActionResult Create()
        {
            List<Mask> masks = _mrepo.FindAll().ToList();
            List<MaskVM> model = _mapper.Map<List<MaskVM>>(masks);
            ViewBag.Masks = model;
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PurchaseCreateVM purchase, IFormCollection form)
        {
            if (ModelState.IsValid)
            {             
                Purchase newPurchase = _mapper.Map<Purchase>(purchase);
                newPurchase.Masks = new List<PurchasedMasks>();

                var data = form["selectedMasks"];
                var values = JsonConvert.DeserializeObject<Dictionary<string,string>>(data);

                foreach (var key in values.Keys)
                {
                    if (key.Equals(String.Empty)) continue;
                    Mask mask = _mrepo.FindByFabricId(key);
                    _mrepo.Save();
                    int quantity = Int32.Parse(values[key]);

                    newPurchase.Masks.Add(new PurchasedMasks
                    {
                        Mask = mask,
                        Quantity = quantity,
                        Purchase = newPurchase
                        
                    });
                }

                _prepo.Create(newPurchase);

            }
            
            //return RedirectToAction(nameof(Index));
            return RedirectToAction(nameof(Create));
        }

        public IActionResult Details(int id)
        {
            var purchase = _prepo.FindById(id);
            var model = _mapper.Map<PurchaseDetailsVM>(purchase);

            return View();
        }
    }
}
