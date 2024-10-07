using System.Text;

namespace CrackEncryption.Ciphers
{
    public static class VigenèreCipher
    {
        public static string Encrypt(string plainText, string key, bool cryptWhiteSpaces)
        {
            return Transform(plainText, key, true, cryptWhiteSpaces);
        }

        public static string Decrypt(string cipherText, string key, bool cryptWhiteSpaces)
        {
            return Transform(cipherText, key, false, cryptWhiteSpaces);
        }

        private const int alphabetSize = 256;

        private static string Transform(string text, string key, bool encrypting, bool cryptWhiteSpaces)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            var result = new StringBuilder();
            int keyIndex = 0;

            foreach (var ch in text)
            {
                var cByte = (byte)ch;
                if (!char.IsWhiteSpace(ch) && !cryptWhiteSpaces || cryptWhiteSpaces)
                {
                    var kByte = (byte)key[keyIndex % key.Length];

                    var shiftedByte = encrypting
                        ? (cByte + kByte) % alphabetSize
                        : (cByte - kByte + alphabetSize) % alphabetSize;

                    result.Append((char)shiftedByte);
                }
                else
                {
                    result.Append(ch);
                }

                keyIndex++;
            }

            return result.ToString();
        }
    }
}
