namespace IStore.Services.CouponAPI.Models.DTOs
{
    public class CouponDto
    {
        public int Id { get; set; }
        public string CouponCode { get; set; } = null!;
        public double DiscountAmount { get; set; }
        public double MinAmount { get; set; }
    }
}
