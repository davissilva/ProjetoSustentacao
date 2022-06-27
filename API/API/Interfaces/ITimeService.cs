using System.Collections.Generic;

namespace API.Interfaces
{
    public interface ITimeService
    {
        public List<Time> RetornaTimes();
        public Time BuscaTime(int id);
        public void InsereTime(Time time);
        public bool DeletaTime(int id);
        public Time AtualizaTime(Time time);
    }
}
