using ApiPopStat.Data;
using ApiPopStat.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPopStat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulationTestController : ControllerBase
    {

        private readonly ApiPopStatContext _context;

        public PopulationTestController(ApiPopStatContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Population>> GetPopulationAllName()
        {
            List<Population> List = new List<Population>();

            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetchAll_name();
            return (List);
        }
        [HttpGet("GetAllYears/{id}")]
        public ActionResult<Population> GetAllYears(int id)
        {
            Population List = new Population();
            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_All_Years(id);
            return (List);
        }
        [HttpGet("GetOneName/{id}")]
        public ActionResult<List<String>> GetOneName(int id)
        {
            List<string> List;

            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_One_name(id);
            return (List);
        }
        [HttpGet("GetPopulation5ans/{id}")]
        public ActionResult<Population> GetPopulation5ans(int id)
        {
            Population List = new Population();
            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_population_5_ans(id);
            return (List);
        }
        [HttpGet("GetPopulation10ans/{id}")]
        public ActionResult<Population> GetPopulation10ans(int id)
        {
            Population List = new Population();
            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_population_10_ans(id);
            return (List);
        }
        [HttpGet("GetPopulation20ans/{id}")]
        public ActionResult<Population> GetPopulation20ans(int id)
        {
            Population List = new Population();
            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_population_20_ans(id);
            return (List);
        }
        [HttpGet("GetPopulation30ans/{id}")]
        public ActionResult<Population> GetPopulation30ans(int id)
        {
            Population List = new Population();
            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_population_30_ans(id);
            return (List);
        }
        [HttpGet("GetPopulation40ans/{id}")]
        public ActionResult<Population> GetPopulation40ans(int id)
        {
            Population List = new Population();
            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_population_40_ans(id);
            return (List);
        }
        [HttpGet("GetPopulation50ans/{id}")]
        public ActionResult<Population> GetPopulation50ans(int id)
        {
            Population List = new Population();
            PopulationDAO populationDao = new PopulationDAO();
            List = populationDao.fetch_population_50_ans(id);
            return (List);
        }
        //// GET: api/<PopulationTestController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<PopulationTestController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
    }
}
