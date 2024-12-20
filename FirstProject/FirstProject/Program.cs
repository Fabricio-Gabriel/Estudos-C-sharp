﻿string msgBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

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

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibeLogo();
    ExibeMenu();
}

void MostraBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo bandas registradas");
    Console.WriteLine("As bandas digitadas foram respectivamente: \n");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda n{i + 1}: {listaDasBandas[i]}");
    //}

    foreach(string banda in bandasRegistradas.Keys)
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

void ExibeMenu()
{
    Console.WriteLine("Digite 1 registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine())!;

    switch (opcao)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostraBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcao);
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
