using System.Text;

namespace CrackEncryption.Ciphers
{
    public static class CaesarCipher
    {
        public static string Encrypt(string input, int shift, bool cryptWhiteSpaces)
        {
            return Transform(input, shift, true, cryptWhiteSpaces);
        }

        public static string Decrypt(string input, int shift, bool cryptWhiteSpaces)
        {
            return Transform(input, shift, false, cryptWhiteSpaces);
        }

        public static string Transform(string input, int shift, bool encrypt, bool cryptWhiteSpaces)
        {
            if (string.IsNullOrEmpty(input) || shift == 0)
            {
                return input;
            }

            var bytes = Encoding.UTF8.GetBytes(input);
            for (int i = 0; i < bytes.Length; i++)
            {
                if (!char.IsWhiteSpace((char)bytes[i]) && !cryptWhiteSpaces || cryptWhiteSpaces)
                {
                    bytes[i] = encrypt ?
                        (byte)((bytes[i] + shift) % 256) :
                        (byte)((bytes[i] - shift) % 256);
                }
            }
            return Encoding.UTF8.GetString(bytes);
        }
    }

}
