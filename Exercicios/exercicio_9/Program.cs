using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionarios = int.Parse(Console.ReadLine());
            Funcionario funcionarios = new Funcionario();

            for (int i = 0; i <= numFuncionarios; i++)
            {
               
                funcionarios.nome = Console.ReadLine();
                funcionarios.cpf = Console.ReadLine();
                funcionarios.dataNascimento = DateTime.Parse(Console.ReadLine());
                funcionarios.salario = double.Parse(Console.ReadLine());
                funcionarios.dataAdmissao = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
                                                
                double salarioNovo = funcionarios.salario + funcionarios.Aumento();
                Console.WriteLine("Nome: " + funcionarios.nome);
                Console.WriteLine("CPF: " + funcionarios.cpf);
                Console.WriteLine("Nasc: " + funcionarios.dataNascimento.Date.ToString());
                Console.WriteLine("Admis: " + funcionarios.dataAdmissao.Date.ToString());
                Console.WriteLine("Salário Atual: " + funcionarios.salario);
                Console.WriteLine("Novo Salário: " + salarioNovo);
            }
        }
    }      
}
 
