using GelPolishStore.BL.Interfaces;
using GelPolishStore.Models.Models;
using GelPolishStore.Models.Responses;
using GelPolishStore.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.BL.Services
{
    public class ShopService : IShopService
    {
        private readonly IGelPolishService _gelpolishService;
        private readonly IManufactureService _manufactureService;

        public ShopService(IManufactureService manufactureService,
                                IGelPolishService gelpolishService)
        {
            _manufactureService = manufactureService;
            _gelpolishService = gelpolishService;
        }

        public Manufacture? Manufacture { get; private set; }
        public List<GelPolish>? GelPolish { get; private set; }

        public GetAllGelPolishesByManufactureResponse? GetAllGelPolishesByManufacture(GetAllGelPolishesByManufactureRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAllGelPolishesByManufactureResponse? GetAllGelPolishesByManufactureAfterDate(GetAllGelPolishesByManufactureRequest request)
        {
            var gelpolish = _gelpolishService.GetAllGelPolishesByManufacture(request.ManufactureId);
            var manufacture = _manufactureService.GetById(request.ManufactureId);
            var result = new GetAllGelPolishesByManufactureResponse();

            Manufacture = manufacture;
            GelPolish = gelpolish.Where(b => b.ReleaseDate >= request.AfterDate).ToList();

            return result;
        }
    }
}