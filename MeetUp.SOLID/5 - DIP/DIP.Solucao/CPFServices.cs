using MeetUp.SOLID.DIP.Solucao.Interfaces;

namespace MeetUp.SOLID.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}