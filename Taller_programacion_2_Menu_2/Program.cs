/* Nombre del Autor: Mauricio Mejia
 Fecha: 17 Noviembre del 2016
 Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi 
 trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_programacion_2_Menu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black; /*Color de fondo*/
                Console.ForegroundColor = ConsoleColor.Green; /*Color de letra */

                Console.Clear();
                Console.WriteLine("*********************************** MENU 2. Taller de Programación N°2 ***********************************");
                Console.WriteLine();
                Console.WriteLine("[1]. Ejercicio 1: Programa que permite encriptar la contraseña de un banco");
                Console.WriteLine();
                Console.WriteLine("[2]. Ejercicio 2: Programa para calcular la fecha del siguiente día a partir de una fecha digitada");
                Console.WriteLine();
                Console.WriteLine("[3]. Ejercicio 4: Programa para calcular el salario de empleados agrupados por categoría");
                Console.WriteLine();
                Console.WriteLine("[4]. Ejercicio 6: Programa para calcular si un número es primo o no");
                Console.WriteLine();
                Console.WriteLine("[5]. Ejercicio 7: Programa para hallar el tipo de triángulo según sus lados");
                Console.WriteLine();
                Console.WriteLine("[6]. Ejercicio 8: Programa para seleccionar personal aspirantes de una vacante según criterios");
                Console.WriteLine();
                Console.WriteLine("[7]. Ejercicio 10: Programa para calcular cuantos días (exactos) han transcurrido una fecha de nacimiento");
                Console.WriteLine();
                Console.WriteLine("[8]. Salir");
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción:");

                do
                {
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (op < 1 || op > 8);
                switch (op)
                {
                    case 1:
                        Menu1();
                        break;
                    case 2:
                        Menu2();
                        break;
                    case 3:
                        Menu3();
                        break;
                    case 4:
                        Menu4();
                        break;
                    case 5:
                        Menu5();
                        break;
                    case 6:
                        Menu6();
                        break;
                    case 7:
                        Menu7();
                        break;
                    case 8:
                        Console.WriteLine("Gracias por utilizar el programa!.Vuelve pronto.");
                        break;
                }

            } while (op != 8);
            Console.WriteLine();
            Console.Write("Salida exitosa del programa.");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para continuar . . . ");
            Console.ReadKey();
        }

        public static void Menu1()

        {
            Console.WriteLine("[1]. Ejercicio 1: Programa que permite encriptar la contraseña de un banco");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            String a = "";
            Console.WriteLine("Por favor, ingrese un número de 4 digitos:");
            String pal = Console.ReadLine();
            int numero = pal.Length;

            if (numero == 4)
            {
                for (int i = numero - 1; i >= 0; i--)
                {
                    a = a + pal.Substring(i, 1);
                }
                Console.WriteLine(" La contraseña encriptada es : {0} ", a);
                Console.WriteLine();
                Console.Write("La consulta se ha realizado exitosamente.! ");
                Console.WriteLine();
                Console.Write("\nPresione una tecla para volver al menú . . . ");
            }
            else
            {
                Console.WriteLine("Error!.El número ingresado no es de 4 digitos");
                Console.Write("\nPresione dos veces enter para volver al menú . . . ");
                Console.ReadKey();
            }
        }

        public static void Menu2()

        {
            int a, x_siguiente, dia = 1;
            int dia_siguiente, mes, mes_siguiente;
            Console.WriteLine("[2]. Ejercicio 2: Programa para calcular la fecha del siguiente día a partir de una fecha digitada");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese el valor de dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de año: ");
            a = int.Parse(Console.ReadLine());
            if ((dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 29 && mes ==
            2) || (dia > 28 && mes == 2 && ((a % 4 != 0) || (a % 100) == 0) && (a % 400) != 0) || (dia >
            31))
            {
                Console.WriteLine(" Error!. Valores no válidos... ");
            }
            else
            {
                if ((dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia == 29 && mes
                == 2) || (dia == 28 && mes == 2 && ((a % 4 != 0) || (a % 100) == 0) && (a % 400) != 0) ||
                (dia == 31))
                {
                    dia_siguiente = 0;
                    mes_siguiente = mes + 1;
                }
                else
                {
                    dia_siguiente = dia + 1;
                    mes_siguiente = mes;
                }
                if (dia_siguiente == 0 && mes_siguiente == 0)
                {
                    mes_siguiente = 0;
                    x_siguiente = a + 1;
                }
                else
                    x_siguiente = a;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Valor de dia siguiente : " + dia_siguiente);
                Console.WriteLine(" Valor de mes siguiente : " + mes_siguiente);
                Console.WriteLine(" Valor de año siguiente : " + x_siguiente);
            }
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione Enter dos veces volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void Menu3()

        {
            int categoria;
            double alm;
            int horas;

            Opcion:
            Console.WriteLine("Categoria del empleado: ");
            Console.WriteLine();
            Console.WriteLine("[1]. Categoria A1");
            Console.WriteLine("[2]. Categoria B2");
            Console.WriteLine("[3]. Categoria C3");
            Console.WriteLine("[4]. Categoria D4");
            Console.WriteLine();
            Console.WriteLine("Selecciona opción:");
            categoria = int.Parse(Console.ReadLine());

            switch (categoria)
            {
                case 1:
                    alm = 20000;
                    break;
                case 2:
                    alm = 15000;
                    break;
                case 3:
                    alm = 10000;
                    break;
                case 4:
                    alm = 7500;
                    break;
                default:
                    Console.WriteLine("Error!. categoria no válida.");
                    goto Opcion;
            }

            Console.WriteLine("Ingrese el numero de horas trabajadas por el empleado:");
            horas = int.Parse(Console.ReadLine());

            double salario = (alm * horas) - (0.072 * (alm * horas));

            if (salario < 1000000)
                salario = salario + 0.15 * (alm * horas);

            Console.WriteLine("El pago al empleado debe ser: " + salario);
            Console.WriteLine();
            Console.WriteLine("Presione dos veces Enter para volver al menú... ");
            Console.ReadKey();
        }

        public static void Menu4()

        {
            int num;
            int divisor = 2;

            Console.WriteLine("[4]. Ejercicio 6: Programa para calcular si un número es primo o no");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ingresa un número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            while (divisor < num)
            {
                while (num % divisor != 0)
                    divisor = divisor + 1;
                if (num == divisor)
                {
                    Console.WriteLine("El número " + num + " es un número primo");
                }
                else
                {
                    Console.WriteLine("El número " + num + " no es número primo ");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Presione dos veces Enter para volver al menú... ");
            Console.ReadKey();
        }

        public static void Menu5()

        {
            Console.WriteLine("[5]. Ejercicio 7: Programa para hallar el tipo de triángulo según sus lados");
            Console.WriteLine();
            Console.WriteLine();
            double a = 0, b = 0, c = 0;
            Console.WriteLine("Ingrese el valor del cateto a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese el valor del cateto b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el valor de la hipotenusa");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a == b && b == c)
                Console.WriteLine("El triángulo es EQUILATERO. ");
            else
            {
                if (a == b || a == c || b == c)
                    Console.WriteLine("El triángulo es ISÓSCELES. ");
                else
                {
                    Console.WriteLine("El triángulo es ESCALENO. ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Presione dos veces Enter para volver al menú... ");
            Console.ReadKey();
        }

        public static void Menu6()

        {
            int n;
            int edad;
            int ing;
            int exp;
            int i;

            int suma = 0;
            int ac = 0;

            Console.WriteLine("[6]. Ejercicio 8: Programa para seleccionar personal aspirantes de una vacante según criterios");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese la cantidad de aspirantes a la vacante:");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("El aspirante " + i, "es:");
                Console.WriteLine();
                Console.WriteLine("Mayor de edad? [1=Si ó 2=No]");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingeniero titulado? [1=Si ó 2=No]");
                ing = int.Parse(Console.ReadLine());
                Console.WriteLine("Tiene experiencia laboral? [1=Si ó 2=No]");
                exp = int.Parse(Console.ReadLine());

                if (edad == 1 && ing == 1 && exp == 1)
                {
                    ac = suma + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total de aspirantes aceptados: " + ac);
            Console.WriteLine();
            Console.WriteLine("Presione dos veces Enter para volver al menú... ");
            Console.ReadKey();
        }

        public static void Menu7()

        {
            int ano, dia, mes;
            Console.WriteLine("[7]. Ejercicio 10: Programa para calcular cuantos días (exactos) han transcurrido una fecha de nacimiento");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese año de nacimiento: ");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Ingrese dia de nacimiento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());

            DateTime oldDate = new DateTime(ano, mes, dia);
            DateTime newDate = DateTime.Now;
            TimeSpan ts = newDate - oldDate;
            int differenceInDays = ts.Days;

            System.Console.WriteLine(" La cantidad de dias despues de su nacimiento son: {0} ", differenceInDays);
            Console.WriteLine();
            Console.WriteLine("Presione dos veces Enter para volver al menú... ");
            Console.ReadKey();
        }
    }
}
