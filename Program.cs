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