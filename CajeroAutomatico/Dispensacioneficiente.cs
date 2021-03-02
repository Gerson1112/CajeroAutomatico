using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class Dispensacioneficiente : Dispensar
    {

        public int Cantidad2;

        public Dispensacioneficiente(int Cantidad2)
        {
            this.Cantidad2 = Cantidad2;
        }

        SubMenu menu = new SubMenu();

        public void dispensacion()
        {
            int contador = 0, contador1 = 0, contador2 = 0, contador3 = 0;
            while (Cantidad2 != 0 && Cantidad2 >= 1000)
            {
                contador3++;
                Cantidad2 = Cantidad2 - 1000;
            }

            while (Cantidad2 != 0 && Cantidad2 >= 500)
            {
                contador2++;
                Cantidad2 = Cantidad2 - 500;
            }
            while (Cantidad2 != 0 && Cantidad2 >= 200)
            {
                contador1++;
                Cantidad2 = Cantidad2 - 200;
            }
            while (Cantidad2 != 0 && Cantidad2 >= 100)
            {
                contador++;
                Cantidad2 = Cantidad2 - 100;
            }

            Console.WriteLine("Las papeletas de 100 devueltas: " + contador);
            Console.WriteLine("Las papeletas de 200 devueltas: " + contador1);
            Console.WriteLine("Las papeletas de 500 devueltas: " + contador2);
            Console.WriteLine("Las papeletas de 1000 devueltas: " + contador3);
            Console.ReadKey();
            menu.imprimirmenu();
        }


    }

}
