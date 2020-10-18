using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DestritosAPI.Models
{
    public class Distrito
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Conselho> Conselhos { get; set; }
    }
}
