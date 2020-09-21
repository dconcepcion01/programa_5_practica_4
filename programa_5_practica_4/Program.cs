using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_5_practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("Jugando con las posiciones");

            //instanciando las clases
            Personaje.MoverArriba();
            Personaje.MoverAbajo();
            Personaje.MoverIzquierda();
            Mario.MoverArriba();
            Mario.MoverAbajo();
            Mario.MoverIzquierda();
            Koopa.MoverArriba();
            Koopa.MoverAbajo();
            Koopa.MoverIzquierda();
        }
    }
}
