using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchis.Models;
using Games.Models;

namespace Tamagotchis.Controllers
{
    public class TamagotchisController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/new")]
        public ActionResult Create()
        {
            Tamagotchi newTamagotchi = new Tamagotchi();
            newTamagotchi.SetName(Request.Form["new-name"]);
            newTamagotchi.Save();
            return View("Index", newTamagotchi);
        }

        [HttpPost("/eat")]
        public ActionResult Feed()
        {
            // System.Console.WriteLine(allTamagotchis[0]);
            // List
            // Tamagotchi tamagotchi = Tamagotchi.GetAll();
            // Tamagotchi newTamagotchi = new Tamagotchi();
            // newTamagotchi = Tamagotchi.GetAll();
            // newTamogotchi.Feed();
            // System.Console.WriteLine(allTamagotchis[0]);
            // allTamagotchis[0].Feed();


            return View("Index");
        }
    }
}
