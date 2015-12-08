using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class HappyNum
    {
        public List<int> happyNums = new List<int>();
        public List<int> duplicates = new List<int>();
        public int OriginalNum;
        public int result;
        int i = 1;



        public void iterateToNumber(int number)
        {
            
            while (happyNums.Count < number)
            {
                
                
                lookForHappy(i);
                i++;
                
            }
        }


        public void lookForHappy(int number)
        {
           
            bool duplicate = false;
            while (duplicate == false)
            {
                result = doHappyThings(number);
                if (result == 1)
                {
                    happyNums.Add(number);
                    duplicate = true;
                }
                
                else if (duplicates.Contains(number))
                {
                    duplicate = true;
                }
                else
                {
                    duplicates.Add(number);
                    number = result;
                }
            }
            
        }
        public int doHappyThings(int number)
        {
            int value = 0;
            string numberString = number.ToString();
            char[] numberArray = numberString.ToArray();

            foreach (char num in numberArray)
            {
                int nVal = Int32.Parse(num.ToString());
                value += (nVal * nVal);
            }
            return (value);
            

        }
        public void getStuff()
        {
            Console.WriteLine(String.Join(" ", happyNums));
            Console.ReadLine();
        }
    }
}
