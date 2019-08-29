using MeetUp.SOLID.OCP.Violacao;

namespace MeetUp.SOLID.OCP.Solucao.Interfaces
{
    public interface ITipoCalculoService
    {
        void CalcularComponentes(Manipulacao manipulacao);
        void CalcularPreco(Manipulacao manipulacao);
        void CalcularValidade(Manipulacao manipulacao);
    }
}