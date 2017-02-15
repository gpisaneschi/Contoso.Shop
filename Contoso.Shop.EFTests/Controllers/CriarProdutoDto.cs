﻿using System.ComponentModel.DataAnnotations;

namespace Contoso.Shop.EFTests.Controllers
{
    public class CriarProdutoDto
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Nome { get; set; }
        [Required, Range(0,100000)]
        public decimal Preco { get; set; }
    }
}