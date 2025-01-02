public class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    
    private int ano;

    public string DescricaoDetalhada => 
           $"{this.Fabricante} {this.Modelo} {this.getAno()}";


    public void setAno(int ano)
    {
        if (this.ano < 1960 && this.ano > 2025)
        {
            this.ano = 2025;
        }
        else
        {
            this.ano = ano;
        }
    }

    public int getAno()
    {
        return this.ano;
    }

    

}