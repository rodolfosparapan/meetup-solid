using MeetUp.SOLID.OCP.Solucao.Interfaces;
using MeetUp.SOLID.OCP.Violacao;

namespace MeetUp.SOLID.OCP.Solucao
{
    public class HomeopatiaService : ITipoCalculoService
    {
        private readonly IPrecoHomeopatia precoHomeopatia;
        private readonly IValidade validade;

        public HomeopatiaService(IPrecoHomeopatia precoHomeopatia, IValidade validade)
        {
            this.precoHomeopatia = precoHomeopatia;
            this.validade = validade;
        }

        public void CalcularComponentes(Manipulacao manipulacao)
        {
            // Regra
        }

        public void CalcularPreco(Manipulacao manipulacao)
        {
            precoHomeopatia.Calcular(manipulacao);
        }

        public void CalcularValidade(Manipulacao manipulacao)
        {
            validade.Calcular(manipulacao);
        }
    }
}
