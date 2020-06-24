using System;

namespace ItemShop
{
    class Mochila
    {
        private Items i;
        private const short TAM = 5;
        private Items[] mochila;
        //Constructor
        public Mochila()
        {
            mochila = new Items[TAM];

            for (int i = 0; i < mochila.Length; i++)
            {
                mochila[i] = null;
            }
        }
        //Indexador
        public Items this[int posicion]
        {
            set
                {
                mochila[posicion] = value;
                }
            get
                {
                return mochila[posicion];
                }
        }

        public int ComprobarEspacioMochila(Items[] a)
        {
            //Usar un booleano que retorne true
            int lugarDisponible=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == null)
                {
                    lugarDisponible = i;
                    Console.WriteLine("Hay lugar disponible en la posicion:{0}",i);
                    break;
                }
                else
                {
                    Console.WriteLine("No hay lugar disponible");
                }
            }
            return lugarDisponible;
        }

        public void VerMochila(Items[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] != null)
                {
                    Console.Write(i + ") ");
                        m[i].VerItem();
                }
                else 
                {
                    Console.WriteLine(i + ") Vacio");
                }
            }
        }

    }
}