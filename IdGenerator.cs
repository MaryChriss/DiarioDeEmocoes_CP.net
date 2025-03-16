namespace DiarioEmocoes_webapi.Utils
{
    internal static class IdGenerator
    {
        private static int _ultimoId = 0;
        public static int GerarNovoId()
        {
            return ++_ultimoId;
        }
    }
}
