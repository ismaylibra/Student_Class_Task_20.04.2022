using System;

namespace HomeWork_1task1_20._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ismayil" ,"Ibrahimli", 20, "Male", false, 85 );
            Console.WriteLine(student.GetInfo());
        }

    }
    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;
        public bool isGraduated;
        public byte Point;
        public Student(string name, string surname, byte age, string gender, bool graduated, byte point)
        { 
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Point = point;
            isGraduated = graduated;
            if( graduated = true)
            {
                Console.WriteLine("You're graduated");
            }
            else { Console.WriteLine("You're student"); }

            if (point >= 80)
            {
                Console.WriteLine("You have chance for a second exam ");
            }
            else
            {
                Console.WriteLine("You missed your second chance ");
            }
        }
        public string GetInfo()
        {

            return $"Name:{Name} Surname: {Surname} Age: {Age} Gender: {Gender} Point: {Point} Is Graduated: {isGraduated} ";
        }
    }

}
           
        
    
