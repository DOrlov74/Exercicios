using System;
using System.Collections.Generic;

namespace Modelo
{
    public class Order:Auditable
    {
        public Guid OrderId { get; set; }=Guid.NewGuid();
        public int ClientId { get; set; }
        public int Number { get; set; } //Requisito Legal (SAFT)
        public DateTime OrderDate { get; set; }
        public ICollection<OrderLine> Lines { get; set; }=new List<OrderLine>();
    }

    public class OrderLine:Auditable
    {
        public int OrderLineId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
    }
}
