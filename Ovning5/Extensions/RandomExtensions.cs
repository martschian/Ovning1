namespace Ovning5.Extensions
{
    internal static class RandomExtensions
    {
        public static string RandomRegistrationNumber(this Random rnd, int length, string allowedCharacters)
        {
            ISet<string> usedStrings = new HashSet<string>();

            char[] chars = new char[length];
            int setLength = allowedCharacters.Length;
            string randomString;

            do
            {
                for (int i = 0; i < length / 2; ++i)
                {
                    chars[i] = allowedCharacters[rnd.Next(setLength)];
                }

                for (int i = length / 2; i < length; ++i)
                {
                    chars[i] = Char.Parse(rnd.Next(9).ToString());
                }

                randomString = new string(chars, 0, length);

                if (usedStrings.Add(randomString))
                    break;
            } while (true);

            return randomString;
        }
    }
}
