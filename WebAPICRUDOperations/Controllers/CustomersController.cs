using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPICRUDOperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public List<string> customers=new List<string> (){ "naveeen", "vishal", "pranav", "rahul" };

        [HttpGet]
        public List<string> GetFruits()
        {
            return customers;
        }
        [HttpGet("{idx}")]
        public string GetFruitByIdx(int idx)
        {
            return customers[idx-1];
        }
    }
}
