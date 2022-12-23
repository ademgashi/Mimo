using Mimo.Application.Dto;
using Mimo.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Mimo.Application.Services.Interfaces
{
    public interface IAchievementService
    {
        Task<UserAchievementDto> GetUserAchievements(int userId, int achievementId);
        
    }
}
