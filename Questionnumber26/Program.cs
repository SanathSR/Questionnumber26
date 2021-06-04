using System;
using System.Collections;
using System.Collections.Generic;
namespace Questionnumber26
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ClsStudent> tempDictionary = new Dictionary<string, ClsStudent>();
            //ClsStudent student = new ClsStudent();

            ClsStudent student1 = new ClsStudent("John");
            ClsStudent student2 = new ClsStudent("Bill");
            ClsStudent student3 = new ClsStudent("Meeta");
            ClsStudent student4 = new ClsStudent("Jolly");
            ClsStudent student5 = new ClsStudent("Bill");


            tempDictionary.Add(student1.Names, student1);
            tempDictionary.Add(student2.Names, student2);
            tempDictionary.Add(student3.Names, student3);
            tempDictionary.Add(student4.Names, student4);
            //tempDictionary.Add(student5.Names, student5);

            ClsStudent value;
            tempDictionary.TryGetValue("Meeta", out value);
            Console.WriteLine(value.Names);


        }
    }
}
