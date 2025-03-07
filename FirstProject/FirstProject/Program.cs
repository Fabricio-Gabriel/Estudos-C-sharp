using FirstProject.Modelos;
using FirstProject.Menus;

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

void ExibeMenu()
{
    Console.WriteLine("Digite 1 registrar uma banda");
    Console.WriteLine("Digite 2 para registrar um álbum");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            MenuRegistrarBanda menuRegistrarBanda = new MenuRegistrarBanda();
            menuRegistrarBanda.ExibirTituloDaOpcao("Registre uma banda");
            menuRegistrarBanda.Executar(bandasRegistradas);
            ExibeLogo();
            ExibeMenu();
            break;
        case 2:
            MenuRegistrarAlbum menuRegistraAlbum = new MenuRegistrarAlbum();
            menuRegistraAlbum.ExibirTituloDaOpcao("Selecione um albúm a ser registrado");
            menuRegistraAlbum.Executar(bandasRegistradas);
            ExibeLogo();
            ExibeMenu();
            break;
        case 3:
            MenuMostraBandas menuMostraBanda = new MenuMostraBandas();
            menuMostraBanda.ExibirTituloDaOpcao("Escreva uma banda para ser mostrada");
            menuMostraBanda.Executar(bandasRegistradas, listaDasBandas);
            ExibeLogo();
            ExibeMenu();
            break;
        case 4:
            MenuAvaliarBanda menuAvaliaBanda = new MenuAvaliarBanda();
            menuAvaliaBanda.ExibirTituloDaOpcao("Avalie uma banda");
            menuAvaliaBanda.Executar(bandasRegistradas);
            ExibeLogo();
            ExibeMenu();
            break;
        case 5:
            MenuExibirDetalhes menu = new MenuExibirDetalhes();
            menu.ExibirTituloDaOpcao("Detalhes da banda escolhida");
            menu.Executar(bandasRegistradas);
            ExibeLogo();
            ExibeMenu();
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






