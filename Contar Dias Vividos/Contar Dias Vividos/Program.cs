using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiasVividos
{
    class DiasVividos
    {
        // Gabriel Matos 
        // 17-miin-1-015
        // Seccion O463
        static void Main(string[] args)
        {
            // Variables
            DateTime nacimiento;
            DateTime hoy;
            TimeSpan diferencia;
            int option, option1;
            do
            {
                Console.Clear();
                //mensajes    
                Console.WriteLine("Datos de Estudiante\n");
                Console.WriteLine("Gabriel Matos");
                Console.WriteLine("17 -miin-1-015");
                Console.WriteLine("Seccion O463\n\n");
                Console.WriteLine("----------------------");
                Console.Title = "Calculo de Dias Vividos";
                Console.WriteLine("Saber dias de vida\n" +
                                  "------------------");
                // Nacimiento
                Console.Write("Ingrese fecha de nacimiento DD/MM/AA: ");
                nacimiento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Quieres poner la Fecha de hoy Manual o Tomarla del Sistema");
                Console.WriteLine("1- Manual");
                Console.WriteLine("2- Sistema");
                Console.WriteLine("Seleccionar: ");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1) {

                    // Hoy    
                    Console.Write("Ingrese fecha del dia de hoy DD/MM/AA: ");
                    hoy = DateTime.Parse(Console.ReadLine());
                    diferencia = hoy - nacimiento;
                }
                else if (option == 2)
                {
                    // Hoy            
                    hoy = DateTime.Now;
                    diferencia = hoy - nacimiento;
                    //Console.WriteLine("La fecha de hoy es: {0}", hoy);
                }
                else
                {
                    Console.Write("Digite una opcion valida");

                }

                // Diferencia por pantalla
               
                Console.WriteLine("Los dias de vida vividos son: {0}", diferencia.Days);

                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Quieres continuar o Salir de la Aplicacion");
                Console.WriteLine("1- Salir");
                Console.WriteLine("2- Continuar");
                Console.WriteLine("Seleccionar: ");
                option1 = Convert.ToInt32(Console.ReadLine());
               
            } while (option == 1);
        }
    }
}