

Console.WriteLine("4) Programa trabajando con el tipo string:");

Console.WriteLine("Ingrese una cadena: ");
string cadena1 = Console.ReadLine();

// CONSULTA: ¿A qué se refiere con obtener algunas letras que forman parte de la cadena?

// Obtener la longitud de la cadena:

int longitudCadena = cadena1.Length;

Console.WriteLine($"La longitud de la cadena es {longitudCadena}");

Console.WriteLine("Ingrese otra cadena: ");
string cadena2 = Console.ReadLine();

// Concatenar cadenas
string cadenaConcatenada = cadena1+cadena2;

Console.WriteLine("La cadena concatenada es: ");
Console.WriteLine(cadenaConcatenada);

// Obtengo una subcadena de la cadenaConcatenada

string subcadena = cadenaConcatenada.Substring(longitudCadena);
// Se obtendrá en realidad la segunda cadena.

Console.WriteLine("Obtengo una subcadena de la cadena concatenada: ");
Console.WriteLine(subcadena);

Console.WriteLine("Muestro caracter a caracter:");

foreach (char letra in cadenaConcatenada)
{
    Console.Write(letra+"-");
}

Console.WriteLine($"\nLa cantidad de veces que aparece la letra a en la cadena concatenada es: {contarOcurrencias(cadenaConcatenada,'a')}");

Console.WriteLine("Convierto la cadena a minúsculas:");
Console.WriteLine(cadenaConcatenada.ToLower());

Console.WriteLine("Convierto la cadena a mayúsculas:");
Console.WriteLine(cadenaConcatenada.ToUpper());

Console.WriteLine("Ingrese una nueva cadena, se comparará con la cadena concatenada:");

string nuevaCadena = Console.ReadLine();

Console.WriteLine($"Comparando con == : {nuevaCadena == cadenaConcatenada}");

Console.WriteLine($"Comparando con Equals: {String.Equals(cadenaConcatenada,nuevaCadena)}");

Console.WriteLine($"Comparando con Compare: {String.Compare(cadenaConcatenada,nuevaCadena)}");

Console.WriteLine("Ingrese una cadena de nombres separada por comas y espacios: ");

string pruebaSplit = Console.ReadLine();

string[] arregloSplit = pruebaSplit.Split(", ");

Console.WriteLine("El resultado obtenido es: ");

foreach (string subCadena in arregloSplit)
{
    Console.WriteLine(subCadena);
}


Console.WriteLine("Indique una operación aritmética básica a realizar (suma, resta, multiplicación o división): ");

string operacion = Console.ReadLine();

if(operacion.Contains('+')){
    double resultado = Convert.ToDouble(operacion.Split('+')[0]) + Convert.ToDouble(operacion.Split('+')[1]);
    Console.WriteLine("El resultado de la operación es " + resultado);
}

if(operacion.Contains('-')){
    double resultado = Convert.ToDouble(operacion.Split('-')[0]) - Convert.ToDouble(operacion.Split('-')[1]);
    Console.WriteLine("El resultado de la operación es " + resultado);
}

if(operacion.Contains('*')){
    double resultado = Convert.ToDouble(operacion.Split('*')[0]) * Convert.ToDouble(operacion.Split('*')[1]);
    Console.WriteLine("El resultado de la operación es " + resultado);
}

if(operacion.Contains('/')){
    if(Convert.ToDouble(operacion.Split('/')[0]) == 0){
        Console.WriteLine("No está definida la división en cero");
    } else {
        double resultado = Convert.ToDouble(operacion.Split('/')[0]) / Convert.ToDouble(operacion.Split('/')[1]);
        Console.WriteLine("El resultado de la operación es " + resultado);
    }
}

Console.Read();

// Funciones

int contarOcurrencias(string cadena, char buscar){
    int contador = 0;
    foreach (char letra in cadena)
    {
        if(letra == buscar) contador++;
    }
    return contador;
}   

