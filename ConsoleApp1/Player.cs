using System;

namespace ItemShop
{
    class Player
    {
<<<<<<< HEAD
        private string nombre;
        private int oro;

        public Player()
        {
            nombre = "Jugador";
            oro = 0;
        }
        public void SetNombre(string nom) 
        {
            this.nombre = nom;
        }
        public void SetOro(int or) 
        {
            this.oro = or;
        }
        public string GetNombre() 
        {
            return nombre;
        }
        public int GetOro() 
        {
            return oro; 
        }
    }
}
=======
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
>>>>>>> 2176f1b46991b533968eeaf70bbbc64b99163a2c
