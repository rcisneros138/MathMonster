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
        
        double number;
        double counterNum;
        public void getNumber()
        {
            Console.WriteLine("Enter a number: ");
            counterNum = Convert.ToDouble(Console.ReadLine());
            number = 1;
            numberDoThing();

        }
        public void numberDoThing()
        {
            for (int i = 1; i < counterNum; i++)
            {
                getHappy(i);
            }
           
        }


        public void getHappy(double number)
        {
            int newNum = Convert.ToInt32(number);



            if (newNum == 1)
            {
                happyNums.Add(number);
            }
            else if (duplicates.Contains(Convert.ToInt32(newNum)))
            {

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
            if (number !=1)
            {
                duplicates.Add(number);
            }
            
        }
        public void giveList()
        {
            Console.WriteLine(String.Join(" ", happyNums));
            Console.ReadLine();
        }
                


                


            }




        }


    

