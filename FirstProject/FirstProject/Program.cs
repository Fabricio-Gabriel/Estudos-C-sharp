using FirstProject.Modelos;

Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));

Banda beatles = new Banda("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);


string msgBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

void ExibeLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(msgBoasVindas + "\n");
}

void ExibirTituloDaOpcao(string titulo)
{
    int tamanho = titulo.Length;
    string asteriscos = "".PadLeft(tamanho, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void MostraMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Dê uma média a sua banda favorita!");
    Console.Write("\nDigite o nome da banda que deseja ver a média de notas: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Banda banda = bandasRegistradas[nomeBanda];

        double media = banda.Media;

        Thread.Sleep(2000);
        Console.WriteLine($"\nA média de notas da banda {nomeBanda} foi de {media}\n");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibeLogo();
        ExibeMenu();

    }
    else
    {
        Thread.Sleep(2000);
        Console.WriteLine($"A banda {nomeBanda} não existe, aperte qualquer tecla e volte ao menu.");
        Console.ReadKey();
        ExibeLogo();
        ExibeMenu();
    }

}

void RegistrarBandas()
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
    ExibeLogo();
    ExibeMenu();
}

void RegistrarAlbum()
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
        ExibeLogo();
    }

    ExibeMenu();
}

void MostraBandas()
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

    ExibeLogo();
    ExibeMenu();
}

void AvaliaBanda()
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
        ExibeLogo();
        ExibeMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.\n");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibeLogo();
        ExibeMenu();
    }
}

void ExibeDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.WriteLine("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}");

        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibeLogo();
        ExibeMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu príncipal");
        Console.ReadKey();
        Console.Clear();
        ExibeLogo();
        ExibeMenu();
    }


}

void ExibeMenu()
{
    Console.WriteLine("Digite 1 registrar uma banda");
    Console.WriteLine("Digite 2 para registrar um álbum");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine())!;

    switch (opcao)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostraBandas();
            break;
        case 4:
            AvaliaBanda();
            break;
        case 5:
            ExibeDetalhes();
            break;
        case -1:
            Console.WriteLine("Tchau Tchau ;)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}


ExibeLogo();
ExibeMenu();



//Musica musica1 = new Musica();
//Musica musica2 = new Musica();

//musica1.Nome = "Roxane";
//musica1.Artista = "The police";
//musica1.Duracao = 273;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.DescricaoResumida);

//musica2.Nome = "Vertigo";
//musica2.Artista = "U2";
//musica2.Duracao = 367;
//musica2.Disponivel = false;
//Console.WriteLine(musica2.DescricaoResumida);

//musica1.ExibeFichaTecnica();
//musica2.ExibeFichaTecnica();

//albumQueen.AdicionarMusica(musica1);
//albumQueen.AdicionarMusica(musica2);

//musica1.ExibeFichaTecnica();
//musica2.ExibeFichaTecnica();
//albumQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

//using Alura.Filmes;

//Filme mazeRunner = new Filme("Maze Runner", 120);
//Filme amorEmonstros = new Filme("Amor e Monstros", 120);

//Artista dylanObrien = new Artista("Dylan O'Brien", 29);

//dylanObrien.AdicionarFilmesDoArtista(mazeRunner);
//dylanObrien.AdicionarFilmesDoArtista(amorEmonstros);

//dylanObrien.MostraFilmesDoArtista();

//mazeRunner.AdicionaArtista(dylanObrien);
//amorEmonstros.AdicionaArtista(dylanObrien);






