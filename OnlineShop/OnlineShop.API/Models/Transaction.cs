using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.API.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        public int Id { get; set; }
        public bool Approved { get; set; }
        public DateTime TimeOfPayment { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public Decimal? Total { get; set; }
        [ForeignKey("Client")] 
        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
