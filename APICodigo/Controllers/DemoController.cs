using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICodigo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "GetPeople")]
        public List<string> GetPeople()
        {
            var response = new List<string>();
            response.Add("Hugo");
            response.Add("Elvis");
            response.Add("Ariana");
            response.Add("Carlos");

            return response;

        }



    }
}
