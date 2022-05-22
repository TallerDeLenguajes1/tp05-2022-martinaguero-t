# Trabajo Práctico N°5

(martinaguero-t - Martin Agüero Trevisan)

## Preguntas sobre el tipo _string_

---

- **¿String es un tipo por valor o un tipo por referencia?**

String es un tipo por referencia pero es inmutable, es decir, una vez que se asigna un valor a una variable de tipo string, no puede ser modificado. Si se "modifica" el contenido de una variable de tipo string, en realidad se está creando una nueva cadena de caracteres y la referencia a la anterior cadena se pierde (a menos que haya sido asignada a otra variable).

_Ver en: <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#immutability-of-strings>_

Por ejemplo:

~~~~C#
...
string cadena1 = "Soy una cadena";
string cadena2 = cadena1;

string cadena1 = "Ahora soy otra cadena";
...
~~~~

Siguiendo el razonamiento anterior se ve que cadena1 ahora referencia a otra cadena (_"Ahora soy otra cadena"_) distinta de la cadena original. La referencia de la cadena1 original fue almacenada en cadena2.

- **¿Qué secuencias de escape tiene el tipo string?**

Algunas de las secuencias de escape del tipo string son:

| Secuencia de escape | Caracter                    |
|---------------------|-----------------------------|
| \\'                 | Comilla simple              |
| \\"                 | Comilla doble               |
| \\                  | Barra invertida             |
| \n                  | Nueva linea                 |
| \r                  | Retorno de carro            |
| \u                  | Secuencia de escape Unicode |

_Tabla extraída de: <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences>_

- **¿Qué sucede cuando se utiliza el caracter @ y $ antes de una cadena de texto?**

El caracter $ se usa para interpolación de cadenas. De esta manera, pueden concatenarse expresiones almacenadas en variables usando '{variable}' dentro de la cadena.

El caracter @ antes de una cadena se usa para crear una llamada **cadena verbatim**, es decir, indica que una cadena debe ser interpretada de manera literal. Este es uno de los usos del operador, aplicado a cadenas.

_Ver en: <https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim> y <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#verbatim-string-literals>_
