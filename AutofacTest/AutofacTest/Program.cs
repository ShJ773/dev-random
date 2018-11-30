using System;
using Autofac;

namespace AutofacTest
{

    // interface class for calculator
    public interface ICalculator

    {
        int Calculate(int a, int b);
    }

    // implementation for addition
    public class CalculatePlus : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }

    // implementation for multiply
    public class CalculateMultiply : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a * b;
        }
    }

    // implementation
    public class CalculateRR : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return (7*a) - (3*b);
        }
    }

    class Program
    {
        private static IContainer container { get; set; }

        static void Main(string[] args)
        {

            // just test
            CalculateMultiply multi = new CalculateMultiply();
            CalculatePlus plus = new CalculatePlus();
            Console.WriteLine("Hello Calculate");
            Console.WriteLine(plus.Calculate(3, 5));
            Console.WriteLine(multi.Calculate(3, 5));

            // autofac
            Console.WriteLine("Hello Autofac");
            var builder = new ContainerBuilder();
            builder.RegisterType<CalculatePlus>().As<ICalculator>();
            container = builder.Build();     

            var calculator1 = container.Resolve<ICalculator>();
            Console.WriteLine(calculator1.Calculate(3, 5));

            // after Build(), new ContainerBuilder needed to register
            var builder2 = new ContainerBuilder();
            builder2.RegisterType<CalculateMultiply>().As<ICalculator>();
            container = builder2.Build();

            var calculator2 = container.Resolve<ICalculator>();
            Console.WriteLine(calculator2.Calculate(3, 5));

        }
    }
}
