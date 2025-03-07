namespace FirstProject.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int tamanho = titulo.Length;
        string asteriscos = "".PadLeft(tamanho, '#');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

}

