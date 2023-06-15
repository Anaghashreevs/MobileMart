using Microsoft.AspNetCore.Mvc;
using MobileMart.Enums;
using MobileMart.Interface;
using MobileMart.Service;

namespace MobileMart.Controllers
{
    [ApiController]
    [Route("[MobileMartSaleController]")]
    public class MobileMartSaleController: ControllerBase
    {
        private readonly IConfigProvider _configProvider;
        public MobileMartSaleController(IConfigProvider configProvider)
        {
            _configProvider = configProvider;
             
        }

        [HttpGet(Name = "MobileMart")]
        public IActionResult ProductDetails()
        {
           // _configProvider.GetConfigDetails();

            
            return new OkResult();
        }
    }
}
