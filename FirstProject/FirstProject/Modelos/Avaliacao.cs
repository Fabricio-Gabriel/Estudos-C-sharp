namespace FirstProject.Modelos;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        if (nota < 0)
        {
            this.Nota = 0;
        }
        else if (nota > 10)
        {
            this.Nota = 10;
        } else
        {
            this.Nota = nota;
        }
    }

    public static Avaliacao Parse(string text)
    {
        int nota = int.Parse(text);
        return new Avaliacao(nota);
    }
}
