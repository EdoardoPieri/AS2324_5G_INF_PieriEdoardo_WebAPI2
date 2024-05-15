using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_PieriEdoardo_WebAPI2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : Controller
    {
        [HttpGet("Celsius_To_Fahrenheit")]
        public JsonResult celsius_to_fahrenheit(float celsius)
        {
            if(celsius >= -273)
            {
                return Json(new { status = "OK", result = celsius * (1.8) + 32 , message = "temperatura calcolata correttamente"});
            } else
            {
                return Json(new { status = "KO", message = "temperatura in celsius errata" });
            }

        }
        [HttpGet("volume_cylinder")]
        public JsonResult volume_cylinder(float radius, float height)
        {
            float c_area = radius * radius * (float)Math.PI;
            return Json(new { status = "OK", result = c_area * height, message = "volume calcolato correttamente" });
        }
    }
}
