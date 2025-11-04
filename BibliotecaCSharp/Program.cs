using BibliotecaCSharp.controller;

class Program
{
    public static void Main(String[] args)
    {
        LoginController loginController = new LoginController();
        
        loginController.Menu();
    }
}