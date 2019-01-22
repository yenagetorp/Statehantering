using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using StatehanteringAPP.Models;
using StatehanteringAPP.Models.ViewModels;

namespace StatehanteringAPP.Controllers
{


    public class SettingsController : Controller
    {
        IMemoryCache cache;
        public SettingsController(IMemoryCache cache)
        {
            this.cache = cache;
        }

        [HttpGet]
        [Route("")]
       // [Route("Settings/Create")], om vi använder det, då i create.cshtml i formen, måste 
       // vi måste använda asp-coroller="Setting", asp-action="create".
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("")]

        //[Route("Settings/Create")]
        public IActionResult Create(SettingsCreateVM viewModel)
        {
            //cache.Set("SupportEmail", viewModel.Email);
            //HttpContext.Session.SetString("CompanyName", viewModel.CompanyName);
            //TempData["Message"] = "Dina värden har sparats";
            cache.Set(Magic.Email, viewModel.Email);
            HttpContext.Session.SetString(Magic.CompanyName, viewModel.CompanyName);
            TempData[Magic.Message] = "Dina värden har sparats";
            // Skicka kakan till browsern:
            Response.Cookies.Append("VisitDate", DateTime.Now.ToString(),
                new CookieOptions { Expires = DateTime.Now.AddSeconds(10) });
            return RedirectToAction(nameof(Display));
        }


        

        [HttpGet]
        public IActionResult Display()
        {
            var display = new SettingsDisplayVM
            {
                //SaveMessage = (string)TempData["Message"],
                //Email = cache.Get<string>("SupportEmail"),
                ////session state
                //CompanyName = HttpContext.Session.GetString("CompanyName")

                /*Using Peek() method, we can directly access the TempData value
                 * and keep it for next subsequent request.*/
                //SaveMessage = (string)TempData.Peek(Magic.Message),

                SaveMessage = (string)TempData[Magic.Message],
                Email = cache.Get<string>(Magic.Email),
                ////session state
                CompanyName = HttpContext.Session.GetString(Magic.CompanyName),
                // Hämta kakan från browsern:
                Dt = Request.Cookies["VisitDate"],
        };

            return View(display);

        }

    }
}