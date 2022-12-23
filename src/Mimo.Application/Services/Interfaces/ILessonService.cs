using System;
using System.Threading.Tasks;
using Mimo.Application.Dto;

namespace Mimo.Application.Services.Interfaces
{
    public interface ILessonService
    {
        Task<int> UpdateLessonProgress(LessonCompletionDto input);

    }
}
