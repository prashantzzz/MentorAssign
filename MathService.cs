namespace MentorAssign
{
    public class MathService
    {
        public int Add(int a, int b) => a + b;

        public int Multiply(int a, int b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Error: Division by zero!");
            return a / b;
        }

        public int Subtract(int a, int b) => a - b;
    }
}
