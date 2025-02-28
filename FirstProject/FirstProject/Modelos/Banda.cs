namespace FirstProject.Modelos;

internal class Banda
{
    private List<Album> albums = [];

    private List<Avaliacao> notas = [];

    public double Media { 
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(avaliacao => avaliacao.Nota);
        }
    }
    public string Nome { get; }

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {this.Nome}");
        albums.ForEach(album => Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})"));
    }
}