using Microsoft.EntityFrameworkCore;
using SalesApplication.Models;

namespace SalesApplication.DataBaseLayer
{
    public class SalesDbContex : DbContext
    {
        public SalesDbContex(DbContextOptions<SalesDbContex> options) : base(options)
        {

        }
        public DbSet<SalesModel> SalesModel { get; set; }
       
    }
}
