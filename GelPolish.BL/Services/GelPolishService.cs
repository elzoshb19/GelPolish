using GelPolishStore.BL.Interfaces;
using GelPolishStore.DL.Repositories;
using GelPolishStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolisStore.BL.Services
{
    public class GelPolishService : IGelPolishService

    {
        private readonly IGelPolishRepository _gelpolishRepository;
        public GelPolishService(GelPolishRepository gelpolishRepository)
        {
            _gelpolishRepository = gelpolishRepository;
        }
        public List<GelPolish> GetAllGelPolishesByManufacture(int manufactureId)
        {
            return _gelpolishRepository.GetAllGelPolishesByManufacture(manufactureId);
        }
    }
}