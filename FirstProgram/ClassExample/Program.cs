using System;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.age = 100;
            human1.height = 200.0f;
            human1.gender = 'M';
            
            Human human2 = new Human();
            human2.age = 50;
            human2.height = 150.0f;
            human2.gender = 'W';

            human1.Sayage();
            human2.Sayage();

        }
    }
    class Human
    {
        public int age;
        public float height;
        public char gender;
        public void Sayage()
        {
            Console.WriteLine(age);
        }
    }

    class Human2
    {
        public int age;
        public float height;
        public char gender;
        public void Sayage()
        {
            Console.WriteLine(age);
        }
    }
}

