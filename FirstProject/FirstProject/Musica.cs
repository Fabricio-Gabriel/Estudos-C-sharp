class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida { get; set; }

    public void ExibeFicha()
    {
        Console.WriteLine($"Nome da música: {this.Nome}");
        Console.WriteLine($"Nome do artista: {this.Artista}");
        Console.WriteLine($"Duração: {this.Duracao}");

        if (this.Disponivel)
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
        Console.WriteLine($"Nome da música: {this.Nome}");
        Console.WriteLine($"Nome do Artista: {this.Artista}");
    }


    //    public bool getDisponivel()
    //    {
    //        return disponivel;
    //    }

    //    public void setDisponivel( bool valor)
    //    {
    //        this.disponivel = valor;
    //    }
}