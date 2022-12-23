using System.Threading;
using Mimo.Application.Dto;
using Mimo.Application.Services.Interfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mimo.Application.Exceptions;
using Mimo.Domain.Models;
using Mimo.Persistence;

namespace Mimo.Application.Services
{
    public sealed class AchievementService : IAchievementService
    {

        private readonly MimoDbContext _context;

        public AchievementService(MimoDbContext ctx)
        {
            _context = ctx;
        }
      
        
        public async Task<UserAchievementDto> GetUserAchievements(int userId, int achievementId)
        {


            var item = await _context.UserAchievements.
                Include(e => e.Achievement).FirstOrDefaultAsync(x => x.AchievementId ==
                    achievementId && x.UserId==userId);


            if (item == null)
                throw new NotFoundException($"Cannot find item with id: {achievementId}!");

            // smells automappers exist more than 10 years now
            // poorman's automapping :)
            var dto = UserAchievementDto.FromUserAchievement(item);

            return dto;
            

        }
        
    }

}

