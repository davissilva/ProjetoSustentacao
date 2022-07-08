using System.Collections.Generic;

namespace API.Interfaces
{
    public interface IDesafio
    {
        public double calcularIMC(double altura, double peso);
        public List<int> ordenarLista(List<int> lista);
        public char retornaUltimoCaractere(string nome);
    }
}
