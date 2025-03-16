using DiarioEmocoes_webapi.Controllers;
using DiarioEmocoes_webapi.Models;
using System.Text.RegularExpressions;

public static class Program
{
    static void Main()
    {
        var diario = new DiarioController();

        while (true)
        {
            Console.WriteLine("\n Diário de Emoções ");
            Console.WriteLine("1. Adicionar Registro");
            Console.WriteLine("2. Listar Registros");
            Console.WriteLine("3. Sair");
            Console.Write("\nEscolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string emocao;
                    do
                    {
                        Console.Write("Digite a emoção (Ex: Feliz, Triste, Ansioso): ");
                        emocao = Console.ReadLine()?.Trim() ?? "";

                        // Validação: Permitir apenas letras e espaços
                        if (string.IsNullOrEmpty(emocao) || !Regex.IsMatch(emocao, @"^[a-zA-Z\s]+$"))
                        {
                            Console.WriteLine("\n Digite algo valido \n");
                            emocao = "";
                        }
                    } while (string.IsNullOrEmpty(emocao));

                    string comentario;
                    do
                    {
                        Console.Write("\nDigite um comentário sobre essa emoção: ");
                        comentario = Console.ReadLine()?.Trim() ?? "";

                        // Validação: Permitir apenas letras, números e espaços
                        if (string.IsNullOrEmpty(comentario) || !Regex.IsMatch(comentario, @"^[a-zA-Z0-9\s.,!?]+$"))
                        {
                            Console.WriteLine("\n O comentário não pode conter caracteres inválidos. Tente novamente.\n");
                            comentario = "";
                        }
                    } while (string.IsNullOrEmpty(comentario));

                    var registro = new RegistroEmocao(emocao, comentario);
                    diario.AdicionarRegistro(registro);

                    break;

                case "2":
                    diario.ListarRegistros();
                    break;

                case "3":
                    Console.WriteLine("\n👋 Até logo!");
                    return;

                default:
                    Console.WriteLine("⚠️ Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
