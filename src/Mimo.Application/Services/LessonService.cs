using Mimo.Application.Services.Interfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mimo.Application.Dto;
using Mimo.Domain.Models;
using Mimo.Persistence;

namespace Mimo.Application.Services
{
    public sealed class LessonService : ILessonService
    {
        private readonly MimoDbContext _context;

        public LessonService(MimoDbContext ctx)
        {
            _context = ctx;
        }

        public async Task<int> UpdateLessonProgress(LessonCompletionDto input)
        {

            var item = await _context.LessonCompletions.Include(e => e.Lesson).
                FirstOrDefaultAsync(x => x.LessonId == input.LessonId && x.UserId == input.LessonId) ?? new LessonCompletion()
                {
                    UserId = input.LessonId,
                    LessonId = input.LessonId

                };

            //automapper here
            item.StartTime = input.StartTime;
            item.EndTime = input.EndTime;
            if (item.Id == 0)
                _context.LessonCompletions.Add(item);
            else
            {
                _context.LessonCompletions.Update(item);

            }

            return await _context.SaveChangesAsync();
        }
    }

}

