using ItemShop;
using System;

namespace ItemsShop
{
    class Mochila
    {
        Items[] mochila;
        public Mochila(int tam, ITEMS tipo)
        {
            mochila = new Items[tam];
        }
        public bool ComprobarEspacioMochila()
        {
            bool lugarDisponible = false;
            for (int i = 0; i < mochila.Length; i++)
            {
                if (mochila[i] == null)
                {
                    lugarDisponible = true;
                }
                else
                {
                    lugarDisponible = false;
                }
            }
            return lugarDisponible;
        }
        public void VerMochila(int t)
        {
            mochila = new Items[t];
            for (int i = 0; i < mochila.Length; i++)
            {
                Console.WriteLine(mochila[i]);
            }
        }
    }
}
