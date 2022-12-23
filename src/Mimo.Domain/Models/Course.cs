using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mimo.Domain.Interfaces;

namespace Mimo.Domain.Models
{
    public class Course : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
