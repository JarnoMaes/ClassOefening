using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", 19,75);
            s1.SetName("");
            Console.WriteLine(s1.GetName());
            s1.setFinalGrade(105);
            Console.WriteLine(s1.GetFinalGrade());
            
            

            





        }
        
    }
}
