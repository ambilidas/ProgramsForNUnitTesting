﻿using System;

namespace ProgramsForNUnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programs for NUnit Testing");
            DayOfWeek obj1 = new DayOfWeek();
            //obj1.dayOfWeek();
            TempConversion obj2=new TempConversion();
            obj2.temperatureConversion();
        }
    }
}
