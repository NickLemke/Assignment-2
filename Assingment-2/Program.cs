using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment_2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string[] grades = { "Kindergarden", "First Grade", "Second Grade", "Third Grade", "Fourth Grade", "Fith Grade", "Sixth Grade", "Seven Grade", "Eigth Grade" };
            string[] months = { "September", "October", "November", "December", "January", "Febuary", "March", "April", "May" };
            int[] gradePrice = { 80, 60 };

            int count = 0;
            foreach (string grade in grades)
            {
                int tuition = 0;
                if (count == 0)
                {
                    tuition = gradePrice[0];
                }
                else
                {
                    tuition = (gradePrice[1] * count); 
                }
                foreach (string month in months)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Grade Number = " + count.ToString());
                        Console.WriteLine("Classroom Number = " + i.ToString());
                        Console.WriteLine("Month = " + month);
                        Console.WriteLine("Tuition this moneth = $" + tuition.ToString());
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine();
                    }
                }
                count++;
            }
        }
    }
}
