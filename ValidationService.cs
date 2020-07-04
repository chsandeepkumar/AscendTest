using System.Linq;

namespace ConsoleApp3
{
    public class ValidationService
    {
        public static bool Validate(string userName)
        {
            if (userName.Length <= 4) return false;

            if (!(userName.All(x => char.IsLetterOrDigit(x) || x == '_'))) return false;

            if (!IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol(userName)) return false;

            return true;
        }

        public static bool StartsWithLetterOnly(string userName)
        {
            return userName.Select(IsOnlyAlphaCharacter).FirstOrDefault();
        }


        public static bool IsOnlyAlphaCharacter(char c)
        {
            return char.IsLetter(c);
        }


        public static bool IsFirstCharacterIsAlphaAndLastCharacterIsNotSymbol(string userName)
        {

            return char.IsLetter(userName[0]) && char.IsSymbol(userName[userName.Length - 1]);

        }

    }
}