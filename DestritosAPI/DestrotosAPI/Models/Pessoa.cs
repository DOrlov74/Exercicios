using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DestritosAPI.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Distrito")] 
        public int DistritoId { get; set; }

        public Distrito Distrito { get; set; }
        [ForeignKey("Conselho")]
        public int ConselhoId { get; set; }

        public Conselho Conselho { get; set; }
        [ForeignKey("Freguesia")]
        public int FreguesiaId { get; set; }

        public Freguesia Freguesia { get; set; }
    }
}
