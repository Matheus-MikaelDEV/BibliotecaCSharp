namespace BibliotecaCSharp.model.produto;

public abstract class Produto
{
    public string Nome { get; set; }
    public int Id { get; set; }

    protected Produto(string nome, int id)
    {
        Nome = nome;
        Id = id;
    }
}