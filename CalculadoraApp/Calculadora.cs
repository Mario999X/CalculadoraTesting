namespace CalculadoraApp.Calculadora
{
    public class Calculadora : ICalculadora
    {

        public Calculadora()
        {
        }

        virtual public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        virtual public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }
        virtual public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        virtual public int? Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error, se intentó dividir entre 0");
                return null;
            }
            return num1 / num2;
        }

    }
}
