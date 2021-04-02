using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
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
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            int numDiscos = pedirDiscos();
            for(int i = numDiscos; i > 0; i--)
            {
                Disco d1 = new Disco(i); //cree els discos que l'usuari
                ini.push(d1); //apile els discos
            }

            Hanoi iniciar = new Hanoi();
            int m = iniciar.iterativo(numDiscos, ini, fin, aux);
            
            
            if( m > 0)
            {
                Console.WriteLine("El numero de movimientos es: " + m);
            }
            

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
