using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    public class Materia
    {
        public string Nome { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }

        public Materia(string nome, Professor professor)
        {
            Nome = nome;
            Avaliacoes = new List<Avaliacao>();
        }

        public void adicionaAvaliacao(Avaliacao nova) {
            Avaliacoes.Add(nova);
        }
    }
}
