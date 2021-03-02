using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class MenuPrincipal
    {
        SubMenu submenu = new SubMenu();
        
        public void imprimirmenu(int Eleccion)
        {
            retirar retiracion = new retirar();
            Dispensar Dispensar1;

            try
            {
                
                Console.Clear();
                Console.WriteLine("Seleccione una Opcion \n1.Configurar el metodo de dispensacion \n2.Retirar el dinero \n3. salir");
                Console.Write("-->");
                int Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        submenu.imprimirmenu();
                        break;
                    case 2:
                        Console.WriteLine("Ingresar la cantidad a retirar");
                        retiracion.Cantidad = int.Parse(Console.ReadLine());
                        if (Eleccion == 1)
                        {
                            Dispensar1 = new Dispensacion1(retiracion.Cantidad);
                        }
                        else if (Eleccion == 2)
                        {
                            Dispensar1 = new Dispensacion2(retiracion.Cantidad);
                        }
                        else
                        {
                            Dispensar1 = new Dispensacioneficiente(retiracion.Cantidad);
                        }

                        Dispensar1.dispensacion();
                        break;
                    case 3:
                        Console.WriteLine("El sistema se va a cerrar...");
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no es valida.");
                        Console.ReadKey();
                        imprimirmenu(Eleccion);
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("La opcion ingresada no es valida.");
                Console.ReadKey();
                imprimirmenu(Eleccion);
            }
        }

        public void submenu1()
        {



        }
    }
}

