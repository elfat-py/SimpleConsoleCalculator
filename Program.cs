using System;


namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string arthOperator;
            Boolean repeat = true;
            while (repeat)
            {
                //We are asking the user for two numbers
                (double firstNum, double secNum) = Numbers();
                Console.WriteLine("Enter the method you want to use: (+, -, /, *) ");
                arthOperator = Console.ReadLine();
                (double finalVal, string operation) = ArthmeticOperation(arthOperator, firstNum, secNum);
                Console.WriteLine($"The total from the {operation} is : {finalVal}");
                repeat = AnotherCalculation();
            }
        }
        
        

        public static (double, double) Numbers()
        {
            double firstNumber, secondNumber;

            Console.WriteLine("Enter the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            return (firstNumber, secondNumber);
        }
    

        public static (double, string) ArthmeticOperation(string arthOp, double firstNumber, double secondNumber)
        {
            string operation;
            double? result;
      
            if (arthOp == "+")
            {
                result = Addition(firstNumber, secondNumber);
                operation = "Addition";
                
            }else if (arthOp == "-")
            {
                result = Subtraction(firstNumber, secondNumber);
                operation = "Subtraction";
            }else if (arthOp == "/")
            {
                result = Division(firstNumber, secondNumber);
                operation = "Division";
            }else if (arthOp == "*")
            {
                result = Multiplication(firstNumber, secondNumber);
                operation = "Multiplication";
            }
            else
            {
                Console.WriteLine("Please check the arthmetic operator");
                result = null;
                operation = "None";
            }

            return ((double)result, operation);
        }

        public static double Subtraction(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        public static double Addition(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        public static double Division(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }

        public static double Multiplication(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }

        public static Boolean AnotherCalculation()
        {
            Console.WriteLine("You want to go again: ");
            return Convert.ToBoolean(Console.ReadLine());
        }
    }
}