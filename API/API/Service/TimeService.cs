using API.Interfaces;
using System.Collections.Generic;

namespace API.Service
{
    public class TimeService : ITimeService
    {
        private readonly ITimeRepository timeRepository;

        public TimeService(ITimeRepository tr)
        {
            timeRepository = tr;
        }

        public Time AtualizaTime(Time time)
        {
            throw new System.NotImplementedException();
        }

        public Time BuscaTime(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool DeletaTime(int id)
        {
            throw new System.NotImplementedException();
        }

        public void InsereTime(int id, string nome, string conferencia)
        {
            Time novoTime = new Time(id, nome, conferencia);
            timeRepository.InsereTime(novoTime);
        }

        public List<Time> RetornaTimes()
        {
            throw new System.NotImplementedException();
        }

        //    public List<Time> RetornaTimes() {

        //        List<Time> times = new List<Time>() {
        //        new Time(1, "Heat", "Leste"),
        //        new Time(2, "Celtics", "Leste")
        //    };
        //        return times;
        //    }

        //    public Time BuscaTime(int id) {
        //        var times = RetornaTimes();

        //        foreach (var time in times)
        //        {
        //            if (time.Id == id)
        //            {
        //                return time;
        //            }
        //        }
        //        return null;
        //    }

        //    public void InsereTime(Time time) {
        //        var times = RetornaTimes();

        //        if (time != null)
        //        {
        //            times.Add(time);
        //        }
        //    }

        //    public bool DeletaTime(int id)
        //    {
        //        var times = RetornaTimes();

        //        var time = BuscaTime(id);

        //        if (time != null) {
        //            times.Remove(time);
        //            return true;
        //        }

        //        return false;
        //    }

        //    public Time AtualizaTime(Time time)
        //    {
        //        var times = RetornaTimes();

        //        foreach (var i in times)
        //        {
        //            if (i.Id == time.Id)
        //            {
        //                i.Nome = time.Nome;
        //                i.Conferencia = time.Conferencia;
        //                return time;
        //            }
        //        }
        //        return null;
        //    }
        //}
    }
