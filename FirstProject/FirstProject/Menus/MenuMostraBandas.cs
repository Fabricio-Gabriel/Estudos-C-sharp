using FirstProject.Modelos;

namespace FirstProject.Menus;

internal class MenuMostraBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo bandas registradas");
        Console.WriteLine("As bandas digitadas foram respectivamente: \n");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }


        Thread.Sleep(5000);
        Console.WriteLine();
        Console.WriteLine("Digite qualquer tecla para voltar ao menu!");
        Console.ReadKey();

        Console.Clear();
    }
}

