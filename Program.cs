namespace BASIC_CALCULTOR_PROGRAM.C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  CALCULATOR  ");
            Console.WriteLine();
            Console.WriteLine("ENTER A TWO NUMBERS TO CALCULATE: ");
            double a, b, add, sub, mul, div;
            int ch;
            a=Convert.ToDouble(Console.ReadLine());
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("PRESS 1) FOR ADDITON:");
            Console.WriteLine("PRESS 2) FOR SUBTRACTION:");
            Console.WriteLine("PRESS 3) FOR MULTIPLICATION:");
            Console.WriteLine("PRESS 4) FOR DIVISION:");
           

            Console.WriteLine("ENTER YOUR CHOICE:");
            ch = Convert.ToInt32(Console.ReadLine());
            if(ch==1)
            {
                add = a + b;
                Console.WriteLine("THE SUM OF TWO NUMBERS IS = " + add);
            }
           else if (ch == 2)
            {
                sub = a + b;
                Console.WriteLine("THE SUBTRACTION OF TWO NUMBERS IS = " + sub);
            }
           else if (ch == 3)
            {
                mul = a * b;
                Console.WriteLine("THE MULTIPLICATION OF TWO NUMBERS IS = " + mul );
            }
           else if (ch == 4)
            {
                div = a / b;
                Console.WriteLine("THE DIVISION OF TWO NUMBERS IS = " + div);
          
            }
            else
            {
                Console.WriteLine("INVALID CHOICE:");
            }
           
        }
    }
}
