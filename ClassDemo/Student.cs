using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;


        public Student(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }
        public Student(string name, int age) :this(name,age,0)
        {
            
        }

        public void SayHello() 
        {
            Console.WriteLine($"Hello from {name} he is {age} and his" +
                $" final grade is {finalGrade}");
        }
        public string GetName()
        {
            if (age >= 18)
            {
                return name;
            }
            else
            {
                return "Person is to young";
            }
        }
        public void SetName(string newName)
        {
            if (newName != "")
            {
                this.name = newName;
            }
            
        }
        public int GetAge()
        {
            if (age <= 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
            
        }
        public void setAge(int newAge)
        {
            if (age != 0)
            {
                age = newAge;
            }
            
        }
        public double GetFinalGrade()
        {
            return finalGrade;
        }
        public void setFinalGrade(double newFinalGrade)
        {
            if (newFinalGrade < 65)
            {
                newFinalGrade = 65;
            }
            else if (newFinalGrade > 100)
            {
                newFinalGrade = 100;
            }
            finalGrade = newFinalGrade;
                  
        }
    }
}
