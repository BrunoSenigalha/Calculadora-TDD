using Calculadora_TDD.Utilitarios;

namespace Calculadora_TDD_Test
{
    public class UnitTest1
    {
        private Calculadora _calc;

        public UnitTest1()
        {
            _calc = new Calculadora();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(-3, 4, 1)]
        public void TestarSomar(double num1, double num2, double resultadoEsperado)
        {
            // Act
            double resultado = _calc.soma(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 10, 10)]
        [InlineData(30, 30, 0)]
        [InlineData(-2, 3, -5)]
        public void TestarSubtrair(double num1, double num2, double resultadoEsperado)
        {
            // Act
            double resultado = _calc.subtracao(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(5, 10, 50)]
        [InlineData(1, 1, 1)]
        public void TesteMultiplicar(int num1, int num2, int resultadoEsperado)
        {
            // Act
            var resultado = _calc.multiplicacao(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(40, 2, 20)]
        [InlineData(10, 5, 2)]
        [InlineData(30, 5, 6)]
        public void TesteDividir(int num1, int num2, int resultadoEsperado)
        {
            // Act
            var resultado = _calc.divisao(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestarDividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
                _calc.divisao(3, 0));
        }

    }
}