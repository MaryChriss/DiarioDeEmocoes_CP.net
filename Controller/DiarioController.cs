
using DiarioEmocoes_webapi.Models;
using DiarioEmocoes_webapi.Services;

namespace DiarioEmocoes_webapi.Controllers
{
    public class DiarioController
    {
        private DiarioService _diarioService;

        public DiarioController()
        {
            _diarioService = new DiarioService();
        }

        public void AdicionarRegistro(RegistroEmocao registro)
        {
            if (string.IsNullOrWhiteSpace(registro.Tag))
            {
                Console.WriteLine("A emoção não pode estar vazia!");
                return;
            }
            _diarioService.AdicionarRegistro(registro);
        }

        public void ListarRegistros()
        {
            _diarioService.ListarRegistros();
        }
    }
}
