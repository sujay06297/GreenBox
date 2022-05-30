using GreenBox.Filters;
using InputNumber.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InputNumber.Controllers
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

        // POST api/<NumberController>
        [HttpPost]
        [Route("createnumber")]
        [ServiceFilter(typeof(ActionFilter))]
        public void CreateNumber([FromBody] string number)
        {
            _numberService.CreateNumber(number);
            
        }

    }
}
