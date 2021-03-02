using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class Dispensacion2 : Dispensar
    {
        public int Cantidad1;
        
        public Dispensacion2(int Cantidad1)
        {
            this.Cantidad1 = Cantidad1;
        }

        SubMenu menu = new SubMenu();
        public void dispensacion()
        {
            int contador = 0, contador1 = 0;
            int ratata = Cantidad1 / 2;
            if (Cantidad1 > 100 && ratata % 100 == 0)
            {
                while (Cantidad1 != 0 && Cantidad1 >= 1000)
                {
                    contador1++;
                    Cantidad1 = Cantidad1 - 1000;
                }
                while (Cantidad1 != 0 && Cantidad1 >= 200)
                {
                    contador++;
                    Cantidad1 = Cantidad1 - 200;
                }
                Console.WriteLine(" Las papeletas de 200 devueltas: " + contador);
                Console.WriteLine(" Las papeletas de 1000 devueltas: " + contador1);
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
