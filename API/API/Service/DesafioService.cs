using API.Interfaces;
using System;
using System.Collections.Generic;


namespace API.Service
{
    public class DesafioService : IDesafio
    {
        public double calcularIMC(double altura, double peso)
        {
            return peso / Math.Pow(altura, 2);
        }

        public List<int> ordenarLista(List<int> lista)
        {
            return lista;
        }

        public char retornaUltimoCaractere(string nome)
        {
            return nome[nome.Length - 1];
        }
    }
}
