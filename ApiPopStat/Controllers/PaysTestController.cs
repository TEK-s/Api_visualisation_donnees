using ApiPopStat.Data;
using ApiPopStat.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPopStat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaysTestController : ControllerBase
    {
        private readonly ApiPopStatContext _context;

        public PaysTestController(ApiPopStatContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Pays>> GetAllPays()
        {
            List<Pays> List = new List<Pays>();

            PaysDAO paysDao = new PaysDAO();
            List = paysDao.fetchAll();
            return (List);
        }
        [HttpGet("GetAllPays1")]
        public ActionResult<List<Pays>> GetAllPays1()
        {
            List<Pays> List = new List<Pays>();

            PaysDAO paysDao = new PaysDAO();
            List = paysDao.fetchAll();
            return (List);
        }
        [HttpGet("GetIncome")]
        public ActionResult<List<String>> GetIncome()
        {
            List<String> ListIconmeName = new List<String>();

            PaysDAO paysDao = new PaysDAO();
            ListIconmeName = paysDao.fetchIncome();
            return (ListIconmeName);
        }
        [HttpGet("GetRegion")]
        public ActionResult<List<String>> GetRegion()
        {
            List<String> List_Region = new List<String>();

            PaysDAO paysDao = new PaysDAO();
            List_Region = paysDao.fetch_Region();
            return (List_Region);
        }
        [HttpGet("GetCountIncome")]
        public ActionResult<List<int>> GetCountIncome()
        {
            List<int> ListCountIncome = new List<int>();

            PaysDAO paysDao = new PaysDAO();
            ListCountIncome = paysDao.fetch_count_income();
            return (ListCountIncome);
        }
        [HttpGet("GetCountRegion")]
        public ActionResult<List<int>> GetCountRegion()
        {
            List<int> ListCountRegion = new List<int>();

            PaysDAO paysDao = new PaysDAO();
            ListCountRegion = paysDao.fetch_count_Region();
            return (ListCountRegion);
        }

    }
}
