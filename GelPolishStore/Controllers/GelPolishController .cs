using GelPolishStore.BL.Interfaces;
using GelPolishStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace GelPolishStore.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GelPolishController : ControllerBase
    {

        private readonly IGelPolishService _gelpolishService;

        public GelPolishController(IGelPolishService gelpolishService)
        {
            _gelpolishService = gelpolishService;
        }

        [HttpGet("GetAllGelPolishesByManufacture")]
        public IEnumerable<GelPolish> GetAllGelPolishesByManufacture(int manufactureId)
        {
            return _gelpolishService.GetAllGelPolishesByManufacture(manufactureId);
        }
    }
}