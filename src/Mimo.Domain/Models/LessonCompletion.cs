using System;
using Mimo.Domain.Interfaces;

namespace Mimo.Domain.Models;

public class LessonCompletion : IEntity<int>
{
    public int Id { get; set; }
    public Lesson Lesson { get; set; }
    public User User { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int UserId { get; set; }
    public int LessonId { get; set; }
}
