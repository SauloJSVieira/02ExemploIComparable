using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ExemploIComparable.Entities
{
    internal class Funcionario : IComparable
    {

        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(string csvFuncionario)
        {
            string[] vetor = csvFuncionario.Split(',');
            Nome = vetor[0];
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Nome + ", " + Salario.ToString("f2", CultureInfo.InvariantCulture);
        }
        
        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new NotImplementedException("\nErro na comparação!\nO argumento não é do tipo Funcionário.");
            }

            Funcionario outroFuncionario = obj as Funcionario;

            return Salario.CompareTo(outroFuncionario.Salario);
        }
    }    
}
