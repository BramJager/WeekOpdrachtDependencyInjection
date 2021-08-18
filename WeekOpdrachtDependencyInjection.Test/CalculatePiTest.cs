using System;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using Xunit;

namespace WeekOpdrachtDependencyInjection.Test
{
    public class CalculatePiTest
    {
        private readonly ICalculatePiService _calculatePiService;

        public CalculatePiTest()
        {
            _calculatePiService = new CalculatePiService();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(10)]
        public void Should_ReturnPiPlusInt_When_IntIsGivenToAdd(int number)
        {
            //Arrange
            double result;

            //Act
            result = _calculatePiService.Add(number);

            //Assert
            Assert.Equal(result, Math.PI + number);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(10)]
        public void Should_ReturnPiMinusInt_When_IntIsGivenToMinus(int number)
        {
            //Arrange
            double result;

            //Act
            result = _calculatePiService.Minus(number);

            //Assert
            Assert.Equal(result, Math.PI - number);
        }
    }
}
