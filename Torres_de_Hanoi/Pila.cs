using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; } //representa la quantitat de palos que hi ha en una pila
        public int Top { get; set; } //representa el disco que està dalt de tot de la pila
        public List<Disco> Elementos { get; set; } //representa el numero de discos que hi ha en una pila


        /* TODO: Implementar métodos */
        public Pila()
        {

        }

        public void push(Disco d) //permet colocar un disco en una pila
        {
            Elementos.Add(d);
            Size++;
            Top = d.Valor;
        }

        public Disco pop() //permet extraure el disco superior de una pila i l'eliminem
        {
            Disco borrat = Elementos[Size-1];

            Elementos.Remove(Elementos[Size - 1]);
            Size--;
            Top--;
            return borrat;
        }                

        public bool isEmpty() //ens informa si una fila està buida
        {
            if ( Size == 0)
            {
                return true;
            }
            else{
                return false;
            }
        }

    }
}
