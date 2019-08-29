using System;

namespace MeetUp.SOLID.LSP.Violacao.Contas
{
    public class ContaEstudante : ContaComum
    {
        public override void SomarInvestimentos()
        {
            throw new Exception("Conta de estudante não rende");
        }
    }
}