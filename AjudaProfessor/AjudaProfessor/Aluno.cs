using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    public class Aluno
    {
        private String nome;
        private Materia materia;
        double media;
        bool aprovado;

        public Aluno(string nome)
        {
            this.Nome = nome;
            this.Aprovado = false;
        }

        public string Nome { get => nome; set => nome = value; }
  
        public double Media { get => media; set => media = value; }

        public bool Aprovado { get => aprovado; set => aprovado = value; }
        internal Materia Materia { get => materia; set => materia = value; }

        private double calcularMedia(List<Avaliacao> avaliacoes)
        {
            double total = 0;
            
            foreach (Avaliacao avaliacao in avaliacoes) {
                total += avaliacao.Nota;
            }

            this.media = total/avaliacoes.Count();

            return Media;
        }
        
        public String avaliarMedia()
        {
            this.media = calcularMedia(this.Materia.Avaliacoes);

            if (media < 4)
            {
                return "Aluno reprovado!";
            }
            if (media >= 4 && media < 6)
            {
                return "Aluno está de recuperação!";
            }
            if (media >= 7 || media >= 6)
            {
                this.aprovado = true;
                return "Parabéns, você passou";
            }
            else
            {
                return "Aluno reprovado!";
            }
        }

    }
}
