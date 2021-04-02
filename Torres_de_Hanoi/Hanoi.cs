using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            Disco d;
            if ( ((a.Top < b.Top) || ( b.isEmpty() == true)) && (a.isEmpty()==false))
            {
                d = a.pop();
                if( d != null)
                {
                    b.push(d);
                }
            }
            else
            {
                d = b.pop();
                if( d != null)
                {
                    a.push(d);
                }
            }
        }

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
