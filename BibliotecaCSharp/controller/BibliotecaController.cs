using BibliotecaCSharp.model;
using BibliotecaCSharp.model.pessoa;
using BibliotecaCSharp.model.produto;

namespace BibliotecaCSharp.controller;

public class BibliotecaController
{
    List<Livro> livros = new List<Livro>();
    List<Produto> produtos = new List<Produto>();
    List<Emprestimo> emprestimos = new List<Emprestimo>();
    
    // Adicionar livros
    public void AddLivros()
    {
        Console.Write("Digite o nome do Livro: ");
        string nome = Console.ReadLine();
        Console.Write("Quem é o autor do Livro? ");
        string autor = Console.ReadLine();
        Console.Write("Qual a descrição do Livro? ");
        string descricao = Console.ReadLine();
        Console.Write("Qual a categoria do Livro? ");
        string categoria = Console.ReadLine();
        
        Livro l = new Livro(nome, livros.Count,  autor, descricao, categoria);
        livros.Add(l);
    }
    
    public void AddEmprestimo(Pessoa pessoa)
    {
        Livro livro = null;
        Console.Write("Digite o nome do Livro: ");
        string nome = Console.ReadLine();

        foreach (Livro livro1 in livros)
        {
            if (livro1.Nome == nome)
            {
                livro = livro1;
                break;
            }
        }
        
        foreach (Emprestimo emprestimo in emprestimos)
        {
            if (emprestimo.Produto.Id == livro.Id)
            {
                Console.WriteLine("Livro indisponível para empréstimo!");
                return;
            }
        }
                
        Emprestimo emp = new Emprestimo(emprestimos.Count, pessoa, livro, DateTime.Now, DateTime.Now.AddDays(7));
        emprestimos.Add(emp);
        Console.WriteLine("Empréstimo realizado com sucesso!");
    }

    // Listar todos os livros
    public void ListarLivros()
    {
        foreach (Livro livro in livros)
        {
            Console.WriteLine($"Nome: {livro.Nome}\nID: {livro.Id}\nAutor: {livro.Autor}\nDescrição: {livro.Descricao}\nCategoria: {livro.Categoria}");
        }
    }
    
    // Listar todas as pessoas
    public void ListarPessoas(List<Pessoa> pessoas)
    {
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}\nIdade: {pessoa.Idade}\nID: {pessoa.Id}\nIsAdmin: {pessoa.IsAdmin}");
        }
    }
    
    // Menu principal
    public void Menu(Pessoa pessoa, List<Pessoa> pessoas)
    {
        if (pessoa.IsAdmin)
        {
            int option = -1;
            do
            {
                Console.WriteLine("Admin");
                Console.Write("\n1-Add Livro\n2-Ver Usuários\n0-Sair\nEscolha: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Tchauuu!!!");
                        break;
                    case 1:
                        AddLivros();
                        break;
                    case 2:
                       ListarPessoas(pessoas);
                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }
            } while (option != 0);
        }
        else
        {
            int option = -1;
            Console.WriteLine("Cliente");
            do
            {
                Console.Write("\n1-Fazer Emprestimo de Livro\n2-Ver Livros\n0-Sair\nEscolha: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddEmprestimo(pessoa);
                        break;
                    case 2:
                        ListarLivros();
                        break;
                    case 0:
                        Console.WriteLine("Tchauuu!!!");
                        break;
                    default:
                        Console.Write("Opção inexistente!");
                        break;
                }
            } while (option != 0);
        }
    }
}