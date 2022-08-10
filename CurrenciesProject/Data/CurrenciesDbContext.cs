using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrenciesProject.Data
{
    public class CurrenciesDbContext: DbContext
    {
        public CurrenciesDbContext(DbContextOptions<CurrenciesDbContext> options): base(options)
        {

        }
        public DbSet<tblCurrency> tblCurrency { get; set; }
    }
}
