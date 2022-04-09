using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    internal class Materia
    {
        private String nome;
        private List<Avaliacao>avaliacoes;

        public Materia(string nome, Professor professor)
        {
            this.Nome = nome;
            Avaliacoes = new List<Avaliacao>();
        }

        public string Nome { get => nome; set => nome = value; }
        public List<Avaliacao> Avaliacoes { get => avaliacoes; set => avaliacoes = value; }

        public void adicionaAvaliacao(Avaliacao nova) {
            Avaliacoes.Add(nova);
        }
        
    }
}
