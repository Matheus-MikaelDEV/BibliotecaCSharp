namespace BibliotecaCSharp.model.produto;

public class Livro : Produto
{
    public string Autor { get; set; }
    public string Descricao { get; set; }
    
    public string Categoria { get; set; }

    public Livro(string nome, int id, string autor, string descricao, string categoria) : base(nome, id)
    {
        Autor = autor;
        Descricao = descricao;
        Categoria = categoria;
    }
}