//class Musica
//{
//    public string nome;
//    public string artista;
//    public int duracao;
//    public bool disponivel;

//    public void ExibeFicha()
//    {
//        Console.WriteLine($"Nome da música: {this.nome}");
//        Console.WriteLine($"Nome do artista: {this.artista}");
//        Console.WriteLine($"Duração: {this.duracao}");

//        if (disponivel) 
//        {
//            Console.WriteLine("A música está disponivel no plano\n");
//        } else
//        {
//            Console.WriteLine("Adquira o plano premium \n");
//        }
//    } 
//}

public class Carro
{
    public int velocidade;
    public string cor;
    public int ano;
    public string modelo;

    public void acelerar() 
    {
        this.velocidade+=10;
    } 

    public void frear()
    {
        this.velocidade-=10;
    }

    public void buzinar()
    {
        Console.WriteLine("BI BI BIIIIIIIII");
    }

}




