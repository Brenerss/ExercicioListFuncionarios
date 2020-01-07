using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class Program {

        static void Main(string[] args) {

            Console.Write("Quantos Funcionarios vao ser registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Funcionario: #{i}");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Digite o id do funcionario que aumentara o salario: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario search = list.Find(x => x.Id == searchId);
            if (search != null) {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                search.increaseSalary(porcentagem);
            } else {
                Console.WriteLine("Esse Id nao existe.");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionarios");
            foreach(Funcionario obj in list) {
                Console.WriteLine(obj);
            }
        }

        
    }
}


