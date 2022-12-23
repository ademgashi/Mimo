using Mimo.Domain.Interfaces;

namespace Mimo.Domain.Models;

public class Achievement : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
   
}
