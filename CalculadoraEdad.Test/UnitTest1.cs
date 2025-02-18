using System;
using Xunit;
using CalculadoraEdad;

namespace CalculadoraEdad.Test
{
    public class TestCalculadoraEdad
    {
        
        [Fact]
        public void CalcularEdad_CalculaCorrectamenteCuandoNoCumplioAnosEsteAno()
        {
            var fechaNacimiento = new DateTime(2000, 2, 17);  
            var fechaActual = new DateTime(2025, 2, 16);      
            var calculadora = new CalculadoraEdad();         

        
            var edadCalculada = calculadora.CalcularEdad(fechaNacimiento, fechaActual); 

            
            Assert.Equal(24, edadCalculada);  
        }
        [Fact]
        public void CalcularEdad_CalculaCorrectamenteCuandoCumplioAnosEsteAno()
        {
            
            var fechaNacimiento = new DateTime(2000, 2, 17);  
            var fechaActual = new DateTime(2025, 2, 18);      
            var calculadora = new CalculadoraEdad();         
        

            var edadCalculada = calculadora.CalcularEdad(fechaNacimiento, fechaActual);  

           
            Assert.Equal(25, edadCalculada);  
        }
    }
}
