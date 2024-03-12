using Microsoft.AspNetCore.Mvc;

namespace MonolithFormulaOne.Shared.Abstractions.Controller;

[ApiController]
[Route(BasePath + "/[controller]")]
public class BaseController : ControllerBase
{
    protected const string BasePath = "api/v1";
}