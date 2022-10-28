using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StatPop.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPopStat.Models;

namespace StatPop.Controllers
{
    public class PopulationController : Controller
    {
        public IActionResult liste_name_pays()
        {
            
            List<Population> PopulationAllName = (List<Population>)PopulationAPI.Instance.GetPopulationAllName().Result;
            
            return View(PopulationAllName);
        }
        public IActionResult Details(int id)
        {
            List<int> anne= new List<int>();

            for (var i = 1961; i < 2020; i++)
            {
                anne.Add(i);
    }

            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationAllYears(id).Result;
            PopulationAllYears.annee = anne;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
        public IActionResult graphe(int id)
        {
           
            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationAllYears(id).Result;
            List<int> List_date = new List<int>();
            string json1 = JsonConvert.SerializeObject(PopulationAllYears.Years);
            ViewBag.liste_years = json1;
            for (var i = 1962; i <= 2020; i++)
            {
                List_date.Add(i);
            }
            string json3 = JsonConvert.SerializeObject(List_date);
            ViewBag.liste_anne = json3;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
        public IActionResult population_5ans(int id)
        {

            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationOn5Async(id).Result;
            List<int> List_date = new List<int>();
            string json1 = JsonConvert.SerializeObject(PopulationAllYears.Years);
            ViewBag.liste_years = json1;
            for (var i = 2015; i <= 2020; i++)
            {
                List_date.Add(i);
            }
            string json3 = JsonConvert.SerializeObject(List_date);
            ViewBag.liste_anne = json3;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
        public IActionResult population_10ans(int id)
        {

            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationOn10Async(id).Result;
            List<int> List_date = new List<int>();
            string json1 = JsonConvert.SerializeObject(PopulationAllYears.Years);
            ViewBag.liste_years = json1;
            for (var i = 2010; i <= 2020; i++)
            {
                List_date.Add(i);
            }
            string json3 = JsonConvert.SerializeObject(List_date);
            ViewBag.liste_anne = json3;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
        public IActionResult population_20ans(int id)
        {

            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationOn20Async(id).Result;
            List<int> List_date = new List<int>();
            string json1 = JsonConvert.SerializeObject(PopulationAllYears.Years);
            ViewBag.liste_years = json1;
            for (var i = 2000; i <= 2020; i++)
            {
                List_date.Add(i);
            }
            string json3 = JsonConvert.SerializeObject(List_date);
            ViewBag.liste_anne = json3;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
        public IActionResult population_30ans(int id)
        {

            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationOn30Async(id).Result;
            List<int> List_date = new List<int>();
            string json1 = JsonConvert.SerializeObject(PopulationAllYears.Years);
            ViewBag.liste_years = json1;
            for (var i = 1990; i <= 2020; i++)
            {
                List_date.Add(i);
            }
            string json3 = JsonConvert.SerializeObject(List_date);
            ViewBag.liste_anne = json3;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
        public IActionResult population_40ans(int id)
        {

            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationOn40Async(id).Result;
            List<int> List_date = new List<int>();
            string json1 = JsonConvert.SerializeObject(PopulationAllYears.Years);
            ViewBag.liste_years = json1;
            for (var i = 1980; i <= 2020; i++)
            {
                List_date.Add(i);
            }
            string json3 = JsonConvert.SerializeObject(List_date);
            ViewBag.liste_anne = json3;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
        public IActionResult population_50ans(int id)
        {

            Population PopulationAllYears = (Population)PopulationAPI.Instance.GetPopulationOn50Async(id).Result;
            List<int> List_date = new List<int>();
            string json1 = JsonConvert.SerializeObject(PopulationAllYears.Years);
            ViewBag.liste_years = json1;
            for (var i = 1970; i <= 2020; i++)
            {
                List_date.Add(i);
            }
            string json3 = JsonConvert.SerializeObject(List_date);
            ViewBag.liste_anne = json3;
            @ViewBag.single_population = PopulationAllYears;
            return View();
        }
    }
}
