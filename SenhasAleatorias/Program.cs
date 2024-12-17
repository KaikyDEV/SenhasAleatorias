using System;

class GeradorDeSenhas
{
    static void Main()
    {
        Console.WriteLine("Gerador de Senhas Aleatórias");

        // Solicita ao usuário o comprimento da senha
        Console.Write("Digite o comprimento desejado para a senha: ");
        int comprimento = int.Parse(Console.ReadLine());

        // Solicita ao usuário se deseja incluir caracteres especiais
        Console.Write("Deseja incluir caracteres especiais? (s/n): ");
        bool incluirCaracteresEspeciais = Console.ReadLine().ToLower() == "s";

        // Solicita ao usuário se deseja incluir números
        Console.Write("Deseja incluir números? (s/n): ");
        bool incluirNumeros = Console.ReadLine().ToLower() == "s";

        // Solicita ao usuário se deseja incluir letras maiúsculas
        Console.Write("Deseja incluir letras maiúsculas? (s/n): ");
        bool incluirMaiusculas = Console.ReadLine().ToLower() == "s";

        // Gera a senha
        string senha = GerarSenha(comprimento, incluirCaracteresEspeciais, incluirNumeros, incluirMaiusculas);

        Console.WriteLine("Senha gerada: " + senha);
    }

    static string GerarSenha(int comprimento, bool incluirCaracteresEspeciais, bool incluirNumeros, bool incluirMaiusculas)
    {
        string caracteresMinusc = "abcdefghijklmnopqrstuvwxyz";
        string caracteresMaiusc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string caracteresNumeros = "0123456789";
        string caracteresEspeciais = "!@#$%^&*()-_+=<>?";

        string caracteresPermitidos = caracteresMinusc;

        // Adiciona mais tipos de caracteres com base nas escolhas do usuário
        if (incluirMaiusculas)
            caracteresPermitidos += caracteresMaiusc;
        if (incluirNumeros)
            caracteresPermitidos += caracteresNumeros;
        if (incluirCaracteresEspeciais)
            caracteresPermitidos += caracteresEspeciais;

        Random random = new Random();
        char[] senha = new char[comprimento];

        for (int i = 0; i < comprimento; i++)
        {
            // Escolhe aleatoriamente um caractere da lista de caracteres permitidos
            senha[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
        }

        return new string(senha);
    }
}
