using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opçao = 0;
            int consulta = 0;

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=lp");
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            conn.Open();

            while (opçao != 1 && opçao != 2)
            {
                Console.Write("Cadastro e consulta: Digite 0 para Cadastrar e 1 para Consultar: ");
                opçao = int.Parse(Console.ReadLine());
                Pessoa p = new Pessoa();

                if (opçao == 1)
                {
                    Console.Write("Nome: ");
                    p.Nome = Console.ReadLine();
                    Console.Write("Sobrenome: ");
                    p.Sobrenome = Console.ReadLine();
                    Console.Write("Peso: ");
                    p.Peso = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    p.Altura = double.Parse(Console.ReadLine());
                    Console.Write("Telefone: ");
                    p.Telefone = Console.ReadLine();

                    Console.WriteLine("Cadastro confirmado!!!");
                    string j = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(nome,sobrenome,peso,altura,telefone) VALUES('{0}','{1}',{2},{3},'{4}')", p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone);
                    command.CommandText = j;
                    command.ExecuteNonQuery();
                    opçao = 0;
                }
                else if (opçao == 2)
                {
                    int opcaoDeconsulta = 0;
                    string consultap;

                    string v = String.Format("SELECT * from pessoa");
                    command.CommandText = v;
                    MySqlDataReader reader = command.ExecuteReader();

                    while (opcaoDeconsulta != 1 && opcaoDeconsulta != 2)
                    {
                        Console.Write("Digite 0 para consultar por nome ou 1 para consultar por id: ");
                        opcaoDeconsulta = int.Parse(Console.ReadLine());

                        if (opcaoDeconsulta == 1)
                        {
                            Console.Write("Digite o nome para consultar: ");
                            consultap = Console.ReadLine();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetString(1) == consultap)
                                    {
                                        Console.WriteLine("ID: {0}, Nome: {1}, Sobrenome: {2}",
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2));
                                        consultain++;

                                    }
                                }
                                if (consultain == 0)
                                {
                                    Console.WriteLine("Não há registro com o nome informado.");
                                }
                            }
                        }
                        else if (opcaoDeconsulta == 2)
                        {
                            Console.Write("Digite o id para consultar: ");
                            consultap = Console.ReadLine();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader.GetInt32(0) == Convert.ToInt32(consultap))
                                    {
                                        Console.WriteLine("ID: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5}",
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2),
                                        reader.GetDouble(3),
                                        reader.GetDouble(4),
                                        reader.GetString(5));
                                        consultain++;
                                    }
                                }
                                if (consultain == 0)
                                {
                                    Console.WriteLine("Não há registro com o id informado.");
                                }
                            }
                        }

                        else
                        {
                            Console.WriteLine("Insira um número válido. 0 para consultar pelo nome ou 1 para consulta por id.");
                        }
                    }
                    reader.Close();
                    opçao = 0;
                }

                else
                {
                    Console.WriteLine("Insira um número válido. 0 para cadastrar ou 1 para consultar!");
                }
                consulta = 0;
            }

            Console.ReadKey();
        }

        public static int opçao { get; set; }

        public static int consultain { get; set; }
    }
}
