using Microsoft.AspNetCore.Mvc;

namespace ApiLuiz.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase {
        


        [HttpGet(Name = "GetWeatherForecast")]
        public string Get() 
        {

            return "Presciso trabalhar, me ajude a me tornar um grande desenvolvedor";
            
        }
    }
}