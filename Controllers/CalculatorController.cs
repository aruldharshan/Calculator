using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("Add")]
    public string Add(int a, int b){
        return (a + b).ToString();
    }
}
