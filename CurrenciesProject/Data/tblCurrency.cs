using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrenciesProject.Data
{
    public class tblCurrency
    {
		[Key]
		public int ID_column { get; set; }

		public string ID { get; set; }

		public int NumCode { get; set; }

		public string CharCode { get; set; }

		public int Nominal { get; set; }

		public string Name { get; set; }

		public double Value { get; set; }

		public double Previous { get; set; }
	}
}
