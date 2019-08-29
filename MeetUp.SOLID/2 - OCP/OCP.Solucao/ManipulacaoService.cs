using MeetUp.SOLID.OCP.Solucao.Interfaces;
using MeetUp.SOLID.OCP.Violacao;

namespace MeetUp.SOLID.OCP.Solucao
{
    public class ManipulacaoService
    {
        private readonly ITipoCalculoService tipoCalculoService;
        
        public ManipulacaoService(ITipoCalculoService tipoCalculoService)
        {
            this.tipoCalculoService = tipoCalculoService;
        }

        public Manipulacao Calcular(Manipulacao manipulacao)
        {
            tipoCalculoService.CalcularComponentes(manipulacao);
            tipoCalculoService.CalcularPreco(manipulacao);
            tipoCalculoService.CalcularValidade(manipulacao);

            return manipulacao;
        }
    }
}