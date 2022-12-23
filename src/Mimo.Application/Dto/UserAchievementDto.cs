using Mimo.Domain.Models;

namespace Mimo.Application.Dto;

public class UserAchievementDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsCompleted { get; set; }
    public int Progress { get; set; }

    public static UserAchievementDto FromUserAchievement(UserAchievement item)
    {
        return new UserAchievementDto()
        {

            Id = item.Id,
            IsCompleted = item.IsCompleted,
            Progress = item.Progress,
            Name = item.Achievement.Name,
            

        };
    }


}




