using _02ExemploIComparable.Entities;

namespace _02ExemploIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoOrigem = @"c:\tmp\entradaDados.csv";

            try
            {
                using (StreamReader leitor = File.OpenText(caminhoOrigem))
                {
                    List<Funcionario> lista = new List<Funcionario>();

                    while (!leitor.EndOfStream)
                    {
                        lista.Add(new Funcionario(leitor.ReadLine()));
                    }

                    lista.Sort();

                    foreach (var item in lista)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nOcurreu um erro!\n" + e.Message);
            }
        }
    }
}