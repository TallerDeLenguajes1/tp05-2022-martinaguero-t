﻿
Console.WriteLine("2) Programa para la Calculadora: ");

int seguirOperando = 1, numOperacion = 0;
double num1, num2;

do
{
    Console.WriteLine("¿Qué operación desea realizar?");

    do
    {
        Console.WriteLine("1) Suma \n2) Resta \n3) Multiplicación \n4) División\n5) Calcular valor absoluto de un número \n6) Calcular cuadrado de un número \n7) Calcular raíz cuadrada un número \n8) Calcular seno de un número \n9) Calcular coseno de un número \n10) Obtener parte entera de un número en punto flotante \n11) Calcular máximo entre dos números \n12) Calcular mínimo entre dos números");
        numOperacion = Convert.ToInt32(Console.ReadLine());
        
    } while (numOperacion < 1 || numOperacion > 12);

    if(numOperacion <= 4 || numOperacion >= 11){
        // Para operaciones binarias
        Console.WriteLine("Ingrese los números a operar (para operaciones no conmutativas se respeta el orden en que se ingresan): ");

        Console.WriteLine("Numero 1:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Numero 2:");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (numOperacion == 4)
        {
            while(num2 == 0){
                Console.WriteLine("No esta definida la división en cero. Ingrese un divisor válido.");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
        }

        switch (numOperacion)
        {
            case 1: 
                Console.WriteLine($"El resultado de sumar {num1} y {num2} es: {Sumar(num1,num2)}");
                break;
            case 2: 
                Console.WriteLine($"El resultado de restar {num1} y {num2} es: {Restar(num1,num2)}");
                break;
            case 3: 
                Console.WriteLine($"El resultado del producto de {num1} por {num2} es: {Multiplicar(num1,num2)}");
                break;
            case 4: 
                Console.WriteLine($"El resultado de la división de {num1} en {num2} es: {Dividir(num1,num2)}");
                break;
            case 11:
                Console.WriteLine($"El máximo número entre {num1} y {num2} es {maximo(num1,num2)}");
                break;
            case 12:
                Console.WriteLine($"El mínimo número entre {num1} y {num2} es {minimo(num1,num2)}");
                break;
        }

    } else {
        // Para operaciones unarias
        Console.WriteLine("Ingrese el número a operar: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        if(numOperacion == 7){
            while(num1 < 0){
                Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo. Ingrese un número no negativo:");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
        }

        switch(numOperacion){
            case 5:
                Console.WriteLine($"El valor absoluto de {num1} es: {Math.Abs(num1)}");
                break;
            case 6:
                Console.WriteLine($"El cuadrado de {num1} es: {Math.Pow(num1,2)}");
                break;
            case 7:
                Console.WriteLine($"La raíz cuadrada de {num1} es: {Math.Sqrt(num1)}");
                break;
            case 8:
                Console.WriteLine($"El seno de {num1} es: {Math.Sin(num1)}");
                break;
            case 9:
                Console.WriteLine($"El coseno de {num1} es: {Math.Cos(num1)}");
                break;
            case 10:
                Console.WriteLine($"La parte entera del float {num1} es: {Math.Truncate(num1)}");
                break;
        }
    }
    
    do
    {
        Console.WriteLine("¿Desea seguir usando la calculadora? (1: sí, 0: no)");
        seguirOperando = Convert.ToInt32(Console.ReadLine());

    } while (seguirOperando < 0 || seguirOperando > 1);

} while (seguirOperando == 1);



double Sumar(double num1, double num2){
    return num1+num2;
}

double Restar(double num1, double num2){
    return num1-num2;
}

double Multiplicar(double num1, double num2){
    return num1*num2;
}

double Dividir(double num1, double num2){
    return num1/num2;
}

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