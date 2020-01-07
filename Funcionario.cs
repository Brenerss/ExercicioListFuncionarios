using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course {
    class Funcionario {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public void increaseSalary(double porcentage) {
            Salary += Salary * porcentage / 100.0;
        }
                          

        public override string ToString() {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
