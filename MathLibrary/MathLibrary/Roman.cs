using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Roman
    {
        List<string> numbers = new List<string>();
        List<string> romanNumerals = new List<string>();
        string numbersToConvert;

        public void getNumber()
        {
            Console.WriteLine("enter a number: ");
            string  number = (Console.ReadLine());
            char[] numArray = number.ToCharArray();
            int iterator = numArray.Length;
            
            foreach (char digit in numArray)
            {
                string w = digit.ToString();
                numbersToConvert = w.PadRight(iterator, '0');
                numbers.Add(numbersToConvert);
                iterator--;
            }
            

        }
        public void checkList()

        {
            foreach (string number in numbers)
            {
                
                if (number.Length == 4)
                {
                    string firstTwo = number.Substring(0, 1);
                    int numToPass = Convert.ToInt32(firstTwo);
                    convertToRoman(numToPass, "M", "M", "M");
                }
                if (number.Length == 3) 
                {
                    string firstTwo = number.Substring(0, 1);
                    int numToPass = Convert.ToInt32(firstTwo);
                    convertToRoman(numToPass, "C", "D", "M");
                }
                if (number.Length == 2)
                {
                    string firstTwo = number.Substring(0, 1);
                    int numToPass = Convert.ToInt32(firstTwo);
                    convertToRoman(numToPass, "X", "L", "C");
                }
                if (number.Length == 1)
                {
                    int numToPass = Convert.ToInt32(number);
                    convertToRoman(numToPass, "I", "V", "X");
                }
            }
        }

        public void convertToRoman(int number, string ones, string fives, string tens)
        {
            if (number == 0)
            {
                
            }
            if (Enumerable.Range(1,3).Contains(number))
            {
                string romanResult = string.Concat(Enumerable.Repeat(ones, number));
                romanNumerals.Add(romanResult);
            }
            if (number == 4) 
            {
                romanNumerals.Add(ones + fives);
                
            }
            if (number == 5)
            {
                romanNumerals.Add(fives);
            }
            if (Enumerable.Range(6,8).Contains(number))
            {
                int newNum = number - 5;
                string romanResult = string.Concat(Enumerable.Repeat(ones, newNum));
                romanNumerals.Add(romanResult);
            }

        }
        public void displayRoman()
        {
          
            
            Console.WriteLine(String.Join("", romanNumerals));
            Console.ReadLine();
        }
    }
}
