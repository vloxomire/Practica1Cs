using System;

namespace ItemShop
{
    class Player
    {
        const int TAM = 4; 
        private string nombre;
        private int oro;
        Random random;
        Item[] mochila;
        public void NombrePlayer() 
        {
            Console.WriteLine("Ingrese su nombre");
            nombre =Console.ReadLine();
        }
        public void OroRandom() 
        {
            oro = random.Next(250,1);
            Console.WriteLine("El (0) tiene (1) oro",nombre,oro);
        }
        public void ComprobarEspacioMochila(int t) 
        {
            mochila = new Item[TAM];
            for (int i = 0; i < mochila.Length; i++)
            {
                
            }
        }
        public void VerMochila(int t)
        {
            mochila = new Item[TAM];
            for (int i = 0; i < mochila.Length; i++)
            {
                Console.WriteLine(mochila[i]);
            }
        }
        public void ComprarItem(int oro,Item[] mochila) 
        {

            
        }
    }
}
