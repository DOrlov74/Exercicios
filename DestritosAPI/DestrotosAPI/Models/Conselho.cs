using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DestritosAPI.Models
{
    public class Conselho
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Distrito")]
        public int DistritoId { get; set; }
        public Distrito Distrito { get; set; }
        public List<Freguesia> Freguesias { get; set; }
    }
}
