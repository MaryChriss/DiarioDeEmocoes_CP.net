
using DiarioEmocoes_webapi.Models;

namespace DiarioEmocoes_webapi.Services
{
    public class DiarioService
    {
        private List<RegistroEmocao> _registros = new List<RegistroEmocao>();

        public void AdicionarRegistro(RegistroEmocao registro)
        {
            _registros.Add(registro);
            Console.WriteLine("Registro adicionado com sucesso!");
        }

        public void ListarRegistros()
        {
            Console.WriteLine("\n======= Seu Diário de Emoções =======\n");
            if (_registros.Count == 0)
            {
                Console.WriteLine("Nenhum registro encontrado.\n");
                return;
            }

            foreach (var registro in _registros)
            {
                Console.WriteLine(registro.ToString());
                Console.WriteLine("----------------------------\n");
            }
        }
    }
}