using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ajuda Professor");

            Aluno aluno = new Aluno("Davi");

            Professor professor = new Professor("João", 10000);

            Materia materia = new Materia("Laboratório de programação", professor);

            aluno.Materia = materia;

            Avaliacao nota1 = new Avaliacao("Avaliação Parcial", 5);
            Avaliacao nota2 = new Avaliacao("Avaliação Final", 10);

            materia.Avaliacoes.Add(nota1);
            materia.Avaliacoes.Add(nota2);

            String mensagem = aluno.avaliarMedia;


            Console.ReadKey();
        }
    }
}
