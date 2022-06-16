using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.WriteLine("Ingreso de datos de lista de autos");

            Console.ForegroundColor = ConsoleColor.Green;

            List<Cliente> ListaAutos = new List<Cliente>();

            Console.WriteLine("Ingrese 's' para iniciar el ingreso de datos:");

            string acceso = Console.ReadLine();

            while (acceso == "s")
            {
                Cliente Dueño = new Cliente();

                Auto Modelo = new Auto();

                Console.WriteLine("Ingrese la marca:");

                Modelo.Marca = Console.ReadLine();

                Console.WriteLine("Ingrese el modelo:");

                Modelo.Modelo = Console.ReadLine();

                Console.WriteLine("Ingrese el año de fabricacion:");

                Modelo.AñoFab = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el numero de patente:");

                Modelo.NumPatente = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el tipo de combustible:");

                Modelo.TipoCombust = Console.ReadLine();

                Console.WriteLine("Ahora vamos a ingresar los datos del cliente:");

                Console.WriteLine("Ingrese el nombre del cliente:");

                Dueño.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido:");

                Dueño.Apellido = Console.ReadLine();

                Console.WriteLine("Numero de DNI:");

                Dueño.DNI = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el modo de pago: 'un pago' o 'cuotas'");

                Dueño.ModPago = Console.ReadLine();

                if (Dueño.ModPago == "cuotas")
                {
                    Console.WriteLine("Ingrese el numero de cuotas:");

                    Dueño.NumCuotas = Convert.ToInt32(Console.ReadLine());

                    while (Dueño.NumCuotas > 36)
                    {

                        Console.WriteLine("El numero maximo es de 36 cuotas, ha excedido lo permitido.");
                        Console.WriteLine("Por favor re-ingrese:");
                        Dueño.NumCuotas = Convert.ToInt32(Console.ReadLine());

                    }
                }

                Dueño.Autos.Add(Modelo);

                ListaAutos.Add(Dueño);

                Console.WriteLine("Desea continuar, ingrese 's', caso contrario ingrese 'n':");

                acceso = Console.ReadLine();

                Console.Clear();

                for (int i= 0; i< ListaAutos.Count; i++)
                {
                    Cliente muestra = ListaAutos[i];

                    Console.CursorLeft = 30;
                    Console.WriteLine("Datos del cliente:");
                    Console.WriteLine("Nombre:" + " " + muestra.Nombre);
                    Console.WriteLine("Apellido:" + " " + muestra.Apellido);
                    Console.WriteLine("DNI:" + " " + muestra.DNI);
                    
                    if (muestra.ModPago == "cuotas")
                    {
                        Console.WriteLine("Modo de pago:" + " " + muestra.ModPago);
                        Console.WriteLine("Numero de cuotas:" + " " + muestra.NumCuotas);
                    }
                    else
                    {
                        Console.WriteLine("Modo de pago:" + " " + muestra.ModPago);
                    }
                    Console.CursorLeft = 30;
                    Console.WriteLine("Datos del vehiculo:");
                    for (int j=0; j<muestra.Autos.Count; j++)
                    {
                        Console.WriteLine("Marca:" + " " + muestra.Autos[i].Marca);
                        Console.WriteLine("Modelo:" + " " + muestra.Autos[i].Modelo);
                        Console.WriteLine("Año de fabricacion:" + " " + muestra.Autos[i].AñoFab);
                        Console.WriteLine("Numero de patente:" + " " + muestra.Autos[i].NumPatente);
                        Console.WriteLine("Tipo de combustible:" + " " + muestra.Autos[i].TipoCombust);

                    }
                }

                Console.ReadKey();
            }
        }
    }
}
