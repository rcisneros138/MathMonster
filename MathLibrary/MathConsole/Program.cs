﻿using System;
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
            HappyNum happy = new HappyNum();
            happy.iterateToNumber(13); 
            happy.getStuff();


            //Roman roman = new Roman();
            //roman.getNumber();
            //roman.checkList();
            //roman.displayRoman();

            //GreatestCommonDiv div = new GreatestCommonDiv();
            //div.askForNumber();
            //div.compare();


        }
    }
}
