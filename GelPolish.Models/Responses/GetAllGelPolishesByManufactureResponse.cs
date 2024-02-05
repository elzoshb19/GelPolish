using GelPolishStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.Models.Responses
{
    public class GetAllGelPolishesByManufactureResponse
    {

        public Manufacture? Manufacture { get; set; }
        public List<GelPolish>? GelPOlish { get; set; }
    }
}
