class Episodio
{
    public double Duracao { get; }

    public int ordem = 0;
    public string Titulo { get; }
    public List<Convidado> Convidados { get; }
    public string Resumo => $"{this.Titulo}: Duração {this.Duracao / 60} minutos";

    public Episodio(int duracao, string titulo)
    {
        this.Duracao = duracao;
        this.Titulo = titulo;
    }

    public void AdicionarConvidados(Convidado convidado)
    {
        Convidados.Add(convidado);
    }

}