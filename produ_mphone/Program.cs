using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace produ_mphone
{
    internal class Program
    {
        static int mPhone3000 = 0;
        static int mPad3500 = 0;
        static int MAPBrook3800 = 0;
        static int mWatch8000 = 0;
        static int total = 0;
        static void Main(string[] args)
        {
            int opcion = Productos_mphone();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Productos_mphone();
                        break;
                    case 1:
                        opcion = mPhone_3000();
                        break;
                    case 2:
                        opcion = mPad_3500();
                        break;
                    case 3:
                        opcion = MAPBrook_3800();
                        break;
                    case 4:
                        opcion = mWatch_8000();
                        break;
                    case 5:
                        opcion = reporte_fin();
                        break;

                }
            } while (opcion!=6);

          
        }
        public static int Productos_mphone()
        {
        Console.Clear();
        Console.WriteLine("================================");
            Console.WriteLine("Productos de mPhone");
            Console.WriteLine("1: Ventas de mPhone 3000");
            Console.WriteLine("2: Ventas de mPad 3500");
            Console.WriteLine("3: Ventas de MAPBrook");
            Console.WriteLine("4: Ventas de mWatch 8000");
            Console.WriteLine("5: Salir");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
                 return getOpcion();
          
        }
         
        public static int mPhone_3000()
        {

            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de mPhone 3000");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar Venta");
            Console.WriteLine("2: Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {
                {
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine("Registrar devolución de:");
                    Console.WriteLine("================================");
                    Console.WriteLine("Se va a registrar la devolución de un mPhone 3000 ¿Desea continuar?");
                    Console.WriteLine("1: Si");
                    Console.WriteLine("2: No");
                    Console.WriteLine("================================");
                    Console.WriteLine("Ingrese una opción:");
                    int devolucionOption = getOpcion();
                    if (devolucionOption == 1)
                    {
                        mPhone3000++;
                    }
                    else if (devolucionOption == 2)
                    {
                        return Productos_mphone();
                    }
                    
                }
            }
            else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Registrar venta de:");
                Console.WriteLine("================================");
                Console.WriteLine("Se va a registrar la venta de un mPhone 3000 ¿Desea continuar?");
                Console.WriteLine("1: Si");
                Console.WriteLine("2: No");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int devolucionOption = getOpcion();
                if (devolucionOption == 1)
                {
                    mPhone3000++;
                }
                else if (devolucionOption == 2)
                {
                    return Productos_mphone();
                }
            }
            else if (opcion == 3)
            {
                return Productos_mphone();
            }
            return opcion;
        }

        public static int mPad_3500()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de mPhone 3500");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar Venta");
            Console.WriteLine("2: Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {
                {
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine("Registrar devolución de:");
                    Console.WriteLine("================================");
                    Console.WriteLine("Se va a registrar la devolución de un mPad 3500 ¿Desea continuar?");
                    Console.WriteLine("1: Si");
                    Console.WriteLine("2: No");
                    Console.WriteLine("================================");
                    Console.WriteLine("Ingrese una opción:");
                    int devolucionOption = getOpcion();
                    if (devolucionOption == 1)
                    {
                        mPad3500++;
                    }
                    else if (devolucionOption == 2)
                    {
                        return Productos_mphone();
                    }

                }
            }
            else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Registrar venta de:");
                Console.WriteLine("================================");
                Console.WriteLine("Se va a registrar la venta de un mPad 3500 ¿Desea continuar?");
                Console.WriteLine("1: Si");
                Console.WriteLine("2: No");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int devolucionOption = getOpcion();
                if (devolucionOption == 1)
                {
                    mPad3500++;
                }
                else if (devolucionOption == 2)
                {
                    return Productos_mphone();
                }
            }
            else if (opcion == 3)
            {
                return Productos_mphone();
            }

            return opcion;
        }
        public static int MAPBrook_3800()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de MAPBrook 3800");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar Venta");
            Console.WriteLine("2: Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {
                {
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine("Registrar devolución de:");
                    Console.WriteLine("================================");
                    Console.WriteLine("Se va a registrar la devolución de un MAPBrook 3800 ¿Desea continuar?");
                    Console.WriteLine("1: Si");
                    Console.WriteLine("2: No");
                    Console.WriteLine("================================");
                    Console.WriteLine("Ingrese una opción:");
                    int devolucionOption = getOpcion();
                    if (devolucionOption == 1)
                    {
                        MAPBrook3800++;
                    }
                    else if (devolucionOption == 2)
                    {
                        return Productos_mphone();
                    }

                }
            }
            else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Registrar venta de:");
                Console.WriteLine("================================");
                Console.WriteLine("Se va a registrar la venta de un MAPBrook 3800 ¿Desea continuar?");
                Console.WriteLine("1: Si");
                Console.WriteLine("2: No");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int devolucionOption = getOpcion();
                if (devolucionOption == 1)
                {
                    MAPBrook3800++;
                }
                else if (devolucionOption == 2)
                {
                    return Productos_mphone();
                }
            }
            else if (opcion == 3)
            {
                return Productos_mphone();
            }
            return opcion;
        }
        private static int mWatch_8000()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de mWatch 8000");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar Venta");
            Console.WriteLine("2: Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opción:");
            int opcion = getOpcion();
            if (opcion == 1)
            {
                {
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine("Registrar devolución de:");
                    Console.WriteLine("================================");
                    Console.WriteLine("Se va a registrar la devolución de un mMatch 8000 ¿Desea continuar?");
                    Console.WriteLine("1: Si");
                    Console.WriteLine("2: No");
                    Console.WriteLine("================================");
                    Console.WriteLine("Ingrese una opción:");
                    int devolucionOption = getOpcion();
                    if (devolucionOption == 1)
                    {
                        mWatch8000++;
                    }
                    else if (devolucionOption == 2)
                    {
                        return Productos_mphone();
                    }

                }
            }
            else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Registrar venta de:");
                Console.WriteLine("================================");
                Console.WriteLine("Se va a registrar la venta de un mWatch 8000 ¿Desea continuar?");
                Console.WriteLine("1: Si");
                Console.WriteLine("2: No");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                int devolucionOption = getOpcion();
                if (devolucionOption == 1)
                {
                    mWatch8000++;
                }
                else if (devolucionOption == 2)
                {
                    return Productos_mphone();
                }
            }
            else if (opcion == 3)
            {
                return Productos_mphone();
            }
         

            return opcion;
        }
        
       public static int reporte_fin()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Reporte Final");
            Console.WriteLine("================================");
            Console.WriteLine("Productos Vendidos    | Cantidad");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"mPhones               |{mPhone3000}");
            Console.WriteLine($"mPads                 |{mPad3500}");
            Console.WriteLine($"MAPBrooks             |{MAPBrook3800}");
            Console.WriteLine($"mWatches              |{mWatch8000}");
            Console.WriteLine("--------------------------------");
            total = mPhone3000 + mPad3500 + MAPBrook3800 + mWatch8000;
            Console.WriteLine($"Total                 |{total}");
            Console.WriteLine("================================");
            Console.WriteLine("¡Hasta luego!");
            Console.WriteLine("Diseñado por:");
            string nom = Console.ReadLine();
            int opcion = getOpcion();
            return opcion;
        }

        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
        

    }
}
