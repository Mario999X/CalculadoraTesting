namespace CalculadoraApp.Calculadora
{
    public class Servicio
    {
        Calculadora Calculadora;

        public Servicio(Calculadora calculadora)
        {
            Calculadora = calculadora;
        }

        private bool Filter(string Num1, string Num2)
        {
            bool signal = false;

            if (int.TryParse(Num1, out _) && int.TryParse(Num2, out _))
            {
                Console.WriteLine("\t--Números identificados, realizando operación...\n");
                signal = true;
            }

            return signal;
        }

        public int? Suma(string Num1, string Num2)
        {
            if (Filter(Num1, Num2))
            {
                return Calculadora.Suma(int.Parse(Num1), int.Parse(Num2));
            }
            return null;
        }

        public int? Resta(string Num1, string Num2)
        {
            if (Filter(Num1, Num2))
            {
                return Calculadora.Resta(int.Parse(Num1), int.Parse(Num2));
            }
            return null;
        }

        public int? Multiplicar(string Num1, string Num2)
        {
            if (Filter(Num1, Num2))
            {
                return Calculadora.Multiplicar(int.Parse(Num1), int.Parse(Num2));
            }
            return null;
        }
        public int? Dividir(string Num1, string Num2)
        {
            if (Filter(Num1, Num2))
            {
                return Calculadora.Dividir(int.Parse(Num1), int.Parse(Num2));
            }
            return null;
        }

    }
}
