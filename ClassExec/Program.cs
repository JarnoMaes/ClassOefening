using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExec
{
    class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students("Jarno",21,"jarno.maes@student.intecbrussel.be");
            s1.showOutput();
            Console.WriteLine(s1.getEmailAdress());
            Console.WriteLine(s1.getAge());
            Console.WriteLine(s1.getName());

            
            

           
            Students s2 = new Students("Peter", 15, "Peter.vermant@student.intecbrussel.be");
            s2.showOutput();
            Console.WriteLine(s2.getName());
            Console.WriteLine(s2.getEmailAdress());
            Console.WriteLine(s2.getAge()); 
            

            Students s3 = new Students("Kenji", 10, "Kenji@outlook.com");           
            s3.changeName("");
            s3.changeEmail("ejkqshfejksh<");
            s3.changeAge(17);
            s3.showOutput();
            

            

        }
    }
}
