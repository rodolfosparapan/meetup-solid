using System.Collections.Generic;

namespace MeetUp.SOLID.LSP.Violacao.Contas
{
    public class ProcessadorInvestimentos
    {
        public static void Processar(List<ContaComum> contas)
        {
            foreach (var conta in contas)
            {
                conta.SomarInvestimentos();
            }
        }
    }
}