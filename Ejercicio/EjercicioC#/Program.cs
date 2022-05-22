
Console.WriteLine("2) Programa para la Calculadora V1: ");

int seguirOperando = 1, numOperacion = 0;
double num1, num2;

do
{
    Console.WriteLine("¿Qué operación desea realizar?");

    do
    {
        Console.WriteLine("5) Calcular valor absoluto \n6) Calcular cuadrado del número \n7) Calcular raíz cuadrada \n8) Calcular seno del número \n9) Calcular coseno \n10) Obtener parte entera de un número en punto flotante ");
        numOperacion = Convert.ToInt32(Console.ReadLine());
        
    } while (numOperacion < 5 || numOperacion > 10);

    Console.WriteLine("Ingrese el número a operar: ");

    num1 = Convert.ToDouble(Console.ReadLine());

    if(numOperacion == 7){
        while(num1 < 0){
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo. Ingrese un número no negativo:");
            num1 = Convert.ToDouble(Console.ReadLine());

        }
    }

    switch (numOperacion)
    {
        case 5:
            Console.WriteLine($"El valor absoluto es: {Math.Abs(num1)}");
            break;
        case 6:
            Console.WriteLine($"El cuadrado del número es: {Math.Pow(num1,2)}");
            break;
        case 7:
            Console.WriteLine($"La raíz cuadrada del número es: {Math.Sqrt(num1)}");
            break;
        case 8:
            Console.WriteLine($"El seno del número es: {Math.Sin(num1)}");
            break;
        case 9:
            Console.WriteLine($"El coseno del número es: {Math.Cos(num1)}");
            break;
        case 10:
            Console.WriteLine($"La parte entera del float es: {Math.Truncate(num1)}");
            break;
    }

    Console.WriteLine("Ingrese dos números para calcular el máximo o el mínimo de los dos. Si los dos números son iguales, se retornará num1: ");
    
    Console.WriteLine("Número 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Número 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    do
    {
        Console.WriteLine("Calcular: 11) el máximo, 12) el mínimo ");

        numOperacion = Convert.ToInt32(Console.ReadLine());

    } while (numOperacion < 11 || numOperacion > 12);

    if(numOperacion == 11){
        Console.WriteLine($"El máximo número es {maximo(num1,num2)}");
    } else {
        Console.WriteLine($"El mínimo número es {minimo(num1,num2)}");
    }

    do
    {
        Console.WriteLine("¿Desea seguir usando la calculadora? (1: sí, 0: no)");
        seguirOperando = Convert.ToInt32(Console.ReadLine());

    } while (seguirOperando < 0 || seguirOperando > 1);

} while (seguirOperando == 1);

double minimo(double num1, double num2){
    if(num1<=num2){
        return num1;
    } else {
        return num2;
    }
}

double maximo(double num1, double num2){
    if(num1>=num2){
        return num1;
    } else {
        return num2;
    }
}