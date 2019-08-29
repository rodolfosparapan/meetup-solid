namespace MeetUp.SOLID.DIP.Violacao
{
    public class NotaFiscal
    {
        private double valor;
        private double v;

        public NotaFiscal(double valor)
        {
            this.valor = valor;
        }

        public NotaFiscal(double valor, double v)
        {
            this.valor = valor;
            this.v = v;
        }
    }
}