using GelPolishStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.DL.MemoryDB
{
    public static class InMemoryDB
    {
        public static List<GelPolish> GelPolishData = new List<GelPolish>()
        {
            new GelPolish()
            {
                Id = 1,
                ManufactureID = 1,
                ReleaseDate = new DateTime(2022,02,12),
                Title = "GelPolish 1"
            },
            new GelPolish()
            {
                Id = 2,
                ManufactureID = 2,
                ReleaseDate = new DateTime(2023,02,12),
                Title = "GelPolish 2"
            }
        };
        public static List<Manufacture> ManufactureData = new List<Manufacture>()
        {
            new Manufacture()
            {
                Id = 1,
                Name = "Manufacture 1",
                BirthDay = DateTime.Now
            },
            new Manufacture()
            {
                Id = 2,
                Name = "Manufacture 2",
                BirthDay = DateTime.Now
            },
            new Manufacture()
            {
                Id = 3,
                Name = "Manufacture 3",
                BirthDay = DateTime.Now
            }
        };
    }
}