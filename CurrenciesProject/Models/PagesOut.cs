using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrenciesProject.Data;

namespace CurrenciesProject.Models
{
    public class PagesOut
    {
        public List<tblCurrency> thelist { get; set; }
        public string previouspage { get; set; }
        public string nextpage { get; set; }
        public PagesOut()
        {
            this.thelist = new List<tblCurrency>();
        }
    }
}
