using MeetUp.SOLID.DIP.Solucao.Interfaces;

namespace MeetUp.SOLID.DIP.Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IEmailServices emailServices;

        public ClienteServices(
            IEmailServices emailServices, 
            IClienteRepository clienteRepository)
        {
            this.emailServices = emailServices;
            this.clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            clienteRepository.AdicionarCliente(cliente);

            emailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}