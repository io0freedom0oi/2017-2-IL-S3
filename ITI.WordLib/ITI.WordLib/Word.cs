using System;

namespace ITI.WordLib
{
    public class Word
    {
        readonly string _word;

        public Word( string word )
        {
            _word = word;
        }

        public bool IsPalindrome
        {
            get { throw new NotImplementedException(); }
        }

        public int Length
        {
            get { throw new NotImplementedException(); }
        }

        public string Original
        {
            get { return _word; }
        }

        public string Value
        {
            get { throw new NotImplementedException(); }
        }

        public int GetCharacterCount( char c )
        {
            throw new NotImplementedException();
        }

        public bool IsRhymingWith( Word candidate )
        {
            throw new NotImplementedException();
        }

        public bool IsAnagramOf( Word candidate )
        {
            throw new NotImplementedException();
        }

        public Word ToJavanais()
        {
            throw new NotImplementedException();
        }
    }
}
