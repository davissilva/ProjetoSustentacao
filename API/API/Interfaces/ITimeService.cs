using System.Collections.Generic;

namespace API.Interfaces
{
    public interface ITimeService
    {
        public List<Time> RetornaTimes();
        public Time BuscaTime(int id);
        public void InsereTime(int id, string nome, string conferencia);
        public bool DeletaTime(int id);
        public Time AtualizaTime(Time time);
    }
}
