using System;

using Serpis.Ad;

namespace CConsola
{
    class MainClass
    {
        public static void Main(string[] args) {
            int entero = ConsoleHelper.ReadInteger("Introduce un entero: ");


            Menu.Create("\tMenú Categorías")



                .Add("\t1 - Nuevo", nuevo)
                .Add("\t2 - Editar", editar)
                .Add("\t3 - Borrar", borrar)
                .ExitWhen("\t0 - Salir")
                .Loop();
        }
        private static void nuevo() {
            Console.WriteLine("Ha entrado en nuevo");
            Console.ReadLine();
        }

        private static void editar() {
            Console.WriteLine("Ha entrado en editar");
            Console.ReadLine();
        }

        private static void borrar() {
            Console.WriteLine("Ha entrado en borrar");
            Console.ReadLine();
        }
    }
}
