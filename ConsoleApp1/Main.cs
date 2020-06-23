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

            player.PlayerInicio();
            controller.InicializarInventario(TAM);
            controller.MostrarInventario();
            

            
            
        }
    }

}