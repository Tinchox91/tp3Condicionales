using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3Condicionales
{
    internal class Calculo
    {
       public void edad()
        {
            Console.WriteLine("Indica tu edad: ");
            int edad = int.Parse(Console.ReadLine());
            string res = (edad >= 18) ? "Usted es mayor de edad" : "Usted es menor de edad";//le doy valor a variable si es true o false
            Console.WriteLine(res);//muestro variable por coonsola
            Console.ReadKey();//espera que aprete alguna tecla pa terminar
        }
        public void controlDeAcceso()
        {
            Console.WriteLine("Hola! ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre} ingresa tu edad: ");
            int edead = int.Parse(Console.ReadLine());
            if ( edead >= 18 )
            {
                Console.WriteLine($"Acceso concedido Bienvenid@! {nombre}");
            }else
            {
                Console.WriteLine("Acceso denegado!! uested es MENOR de edad!");
            }
            Console.ReadKey();
        }
        public void descuento()
        {
            Console.WriteLine("Edad: ");
            int edad = (int.Parse(Console.ReadLine()));
            if ( edad >= 18 )
            {
                Console.WriteLine("Uted tiene un 20% de descuento");
            }else
            {
                Console.WriteLine("usted no tiene descuento");
            }
            Console.ReadKey();
        }
        public void calificacion()
        {
            Console.WriteLine("Calificacion:");
            double cal= double.Parse(Console.ReadLine());
            string res = (cal < 7) ? "DESAPROBADO" : "APROBADO";
            Console.WriteLine($"el alumno esta {res}");
            Console.ReadKey();
        }
        public void contrasenia()
        {
            string contra = "123";
            Console.WriteLine("Contraseña: ");
            string res=Console.ReadLine();
            string acces = res == contra ? "ACCESO CONCEDIDO" : "CONTRASEÑA INCORRECTA";
            Console.WriteLine(acces);
            Console.ReadKey();
        }

        

        
    
    }
}
