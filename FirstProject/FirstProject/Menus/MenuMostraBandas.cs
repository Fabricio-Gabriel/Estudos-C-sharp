using FirstProject.Modelos;

namespace FirstProject.Menus;

internal class MenuMostraBandas : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas, List<string> listaDasBandas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo bandas registradas");
        Console.WriteLine("As bandas digitadas foram respectivamente: \n");

        for (int i = 0; i < listaDasBandas.Count; i++)
        {
            Console.WriteLine($"Banda n{i + 1}: {listaDasBandas[i]}");
        }

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

