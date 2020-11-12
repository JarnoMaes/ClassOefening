using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExec
{
    class Students
    {
        private string name;
        private int age;
        private string emailAddress;


        public Students(string name, int age, string emailAddress)
        {
            this.name = name;
            this.age = age;
            this.emailAddress = emailAddress;
        
        }
        public void showOutput()
        {
            Console.WriteLine($"\nMy name is {name} and i am {age} years old" +
                $" and you can reach me on {emailAddress}");
        }
        public  string getEmailAdress()
        {
            if (age >= 18)
            {
                return emailAddress;
            }
            else
            {
                return "Person too young, information protected";
            }
        }
        public int getAge()
        {
            if (age >= 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
        }
        public string getName()
        {
            if (age >= 18)
            {
                return name;
            }
            else
            {
                return "Person too young, information protected";
            }
        }
        public void changeName(string changeName)
        {
            if (changeName != "")
            {
                this.name = changeName;
            }
        }
        public void changeAge(int newAge)
        {
            if (age > 0)
            {
                this.age = newAge;
            }
        
        }
        public void changeEmail(string newEmail)
        {
            if (newEmail != "")
            {
                this.emailAddress = newEmail;
            }
        }
            


    }
}
