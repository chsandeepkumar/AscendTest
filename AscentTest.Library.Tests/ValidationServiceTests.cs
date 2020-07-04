using AscendTest.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AscentTest.Library.Tests
{
    [TestClass]
    public class ValidationServiceTests
    {
        [TestMethod]
        public void When_UserName_Length_is_LessThan_4_Then_Validate_Return_False()
        {
            var userName = "Abc";
            var result = ValidationService.Validate(userName);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void When_UserName_Contains_AlphaNumeric_Then_IsContainAlphaNumeric_Return_True()
        {
            var userName = "Abc123";
            var result = ValidationService.IsContainAlphaNumeric(userName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void When_UserName_Contains_Symbol_Then_IsContainSymbol_Return_True()
        {
            var userName = "A_BCCCC";
            var result = ValidationService.IsContainSymbol(userName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void When_UserName_Contains_AlphaNumericWithUnderScore_Then_IsContainsAlphaNumericOrUnderScore_Return_True()
        {
            var userName = "ABCd_123";
            var result = ValidationService.IsContainsAlphaNumericOrUnderScore(userName);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void When_UserName_FirstCharacter_Contains_Non_Alpha_Character_IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol_return_False()
        {
            var userName = "12A123_";
            var result = ValidationService.IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol(userName);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void When_UserName_FirstCharacter_Contains_Alpha_Character_IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol_return_True()
        {
            var userName = "A123_";
            var result = ValidationService.IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol(userName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void When_UserName_LastCharacter_Contains_Underscore_IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol_return_True()
        {
            var userName = "A_123";
            var result = ValidationService.IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol(userName);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void When_UserName_Donot_Have_UnderScore_Validate_return_True()
        {
            var userName = "A12345";
            var result = ValidationService.Validate(userName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void When_UserName_Have_UnderScore_Validate_return_True()
        {
            var userName = "A123_45";
            var result = ValidationService.Validate(userName);
            Assert.IsTrue(result);
        }

    }
}