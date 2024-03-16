public class Contato
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    // O construtor padrão sem parâmetros é necessário para a deserialização
    public Contato() {}

    // Construtor com todos os campos
    public Contato(string nome, string sobrenome, string telefone, string email)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Telefone = telefone;
        Email = email;
    }
    
}
