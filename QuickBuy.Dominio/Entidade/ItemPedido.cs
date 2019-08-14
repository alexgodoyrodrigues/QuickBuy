using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidade 
{
    public class ItemPedido : Entidade
    {
        public static bool Any { get; internal set; }
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
            {
                AdicionarCritica("Informe o produto do pedido");
            }

            if (Quantidade == 0)
            {
                AdicionarCritica("Quantidade não informada");
            }
        }
    }
}
