using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Modelo.Services;

namespace WebOrderMVC.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _db;

        public OrdersController(IOrderService db)
        {
            _db = db;
        }
        // GET: OrdersController
        public ActionResult Index()
        {
            return View(_db.Select());
        }

        // GET: OrdersController/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_db.Select(id));
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order item)
        {
            try
            {
                _db.Insert(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_db.Select(id));
        }

        // POST: OrdersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Order item)
        {
            try
            {
                _db.Update(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdersController/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_db.Select(id));
        }

        // POST: OrdersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Order item)
        {
            try
            {
                _db.Delete(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
