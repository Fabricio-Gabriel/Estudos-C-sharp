class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    public string DescricaoResumida 
        => $"A música {this.Nome} pertence à banda {this.Artista}";


    public void ExibeFichaTecnica()
    {
        Console.WriteLine();
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Artista: {this.Artista}");
        Console.WriteLine($"Duração: {this.Duracao}");

        if (this.Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    //public void setDisponivel(bool value)
    //{
    //    this.disponivel = value;
    //}

    //public bool getDisponivel()
    //{
    //    return this.disponivel;
    //}

}