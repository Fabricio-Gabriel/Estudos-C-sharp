//string msgBoasVindas = "Boas vindas ao Screen Sound";
////List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

//Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
//bandasRegistradas.Add("The Beatles", new List<int>());

//void ExibeLogo()
//{
//    Console.WriteLine(@"

//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//");
//    Console.WriteLine(msgBoasVindas + "\n");
//}

//void ExibirTituloDaOpcao(string titulo)
//{
//    int tamanho = titulo.Length;
//    string asteriscos = "".PadLeft(tamanho, '*');
//    Console.WriteLine(asteriscos);
//    Console.WriteLine(titulo);
//    Console.WriteLine(asteriscos + "\n");
//}

//void MostraMedia()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Dê uma média a sua banda favorita!");
//    Console.Write("\nDigite o nome da banda que deseja ver a média de notas: ");
//    string nomeBanda = Console.ReadLine()!;

//    if(bandasRegistradas.ContainsKey(nomeBanda))
//    {
//        double soma = 0;
//        foreach (double nota in bandasRegistradas[nomeBanda])
//        {
//            soma += nota;
//        }

//        double media = soma / bandasRegistradas[nomeBanda].Count;
//        Thread.Sleep(2000);
//        Console.WriteLine($"\nA média de notas da banda {nomeBanda} foi de {media}\n");
//        Console.WriteLine("Digite qualquer tecla para voltar ao menu");
//        Console.ReadKey();
//        Console.Clear();
//        ExibeLogo();
//        ExibeMenu();

//    } else 
//    {
//        Thread.Sleep(2000);
//        Console.WriteLine($"A banda {nomeBanda} não existe, aperte qualquer tecla e volte ao menu.");
//        Console.ReadKey();
//        ExibeLogo();
//        ExibeMenu();
//    }

//}

//void RegistrarBandas()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Registro de Bandas");
//    Console.Write("Digite o nome da banda que deseja registar: ");
//    string nomeBanda = Console.ReadLine()!;
//    bandasRegistradas.Add(nomeBanda, new List<int>());
//    Console.WriteLine($"A banda {nomeBanda} foi registrada!");
//    Thread.Sleep(2000);
//    Console.Clear();
//    ExibeLogo();
//    ExibeMenu();
//}

//void MostraBandas()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Exibindo bandas registradas");
//    Console.WriteLine("As bandas digitadas foram respectivamente: \n");

//    //for (int i = 0; i < listaDasBandas.Count; i++)
//    //{
//    //    Console.WriteLine($"Banda n{i + 1}: {listaDasBandas[i]}");
//    //}

//    foreach (string banda in bandasRegistradas.Keys)
//    {
//        Console.WriteLine($"Banda: {banda}");
//    }


//    Thread.Sleep(5000);
//    Console.WriteLine();
//    Console.WriteLine("Digite qualquer tecla para voltar ao menu!");
//    Console.ReadKey();

//    Console.Clear();

//    ExibeLogo();
//    ExibeMenu();
//}

//void AvaliaBanda()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Avaliar banda");
//    Console.Write("Digite a banda que quer avaliar: ");
//    string nomeBanda = Console.ReadLine()!;

//    if (bandasRegistradas.ContainsKey(nomeBanda))
//    {
//        Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
//        int nota = int.Parse(Console.ReadLine()!);
//        bandasRegistradas[nomeBanda].Add(nota);
//        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}\n");
//        Thread.Sleep(4000);
//        Console.Clear();
//        ExibeLogo();
//        ExibeMenu();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.\n");
//        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
//        Console.ReadKey();
//        Console.Clear();
//        ExibeLogo();
//        ExibeMenu();
//    }
//}

//void ExibeMenu()
//{
//    Console.WriteLine("Digite 1 registrar uma banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para exibir a média de uma banda");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("\nDigite a sua opção: ");
//    int opcao = int.Parse(Console.ReadLine())!;

//    switch (opcao)
//    {
//        case 1:
//            RegistrarBandas();
//            break;
//        case 2:
//            MostraBandas();
//            break;
//        case 3:
//            AvaliaBanda();
//            break;
//        case 4:
//            MostraMedia();
//            break;
//        case -1:
//            Console.WriteLine("Tchau Tchau ;)");
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//}


//ExibeLogo();
//ExibeMenu();

//int VerificaNum(int escolha)
//{
//    if (escolha < 0 || escolha > 100)
//    {
//        Console.WriteLine("Escolha inválida, Tente novamente (0 a 100)");
//        return -1;
//    }
//    else
//    {
//        return escolha;
//    }


//}

//Carro car1 = new Carro();

//car1.velocidade = 0;

//car1.acelerar();
//car1.acelerar();
//car1.acelerar();
//car1.acelerar();

//Console.WriteLine($"A velocidade atual do carro é de {car1.velocidade}km/h");

//car1.frear();
//car1.frear();

//Console.WriteLine($"A velocidade atual do carro é de {car1.velocidade}km/h");

//car1.buzinar();

//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

//numerosPares.ForEach(numero => Console.WriteLine(numero));

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

//Carro car1 = new Carro();

//car1.Modelo = "Civic";
//car1.Fabricante = "Honda";
//car1.setAno(1999);
//Console.WriteLine(car1.DescricaoDetalhada);


//Album albumQueen = new Album("A night at the opera");

//Banda queen = new Banda("Queen");
//queen.AdicionarAlbum(albumQueen);

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Disponivel = true,
//    Duracao = 213
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Disponivel = false,
//    Duracao = 354
//};

//albumQueen.AdicionarMusica(musica1);
//albumQueen.AdicionarMusica(musica2);

//musica1.ExibeFichaTecnica();
//musica2.ExibeFichaTecnica();
//albumQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

Convidado paulGeorge = new Convidado("Paul George", 34, "Jogador de basquete");
Convidado julioCocielo = new Convidado("Júlio Cocielo", 32, "YouTuber");
Convidado GuiSantos = new Convidado("Gui Santos", 26, "Jogador de Basquete");
Convidado fabricioGabriel = new Convidado("Fabricio Gabriel", 20, "Dev");

Episodio episodio1 = new Episodio(3600, $"Conhecendo {paulGeorge.Nome}");
Episodio episodio2 = new Episodio(3600, $"Conversa com {julioCocielo.Nome}");
Episodio episodio3 = new Episodio(3600, $"Falando com {GuiSantos.Nome}");
Episodio episodio4 = new Episodio(7200, $"Conversando com {fabricioGabriel.Nome}");

Podcast podPah = new Podcast("Youtube", "PodPah");
podPah.AdicionarEpisodio(episodio1);
podPah.AdicionarEpisodio(episodio2);
podPah.AdicionarEpisodio(episodio3);
podPah.AdicionarEpisodio(episodio4);

podPah.ExibirDetalhes();
