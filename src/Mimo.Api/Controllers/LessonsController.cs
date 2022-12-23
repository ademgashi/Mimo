using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mimo.Application.Dto;
using Mimo.Application.Services.Interfaces;

namespace Mimo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LessonsController : BaseControllerV1
{

    private readonly ILessonService _service;
    private readonly ILogger<LessonsController> _logger;

    public LessonsController(ILessonService service, ILogger<LessonsController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpPost]
    public async Task<ActionResult<LessonCompletionDto>> UpdateLessonProgress([FromBody] LessonCompletionDto input)
    {
        _logger.LogInformation("UpdateLessonsProgress");
        var result = await _service.UpdateLessonProgress(input);

        return Ok(result);
        
    }
}
