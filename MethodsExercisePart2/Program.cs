using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercisePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math problems!");
            Console.WriteLine($"5410 + 2023 will equal: {Add(5410, 2023)}");
            Console.WriteLine($"754 - 249 will equal: {Subtract(754,249)}");
            Console.WriteLine($"60 * 67 will equal: {Multiply(60, 67)}");
            Console.WriteLine($"60 / 5 will equal: {Divide(60, 5)}");

        }

        public static int Add(int num7,int num8)
        {
            int add = num7 + num8;
            
            return add;
        }

                       
        public static int Subtract(int num5,int num6)

        { 
            int subtract = num5 - num6;
            
            return subtract;
        }
               
        public static int Multiply(int num1, int num2)
        {
            int Multiply = num1 * num2;
            
            return Multiply;
        }

        public static int Divide(int num3, int num4)
        {
            int Divide = num3 / num4;
            
            return Divide;
        }
        
        
    }
}