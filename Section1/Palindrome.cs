
using System

namespace  Section1

{
    class Palindrome
    {
        static void Main(String[] args);
        
            StringUtilities utils = new StringUtilities();

            utils.Palindrome();

            bool Palindrome = utils.isPalindrome("racecar");
            Console.Writeline(Palindrome);
        }
    }
