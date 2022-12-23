using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Mimo.Api.Controllers;

[Route("api/[controller]")]
public class BaseControllerV1 : ControllerBase
{
    protected IServiceProvider Resolver => HttpContext.RequestServices;

    protected T GetService<T>()
    {
        return Resolver.GetService<T>();
    }

    protected ILogger Logger => GetService<ILogger>();
}
