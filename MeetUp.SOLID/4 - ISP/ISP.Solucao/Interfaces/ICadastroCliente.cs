﻿namespace MeetUp.SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}