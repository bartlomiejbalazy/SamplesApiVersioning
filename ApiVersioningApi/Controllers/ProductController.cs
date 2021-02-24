using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ProductModelV1> GetProductV1()
        {
            return new ProductModelV1()
            {
                Name = "Resharper",
                Price = 300M
            };
        }
        
        [HttpGet]
        [MapToApiVersion("2.0")]
        public ActionResult<ProductModelV2> GetProductV2()
        {
            return new ProductModelV2()
            {
                ProductName = "Resharper",
                Price = 300M
            };
        }
    }
}