namespace BibliotecaCSharp.model.pessoa;

public class Cliente : Pessoa
{
    public Cliente(string nome, int idade, int id, string senha, bool isAdmin) : base(nome, idade, id, senha, isAdmin)
    {
    }
}