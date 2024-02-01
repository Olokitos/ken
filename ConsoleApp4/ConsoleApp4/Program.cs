using System;
namespace gengeng
{

    public class Meth
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("Add= " + (num1 + num2));
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine("Sub= " + (num1 - num2));
        }
        public void Mult(int num1, int num2)
        {
            Console.WriteLine("Mult= " + (num1 * num2));
        }
        public void Div(int num1, int num2)
        {
            Console.WriteLine("Div= " + (num1 / num2));
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Meth math = new Meth();

            int num1, num2;
           
            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2:");
            num2 = int.Parse(Console.ReadLine());

            math.Add(num1, num2);
            math.Sub(num1, num2);
            math.Mult(num1, num2);
            math.Div(num1, num2);   
        }
    }
}