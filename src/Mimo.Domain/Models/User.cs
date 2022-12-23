using System;
using System.Collections.Generic;
using Mimo.Domain.Interfaces;

namespace Mimo.Domain.Models;

public class User : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<LessonCompletion> LessonCompletions { get; set; }
    public List<UserAchievement> UserAchievements { get; set; }
}


public class UserAchievement : IEntity<int>
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int AchievementId { get; set; }
    public Achievement Achievement { get; set; }
    public DateTime CompletedAt { get; set; }
    public bool IsCompleted { get; set; }

    public int Progress { get; set; }
    
}
