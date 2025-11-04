using BibliotecaCSharp.model.pessoa;

namespace BibliotecaCSharp.controller;

public class LoginController
{
    public List<Pessoa> Pessoas = new List<Pessoa>();

    private int senhaParaSerBibliotecario = 2005;
    
     public Pessoa UsuarioLogado { get; private set; }
     
     BibliotecaController biblioteca = new BibliotecaController();

    public void FazerRegistro()
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o seu senha: ");
        string senha = Console.ReadLine();
        Console.Write("Qual sua idade? ");
        int idade = int.Parse(Console.ReadLine());
        Console.Write("Admin ou cliente(A para admin e C para cliente)? ");
        string admin = Console.ReadLine().ToUpper();
        
        bool continuar = true;
        
        foreach (Pessoa pessoa in Pessoas)
        {
            if (pessoa.Nome == nome)
            {
                Console.Write("Nome já existe!");
                continuar = false;
            }
        }

        if (continuar == true)
        {
            if (admin == "A")
            {
                Console.Write("Senha admin: ");
                int senhaParaSer = int.Parse(Console.ReadLine());
                if (senhaParaSer == senhaParaSerBibliotecario)
                {
                    Pessoa p = new Bibliotecario(nome, idade, Pessoas.Count, senha, true);
                    Pessoas.Add(p);
                    Console.WriteLine("Registro como admin realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Senha incorreta!");
                }
            } else if (admin == "C")
            {
                Pessoa p = new Cliente(nome, idade, Pessoas.Count, senha, false);
                Pessoas.Add(p);
                Console.WriteLine("Registro como cliente realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Tipo de usuário inválido!");
            }
        }

        {
            if (admin == "A")
            {
                Console.Write("Senha admin: ");
                int senhaParaSer = int.Parse(Console.ReadLine());
                if (senhaParaSer == senhaParaSerBibliotecario)
                {
                    Pessoa p = new Bibliotecario(nome, idade, Pessoas.Count, senha, true);
                    Pessoas.Add(p);
                    Console.WriteLine("Registro como admin realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Senha incorreta!");
                }
            } else if (admin == "C")
            {
                Pessoa p = new Cliente(nome, idade, Pessoas.Count, senha, false);
                Pessoas.Add(p);
                Console.WriteLine("Registro como cliente realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Tipo de usuário inválido!");
            }
        }
    }

    public void FazerLogin()
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o seu senha: ");
        string senha = Console.ReadLine();
        foreach (Pessoa pessoa in Pessoas)
        {
            if (pessoa.Nome == nome && pessoa.Senha == senha)
            {
                UsuarioLogado = pessoa;
                Console.WriteLine("Login efetuado com sucesso!");
                biblioteca.Menu(UsuarioLogado, Pessoas);
            }
        }
    }
    
    public void Menu()
    {
        int option = -1;
        do
        {
            Console.Write("1-Login\n2-Registrar-se\n0-Sair\nEscolha: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {   
                case 0:
                    Console.WriteLine("Tchauuu!!!");
                    break;
                case 1:
                    FazerLogin();
                    break;
                case 2:
                    FazerRegistro();
                    break;
                default:
                    Console.WriteLine("Opção inexistente!");
                    break;
            
            }
        } while (option != 0);
    }
}