using Mimo.Domain.Interfaces;

namespace Mimo.Domain.Models;

public class Lesson : IEntity<int>
{
    public int Id { get; set; }
    public int Order { get; set; }
    public string Name { get; set; }
    public Chapter Chapter { get; set; }
}