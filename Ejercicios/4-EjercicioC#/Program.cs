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
