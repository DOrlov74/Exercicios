using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Price { get; set; }
        public bool Descounted { get; private set; }
        [Url]
        public string ImageURL { get; set; }
        public List<CartProduct> CartProducts { get; set; }
    }
}
