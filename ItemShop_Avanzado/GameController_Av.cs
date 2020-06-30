using System;
namespace ItemShop
{
    class GameController_Av
    {
        public void Iniciador() 
        {
            const short TAM = 5;
            ShopController controller = new ShopController();
            PlayerController playerControl = new PlayerController();
            Mochila mochila = new Mochila();
            bool hayEspacioMain;
            char salir;
            short lugarDisponibleMain = 0;
            Player player = new Player();
            Items[] mochil = new Items[TAM];
            int oro = 0;

            oro = playerControl.PlayerInicio();
            controller.InicializarInventario(TAM);

            //Ciclo Menu
            do
            {
                controller.MostrarInventario();
                controller.FiltroShop();
                //Hay espacio tiene que ser por referencia para poder mandar posicion
                hayEspacioMain = mochila.ComprobarEspacioMochila(mochil, ref lugarDisponibleMain);//resive el true del metodo
                /*Usar variable local para traer el get del oro al iniciar y usara esa pq cuando llama al metodo get no esta o setear por referencia*/
                oro = controller.ComprarItem(mochil, hayEspacioMain, oro, lugarDisponibleMain);
                Console.WriteLine(("").PadRight(24, '-'));


                mochila.VerMochila(mochil);
                Console.WriteLine("Desea salir del menu de compra?");
                Console.WriteLine("y/n");
                salir = Convert.ToChar(Console.ReadLine());
            } while (salir == 'n');
        }
    }
}
