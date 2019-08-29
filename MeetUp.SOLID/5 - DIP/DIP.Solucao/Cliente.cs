using System;
using MeetUp.SOLID.DIP.Solucao.Interfaces;

namespace MeetUp.SOLID.DIP.Solucao
{
    public class Cliente
    {
        private readonly ICPFServices cpfServices;
        private readonly IEmailServices emailServices;

        public Cliente(ICPFServices cpfServices, IEmailServices emailServices)
        {
            this.cpfServices = cpfServices;
            this.emailServices = emailServices;
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return emailServices.IsValid(Email) && cpfServices.IsValid(CPF);
        }
    }
}