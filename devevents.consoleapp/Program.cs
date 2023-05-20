// POO - Programação Orientada a Objetos

var evento = new Evento(1, "Jornada .NET", "Um Evento Incrível", DateTime.Now, DateTime.Now.AddDays(7), "LuisDev");
var show = new Show("Pedro Grachet", "Rock, Trap", 2, "Show Jornada .NET", "Um Evento Incrível", DateTime.Now, DateTime.Now.AddDays(7), "LuisDev");

Console.WriteLine(evento.GerarResumo());
Console.WriteLine(show.GerarResumo());

var eventos = new List<Evento> { evento, show };

foreach (var item in eventos)
{
    Console.WriteLine(item.GerarResumo());
}

public class Evento
{
    public Evento(int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, string organizador)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        DataInicio = dataInicio;
        DataFim = dataFim;
        Organizador = organizador;
    }

    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Organizador { get; set; }

    public virtual string GerarResumo()
    {
        return $"Evento {Titulo}, {DataInicio}, {DataFim}, Organizador: {Organizador}";
    }
}

public class Show : Evento
{
    public Show(string artista, string tracklist, int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, string organizador) : base(id, titulo, descricao, dataInicio, dataFim, organizador)
    {
        Artista = artista;
        TrackList = tracklist;
    }
    public string Artista { get; set; }
    public string TrackList { get; private set; }

    public override string GerarResumo()
    {
        var resumoBase = base.GerarResumo();
        return $"{resumoBase}, {Artista}, {TrackList}";
    }
}
