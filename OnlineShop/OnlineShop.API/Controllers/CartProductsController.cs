using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Data;
using OnlineShop.API.Models;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartProductsController : ControllerBase
    {
        private readonly OnlineShopContext _context;

        public CartProductsController(OnlineShopContext context)
        {
            _context = context;
        }

        // GET: api/CartProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartProduct>>> GetCartProduct()
        {
            return await _context.CartProducts.ToListAsync();
        }

        // GET: api/CartProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CartProduct>> GetCartProduct(int id)
        {
            var cartProduct = await _context.CartProducts.FindAsync(id);

            if (cartProduct == null)
            {
                return NotFound();
            }

            return cartProduct;
        }

        // PUT: api/CartProducts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartProduct(int id, CartProduct cartProduct)
        {
            if (id != cartProduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(cartProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CartProducts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CartProduct>> PostCartProduct(CartProduct cartProduct)
        {
            _context.CartProducts.Add(cartProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCartProduct", new { id = cartProduct.Id }, cartProduct);
        }

        // DELETE: api/CartProducts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CartProduct>> DeleteCartProduct(int id)
        {
            var cartProduct = await _context.CartProducts.FindAsync(id);
            if (cartProduct == null)
            {
                return NotFound();
            }

            _context.CartProducts.Remove(cartProduct);
            await _context.SaveChangesAsync();

            return cartProduct;
        }

        private bool CartProductExists(int id)
        {
            return _context.CartProducts.Any(e => e.Id == id);
        }
    }
}
