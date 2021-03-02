using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class SubMenu
    {

        public void imprimirmenu()
        {
            try
            {
                Console.Clear();
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                Console.Clear();
                Console.WriteLine("Seleccione una Opcion \n1.Modo de dispensacion de 100, 500 \n2.Modo de dispensacion de 200, 1000 \n3.Modo de dispensacion efeciente de 100, 200, 500, 1000 \n4.Volver a menu principal");
                int Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Console.WriteLine("El Modo se ha guardado correctamente...");
                        Console.ReadKey();
                        menuPrincipal.imprimirmenu(1);
                        break;
                    case 2:
                        Console.WriteLine("El modo se ha guardado correctamente...");
                        Console.ReadKey();
                        menuPrincipal.imprimirmenu(2);
                        break;
                    case 3:
                        Console.WriteLine("El modo se ha guardado correctamente");
                        Console.ReadKey();
                        menuPrincipal.imprimirmenu(3);
                        break;
                    case 4:
                        menuPrincipal.imprimirmenu(0);
                        break;
                    default:
                        Console.WriteLine("La opcion introducida no es valida.");
                        Console.ReadKey();
                        imprimirmenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("La opcion introducida no es valida.");
                Console.ReadKey();
                imprimirmenu();
            }
        }







    }
}
