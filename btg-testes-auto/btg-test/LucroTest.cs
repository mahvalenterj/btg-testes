using btg_testes_auto;
using System;

namespace btg_test
{
    public class LucroTest
    {
             
             //Vai gerar um erro
            [Fact]
            public void Calcular_LucroMenorQue20_DeveRetornarValorCom45PercentDeLucro()
            {
                // Arrange
                Lucro lucroCalculadora = new Lucro();
                decimal valorProduto = 15;

                // Act
                decimal resultado = lucroCalculadora.Calcular(valorProduto);

                // Assert
                Assert.Equal(15 * 1.50M, resultado); 
            }
            

        public class LucroTests
        {
            [Fact]
            public void Calcular_LucroMenorQue20_DeveRetornarValorCom45PercentDeLucro()
            {
                // Arrange
                Lucro lucroCalculator = new Lucro();
                decimal valorProduto = 15;

                // Act
                decimal resultado = lucroCalculator.Calcular(valorProduto);

                // Assert
                Assert.Equal(15 * 1.45M, resultado);
            }

            [Fact]
            public void Calcular_LucroMaiorOuIgualA20_DeveRetornarValorCom30PercentDeLucro()
            {
                // Arrange
                Lucro lucroCalculator = new Lucro();
                decimal valorProduto = 25;

                // Act
                decimal resultado = lucroCalculator.Calcular(valorProduto);

                // Assert
                Assert.Equal(25 * 1.30M, resultado);
            }

            [Fact]
            public void Calcular_LucroIgualA20_DeveRetornarValorCom30PercentDeLucro()
            {
                // Arrange
                Lucro lucroCalculator = new Lucro();
                decimal valorProduto = 20;

                // Act
                decimal resultado = lucroCalculator.Calcular(valorProduto);

                // Assert
                Assert.Equal(20 * 1.30M, resultado);
            }
        }
    }
}