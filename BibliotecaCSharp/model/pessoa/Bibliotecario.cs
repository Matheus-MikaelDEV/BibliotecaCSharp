namespace BibliotecaCSharp.model.pessoa;

public class Bibliotecario : Pessoa
{
    public Bibliotecario(string nome, int idade, int id, string senha, bool isAdmin) : base(nome, idade, id, senha, isAdmin)
    {
    }
}