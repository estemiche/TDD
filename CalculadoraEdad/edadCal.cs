using System;

namespace CalculadoraEdad
{
    public class EdadCal
    {
        public int CalcularEdad(DateTime fechaNacimiento, DateTime fechaActual)
        {
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Si aún no ha pasado el cumpleaños en el año actual, restamos un año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad).Date)
            {
                edad--;
            }

            return edad;
        }
    }
}
