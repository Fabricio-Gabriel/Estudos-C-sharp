namespace FirstProject.Modelos;

class Banda
{
    private List<Album> albums = [];
    public string Nome { get; }

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {this.Nome}");
        albums.ForEach(album => Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})"));
    }
}