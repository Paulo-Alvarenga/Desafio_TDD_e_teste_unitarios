using Desafio_TDD_e_Testes_Unitarios;

namespace Test_Desafio_TDD_e_Testes_Unitarios
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculadora = calc.dividir(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();
            calc.somar(3, 1);
            calc.somar(5, 7);
            calc.somar(2, 1);
            calc.somar(3, 4);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}

