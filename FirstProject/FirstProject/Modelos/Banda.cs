namespace FirstProject.Modelos;

internal class Banda
{
    private List<Album> albums = [];

    private List<int> notas = [];

    public double Media => notas.Average();
    public string Nome { get; }

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {this.Nome}");
        albums.ForEach(album => Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})"));
    }
}