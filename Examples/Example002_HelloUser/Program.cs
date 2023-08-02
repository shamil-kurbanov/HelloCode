//write console app, where user should enter his name and age
//and then program should print out "Hello, <name>, your age is <age>, after 10 years you will be <age+10> years old"

using System;
using static System.Console;

//write console app, where user should enter his name
//and then program should print out "Hello, <name>"

namespace Example002_HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string name;
            int age;
            WriteLine("Enter your name:");
            name = ReadLine();
            WriteLine("Enter your age:");
            age = Convert.ToInt32(ReadLine());
            WriteLine($"Hello, {name}, your age is {age}");
            ReadKey();*/

            string name;
            int age;

            try{
                WriteLine("Enter your name: ");
                name = ReadLine();

                WriteLine("Enter your age: ");
                age = Convert.ToInt32(ReadLine());

                WriteLine("Hello, {0}, your age is {1}", name, age);

                ReadKey();
            } catch (Exception e){
                WriteLine("Error: {0}", e.Message);
            }
        }
    }
}