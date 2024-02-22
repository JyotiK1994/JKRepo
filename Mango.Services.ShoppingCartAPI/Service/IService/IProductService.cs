using Ecom.Services.ShoppingCartAPI.Models.Dto;

namespace Ecom.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
