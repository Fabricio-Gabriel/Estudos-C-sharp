namespace Alura.Filmes;

class Artista
{
    public string Nome { get; }
    public int Idade { get; }

    public List<Filme> filmesDoArtista = [];

    public Artista(string Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }

    public void AdicionarFilmesDoArtista(Filme filme)
    {
        filmesDoArtista.Add(filme);
    }

    public void MostraFilmesDoArtista()
    {
        Console.WriteLine($"Lista de filmes do artista {this.Nome}: \n");
        foreach (Filme filme in filmesDoArtista)
        {
            Console.WriteLine(filme.DetalhesDoFilme);
        }
    }
}