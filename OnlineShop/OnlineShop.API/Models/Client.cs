using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Models
{
    [Table("Clients")]
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25), MinLength(4)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(16), MinLength(6)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        [RegularExpression("(PT)?[0-9]{9}")]
        public ulong NIF { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal PaidOut { get; set; }
        [ForeignKey("Discount")]
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
