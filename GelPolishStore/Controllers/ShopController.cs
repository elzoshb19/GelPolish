using GelPolishStore.BL.Interfaces;
using GelPolishStore.Models.Requests;
using GelPolishStore.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GelPolishStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpPost("GetAllGelPolishesByManufacture")]
        public GetAllGelPolishesByManufactureResponse?

            GetAllGelPolishesByManufacture([FromBody] GetAllGelPolishesByManufactureRequest request) => _shopService.GetAllGelPolishesByManufacture(request);

        [HttpPost("TestEndPoint")]
        public string TestEndPoint([FromBody]

            GetAllGelPolishesByManufactureRequest request)
        {
            return "Ok";
        }
    }
}