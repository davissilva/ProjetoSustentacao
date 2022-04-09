using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    public class Avaliacao
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Avaliacao(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public string toString() {
            return "Avaliação: " + Nome + " | Nota: " + Nota; 
        }
    }
}
