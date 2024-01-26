/*
 * Author: Logan Jones
 * Course: COMP-003A-L01
 * Purpose: Writing examples of different basic computing processes for Week 2 Assignments. 
 */


namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor= ConsoleColor.White;

            Console.WriteLine("******************************");

            Console.WriteLine("Please enter your first name below.");
            string firstName= Console.ReadLine();
            Console.WriteLine("Please enter your middle name below. (Or press enter if you don't have one)");
            string middleName= Console.ReadLine();
            Console.WriteLine("Please enter your last name below.");
            string lastName= Console.ReadLine();
            Console.WriteLine("How old will you turn in 2024?");
            string inputAge= Console.ReadLine();
            int yearBorn= 2024 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName} . You were born in {yearBorn}.");

            Console.WriteLine("****************************************");

            Console.WriteLine("Input a number ");
            String input1= Console.ReadLine();
            int integer1= Convert.ToInt32(input1);

            Console.WriteLine("Input a second number ");
            String input2 = Console.ReadLine();
            int integer2 = Convert.ToInt32(input2);
           
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {(Convert.ToDecimal(integer1)) / (Convert.ToDecimal(integer2))}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            Console.WriteLine("Please enter the radius");
            double radius= Convert.ToDouble(Console.ReadLine() );
            double area= Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is: {area}.");
            double circumference = Math.PI * 2 * radius;
            Console.WriteLine($"The circumference of the circle is: {circumference}.");

            Console.WriteLine("Thank you for coming to my TEDTalk");
            Console.Beep(440, 160);

        }
    }
}
