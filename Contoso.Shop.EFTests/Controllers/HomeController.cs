using Contoso.Shop.EFTests.Services;
using Contoso.Shop.EFTests.Shop;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Shop.EFTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoService produtoService;

        public HomeController(IProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }

        public IActionResult Index()
        {
            //SELECT * FROM Produtos
            //var produtos = shopContext.Produtos.ToList();
            var produtos = produtoService.ObterTodos();
            return Ok(produtos);
        }

        [HttpPost]
        public IActionResult Create(CriarProdutoDto dto)
        {
            if(dto== null)
            {
                throw new ArgumentNullException(nameof(dto));
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var produto = produtoService.Criar(dto);

            return Ok(produto);
        }
    }

}
