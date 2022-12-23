using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mimo.Application.Dto;
using Mimo.Application.Services.Interfaces;

namespace Mimo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AchievementsController : BaseControllerV1
{
      
    private readonly IAchievementService _service;
    private readonly ILogger<AchievementsController> _logger;

    public AchievementsController(IAchievementService service, ILogger<AchievementsController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<UserAchievementDto>> GetAchievementProgress(int userId, int achievementId)
    {
        _logger.LogInformation("GetAchievement");
        var achievements = await _service.GetUserAchievements(userId, achievementId);

        return Ok(achievements);

        //return achievements.Select(a => new AchievementDto
        //{
        //    Id = a.Id,
        //    Name = a.Name,
        //    IsCompleted = _service.IsAchievementCompleted(1, a.Id), // hardcoded user ID for simplicity
        //    Progress = _service.GetAchievementProgress(1, a.Id) // hardcoded user ID for simplicity
        //}).ToList();
    }
}
