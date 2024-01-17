// MyApiController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/bmi")]
public class BmiController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from MyApi");
    }

    //支援post方法，可傳入身高體重，計算bmi的api
    [HttpPost]
    public IActionResult Post([FromBody] BmiModel model)
    {
        var bmi = model.Weight / Math.Pow(model.Height / 100, 2);
        return Ok(bmi);
    }
}

// 建立 BmiModel 類別
public class BmiModel
{
    public double Height { get; set; }
    public double Weight { get; set; }
}

