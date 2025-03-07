using FirstProject.Modelos;

namespace FirstProject.Menus;

internal class MenuRegistrarBanda : Menu
{

    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de Bandas");
        Console.Write("Digite o nome da banda que deseja registar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeBanda);
        bandasRegistradas.Add(nomeBanda, banda);
        Console.WriteLine($"A banda {nomeBanda} foi registrada!");
        Thread.Sleep(2000);
        Console.Clear();
    }


}

