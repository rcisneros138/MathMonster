using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;


namespace MathConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //FigureNum figureNum = new FigureNum();
            //figureNum.getNumber();
            Roman roman = new Roman();
            roman.getNumber();
            roman.checkList();
            roman.displayRoman();
            
            
        }
    }
}
