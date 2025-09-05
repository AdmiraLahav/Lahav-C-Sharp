using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Please dont enter a number bigger than 2,147,483,647 pwease");
        //first number
        Console.WriteLine("Enter First Number:");
        int FirstNumber = int.Parse(Console.ReadLine());
        //second number
        Console.WriteLine("Enter Second Number:");
        int SecondNumber = int.Parse(Console.ReadLine());
        //sign
        Console.WriteLine("Enter Sign:");
        //create a list of all possible characters
        char[] value = { '+', '-', '*', '/'};
        // ask user for the sign he wants to use and read only the first character -> [0]
        char ReqSign = Console.ReadLine()[0];
        //check if the sign inputed (ReqSign) is equal to the first character in the list -> value[0] if not, skip and move on
        if (ReqSign == value[0])
        {
            Console.WriteLine(FirstNumber + SecondNumber);
        }
        //check if it is the second character in the list and so on
        else if (ReqSign == value[1])
        {
            Console.WriteLine(FirstNumber - SecondNumber);
        }
        else if (ReqSign == value[2])
        {
            Console.WriteLine(FirstNumber * SecondNumber);
        }
        else if (ReqSign == value[3])
        {

            //check if division by 0
            if (SecondNumber == 0)
            {
                Console.WriteLine("Division by 0 is not allowed");
            }
            Console.WriteLine(FirstNumber / SecondNumber);
        }
        else
        {
            Console.WriteLine("No allowed sign given");
        }
    }
}
