using Ecom.Services.ShoppingCartAPI.Models.Dto;

namespace Ecom.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
