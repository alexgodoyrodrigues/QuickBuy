using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBuy.Dominio.Entidade
{
    [Table("Usuario")]
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("E-mail não foi informado");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Senha não foi informada");
            }
        }
    }
}
