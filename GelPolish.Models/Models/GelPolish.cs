using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelPolishStore.Models.Models
{
    public class GelPolish
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int ManufactureID { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}