using DiarioEmocoes_webapi.DiarioLib.obj;

public static class Program
{
    static void Main()
    {
        var diario = new Diario();

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
                    Console.Write("Digite a emoção (Ex: Feliz, Triste, Ansioso): ");
                    string? emocao = Console.ReadLine();

                    Console.Write("Digite um comentário sobre essa emoção: ");
                    string? comentario = Console.ReadLine();

                    var registro = new RegistroEmocao(
                        id: new Random().Next(1, 1000),
                        emoção: emocao ?? "Sem emoção",
                        comentario: comentario ?? "Sem comentário"
                    );



                    diario.AdicionarRegistro(registro);
                    break;

                case "2":
                    diario.ListarRegistros();
                    break;

                case "3":
                    Console.WriteLine("\n Até logo! ");
                    return;

                default:
                    Console.WriteLine(" Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
