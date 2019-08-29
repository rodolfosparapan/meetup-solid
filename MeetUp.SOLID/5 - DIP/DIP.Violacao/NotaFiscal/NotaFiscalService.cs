namespace MeetUp.SOLID.DIP.Violacao
{
    public class NotaFiscalService
    {
        public NotaFiscal Gerar(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal notaFiscal = new NotaFiscal(valor);

            new EmailService().Enviar(notaFiscal);
            new NotaFiscalRepository().Salvar(notaFiscal);

            return notaFiscal;
        }
    }
}