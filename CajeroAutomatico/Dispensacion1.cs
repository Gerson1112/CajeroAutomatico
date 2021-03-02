using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public class Dispensacion1 : Dispensar
    {

        public int Cantidad;

         SubMenu menu = new SubMenu();
        public Dispensacion1(int Cantidad)
        {
            this.Cantidad = Cantidad;
        }

        public void dispensacion()
        {
            int contador = 0, contador1 = 0;
            int ratata = Cantidad / 2;
            if (Cantidad > 100 && ratata % 100 == 0)
            {
                while (Cantidad != 0 && Cantidad >= 500)
                {
                    contador1++;
                    Cantidad = Cantidad - 500;
                }
                while (Cantidad != 0 && Cantidad >= 100)
                {
                    contador++;
                    Cantidad = Cantidad - 100;
                }

                Console.WriteLine(" Las papeletas de 100 devueltas: " + contador);
                Console.WriteLine(" Las papeletas de 500 devueltas: " + contador1);
                Console.ReadKey();
                menu.imprimirmenu();
            }
            else
            {
                Console.WriteLine(" El sistema no admite este tipo de moneda");
                Console.ReadKey();
                menu.imprimirmenu();
            }
           
        }
    }
}
