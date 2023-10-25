using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_prob04
{
    internal class Program

        {
            static void Main(string[] args)
            {
                int opcion;

                Dictionary<string, int> ventas = new Dictionary<string, int>();

                do
                {
                    Console.Clear(); // Limpia la pantalla
                    Console.WriteLine("================================");
                    Console.WriteLine("Productos de mPhone");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Ventas de mPhone 3000");
                    Console.WriteLine("2: Ventas de mPad 3500");
                    Console.WriteLine("3: Ventas de MAPBrook 3800");
                    Console.WriteLine("4: Ventas de mWatch 8000");
                    Console.WriteLine("5: Salir");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                ventas["mPhone 3000"] += RegistrarVenta("mPhone 3000");
                                break;
                            case 2:
                                ventas["mPad 3500"] += RegistrarVenta("mPad 3500");
                                break;
                            case 3:
                                ventas["MAPBrook 3800"] += RegistrarVenta("MAPBrook 3800");
                                break;
                            case 4:
                                ventas["mWatch 8000"] += RegistrarVenta("mWatch 8000");
                                break;
                            case 5:
                                Console.WriteLine("Saliendo del programa...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                    }

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                } while (opcion != 5);
            }

            static int RegistrarVenta(string producto)
            {
                int cantidadVentas = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine($"Registrar venta de:");
                    Console.WriteLine("================================");
                    Console.WriteLine($"Se va a registrar la venta de un {producto} ¿Desea Continuar?");
                    Console.WriteLine("1: Sí");
                    Console.WriteLine("2: No");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");

                    if (int.TryParse(Console.ReadLine(), out int opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese la cantidad de ventas a registrar: ");
                                if (int.TryParse(Console.ReadLine(), out int ventasNuevas))
                                {
                                    cantidadVentas = ventasNuevas;
                                    Console.WriteLine($"Se registraron {ventasNuevas} ventas de {producto}.");
                                }
                                else
                                {
                                    Console.WriteLine("Cantidad no válida. Intente de nuevo.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("No se registraron ventas.");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                    }

                    if (cantidadVentas == 0)
                    {
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                    }
                } while (cantidadVentas == 0);

                return cantidadVentas;
            }
        }

    }


