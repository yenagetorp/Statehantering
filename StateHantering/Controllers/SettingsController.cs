using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using StateHantering.Models;
using StateHantering.Models.ViewModels;

namespace StateHantering.Controllers
{
    public class SettingsController : Controller
    {
        IMemoryCache memoryCache;
        public SettingsController(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("")]
        [HttpPost]
        public IActionResult Create(SettingsCreateVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            StateHandler sh = new StateHandler(this);
            sh.SetTempData("Message");
            memoryCache.Set("Support e-mail", viewModel.Email);
            HttpContext.Session.SetString("Company Name", viewModel.CompanyName);

            return RedirectToAction(nameof(Display));
        }

        [HttpGet]
        public IActionResult Display()
        {
            StateHandler sh = new StateHandler(this);

            return View(new SettingsDisplayVM
            {
                CompanyName = HttpContext.Session.GetString("Company Name"),
                Email = memoryCache.Get<string>("Support e-mail"),
                Temp = sh.GetTempData()
            });
        }
    }
}