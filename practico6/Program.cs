// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void invertirNum()
{
    int intnum1 = 0;
    bool anda = false;
    string? numString = "";

    while (!anda)
    {
        System.Console.WriteLine("Escriba un numero valido:");
        numString = Console.ReadLine();
        anda = int.TryParse(numString, out intnum1);

        if (!anda)
        {
            System.Console.WriteLine(numString + " No es un numero valido");
        }
    }

    if (intnum1 < 10)
    {
        System.Console.WriteLine("Numero invertido es: " + intnum1);
    }
    else
    {
        System.Console.WriteLine("Numero invertido es: ");
        while (intnum1 != 0)
        {
            int aux = intnum1 % 10;
            System.Console.Write(aux);
            intnum1 = intnum1 / 10;

        }
        System.Console.WriteLine();

    }

}
void calculadora()
{
    int operacion, num1, num2;
    System.Console.WriteLine("--------Esta usando la calculadora--------");
    System.Console.WriteLine("0-Suma");
    System.Console.WriteLine("1-Resta");
    System.Console.WriteLine("2-Division");
    System.Console.WriteLine("3-Multiplicacion");
    int.TryParse(Console.ReadLine(), out operacion);
    System.Console.WriteLine("Ingrese el primer numero a operar");
    int.TryParse(Console.ReadLine(), out num1);
    System.Console.WriteLine("Ingrese el segundo numero a operar");
    int.TryParse(Console.ReadLine(), out num2);
    switch (operacion)
    {
        case 0:
            System.Console.WriteLine("El resultado es:" + (num1 + num2));
            break;
        case 1:
            System.Console.WriteLine("El resultado es:" + (num1 - num2));
            break;
        case 2:
            System.Console.WriteLine("El resultado es:" + (num1 / num2));
            break;
        case 3:
            System.Console.WriteLine("El resultado es:" + (num1 * num2));
            break;
        default:
            System.Console.WriteLine("No ingreso una operacion valida");
            break;
    }
}
void calculadoraV2()
{
    double num1, num2, num3;
    System.Console.WriteLine("Ingrese el numero a operar");
    double.TryParse(Console.ReadLine(), out num1);
    System.Console.WriteLine("El numero en valor absoluto:" + Math.Abs(num1));
    System.Console.WriteLine("El cuadrado del numero es:" + (num1 * num1));
    System.Console.WriteLine("La raiz del numero es:" + Math.Pow(num1, 0.5));
    System.Console.WriteLine("El seno del numero es:" + Math.Sin(num1));
    System.Console.WriteLine("El coseno del numero es:" + Math.Cos(num1));
    System.Console.WriteLine("El numero en float a int es:" + ((int)num1));

    System.Console.WriteLine("Ingrese el primer numero a operar");
    double.TryParse(Console.ReadLine(), out num2);
    System.Console.WriteLine("Ingrese el segundo numero a operar");
    double.TryParse(Console.ReadLine(), out num3);
    System.Console.WriteLine("El maximo de los numeros ingresados es: " + Math.Max(num2, num3));
    System.Console.WriteLine("El minimo de los numeros ingresados es: " + Math.Min(num2, num3));


}

/* invertirNum();

calculadora(); */
calculadoraV2();
