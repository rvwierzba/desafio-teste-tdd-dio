using MeuAppCalculadora;
using Xunit;

namespace MeuAppCalculadora.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Fact]
        public void Somar_DeveRetornarSomaCorreta()
        {
            var resultado = _calculadora.Somar(2, 3);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarSubtracaoCorreta()
        {
            var resultado = _calculadora.Subtrair(5, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Multiplicar_DeveRetornarMultiplicacaoCorreta()
        {
            var resultado = _calculadora.Multiplicar(5, 3);
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Dividir_DeveRetornarDivisaoCorreta()
        {
            var resultado = _calculadora.Dividir(6, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_DeveLancarExcecaoQuandoDividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(5, 0));
        }
    }
}
