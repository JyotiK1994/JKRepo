using AutoMapper;
using Ecom.Services.ProductAPI.Models;
using Ecom.Services.ProductAPI.Models.Dto;

namespace Ecom.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
