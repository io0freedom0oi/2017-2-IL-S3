using System;

namespace ITI.WordLib
{
    public class Word
    {
        readonly string _word;

        public Word(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) throw new ArgumentException("The word must be nt null nor whitespace.", nameof(word));
            WordGuard(word);

            _word = word;
        }

        static void WordGuard(string word)
        {
            for (int idx = 0; idx < word.Length; idx++)
            {
                char c = word[idx];
                if (!char.IsLetter(c)) throw new ArgumentException("A word must contain only letters.", nameof(word));
            }
        }

        public bool IsPalindrome
        {
            get
            {
                string value = Value;
                for (int idx = 0; idx < value.Length / 2; idx++)
                {
                    if (value[idx] != value[value.Length - (1 + idx)]) return false;
                }

                return true;
            }
        }

        public int Length
        {
            get { return _word.Length; }
        }

        public string Original
        {
            get { return _word; }
        }

        public string Value
        {
            get { return _word.ToLower(); }
        }

        public int GetCharacterCount(char c)
        {
            string value = Value;
            int count = 0;
            c = char.ToLower(c);

            foreach (char current in value)
            {
                if (current == c) count++;
            }

            return count;
        }

        public bool IsRhymingWith(Word candidate)
        {
            throw new NotImplementedException();
        }

        public bool IsAnagramOf(Word candidate)
        {
            throw new NotImplementedException();
        }

        public Word ToJavanais()
        {
            throw new NotImplementedException();
        }
    }
}
