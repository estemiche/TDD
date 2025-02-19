using System;
using CalculadoraEdad;

Console.WriteLine("Ejecutando Calculadora de Edad...");

// Solicitar la fecha de nacimiento al usuario
Console.Write("Ingrese su fecha de nacimiento (Día-mes-año): ");
string input = Console.ReadLine() ?? "";

// Intentar convertir la entrada en un DateTime
if (DateTime.TryParse(input, out DateTime fechaNacimiento))
{
    DateTime fechaActual = DateTime.Now;

    // Crear instancia de la calculadora
    EdadCal calculadora = new EdadCal();
    int edad = calculadora.CalcularEdad(fechaNacimiento, fechaActual);

    Console.WriteLine($"La edad calculada es: {edad} años.");
}
else
{
    Console.WriteLine(" Fecha inválida. Intente nuevamente con el formato correcto.");
}
