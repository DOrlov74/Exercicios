using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Models
{
    [Table("Discounts")]
    public class Discount
    {
        public int Id { get; set; }
        [Range(0, 100)]
        public int Percent { get; set; }
        public List<Client> Clients { get; set; }
    }
}
