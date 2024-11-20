using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MentorAssign
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly MathService _mathService;
        public MathController(MathService mathService)
        {
            _mathService = mathService;
        }

        [HttpGet("add")]
        public IActionResult Add([FromQuery] int num1, [FromQuery] int num2)
        {
            var result = _mathService.Add(num1, num2);
            return Ok(new { Result = result });
        }

        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] int num1, [FromQuery] int num2)
        {
            var result = _mathService.Multiply(num1, num2);
            return Ok(new { Result = result });
        }

        [HttpGet("divide")]
        public IActionResult Divide([FromQuery] double num1, [FromQuery] double num2)
        {
            if (num2 == 0) return BadRequest(new { Error = "Division by zero is not allowed." });
            var result = _mathService.Divide(num1, num2);
            return Ok(new { Result = result });
        }

        [HttpGet("subtract")]
        public IActionResult Subtract([FromHeader] int num1, [FromHeader] int num2)
        {
            var result = _mathService.Subtract(num1, num2);
            return Ok(new { Result = result });
        }
    }

    public class MultiplicationRequest
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
}
