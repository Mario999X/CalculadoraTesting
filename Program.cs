using CalculadoraATestear;

Calculadora c = new();
Servicio s = new(c);
var salir = false;

while (!salir)
{
    Console.WriteLine("\nEscoga una opción: \n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n(OtrasOpciones).Salir");
    var opcion = Console.ReadLine();

    if (opcion == "1")
    {
        Console.WriteLine("\nEscriba los números de forma ordenada y en distintas líneas: ");
        var num1 = Console.ReadLine();
        var num2 = Console.ReadLine();

        Console.WriteLine("Resultado: " + s.Suma(num1, num2));

    }

    else if (opcion == "2")
    {
        Console.WriteLine("\nEscriba los números de forma ordenada y en distintas líneas: ");
        var num1 = Console.ReadLine();
        var num2 = Console.ReadLine();

        Console.WriteLine("Resultado: " + s.Resta(num1, num2));

    }

    else if (opcion == "3")
    {
        Console.WriteLine("\nEscriba los números de forma ordenada y en distintas líneas: ");
        var num1 = Console.ReadLine();
        var num2 = Console.ReadLine();

        Console.WriteLine("Resultado: " + s.Multiplicar(num1, num2));

    }

    else if (opcion == "4")
    {
        Console.WriteLine("\nEscriba los números de forma ordenada y en distintas líneas: ");
        var num1 = Console.ReadLine();
        var num2 = Console.ReadLine();

        Console.WriteLine("Resultado: " + s.Dividir(num1, num2));
    }

    else salir = true;
}
