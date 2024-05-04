using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
            if (edead >= 18)
            {
                Console.WriteLine($"Acceso concedido Bienvenid@! {nombre}");
            }
            else
            {
                Console.WriteLine("Acceso denegado!! uested es MENOR de edad!");
            }
            Console.ReadKey();
        }
        public void descuento()
        {
            Console.WriteLine("Edad: ");
            int edad = (int.Parse(Console.ReadLine()));
            if (edad >= 18)
            {
                Console.WriteLine("Uted tiene un 20% de descuento");
            }
            else
            {
                Console.WriteLine("usted no tiene descuento");
            }
            Console.ReadKey();
        }
        public void calificacion()
        {
            Console.WriteLine("Calificacion:");
            double cal = double.Parse(Console.ReadLine());
            string res = (cal < 7) ? "DESAPROBADO" : "APROBADO";
            Console.WriteLine($"el alumno esta {res}");
            Console.ReadKey();
        }
        public void contrasenia()
        {
            string contra = "123";
            Console.WriteLine("Contraseña: ");
            string res = Console.ReadLine();
            string acces = res == contra ? "ACCESO CONCEDIDO" : "CONTRASEÑA INCORRECTA";
            Console.WriteLine(acces);
            Console.ReadKey();
        }
        public void redesSociales()
        {
            Console.WriteLine("Las redes sociales solo estan disponibles para mayores de edad..");
            Console.WriteLine("ingresa tu edad:");
            byte edad = (byte.Parse(Console.ReadLine()));
            string res = (edad >= 18) ? "Puedes crearte una cuenta!" : "No puedes crearte una cuenta porque eres menor de edad!";
            Console.WriteLine(res);
            Console.ReadKey();





        }
        public void impuestos()
        {
            
            double impuesto;
            double total;
            Console.WriteLine("ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario < 800000)//como en la consigna no habia parametro de referencia al impuesto puse un 25% de impuesto a un sueldo mayor a 800 mil y a los de menos un 10%
            {
impuesto = salario*0.25;
                total = salario - impuesto;
                Console.WriteLine($"El descuento de impuestos es de ${impuesto} y queda un total de ${total}");

            }
            else
            {
                impuesto = salario * 0.1;
                total = salario - impuesto;
                Console.WriteLine($"El descuento de impuestos es de ${impuesto} y queda un total de ${total}");

            }
            Console.ReadKey();
        }
        public void bar()
        {
            Console.WriteLine("Hola! ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre} ingresa tu edad: ");
            int edead = int.Parse(Console.ReadLine());
            if (edead >= 18)
            {
                Console.WriteLine($"Acceso concedido Bienvenid@ al BAR! {nombre}");
            }
            else
            {
                Console.WriteLine("Acceso denegado!! uested es MENOR de edad no puede entrar al BAR");
            }
            Console.ReadKey();
        }
        public void asistencia()
        {
            Console.WriteLine("ingresa el numero de clases totales:");//el usuario determina el numero de clases totales para calcular el numero de asistencias minimas
            int clases = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de asistencias");
            Console.WriteLine("TENER EN CUENTA QUE SE NECESITA MINIMO 80% DE ASISTENCIAS");
            int asistencias=int.Parse(Console.ReadLine());            
            double minimo = clases * 0.8;//determino el 80% para compararla en el condicional
            if (minimo > asistencias)
            {
                Console.WriteLine("no llega a cubrir el minimo de asistencias");
                
            }else
            {

                Console.WriteLine($"el alumno llego a completar el minimo de asistencias");
            }           
           
            Console.ReadKey();
            

        }
        public void telefono()
        {
            long numero = 2235476963;
            Console.WriteLine("ingrese el numero de telefono correspondiente");
           long respuesta = long.Parse(Console.ReadLine());
            string resultado = (numero == respuesta) ? "NUMERO CORRECTO!" : "NUMERO INCORRECTO!";
            Console.WriteLine(resultado);
            Console.ReadKey();
            
        }
        public void tienda()
        {
            Console.WriteLine("Se aplicara un descuento de 15% a llas compras de mas de $20.000 y un descuento del 10% a las compras de $10.000 en adelante hasta $20.000");
            Console.WriteLine("Ingrese el monto de la compra: ");
            double compra = double.Parse(Console.ReadLine());
            double descuento;
            if (compra >= 10000 & compra < 20000)
            {
                descuento = compra * 0.1;
                Console.WriteLine($"El total de tu compra es: {compra - descuento}");
                Console.ReadKey ();
            }else if (compra >= 20000)
            {
                descuento = compra * 0.15;
                                Console.WriteLine($"El total de tu compra es: {compra - descuento}");
                Console.ReadKey();
            }
            

            
        }
        public void productosDisponibles()
        {
            int azucar = 20;
            int cocacola = 50;
            int fernet = 50;
            int fideos = 20;
            Console.WriteLine("ingrese el numero segun el producto a consultar:");
            Console.WriteLine("1.Azucar");
            Console.WriteLine("2.CocaCola");
            Console.WriteLine("3.Fernet");
            Console.WriteLine("4.Fideos");
            int respuesta= int.Parse(Console.ReadLine());
            string resultado;
            int cantidad;
            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("ingrese la cantidad:");
                    cantidad= int.Parse(Console.ReadLine());
                     resultado = (cantidad <= azucar) ? "Queda Stock!" : "No alcanza el Stock!!";
                    Console.WriteLine(resultado);
                    Console.ReadKey ( );
                    break;
                case 2:
                    Console.WriteLine("ingrese la cantidad:");
                    cantidad = int.Parse(Console.ReadLine());
                     resultado = (cantidad <= cocacola) ? "Queda Stock!" : "No alcanza el Stock!!";
                    Console.WriteLine(resultado);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("ingrese la cantidad:");
                     cantidad = int.Parse(Console.ReadLine());
                     resultado = (cantidad <= fernet) ? "Queda Stock!" : "No alcanza el Stock!!";
                    Console.WriteLine(resultado);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("ingrese la cantidad:");
                    cantidad = int.Parse(Console.ReadLine());
                     resultado = (cantidad <= fideos) ? "Queda Stock!" : "No alcanza el Stock!!";
                    Console.WriteLine(resultado);
                    Console.ReadKey();
                    break;
            }
        }
        public void aprobacionCredito()
        {
            Console.WriteLine("Ingrese su sueldo mensual:");
            double sueldo=double.Parse(Console.ReadLine());
            Console.WriteLine("Tener en cuenta que la taza anual actual es de 70% y que la cuota minima no debe superar el 25% del sueldo");
            Console.WriteLine("Ingrese el monto del Prestamo");
            double prestamo =double.Parse(Console.ReadLine());
            double compSueldo = sueldo * 0.25;
            double compCuota = prestamo / 12;
            double totalCuota=(prestamo*1.7)/12;
            if (compSueldo > compCuota) {
                Console.WriteLine("Credito Aprobado!!");
                Console.WriteLine($"La cuota mensual por 12 meses es: $ {totalCuota}");
            }else
            {
                Console.WriteLine("PRESTAMO NO APROBADO");
            }
            Console.ReadKey();
        }
        public void validacionCorreo()
        {
            string correo;
            Console.WriteLine("Ingrese correo electrónico:");
            correo = Console.ReadLine();

            if (Regex.IsMatch(correo, @"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]"))//utilizo la clase regex para validar si la cadena correo tien el formato que pongo como parametro de la funcion IsMatch
            {
                Console.WriteLine("El correo electrónico es VALIDO!");
            }
            else
            {
                Console.WriteLine("El correo electrónico NO es VALIDO!");
            }
            Console.ReadKey();
        }
       public void asientosDisponibles()
        { 
            int asientosDisp =100 ;
            Console.WriteLine("Ingrese la cantidad de asientos que desea:");
        int cliente=int.Parse(Console.ReadLine());
            string resp = cliente < asientosDisp ? "Hay disponibilidad!" : "No hay disponibilidad";
            Console.WriteLine(resp);
            Console.ReadKey ();
        
        
        }



    }

}
