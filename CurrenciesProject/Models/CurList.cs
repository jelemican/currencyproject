using CurrenciesProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrenciesProject.Models
{
    public class CurList
    {
        public tblCurrency AUD { get; set; }
        public tblCurrency AZN { get; set; }
        public tblCurrency GBP { get; set; }
        public tblCurrency AMD { get; set; }
        public tblCurrency BYN { get; set; }
        public tblCurrency BGN { get; set; }
        public tblCurrency BRL { get; set; }
        public tblCurrency HUF { get; set; }
        public tblCurrency HKD { get; set; }
        public tblCurrency DKK { get; set; }
        public tblCurrency USD { get; set; }
        public tblCurrency EUR { get; set; }
        public tblCurrency INR { get; set; }
        public tblCurrency KZT { get; set; }
        public tblCurrency CAD { get; set; }
        public tblCurrency KGS { get; set; }
        public tblCurrency CNY { get; set; }
        public tblCurrency MDL { get; set; }
        public tblCurrency NOK { get; set; }
        public tblCurrency PLN { get; set; }
        public tblCurrency RON { get; set; }
        public tblCurrency XDR { get; set; }
        public tblCurrency SGD { get; set; }
        public tblCurrency TJS { get; set; }
        public tblCurrency TRY { get; set; }
        public tblCurrency TMT { get; set; }
        public tblCurrency UZS { get; set; }
        public tblCurrency UAH { get; set; }
        public tblCurrency CZK { get; set; }
        public tblCurrency SEK { get; set; }
        public tblCurrency CHF { get; set; }
        public tblCurrency ZAR { get; set; }
        public tblCurrency KRW { get; set; }
        public tblCurrency JPY { get; set; }
        public List<tblCurrency> CreateList()
        {
            List<tblCurrency> res = new List<tblCurrency>();
            res.Add(this.AUD);
            res.Add(this.AZN);
            res.Add(this.GBP);
            res.Add(this.AMD);
            res.Add(this.BYN);
            res.Add(this.BGN);
            res.Add(this.BRL);
            res.Add(this.HUF);
            res.Add(this.HKD);
            res.Add(this.DKK);
            res.Add(this.USD);
            res.Add(this.EUR);
            res.Add(this.INR);
            res.Add(this.KZT);
            res.Add(this.CAD);
            res.Add(this.KGS);
            res.Add(this.CNY);
            res.Add(this.MDL);
            res.Add(this.NOK);
            res.Add(this.PLN);
            res.Add(this.RON);
            res.Add(this.XDR);
            res.Add(this.SGD);
            res.Add(this.TJS);
            res.Add(this.TRY);
            res.Add(this.TMT);
            res.Add(this.UZS);
            res.Add(this.UAH);
            res.Add(this.CZK);
            res.Add(this.SEK);
            res.Add(this.CHF);
            res.Add(this.ZAR);
            res.Add(this.KRW);
            res.Add(this.JPY);
            return res;
        }
    }
}
