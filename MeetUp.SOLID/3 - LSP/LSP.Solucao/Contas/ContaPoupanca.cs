namespace EP.SOLID.LSP.Solucao.Contas
{
    public class ContaPoupanca : ContaInvestimento
    {
        public void CalcularInvestimento()
        {
            this.Saldo += this.Saldo * 0.000001;
        }
    }
}