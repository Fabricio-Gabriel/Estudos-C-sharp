class Album
{
    private List<Musica> musicas = [];
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {this.Nome}: \n");
        musicas.ForEach(musica => Console.WriteLine($"Música: {musica.Nome}"));
        Console.WriteLine($"Este álbum possui {this.DuracaoTotal} segundos de duração.");
    }
}