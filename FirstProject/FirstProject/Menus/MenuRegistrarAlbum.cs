using FirstProject.Modelos;

namespace FirstProject.Menus;

internal class MenuRegistrarAlbum : Menu
{

    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.WriteLine("Digite a banda cujo álbum deseja registrar: ");

        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.WriteLine("Agora digite o titulo do álbum: ");
            string tituloDoAlbum = Console.ReadLine()!;

            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloDoAlbum));

            Console.WriteLine($"O álbum {tituloDoAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.\n");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
    }

}

