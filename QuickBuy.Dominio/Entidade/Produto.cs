namespace QuickBuy.Dominio.Entidade
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome não foi informado");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Descrição não foi informado");
            }

            if (Preco == 0)
            {
                AdicionarCritica("Preço não foi informado");
            }
        }
    }
}
