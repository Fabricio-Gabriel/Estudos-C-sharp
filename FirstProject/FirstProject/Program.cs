//string msgBoasVindas = "Boas vindas ao Screen Sound";
//void MostraMensagem()
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

//void ExibeMenu()
//{
//    Console.WriteLine("Digite 1 registrar uma banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para exibir a média de uma banda");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("\nDigite a sua opção: ");
//    int opcao = int.Parse(Console.ReadLine())!;

//    switch(opcao)
//    {
//        case 1:
//            Console.WriteLine("Você escolheu a opção " + opcao);
//            break;
//        case 2:
//            Console.WriteLine("Você escolheu a opção " + opcao);
//            break;
//        case 3:
//            Console.WriteLine("Você escolheu a opção " + opcao);
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

int VerificaNum(int escolha)
{
    if (escolha < 0 || escolha > 100)
    {
        Console.WriteLine("Escolha inválida, Tente novamente (0 a 100)");
        return -1;
    }
    else
    {
        return escolha;
    }
  

}

Random aleatorio = new Random();

int valorMaquina = aleatorio.Next(100);

Console.WriteLine("========================================");
Console.WriteLine("SEJA BEM-VINDO AO JOGO DA ADVINHAÇÃO!!!");
Console.WriteLine("========================================\n");

do
{
    Console.Write("Digite o número que escolheu: ");
    int escolha = int.Parse(Console.ReadLine());
    
    if (VerificaNum(escolha) < valorMaquina)
    {
        Console.WriteLine("O número digitado é menor do que o escolhido, tente de novo!\n");
        continue;
    } else if (VerificaNum(escolha) > valorMaquina)
    {
        Console.WriteLine("O número digitado é maior que o escolhido, tente de novo!\n");
        continue;
    } else
    {
        Console.WriteLine("Parabéns! Você Acertou!\n");
        Console.WriteLine($"O valor digitado foi {VerificaNum(escolha)} o valor escolhido foi {valorMaquina}");
        break;
    }

} while (true);









//List<string> lista = ["C#", "JAVA", "JavaScript"];

//lista.Add("Python");
//lista.Remove("JAVA");

//for (int i = 0; i < lista.Count; i++)
//{
//    Console.WriteLine(lista[i]);
//}

//Console.Write("Digite seu nome: ");
//string nome =  Console.ReadLine();
//Console.Write("Digite seu Sobrenome: ");
//string sobrenome = Console.ReadLine();
//Console.WriteLine($"Olá {nome} {sobrenome}, seja muito bem-vindo!");