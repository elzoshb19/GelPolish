using GelPolishStore.DL.MemoryDB;
using GelPolishStore.Models.Models;
using GelPolishStore.DL.MemoryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.DL.Repositories
{
    public class GelPolishRepository : IGelPolishRepository
    {
        public List<GelPolish> GetAllGelPolishesByManufacture(int manufactureId)
        {
            var result = InMemoryDB.GelPolishData.Where(b => b.ManufactureID == manufactureId).ToList();
            return result;
        }
    }
}
