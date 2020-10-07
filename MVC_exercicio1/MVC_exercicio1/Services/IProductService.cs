using System.Collections.Generic;
using MVC_exercicio1.Models;

namespace MVC_exercicio1.Services
{
    public interface IProductService
    {
        Produto ProdutoMaisCaro();
        Produto ProdutoMaisBarato();
        string MediaDePrecosDosProdutos();
        IEnumerable<Produto> ListagemDeProdutos();
    }
}