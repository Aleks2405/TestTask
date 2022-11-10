namespace ClassLibraryTest
{
    public interface IFigure
    {
        void AreaOfThe(double[] numbers);
    }
    public class Circle : IFigure
    {
        public void AreaOfThe(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < 1; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                result += numbers[i];
            }
            Console.WriteLine($"Площадь вашего круга = {3.14 * result * result}");
        }
    }
    public class Square : IFigure
    {
        public void AreaOfThe(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                result += numbers[i];
            }
            double p = result / 2;
            double S = p * (p - numbers[0]) * (p - numbers[1]) * (p - numbers[2]);
            Console.WriteLine($" Плоащадь Вашего треугольника = {Math.Sqrt(S)}");
  
            if (Math.Pow(numbers[2],2) == Math.Pow(numbers[0], 2)+ Math.Pow(numbers[1], 2) ||
                Math.Pow(numbers[0], 2) == Math.Pow(numbers[2], 2) + Math.Pow(numbers[1], 2) ||
                Math.Pow(numbers[1], 2) == Math.Pow(numbers[0], 2) + Math.Pow(numbers[2], 2))
            {
                Console.WriteLine("Треугольник является прямоугольным");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным");
            }
        }
    }
        public class Rectangle : IFigure
        {
            public void AreaOfThe(double[] numbers)
            {
                double result = 1;
                for (int i = 0; i < 2; i++)
                {
                    numbers[i] = double.Parse(Console.ReadLine());
                    result *= numbers[i];
                }
                Console.WriteLine($"площадь квадрата = {result}");
            }
        }  
}