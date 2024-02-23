using Ecom.Services.EmailAPI.Message;
using Ecom.Services.EmailAPI.Models.Dto;

namespace Ecom.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
