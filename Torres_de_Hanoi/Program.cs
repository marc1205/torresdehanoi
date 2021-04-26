using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        //en pedirDisco() li demanarem a l'usuari que ens diga el numero total de discos que tindrà l'exercici.
        static int pedirDiscos()
        {
            Console.WriteLine("Dime el numero de discos: ");
            int num = Int32.Parse(Console.ReadLine());

            if( num <= 0)
            {
                Console.WriteLine("No se han introducido correctamente los discos");
                return 0;
            }
            else
            {
                return num;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el método que desa usar: Pulsa 1 para usar el método Iterativo, o cualquier otro número para el método Recursivo: ");
            int numero = Int32.Parse(Console.ReadLine());

            //creem les tres piles que anem a gastar
            Pila ini = new Pila(); 
            Pila aux = new Pila();
            Pila fin = new Pila();

            int numDiscos = pedirDiscos();

            //recorrec el bucle de major a menor per a que vaja guardant els discos de més gran a més xicotet.
            for (int i = numDiscos; i > 0; i--) 
            {
                Disco d1 = new Disco(i); //cree els discos que l'usuari ha dit
                ini.push(d1);            //apile els discos en la pila inicial
            }

            Hanoi iniciar = new Hanoi(); //iniciem hanoi

            if (numero == 1)
            {
                int m = iniciar.iterativo(numDiscos, ini, fin, aux); //m serà el número total de moviments
                Console.WriteLine("El numero de movimientos es: " + m);
            }
            else
            {
                int x = iniciar.recursivo(numDiscos, ini, fin, aux); //m serà el número total de moviments
                Console.WriteLine("El numero de movimientos es: " + x);

                //int m = 0;
                //iniciar.recursivo2(numDiscos, ini, fin, aux, ref m); //m serà el número total de moviments
                // Console.WriteLine("El numero de movimientos es: " + m);
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
