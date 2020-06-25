using System;

namespace ItemShop
{
    class Mochila
    {
        private Items i;
        private const short TAM = 5;
        private Items[] mochila;
        private bool hayEspacio;
        //Constructor
        public Mochila()
        {
            mochila = new Items[TAM];
            for (int i = 0; i < mochila.Length; i++)
            {
                mochila[i] = null;
            }

            hayEspacio = false;
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
            Console.ReadLine();
        }
        public bool ComprobarEspacioMochila(Items[] a)
        {
            //Usar un booleano que retorne true
            int lugarDisponible=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == null)
                {
                    lugarDisponible = i;
                    hayEspacio = true;
                    //Console.WriteLine("Hay lugar disponible en la posicion:{0}",i);
                    break;
                }
                else
                {
                    //Console.WriteLine("No hay lugar disponible");
                    hayEspacio = false;
                }
            }
            //Pregunta por el var booleana
            if (!hayEspacio)
            {
                Console.WriteLine("La mochila esta llena");
                VerMochila(mochila);
            }
            else 
            {
                Console.WriteLine("Hay espacio en la mochila");
            }
            return hayEspacio;
        }
    }
}