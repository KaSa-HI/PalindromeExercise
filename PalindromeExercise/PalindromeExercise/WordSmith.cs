using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
       public  bool IsAPalindrome(string ap)
        {
         var arr = ap.Reverse().ToArray();
            string reverse = new string(arr);
            
            return ap == reverse;
        } 
    }
}
