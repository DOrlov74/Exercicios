using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Services
{
    public interface IOrderService
    {
        int Insert(Order item);
        int Insert(Order item, OrderLine line);
        int Insert(Guid orderId, OrderLine line);
        ICollection<Order> Select();
        ICollection<Order> Select(int clientID);
        Order Select(Guid orderId);
        int Update(Order item);
        int Update(Guid orderId, OrderLine line);
        int Delete(Order item);
        int Delete(Guid orderId, OrderLine line);
        //Negocio
        decimal OrderTotal(Guid orderId);   //  Total da order
        decimal OrderLineTotal(OrderLine line); //  Total da linha
    }
}
