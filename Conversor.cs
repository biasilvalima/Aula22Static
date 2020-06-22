namespace Aula22Static
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.25f;
        public static float CotacaoEuro = 5.89f;

        public static float ConverterDolarParaReal(float valor)
        {
            return valor * CotacaoDolar;
        }

        public static float ConverterRealParaDolar(float valor)
        {
            return valor / CotacaoDolar;
        }

        public static float CoverterEuroParaReal(float valor)
        {
            return valor * CotacaoEuro;
        }

        public static float ConverterRealParaEuro(float valor)
        {
            return valor / CotacaoEuro;
        }
    }
}