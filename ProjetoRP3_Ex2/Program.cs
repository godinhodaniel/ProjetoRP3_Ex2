using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace readwriteapp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter wr = new StreamWriter(@"D:\doc.txt", true);

            string input;
            do
            {
                Console.Write("Digite uma linha (ou 'sair' para finalizar): ");
                input = Console.ReadLine();

                if (input.ToLower() != "sair")
                {
                    wr.WriteLine(input);
                }

            } while (input.ToLower() != "sair");

            //StreamWriter.
            wr.Close();

            //leitura.
            StreamReader rd = new StreamReader(@"D:\doc.txt");
            Console.WriteLine("\nConteúdo do arquivo:");

            //exibe cada linha do arquivo.
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
            }

            //StreamReader.
            rd.Close();
            Console.Write("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}
