namespace EP.SOLID.LSP.Solucao.Contas
{
    public class ContaInvestimento
    {
        public double Saldo { get; protected set; }

        void SomarInvestimentos()
        {
            this.Saldo += this.Saldo * 0.01;
        }
    }
}