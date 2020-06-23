using System;

namespace ItemShop 
{
    class Program
    {
        static void Main(string[] args)
        {
            const short TAM = 5;
            ShopController controller = new ShopController();
            PlayerController player = new PlayerController();
            Mochila mochila = new Mochila(5);

            player.PlayerInicio();
            controller.InicializarInventario(TAM);
            controller.MostrarInventario();
            controller.ComprarItem(player.OroInicial,mochila);
            

            
            
        }
    }

}