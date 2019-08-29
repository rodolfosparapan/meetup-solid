using MeetUp.SOLID.DIP.Violacao;
using System.Collections.Generic;

namespace MeetUp.SOLID.DIP.Solucao
{
    public class NotaFiscalService
    {
        private readonly List<IAcaoAposGerarNota> acoesAposGerarNota;

        public NotaFiscalService(List<IAcaoAposGerarNota> acoesAposGerarNota)
        {
            this.acoesAposGerarNota = acoesAposGerarNota;
        }

        public NotaFiscal Gerar(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal notaFiscal = new NotaFiscal(valor);

            foreach (var acao in acoesAposGerarNota)
            {
                acao.Executar();
            }

            return notaFiscal;
        }
    }
}
