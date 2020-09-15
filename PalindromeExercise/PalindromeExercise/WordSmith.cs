using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
   public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var backwordsWord = word.SequenceEqual(word.Reverse());

            return backwordsWord;
        }
    }
}
