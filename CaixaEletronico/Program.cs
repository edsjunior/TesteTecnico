using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int vlr_Saque = 0;
            int qtd_nota100 = 0;
            int qtd_nota50 = 0;
            int qtd_nota20 = 0;
            int qtd_nota10 = 0;

            Console.Write("Valor do saque: ");
            vlr_Saque = Convert.ToInt32(Console.ReadLine());

            if (vlr_Saque > 0)
            {
                while (vlr_Saque >= 100)
                {
                    vlr_Saque -= 100;
                    qtd_nota100++;
                }
                while (vlr_Saque >= 50)
                {
                    vlr_Saque -= 50;
                    qtd_nota50++;
                }
                while (vlr_Saque >= 20)
                {
                    vlr_Saque -= 20;
                    qtd_nota20++;
                }
                while (vlr_Saque >= 10)
                {
                    vlr_Saque -= 10;
                    qtd_nota10++;
                }
            }
            Console.WriteLine("Notas de 100: " + qtd_nota100 + ".");
            Console.WriteLine("Notas de 50: " + qtd_nota50 + ".");
            Console.WriteLine("Notas de 20: " + qtd_nota20 + ".");
            Console.WriteLine("Notas de 10: " + qtd_nota10 + ".");
            Console.ReadKey();

        }
    }
}
