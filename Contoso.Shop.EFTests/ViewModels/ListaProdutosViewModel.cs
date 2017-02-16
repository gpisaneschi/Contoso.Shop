using Contoso.Shop.EFTests.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Shop.EFTests.ViewModels
{
    public class ListaProdutosViewModel
    {
        public ListaProdutosViewModel()
        {
            Produtos = Array.Empty<Produto>();
        }

        public string TermoPesquisa { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
