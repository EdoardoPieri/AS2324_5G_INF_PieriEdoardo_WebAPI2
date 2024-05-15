using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_PieriEdoardo_WebAPI2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : Controller
    {
        [HttpGet("Celsius to Fahrenheit")]
        public JsonResult celsius_to_fahrenheit(float celsius)
        {
            if(celsius > -273)
            {
                return Json(new { status = "OK", result = celsius * (1.8) + 32 , message = "temperatura calcolata correttamente"});
            } else
            {
                return Json(new { status = "KO", message = "temperatura in celsius errata" });
            }

        }
    }
}
