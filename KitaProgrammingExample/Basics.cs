using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaProgrammingExample
{
    internal class Basics
    {
        int number = 123;   //numbers like 1, 2, 69, 420, -5823, etc. positive or negative
        double numberWithDecimal = 123.123; //anything that has a decimal, positive or negative. Doesn't techincally have to have a decimal either
        float numberWithDecialButDontUse = 123.123f;    //like double, but holds less numbers. There's really not a need to use this one
        long numberButBig = 1234567890; //this is like int but holds more numbers. Can be useful in certain applications like a phone number
        string lotsOfLetters = "Hello, my name is Kita";    //this hold a long list of characters/letters usually in the form of words and sentances.
        char oneLetter = 'A';   //holds one letter
        bool trueOrFalse = true;    //holds a value of true or false
        int[] arrayOfNumbers = {1, 2, 3, 4, 5}; //array of size 5, each number in here is from 0-4
        string[] arrayOfStrings = {"Hello", "This", "Is", "Array" }; //array of size 4, each word is from 0-3

        public void Main()  //this is just here so I have a place to put my code
        {
            //if-else statements - one of the most used tools for a programmer. It can just be "if", "if-else", "if-else if-else" or any number of else-ifs included
            if(number != 69)    //if the number varible is not the number 69
            {
                Console.WriteLine("This is not based");
            }
            else
            {
                Console.WriteLine("Nice!");
            }

            //for loop - used when you want something to happen multiple times - but a set number, like you want to print a word 5 times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The number is: " + i);   //this Console.WriteLine(""); is used to print output to the IDE (Visua Studio) so you can see
            }

            //while loop - used to execute a function of some sort for as long as a certain condition is not met. You can be inside of a while loop the entire time.
            while (trueOrFalse != false)
            {
                Console.WriteLine("THIS WILL NEVER END");
            }

            //try-catch is used when your program will attempt to do something, but may fail and you expect that it may fail.
            try
            {
                Convert.ToInt32(lotsOfLetters); //this will try to make the string an int, which will break the program as it stands. If the string was "1" it could work
                Console.WriteLine("IT WORKED");
            }
            catch
            {
                Console.WriteLine("Uh oh! Not gonna work!");
            }

            //switch statements - they aren't used too often but can be handy on occasion
            int day = 1;
            switch (day)
            {
                case 1: //right now since our day variable is = 1, this is what will happen. 
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4: //if our variable changed to 4, then this one would happen
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        public void MakeSomethingHappen()   //this is a method, you've got 3 main parts, the access level (public or private), the return type (int, string, double, bool, or void if you don't return anything), the name, and then inside the parentheses if you need it to accept any data
        {
            //becasue this is a void type, we won't return anything, but we'll have it do something
            Console.WriteLine("You called a method!");
        }

        public int ThisWillAddTwoIntegers(int number1, int number2)
        {
            return number1 + number2; //in this because my return type is not void, it is int, I must return a value and I need to literally use "return" and whatever the date type I set in the method. You can also see in my method I have 2 integers which I can use inside my method.
        }

        //if I want to call a method I need to do this:
        public void Main2()
        {
            ThisWillAddTwoIntegers(1, 4);   //this is add the two numbers, but won't do anything with it really. To make it useful, do this:
            int addedNumbers = ThisWillAddTwoIntegers(1, 4);   //now we have the result stored somewhere useful!

            //you can also send variables to the method
            int thisIsANumber = 53;
            int thisIsAnotherNumber = 23;
            int resultOfThose = ThisWillAddTwoIntegers(thisIsANumber, thisIsAnotherNumber); //notice how I don't have to name the variables what I named them in the method declaration before (number1 and number2) they don't have to match names, only variable types

            //to use the void one, we only have to call it
            MakeSomethingHappen();
        }


    }
}
