using MeetUp.SOLID.OCP.Solucao.Interfaces;
using MeetUp.SOLID.OCP.Violacao;
using System;

namespace MeetUp.SOLID.OCP.Solucao
{
    public static class TipoCalculoServiceFactory
    {
        public static ITipoCalculoService Obter(TipoCalculo tipoCalculo)
        {
            switch (tipoCalculo)
            {
                case TipoCalculo.Capsula:
                    return new CapsulaService(new Preco(), new Validade());

                case TipoCalculo.Creme:
                    return new CremeService(new Preco(), new Validade());

                case TipoCalculo.Homeopatia:
                    return new HomeopatiaService(new PrecoHomeopatia(), new Validade());

                default:
                    throw new ArgumentException("Tipo de calculo nao encontrado");
            }
        }
    }
}