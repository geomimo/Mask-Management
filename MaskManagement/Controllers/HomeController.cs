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

namespace MaskManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPurchaseRepository _repo;
        private readonly IMapper _mapper;


        public HomeController(ILogger<HomeController> logger, IPurchaseRepository repo, IMapper mapper)
        {
            _logger = logger;
            _repo = repo;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var purchases = _repo.FindAll().ToList();
            var model = _mapper.Map<List<PurchaseDetailsVM>>(purchases);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
