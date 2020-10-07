using MVC_exercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_exercicio1.Services
{
    public class ProductService : IProductService
    {
        public Produto ProdutoMaisCaro()
        {
            Produto result;
            using (Context bd = new Context())
            {
                decimal maxPrice = bd.Products.Select(p => p.Price).Max();
                result = (from p in bd.Products
                    where p.Price == maxPrice
                    select p).FirstOrDefault();
            }
            return result;
        }

        public Produto ProdutoMaisBarato()
        {
            Produto result;
            using (Context bd = new Context())
            {
                decimal minPrice= bd.Products.Select(p => p.Price).Min();
                result = (from p in bd.Products
                    where p.Price==minPrice
                         select p).FirstOrDefault();
            }
            return result;
        }

        public string MediaDePrecosDosProdutos()
        {
            decimal result;
            using (Context bd = new Context())
            {
                result = bd.Products.Average(p=>p.Price);
            }
            return $"The average price of the products is {result}";
        }

        public IEnumerable<Produto> ListagemDeProdutos()
        {
            List<Produto> result=new List<Produto>();
            using (Context bd = new Context()) { 
                foreach (Produto p in bd.Products)
                {
                    result.Add(p);
                }

            }

            return result;
        }
    }
}
