using Delegates.Services;

namespace Delegates
{

    //delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperation(double n1, double n2);


    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            //double result = op.Invoke(a, b);
            //Console.WriteLine(result);

            //op.Invoke(a, b);                    
            op(a, b); // Funciona igual o de cima  /\
        }
    }
}
