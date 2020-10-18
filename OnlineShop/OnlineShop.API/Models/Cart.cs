using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Models
{
    [Table("Carts")]
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public List<CartProduct> CartProducts { get; set; }
    }
}
