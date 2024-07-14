using System;
using System.Collections.Generic;
using Trabajo_Final___AbeasCorp;

namespace AplicationConsoleAbeasCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a AbeasCorp.\n");

            var requests = new List<Request>();
            var scheduler = new RequestSchedulerTest();
            while (true) 
            {
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Ingresaar una nueva solicitud: ");
                Console.WriteLine("2. Calcular maximo beneficio: ");
                Console.WriteLine("3. Salir ");

                Console.Write("Opcion: ");
                string opcion = Console.ReadLine().Trim();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese los datos de la solicitud");

                        Console.Write("Codigo de la solicitud: ");
                        string codigo = Console.ReadLine().Trim();

                        int q1, q2, q3;

                        Console.Write("Hora de inicio(0-23): ");
                        while (!int.TryParse(Console.ReadLine().Trim(), out q1) || q1 < 0 || q1 > 23)
                        {
                            Console.WriteLine("Debes ingresar un numero entero entre el 0 y el 23 para la hora de inicio.");
                            Console.Write("Hora de inicio(0-23): ");
                        }

                        Console.Write("Duracion de viaje (0-15): ");
                        while (!int.TryParse(Console.ReadLine().Trim(), out q2) || q2 < 0 || q2 > 15)
                        {
                            Console.WriteLine("Debes ingresar un numero entero entre el 0 y el 15 para la duracion de viaje.");
                            Console.Write("Duracion de viaje (0-15): ");
                        }

                        Console.Write("Precio a pagar: ");
                        while (!int.TryParse(Console.ReadLine().Trim(), out q3))
                        {
                            Console.WriteLine("Debes ingresar un numero entero para el precio a pagar.");
                            Console.Write("Precio a pagar: ");
                        }
                        requests.Add(new Request(codigo.ToUpper(), q1, q2, q3));

                        Console.WriteLine("Solicitud agregada correctamente.");
                        break;

                    case "2":

                        if (requests.Count == 0)
                        {
                            Console.WriteLine("No hay solicitudes ingresadas.");
                            break;
                        }

                        var MaxGain = scheduler.GetMaxGain(requests);
                        Console.WriteLine("\nEl mejor resultado es: " + MaxGain);
                        break;


                    case "3":

                        Console.WriteLine("Saliendo del programa.");
                        return;

                    default:
                        Console.WriteLine("Opcion invalida. Intente de Nuevo.");
                        break;

                }
            }
          
        }
    }
}
