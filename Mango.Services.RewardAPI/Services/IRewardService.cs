using Ecom.Services.RewardAPI.Message;

namespace Ecom.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
