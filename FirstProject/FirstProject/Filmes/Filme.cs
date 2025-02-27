namespace Alura.Filmes;

class Filme
{
    public string Titulo { get; }
    public int Duracao { get; }

    public List<Artista> elenco = [];

    public string DetalhesDoFilme => $"Filme: {this.Titulo} / Duração: {this.Duracao}";

    public Filme(string titulo, int duracao)
    {
        this.Titulo = titulo;
        this.Duracao = duracao;
    }

    public void AdicionaArtista(Artista artista)
    {
        elenco.Add(artista);
    }

    public void MostraElenco()
    {
        Console.WriteLine($"\nLista de artistas do elenco de {this.Titulo}: ");
        foreach (Artista artista in elenco)
        {
            Console.WriteLine($"- {artista.Nome}");
        }
    }
}