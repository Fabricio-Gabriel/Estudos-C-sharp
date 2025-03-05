
using FirstProject.Modelos;

namespace FirstProject.Menus;

internal class MenuAvaliarBanda : Menu
{

    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite a banda que quer avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeBanda}\n");
            Thread.Sleep(4000);
            Console.Clear();
            
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.\n");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
   
        }
    }

}

