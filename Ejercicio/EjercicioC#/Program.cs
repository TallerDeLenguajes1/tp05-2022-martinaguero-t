Console.WriteLine("1) Programa para invertir un número de N cifras:");

Console.WriteLine("Ingrese el número a invertir:");

int num = Convert.ToInt32(Console.ReadLine());
// Se lee el numero ingresado por el usuario

int numReverso = 0;
int ultimoDigito = 0;

while(num > 0 && num != 0){

    ultimoDigito = num % 10;
    // Obtengo el último digito del numero

    numReverso = numReverso * 10 + ultimoDigito;
    // En el número reverso voy guardando los números cada vez multiplicando por 10 para luego sumar el último digito a añadir 

    num = num/10;
    // Divido el numero original en 10 de manera sucesiva

}

Console.WriteLine($"El número reverso es {numReverso}. Si ingresó un número menor o igual a cero se muestra como resultado 0.");