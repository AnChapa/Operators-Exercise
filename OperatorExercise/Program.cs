namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            int a = 17;
            int b = 4;

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}+{b} is {addition}");
            Console.WriteLine($"{a}-{b} is {subtraction}");
            Console.WriteLine($"{a}*{b} is {multiplication}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");

            //Thought Exercise

            // var is implicit type inferrence (more on this later)
            /*
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            */
            //Console.WriteLine(k); // ouputs 16 with i being 4 and j being 5 after the calculation
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
