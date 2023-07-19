using System;

//Ejercicio 1 

// Escribe un programa que reciba datos de una persona y genera un mensaje,
// usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

Console.Write("Por favor escriba su nombre: ");
string nombre = Console.ReadLine();


Console.Write("Por favor escriba su apellido: ");
string apellido  = Console.ReadLine();


Console.Write("Por favor escribe tu edad: ");
int edad = Int32.Parse(Console.ReadLine());


Console.Write("Sabe Programar?, Por favor colocar true o false: \n" );

bool programar = bool.Parse(Console.ReadLine());
if (programar == true)
{
    Console.WriteLine("Hola buenas mi nombre es: " + nombre + " mi apellido es: " + apellido + " y mi edad es: " + edad + ", Actualmente: Si, se programar");
}
else
{
    Console.WriteLine("Hola buenas mi nombre es: " + nombre + " mi apellido es: " + apellido + " y mi edad es: " + edad + ", Actualmente:  No se programar");
}

//ejercico 2

//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

//Coche: puertas, ruedas, marca, ITV vigente

//Mesa: peso, largo, material, color

//Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

//Coche
int puertas;
int ruedas;
string marca;
bool ITVVigente;

//Mesa
long peso;
float largo;
string material;
string color;

//Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.


/*
 
Ejercicio 3

Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

int numero = 10;

if (numero >= 18)
{

}

char a;

int numero1 = 10;

if (numero1 <= 10 && numero <= 10)
{

}
else
{

}

if (numero > 20 || numero1 > 5)
{

}

