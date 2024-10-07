using CrackEncryption.Enums;

namespace CrackEncryption
{
    public static class CharacterFrequencyProvider
    {
        public static readonly Dictionary<Language, List<CharacterFrequency>> LanguageFrequencies = new()
    {
        {
            Language.English,
            [
                new CharacterFrequency(' ', 11.1607),
                new CharacterFrequency('e', 11.1607),
                new CharacterFrequency('a', 8.4966),
                new CharacterFrequency('r', 7.5809),
                new CharacterFrequency('i', 7.5448),
                new CharacterFrequency('o', 7.1635),
                new CharacterFrequency('t', 6.9509),
                new CharacterFrequency('n', 6.6544),
                new CharacterFrequency('s', 5.7351),
                new CharacterFrequency('l', 5.4893),
                new CharacterFrequency('c', 4.5388),
                new CharacterFrequency('u', 3.6308),
                new CharacterFrequency('d', 3.3844),
                new CharacterFrequency('p', 3.1671),
                new CharacterFrequency('m', 3.0129),
                new CharacterFrequency('h', 3.0034),
                new CharacterFrequency('g', 2.4705),
                new CharacterFrequency('b', 2.0720),
                new CharacterFrequency('f', 1.8121),
                new CharacterFrequency('y', 1.7779),
                new CharacterFrequency('w', 1.2899),
                new CharacterFrequency('k', 1.1016),
                new CharacterFrequency('v', 1.0074),
                new CharacterFrequency('x', 0.2902),
                new CharacterFrequency('z', 0.2722),
                new CharacterFrequency('j', 0.1965),
                new CharacterFrequency('q', 0.1962)
            ]
        },
        {
            Language.Hungarian,
            [
                new CharacterFrequency(' ', 10.53),
                new CharacterFrequency('e', 10.53),
                new CharacterFrequency('a', 8.98),
                new CharacterFrequency('t', 7.97),
                new CharacterFrequency('l', 6.79),
                new CharacterFrequency('s', 6.20),
                new CharacterFrequency('n', 5.36),
                new CharacterFrequency('k', 5.05),
                new CharacterFrequency('z', 4.41),
                new CharacterFrequency('r', 4.27),
                new CharacterFrequency('i', 3.88),
                new CharacterFrequency('o', 3.85),
                new CharacterFrequency('á', 3.67),
                new CharacterFrequency('é', 3.52),
                new CharacterFrequency('g', 3.13),
                new CharacterFrequency('m', 2.92),
                new CharacterFrequency('b', 2.15),
                new CharacterFrequency('y', 2.12),
                new CharacterFrequency('v', 2.03),
                new CharacterFrequency('d', 1.73),
                new CharacterFrequency('h', 1.49),
                new CharacterFrequency('j', 1.12),
                new CharacterFrequency('ó', 1.08),
                new CharacterFrequency('ö', 1.08),
                new CharacterFrequency('f', 1.06),
                new CharacterFrequency('p', 1.04),
                new CharacterFrequency('ő', 1.01),
                new CharacterFrequency('u', 0.93),
                new CharacterFrequency('c', 0.81),
                new CharacterFrequency('í', 0.64),
                new CharacterFrequency('ü', 0.53),
                new CharacterFrequency('ú', 0.29),
                new CharacterFrequency('ű', 0.23),
                new CharacterFrequency('x', 0.07),
                new CharacterFrequency('w', 0.04),
                new CharacterFrequency('q', 0.01)
            ]
        }
    };

        public static int PerformFrequencyAnalysis(string cipherText, char ch)
        {
            if (String.IsNullOrEmpty(cipherText))
            {
                return 0;
            }

            var frequency = new Dictionary<char, int>();

            foreach (var c in cipherText)
            {
                if (frequency.TryGetValue(c, out int value))
                {
                    frequency[c] = ++value;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            var mostFrequentChar = frequency.OrderByDescending(pair => pair.Value).First().Key;
            return (mostFrequentChar - ch) & 0xFF;  // & 0xFF ensures the result is within the byte range
        }
    }

}
