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

            int monthCount = 1;
            foreach (string month in months)
            {
                Console.WriteLine("For Month " + month + "(" + monthCount.ToString() + "/" + months.Length.ToString() + ")");
                int gradeCount = 0;
                foreach (string grade in grades)
                {
                    int tuition = 0;
                    if (gradeCount == 0)
                    {
                        tuition = gradePrice[0];
                    }
                    else
                    {
                        tuition = (gradePrice[1] * gradeCount);
                    }
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("For Grade: " + gradeCount.ToString() + " Classroom: " + i.ToString() + " Tuition due: $" + tuition.ToString());
                    }
                    gradeCount++;
                }
                monthCount++;
                Console.WriteLine("*******************");
            }
        }
    }
}
