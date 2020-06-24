using ItemShop;
using System;
using System.Dynamic;

namespace ItemShop
{
    class Mochila
    {
        Items[] mochila;
        //Constructor
        public Mochila()
        {
            mochila = new Items[5];
            for (int i = 0; i < mochila.Length; i++)
            {
                mochila[i] = null;
            }
        }
        public Items GetMochila() 
        {
            return mochila[];
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
        public void VerMochila()
        {
            mochila = new Items[5];
            for (int i = 0; i < mochila.Length; i++)
            {
                Console.WriteLine(mochila[i]);
            }
        }
    }
}
