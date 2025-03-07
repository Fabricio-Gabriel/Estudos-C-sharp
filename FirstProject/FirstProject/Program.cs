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

Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostraBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());


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
    int opcaoEscolha = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolha))
    {
        Menu menuASerExibido = opcoes[opcaoEscolha];
        menuASerExibido.Executar(bandasRegistradas);
        if(opcaoEscolha > 0)
        {
            ExibeLogo();
            ExibeMenu();
        }

    } else
    {
        Console.WriteLine("Opção Inválida.");
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






