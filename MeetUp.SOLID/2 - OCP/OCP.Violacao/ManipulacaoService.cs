namespace MeetUp.SOLID.OCP.Violacao
{
    public class ManipulacaoService
    {
        public Manipulacao Calcular(TipoCalculo tipoCalculo, Manipulacao manipulacao)
        {
            if(tipoCalculo == TipoCalculo.Capsula)
            {
                new Capsula().CalcularComponentes(manipulacao);
                new Preco().Calcular(manipulacao);
            }

            if (tipoCalculo == TipoCalculo.Creme)
            {
                new Creme().CalcularComponentes(manipulacao);
                new Preco().Calcular(manipulacao);
            }

            if (tipoCalculo == TipoCalculo.Homeopatia)
            {
                new Homeopatia().CalcularComponentes(manipulacao);
                new PrecoHomeopatia().Calcular(manipulacao);
            }

            new Validade().Calcular(manipulacao);

            return manipulacao;
        }
    }
}