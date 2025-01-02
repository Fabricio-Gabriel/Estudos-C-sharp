class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibeFicha()
    {
        Console.WriteLine($"Nome da música: {this.nome}");
        Console.WriteLine($"Nome do artista: {this.artista}");
        Console.WriteLine($"Duração: {this.duracao}");

        if (disponivel)
        {
            Console.WriteLine("A música está disponivel no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano premium \n");
        }
    }

    public void MostraNome()
    {
        Console.WriteLine($"Nome da música: {this.nome}");
        Console.WriteLine($"Nome do Artista: {this.artista}");
    }
}