using ApiPopStat.Models;
using Microsoft.AspNetCore.Mvc;
using StatPop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatPop.Controllers
{
    public class PaysControllers : Controller
    {
        public IActionResult IndexAsync()
        {
            //return View(await _context.Country.Include("Links").ToListAsync());

            List<Pays> countries = (List<Pays>)PaysAPI.Instance.GetAllPays().Result;
            //ViewBag.liste_pays = countries;
           
            return View(countries);
        }

    }
}
