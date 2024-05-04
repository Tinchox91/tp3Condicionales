using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3Condicionales
{
    internal class Inicio
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();
            Console.WriteLine("Ingrese la opcion deseada:");
            Console.WriteLine("1.Edad para conducir");
            Console.WriteLine("2.Control de acceso");
            Console.WriteLine("3.Descuento de edad en cine");
            Console.WriteLine("4.Calificacion aprobatoria");
            Console.WriteLine("5.Verificacion de contraseña");
            Console.WriteLine("6.Comprobacion de edad para redes sociales");
            Console.WriteLine("7.Calculo de impuestos");
            Console.WriteLine("8.Control de acceso a un bar");
            Console.WriteLine("9.Vedificacion de asistencia a clase");
            Console.WriteLine("10.validacion de numero de telefono");
            Console.WriteLine("11.calculo de descuento em tienda");
            Console.WriteLine("12.Veroficacion de disponibilidad de producto");
            Console.WriteLine("13.Aprobacion de credito");
            Console.WriteLine("14.Validacion de correo electronico");
            Console.WriteLine("15.Comprobacion de disponbilidad de asientos");
            string op1 = Console.ReadLine();
            switch (op1)
            {
                case "1":calculo.edad(); break;
                case "2":calculo.controlDeAcceso(); break;
                case"3":calculo.descuento(); break;
                case "4":calculo.calificacion(); break;
                case "5":calculo.contrasenia(); break;
                case "6":calculo.redesSociales(); break;
                case "7":calculo.impuestos();break;
                case "8":calculo.bar();break;
                case "9":calculo.asistencia(); break;
                case "10": calculo.telefono(); break;
                case "11": calculo.tienda(); break;
                case "12":calculo.productosDisponibles(); break;
                case "13":calculo.aprobacionCredito(); break;
                case "14":calculo.validacionCorreo(); break;
                case "15":calculo.asientosDisponibles();break;

                    


                              }
        }
    }

}
