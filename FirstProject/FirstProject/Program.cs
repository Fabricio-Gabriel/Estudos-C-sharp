string msgBoasVindas = "Boas vindas ao Screen Sound";
void MostraMensagem()
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

void ExibeMenu()
{
    Console.WriteLine("Digite 1 registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine())!;

    switch(opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcao);
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

List<string> lista = ["C#", "JAVA", "JavaScript"];

lista.Add("Python");
lista.Remove("JAVA");

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

//Console.Write("Digite seu nome: ");
//string nome =  Console.ReadLine();
//Console.Write("Digite seu Sobrenome: ");
//string sobrenome = Console.ReadLine();
//Console.WriteLine($"Olá {nome} {sobrenome}, seja muito bem-vindo!");