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
            char salir;
            Player player = new Player();
            Items[] mochil=new Items [TAM];

            playerControl.PlayerInicio();
            controller.InicializarInventario(TAM);
            
            //Ciclo Menu
            do
            {
                controller.MostrarInventario();
                espacio = mochila.ComprobarEspacioMochila(mochil);
                controller.ComprarItem(mochil, espacio);
                Console.WriteLine(("").PadRight(24, '-'));
                mochila.VerMochila(mochil);
                Console.WriteLine("Desea salir del menu de compra?");
                Console.WriteLine("y/n");
                salir = Convert.ToChar(Console.ReadLine());
            } while (salir=='n');
            
            
        }
    }

}