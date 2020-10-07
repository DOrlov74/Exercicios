using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_exercicio1.Models;
using MVC_exercicio1.Services;

namespace MVC_exercicio1.Controllers
{
    public class ProductController : Controller
    {
        private Context _context;
        private IProductService _productService;

        public ProductController(Context context, IProductService productService)
        {
            _productService = productService;
            _context = context;
        }
        public IEnumerable<Produto> Index()
        {
            //List<Produto> result = new List<Produto>();
            //foreach (Produto p in _context.Products)
            //{
            //    result.Add(p);
            //}

            //return result;
            return _productService.ListagemDeProdutos();
        }

        public string max()
        {
            Produto result = _productService.ProdutoMaisCaro();
            return $"The product {result.Name} has the highest price of {result.Price}";
        }

        public string min()
        {
            Produto result = _productService.ProdutoMaisBarato();
            return $"The product {result.Name} has the lowest price of {result.Price}";
        }

        public string average()
        {
            return _productService.MediaDePrecosDosProdutos();
        }

    }
}
