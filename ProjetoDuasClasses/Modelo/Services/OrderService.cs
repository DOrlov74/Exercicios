using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Services
{
    public class OrderService : IOrderService
    {
        private readonly ICollection<Order> _cache=new List<Order>();
        public int Delete(Order item)
        {
            var order = _cache.FirstOrDefault(o => o.OrderId == item.OrderId);
            if (order != null)
            {
                _cache.Remove(order);
                return 0;
            }
            return -1;
        }

        public int Delete(Guid orderId, OrderLine line)
        {
            var order = _cache.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                var orderLine = order.Lines.FirstOrDefault(l => l.OrderLineId == line.OrderLineId);
                if (orderLine != null)
                {
                    order.Lines.Remove(orderLine);
                    return 0;
                }
            }
            return -1;
        }

        public int Insert(Order item)
        {
            var order= _cache.FirstOrDefault(o => o.Number == item.Number);
            if (order == null)
            {
                _cache.Add(item);
                return 0;
            }
            return -1;
        }

        public int Insert(Order item, OrderLine line)
        {
            var order=_cache.FirstOrDefault(o=>o.OrderId==item.OrderId);
            if (order != null && line != null)
            {
                var orderLine = order.Lines.FirstOrDefault(l=>l.OrderLineId==line.OrderLineId);
                if (orderLine == null)
                {
                    order.Lines.Add(line);
                    return 0;
                }
            }
            return -1;
        }

        public int Insert(Guid orderId, OrderLine line)
        {
            var order = _cache.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                var orderLine = order.Lines.FirstOrDefault(l => l.OrderLineId == line.OrderLineId);
                if (orderLine == null)
                {
                    order.Lines.Add(line);
                    return 0;
                }
            }
            return -1;
        }

        public decimal OrderLineTotal(OrderLine line)
        {
            return line.Quantity * line.Price * (1 - line.Discount / 100M) * (1 + line.Tax / 100M);
        }

        public decimal OrderTotal(Guid orderId)
        {
            var order = _cache.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                decimal total = 0;
                foreach (OrderLine line in order.Lines)
                {
                    total += OrderLineTotal(line);
                }
                return total;
            }
            return -1;
        }
        /// <summary>
        /// Devolve o list de todos Orders
        /// </summary>
        /// <returns></returns>
        public ICollection<Order> Select()
        {
            return _cache;
        }

        public ICollection<Order> Select(int clientID)
        {
            return _cache.Where(o=>o.ClientId==clientID).ToList();
        }

        public Order Select(Guid orderId)
        {
            return _cache.FirstOrDefault(o=>o.OrderId==orderId);
        }

        public int Update(Order item)
        {
            var order = _cache.FirstOrDefault(o => o.OrderId == item.OrderId);
            if (order != null)
            {
                order.Number = item.Number!=0? item.Number: order.Number;
                order.ClientId = item.ClientId!=0? item.ClientId: order.ClientId;
                order.OrderDate = item.OrderDate!=DateTime.MinValue? item.OrderDate: order.OrderDate;
                order.CreatedBy = item.CreatedBy?? order.CreatedBy;
                order.UpdatedBy = item.UpdatedBy?? order.UpdatedBy;
                order.DeletedBy = item.DeletedBy?? order.DeletedBy;
                order.IsDeleted = item.IsDeleted;
                order.Lines=new List<OrderLine>();
                foreach (OrderLine line in item.Lines)
                {
                    order.Lines.Add(line);
                }
                return 0;
            }
            return -1;
        }

        public int Update(Guid orderId, OrderLine line)
        {
            var  order=_cache.FirstOrDefault(o=>o.OrderId==orderId);
            if (order != null)
            {
                var orderLine = order.Lines.FirstOrDefault(l => l.OrderLineId == line.OrderLineId);
                if (orderLine != null)
                {
                    orderLine.ProductId = line.ProductId==0? orderLine.ProductId: line.ProductId;
                    orderLine.Discount = line.Discount==0M? orderLine.Discount: line.Discount;
                    orderLine.Tax = line.Tax==0M? orderLine.Tax: line.Tax;
                    orderLine.Price = line.Price==0M? orderLine.Price:line.Price;
                    orderLine.Quantity = line.Quantity==0M? orderLine.Quantity:line.Quantity;
                    orderLine.CreatedBy = line.CreatedBy?? orderLine.CreatedBy;
                    orderLine.UpdatedBy = line.UpdatedBy?? orderLine.UpdatedBy;
                    orderLine.DeletedBy = line.DeletedBy?? orderLine.DeletedBy;
                    orderLine.IsDeleted = line.IsDeleted;
                    return 0;
                }
            }
            return -1;
        }
    }
}
