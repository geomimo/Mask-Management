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
        public IActionResult Create(PurchaseCreateVM purchase)
        {
            if (ModelState.IsValid)
            {

                Purchase newPurchase = _mapper.Map<Purchase>(purchase);

                _prepo.Create(newPurchase);

            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var purchase = _prepo.FindById(id);
            var model = _mapper.Map<PurchaseDetailsVM>(purchase);

            return View();
        }
    }
}
