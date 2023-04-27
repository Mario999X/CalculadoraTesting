namespace CalculadoraApp.Calculadora
{
    public interface ICalculadora
    {
        int Suma(int Num1, int Num2);

        int Resta(int Num1, int Num2);

        int Multiplicar(int Num1, int Num2);

        int? Dividir(int Num1, int Num2);


    }
}
