using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using Modelo.Services;

namespace ModeloTest
{
    [TestClass]
    public class TestOrderService
    {
        private IOrderService service;
        [TestMethod]
        public void TestInsertOrder()
        {
            //  Prepare
            service=new OrderService(); //DI -> services.AddSingleton<IOrderService, OrderService>
            //  Execute
            var r = service.Insert(new Order() {Number = 1});
            //  Assert
            Assert.AreEqual(0, r);
            //Execute
            r = service.Insert(new Order() { Number = 1 });
            //  Assert
            Assert.AreEqual(-1, r);
            r = service.Insert(new Order() { Number = 2 });
            //  Assert
            Assert.AreEqual(0, r);
            //  Prepare
            var line1 = new OrderLine() { OrderLineId = 1, ProductId = 1, Price = 10M, Quantity = 5M, Discount = 3M, Tax = 2M, CreatedBy = "admin" };
            var line2 = new OrderLine() { OrderLineId = 2, ProductId = 2, Price = 15M, Quantity = 7M, Discount = 5M, Tax = 4M, CreatedBy = "user" };
            var orderId = service.Select().ToList()[0].OrderId;
            //Execute
            var result=service.Insert(orderId, line1);
            var order = service.Select(orderId);
            //  Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(1, order.Lines.ToList().Count);
            Assert.AreEqual(1, order.Lines.ToList()[0].OrderLineId);
            Assert.AreEqual(1, order.Lines.ToList()[0].ProductId);
            Assert.AreEqual(10M, order.Lines.ToList()[0].Price);
            Assert.AreEqual(5M, order.Lines.ToList()[0].Quantity);
            Assert.AreEqual(3M, order.Lines.ToList()[0].Discount);
            Assert.AreEqual(2M, order.Lines.ToList()[0].Tax);
            Assert.AreEqual("admin", order.Lines.ToList()[0].CreatedBy);
            Assert.AreEqual(false, order.Lines.ToList()[0].IsDeleted);
            //Execute
            result = service.Insert(orderId, line1);
            //  Assert
            Assert.AreEqual(-1, result);
            //Execute
            result = service.Insert(orderId, line2);
            //  Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(2, order.Lines.ToList()[1].OrderLineId);
            Assert.AreEqual(2, order.Lines.ToList()[1].ProductId);
            Assert.AreEqual(15M, order.Lines.ToList()[1].Price);
            Assert.AreEqual(7M, order.Lines.ToList()[1].Quantity);
            Assert.AreEqual(5M, order.Lines.ToList()[1].Discount);
            Assert.AreEqual(4M, order.Lines.ToList()[1].Tax);
            Assert.AreEqual("user", order.Lines.ToList()[1].CreatedBy);
            Assert.AreEqual(false, order.Lines.ToList()[1].IsDeleted);
        }
        [TestMethod]
        public void TestSelectOrder()
        {
            //  Prepare
            service = new OrderService();
            var r = service.Insert(new Order() { Number = 1 });
            r = service.Insert(new Order() { Number = 2 });
            //  Execute
            var orders = service.Select();
            //  Assert
            Assert.AreEqual(2, orders.Count);
            Assert.AreEqual(1, orders.ToList()[0].Number);
            Assert.AreEqual(2, orders.ToList()[1].Number);
            //  Prepare
            orders.ToList()[0].ClientId = 1;
            orders.ToList()[1].ClientId = 1;
            //  Execute
            var clientOrders = service.Select(1);
            //  Assert
            Assert.AreEqual(2, clientOrders.Count);
            Assert.AreEqual(1, clientOrders.ToList()[0].Number);
            Assert.AreEqual(2, clientOrders.ToList()[1].Number);
        }
        [TestMethod]
        public void TestUpdateOrder()
        {
            //  Prepare
            service = new OrderService();
            var r = service.Insert(new Order() { OrderId = Guid.NewGuid(), Number = 1, ClientId = 1, IsDeleted = false, CreatedBy = "admin", OrderDate = DateTime.Now});
            r = service.Insert(new Order() { OrderId =Guid.NewGuid(), Number = 2, ClientId = 1, IsDeleted = false, CreatedBy = "user", OrderDate = DateTime.Now });
            var order1Id = service.Select().ToList()[0].OrderId;
            var order2Id = service.Select().ToList()[1].OrderId;
            //  Execute
            var result = service.Update(new Order() { OrderId = order1Id, Number = 3, ClientId = 2, UpdatedBy = "user2" });
            var order1 = service.Select(order1Id);
            //  Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(3, order1.Number);
            Assert.AreEqual(2, order1.ClientId);
            Assert.AreEqual("user2", order1.UpdatedBy);
            Assert.AreEqual("admin", order1.CreatedBy);
            //  Prepare
            var line1=new OrderLine(){OrderLineId = 1, ProductId = 1, Price = 10M, Quantity = 5M, Discount = 3M, Tax = 2M, CreatedBy = "admin"};
            var line2 = new OrderLine() { OrderLineId = 1, ProductId = 2, Price = 15M, Quantity = 7M, Discount = 5M, Tax = 4M, CreatedBy = "user" };
            service.Insert(order2Id, line1); ;
            //  Execute
            result = service.Update(order2Id, line2);
            var order2 = service.Select(order2Id);
            //  Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(1, order2.Lines.ToList().Count);
            Assert.AreEqual(1, order2.Lines.ToList()[0].OrderLineId);
            Assert.AreEqual(2, order2.Lines.ToList()[0].ProductId);
            Assert.AreEqual(15M, order2.Lines.ToList()[0].Price);
            Assert.AreEqual(7M, order2.Lines.ToList()[0].Quantity);
            Assert.AreEqual(5M, order2.Lines.ToList()[0].Discount);
            Assert.AreEqual(4M, order2.Lines.ToList()[0].Tax);
            Assert.AreEqual("user", order2.Lines.ToList()[0].CreatedBy);
            Assert.AreEqual(false, order2.Lines.ToList()[0].IsDeleted);
        }
    }
}
