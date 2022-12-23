using System;

namespace Mimo.Application.Dto
{
    public class LessonCompletionDto
    {
        public int LessonId { get; set; }
        public int UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        
    }
    
}
