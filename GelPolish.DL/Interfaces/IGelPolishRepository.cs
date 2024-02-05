using GelPolishStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.DL.Repositories
{
    public interface IGelPolishRepository
    {
        List<GelPolish> GetAllGelPolishesByManufacture(int manufactureId);

        //  Book? GetByTitle(string title);
    }
}
