using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace ValidationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.    

            //What will the application do?   
            //● Provide information about students in a class  
            //● Prompt the user to ask about a particular student    
            //● Give proper responses according to user-submitted information    
            //● Ask if user would like to learn about another student   

            //Build Speciﬁcations   
            //1. Account for invalid user input with exceptions   
            //2. Try to incorporate IndexOutOfRangeException and FormatException

            string[] students = { "Randy", "Gina", "Frank", "Joe" };
            string[] food = { "Ramen", "Ice Cream", "Daft Punk Pizza", "Lasagna" };
            string[] color = { "Red", "Purple", "Green", "Blue" };
            string cont = "y";
            Console.WriteLine("Welcome to the C# Class!!");
            do
            {
                try
                {
                    Console.WriteLine("Which student would you like to learn about? (enter a number 0-3)");
                    int studentChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Student {studentChoice} is {students[studentChoice]}, what would you like to learn about them? (Enter Food or Color)");
                    string choiceOne = Console.ReadLine().ToLower();
                    string contTwo = "y";
                    do
                    {
                        if (choiceOne == "food")
                        {
                            Console.WriteLine($"{students[studentChoice]}'s favorite food is {food[studentChoice]}");
                            contTwo = "n";
                        }
                        else if (choiceOne == "color")
                        {
                            Console.WriteLine($"{students[studentChoice]}'s favorite color is {color[studentChoice]}");
                            contTwo = "n";
                        }
                        else
                        {
                            Console.WriteLine("That is not valid input, try again (Food or Color)");
                            choiceOne = Console.ReadLine().ToLower();
                        }
                    } while (contTwo == "y");

                    Console.WriteLine("Would you like learn more? (y/n)");
                    cont = YesOrNoValidation(Console.ReadLine().ToLower());
                    if (cont == "y")
                    {
                        if (choiceOne == "food")
                        {
                            Console.WriteLine($"{students[studentChoice]}'s favorite color is {color[studentChoice]}");
                        }
                        else if (choiceOne == "color")
                        {
                            Console.WriteLine($"{students[studentChoice]}'s favorite food is {food[studentChoice]}");
                        }
                    }
                    Console.WriteLine("Would you like to learn about another student? (y/n)");
                    cont = YesOrNoValidation(Console.ReadLine().ToLower());
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter valid input");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid input");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter valid input");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter valid input");
                }

            } while (cont == "y");

            Console.WriteLine("Goodbye!");
        }


        public static string YesOrNoValidation(string input)
        {
            input = input.ToLower();
            string go = "y";


            do
            {
                try
                {
                    if (input == "y" || input == "n")
                    {
                        go = "n";
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input (y/n)");
                        input = Console.ReadLine();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter valid input");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid input");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter valid input");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter valid input");
                }
            } while (go == "y");

            return input;
        }
    }

}
