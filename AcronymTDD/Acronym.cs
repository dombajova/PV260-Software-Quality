using System;
using System.Linq;

namespace AcronymTDD
{
    public static class Acronym
    {
        private static readonly char[] Separators = { ' ', '-' };
        private static readonly string[] Prepositions = { "of", "to", "about" }; //...

        private static string GetAcronymForWord(string word)
        {
            if (String.IsNullOrEmpty(word) || IsPreposition(word))
            {
                return "";
            }
            if (word.ToLower() == "and")
            {
                return "&";
            }
            return word.First().ToString().ToUpper();
        }

        private static bool IsPreposition(string word)
        {
            return Prepositions.Any(preposition => preposition.Equals(word.ToLower()));
        }

        public static string GetAccronym(string sentence)
        {
            if (String.IsNullOrEmpty(sentence))
            {
                return "";
            }
            var words = sentence.Split(Separators).Select(x => x);
            return string.Join("", words.Select(word => GetAcronymForWord(word)));
        }
    }
}
