using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class GreatestCommonDiv
    {
        List<int> firstDivisor = new List<int>();
        List<int> secondDivisor = new List<int>();
        List<int> commonDivisors = new List<int>();
        public void askForNumber()
        {
            Console.WriteLine("enter first Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            FigureGCDfirst(ref firstNum);
            figureGCDsecond(ref secondNum);
            
        }
        public void FigureGCDfirst(ref int firstnum)
        {
            for (int i = 1; i < firstnum; i++)
            {
                int first = firstnum%i;
                if (first == 0)
                {
                    firstDivisor.Add(i);
                }
            }
        }
        public void figureGCDsecond(ref int secondNum)
        {
            for (int i = 1; i < secondNum; i++)
            {
                int second = secondNum % i;
                if (second == 0)
                {
                    secondDivisor.Add(i);
                }
            }
        }
        public void compare()
        {
            foreach (int number in firstDivisor.Intersect(secondDivisor))
            {
                commonDivisors.Add(number);
                
            }
            Console.WriteLine(commonDivisors.Max());
            Console.ReadLine();
        }
    }
}
