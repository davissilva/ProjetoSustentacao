using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    public class Aluno
    {
        public String Nome { get;  set; }
        public Materia Materia { get; set; }
        public double Media { get; set; }
        public bool Aprovado { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Aprovado = false;
        }

        private double calcularMedia(List<Avaliacao> avaliacoes)
        {
            double total = 0;
            
            foreach (var avaliacao in avaliacoes) {
                total += avaliacao.Nota;
            }

            Media = total/avaliacoes.Count();

            return Media;
        }
        
        public String avaliarMedia()
        {
            Media = calcularMedia(this.Materia.Avaliacoes);

            if (Media < 4)
            {
                return "Aluno reprovado!";
            }
            if (Media >= 4 && Media < 6)
            {
                return "Aluno está de recuperação!";
            }
            if (Media >= 7 || Media >= 6)
            {
                Aprovado = true;
                return "Parabéns, você passou";
            }
            else
            {
                return "Aluno reprovado!";
            }
        }

    }
}
