using BibliotecaCSharp.model.pessoa;
using BibliotecaCSharp.model.produto;

namespace BibliotecaCSharp.model;

public class Emprestimo
{
    public int IdEmprestimo { get; set; }
    public Pessoa Pessoa { get; set; }
    public Produto Produto { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }
    
    public Emprestimo(int idEmprestimo, Pessoa pessoa, Produto produto, DateTime dataEmprestimo, DateTime dataDevolucao)
    {
        IdEmprestimo = idEmprestimo;
        Pessoa = pessoa;
        Produto = produto;
        DataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
    }
}