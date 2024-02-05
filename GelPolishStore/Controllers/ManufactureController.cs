using GelPolishStore.BL.Interfaces;
using GelPolishStore.BL.Services;
using GelPolishStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace GelPolishStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManufactureController : ControllerBase
    {


        private readonly IManufactureService _manufactureService;

        public ManufactureController(ManufactureService manufactureService)
        {
            _manufactureService = manufactureService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Manufacture> GetAll() => _manufactureService.GetAll();

        [HttpGet("GetById")]

        public Manufacture? GetById(int id)
        {
            return _manufactureService.GetById(id);
        }

        [HttpPost("Add")]

        public void Add([FromBody] Manufacture manufacture)
        {
            _manufactureService.Add(manufacture);
        }

        [HttpDelete("Delete")]

        public void Delete(int id)
        {
            _manufactureService.Delete(id);
        }
    }
}