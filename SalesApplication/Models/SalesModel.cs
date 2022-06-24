namespace SalesApplication.Models
{
    public class SalesModel
    {
        public int SellingPrice { get; set; } 
        public int DiscountType { get; set; }
        public double DiscountAmount { get; set; }
        public double EventPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
