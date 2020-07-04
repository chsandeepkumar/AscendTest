using System.Linq;

namespace AscendTest.Library
{
    public class ValidationService
    {
        public static bool Validate(string userName)
        {
            if (userName.Length <= 4) return false;

            return IsContainsAlphaNumericOrUnderScore(userName) && IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol(userName);
        }

        public static bool IsContainsAlphaNumericOrUnderScore(string userName)
        {
            return (IsContainAlphaNumeric(userName) || IsContainSymbol(userName));
        }

        public static bool IsContainSymbol(string userName)
        {
            return userName.Any(character => character == '_');
        }
        public static bool IsContainAlphaNumeric(string userName)
        {
            return userName.All(char.IsLetterOrDigit);
        }
        public static bool IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol(string userName)
        {
            if (IsContainSymbol(userName))
                return char.IsLetter(userName[0]) || userName[userName.Length - 1] != '_';
            return char.IsLetter(userName[0]);

        }

    }
}