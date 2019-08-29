namespace MeetUp.SOLID.ISP.Violacao
{
    public interface ICadastro
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}