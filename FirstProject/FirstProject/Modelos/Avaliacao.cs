namespace FirstProject.Modelos;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        this.Nota = nota;
    }

    public static Avaliacao Parse(string text)
    {
        int nota = int.Parse(text);
        return new Avaliacao(nota);
    }
}
