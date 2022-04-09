using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    public class Professor
    {
        String nome;
        double salario;

        public Professor(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }

        public string toString()
        {
            return "Professor: " + this.nome + " | Salário: " + this.salario;
        }

    }
}
