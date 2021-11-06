using LuhnAlgorithm.Library;
using System;
using Xunit;

namespace LuhnAlgorithm.UnitTest
{
    public class LuhnAlgorithmUnitTest
    {
        [Fact]
        public void GivenAValidMasterCardCreditCardShouldBeCheckIsAValidMasterCardCreditCardTest()
        {
            var creditCard = "5105 1051 0510 5100";

            var isValid = LuhnAlgorithmValidator.IsValid(creditCard);

            Assert.True(isValid);
        }

        [Fact]
        public void GivenAValidVisaCreditCardShouldBeCheckIsAValidVisaCreditCardTest()
        {
            var creditCard = "4012 8888 8888 1881";

            var isValid = LuhnAlgorithmValidator.IsValid(creditCard);

            Assert.True(isValid);
        }
    }
}
