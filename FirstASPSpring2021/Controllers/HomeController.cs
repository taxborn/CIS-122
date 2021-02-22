using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstASPSpring2021.Models;

namespace FirstASPSpring2021.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            Song aSong1 = new Song("Run Up", "Ubi & Tech N9ne", "Ubi", 223);
            Song aSong2 = new Song("Heroes", "Dubs Life", "Dubs Life", 198);
            Song aSong3 = new Song("I Got 5 On It", "Luniz & Michael Marshall", "Luniz", 254);
            Song aSong4 = new Song("Gib6erish", "Eazy Mac", "Eazy Mac", 243);

            List<Song> aListOfSongs = new List<Song>();

            aListOfSongs.Add(aSong1);
            aListOfSongs.Add(aSong2);
            aListOfSongs.Add(aSong3);
            aListOfSongs.Add(aSong4);

            ViewBag.ListOfSongs = aListOfSongs;

            return View();
        }
    }
}
