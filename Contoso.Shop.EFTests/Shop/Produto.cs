using System;

namespace Contoso.Shop.EFTests.Shop
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTimeOffset CriadoEm { get; set; }
        public DateTimeOffset? AtualizadoEm { get; set; }

    }
}
