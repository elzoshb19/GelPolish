using GelPolishStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.BL.Interfaces
{
    public interface IGelPolishService
    {
        List<GelPolish> GetAllGelPolishesByManufacture(int manufactureId);
    }
}
