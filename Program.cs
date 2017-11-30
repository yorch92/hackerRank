using System;
using System.Collections.Generic;
using System.IO;

namespace hackerRank
{

    class Person {
        public int age;     
        public Person(int initialAge) {
            // Add some more code to run some checks on initialAge
            if(initialAge < 0){
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            } else {
                age = initialAge;
            }
        }
        public void amIOld() {
            // Do some computations in here and print out the correct statement to the console 
            if(age < 13) {
                Console.WriteLine("You are young.");
            } else if (age >= 13 && age < 18) {
                Console.WriteLine("You are a teenager.");
            } else {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses() {
            // Increment the age of the person in here
            age++;
        }
    }

    class Program
    {
        static void dayZero() { 
            // Declare a variable named 'inputString' to hold our input.
            String inputString; 
            
            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine(); 
            
            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");
            
            // TODO: Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);
        }
        static void dayOne() {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
                    
            // Declare second integer, double, and String variables.
            int sI;
            double sD;
            string sS;

            // Read and save an integer, double, and String to your variables.
            sI = Convert.ToInt32(Console.ReadLine());
            sD = Convert.ToDouble(Console.ReadLine());
            sS = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine("{0}", i + sI);

            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:0.0}", d + sD);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine("{0}", s + sS);
        }
        static void dayTwo(){
            double mealCost;
            double tip;
            double tax;
            double totalCost;
            double tipPercentage;
            double taxPercentage;

            mealCost = Convert.ToDouble(Console.ReadLine());
            tip = Convert.ToDouble(Console.ReadLine());
            tax = Convert.ToDouble(Console.ReadLine());

            tipPercentage = calculatePercentage(mealCost, tip);
            taxPercentage = calculatePercentage(mealCost, tax);
            totalCost = mealCost + tipPercentage + taxPercentage;

            Console.WriteLine("The total meal cost is {0:0} dollars.", totalCost);
        }
        static double calculatePercentage(double total, double percentage){
            return (total * (percentage / 100));
        }
        static void dayThree(){
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 != 0) {
                Console.WriteLine("Weird");
            } else if ( (N % 2 == 0) && (N >= 2 && N <= 5 ) ) {
                Console.WriteLine("Not Weird");
            } else if ( (N % 2 == 0) && (N >= 6 && N <= 20 ) ) {
                Console.WriteLine("Weird");
            } else if ( (N % 2 == 0) && (N > 20) ) {
                Console.WriteLine("Not Weird");
            }
        }
        static void dayFour() {
            // int T = int.Parse(Console.In.ReadLine());
            // for(int = i; i < T; i++) {
            //     int age=int.Parse(Console.In.ReadLine());
            //     Person p=new Person(age);
            //     p.amIOld();
            //     for (int j = 0; j < 3; j++) {
            //       p.yearPasses();
            //     }
            //     p.amIOld();
            //     Console.WriteLine();
            // }
        }
        static void dayFive() {
            int n = Convert.ToInt32(Console.ReadLine());
        
            for(int i = 1; i <= 10; i++){
                Console.WriteLine("2 x {0} = " + n * i, i);
            }
        }
        static void Main(string[] args)
        {
            // dayZero();
            // dayOne();
            // dayTwo();
            // dayThree();
            // dayFour();
            dayFive();
        }
    }
}
