using MeetUp.SOLID.ISP.Violacao;
using MeetUp.SOLID.LSP.Violacao;
using MeetUp.SOLID.LSP.Violacao.Contas;
using System;
using System.Collections.Generic;

namespace MeetUp.SOLID
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - LSP - Processador Investimentos");
            Console.WriteLine("2 - LSP - Quadrado");
            Console.WriteLine("3 - ISP - CSharp");
            
            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    ProcessadorInvestimentos.Processar(new List<ContaComum> { new ContaEstudante()});
                    break;
                case '2':
                    CalculoArea.Calcular();
                    break;
                case '3':
                    CSharp.AdicionarLista();
                    break;
            }
        }
    }
}