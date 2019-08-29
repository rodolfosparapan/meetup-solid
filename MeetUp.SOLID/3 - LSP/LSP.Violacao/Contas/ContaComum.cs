using System;

namespace MeetUp.SOLID.LSP.Violacao.Contas
{
    public class ContaComum
    {
        public double Saldo { get; private set; }

        public ContaComum()
        {
            this.Saldo = 0;
        }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void SomarInvestimentos()
        {
            this.Saldo += this.Saldo * 0.01;
        }

        public void Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
