using CurrenciesProject.Data;
using CurrenciesProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrenciesProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private CurrenciesDbContext _dbContext;
        
        public CurrencyController(CurrenciesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DbUpdate(string response)
        {
            JsonRead res = JsonConvert.DeserializeObject<JsonRead>(response);
            List<tblCurrency> thelist = res.Valute.CreateList();
            foreach (tblCurrency item in thelist)
            {
                tblCurrency row = _dbContext.tblCurrency.Where(x => x.ID == item.ID).FirstOrDefault();
                if (row == null)
                {
                    tblCurrency temp = new tblCurrency();
                    temp.ID = item.ID;
                    temp.Name = item.Name;
                    temp.Nominal = item.Nominal;
                    temp.NumCode = item.NumCode;
                    temp.Value = item.Value;
                    temp.Previous = item.Previous;
                    temp.CharCode = item.CharCode;
                    _dbContext.tblCurrency.Add(temp);
                    _dbContext.SaveChanges();
                }
                else
                {
                    row.Value = item.Value;
                    row.Previous = item.Previous;
                    _dbContext.Entry(row).State = EntityState.Modified;
                    _dbContext.SaveChanges();
                }
                
            }
        }

        [HttpGet("currencies")]
        public async Task<IActionResult> Get([FromQuery]int page)
        {
            CurrencyController temp = new CurrencyController(_dbContext);
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");
            temp.DbUpdate(response);
            int Id = page;
            try
            {
                var cures = _dbContext.tblCurrency.ToList();
                if (cures.Count == 0)
                {
                    return StatusCode(404, "No currencies were found in the database");
                }
                PagesOut result = new PagesOut();
                if (Id < 1)
                {
                    Id = 1;
                }
                else if (Id > 7)
                {
                    Id = 7;
                }
                if (Id == 7)
                {
                    for (int i = 30; i < 34; i++)
                    {
                        result.thelist.Add(cures[i]);
                    }
                    result.nextpage = "None";
                    result.previouspage = "https://localhost:44318/api/currency/currencies?page=6";
                }
                else if (Id == 1)
                {
                    for (int i = Id * 5 - 5; i < Id * 5; i++)
                    {
                        result.thelist.Add(cures[i]);
                    }
                    result.nextpage = "https://localhost:44318/api/currency/currencies?page=2";
                    result.previouspage = "None";
                }
                else
                {
                    for (int i = Id * 5 - 5; i < Id * 5; i++)
                    {
                        result.thelist.Add(cures[i]);
                    }
                    result.nextpage = "https://localhost:44318/api/currency/currencies?page=" + Convert.ToString(Id + 1);
                    result.previouspage = "https://localhost:44318/api/currency/currencies?page=" + Convert.ToString(Id - 1);
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500, "An error ccured while sending the data to you");
            }
        }
        [HttpGet("currency/{Id}")]
        public async Task<IActionResult> Get1(int Id)
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");
            CurrencyController temp = new CurrencyController(_dbContext);
            temp.DbUpdate(response);
            try
            {
                var row = _dbContext.tblCurrency.FirstOrDefault(x => x.ID_column == Id);
                return Ok(row);
            }
            catch (Exception)
            {
                return StatusCode(404, "The typed number of currency was not found in the database");
            }
            
        }

    }
}
