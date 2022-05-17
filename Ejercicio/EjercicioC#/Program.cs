Console.WriteLine("2) Programa para la Calculadora V1: ");

int seguirOperando = 1, numOperacion = 0, num1, num2;

do
{
    Console.WriteLine("¿Qué operación desea realizar?");

    do
    {
        Console.WriteLine("1) Suma \n2) Resta \n3) Multiplicación \n4) División ");
        numOperacion = Convert.ToInt32(Console.ReadLine());
        
    } while (numOperacion < 1 || numOperacion > 4);

    Console.WriteLine("Ingrese los números a operar en el orden dado.");

    Console.WriteLine("Numero 1:");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Numero 2:");
    num2 = Convert.ToInt32(Console.ReadLine());

    if (numOperacion == 4)
    {
        do
        {
            Console.WriteLine("No esta definida la división en cero. Ingrese un divisor válido.");
            num2 = Convert.ToInt32(Console.ReadLine());
        } while (num2 == 0);
    }

    switch (numOperacion)
    {
        case 1: 
            Console.WriteLine($"El resultado de la suma es: {Sumar(num1,num2)}");
            break;
        case 2: 
            Console.WriteLine($"El resultado de la resta es: {Restar(num1,num2)}");
            break;
        case 3: 
            Console.WriteLine($"El resultado del producto es: {Multiplicar(num1,num2)}");
            break;
        case 4: 
            Console.WriteLine($"El resultado de la división es: {Dividir(num1,num2)}");
            break;
    }

    do
    {
        Console.WriteLine("¿Desea seguir usando la calculadora? (1: sí, 0: no)");
        seguirOperando = Convert.ToInt32(Console.ReadLine());

    } while (seguirOperando < 0 || seguirOperando > 1);

} while (seguirOperando == 1);


int Sumar(int num1, int num2){
    return num1+num2;
}

int Restar(int num1, int num2){
    return num1-num2;
}

int Multiplicar(int num1, int num2){
    return num1*num2;
}

int Dividir(int num1, int num2){
    return num1/num2;
}