using MeetUp.SOLID.OCP.Solucao.Interfaces;
using MeetUp.SOLID.OCP.Violacao;

namespace MeetUp.SOLID.OCP.Solucao
{
    public class CremeService : ITipoCalculoService
    {
        private readonly IPreco preco;
        private readonly IValidade validade;

        public CremeService(IPreco preco, IValidade validade)
        {
            this.preco = preco;
            this.validade = validade;
        }

        public void CalcularComponentes(Manipulacao manipulacao)
        {
            // Regra
        }

        public void CalcularPreco(Manipulacao manipulacao)
        {
            preco.Calcular(manipulacao);
        }

        public void CalcularValidade(Manipulacao manipulacao)
        {
            validade.Calcular(manipulacao);
        }
    }
}
