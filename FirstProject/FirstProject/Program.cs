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

//    foreach(string banda in bandasRegistradas.Keys)
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
//    } else
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
//            Console.WriteLine("Você escolheu a opção " + opcao);
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

//Random aleatorio = new Random();

//int valorMaquina = aleatorio.Next(100);

//Console.WriteLine("========================================");
//Console.WriteLine("SEJA BEM-VINDO AO JOGO DA ADVINHAÇÃO!!!");
//Console.WriteLine("========================================\n");

//do
//{
//    Console.Write("Digite o número que escolheu: ");
//    int escolha = int.Parse(Console.ReadLine());

//    if(VerificaNum(escolha) < 0 || VerificaNum(escolha) > 100)
//    {
//        continue;
//    }

//    if (VerificaNum(escolha) < valorMaquina)
//    {
//        Console.WriteLine("O número digitado é menor do que o escolhido, tente de novo!\n");
//        continue;
//    } else if (VerificaNum(escolha) > valorMaquina)
//    {
//        Console.WriteLine("O número digitado é maior que o escolhido, tente de novo!\n");
//        continue;
//    } else
//    {
//        Console.WriteLine("Parabéns! Você Acertou!\n");
//        Console.WriteLine($"O valor digitado foi {VerificaNum(escolha)} o valor escolhido foi {valorMaquina}");
//        break;
//    }

//} while (true);


//Dictionary<string, List<double>> notasAluno = new Dictionary<string, List<double>>();

//Console.Write("Digite o nome do aluno: ");
//string nomeAluno = Console.ReadLine()!;
//notasAluno.Add(nomeAluno, new List<double>());

//for(int i = 1; i <= 4; i++)
//{
//    Console.Write($"Digite a {i}a nota: ");
//    double nota = double.Parse(Console.ReadLine()!);
//    notasAluno[nomeAluno].Add(nota);
//}

//double s = 0;
//foreach(double nota in notasAluno[nomeAluno])
//{
//    s += nota;
//}

//Thread.Sleep(2000);
//double media = s / notasAluno[nomeAluno].Count;
//Console.WriteLine($"A média do aluno {nomeAluno} foi de {media}");

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

Console.Write("Digite o carro que deseja ver a média de vendas: ");
string carro = Console.ReadLine();

if(vendasCarros.ContainsKey(carro))
{
    int soma = 0;

    foreach(int venda in vendasCarros[carro])
    {
        soma += venda;
    }

    int media = soma / vendasCarros[carro].Count;
    Console.WriteLine($"O carro {carro} teve uma média de vendas de {media} carros");
} else
{
    Console.WriteLine("O carro não foi encontrado no sistema!");
}