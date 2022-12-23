using System.Collections.Generic;
using Mimo.Domain.Interfaces;

namespace Mimo.Domain.Models;

public class Chapter : IEntity<int>
{
    public int Id { get; set; }
    public int Order { get; set; }
    public string Name { get; set; }
    public List<Lesson> Lessons { get; set; }
    public Course Course { get; set; }
    public int CourseId { get; set; }
}
