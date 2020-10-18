using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DestritosAPI.Models
{
    public class Freguesia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Conselho")]
        public int ConselhoId { get; set; }
        public Conselho Conselho { get; set; }
    }
}
