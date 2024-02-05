using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.Models.Requests
{
    public class GetAllGelPolishesByManufactureRequest
    {
        public int ManufactureId { get; set; }
        public int manufactureId { get; set; }
        public DateTime AfterDate { get; set; }
    }
}
