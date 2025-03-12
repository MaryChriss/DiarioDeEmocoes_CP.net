using DiarioEmocoes_webapi.DiarioLib.obj;

public static class Program
{
    static void Main()
    {
        var diario = new Diario();

        while (true)
        {
            Console.WriteLine("\n Di�rio de Emo��es ");
            Console.WriteLine("1. Adicionar Registro");
            Console.WriteLine("2. Listar Registros");
            Console.WriteLine("3. Sair");
            Console.Write("\nEscolha uma op��o: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a emo��o (Ex: Feliz, Triste, Ansioso): ");
                    string? emocao = Console.ReadLine();

                    Console.Write("Digite um coment�rio sobre essa emo��o: ");
                    string? comentario = Console.ReadLine();

                    var registro = new RegistroEmocao(
                        id: new Random().Next(1, 1000),
                        emo��o: emocao ?? "Sem emo��o",
                        comentario: comentario ?? "Sem coment�rio"
                    );



                    diario.AdicionarRegistro(registro);
                    break;

                case "2":
                    diario.ListarRegistros();
                    break;

                case "3":
                    Console.WriteLine("\n At� logo! ");
                    return;

                default:
                    Console.WriteLine(" Op��o inv�lida! Tente novamente.");
                    break;
            }
        }
    }
}
