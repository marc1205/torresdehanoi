using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        //implementem el mover_disco()
        public void mover_disco(Pila a, Pila b)
        {
            Disco d;
            //si el disco de dalt de la pila a és més xicotet que el de la pila b; o la pila b està buida; 
            //i si la pila a conté discos:
            if ( ((a.Top < b.Top) || ( b.isEmpty() == true)) && (a.isEmpty()==false))
            {
                //si hi ha disco, que l'agafe de dalt de a i l'afegisca a la pila b.
                d = a.pop();
                if( d != null)
                {
                    b.push(d);
                }
            }
            //si no: si hi ha, que agafe el disco de dalt de b i l'afegisca a la pila a.
            else
            {
                d = b.pop();
                if( d != null)
                {
                    a.push(d);
                }
            }
        }

        //implementem l'algoritme iteratiu
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if( n % 2 != 0)
            {
                while ( fin.Size != n)
                {
                    mover_disco(ini, fin);
                    m++;
                    if( fin.Size != n)
                    {
                        mover_disco(ini, aux);
                        m++;
                    }
                    if (fin.Size != n)
                    {
                        mover_disco(aux, fin);
                        m++;
                    }
                }
            }
            else
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    m++;
                    if (fin.Size != n)
                    {
                        mover_disco(ini, fin);
                        m++;
                    }
                    if (fin.Size != n)
                    {
                        mover_disco(aux, fin);
                        m++;
                    }
                }
            }
            return m;
        }
    }
}
