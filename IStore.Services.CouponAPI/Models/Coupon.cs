using System.ComponentModel.DataAnnotations;

namespace IStore.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CouponCode { get; set; } = null!;
        [Required]
        public double DiscountAmount { get; set; }
        public double MinAmount { get; set; }
    }
}
