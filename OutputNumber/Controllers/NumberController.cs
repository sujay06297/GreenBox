using Microsoft.AspNetCore.Mvc;
using OutputNumber.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OutputNumber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly INumberService _numberService;

        public NumberController(INumberService numberService)
        {
            _numberService = numberService;
        }

        [HttpGet]
        [Route("getnumber")]
        public string GetNumber()
        {
            var result = _numberService.GetNumber();
            return result;
        }


    }
}
