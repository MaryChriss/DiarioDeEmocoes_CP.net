namespace DiarioEmocoes_webapi.DiarioLib.obj
{
    public class Diario
    {
        private List<RegistroEmocao> registros = new List<RegistroEmocao>();

        public void AdicionarRegistro(RegistroEmocao registro)
        {
            registros.Add(registro);
            Console.WriteLine(" Registro adicionado com sucesso! ");
        }

        public void ListarRegistros()
        {
            Console.WriteLine("\n======= Seu Diário de Emoções =======\n");
            if (registros.Count == 0)
            {
                Console.WriteLine("Nenhum registro encontrado.\n");
                return;
            }

            foreach (var registro in registros)
            {
                Console.WriteLine( registro.ToString());
                Console.WriteLine("----------------------------\n");
            }
        }
    }
}
