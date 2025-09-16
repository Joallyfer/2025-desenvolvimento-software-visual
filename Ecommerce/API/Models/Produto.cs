namespace API.Models;

public class Produto
{
    //Contrutor
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
        Nome = string.Empty;
    }
    //Atributos da Classe / Em C# se chama Propriedades
    public string Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    public DateTime CriadoEm { get; set; }




    //Atributos da Classe Exemplo Java
    //private string nome;
    //Metodos
    // public string getNome()
    // {
    // return nome;
    // }
    //    public void setNome(string nome)
    // {
    //     this.nome = nome;
    //}

}
