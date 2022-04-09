using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    internal class Avaliacao
    {
        String nome;
        double nota;

        public Avaliacao() { 
        }

        public Avaliacao(string nome, double nota)
        {
            this.Nome = nome;
            this.Nota = nota;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Nota { get => nota; set => nota = value; }
        public string toString() {
            return "Avaliação: " + this.nome + " | Nota: " + this.nota; 
        }
    }
}
