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
int calculadora(int operacion, int num1, int num2)
{
    /* int operacion, num1, num2; */
  /*   System.Console.WriteLine("--------Esta usando la calculadora--------");
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
        return (num1 + num2);
             System.Console.WriteLine("El resultado es:" + (num1 + num2)); 
            break;
        case 1:
        return (num1 - num2);
             System.Console.WriteLine("El resultado es:" + (num1 - num2)); 
            break;
        case 2:
        return (num1 / num2);
             System.Console.WriteLine("El resultado es:" + (num1 / num2)); 
            break;
        case 3:
        return (num1 * num2);
             System.Console.WriteLine("El resultado es:" + (num1 * num2)); 
            break;
        default:
             System.Console.WriteLine("No ingreso una operacion valida"); 
            break;
    }  */ 
    int resultado = 0;
    
    // Lógica de la calculadora
    switch (operacion)
    {
        case 1: // Suma
            resultado = num1 + num2;
            break;
        case 2: // Resta
            resultado = num1 - num2;
            break;
        case 3: // Multiplicación
            resultado = num1 * num2;
            break;
        case 4: // División
            resultado = num1 / num2;
            break;
        default:
            Console.WriteLine("Operación no válida");
            break;
    }
    
    return resultado;
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
void stringa(){
    string cadena, cadena2,cadena3,subcadena,buscada;
    int num;
    int operacion, num1, num2;
    System.Console.WriteLine("Ingrese la cadena de caracteres:");
    cadena=Console.ReadLine();
    num=cadena.Length;
    System.Console.WriteLine("La longitud de la cadena es:" + num);
    System.Console.WriteLine("Ingrese la segunda cadena de caracteres:");
    cadena2=Console.ReadLine();
    cadena3=cadena + cadena2;
    System.Console.WriteLine("La cadena despues de la union queda como:" + cadena3);
    subcadena=cadena3.Substring(1,4);
    System.Console.WriteLine("La subcadena es:"+subcadena);
    System.Console.WriteLine("--------Esta usando la calculadora--------");
    System.Console.WriteLine("Ingrese el primer numero a operar");
    int.TryParse(Console.ReadLine(), out num1);
    System.Console.WriteLine("Ingrese el segundo numero a operar");
    int.TryParse(Console.ReadLine(), out num2); 
    num=calculadora(1,num1,num2);
    System.Console.WriteLine("La suma de" + num1 + " y " + num2 + "es:" + num);
    foreach (char caracter in cadena3)
{
    Console.WriteLine(caracter);
}
System.Console.WriteLine("Ingrese la palabra buscada:");
buscada=Console.ReadLine();
if (cadena.Contains(buscada))
{
    System.Console.WriteLine("La palabra buscada se encuentra en la cadena");
}else
{
    System.Console.WriteLine("La palabra buscada no se encuentra en la cadena");
}
System.Console.WriteLine("La cadena en mayusculas es:" + cadena.ToUpper());
System.Console.WriteLine("La cadena en minusculas es:" + cadena.ToLower());
System.Console.WriteLine("Ingrese una cadena separada por caracteres:");
cadena = Console.ReadLine();
Console.WriteLine("Ingrese el carácter separador:");
string separador = Console.ReadLine();
string[] subcadenass = cadena.Split(separador);
Console.WriteLine("Resultados:");
foreach (string subcadenas in subcadenass)
{
    Console.WriteLine(subcadenas);
}
Console.WriteLine("Ingrese una ecuación simple (por ejemplo, '582+2'):");
string ecuacion = Console.ReadLine();

char operador = ecuacion.FirstOrDefault(c => c == '+' || c == '-' || c == '*' || c == '/');
int operador1=0;
switch (operador)
{
    case '+':
            operador1=1;
            break;
        case '-':
            operador1=2;
            break;
        case '*':
            operador1=3;
            break;
        case '/':
            operador1=4;
            break;
        default:
            Console.WriteLine("Operador no válido");
            break;

}
string[] operandos = ecuacion.Split(operador);
int.TryParse(operandos[0], out int num11);
int.TryParse(operandos[1], out int num21);
System.Console.WriteLine("El resultado es:"+calculadora(operador1,num11,num21)); 
}

/* invertirNum();

calculadora(); */
/* calculadoraV2();
 */
 