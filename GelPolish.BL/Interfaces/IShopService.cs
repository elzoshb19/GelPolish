using GelPolishStore.Models.Requests;
using GelPolishStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.BL.Interfaces
{
    public interface IShopService
    {
        GetAllGelPolishesByManufactureResponse?
             GetAllGelPolishesByManufacture(GetAllGelPolishesByManufactureRequest request);
    }
}
