using Microsoft.AspNetCore.Mvc;
using SalesApplication.DataBaseLayer;
using SalesApplication.Models;

namespace SalesApplication.Controllers
{
    public class SalesController : Controller
    {
        private SalesDbContex salesDbContext { get; }
        public SalesController(SalesDbContex _context)
        {
            this.salesDbContext = _context;
        }

        [Route("api/[Controller]")]

        [HttpPost]
        public void SaveSalesData([FromBody] SalesModel salesModel)
        {
            if (salesModel != null)
            {
                if (salesModel.DiscountType == 0)// discount amount in doller
                {
                    salesModel.EventPrice = salesModel.SellingPrice - salesModel.DiscountAmount;
                }
                else
                {
                    salesModel.EventPrice = (salesModel.DiscountAmount/100) * salesModel.SellingPrice;
                }
                this.salesDbContext.SalesModel.Add(salesModel);
                this.salesDbContext.SaveChanges();
            }
        }
    }

    //table structure
    //CREATE TABLE Sales (

    //   [Id][int] IDENTITY(1,1) NOT NULL,
    //   [SallingPrice] [int] NOT NULL,
    //   [DiscountType] [int] NOT NULL,
    //   [DiscountAmount][float] NOT NULL,
    //   [EventPrice][float] NOT NULL,
    //   [StartDate] date NOT NULL,
    //   [EndDate] date NOT NULL,
    //) GO
}
