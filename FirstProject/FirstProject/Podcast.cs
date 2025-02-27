//class Podcast
//{
//    public string Host { get; }
//    public string Nome { get; }

//    private List<Episodio> TotalEpisodios = [];

//    public Podcast(string host, string nome)
//    {
//        this.Host = host;
//        this.Nome = nome;
//    }

//    public void AdicionarEpisodio(Episodio episodio)
//    {
//        TotalEpisodios.Add(episodio);
//    }

//    public void ExibirDetalhes()
//    {
//        Console.WriteLine($"{this.Nome}: {this.Host}\n");
//        for(int i = 0; i <  TotalEpisodios.Count; i++)
//        {
//            Console.WriteLine($"{i + 1} Episódio: {TotalEpisodios[i].Resumo}");
//        }
//        Console.WriteLine($"\nTotal de episódios do Podcast: {TotalEpisodios.Count}");

//    }

//}