namespace API
{
    public class Time
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Conferencia { get; set; }

        public Time(int id, string nome, string conferencia)
        {
            Id = id;
            Nome = nome;
            Conferencia = conferencia;
        }
    }
}
