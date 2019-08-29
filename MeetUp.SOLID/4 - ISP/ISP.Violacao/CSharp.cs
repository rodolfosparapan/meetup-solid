using System;
using System.Collections.Generic;

namespace MeetUp.SOLID.ISP.Violacao
{
    public class CSharp
    {
        public static void AdicionarLista()
        {
            //Array
            string[] nomes = { "Rodolfo" };
            
            Adicionar(nomes, "Silvio Santos");
        }

        private static void Adicionar(IList<string> nomes, string nome)
        {
            nomes.Add(nome);
        }
    }
}