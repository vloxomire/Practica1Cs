using System;

namespace ItemShop 
{
    class Program
    {
        static void Main(string[] args)
        {
            const short TAM = 5;
            ShopController controller = new ShopController();
            PlayerController playerControl = new PlayerController();
            Mochila mochila = new Mochila();
            int espacio;
            Player player = new Player();
            Items[] mochil=new Items [TAM];

            playerControl.PlayerInicio();
            controller.InicializarInventario(TAM);
            controller.MostrarInventario();
            //Ciclo Menu
            do
            {
                espacio = mochila.ComprobarEspacioMochila(mochil);
                controller.ComprarItem(mochil, espacio);
                Console.Clear();
            } while (espacio<TAM);
            
            
        }
    }

}