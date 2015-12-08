using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public  class FigureNum
    {
      
        public List<double> happyNums = new List<double>();
        public List<double> duplicates = new List<double>();
        string originalNum;
        double number;
        double counterNum;
        public void getNumber()
        {
            Console.WriteLine("Enter a number: ");
            counterNum = Convert.ToDouble(Console.ReadLine());
            number = 1;
            numberDoThing(number);

        }
        public void numberDoThing(double number)
        {
            while (happyNums.Count < counterNum)
            {
                number++;
                getHappy(number);
            }
        }


        public void getHappy(double number)
        {
            if (number == 1)
            {
                happyNums.Add(number);
            }
            if (duplicates.Contains(number))
            {
                checkNum(number);
            }
            else
            {
                duplicates.Add(number);
                checkNum(number);
            }

        }
        

       public void checkNum(double number)
        {
            double baseNum = 0;
            List<double> resultList = new List<double>();
            string thisNum = number.ToString();
            char[] numArray = thisNum.ToCharArray();
            foreach (char num in numArray)
            {
                double numnum = char.GetNumericValue(num);
                double result = Math.Pow(numnum, 2);
                resultList.Add(result);
            }
            foreach (double Number in resultList)
            {
                baseNum += Number;

            }
         number = baseNum;
            
                //getHappy(finalNum);
        }
                


                


            }




        }


    

