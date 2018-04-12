using System;

namespace BlazorExample.Services
{
    public class GeradorDeNumeros
    {
        public int GerarNumero(int numeroInicial, int numeroFinal)
        {
            var random = new Random();
            return random.Next(numeroInicial, numeroFinal);
        }
    }
}
