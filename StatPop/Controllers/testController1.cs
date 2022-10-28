using ApiPopStat.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StatPop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatPop.Controllers
{
    public class testController1 : Controller
    {
        public IActionResult liste_pays()
        {
            //return View(await _context.Country.Include("Links").ToListAsync());

            List<Pays> countries = (List<Pays>)PaysAPI.Instance.GetAllPays().Result;
            //ViewBag.liste_pays = countries;

            return View(countries);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Graphe()
        {
            List<String> income = (List<String>)PaysAPI.Instance.GetIncome().Result;
            List<int> count = (List<int>)PaysAPI.Instance.GetCountIncome().Result;
            string json = JsonConvert.SerializeObject(income);
            ViewBag.income = json;
            string json1 = JsonConvert.SerializeObject(count);
            ViewBag.count = json1;
            return View();
        }
        public IActionResult Graphe_Region()
        {
            List<String> region = (List<String>)PaysAPI.Instance.GetRegion().Result;
            List<int> count_Country = (List<int>)PaysAPI.Instance.GetCountRegion().Result;
            string json = JsonConvert.SerializeObject(region);
            ViewBag.region = json;
            string json1 = JsonConvert.SerializeObject(count_Country);
            ViewBag.count_Country = json1;
            return View();
        }
    }
}
