using System;
using System.Reflection;

class ConditionalStatement
{
    static void Main(string[] args)
    {
        //if statement
        //1
        int age1 = 20;
        if (age1 > 18)
        {
            Console.WriteLine("You are eligible for vote");
        }

        //2
        int x = 100;
        int y = 20;
        if (x > y)
        {
            Console.WriteLine(x + " is greater than " + y);
        }


        //if else statement
        //1 (find even or odd)
        int num = 10;
        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is an even Number!");
        }
        else
        {
            Console.WriteLine(num + " is an odd Number!"); 
        }

        //2 (Possitive or Negative Number)

        int num1 = -2; 
        if(num1 < 0)
        {
            Console.WriteLine(num1 + " is a Negative Number!");
        }
        else
        {
            Console.WriteLine(num1 + " is a Posstive Number!"); 
        }

        //if else if statement 

        //1 ->Assigning grades based on percentage: Write a program that takes a percentage as input and assigns a
        //grade based on predefined ranges(e.g., 90 - 100 for A, 80 - 89 for B, etc.).

        int grade = 70; 

        if(grade < 100 &&  grade >= 90)
        {
            Console.WriteLine("Grade A "); 
        }
        else if(grade < 90 &&  grade >= 80)
        {
            Console.WriteLine("Grade B "); 
        }
        else if(grade < 80 && grade >= 70)
        {
            Console.WriteLine("Grade C "); 
        }
        else
        {
            Console.WriteLine("Fail ") ;
        }

        //2 -> Age group classification
        int age = 21; 
        if(age <= 12 && age >= 0)
        {
            Console.WriteLine("You are child !"); 
        }
        else if(age <= 19 &&  age >= 13)
        {
            Console.WriteLine("You are Teenager !"); 
        }
        else if(age <= 64 && age >= 20)
        {
            Console.WriteLine("You are Adult !"); 
        }
        else
        {
            Console.WriteLine("You are senior !"); 
        }
        //Nested if else statement 


        // 1 -> Determining the greatest of two or three numbers: Create a program that takes two or three numbers as
        //input and determines which one is the greatest.

        int n1 = 100;
        int n2 = 260;
        int n3 = 30; 

        if(n1 > n2)
        {
            if(n1 > n3)
            {
                Console.WriteLine(n1 + " is greatest number !"); 
            }
            else
            {
                Console.WriteLine(n3 + " is greatest number !"); 
            }
        }
        else
        {
            if(n2 > n3)
            {
                Console.WriteLine(n2 + " is greatest number !");
            }
            else
            {
                Console.WriteLine(n3 + " is greatest number !"); 
            }
        }

        //2 -> Age and Gender Classification: Write a program that takes a person’s age and gender as inputs. Using
        //nested if-else statements, classify the person into different categories:
        //If the person is under 18, classify them as a "Minor".
        //If the person is 18 or older, check if they are male or female:
        //If male, print "Adult Male".
        //If female, print "Adult Female".

        int Age = 19;
        string gender = "female";
        if (Age < 18)
        {
            Console.WriteLine("You are Minor !");
        }
        else if(Age >= 18)
        {
            if(gender == "male")
            {
                Console.WriteLine("Adult Male "); 
            }
            else if(gender == "female")
            {
                Console.WriteLine("Adult Female "); 
            }
            else
            {
                Console.WriteLine("Wrong Choice "); 
            }
        }
        else
        {
            Console.WriteLine("Wrong Choice"); 
        }


        //switch case 
        //1 ->Determining the day of the week: Write a program that takes a day number(1 - 7) as input and prints the
        //corresponding day of the week.

        int day = 2;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break; 
            case 2:
                Console.WriteLine("Tuesday");
                break; 
            case 3:
                Console.WriteLine("Wednesday"); 
                break;
            case 4:
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
            default:
                Console.WriteLine("Please provide number between 1 - 7"); 
                break;
        }

        //2 -> Simple calculator: add , substract , multiply , division

        //1 -> Add 
        //2 -> Substract
        //3 -> Multiply
        //4 -> Division

        int n = 3;
        int a = 20;
        int b = 30;
        int add, subs, mul, div, mod; 

        switch (n)
        {
            case 1:
                add = a + b;
                Console.WriteLine("Addition : " + add);
                break; 
            case 2:
                subs = a - b;
                Console.WriteLine("Substraction : " + subs);
                break; 
            case 3:
                mul = a * b;
                Console.WriteLine($"Multiplication : {mul}");
                break; 
            case 4:
                div = a / b;
                Console.WriteLine($"Division : {div}");
                break; 
            case 5:
                mod = a % b;
                Console.WriteLine($"Modulus : {mod}");
                break;
            default:
                Console.WriteLine("Please enter correct number from 1 to 5");
                break;

        }

        //Nested Switch Case 
        //Write a program that asks the user for the day of the week(1 - 7).Then, based on the day, it offers a meal suggestion for breakfast, lunch, or dinner:
        //1 - 5: Workdays – Breakfast, Lunch, and Dinner options.
        //6 - 7: Weekend – Brunch and Dinner options.

        int Day = 5;
        switch (Day)
        {
            //1 - 5 : workdays
            //6 - 7 : weekend
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                switch( Day )
                {
                    case 1:
                        Console.WriteLine("BreakFast: Oats, Lunch: Sandwitch, Dinner: Pasta");
                        break; 
                    case 2:
                        Console.WriteLine("BreakFast: Eggs, Lunch: Salad, Dinner: Soup");
                        break;                    
                    case 3:
                        Console.WriteLine("BreakFast: Pancakes, Lunch: Rice, Dinner: Steak");
                        break; 
                    case 4:
                        Console.WriteLine("BreakFast: Toast, Lunch: Pasta, Dinner: Pizza");
                        break;                    
                    case 5:
                        Console.WriteLine("BreakFast: Chawal, Lunch: Dal, Dinner: Chatni");
                        break; 
                }
                break;
            case 6:
            case 7:
                switch (Day)
                {
                    case 6:
                        Console.WriteLine("Omelette , BBQ");
                        break; 
                    case 7:
                        Console.WriteLine("Pancakes, Chicket");
                        break; 
                }
                break;
            default:
                Console.WriteLine("Invalid day! Please enter correct number of day");
                break; 
        }
    }
}
