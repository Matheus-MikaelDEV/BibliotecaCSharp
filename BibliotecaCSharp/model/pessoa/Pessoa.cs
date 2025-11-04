namespace BibliotecaCSharp.model.pessoa;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int Id { get; set; }
    
    public string Senha { get; set; }
    public bool IsAdmin { get; private set; }

    protected Pessoa(string nome, int idade, int id, string senha, bool isAdmin)
    {
        Nome = nome;
        Idade = idade;
        Id = id;
        Senha = senha;
        IsAdmin = isAdmin;
    }
}